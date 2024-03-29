﻿using NTwain;
using NTwain.Data;
using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Tesseract;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Bson;

namespace Sample.Winform
{

    public partial class TestForm : Form
    {
        Image img;
        TwainSession _twain;
        bool _stopScan;
        bool _loadingCaps;
        string ocrOutput;
        static string configJson = File.ReadAllText("properties/config.json");
        JObject configObj = JObject.Parse(configJson);
        HttpClientHandler _handler;
        HttpClient _client;
        static string propertiesJson = File.ReadAllText("properties/properties.json");
        JObject propertiesObj = JObject.Parse(propertiesJson);

        public TestForm()
        {
            _handler = new HttpClientHandler { CookieContainer = new CookieContainer() };
            _client = new HttpClient(_handler);
            InitializeComponent();
        }

        public string extrairDados(string ocrtext)
        {
            string text;
            string tipo;

            text = ocrtext.ToUpper();
            text = ocrtext.Replace("\n", "");

            int tipo_chassi = text.IndexOf("GRAVAR O CHASSI");
            int tipo_motor = text.IndexOf("GRAVAR O NUMERO");
            int placa_index = text.IndexOf("PLACA");
            int cpf_index = text.IndexOf("CPF");
            int cgc_index = text.IndexOf("CGC");
            int propriedade_index = text.IndexOf("PROPRIEDADE");
            int proprietario_index = text.IndexOf("PROPRIETARIO");
            int renavam_index = text.IndexOf("RENAVAM");
            int chassi_index = text.IndexOf("CHASSI:");
            int motor_index = text.IndexOf("MOTOR");
            int ano_index = text.IndexOf("ANO FABRICACAO");
            int marca_index = text.IndexOf("MARCA/MODELO");
            int especie_index = text.IndexOf("ESPECIE/TIPO");
            int observacao_index = text.IndexOf("OBSERVACAO");

            if (cpf_index <= 0) cpf_index = cgc_index - 4;


            if (tipo_chassi > 0)
            {
                tipo = "REABERTURA DE NUMERO DO CHASSI";
            }
            else if (tipo_motor > 0)
            {
                tipo = "REABERTURA DE NUMERO DO MOTOR";
            }
            else
            {
                tipo = "REABERTURA DE NUMERO";
            }

            string cpf = new Regex(@"[^\d]").Replace(text.Substring(cpf_index + 11, 14), "");
            string placa = text.Substring(placa_index + 7, 7);
            string renavam = new Regex(@"[^\d]").Replace(text.Substring(renavam_index + 9, 11), "");
            string chassi = text.Substring(chassi_index + 8, 17);
            string ano = text.Substring(ano_index + 16, 11);
            string especie = text.Substring(especie_index + 14, 22);
            string marca = text.Substring(marca_index + 13, especie_index - marca_index - 13);
            string motor = text.Substring(motor_index + 6, 9);

            string nome = "";
            if (propriedade_index > 0 && cpf_index > 0)
            {
                nome = text.Substring(propriedade_index + 15, cpf_index - propriedade_index - 15);
            }
            if (proprietario_index > 0 && observacao_index > 0)
            {
                nome = text.Substring(proprietario_index + 13, observacao_index - proprietario_index - 13);
            }

            textBoxCPF.Text = cpf;
            textBoxNome.Text = nome;
            textBoxDescricao.Text = tipo;

            return
                tipo + "\r\n" +
                "NO VEICULO DE PLACA: " + (placa_index > 0 ? placa : "") + "\r\n" +
                "RENAVAM: " + (renavam_index > 0 ? renavam : "") + "\r\n" +
                "MARCA / MODELO: " + (marca_index > 0 ? marca : "") + "\r\n" +
                "ESPECIE / TIPO: " + (especie_index > 0 ? especie : "") + "\r\n" +
                "ANO DE FABRICACAO: " + (ano_index > 0 ? ano : "") + "\r\n" +
                "CHASSI: " + (chassi_index > 0 ? chassi : "") + "\r\n" +
                (motor_index > 0 ? "NUMERO DO MOTOR: " + motor + "\r\n" : "");
        }

        public string ExtrairChaveDANFe(string ocrtext)
        {
            string chave = "";
            string pattern = @"\b(\d{4} \d{4} \d{4} \d{4} \d{4} \d{4} \d{4} \d{4} \d{4} \d{4} \d{4})\b";
            Regex regex = new Regex(pattern);

            Match match = regex.Match(ocrtext);
            if (match.Success)
            {
                chave = match.Groups[1].Value.Replace(" ", "");
            }

            return chave;
        }

        public void ProcessarDados(string ocrtext)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                observacao.Text = extrairDados(ocrtext);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                observacao.Text = ExtrairChaveDANFe(ocrtext);
            }
            else
            {
                textBoxCPF.Text = "";
                textBoxNome.Text = "";
                observacao.Text = ocrtext;
            }
        }

        public void IniciarOCR()
        {
            //TODO configurar quando usar o bmp pelo picturebox ou pela variavel img
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Pix pic = PixConverter.ToPix(bmp);
            var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default);
            var page = engine.Process(pic);
            ocrOutput = page.GetText();
            ProcessarDados(ocrOutput);
        }

        #region setup & cleanup

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetupTwain();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_twain != null)
            {
                if (e.CloseReason == CloseReason.UserClosing && _twain.State > 4)
                {
                    e.Cancel = true;
                }
                else
                {
                    CleanupTwain();
                }
            }
            base.OnFormClosing(e);
        }

        private void SetupTwain()
        {
            var appId = TWIdentity.CreateFromAssembly(DataGroups.Image, Assembly.GetEntryAssembly());
            _twain = new TwainSession(appId);
            _twain.StateChanged += (s, e) =>
            {
                PlatformInfo.Current.Log.Info("State changed to " + _twain.State + " on thread " + Thread.CurrentThread.ManagedThreadId);
            };
            _twain.TransferError += (s, e) =>
            {
                PlatformInfo.Current.Log.Info("Got xfer error on thread " + Thread.CurrentThread.ManagedThreadId);
            };
            _twain.DataTransferred += (s, e) =>
            {
                PlatformInfo.Current.Log.Info("Transferred data event on thread " + Thread.CurrentThread.ManagedThreadId);

                // example on getting ext image info
                var infos = e.GetExtImageInfo(ExtendedImageInfo.Camera).Where(it => it.ReturnCode == ReturnCode.Success);
                foreach (var it in infos)
                {
                    var values = it.ReadValues();
                    PlatformInfo.Current.Log.Info(string.Format("{0} = {1}", it.InfoID, values.FirstOrDefault()));
                    break;
                }

                // handle image data
                if (e.NativeData != IntPtr.Zero)
                {
                    var stream = e.GetNativeImageStream();
                    if (stream != null)
                    {
                        img = Image.FromStream(stream);
                    }
                }
                else if (!string.IsNullOrEmpty(e.FileDataPath))
                {
                    img = new Bitmap(e.FileDataPath);
                }
                if (img != null)
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        if (pictureBox1.Image != null)
                        {
                            pictureBox1.Image.Dispose();
                            pictureBox1.Image = null;
                        }
                        pictureBox1.Image = img;
                    }));
                }
            };
            _twain.SourceDisabled += (s, e) =>
            {
                PlatformInfo.Current.Log.Info("Source disabled event on thread " + Thread.CurrentThread.ManagedThreadId);
                this.BeginInvoke(new Action(() =>
                {
                    Cursor.Current = Cursors.WaitCursor;
                    btnStartCapture.Enabled = true;
                    panelOptions.Enabled = true;
                    LoadSourceCaps();
                    IniciarOCR();
                    Cursor.Current = Cursors.Arrow;
                }));
            };
            _twain.TransferReady += (s, e) =>
            {
                PlatformInfo.Current.Log.Info("Transferr ready event on thread " + Thread.CurrentThread.ManagedThreadId);
                e.CancelAll = _stopScan;
            };

            // either set sync context and don't worry about threads during events,
            // or don't and use control.invoke during the events yourself
            PlatformInfo.Current.Log.Info("Setup thread = " + Thread.CurrentThread.ManagedThreadId);
            _twain.SynchronizationContext = SynchronizationContext.Current;
            if (_twain.State < 3)
            {
                // use this for internal msg loop
                _twain.Open();
                // use this to hook into current app loop
                //_twain.Open(new WindowsFormsMessageLoopHook(this.Handle));
            }
        }

        private void CleanupTwain()
        {
            if (_twain.State == 4)
            {
                _twain.CurrentSource.Close();
            }
            if (_twain.State == 3)
            {
                _twain.Close();
            }

            if (_twain.State > 2)
            {
                // normal close down didn't work, do hard kill
                _twain.ForceStepDown(2);
            }
        }

        #endregion

        #region toolbar

        private void btnSources_DropDownOpening(object sender, EventArgs e)
        {
            if (btnSources.DropDownItems.Count == 2)
            {
                ReloadSourceList();
            }
        }

        private void reloadSourcesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReloadSourceList();
        }

        private void ReloadSourceList()
        {
            if (_twain.State >= 3)
            {
                while (btnSources.DropDownItems.IndexOf(sepSourceList) > 0)
                {
                    var first = btnSources.DropDownItems[0];
                    first.Click -= SourceMenuItem_Click;
                    btnSources.DropDownItems.Remove(first);
                }
                foreach (var src in _twain)
                {
                    var srcBtn = new ToolStripMenuItem(src.Name);
                    srcBtn.Tag = src;
                    srcBtn.Click += SourceMenuItem_Click;
                    srcBtn.Checked = _twain.CurrentSource != null && _twain.CurrentSource.Name == src.Name;
                    btnSources.DropDownItems.Insert(0, srcBtn);
                }
            }
        }

        void SourceMenuItem_Click(object sender, EventArgs e)
        {
            // do nothing if source is enabled
            if (_twain.State > 4) { return; }

            if (_twain.State == 4) { _twain.CurrentSource.Close(); }

            foreach (var btn in btnSources.DropDownItems)
            {
                var srcBtn = btn as ToolStripMenuItem;
                if (srcBtn != null) { srcBtn.Checked = false; }
            }

            var curBtn = (sender as ToolStripMenuItem);
            var src = curBtn.Tag as DataSource;
            if (src.Open() == ReturnCode.Success)
            {
                curBtn.Checked = true;
                btnStartCapture.Enabled = true;
                LoadSourceCaps();
            }
        }

        private void btnStartCapture_Click(object sender, EventArgs e)
        {
            if (_twain.State == 4)
            {
                //_twain.CurrentSource.CapXferCount.Set(4);

                _stopScan = false;

                if (_twain.CurrentSource.Capabilities.CapUIControllable.IsSupported)//.SupportedCaps.Contains(CapabilityId.CapUIControllable))
                {
                    // hide scanner ui if possible
                    if (_twain.CurrentSource.Enable(SourceEnableMode.NoUI, false, this.Handle) == ReturnCode.Success)
                    {
                        btnStartCapture.Enabled = false;
                        panelOptions.Enabled = false;
                    }
                }
                else
                {
                    if (_twain.CurrentSource.Enable(SourceEnableMode.ShowUI, true, this.Handle) == ReturnCode.Success)
                    {
                        btnStartCapture.Enabled = false;
                        panelOptions.Enabled = false;
                    }
                }
            }
        }


        #endregion

        #region cap control


        private void LoadSourceCaps()
        {
            var src = _twain.CurrentSource;
            _loadingCaps = true;

            //var test = src.SupportedCaps;

            if (groupDepth.Enabled = src.Capabilities.ICapPixelType.IsSupported)
            {
                LoadDepth(src.Capabilities.ICapPixelType);
            }
            if (groupDPI.Enabled = src.Capabilities.ICapXResolution.IsSupported && src.Capabilities.ICapYResolution.IsSupported)
            {
                LoadDPI(src.Capabilities.ICapXResolution);
            }
            if (groupSize.Enabled = src.Capabilities.ICapSupportedSizes.IsSupported)
            {
                LoadPaperSize(src.Capabilities.ICapSupportedSizes);
            }
            _loadingCaps = false;
        }

        private void LoadPaperSize(ICapWrapper<SupportedSize> cap)
        {
            var list = cap.GetValues().ToList();
            comboSize.DataSource = list;
            var cur = cap.GetCurrent();
            if (list.Contains(cur))
            {
                comboSize.SelectedItem = cur;
            }
            var labelTest = cap.GetLabel();
            if (!string.IsNullOrEmpty(labelTest))
            {
                groupSize.Text = labelTest;
            }
        }

        private void LoadDPI(ICapWrapper<TWFix32> cap)
        {
            // only allow dpi of certain values for those source that lists everything
            var list = cap.GetValues().Where(dpi => (dpi % 50) == 0).ToList();
            comboDPI.DataSource = list;

            var sel = (TWFix32)300; //Seta DPI padrão
            _twain.CurrentSource.Capabilities.ICapXResolution.SetValue(sel);
            _twain.CurrentSource.Capabilities.ICapYResolution.SetValue(sel);

            var cur = cap.GetCurrent();

            if (list.Contains(cur))
            {
                comboDPI.SelectedItem = cur;
            }
        }

        private void LoadDepth(ICapWrapper<PixelType> cap)
        {
            var list = cap.GetValues().ToList();
            comboDepth.DataSource = list;
            var cur = cap.GetCurrent();
            if (list.Contains(cur))
            {
                comboDepth.SelectedItem = cur;
            }
            var labelTest = cap.GetLabel();
            if (!string.IsNullOrEmpty(labelTest))
            {
                groupDepth.Text = labelTest;
            }
        }

        private void comboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_loadingCaps && _twain.State == 4)
            {
                var sel = (SupportedSize)comboSize.SelectedItem;
                _twain.CurrentSource.Capabilities.ICapSupportedSizes.SetValue(sel);
            }
        }

        private void comboDepth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_loadingCaps && _twain.State == 4)
            {
                var sel = (PixelType)comboDepth.SelectedItem;
                _twain.CurrentSource.Capabilities.ICapPixelType.SetValue(sel);
            }
        }

        private void comboDPI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_loadingCaps && _twain.State == 4)
            {
                var sel = (TWFix32)comboDPI.SelectedItem;
                _twain.CurrentSource.Capabilities.ICapXResolution.SetValue(sel);
                _twain.CurrentSource.Capabilities.ICapYResolution.SetValue(sel);
            }
        }

        #endregion

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "arquivo")
            {
                string file = openFileDialog1.FileName;
                Cursor.Current = Cursors.WaitCursor;

                if (file.EndsWith(".pdf"))
                {
                    FileStream pdfStream = new FileStream(file, FileMode.Open);
                    byte[] png = Freeware.Pdf2Png.Convert(pdfStream, 1);
                    pdfStream.Close();
                    img = Image.FromStream(new MemoryStream(png));
                }
                else if (file.EndsWith(".jpg") || file.EndsWith(".jpeg") || file.EndsWith(".png"))
                {
                    img = Image.FromFile(openFileDialog1.FileName);
                }
                else
                {
                    return; //Encerra caso não tenha carregado uma imagem válida ou pdf
                }

                pictureBox1.Image = img;

                IniciarOCR();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    int x = (int)Math.Round(pictureBox1.Image.Width * 0.1);
                    int y = (int)Math.Round(pictureBox1.Image.Height * 0.1);
                    int largura = (int)Math.Round(pictureBox1.Image.Width * 0.7);
                    int altura = (int)Math.Round(pictureBox1.Image.Height * 0.7);
                    Rectangle CropRectangle = new Rectangle(x, y, largura, altura);
                    pictureBox1.Image = CropImage(pictureBox1.Image, CropRectangle);
                }
                else
                {
                    pictureBox1.Image = img;
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                saveFileDialog1.Title = "Salvar imagem";
                saveFileDialog1.Filter = "Jpeg Image|*.jpg";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    img.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fs.Close();
                }
            }

        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            if (configObj["selectScan0"].Equals(true))
            {
                foreach (var item in _twain)
                {
                    if (item.Open() == ReturnCode.Success)
                    {
                        btnStartCapture.Enabled = true;
                        LoadSourceCaps();
                        break;
                    }
                }
            }
        }
        private Image CropImage(Image img, Rectangle rect)
        {
            return ((Bitmap)img).Clone(rect, img.PixelFormat);
        }

        private void textBoxCPF_Click(object sender, EventArgs e)
        {
            if (textBoxCPF.TextLength > 0)
            {
                Clipboard.SetText(textBoxCPF.Text);
            }
        }

        private void textBoxNome_Click(object sender, EventArgs e)
        {
            if (textBoxNome.TextLength > 0)
            {
                Clipboard.SetText(textBoxNome.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ProcessarDados(ocrOutput);
            }
        }

        private void textBoxCPF_MouseMove(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxCPF, "Clique para copiar");
        }

        private void textBoxNome_MouseMove(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxNome, "Clique para copiar");
        }

        private void btnCopyOutput_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(observacao.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxUF.Clear();
            textBoxCidade.Clear();
            textBoxCPF.Clear();
            textBoxNome.Clear();
            textBoxCEP.Clear();
            textBoxEndereco.Clear();
            textBoxDescricao.Clear();
            textBoxValor.Clear();
            observacao.Clear();
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCamposIniciais() && emitirNotaFiscalAsync())
                {
                    MessageBox.Show($"Nota fiscal emitida com sucesso!");
                }
                else
                {
                    MessageBox.Show($"Não foi possível emitir a nota fiscal!");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Erro na requisição: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        Boolean validarCamposIniciais()
        {
            if (textBoxCPF.Text.Length < 11) { throw new Exception("CPF inválido!"); }
            if (textBoxNome.Text.Length < 6) { throw new Exception("Nome inválido!"); }
            if (textBoxCEP.Text.Length < 8) { throw new Exception("CEP inválido!"); }

            return true;
        }

        Boolean validarCamposFinais()
        {
            if (textBoxCPF.Text.Length < 11) { throw new Exception("CPF inválido!"); }
            if (textBoxNome.Text.Length < 6) { throw new Exception("Nome inválido!"); }
            if (textBoxCEP.Text.Length < 8) { throw new Exception("CEP inválido!"); }
            if (textBoxUF.Text.Length < 2) { throw new Exception("Estado inválido!"); }
            if (textBoxCidade.Text.Length < 2) { throw new Exception("Cidade inválida!"); }
            if (textBoxEndereco.Text.Length < 2) { throw new Exception("Endereço inválido!"); }
            if (textBoxDescricao.Text.Length < 4) { throw new Exception("Descrição inválida!"); }
            if (textBoxValor.Text.Length < 2) { throw new Exception("Valor inválido!"); }
            return true;
        }

        static async Task<string> PostHttpRequest(string url, HttpContent content)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return responseBody;
                }
                else
                {
                    MessageBox.Show($"Erro na requisição: {response.StatusCode}");
                    return null;
                }
            }
        }

        void fazerLogin()
        {
            string tokenUrl = propertiesObj["token"]["url"].ToString();
            string tokenParams = propertiesObj["token"]["params"].ToString();
            string loginUrl = propertiesObj["login"]["url"].ToString();
            string loginParams = propertiesObj["login"]["params"].ToString();
            //token
            var tokenRequest = new StringContent(tokenParams, Encoding.UTF8, "application/json");
            HttpResponseMessage tokenResponse = _client.PostAsync(tokenUrl, tokenRequest).Result;
            tokenResponse.EnsureSuccessStatusCode();
            //string tokenContent = await tokenResponse.Content.ReadAsStringAsync();

            //login 
            var loginRequest = new StringContent(loginParams, Encoding.UTF8, "application/x-www-form-urlencoded");
            HttpResponseMessage loginResponse = _client.PostAsync(loginUrl, loginRequest).Result;
            loginResponse.EnsureSuccessStatusCode();
            //string loginContent = await loginResponse.Content.ReadAsStringAsync();
        }

        string consultarPessoa()
        {
            string obterPessoaUrl = propertiesObj["emissaoNF"]["obterPessoa"].ToString();
            var obterPessoaRequest = new StringContent($"documento={textBoxCPF.Text}", Encoding.UTF8, "application/x-www-form-urlencoded");
            HttpResponseMessage obterPessoaResponse = _client.PostAsync(obterPessoaUrl, obterPessoaRequest).Result;
            obterPessoaResponse.EnsureSuccessStatusCode();
            string obterPessoaContent = obterPessoaResponse.Content.ReadAsStringAsync().Result;
            if (obterPessoaContent == null || obterPessoaContent.Equals(""))
            {
                MessageBox.Show("Pessoa não cadastrada!");
                return null;
            }
            JObject pessoaObj = JObject.Parse(obterPessoaContent);
            textBoxNome.Text = pessoaObj["NomeRazaoSocial"].ToString();
            if (pessoaObj["EnderecosPessoa"] != null && pessoaObj["EnderecosPessoa"].Type == JTokenType.Array && pessoaObj["EnderecosPessoa"].Any())
            {
                textBoxCEP.Text = pessoaObj["EnderecosPessoa"][0]["Cep"].ToString();
            }
            string pessoaId = pessoaObj["Id"].ToString();
            return pessoaId;
        }

        string cadastrarPessoa()
        {
            string cadastrarPessoaUrl = propertiesObj["emissaoNF"]["cadastrarPessoa"].ToString();
            JObject enderecoObj = obterEndereco();

            string pessoaJson = @"{
                    ""IdTipoPessoa"": -1,
                    ""CpfCnpj"": """ + textBoxCPF.Text + @""",
                    ""NomeRazaoSocial"": """ + textBoxNome.Text + @""",
                    ""IdPaisNaturalidade"": """ + enderecoObj["IdPais"] + @""" ,
                    ""IdEstadoNaturalidade"": """ + enderecoObj["IdEstado"] + @""" ,
                    ""IdMunicipioNaturalidade"": """ + enderecoObj["IdMunicipio"] + @""" ,
                    ""IdBairro"": """ + enderecoObj["IdBairro"] + @""" ,
                    ""Bairro"": """ + enderecoObj["NomeBairro"] + @""" ,
                    ""IdTipoLogradouro"":""" + enderecoObj["IdTipoLogradouro"] + @""" ,
                    ""IdLogradouro"":""" + enderecoObj["IdLogradouro"] + @""" ,
                    ""Logradouro"": """ + enderecoObj["Logradouro"] + @""" ,
                    ""IdEnderecamentoPostal"": """ + enderecoObj["Id"] + @""" ,
                    ""Cep"": """ + enderecoObj["Cep"] + @""" ,
                    ""Municipio"": """ + enderecoObj["NomeMunicipio"] + @""" ,
                    ""Estado"": """ + enderecoObj["NomeEstado"] + @""" ,
                    ""IdSexo"": null,""IdTipoTelefone"": null,""Ddi"": null,""Ddd"": null,""NumeroTelefone"": null,""Ramal"": """",""Email"": """",""IdDistrito"": null,""Distrito"": """",""LocalNaturalidadeEstrangeiro"": """",""Numero"": """",""Complemento"":"""",""Pais"": ""BRASIL""
                }";
            var cadastrarPessoaRequest = new StringContent("values=" + pessoaJson, Encoding.UTF8, "application/x-www-form-urlencoded");
            HttpResponseMessage cadastrarPessoaResponse = _client.PostAsync(cadastrarPessoaUrl, cadastrarPessoaRequest).Result;
            cadastrarPessoaResponse.EnsureSuccessStatusCode();
            string pessoaId = cadastrarPessoaResponse.Content.ReadAsStringAsync().Result;
            MessageBox.Show("Pessoa cadastrada com sucesso! Id: " + pessoaId);
            return pessoaId;
        }

        JObject obterEndereco()
        {
            string obterEnderecoAsyncUrl = propertiesObj["emissaoNF"]["obterEnderecoAsync"].ToString();
            //string obterEnderecoCompletedUrl = obj["emissaoNF"]["obterEnderecoCompleted"].ToString();
            string obterEnderecoUrl = propertiesObj["emissaoNF"]["obterEndereco"].ToString();
            string obterMunicipioUrl = propertiesObj["emissaoNF"]["obterMunicipio"].ToString();
            JObject enderecoObj = null;
            JObject municipioObj = null;

            //obter endereco
            var obterEnderecoAsyncRequest = new StringContent($"cep={textBoxCEP.Text}&permitirCepDeOutrosMunicipios=true&cadastrarCep=true", Encoding.UTF8, "application/x-www-form-urlencoded");
            HttpResponseMessage obterEnderecoAsyncResponse = _client.PostAsync(obterEnderecoAsyncUrl, obterEnderecoAsyncRequest).Result;
            obterEnderecoAsyncResponse.EnsureSuccessStatusCode();
            string obterEnderecoAsyncContent = obterEnderecoAsyncResponse.Content.ReadAsStringAsync().Result;
            Thread.Sleep(5000); //TODO melhorar
            var obterEnderecoRequest = new StringContent($"id={obterEnderecoAsyncContent}", Encoding.UTF8, "application/x-www-form-urlencoded");
            HttpResponseMessage obterEnderecoResponse = _client.PostAsync(obterEnderecoUrl, obterEnderecoRequest).Result;
            obterEnderecoResponse.EnsureSuccessStatusCode();
            string obterEnderecoContent = obterEnderecoResponse.Content.ReadAsStringAsync().Result;
            enderecoObj = JObject.Parse(obterEnderecoContent);

            //obtendo municipio apenas pra pegar CodigoIbge
            var obterMunicipioRequest = new StringContent($"idMunicipio={enderecoObj["IdMunicipio"]}&idEstado={enderecoObj["IdEstado"]}&page=1&start=0&limit=10", Encoding.UTF8, "application/x-www-form-urlencoded");
            HttpResponseMessage obterMunicipioResponse = _client.PostAsync(obterMunicipioUrl, obterMunicipioRequest).Result;
            obterMunicipioResponse.EnsureSuccessStatusCode();
            string obterMunicipioContent = obterMunicipioResponse.Content.ReadAsStringAsync().Result;
            municipioObj = JObject.Parse(obterMunicipioContent);
            enderecoObj["CodigoIbge"] = municipioObj["Dados"][0]["CodigoIbge"];

            textBoxCEP.Text = textBoxCEP.Text.Replace(" - ", "");
            textBoxUF.Text = enderecoObj["NomeEstado"].ToString();
            textBoxCidade.Text = enderecoObj["NomeMunicipio"].ToString().ToUpper();
            if (enderecoObj["DescricaoEndereco"].ToString().Length > 1)
            {
                textBoxEndereco.Text = enderecoObj["DescricaoEndereco"].ToString().ToUpper() + ", ";
            }

            return enderecoObj;
        }
        Boolean emitirNotaFiscalAsync()
        {

            fazerLogin();

            string emitirNFUrl = propertiesObj["emissaoNF"]["emitirNF"].ToString();
            string emitirNFCompletedUrl = propertiesObj["emissaoNF"]["emitirNFCompleted"].ToString();
            string nfBody = propertiesObj["emissaoNF"]["body"].ToString();
            string pessoaId = consultarPessoa();
            JObject enderecoObj = obterEndereco();

            if (pessoaId == null || pessoaId.Equals(""))
            {
                DialogResult confirmarCadastroPessoa = MessageBox.Show("Pessoa não cadastrada. Cadastrar nova pessoa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmarCadastroPessoa == DialogResult.Yes)
                {
                    pessoaId = cadastrarPessoa();
                }
                else
                {
                    return false;
                }
            }
            else
            {

            }

            //Emitir NF
            if (validarCamposFinais())
            {
                DateTime now = DateTime.Now;
                string dataAtual = now.ToString("yyyy-MM-ddTHH:mm:ss");

                string nfJson = nfBody + @"
                ""DataEmissao"":""" + dataAtual + @""",
                ""Observacao"":""" + observacao.Text + @""",
                ""IdPessoaTomador"":" + pessoaId + @",
                ""NomeRazaoSocialTomador"":""" + textBoxNome.Text.ToUpper() + @""",
                ""TipoPessoa"":1,
                ""CPFCNPJTomador"":""" + textBoxCPF.Text + @""",
                ""CepTomador"":""" + textBoxCEP.Text + @""",
                ""IdEnderecamentoPostal"":" + enderecoObj["Id"] + @",
                ""IdPais"":-31,
                ""CodigoPaisTomador"":1058,
                ""NomePaisTomador"":""BRASIL"",
                ""IdEstado"":" + enderecoObj["IdEstado"] + @",
                ""NomeEstadoTomador"":""" + enderecoObj["NomeEstado"] + @""",
                ""SiglaEstadoTomador"":""" + enderecoObj["SiglaEstado"] + @""",
                ""IdMunicipio"":" + enderecoObj["IdMunicipio"] + @",
                ""CodigoIbgeMunicipioTomador"":" + enderecoObj["CodigoIbge"] + @",
                ""NomeMunicipioTomador"":""" + textBoxCidade.Text + @""",
                ""DescricaoEndereco"":""" + textBoxEndereco.Text + @""",
                ""ValorTotalServicos"":" + textBoxValor.Text + @",
                ""ValorTotalLiquido"":" + textBoxValor.Text + @",
                ""BaseCalculoISSQN"":" + textBoxValor.Text + @",
                ""AliquotaISSQN"":5,
                ""TotalISSQNCalculado"":" + Int32.Parse(textBoxValor.Text) * 0.05 + @",
                ""Servicos"":[
                {
                    ""Servico"":""" + textBoxDescricao.Text + @""",
                    ""ValorUnitario"":" + textBoxValor.Text + @",
                    ""ValorBruto"":" + textBoxValor.Text + @",
                    ""ValorLiquido"":" + textBoxValor.Text + @",
                    ""Id"":0,""_TempId"":"""",""ValorDesconto"":0,""IdEstruturaPadraoCNAE"":null,""IdServicoLei116"":null,""DescricaoCNAE"":null,""DescricaoLei"":null,""Quantidade"":1,""FlPermiteTrocaMunInc"":false,""FlMunicipioIncidenciaTomador"":false,""IdEconomicoParceiro"":null,""IdRelacaoEconomicoParceiro"":null,""PercentualRetencao"":null,""ValorRetidoBaseCalculoISSQN"":0,""NomeRazaoSocialParceiro"":"""",""TipoPessoaParceiro"":"""",""CpfCnpjParceiro"":"""",""InscricaoMunicipalParceiro"":""""
                }
                ]
                }";

                DialogResult confirmarEmissao = MessageBox.Show("Confirmar emissão de nota fiscal?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmarEmissao == DialogResult.Yes)
                {
                    var emitirNfRequest = new StringContent(nfJson, Encoding.UTF8, "application/x-www-form-urlencoded");
                    HttpResponseMessage emitirNfResponse = _client.PostAsync(emitirNFUrl, emitirNfRequest).Result;
                    emitirNfResponse.EnsureSuccessStatusCode();
                    string emitirNfContent = emitirNfResponse.Content.ReadAsStringAsync().Result;

                    var emitirNfCompletedRequest = new StringContent($"id={emitirNfContent}", Encoding.UTF8, "application/x-www-form-urlencoded");
                    HttpResponseMessage emitirNfCompletedResponse = _client.PostAsync(emitirNFCompletedUrl, emitirNfCompletedRequest).Result;
                    emitirNfCompletedResponse.EnsureSuccessStatusCode();
                    string nfResult = emitirNfCompletedResponse.Content.ReadAsStringAsync().Result;
                    JObject nfResultJson = JObject.Parse(nfResult);
                    // verifica erros
                    if (nfResultJson["Dados"].Count() > 0)
                    {
                        MessageBox.Show("Erro: " + nfResult);
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }

            //fim da emissão. supostamente com sucesso.
            return true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (textBoxCPF.Text.Length < 11)
            {
                MessageBox.Show("CPF inválido!");
                return;
            }

            fazerLogin();
            consultarPessoa();
            if (textBoxCEP.Text.Length > 0)
            {
                obterEndereco();
            }
        }
    }
}
