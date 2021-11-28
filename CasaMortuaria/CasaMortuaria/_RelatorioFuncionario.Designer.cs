namespace CasaMortuaria
{
    partial class _RelatorioFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_RelatorioFuncionario));
            this.lk_sair = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // lk_sair
            // 
            this.lk_sair.Image = ((System.Drawing.Image)(resources.GetObject("lk_sair.Image")));
            this.lk_sair.ImageSize = 30;
            this.lk_sair.Location = new System.Drawing.Point(848, 19);
            this.lk_sair.Name = "lk_sair";
            this.lk_sair.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lk_sair.NoFocusImage")));
            this.lk_sair.Size = new System.Drawing.Size(38, 38);
            this.lk_sair.TabIndex = 34;
            this.lk_sair.UseSelectable = true;
            this.lk_sair.Click += new System.EventHandler(this.lk_sair_Click);
            // 
            // _RelatorioFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 525);
            this.ControlBox = false;
            this.Controls.Add(this.lk_sair);
            this.Movable = false;
            this.Name = "_RelatorioFuncionario";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink lk_sair;
    }
}