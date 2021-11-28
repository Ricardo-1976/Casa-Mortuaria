namespace CasaMortuaria
{
    partial class _CadastrarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_CadastrarFuncionario));
            this.lk_sair = new MetroFramework.Controls.MetroLink();
            this.lk_editarF = new MetroFramework.Controls.MetroLink();
            this.tc_funcionario = new MetroFramework.Controls.MetroTabControl();
            this.tp_cadastrarFuncionario = new MetroFramework.Controls.MetroTabPage();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.pic_brF = new System.Windows.Forms.PictureBox();
            this.pic_qrF = new System.Windows.Forms.PictureBox();
            this.txt_comfirSenha = new MetroFramework.Controls.MetroTextBox();
            this.dt_datanasc = new MetroFramework.Controls.MetroDateTime();
            this.btn_imgF = new MetroFramework.Controls.MetroButton();
            this.pic_imgF = new System.Windows.Forms.PictureBox();
            this.cb_papel = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_telefoneF = new MetroFramework.Controls.MetroTextBox();
            this.cb_sexoF = new MetroFramework.Controls.MetroComboBox();
            this.txt_emailF = new MetroFramework.Controls.MetroTextBox();
            this.txt_senhaF = new MetroFramework.Controls.MetroTextBox();
            this.txt_nomeF = new MetroFramework.Controls.MetroTextBox();
            this.txt_nbiF = new MetroFramework.Controls.MetroTextBox();
            this.txt_idF = new MetroFramework.Controls.MetroTextBox();
            this.lk_excluirF = new MetroFramework.Controls.MetroLink();
            this.lk_salvarF = new MetroFramework.Controls.MetroLink();
            this.lk_restaura = new MetroFramework.Controls.MetroLink();
            this.lk_excluirRec = new MetroFramework.Controls.MetroLink();
            this.tc_funcionario.SuspendLayout();
            this.tp_cadastrarFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_brF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imgF)).BeginInit();
            this.SuspendLayout();
            // 
            // lk_sair
            // 
            this.lk_sair.Image = ((System.Drawing.Image)(resources.GetObject("lk_sair.Image")));
            this.lk_sair.ImageSize = 30;
            this.lk_sair.Location = new System.Drawing.Point(747, 21);
            this.lk_sair.Name = "lk_sair";
            this.lk_sair.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lk_sair.NoFocusImage")));
            this.lk_sair.Size = new System.Drawing.Size(38, 31);
            this.lk_sair.TabIndex = 51;
            this.lk_sair.UseSelectable = true;
            this.lk_sair.Click += new System.EventHandler(this.lk_sair_Click);
            // 
            // lk_editarF
            // 
            this.lk_editarF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lk_editarF.Image = ((System.Drawing.Image)(resources.GetObject("lk_editarF.Image")));
            this.lk_editarF.ImageSize = 30;
            this.lk_editarF.Location = new System.Drawing.Point(651, 21);
            this.lk_editarF.Name = "lk_editarF";
            this.lk_editarF.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lk_editarF.NoFocusImage")));
            this.lk_editarF.Size = new System.Drawing.Size(33, 31);
            this.lk_editarF.TabIndex = 49;
            this.lk_editarF.UseSelectable = true;
            this.lk_editarF.Visible = false;
            this.lk_editarF.Click += new System.EventHandler(this.lk_editarF_Click);
            // 
            // tc_funcionario
            // 
            this.tc_funcionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_funcionario.Controls.Add(this.tp_cadastrarFuncionario);
            this.tc_funcionario.Location = new System.Drawing.Point(22, 21);
            this.tc_funcionario.Name = "tc_funcionario";
            this.tc_funcionario.SelectedIndex = 0;
            this.tc_funcionario.Size = new System.Drawing.Size(767, 478);
            this.tc_funcionario.Style = MetroFramework.MetroColorStyle.Black;
            this.tc_funcionario.TabIndex = 48;
            this.tc_funcionario.UseSelectable = true;
            // 
            // tp_cadastrarFuncionario
            // 
            this.tp_cadastrarFuncionario.Controls.Add(this.metroDateTime1);
            this.tp_cadastrarFuncionario.Controls.Add(this.metroLabel7);
            this.tp_cadastrarFuncionario.Controls.Add(this.pic_brF);
            this.tp_cadastrarFuncionario.Controls.Add(this.pic_qrF);
            this.tp_cadastrarFuncionario.Controls.Add(this.txt_comfirSenha);
            this.tp_cadastrarFuncionario.Controls.Add(this.dt_datanasc);
            this.tp_cadastrarFuncionario.Controls.Add(this.btn_imgF);
            this.tp_cadastrarFuncionario.Controls.Add(this.pic_imgF);
            this.tp_cadastrarFuncionario.Controls.Add(this.cb_papel);
            this.tp_cadastrarFuncionario.Controls.Add(this.metroLabel2);
            this.tp_cadastrarFuncionario.Controls.Add(this.metroLabel6);
            this.tp_cadastrarFuncionario.Controls.Add(this.metroLabel5);
            this.tp_cadastrarFuncionario.Controls.Add(this.metroLabel4);
            this.tp_cadastrarFuncionario.Controls.Add(this.metroLabel3);
            this.tp_cadastrarFuncionario.Controls.Add(this.metroLabel1);
            this.tp_cadastrarFuncionario.Controls.Add(this.txt_telefoneF);
            this.tp_cadastrarFuncionario.Controls.Add(this.cb_sexoF);
            this.tp_cadastrarFuncionario.Controls.Add(this.txt_emailF);
            this.tp_cadastrarFuncionario.Controls.Add(this.txt_senhaF);
            this.tp_cadastrarFuncionario.Controls.Add(this.txt_nomeF);
            this.tp_cadastrarFuncionario.Controls.Add(this.txt_nbiF);
            this.tp_cadastrarFuncionario.Controls.Add(this.txt_idF);
            this.tp_cadastrarFuncionario.HorizontalScrollbarBarColor = true;
            this.tp_cadastrarFuncionario.HorizontalScrollbarHighlightOnWheel = false;
            this.tp_cadastrarFuncionario.HorizontalScrollbarSize = 10;
            this.tp_cadastrarFuncionario.Location = new System.Drawing.Point(4, 38);
            this.tp_cadastrarFuncionario.Name = "tp_cadastrarFuncionario";
            this.tp_cadastrarFuncionario.Size = new System.Drawing.Size(759, 436);
            this.tp_cadastrarFuncionario.Style = MetroFramework.MetroColorStyle.Teal;
            this.tp_cadastrarFuncionario.TabIndex = 0;
            this.tp_cadastrarFuncionario.Text = "Cadastrar Funcionário";
            this.tp_cadastrarFuncionario.VerticalScrollbarBarColor = true;
            this.tp_cadastrarFuncionario.VerticalScrollbarHighlightOnWheel = false;
            this.tp_cadastrarFuncionario.VerticalScrollbarSize = 10;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(556, 6);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 51;
            this.metroDateTime1.Visible = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(495, 199);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(115, 19);
            this.metroLabel7.TabIndex = 50;
            this.metroLabel7.Text = "Comfirma Senha :";
            // 
            // pic_brF
            // 
            this.pic_brF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_brF.Location = new System.Drawing.Point(199, 339);
            this.pic_brF.Name = "pic_brF";
            this.pic_brF.Size = new System.Drawing.Size(266, 91);
            this.pic_brF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_brF.TabIndex = 49;
            this.pic_brF.TabStop = false;
            // 
            // pic_qrF
            // 
            this.pic_qrF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_qrF.Location = new System.Drawing.Point(495, 259);
            this.pic_qrF.Name = "pic_qrF";
            this.pic_qrF.Size = new System.Drawing.Size(236, 171);
            this.pic_qrF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_qrF.TabIndex = 48;
            this.pic_qrF.TabStop = false;
            // 
            // txt_comfirSenha
            // 
            this.txt_comfirSenha.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_comfirSenha.CustomButton.Image = null;
            this.txt_comfirSenha.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.txt_comfirSenha.CustomButton.Name = "";
            this.txt_comfirSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_comfirSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_comfirSenha.CustomButton.TabIndex = 1;
            this.txt_comfirSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_comfirSenha.CustomButton.UseSelectable = true;
            this.txt_comfirSenha.CustomButton.Visible = false;
            this.txt_comfirSenha.Lines = new string[0];
            this.txt_comfirSenha.Location = new System.Drawing.Point(495, 221);
            this.txt_comfirSenha.MaxLength = 10;
            this.txt_comfirSenha.Name = "txt_comfirSenha";
            this.txt_comfirSenha.PasswordChar = '●';
            this.txt_comfirSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_comfirSenha.SelectedText = "";
            this.txt_comfirSenha.SelectionLength = 0;
            this.txt_comfirSenha.SelectionStart = 0;
            this.txt_comfirSenha.ShortcutsEnabled = true;
            this.txt_comfirSenha.Size = new System.Drawing.Size(236, 23);
            this.txt_comfirSenha.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_comfirSenha.TabIndex = 42;
            this.txt_comfirSenha.UseCustomBackColor = true;
            this.txt_comfirSenha.UseCustomForeColor = true;
            this.txt_comfirSenha.UseSelectable = true;
            this.txt_comfirSenha.UseStyleColors = true;
            this.txt_comfirSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_comfirSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_comfirSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_comfirSenha_KeyPress_1);
            // 
            // dt_datanasc
            // 
            this.dt_datanasc.Checked = false;
            this.dt_datanasc.CustomFormat = "";
            this.dt_datanasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_datanasc.Location = new System.Drawing.Point(199, 304);
            this.dt_datanasc.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_datanasc.Name = "dt_datanasc";
            this.dt_datanasc.Size = new System.Drawing.Size(112, 29);
            this.dt_datanasc.Style = MetroFramework.MetroColorStyle.Teal;
            this.dt_datanasc.TabIndex = 41;
            this.dt_datanasc.UseCustomBackColor = true;
            this.dt_datanasc.UseCustomForeColor = true;
            this.dt_datanasc.UseStyleColors = true;
            // 
            // btn_imgF
            // 
            this.btn_imgF.Location = new System.Drawing.Point(24, 189);
            this.btn_imgF.Name = "btn_imgF";
            this.btn_imgF.Size = new System.Drawing.Size(136, 23);
            this.btn_imgF.TabIndex = 35;
            this.btn_imgF.Text = "Inserir Foto";
            this.btn_imgF.UseSelectable = true;
            this.btn_imgF.Click += new System.EventHandler(this.btn_imgF_Click);
            // 
            // pic_imgF
            // 
            this.pic_imgF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_imgF.Location = new System.Drawing.Point(24, 19);
            this.pic_imgF.Name = "pic_imgF";
            this.pic_imgF.Size = new System.Drawing.Size(136, 161);
            this.pic_imgF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_imgF.TabIndex = 34;
            this.pic_imgF.TabStop = false;
            // 
            // cb_papel
            // 
            this.cb_papel.FormattingEnabled = true;
            this.cb_papel.ItemHeight = 23;
            this.cb_papel.Items.AddRange(new object[] {
            "Administrador",
            "Operador"});
            this.cb_papel.Location = new System.Drawing.Point(351, 120);
            this.cb_papel.Name = "cb_papel";
            this.cb_papel.PromptText = "Papel";
            this.cb_papel.Size = new System.Drawing.Size(114, 29);
            this.cb_papel.Style = MetroFramework.MetroColorStyle.Black;
            this.cb_papel.TabIndex = 33;
            this.cb_papel.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(205, 196);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "NºBI :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(495, 152);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(51, 19);
            this.metroLabel6.TabIndex = 28;
            this.metroLabel6.Text = "Senha :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(495, 104);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(121, 19);
            this.metroLabel5.TabIndex = 27;
            this.metroLabel5.Text = "Nome do Usuario :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(205, 149);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(53, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Nome :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(201, 244);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "Telefone :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(201, 104);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(32, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "NIF:";
            // 
            // txt_telefoneF
            // 
            this.txt_telefoneF.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_telefoneF.CustomButton.Image = null;
            this.txt_telefoneF.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txt_telefoneF.CustomButton.Name = "";
            this.txt_telefoneF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_telefoneF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_telefoneF.CustomButton.TabIndex = 1;
            this.txt_telefoneF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_telefoneF.CustomButton.UseSelectable = true;
            this.txt_telefoneF.CustomButton.Visible = false;
            this.txt_telefoneF.Lines = new string[0];
            this.txt_telefoneF.Location = new System.Drawing.Point(201, 266);
            this.txt_telefoneF.MaxLength = 9;
            this.txt_telefoneF.Name = "txt_telefoneF";
            this.txt_telefoneF.PasswordChar = '\0';
            this.txt_telefoneF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_telefoneF.SelectedText = "";
            this.txt_telefoneF.SelectionLength = 0;
            this.txt_telefoneF.SelectionStart = 0;
            this.txt_telefoneF.ShortcutsEnabled = true;
            this.txt_telefoneF.Size = new System.Drawing.Size(264, 23);
            this.txt_telefoneF.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_telefoneF.TabIndex = 22;
            this.txt_telefoneF.UseCustomBackColor = true;
            this.txt_telefoneF.UseCustomForeColor = true;
            this.txt_telefoneF.UseSelectable = true;
            this.txt_telefoneF.UseStyleColors = true;
            this.txt_telefoneF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_telefoneF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_telefoneF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_telefoneF_KeyDown_1);
            this.txt_telefoneF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefoneF_KeyPress_1);
            // 
            // cb_sexoF
            // 
            this.cb_sexoF.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cb_sexoF.FormattingEnabled = true;
            this.cb_sexoF.ItemHeight = 23;
            this.cb_sexoF.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cb_sexoF.Location = new System.Drawing.Point(355, 304);
            this.cb_sexoF.Name = "cb_sexoF";
            this.cb_sexoF.PromptText = "Sexo";
            this.cb_sexoF.Size = new System.Drawing.Size(110, 29);
            this.cb_sexoF.Style = MetroFramework.MetroColorStyle.Black;
            this.cb_sexoF.TabIndex = 10;
            this.cb_sexoF.UseCustomBackColor = true;
            this.cb_sexoF.UseCustomForeColor = true;
            this.cb_sexoF.UseSelectable = true;
            this.cb_sexoF.UseStyleColors = true;
            // 
            // txt_emailF
            // 
            this.txt_emailF.BackColor = System.Drawing.Color.White;
            this.txt_emailF.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            // 
            // 
            // 
            this.txt_emailF.CustomButton.Image = null;
            this.txt_emailF.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.txt_emailF.CustomButton.Name = "";
            this.txt_emailF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_emailF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_emailF.CustomButton.TabIndex = 1;
            this.txt_emailF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_emailF.CustomButton.UseSelectable = true;
            this.txt_emailF.CustomButton.Visible = false;
            this.txt_emailF.Lines = new string[0];
            this.txt_emailF.Location = new System.Drawing.Point(495, 126);
            this.txt_emailF.MaxLength = 100;
            this.txt_emailF.Name = "txt_emailF";
            this.txt_emailF.PasswordChar = '\0';
            this.txt_emailF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_emailF.SelectedText = "";
            this.txt_emailF.SelectionLength = 0;
            this.txt_emailF.SelectionStart = 0;
            this.txt_emailF.ShortcutsEnabled = true;
            this.txt_emailF.Size = new System.Drawing.Size(236, 23);
            this.txt_emailF.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_emailF.TabIndex = 8;
            this.txt_emailF.UseCustomBackColor = true;
            this.txt_emailF.UseCustomForeColor = true;
            this.txt_emailF.UseSelectable = true;
            this.txt_emailF.UseStyleColors = true;
            this.txt_emailF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_emailF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_emailF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_emailF_KeyDown_1);
            this.txt_emailF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_emailF_KeyPress_1);
            // 
            // txt_senhaF
            // 
            this.txt_senhaF.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_senhaF.CustomButton.Image = null;
            this.txt_senhaF.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.txt_senhaF.CustomButton.Name = "";
            this.txt_senhaF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_senhaF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_senhaF.CustomButton.TabIndex = 1;
            this.txt_senhaF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_senhaF.CustomButton.UseSelectable = true;
            this.txt_senhaF.CustomButton.Visible = false;
            this.txt_senhaF.Lines = new string[0];
            this.txt_senhaF.Location = new System.Drawing.Point(495, 173);
            this.txt_senhaF.MaxLength = 10;
            this.txt_senhaF.Name = "txt_senhaF";
            this.txt_senhaF.PasswordChar = '●';
            this.txt_senhaF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_senhaF.SelectedText = "";
            this.txt_senhaF.SelectionLength = 0;
            this.txt_senhaF.SelectionStart = 0;
            this.txt_senhaF.ShortcutsEnabled = true;
            this.txt_senhaF.Size = new System.Drawing.Size(236, 23);
            this.txt_senhaF.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_senhaF.TabIndex = 6;
            this.txt_senhaF.UseCustomBackColor = true;
            this.txt_senhaF.UseCustomForeColor = true;
            this.txt_senhaF.UseSelectable = true;
            this.txt_senhaF.UseStyleColors = true;
            this.txt_senhaF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_senhaF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_senhaF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_senhaF_KeyDown_1);
            this.txt_senhaF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_senhaF_KeyPress_1);
            // 
            // txt_nomeF
            // 
            this.txt_nomeF.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_nomeF.CustomButton.Image = null;
            this.txt_nomeF.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txt_nomeF.CustomButton.Name = "";
            this.txt_nomeF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_nomeF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_nomeF.CustomButton.TabIndex = 1;
            this.txt_nomeF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_nomeF.CustomButton.UseSelectable = true;
            this.txt_nomeF.CustomButton.Visible = false;
            this.txt_nomeF.Lines = new string[0];
            this.txt_nomeF.Location = new System.Drawing.Point(201, 171);
            this.txt_nomeF.MaxLength = 100;
            this.txt_nomeF.Name = "txt_nomeF";
            this.txt_nomeF.PasswordChar = '\0';
            this.txt_nomeF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nomeF.SelectedText = "";
            this.txt_nomeF.SelectionLength = 0;
            this.txt_nomeF.SelectionStart = 0;
            this.txt_nomeF.ShortcutsEnabled = true;
            this.txt_nomeF.Size = new System.Drawing.Size(264, 23);
            this.txt_nomeF.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_nomeF.TabIndex = 5;
            this.txt_nomeF.UseCustomBackColor = true;
            this.txt_nomeF.UseCustomForeColor = true;
            this.txt_nomeF.UseSelectable = true;
            this.txt_nomeF.UseStyleColors = true;
            this.txt_nomeF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_nomeF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nomeF.TextChanged += new System.EventHandler(this.txt_nomeF_TextChanged);
            this.txt_nomeF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nomeF_KeyDown_1);
            // 
            // txt_nbiF
            // 
            this.txt_nbiF.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_nbiF.CustomButton.Image = null;
            this.txt_nbiF.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txt_nbiF.CustomButton.Name = "";
            this.txt_nbiF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_nbiF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_nbiF.CustomButton.TabIndex = 1;
            this.txt_nbiF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_nbiF.CustomButton.UseSelectable = true;
            this.txt_nbiF.CustomButton.Visible = false;
            this.txt_nbiF.Lines = new string[0];
            this.txt_nbiF.Location = new System.Drawing.Point(201, 218);
            this.txt_nbiF.MaxLength = 14;
            this.txt_nbiF.Name = "txt_nbiF";
            this.txt_nbiF.PasswordChar = '\0';
            this.txt_nbiF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nbiF.SelectedText = "";
            this.txt_nbiF.SelectionLength = 0;
            this.txt_nbiF.SelectionStart = 0;
            this.txt_nbiF.ShortcutsEnabled = true;
            this.txt_nbiF.Size = new System.Drawing.Size(264, 23);
            this.txt_nbiF.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_nbiF.TabIndex = 4;
            this.txt_nbiF.UseCustomBackColor = true;
            this.txt_nbiF.UseCustomForeColor = true;
            this.txt_nbiF.UseSelectable = true;
            this.txt_nbiF.UseStyleColors = true;
            this.txt_nbiF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_nbiF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nbiF.TextChanged += new System.EventHandler(this.txt_nbiF_TextChanged);
            this.txt_nbiF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nbiF_KeyDown_1);
            this.txt_nbiF.Leave += new System.EventHandler(this.txt_nbiF_Leave);
            // 
            // txt_idF
            // 
            // 
            // 
            // 
            this.txt_idF.CustomButton.Image = null;
            this.txt_idF.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txt_idF.CustomButton.Name = "";
            this.txt_idF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_idF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_idF.CustomButton.TabIndex = 1;
            this.txt_idF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_idF.CustomButton.UseSelectable = true;
            this.txt_idF.CustomButton.Visible = false;
            this.txt_idF.Enabled = false;
            this.txt_idF.Lines = new string[0];
            this.txt_idF.Location = new System.Drawing.Point(201, 126);
            this.txt_idF.MaxLength = 32767;
            this.txt_idF.Name = "txt_idF";
            this.txt_idF.PasswordChar = '\0';
            this.txt_idF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_idF.SelectedText = "";
            this.txt_idF.SelectionLength = 0;
            this.txt_idF.SelectionStart = 0;
            this.txt_idF.ShortcutsEnabled = true;
            this.txt_idF.Size = new System.Drawing.Size(114, 23);
            this.txt_idF.Style = MetroFramework.MetroColorStyle.Black;
            this.txt_idF.TabIndex = 3;
            this.txt_idF.UseSelectable = true;
            this.txt_idF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_idF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lk_excluirF
            // 
            this.lk_excluirF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lk_excluirF.Image = ((System.Drawing.Image)(resources.GetObject("lk_excluirF.Image")));
            this.lk_excluirF.ImageSize = 30;
            this.lk_excluirF.Location = new System.Drawing.Point(700, 21);
            this.lk_excluirF.Name = "lk_excluirF";
            this.lk_excluirF.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lk_excluirF.NoFocusImage")));
            this.lk_excluirF.Size = new System.Drawing.Size(33, 31);
            this.lk_excluirF.TabIndex = 52;
            this.lk_excluirF.UseSelectable = true;
            this.lk_excluirF.Visible = false;
            this.lk_excluirF.Click += new System.EventHandler(this.lk_excluirF_Click);
            // 
            // lk_salvarF
            // 
            this.lk_salvarF.Image = ((System.Drawing.Image)(resources.GetObject("lk_salvarF.Image")));
            this.lk_salvarF.ImageSize = 30;
            this.lk_salvarF.Location = new System.Drawing.Point(703, 21);
            this.lk_salvarF.Name = "lk_salvarF";
            this.lk_salvarF.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lk_salvarF.NoFocusImage")));
            this.lk_salvarF.Size = new System.Drawing.Size(29, 31);
            this.lk_salvarF.TabIndex = 53;
            this.lk_salvarF.UseSelectable = true;
            this.lk_salvarF.Click += new System.EventHandler(this.lk_salvarF_Click);
            // 
            // lk_restaura
            // 
            this.lk_restaura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lk_restaura.Image = ((System.Drawing.Image)(resources.GetObject("lk_restaura.Image")));
            this.lk_restaura.ImageSize = 30;
            this.lk_restaura.Location = new System.Drawing.Point(652, 21);
            this.lk_restaura.Name = "lk_restaura";
            this.lk_restaura.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lk_restaura.NoFocusImage")));
            this.lk_restaura.Size = new System.Drawing.Size(33, 31);
            this.lk_restaura.TabIndex = 54;
            this.lk_restaura.UseSelectable = true;
            this.lk_restaura.Visible = false;
            this.lk_restaura.Click += new System.EventHandler(this.lk_restaura_Click);
            // 
            // lk_excluirRec
            // 
            this.lk_excluirRec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lk_excluirRec.Image = ((System.Drawing.Image)(resources.GetObject("lk_excluirRec.Image")));
            this.lk_excluirRec.ImageSize = 30;
            this.lk_excluirRec.Location = new System.Drawing.Point(700, 21);
            this.lk_excluirRec.Name = "lk_excluirRec";
            this.lk_excluirRec.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lk_excluirRec.NoFocusImage")));
            this.lk_excluirRec.Size = new System.Drawing.Size(33, 31);
            this.lk_excluirRec.TabIndex = 55;
            this.lk_excluirRec.UseSelectable = true;
            this.lk_excluirRec.Visible = false;
            this.lk_excluirRec.Click += new System.EventHandler(this.lk_excluirRec_Click);
            // 
            // _CadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 520);
            this.ControlBox = false;
            this.Controls.Add(this.lk_excluirRec);
            this.Controls.Add(this.lk_restaura);
            this.Controls.Add(this.lk_excluirF);
            this.Controls.Add(this.lk_salvarF);
            this.Controls.Add(this.lk_sair);
            this.Controls.Add(this.lk_editarF);
            this.Controls.Add(this.tc_funcionario);
            this.Movable = false;
            this.Name = "_CadastrarFuncionario";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.tc_funcionario.ResumeLayout(false);
            this.tp_cadastrarFuncionario.ResumeLayout(false);
            this.tp_cadastrarFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_brF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imgF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink lk_sair;
        private MetroFramework.Controls.MetroLink lk_editarF;
        private MetroFramework.Controls.MetroTabControl tc_funcionario;
        private MetroFramework.Controls.MetroTabPage tp_cadastrarFuncionario;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.PictureBox pic_brF;
        private System.Windows.Forms.PictureBox pic_qrF;
        private MetroFramework.Controls.MetroTextBox txt_comfirSenha;
        private MetroFramework.Controls.MetroDateTime dt_datanasc;
        private MetroFramework.Controls.MetroButton btn_imgF;
        private System.Windows.Forms.PictureBox pic_imgF;
        private MetroFramework.Controls.MetroComboBox cb_papel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_telefoneF;
        private MetroFramework.Controls.MetroComboBox cb_sexoF;
        private MetroFramework.Controls.MetroTextBox txt_emailF;
        private MetroFramework.Controls.MetroTextBox txt_senhaF;
        private MetroFramework.Controls.MetroTextBox txt_nomeF;
        private MetroFramework.Controls.MetroTextBox txt_nbiF;
        private MetroFramework.Controls.MetroTextBox txt_idF;
        private MetroFramework.Controls.MetroLink lk_excluirF;
        private MetroFramework.Controls.MetroLink lk_salvarF;
        private MetroFramework.Controls.MetroLink lk_restaura;
        private MetroFramework.Controls.MetroLink lk_excluirRec;
    }
}