namespace Quality
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.swtConn = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.cboServer = new DevComponents.DotNetBar.ComboBoxItem();
            this.produção = new DevComponents.Editors.ComboItem();
            this.teste = new DevComponents.Editors.ComboItem();
            this.pnlStatus = new DevComponents.DotNetBar.PanelEx();
            this.btnCancela = new DevComponents.DotNetBar.ButtonX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.txtSenha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // swtConn
            // 
            // 
            // 
            // 
            this.swtConn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swtConn.Location = new System.Drawing.Point(245, 343);
            this.swtConn.Name = "swtConn";
            this.swtConn.Size = new System.Drawing.Size(66, 22);
            this.swtConn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swtConn.TabIndex = 1;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.itemPanel1);
            this.groupPanel1.Controls.Add(this.pnlStatus);
            this.groupPanel1.Controls.Add(this.btnCancela);
            this.groupPanel1.Controls.Add(this.btnOK);
            this.groupPanel1.Controls.Add(this.txtSenha);
            this.groupPanel1.Controls.Add(this.txtUsuario);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(40, 118);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(273, 218);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 3;
            this.groupPanel1.Text = "LOGIN";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(34, 3);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 20);
            this.labelX4.TabIndex = 12;
            this.labelX4.Text = "Ambiente:";
            // 
            // itemPanel1
            // 
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.DragDropSupport = true;
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.cboServer});
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(34, 29);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(207, 28);
            this.itemPanel1.TabIndex = 5;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // cboServer
            // 
            this.cboServer.DropDownHeight = 106;
            this.cboServer.Items.AddRange(new object[] {
            this.produção,
            this.teste});
            this.cboServer.Name = "cboServer";
            this.cboServer.SelectedIndexChanged += new System.EventHandler(this.cboServer_SelectedIndexChanged);
            // 
            // produção
            // 
            this.produção.Text = "produção";
            // 
            // teste
            // 
            this.teste.Text = "teste";
            // 
            // pnlStatus
            // 
            this.pnlStatus.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlStatus.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlStatus.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlStatus.Location = new System.Drawing.Point(34, 161);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(207, 21);
            this.pnlStatus.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlStatus.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.pnlStatus.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.pnlStatus.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.pnlStatus.Style.GradientAngle = 90;
            this.pnlStatus.TabIndex = 5;
            // 
            // btnCancela
            // 
            this.btnCancela.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancela.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancela.Location = new System.Drawing.Point(187, 119);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(54, 23);
            this.btnCancela.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancela.TabIndex = 3;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Location = new System.Drawing.Point(115, 119);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(54, 23);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.Border.Class = "TextBoxBorder";
            this.txtSenha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSenha.ButtonCustom.Tooltip = "";
            this.txtSenha.ButtonCustom2.Tooltip = "";
            this.txtSenha.DisabledBackColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(115, 93);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PreventEnterBeep = true;
            this.txtSenha.Size = new System.Drawing.Size(126, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.Border.Class = "TextBoxBorder";
            this.txtUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUsuario.ButtonCustom.Tooltip = "";
            this.txtUsuario.ButtonCustom2.Tooltip = "";
            this.txtUsuario.DisabledBackColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(115, 64);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PreventEnterBeep = true;
            this.txtUsuario.Size = new System.Drawing.Size(126, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(34, 92);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 20);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Senha:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(34, 63);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 20);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Id usuario:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(183, 342);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(56, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Servidor:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quality.Properties.Resources.proq;
            this.pictureBox1.Location = new System.Drawing.Point(40, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 373);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.swtConn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pro Quality System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.SwitchButton swtConn;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ComboBoxItem cboServer;
        private DevComponents.DotNetBar.PanelEx pnlStatus;
        private DevComponents.DotNetBar.ButtonX btnCancela;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSenha;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUsuario;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.ComboItem produção;
        private DevComponents.Editors.ComboItem teste;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

