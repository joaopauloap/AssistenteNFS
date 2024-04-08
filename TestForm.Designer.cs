namespace Sample.Winform
{
	partial class TestForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSources = new System.Windows.Forms.ToolStripDropDownButton();
            this.sepSourceList = new System.Windows.Forms.ToolStripSeparator();
            this.reloadSourcesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.btnSaveFile = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanelContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelCampos = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelCEP = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxCidade = new System.Windows.Forms.GroupBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.groupBoxEstado = new System.Windows.Forms.GroupBox();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.groupBoxCEP = new System.Windows.Forms.GroupBox();
            this.btnPesquisarCEP = new System.Windows.Forms.RadioButton();
            this.textBoxCEP = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelDescricao = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxValor = new System.Windows.Forms.GroupBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.groupBoxDescricao = new System.Windows.Forms.GroupBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelBotoesRodape = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEmitir = new System.Windows.Forms.Button();
            this.tableLayoutPanelCPF = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxCPF = new System.Windows.Forms.GroupBox();
            this.btnPesquisarPessoa = new System.Windows.Forms.RadioButton();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.groupBoxNome = new System.Windows.Forms.GroupBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelEndereco = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxNumero = new System.Windows.Forms.GroupBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.groupBoxBairro = new System.Windows.Forms.GroupBox();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.groupBoxEndereco = new System.Windows.Forms.GroupBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.groupBoxObservacoes = new System.Windows.Forms.GroupBox();
            this.observacao = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelOptions = new System.Windows.Forms.TableLayoutPanel();
            this.btnStartCapture = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupSize = new System.Windows.Forms.GroupBox();
            this.comboSize = new System.Windows.Forms.ComboBox();
            this.groupDPI = new System.Windows.Forms.GroupBox();
            this.comboDPI = new System.Windows.Forms.ComboBox();
            this.groupDepth = new System.Windows.Forms.GroupBox();
            this.comboDepth = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanelContainer.SuspendLayout();
            this.tableLayoutPanelCampos.SuspendLayout();
            this.tableLayoutPanelCEP.SuspendLayout();
            this.groupBoxCidade.SuspendLayout();
            this.groupBoxEstado.SuspendLayout();
            this.groupBoxCEP.SuspendLayout();
            this.tableLayoutPanelDescricao.SuspendLayout();
            this.groupBoxValor.SuspendLayout();
            this.groupBoxDescricao.SuspendLayout();
            this.tableLayoutPanelBotoesRodape.SuspendLayout();
            this.tableLayoutPanelCPF.SuspendLayout();
            this.groupBoxCPF.SuspendLayout();
            this.groupBoxNome.SuspendLayout();
            this.tableLayoutPanelEndereco.SuspendLayout();
            this.groupBoxNumero.SuspendLayout();
            this.groupBoxBairro.SuspendLayout();
            this.groupBoxEndereco.SuspendLayout();
            this.groupBoxObservacoes.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupSize.SuspendLayout();
            this.groupDPI.SuspendLayout();
            this.groupDepth.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(822, 913);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSources,
            this.btnOpenFile,
            this.btnSaveFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1582, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSources
            // 
            this.btnSources.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSources.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sepSourceList,
            this.reloadSourcesListToolStripMenuItem});
            this.btnSources.Image = ((System.Drawing.Image)(resources.GetObject("btnSources.Image")));
            this.btnSources.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSources.Name = "btnSources";
            this.btnSources.Size = new System.Drawing.Size(88, 29);
            this.btnSources.Text = "Scanner";
            this.btnSources.DropDownOpening += new System.EventHandler(this.btnSources_DropDownOpening);
            // 
            // sepSourceList
            // 
            this.sepSourceList.Name = "sepSourceList";
            this.sepSourceList.Size = new System.Drawing.Size(214, 6);
            // 
            // reloadSourcesListToolStripMenuItem
            // 
            this.reloadSourcesListToolStripMenuItem.Name = "reloadSourcesListToolStripMenuItem";
            this.reloadSourcesListToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.reloadSourcesListToolStripMenuItem.Text = "Recarregar lista";
            this.reloadSourcesListToolStripMenuItem.Click += new System.EventHandler(this.reloadSourcesListToolStripMenuItem_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(55, 29);
            this.btnOpenFile.Text = "Abrir";
            this.btnOpenFile.ToolTipText = "Abrir";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveFile.Image")));
            this.btnSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(63, 29);
            this.btnSaveFile.Text = "Salvar";
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "arquivo";
            // 
            // tableLayoutPanelContainer
            // 
            this.tableLayoutPanelContainer.AutoScroll = true;
            this.tableLayoutPanelContainer.AutoSize = true;
            this.tableLayoutPanelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelContainer.ColumnCount = 2;
            this.tableLayoutPanelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.83019F));
            this.tableLayoutPanelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.16981F));
            this.tableLayoutPanelContainer.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanelContainer.Controls.Add(this.tableLayoutPanelCampos, 1, 0);
            this.tableLayoutPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContainer.Location = new System.Drawing.Point(260, 32);
            this.tableLayoutPanelContainer.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelContainer.Name = "tableLayoutPanelContainer";
            this.tableLayoutPanelContainer.RowCount = 1;
            this.tableLayoutPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 921F));
            this.tableLayoutPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 921F));
            this.tableLayoutPanelContainer.Size = new System.Drawing.Size(1322, 921);
            this.tableLayoutPanelContainer.TabIndex = 0;
            // 
            // tableLayoutPanelCampos
            // 
            this.tableLayoutPanelCampos.ColumnCount = 1;
            this.tableLayoutPanelCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCampos.Controls.Add(this.tableLayoutPanelCEP, 0, 1);
            this.tableLayoutPanelCampos.Controls.Add(this.tableLayoutPanelDescricao, 0, 3);
            this.tableLayoutPanelCampos.Controls.Add(this.tableLayoutPanelBotoesRodape, 0, 5);
            this.tableLayoutPanelCampos.Controls.Add(this.tableLayoutPanelCPF, 0, 0);
            this.tableLayoutPanelCampos.Controls.Add(this.tableLayoutPanelEndereco, 0, 2);
            this.tableLayoutPanelCampos.Controls.Add(this.groupBoxObservacoes, 0, 4);
            this.tableLayoutPanelCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCampos.Location = new System.Drawing.Point(833, 2);
            this.tableLayoutPanelCampos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelCampos.Name = "tableLayoutPanelCampos";
            this.tableLayoutPanelCampos.RowCount = 6;
            this.tableLayoutPanelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.660378F));
            this.tableLayoutPanelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.660378F));
            this.tableLayoutPanelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.660378F));
            this.tableLayoutPanelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.660378F));
            this.tableLayoutPanelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.75471F));
            this.tableLayoutPanelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.603774F));
            this.tableLayoutPanelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCampos.Size = new System.Drawing.Size(486, 917);
            this.tableLayoutPanelCampos.TabIndex = 0;
            // 
            // tableLayoutPanelCEP
            // 
            this.tableLayoutPanelCEP.ColumnCount = 3;
            this.tableLayoutPanelCEP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanelCEP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanelCEP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCEP.Controls.Add(this.groupBoxCidade, 0, 0);
            this.tableLayoutPanelCEP.Controls.Add(this.groupBoxEstado, 0, 0);
            this.tableLayoutPanelCEP.Controls.Add(this.groupBoxCEP, 0, 0);
            this.tableLayoutPanelCEP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCEP.Location = new System.Drawing.Point(3, 51);
            this.tableLayoutPanelCEP.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanelCEP.Name = "tableLayoutPanelCEP";
            this.tableLayoutPanelCEP.RowCount = 1;
            this.tableLayoutPanelCEP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCEP.Size = new System.Drawing.Size(480, 51);
            this.tableLayoutPanelCEP.TabIndex = 2;
            // 
            // groupBoxCidade
            // 
            this.groupBoxCidade.Controls.Add(this.textBoxCidade);
            this.groupBoxCidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBoxCidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxCidade.Location = new System.Drawing.Point(242, 0);
            this.groupBoxCidade.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBoxCidade.Name = "groupBoxCidade";
            this.groupBoxCidade.Size = new System.Drawing.Size(235, 51);
            this.groupBoxCidade.TabIndex = 4;
            this.groupBoxCidade.TabStop = false;
            this.groupBoxCidade.Text = "Cidade";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCidade.Location = new System.Drawing.Point(3, 23);
            this.textBoxCidade.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.ReadOnly = true;
            this.textBoxCidade.Size = new System.Drawing.Size(229, 30);
            this.textBoxCidade.TabIndex = 2;
            // 
            // groupBoxEstado
            // 
            this.groupBoxEstado.Controls.Add(this.textBoxEstado);
            this.groupBoxEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBoxEstado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxEstado.Location = new System.Drawing.Point(137, 0);
            this.groupBoxEstado.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBoxEstado.Name = "groupBoxEstado";
            this.groupBoxEstado.Size = new System.Drawing.Size(99, 51);
            this.groupBoxEstado.TabIndex = 3;
            this.groupBoxEstado.TabStop = false;
            this.groupBoxEstado.Text = "Estado";
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEstado.Location = new System.Drawing.Point(3, 23);
            this.textBoxEstado.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.ReadOnly = true;
            this.textBoxEstado.Size = new System.Drawing.Size(93, 30);
            this.textBoxEstado.TabIndex = 1;
            // 
            // groupBoxCEP
            // 
            this.groupBoxCEP.Controls.Add(this.btnPesquisarCEP);
            this.groupBoxCEP.Controls.Add(this.textBoxCEP);
            this.groupBoxCEP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCEP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxCEP.Location = new System.Drawing.Point(3, 0);
            this.groupBoxCEP.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBoxCEP.Name = "groupBoxCEP";
            this.groupBoxCEP.Size = new System.Drawing.Size(128, 51);
            this.groupBoxCEP.TabIndex = 2;
            this.groupBoxCEP.TabStop = false;
            this.groupBoxCEP.Text = "CEP";
            // 
            // btnPesquisarCEP
            // 
            this.btnPesquisarCEP.AutoSize = true;
            this.btnPesquisarCEP.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarCEP.Checked = true;
            this.btnPesquisarCEP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarCEP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisarCEP.Location = new System.Drawing.Point(51, 3);
            this.btnPesquisarCEP.Name = "btnPesquisarCEP";
            this.btnPesquisarCEP.Size = new System.Drawing.Size(17, 16);
            this.btnPesquisarCEP.TabIndex = 3;
            this.btnPesquisarCEP.TabStop = true;
            this.btnPesquisarCEP.UseVisualStyleBackColor = false;
            this.btnPesquisarCEP.Click += new System.EventHandler(this.btnPesquisarCEP_Click);
            // 
            // textBoxCEP
            // 
            this.textBoxCEP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCEP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCEP.Location = new System.Drawing.Point(3, 23);
            this.textBoxCEP.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxCEP.Name = "textBoxCEP";
            this.textBoxCEP.Size = new System.Drawing.Size(122, 30);
            this.textBoxCEP.TabIndex = 0;
            this.textBoxCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCEP_KeyPress);
            // 
            // tableLayoutPanelDescricao
            // 
            this.tableLayoutPanelDescricao.ColumnCount = 2;
            this.tableLayoutPanelDescricao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelDescricao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDescricao.Controls.Add(this.groupBoxValor, 1, 0);
            this.tableLayoutPanelDescricao.Controls.Add(this.groupBoxDescricao, 0, 0);
            this.tableLayoutPanelDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDescricao.Location = new System.Drawing.Point(3, 153);
            this.tableLayoutPanelDescricao.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanelDescricao.Name = "tableLayoutPanelDescricao";
            this.tableLayoutPanelDescricao.RowCount = 1;
            this.tableLayoutPanelDescricao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDescricao.Size = new System.Drawing.Size(480, 51);
            this.tableLayoutPanelDescricao.TabIndex = 4;
            // 
            // groupBoxValor
            // 
            this.groupBoxValor.Controls.Add(this.textBoxValor);
            this.groupBoxValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBoxValor.Location = new System.Drawing.Point(387, 0);
            this.groupBoxValor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBoxValor.Name = "groupBoxValor";
            this.groupBoxValor.Size = new System.Drawing.Size(90, 51);
            this.groupBoxValor.TabIndex = 9;
            this.groupBoxValor.TabStop = false;
            this.groupBoxValor.Text = "Valor";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValor.Location = new System.Drawing.Point(3, 23);
            this.textBoxValor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(84, 30);
            this.textBoxValor.TabIndex = 0;
            // 
            // groupBoxDescricao
            // 
            this.groupBoxDescricao.Controls.Add(this.textBoxDescricao);
            this.groupBoxDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBoxDescricao.Location = new System.Drawing.Point(3, 0);
            this.groupBoxDescricao.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBoxDescricao.Name = "groupBoxDescricao";
            this.groupBoxDescricao.Size = new System.Drawing.Size(378, 51);
            this.groupBoxDescricao.TabIndex = 8;
            this.groupBoxDescricao.TabStop = false;
            this.groupBoxDescricao.Text = "Descrição do Serviço";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescricao.Location = new System.Drawing.Point(3, 23);
            this.textBoxDescricao.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(372, 30);
            this.textBoxDescricao.TabIndex = 0;
            // 
            // tableLayoutPanelBotoesRodape
            // 
            this.tableLayoutPanelBotoesRodape.ColumnCount = 3;
            this.tableLayoutPanelBotoesRodape.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelBotoesRodape.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBotoesRodape.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelBotoesRodape.Controls.Add(this.btnLimpar, 0, 0);
            this.tableLayoutPanelBotoesRodape.Controls.Add(this.btnEmitir, 2, 0);
            this.tableLayoutPanelBotoesRodape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBotoesRodape.Location = new System.Drawing.Point(3, 855);
            this.tableLayoutPanelBotoesRodape.Name = "tableLayoutPanelBotoesRodape";
            this.tableLayoutPanelBotoesRodape.RowCount = 1;
            this.tableLayoutPanelBotoesRodape.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBotoesRodape.Size = new System.Drawing.Size(480, 59);
            this.tableLayoutPanelBotoesRodape.TabIndex = 14;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(3, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(114, 53);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEmitir
            // 
            this.btnEmitir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitir.Location = new System.Drawing.Point(363, 3);
            this.btnEmitir.Name = "btnEmitir";
            this.btnEmitir.Size = new System.Drawing.Size(114, 53);
            this.btnEmitir.TabIndex = 11;
            this.btnEmitir.Text = "Emitir";
            this.btnEmitir.UseVisualStyleBackColor = true;
            this.btnEmitir.Click += new System.EventHandler(this.btnEmitir_Click);
            // 
            // tableLayoutPanelCPF
            // 
            this.tableLayoutPanelCPF.ColumnCount = 2;
            this.tableLayoutPanelCPF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelCPF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelCPF.Controls.Add(this.groupBoxCPF, 0, 0);
            this.tableLayoutPanelCPF.Controls.Add(this.groupBoxNome, 1, 0);
            this.tableLayoutPanelCPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCPF.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanelCPF.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanelCPF.Name = "tableLayoutPanelCPF";
            this.tableLayoutPanelCPF.RowCount = 1;
            this.tableLayoutPanelCPF.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCPF.Size = new System.Drawing.Size(480, 51);
            this.tableLayoutPanelCPF.TabIndex = 1;
            // 
            // groupBoxCPF
            // 
            this.groupBoxCPF.Controls.Add(this.btnPesquisarPessoa);
            this.groupBoxCPF.Controls.Add(this.textBoxCPF);
            this.groupBoxCPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCPF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxCPF.Location = new System.Drawing.Point(3, 0);
            this.groupBoxCPF.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBoxCPF.Name = "groupBoxCPF";
            this.groupBoxCPF.Size = new System.Drawing.Size(138, 51);
            this.groupBoxCPF.TabIndex = 0;
            this.groupBoxCPF.TabStop = false;
            this.groupBoxCPF.Text = "CPF/CNPJ";
            // 
            // btnPesquisarPessoa
            // 
            this.btnPesquisarPessoa.AutoSize = true;
            this.btnPesquisarPessoa.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarPessoa.Checked = true;
            this.btnPesquisarPessoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarPessoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisarPessoa.Location = new System.Drawing.Point(102, 2);
            this.btnPesquisarPessoa.Name = "btnPesquisarPessoa";
            this.btnPesquisarPessoa.Size = new System.Drawing.Size(17, 16);
            this.btnPesquisarPessoa.TabIndex = 2;
            this.btnPesquisarPessoa.TabStop = true;
            this.btnPesquisarPessoa.UseVisualStyleBackColor = false;
            this.btnPesquisarPessoa.Click += new System.EventHandler(this.btnPesquisarPessoa_Click);
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCPF.Location = new System.Drawing.Point(3, 23);
            this.textBoxCPF.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(132, 30);
            this.textBoxCPF.TabIndex = 1;
            this.textBoxCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCPF_KeyPress);
            // 
            // groupBoxNome
            // 
            this.groupBoxNome.Controls.Add(this.textBoxNome);
            this.groupBoxNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBoxNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxNome.Location = new System.Drawing.Point(147, 0);
            this.groupBoxNome.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBoxNome.Name = "groupBoxNome";
            this.groupBoxNome.Size = new System.Drawing.Size(330, 51);
            this.groupBoxNome.TabIndex = 1;
            this.groupBoxNome.TabStop = false;
            this.groupBoxNome.Text = "Nome/Razão Social";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(3, 23);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(324, 30);
            this.textBoxNome.TabIndex = 0;
            // 
            // tableLayoutPanelEndereco
            // 
            this.tableLayoutPanelEndereco.ColumnCount = 3;
            this.tableLayoutPanelEndereco.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelEndereco.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelEndereco.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelEndereco.Controls.Add(this.groupBoxNumero, 0, 0);
            this.tableLayoutPanelEndereco.Controls.Add(this.groupBoxBairro, 0, 0);
            this.tableLayoutPanelEndereco.Controls.Add(this.groupBoxEndereco, 0, 0);
            this.tableLayoutPanelEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelEndereco.Location = new System.Drawing.Point(3, 105);
            this.tableLayoutPanelEndereco.Name = "tableLayoutPanelEndereco";
            this.tableLayoutPanelEndereco.RowCount = 1;
            this.tableLayoutPanelEndereco.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelEndereco.Size = new System.Drawing.Size(480, 45);
            this.tableLayoutPanelEndereco.TabIndex = 3;
            // 
            // groupBoxNumero
            // 
            this.groupBoxNumero.Controls.Add(this.textBoxNumero);
            this.groupBoxNumero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBoxNumero.Location = new System.Drawing.Point(435, 0);
            this.groupBoxNumero.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBoxNumero.Name = "groupBoxNumero";
            this.groupBoxNumero.Size = new System.Drawing.Size(42, 45);
            this.groupBoxNumero.TabIndex = 7;
            this.groupBoxNumero.TabStop = false;
            this.groupBoxNumero.Text = "Nº";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNumero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumero.Location = new System.Drawing.Point(3, 23);
            this.textBoxNumero.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(36, 30);
            this.textBoxNumero.TabIndex = 6;
            // 
            // groupBoxBairro
            // 
            this.groupBoxBairro.Controls.Add(this.textBoxBairro);
            this.groupBoxBairro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBoxBairro.Location = new System.Drawing.Point(291, 0);
            this.groupBoxBairro.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBoxBairro.Name = "groupBoxBairro";
            this.groupBoxBairro.Size = new System.Drawing.Size(138, 45);
            this.groupBoxBairro.TabIndex = 6;
            this.groupBoxBairro.TabStop = false;
            this.groupBoxBairro.Text = "Bairro";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxBairro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBairro.Location = new System.Drawing.Point(3, 23);
            this.textBoxBairro.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(132, 30);
            this.textBoxBairro.TabIndex = 6;
            // 
            // groupBoxEndereco
            // 
            this.groupBoxEndereco.Controls.Add(this.textBoxEndereco);
            this.groupBoxEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBoxEndereco.Location = new System.Drawing.Point(3, 0);
            this.groupBoxEndereco.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBoxEndereco.Name = "groupBoxEndereco";
            this.groupBoxEndereco.Size = new System.Drawing.Size(282, 45);
            this.groupBoxEndereco.TabIndex = 5;
            this.groupBoxEndereco.TabStop = false;
            this.groupBoxEndereco.Text = "Endereço";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEndereco.Location = new System.Drawing.Point(3, 23);
            this.textBoxEndereco.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(276, 30);
            this.textBoxEndereco.TabIndex = 6;
            // 
            // groupBoxObservacoes
            // 
            this.groupBoxObservacoes.Controls.Add(this.observacao);
            this.groupBoxObservacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBoxObservacoes.Location = new System.Drawing.Point(3, 207);
            this.groupBoxObservacoes.Name = "groupBoxObservacoes";
            this.groupBoxObservacoes.Size = new System.Drawing.Size(480, 642);
            this.groupBoxObservacoes.TabIndex = 10;
            this.groupBoxObservacoes.TabStop = false;
            this.groupBoxObservacoes.Text = "Observações";
            // 
            // observacao
            // 
            this.observacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.observacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacao.Location = new System.Drawing.Point(3, 23);
            this.observacao.Margin = new System.Windows.Forms.Padding(4);
            this.observacao.Multiline = true;
            this.observacao.Name = "observacao";
            this.observacao.Size = new System.Drawing.Size(474, 616);
            this.observacao.TabIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "imagem";
            // 
            // panelOptions
            // 
            this.panelOptions.AutoScroll = true;
            this.panelOptions.ColumnCount = 1;
            this.panelOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelOptions.Controls.Add(this.btnStartCapture, 0, 7);
            this.panelOptions.Controls.Add(this.groupBox1, 0, 0);
            this.panelOptions.Controls.Add(this.groupSize, 0, 4);
            this.panelOptions.Controls.Add(this.groupDPI, 0, 1);
            this.panelOptions.Controls.Add(this.groupDepth, 0, 6);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOptions.Location = new System.Drawing.Point(0, 32);
            this.panelOptions.Margin = new System.Windows.Forms.Padding(4);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.RowCount = 9;
            this.panelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelOptions.Size = new System.Drawing.Size(260, 921);
            this.panelOptions.TabIndex = 0;
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartCapture.Enabled = false;
            this.btnStartCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartCapture.Location = new System.Drawing.Point(11, 350);
            this.btnStartCapture.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(238, 60);
            this.btnStartCapture.TabIndex = 0;
            this.btnStartCapture.TabStop = false;
            this.btnStartCapture.Text = "Escanear";
            this.btnStartCapture.UseVisualStyleBackColor = true;
            this.btnStartCapture.Click += new System.EventHandler(this.btnStartCapture_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(11, 10, 11, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(238, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Autorização",
            "Chave DANFe",
            "Outro"});
            this.comboBox1.Location = new System.Drawing.Point(24, 28);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.TabStop = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupSize
            // 
            this.groupSize.Controls.Add(this.comboSize);
            this.groupSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupSize.Enabled = false;
            this.groupSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSize.Location = new System.Drawing.Point(11, 180);
            this.groupSize.Margin = new System.Windows.Forms.Padding(11, 10, 11, 4);
            this.groupSize.Name = "groupSize";
            this.groupSize.Padding = new System.Windows.Forms.Padding(4);
            this.groupSize.Size = new System.Drawing.Size(238, 71);
            this.groupSize.TabIndex = 0;
            this.groupSize.TabStop = false;
            this.groupSize.Text = "Tamanho";
            // 
            // comboSize
            // 
            this.comboSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSize.FormattingEnabled = true;
            this.comboSize.Location = new System.Drawing.Point(24, 28);
            this.comboSize.Margin = new System.Windows.Forms.Padding(4);
            this.comboSize.Name = "comboSize";
            this.comboSize.Size = new System.Drawing.Size(187, 28);
            this.comboSize.TabIndex = 0;
            this.comboSize.TabStop = false;
            this.comboSize.SelectedIndexChanged += new System.EventHandler(this.comboSize_SelectedIndexChanged);
            // 
            // groupDPI
            // 
            this.groupDPI.Controls.Add(this.comboDPI);
            this.groupDPI.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDPI.Enabled = false;
            this.groupDPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDPI.Location = new System.Drawing.Point(11, 95);
            this.groupDPI.Margin = new System.Windows.Forms.Padding(11, 10, 11, 4);
            this.groupDPI.Name = "groupDPI";
            this.groupDPI.Padding = new System.Windows.Forms.Padding(4);
            this.groupDPI.Size = new System.Drawing.Size(238, 71);
            this.groupDPI.TabIndex = 0;
            this.groupDPI.TabStop = false;
            this.groupDPI.Text = "Qualidade (DPI)";
            // 
            // comboDPI
            // 
            this.comboDPI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboDPI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDPI.FormattingEnabled = true;
            this.comboDPI.Location = new System.Drawing.Point(24, 28);
            this.comboDPI.Margin = new System.Windows.Forms.Padding(4);
            this.comboDPI.Name = "comboDPI";
            this.comboDPI.Size = new System.Drawing.Size(188, 28);
            this.comboDPI.TabIndex = 0;
            this.comboDPI.TabStop = false;
            this.comboDPI.SelectedIndexChanged += new System.EventHandler(this.comboDPI_SelectedIndexChanged);
            // 
            // groupDepth
            // 
            this.groupDepth.Controls.Add(this.comboDepth);
            this.groupDepth.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDepth.Enabled = false;
            this.groupDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDepth.Location = new System.Drawing.Point(11, 265);
            this.groupDepth.Margin = new System.Windows.Forms.Padding(11, 10, 11, 4);
            this.groupDepth.Name = "groupDepth";
            this.groupDepth.Padding = new System.Windows.Forms.Padding(4);
            this.groupDepth.Size = new System.Drawing.Size(238, 71);
            this.groupDepth.TabIndex = 0;
            this.groupDepth.TabStop = false;
            this.groupDepth.Text = "Cor";
            // 
            // comboDepth
            // 
            this.comboDepth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepth.FormattingEnabled = true;
            this.comboDepth.Location = new System.Drawing.Point(24, 30);
            this.comboDepth.Margin = new System.Windows.Forms.Padding(4);
            this.comboDepth.Name = "comboDepth";
            this.comboDepth.Size = new System.Drawing.Size(188, 28);
            this.comboDepth.TabIndex = 0;
            this.comboDepth.TabStop = false;
            this.comboDepth.SelectedIndexChanged += new System.EventHandler(this.comboDepth_SelectedIndexChanged);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 953);
            this.Controls.Add(this.tableLayoutPanelContainer);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TestForm";
            this.Text = "Assistente NFS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanelContainer.ResumeLayout(false);
            this.tableLayoutPanelCampos.ResumeLayout(false);
            this.tableLayoutPanelCEP.ResumeLayout(false);
            this.groupBoxCidade.ResumeLayout(false);
            this.groupBoxCidade.PerformLayout();
            this.groupBoxEstado.ResumeLayout(false);
            this.groupBoxEstado.PerformLayout();
            this.groupBoxCEP.ResumeLayout(false);
            this.groupBoxCEP.PerformLayout();
            this.tableLayoutPanelDescricao.ResumeLayout(false);
            this.groupBoxValor.ResumeLayout(false);
            this.groupBoxValor.PerformLayout();
            this.groupBoxDescricao.ResumeLayout(false);
            this.groupBoxDescricao.PerformLayout();
            this.tableLayoutPanelBotoesRodape.ResumeLayout(false);
            this.tableLayoutPanelCPF.ResumeLayout(false);
            this.groupBoxCPF.ResumeLayout(false);
            this.groupBoxCPF.PerformLayout();
            this.groupBoxNome.ResumeLayout(false);
            this.groupBoxNome.PerformLayout();
            this.tableLayoutPanelEndereco.ResumeLayout(false);
            this.groupBoxNumero.ResumeLayout(false);
            this.groupBoxNumero.PerformLayout();
            this.groupBoxBairro.ResumeLayout(false);
            this.groupBoxBairro.PerformLayout();
            this.groupBoxEndereco.ResumeLayout(false);
            this.groupBoxEndereco.PerformLayout();
            this.groupBoxObservacoes.ResumeLayout(false);
            this.groupBoxObservacoes.PerformLayout();
            this.panelOptions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupSize.ResumeLayout(false);
            this.groupDPI.ResumeLayout(false);
            this.groupDepth.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnSources;
        private System.Windows.Forms.ToolStripSeparator sepSourceList;
        private System.Windows.Forms.ToolStripMenuItem reloadSourcesListToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContainer;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton btnOpenFile;
        private System.Windows.Forms.ToolStripButton btnSaveFile;
        private System.Windows.Forms.TableLayoutPanel panelOptions;
        private System.Windows.Forms.Button btnStartCapture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupSize;
        private System.Windows.Forms.ComboBox comboSize;
        private System.Windows.Forms.GroupBox groupDPI;
        private System.Windows.Forms.ComboBox comboDPI;
        private System.Windows.Forms.GroupBox groupDepth;
        private System.Windows.Forms.ComboBox comboDepth;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCampos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCPF;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCEP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEndereco;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDescricao;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBotoesRodape;
        private System.Windows.Forms.GroupBox groupBoxCPF;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.GroupBox groupBoxNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.GroupBox groupBoxCEP;
        private System.Windows.Forms.TextBox textBoxCEP;
        private System.Windows.Forms.GroupBox groupBoxEstado;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.GroupBox groupBoxCidade;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.GroupBox groupBoxEndereco;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.GroupBox groupBoxDescricao;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.GroupBox groupBoxValor;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.GroupBox groupBoxObservacoes;
        private System.Windows.Forms.TextBox observacao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEmitir;
        private System.Windows.Forms.GroupBox groupBoxNumero;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.GroupBox groupBoxBairro;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.RadioButton btnPesquisarPessoa;
        private System.Windows.Forms.RadioButton btnPesquisarCEP;
    }
}

