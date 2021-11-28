namespace CasaMortuaria
{
    partial class _PesquisaemMassa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_PesquisaemMassa));
            this.lk_sair = new MetroFramework.Controls.MetroLink();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txt_pesquisar = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroTabControl1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lk_sair
            // 
            this.lk_sair.Image = ((System.Drawing.Image)(resources.GetObject("lk_sair.Image")));
            this.lk_sair.ImageSize = 30;
            this.lk_sair.Location = new System.Drawing.Point(957, 7);
            this.lk_sair.Name = "lk_sair";
            this.lk_sair.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lk_sair.NoFocusImage")));
            this.lk_sair.Size = new System.Drawing.Size(35, 38);
            this.lk_sair.TabIndex = 37;
            this.lk_sair.UseSelectable = true;
            this.lk_sair.Click += new System.EventHandler(this.lk_sair_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 51);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(965, 460);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabControl1.TabIndex = 38;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(957, 418);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txt_pesquisar);
            this.metroPanel1.Controls.Add(this.metroDateTime1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(282, 45);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(702, 38);
            this.metroPanel1.TabIndex = 39;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txt_pesquisar.CustomButton.Image = null;
            this.txt_pesquisar.CustomButton.Location = new System.Drawing.Point(400, 1);
            this.txt_pesquisar.CustomButton.Name = "";
            this.txt_pesquisar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_pesquisar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pesquisar.CustomButton.TabIndex = 1;
            this.txt_pesquisar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pesquisar.CustomButton.UseSelectable = true;
            this.txt_pesquisar.CustomButton.Visible = false;
            this.txt_pesquisar.DisplayIcon = true;
            this.txt_pesquisar.ForeColor = System.Drawing.Color.Black;
            this.txt_pesquisar.Icon = ((System.Drawing.Image)(resources.GetObject("txt_pesquisar.Icon")));
            this.txt_pesquisar.Lines = new string[0];
            this.txt_pesquisar.Location = new System.Drawing.Point(261, 12);
            this.txt_pesquisar.MaxLength = 32767;
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.PasswordChar = '\0';
            this.txt_pesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pesquisar.SelectedText = "";
            this.txt_pesquisar.SelectionLength = 0;
            this.txt_pesquisar.SelectionStart = 0;
            this.txt_pesquisar.ShortcutsEnabled = true;
            this.txt_pesquisar.Size = new System.Drawing.Size(422, 23);
            this.txt_pesquisar.Style = MetroFramework.MetroColorStyle.Black;
            this.txt_pesquisar.TabIndex = 44;
            this.txt_pesquisar.UseSelectable = true;
            this.txt_pesquisar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pesquisar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime1.Location = new System.Drawing.Point(61, 6);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(123, 29);
            this.metroDateTime1.TabIndex = 2;
            // 
            // _PesquisaemMassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 534);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.lk_sair);
            this.Movable = false;
            this.Name = "_PesquisaemMassa";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabControl1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLink lk_sair;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txt_pesquisar;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
    }
}