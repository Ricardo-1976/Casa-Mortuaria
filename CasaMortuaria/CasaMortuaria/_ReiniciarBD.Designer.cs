namespace CasaMortuaria
{
    partial class _ReiniciarBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_ReiniciarBD));
            this.lk_sair = new MetroFramework.Controls.MetroLink();
            this.txt_caminhobd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btn_procurar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lk_sair
            // 
            this.lk_sair.Image = ((System.Drawing.Image)(resources.GetObject("lk_sair.Image")));
            this.lk_sair.ImageSize = 30;
            this.lk_sair.Location = new System.Drawing.Point(343, 15);
            this.lk_sair.Name = "lk_sair";
            this.lk_sair.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lk_sair.NoFocusImage")));
            this.lk_sair.Size = new System.Drawing.Size(38, 38);
            this.lk_sair.TabIndex = 34;
            this.lk_sair.UseSelectable = true;
            this.lk_sair.Click += new System.EventHandler(this.lk_sair_Click);
            // 
            // txt_caminhobd
            // 
            // 
            // 
            // 
            this.txt_caminhobd.CustomButton.Image = null;
            this.txt_caminhobd.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.txt_caminhobd.CustomButton.Name = "";
            this.txt_caminhobd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_caminhobd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_caminhobd.CustomButton.TabIndex = 1;
            this.txt_caminhobd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_caminhobd.CustomButton.UseSelectable = true;
            this.txt_caminhobd.CustomButton.Visible = false;
            this.txt_caminhobd.DisplayIcon = true;
            this.txt_caminhobd.Enabled = false;
            this.txt_caminhobd.Lines = new string[0];
            this.txt_caminhobd.Location = new System.Drawing.Point(23, 110);
            this.txt_caminhobd.MaxLength = 32767;
            this.txt_caminhobd.Name = "txt_caminhobd";
            this.txt_caminhobd.PasswordChar = '\0';
            this.txt_caminhobd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_caminhobd.SelectedText = "";
            this.txt_caminhobd.SelectionLength = 0;
            this.txt_caminhobd.SelectionStart = 0;
            this.txt_caminhobd.ShortcutsEnabled = true;
            this.txt_caminhobd.Size = new System.Drawing.Size(287, 23);
            this.txt_caminhobd.TabIndex = 35;
            this.txt_caminhobd.UseSelectable = true;
            this.txt_caminhobd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_caminhobd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(206, 25);
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = "Restaura Banco de Dados";
            // 
            // metroLink1
            // 
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageSize = 30;
            this.metroLink1.Location = new System.Drawing.Point(302, 15);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("metroLink1.NoFocusImage")));
            this.metroLink1.Size = new System.Drawing.Size(38, 38);
            this.metroLink1.TabIndex = 37;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 38;
            this.metroLabel2.Text = "Nome da Cópia :";
            // 
            // btn_procurar
            // 
            this.btn_procurar.Location = new System.Drawing.Point(316, 110);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(63, 23);
            this.btn_procurar.TabIndex = 39;
            this.btn_procurar.Text = ".....";
            this.btn_procurar.UseSelectable = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // _ReiniciarBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 201);
            this.ControlBox = false;
            this.Controls.Add(this.btn_procurar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_caminhobd);
            this.Controls.Add(this.lk_sair);
            this.Movable = false;
            this.Name = "_ReiniciarBD";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink lk_sair;
        private MetroFramework.Controls.MetroTextBox txt_caminhobd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btn_procurar;
    }
}