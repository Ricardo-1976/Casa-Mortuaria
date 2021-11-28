using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CasaMortuaria.Model;
using CasaMortuaria.Bll;
using MetroFramework;
using System.Security.Cryptography;

namespace CasaMortuaria
{
    public partial class _Abrir : MetroFramework.Forms.MetroForm
    {
        string a;
        public _Abrir()
        {
            InitializeComponent();

        }

        string hash = "f0xle@rn";
        // Metodo para Salvar Funcionario
        public void IniciarF(Usuario pessoa)
        {
          byte[] data = UTF8Encoding.UTF8.GetBytes(txt_senha.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    a = Convert.ToBase64String(results, 0, results.Length);
                }
            }
            

            DadosEditar.EditarDados.emailflong = txt_email.Text.Trim();
            DadosEditar.EditarDados.senhaFlong = a.Trim();

            pessoaBLL pessoaBll = new pessoaBLL();
            pessoaBll.IniciarF(pessoa);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pb_iniciar.Value < 100)
            {
                pb_iniciar.Value = pb_iniciar.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                if (pl_iniciar.Left == 461)
                {
                    pl_abrir.Visible = false;
                    pl_abrir.Left = 461;

                    pl_iniciar.Visible = false;
                    pl_iniciar.Left = 2;
                    pl_iniciar.Visible = true;
                    pl_iniciar.Refresh();
                    timer1.Enabled = true;
                }
            }
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void lk_sair_Click(object sender, EventArgs e)
        {
            ctm_sair.Show(lk_sair, 0, lk_sair.Height);
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            bool vazio = false;
            if (txt_email.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_senha.Text == string.Empty)
            {
                vazio = true;
            }
            if (vazio)
            {
                MessageBox.Show(this, "Preencha todos os Campos", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Usuario pessoa = new Usuario();
                IniciarF(pessoa);

                if (DadosEditar.EditarDados.emailflong == DadosEditar.EditarDados.emailconf && DadosEditar.EditarDados.senhaFlong == DadosEditar.EditarDados.senhaconf)
                {
                    _Principal principal = new _Principal();
                    principal.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario Invalido", "O Email ou a Senha Esta Errada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_email.Text = string.Empty;
            txt_senha.Text = string.Empty;
        }
    }
}
