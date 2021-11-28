using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CasaMortuaria
{
    public partial class _ReiniciarBD : MetroFramework.Forms.MetroForm
    {
        string conn = "server=localhost; port=3306; User id=root;database=bd_casamortuaria; password='' ";
        string file;

        public _ReiniciarBD()
        {
            InitializeComponent();
        }

        private void lk_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "SQL Dump File (*.sql) |*.sql|All Files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                file = dialog.FileName;
                txt_caminhobd.Text = file;
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            if (txt_caminhobd.Text == string.Empty)
            {
                MessageBox.Show(this, "Seleciona o Arquivo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (MySqlConnection con = new MySqlConnection(conn))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = con;
                            con.Open();
                            mb.ImportFromFile(file);
                            con.Close();
                        }
                    }
                }

                MessageBox.Show(this, "O Arquivo Restaurado com Sucesso", "Arquivo Restaurado", MessageBoxButtons.OK, MessageBoxIcon.None);
                txt_caminhobd.Text = string.Empty;
            }
        }
    }
}
