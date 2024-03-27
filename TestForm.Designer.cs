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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxUF = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxCEP = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEmitir = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox10.SuspendLayout();
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
            this.pictureBox1.Size = new System.Drawing.Size(795, 713);
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
            this.toolStrip1.Size = new System.Drawing.Size(1539, 32);
            this.toolStrip1.TabIndex = 2;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.83019F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.16981F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(260, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 721F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 721F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1279, 721);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox10, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(806, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.660378F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.660378F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.660378F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.660378F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.75471F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.603774F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(470, 717);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 40);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(464, 40);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxCidade);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox6.Location = new System.Drawing.Point(234, 0);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(227, 40);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cidade";
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
            this.textBoxCidade.Size = new System.Drawing.Size(221, 30);
            this.textBoxCidade.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxUF);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox5.Location = new System.Drawing.Point(142, 0);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(86, 40);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Estado";
            // 
            // textBoxUF
            // 
            this.textBoxUF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUF.Location = new System.Drawing.Point(3, 23);
            this.textBoxUF.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxUF.Name = "textBoxUF";
            this.textBoxUF.ReadOnly = true;
            this.textBoxUF.Size = new System.Drawing.Size(80, 30);
            this.textBoxUF.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxCEP);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox4.Location = new System.Drawing.Point(3, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(133, 40);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CEP";
            // 
            // textBoxCEP
            // 
            this.textBoxCEP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCEP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCEP.Location = new System.Drawing.Point(3, 23);
            this.textBoxCEP.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxCEP.Name = "textBoxCEP";
            this.textBoxCEP.Size = new System.Drawing.Size(127, 30);
            this.textBoxCEP.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox9, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox8, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 120);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(464, 40);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBoxValor);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox9.Location = new System.Drawing.Point(374, 0);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(87, 40);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Valor";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValor.Location = new System.Drawing.Point(3, 23);
            this.textBoxValor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(81, 30);
            this.textBoxValor.TabIndex = 9;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBoxDescricao);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox8.Location = new System.Drawing.Point(3, 0);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(365, 40);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Descrição do Serviço";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescricao.Location = new System.Drawing.Point(3, 23);
            this.textBoxDescricao.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(359, 30);
            this.textBoxDescricao.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.btnLimpar, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnEmitir, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 670);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(464, 44);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(3, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 38);
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
            this.btnEmitir.Location = new System.Drawing.Point(351, 3);
            this.btnEmitir.Name = "btnEmitir";
            this.btnEmitir.Size = new System.Drawing.Size(110, 38);
            this.btnEmitir.TabIndex = 8;
            this.btnEmitir.Text = "Emitir";
            this.btnEmitir.UseVisualStyleBackColor = true;
            this.btnEmitir.Click += new System.EventHandler(this.btnEmitir_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel6.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(464, 40);
            this.tableLayoutPanel6.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.textBoxCPF);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 40);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPF/CNPJ";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.LightBlue;
            this.btnPesquisar.Location = new System.Drawing.Point(104, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(29, 18);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCPF.Location = new System.Drawing.Point(3, 23);
            this.textBoxCPF.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(127, 30);
            this.textBoxCPF.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxNome);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox3.Location = new System.Drawing.Point(142, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 40);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nome/Razão Social";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(3, 23);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(313, 30);
            this.textBoxNome.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.groupBox7, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(464, 34);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxEndereco);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox7.Location = new System.Drawing.Point(3, 0);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(458, 34);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Endereço";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEndereco.Location = new System.Drawing.Point(3, 23);
            this.textBoxEndereco.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(452, 30);
            this.textBoxEndereco.TabIndex = 6;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.observacao);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox10.Location = new System.Drawing.Point(3, 163);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(464, 501);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Observações";
            // 
            // observacao
            // 
            this.observacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.observacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacao.Location = new System.Drawing.Point(3, 23);
            this.observacao.Margin = new System.Windows.Forms.Padding(4);
            this.observacao.Multiline = true;
            this.observacao.Name = "observacao";
            this.observacao.Size = new System.Drawing.Size(458, 475);
            this.observacao.TabIndex = 8;
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
            this.panelOptions.Size = new System.Drawing.Size(260, 721);
            this.panelOptions.TabIndex = 3;
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
            this.ClientSize = new System.Drawing.Size(1539, 753);
            this.Controls.Add(this.tableLayoutPanel1);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEmitir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxUF;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxCEP;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox observacao;
        private System.Windows.Forms.Button btnPesquisar;
    }
}

