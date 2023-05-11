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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSources = new System.Windows.Forms.ToolStripDropDownButton();
            this.sepSourceList = new System.Windows.Forms.ToolStripSeparator();
            this.reloadSourcesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.btnSaveFile = new System.Windows.Forms.ToolStripButton();
            this.groupDPI = new System.Windows.Forms.GroupBox();
            this.comboDPI = new System.Windows.Forms.ComboBox();
            this.groupDepth = new System.Windows.Forms.GroupBox();
            this.comboDepth = new System.Windows.Forms.ComboBox();
            this.groupSize = new System.Windows.Forms.GroupBox();
            this.comboSize = new System.Windows.Forms.ComboBox();
            this.panelOptions = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartCapture = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCopyOutput = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupDPI.SuspendLayout();
            this.groupDepth.SuspendLayout();
            this.groupSize.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.pictureBox1.Size = new System.Drawing.Size(610, 571);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSources,
            this.btnOpenFile,
            this.btnSaveFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1245, 27);
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
            this.btnSources.Size = new System.Drawing.Size(75, 24);
            this.btnSources.Text = "Scanner";
            this.btnSources.DropDownOpening += new System.EventHandler(this.btnSources_DropDownOpening);
            // 
            // sepSourceList
            // 
            this.sepSourceList.Name = "sepSourceList";
            this.sepSourceList.Size = new System.Drawing.Size(192, 6);
            // 
            // reloadSourcesListToolStripMenuItem
            // 
            this.reloadSourcesListToolStripMenuItem.Name = "reloadSourcesListToolStripMenuItem";
            this.reloadSourcesListToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.reloadSourcesListToolStripMenuItem.Text = "Recarregar lista";
            this.reloadSourcesListToolStripMenuItem.Click += new System.EventHandler(this.reloadSourcesListToolStripMenuItem_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(46, 24);
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
            this.btnSaveFile.Size = new System.Drawing.Size(53, 24);
            this.btnSaveFile.Text = "Salvar";
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // groupDPI
            // 
            this.groupDPI.Controls.Add(this.comboDPI);
            this.groupDPI.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDPI.Enabled = false;
            this.groupDPI.Location = new System.Drawing.Point(11, 10);
            this.groupDPI.Margin = new System.Windows.Forms.Padding(11, 10, 11, 4);
            this.groupDPI.Name = "groupDPI";
            this.groupDPI.Padding = new System.Windows.Forms.Padding(4);
            this.groupDPI.Size = new System.Drawing.Size(238, 66);
            this.groupDPI.TabIndex = 0;
            this.groupDPI.TabStop = false;
            this.groupDPI.Text = "DPI";
            // 
            // comboDPI
            // 
            this.comboDPI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboDPI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDPI.FormattingEnabled = true;
            this.comboDPI.Location = new System.Drawing.Point(24, 23);
            this.comboDPI.Margin = new System.Windows.Forms.Padding(4);
            this.comboDPI.Name = "comboDPI";
            this.comboDPI.Size = new System.Drawing.Size(187, 24);
            this.comboDPI.TabIndex = 0;
            this.comboDPI.SelectedIndexChanged += new System.EventHandler(this.comboDPI_SelectedIndexChanged);
            // 
            // groupDepth
            // 
            this.groupDepth.Controls.Add(this.comboDepth);
            this.groupDepth.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDepth.Enabled = false;
            this.groupDepth.Location = new System.Drawing.Point(11, 90);
            this.groupDepth.Margin = new System.Windows.Forms.Padding(11, 10, 11, 4);
            this.groupDepth.Name = "groupDepth";
            this.groupDepth.Padding = new System.Windows.Forms.Padding(4);
            this.groupDepth.Size = new System.Drawing.Size(238, 66);
            this.groupDepth.TabIndex = 4;
            this.groupDepth.TabStop = false;
            this.groupDepth.Text = "Cor";
            // 
            // comboDepth
            // 
            this.comboDepth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepth.FormattingEnabled = true;
            this.comboDepth.Location = new System.Drawing.Point(24, 23);
            this.comboDepth.Margin = new System.Windows.Forms.Padding(4);
            this.comboDepth.Name = "comboDepth";
            this.comboDepth.Size = new System.Drawing.Size(187, 24);
            this.comboDepth.TabIndex = 0;
            this.comboDepth.SelectedIndexChanged += new System.EventHandler(this.comboDepth_SelectedIndexChanged);
            // 
            // groupSize
            // 
            this.groupSize.Controls.Add(this.comboSize);
            this.groupSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupSize.Enabled = false;
            this.groupSize.Location = new System.Drawing.Point(11, 170);
            this.groupSize.Margin = new System.Windows.Forms.Padding(11, 10, 11, 4);
            this.groupSize.Name = "groupSize";
            this.groupSize.Padding = new System.Windows.Forms.Padding(4);
            this.groupSize.Size = new System.Drawing.Size(238, 66);
            this.groupSize.TabIndex = 5;
            this.groupSize.TabStop = false;
            this.groupSize.Text = "Tamanho";
            // 
            // comboSize
            // 
            this.comboSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSize.FormattingEnabled = true;
            this.comboSize.Location = new System.Drawing.Point(24, 23);
            this.comboSize.Margin = new System.Windows.Forms.Padding(4);
            this.comboSize.Name = "comboSize";
            this.comboSize.Size = new System.Drawing.Size(187, 24);
            this.comboSize.TabIndex = 0;
            this.comboSize.SelectedIndexChanged += new System.EventHandler(this.comboSize_SelectedIndexChanged);
            // 
            // panelOptions
            // 
            this.panelOptions.AutoScroll = true;
            this.panelOptions.ColumnCount = 1;
            this.panelOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelOptions.Controls.Add(this.groupSize, 0, 2);
            this.panelOptions.Controls.Add(this.groupDepth, 0, 1);
            this.panelOptions.Controls.Add(this.groupDPI, 0, 0);
            this.panelOptions.Controls.Add(this.label1, 0, 6);
            this.panelOptions.Controls.Add(this.btnStartCapture, 0, 4);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOptions.Location = new System.Drawing.Point(0, 27);
            this.panelOptions.Margin = new System.Windows.Forms.Padding(4);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.RowCount = 7;
            this.panelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.panelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.panelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelOptions.Size = new System.Drawing.Size(260, 579);
            this.panelOptions.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 320);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "   ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartCapture.Enabled = false;
            this.btnStartCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartCapture.Location = new System.Drawing.Point(3, 243);
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(254, 51);
            this.btnStartCapture.TabIndex = 6;
            this.btnStartCapture.Text = "Escanear";
            this.btnStartCapture.UseVisualStyleBackColor = true;
            this.btnStartCapture.Click += new System.EventHandler(this.btnStartCapture_Click);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(260, 27);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(985, 579);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnCopyOutput, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(621, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.06631F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.933682F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(361, 573);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnCopyOutput
            // 
            this.btnCopyOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyOutput.Location = new System.Drawing.Point(3, 541);
            this.btnCopyOutput.Name = "btnCopyOutput";
            this.btnCopyOutput.Size = new System.Drawing.Size(355, 29);
            this.btnCopyOutput.TabIndex = 9;
            this.btnCopyOutput.Text = "Copiar";
            this.btnCopyOutput.UseVisualStyleBackColor = true;
            this.btnCopyOutput.Click += new System.EventHandler(this.btnCopyOutput_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 530);
            this.textBox1.TabIndex = 6;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "imagem";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 606);
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
            this.groupDPI.ResumeLayout(false);
            this.groupDepth.ResumeLayout(false);
            this.groupSize.ResumeLayout(false);
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnSources;
        private System.Windows.Forms.ToolStripSeparator sepSourceList;
        private System.Windows.Forms.ToolStripMenuItem reloadSourcesListToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupDPI;
        private System.Windows.Forms.ComboBox comboDPI;
        private System.Windows.Forms.GroupBox groupDepth;
        private System.Windows.Forms.ComboBox comboDepth;
        private System.Windows.Forms.GroupBox groupSize;
        private System.Windows.Forms.ComboBox comboSize;
        private System.Windows.Forms.TableLayoutPanel panelOptions;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton btnOpenFile;
        private System.Windows.Forms.ToolStripButton btnSaveFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCopyOutput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStartCapture;
    }
}

