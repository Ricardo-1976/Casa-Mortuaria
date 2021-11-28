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
using System.Security.Cryptography;

namespace CasaMortuaria
{
    public partial class _Bloquear : MetroFramework.Forms.MetroForm
    {
        string a;
        public _Bloquear()
        {
            InitializeComponent();
        }
        string hash = "f0xle@rn";
        #region Metodo para Desbloquear
        public void IniciarF(Usuario pessoa)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(txt_desbloquear.Text);
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

            DadosEditar.EditarDados.senhaFlong = a.Trim();

            pessoaBLL pessoaBll = new pessoaBLL();
            pessoaBll.IniciarF(pessoa);

        }
        #endregion
        private void metroLink1_Click(object sender, EventArgs e)
        {
            ctm_sai.Show(metroLink1, 0, metroLink1.Height);
        }

        private void btn_desbloquear_Click(object sender, EventArgs e)
        {
            bool vazio = false;
            if (txt_desbloquear.Text == string.Empty)
            {
                vazio = true;
            }
            if (vazio)
            {
                MessageBox.Show(this, "Preencha o Campo", "Campo Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Usuario pessoa = new Usuario();
                IniciarF(pessoa);

                if (DadosEditar.EditarDados.emailflong == DadosEditar.EditarDados.emailconf && DadosEditar.EditarDados.senhaFlong == DadosEditar.EditarDados.senhaconf)
                {
                    this.Hide();
                    txt_desbloquear.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Usuario Invalido", " Ou Senha Errada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_desbloquear.Text = string.Empty;
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
    }
}
