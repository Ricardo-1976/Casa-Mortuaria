namespace CasaMortuaria
{
    partial class _SalvarBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_SalvarBD));
            this.lk_sair = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.rb_copia_Seguranca = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // lk_sair
            // 
            this.lk_sair.Image = ((System.Drawing.Image)(resources.GetObject("lk_sair.Image")));
            this.lk_sair.ImageSize = 30;
            this.lk_sair.Location = new System.Drawing.Point(344, 15);
            this.lk_sair.Name = "lk_sair";
            this.lk_sair.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lk_sair.NoFocusImage")));
            this.lk_sair.Size = new System.Drawing.Size(38, 38);
            this.lk_sair.TabIndex = 34;
            this.lk_sair.UseSelectable = true;
            this.lk_sair.Click += new System.EventHandler(this.lk_sair_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageSize = 30;
            this.metroLink1.Location = new System.Drawing.Point(300, 15);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("metroLink1.NoFocusImage")));
            this.metroLink1.Size = new System.Drawing.Size(38, 38);
            this.metroLink1.TabIndex = 39;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(21, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(165, 25);
            this.metroLabel1.TabIndex = 38;
            this.metroLabel1.Text = "Cópia de Segurança";
            // 
            // rb_copia_Seguranca
            // 
            this.rb_copia_Seguranca.AutoSize = true;
            this.rb_copia_Seguranca.Location = new System.Drawing.Point(104, 97);
            this.rb_copia_Seguranca.Name = "rb_copia_Seguranca";
            this.rb_copia_Seguranca.Size = new System.Drawing.Size(187, 15);
            this.rb_copia_Seguranca.Style = MetroFramework.MetroColorStyle.Black;
            this.rb_copia_Seguranca.TabIndex = 41;
            this.rb_copia_Seguranca.Text = "Reduzindo Cópia de Segurança";
            this.rb_copia_Seguranca.UseSelectable = true;
            // 
            // _SalvarBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.ControlBox = false;
            this.Controls.Add(this.rb_copia_Seguranca);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lk_sair);
            this.Movable = false;
            this.Name = "_SalvarBD";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink lk_sair;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton rb_copia_Seguranca;
    }
}