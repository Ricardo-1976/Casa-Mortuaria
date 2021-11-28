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
    public partial class _AlterarPasse : MetroFramework.Forms.MetroForm
    {
        string a;
        public _AlterarPasse()
        {
            InitializeComponent();
            lb_NomeUsuario.Text = DadosEditar.EditarDados.nome_flong;
        }
        string hash = "f0xle@rn";
        // Metodo para Editarr Funcionario
        public void EditarUsPs(Usuario pessoa)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(txt_novasenha.Text.Trim());
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

            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_usuario = Convert.ToInt32(DadosEditar.EditarDados.id_flong);
            pessoa._senha = a.Trim();
          
            pessoaBll.EditarUsPs(pessoa);

            MessageBox.Show(this, "A senha foi Atualizado com sucesso", "Arquivo Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_senhaatual.Text = string.Empty;
            txt_confirsenha.Text = string.Empty;
            txt_novasenha.Text = string.Empty;
        }

        private void lk_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(txt_senhaatual.Text.Trim());
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
            txt_senhaatual.Text = a;
            bool vazio = false;
            if (txt_senhaatual.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_novasenha.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_confirsenha.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_senhaatual.Text != DadosEditar.EditarDados.senhaconf)
            {
                MessageBox.Show(this, "Senhas Diferentes", "Senha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_novasenha.Text != txt_confirsenha.Text)
            {
                MessageBox.Show(this, "Senhas Diferentes", "Senha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (vazio)
            {
                MessageBox.Show(this, "Preencha todos os Campos", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Usuario pessoa = new Usuario();
                EditarUsPs(pessoa);
                txt_senhaatual.Text = string.Empty;
                txt_novasenha.Text = string.Empty;
                txt_confirsenha.Text = string.Empty;
            }
        }
    }
}
