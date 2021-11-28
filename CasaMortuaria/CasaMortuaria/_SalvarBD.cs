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
    public partial class _SalvarBD : MetroFramework.Forms.MetroForm
    {
        public _SalvarBD()
        {
            InitializeComponent();
        }

        private void lk_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroLink1_Click_1(object sender, EventArgs e)
        {
            if (rb_copia_Seguranca.Checked)
            {
                string conn = "server=localhost; port=3306; User id=root;database=bd_casamortuaria; password='' ";

                string file;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "SQL Dump File (*.sql) |*.sql|All Files (*.*)|*.*";
                sfd.FileName = "CasaMortuaria.sql";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    file = sfd.FileName;
                    using (MySqlConnection con = new MySqlConnection(conn))
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                cmd.Connection = con;
                                con.Open();
                                mb.ExportToFile(file);
                                con.Close();
                            }
                        }
                    }
                    MessageBox.Show(this,"Cópia de Segurança feita com Sucesso","Arquivo Salvo");
                }
            }
            else
            {
                MessageBox.Show(this,"Selecione a Opção para fazer a Cópia","Alerta",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
