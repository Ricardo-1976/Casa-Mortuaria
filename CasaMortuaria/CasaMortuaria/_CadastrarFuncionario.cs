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
    public partial class _CadastrarFuncionario : MetroFramework.Forms.MetroForm
    {
        string foto, dataF,a;
        public _CadastrarFuncionario()
        {
            InitializeComponent();

            #region Abir com dados 
            if (DadosEditar.EditarDados.v == true)
            {
                #region Pegar dados Para Editar 
                lk_salvarF.Visible = false;
                lk_editarF.Visible = true;
                lk_excluirF.Visible = true;

                #region Dados do Usuario
                txt_idF.Text = DadosEditar.EditarDados.id_fun;
                txt_nomeF.Text = DadosEditar.EditarDados._nomeF;
                txt_nbiF.Text = DadosEditar.EditarDados._nbiF;
                cb_sexoF.Text = DadosEditar.EditarDados._sexoF;
                dt_datanasc.Text = DadosEditar.EditarDados._dataF;
                txt_emailF.Text = DadosEditar.EditarDados._emailF;
                txt_senhaF.Text = DadosEditar.EditarDados._senhaF;
                txt_comfirSenha.Text = DadosEditar.EditarDados._senhaF;
                txt_telefoneF.Text = DadosEditar.EditarDados._telefoneF;
                cb_papel.Text = DadosEditar.EditarDados._papelF;
                pic_imgF.ImageLocation = DadosEditar.EditarDados._imgF;
                foto = DadosEditar.EditarDados._imgF;

                DadosEditar.EditarDados.v = false;

                #endregion
                #endregion
            }

            if (DadosEditar.EditarDados.v1 == 2)
            {
                #region Dados do Usuario
                lk_salvarF.Visible = false;
                lk_editarF.Visible = false;
                lk_excluirRec.Visible = true;
                lk_restaura.Visible = true;
       
                
                txt_idF.Text = DadosEditar.EditarDados.id_fun;
                txt_nomeF.Text = DadosEditar.EditarDados._nomeF;
                txt_nbiF.Text = DadosEditar.EditarDados._nbiF;
                cb_sexoF.Text = DadosEditar.EditarDados._sexoF;
                dt_datanasc.Text = DadosEditar.EditarDados._dataF;
                txt_emailF.Text = DadosEditar.EditarDados._emailF;
                txt_senhaF.Text = DadosEditar.EditarDados._senhaF;
                txt_comfirSenha.Text = DadosEditar.EditarDados._senhaF;
                txt_telefoneF.Text = DadosEditar.EditarDados._telefoneF;
                cb_papel.Text = DadosEditar.EditarDados._papelF;
                pic_imgF.ImageLocation = DadosEditar.EditarDados._imgF;
                foto = DadosEditar.EditarDados._imgF;

                DadosEditar.EditarDados.v1 = 0;

                #endregion

                #region Nao editar 
                cb_papel.Enabled = false;
                txt_nomeF.Enabled = false;
                txt_nbiF.Enabled = false;
                txt_telefoneF.Enabled = false;
                cb_sexoF.Enabled = false;
                dt_datanasc.Enabled = false;
                txt_emailF.Enabled = false;
                txt_senhaF.Enabled = false;
                txt_comfirSenha.Enabled = false;
                btn_imgF.Enabled = false;
                #endregion
            }
            #endregion
        }
        string hash = "f0xle@rn";
        // Metodo para Salvar Funcionario
        public void salvar(Usuario pessoa)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(txt_senhaF.Text);
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

            pessoa._nome = txt_nomeF.Text.Trim();
            pessoa._nbi = txt_nbiF.Text.Trim();
            pessoa._sexo = cb_sexoF.Text.Trim();
            pessoa._data_nascimento = dataF.Trim();
            pessoa._email = txt_emailF.Text.Trim();
            pessoa._senha = a.Trim();
            pessoa._telefone = txt_telefoneF.Text.Trim();
            pessoa._papel = cb_papel.Text.Trim();
            pessoa._img = foto;

            pessoaBll.salvarUsu(pessoa);

            MessageBox.Show(this, "Pessoa salva com sucesso!", "Arquivo Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Metodo permitir cadastrar Funcionário
        public void permiF(Usuario pessoa)
        {
            DadosEditar.EditarDados.nbi_fun = txt_nbiF.Text;

            pessoaBLL pessoaBll = new pessoaBLL();
            pessoaBll.permiF(pessoa);

            string nome = DadosEditar.EditarDados.nomeconf;
        }
        // Metodo para Editarr Funcionario
        public void EditarUs(Usuario pessoa)
        {

            byte[] data = UTF8Encoding.UTF8.GetBytes(txt_senhaF.Text);
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

            pessoa.id_usuario = Convert.ToInt32(txt_idF.Text.Trim());
            pessoa._nome = txt_nomeF.Text.Trim();
            pessoa._nbi = txt_nbiF.Text.Trim();
            pessoa._sexo = cb_sexoF.Text.Trim();
            pessoa._data_nascimento = dataF.Trim();
            pessoa._email = txt_emailF.Text.Trim();
            pessoa._senha = a.Trim();
            pessoa._telefone = txt_telefoneF.Text.Trim();
            pessoa._papel = cb_papel.Text.Trim();
            pessoa._img = foto.Trim();

            pessoaBll.EditarUs(pessoa);

            MessageBox.Show(this, "O Funcionario foi Atualizado com sucesso", "Arquivo Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        // Metodo para Excluir um registro
        private void excluirUs(Usuario pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_usuario = Convert.ToInt32(txt_idF.Text);

            pessoaBll.excluirUs(pessoa);

            MessageBox.Show(this, "O Funcionário foi Excluido com sucesso", "Arquivo Excluido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        // Metodo para Excluir um registro na reciclagem
        private void excluirRecUs(Usuario pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa.id_usuario = Convert.ToInt32(txt_idF.Text);

            pessoaBll.excluirRecUs(pessoa);

            MessageBox.Show(this, "O Funcionario foi Excluido na Reciclagem com Sucesso", "Arquivo Excluido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        // Metodo para Enviar um Funcionario na Resiclagem
        public void EnviarRec(Usuario pessoa)
        {
            pessoaBLL pessoaBll = new pessoaBLL();

            pessoa._nome = txt_nomeF.Text.Trim();
            pessoa._nbi = txt_nbiF.Text.Trim();
            pessoa._sexo = cb_sexoF.Text.Trim();
            pessoa._data_nascimento = dataF.Trim();
            pessoa._email = txt_emailF.Text.Trim();
            pessoa._senha = txt_senhaF.Text.Trim();
            pessoa._telefone = txt_telefoneF.Text.Trim();
            pessoa._papel = cb_papel.Text.Trim();
            pessoa._img = foto;

            pessoaBll.EnviarRec(pessoa);

        }
        // Metodo para Limpar Campo 
        public void limparcampoF()
        {
            pic_imgF.ImageLocation = string.Empty;
            txt_idF.Text = string.Empty;
            txt_nomeF.Text = string.Empty;
            txt_nbiF.Text = string.Empty;
            txt_telefoneF.Text = string.Empty;
            txt_emailF.Text = string.Empty;
            txt_senhaF.Text = string.Empty;
            txt_comfirSenha.Text = string.Empty;
            cb_papel.Text = string.Empty;
            cb_sexoF.Text = string.Empty;
            dt_datanasc.Text = string.Empty;
            pic_qrF.ImageLocation = string.Empty;
            pic_brF.ImageLocation = string.Empty;
        }

        private void lk_excluirF_Click(object sender, EventArgs e)
        {
            #region Eliminar Funcionario no Sistema
            Usuario pessoa = new Usuario();
            if (txt_idF.Text == string.Empty)
            {
                MessageBox.Show(this, "Selecione a pessoa que prentendes Excluir", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show(this, "Deseja realmente Excluir esta pessoa", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {

                }
                else
                {

                    DateTime data = dt_datanasc.Value;
                    DateTime datav = metroDateTime1.Value;

                    if (data < datav)
                    {
                        dataF = data.Year + "-" + data.Month + "-" + data.Day;

                    }
                    else
                    {
                        MessageBox.Show(this, "Ainda não estamos neste ano: " + data, "Verifica a Data Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    excluirUs(pessoa);
                    EnviarRec(pessoa);
                    limparcampoF();
                }
            }
            #endregion
        }
        
        private void lk_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lk_editarF_Click(object sender, EventArgs e)
        {
            #region Verificação dos campos
            bool vazio = false;
            if (txt_nomeF.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_nbiF.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_telefoneF.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_emailF.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_senhaF.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_comfirSenha.Text == string.Empty)
            {
                vazio = true;
            }
            if (cb_sexoF.Text == string.Empty)
            {
                vazio = true;
            }
            if (cb_papel.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_senhaF.Text != txt_comfirSenha.Text)
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

                DateTime datav = metroDateTime1.Value;
                DateTime data = dt_datanasc.Value;

                if (data <= datav)
                {
                    dataF = data.Year + "-" + data.Month + "-" + data.Day;

                    foto = pic_imgF.ImageLocation;
                    Usuario pessoa = new Usuario();
                    EditarUs(pessoa);
                }
                else
                {
                    MessageBox.Show(this, "Ainda não estamos neste ano: " + data.Date, "Verifica a Data Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            #endregion
        }

        private void lk_salvarF_Click(object sender, EventArgs e)
        {
            #region Verificação dos campos
            bool vazio = false;
            if (txt_nomeF.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_nbiF.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_telefoneF.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_emailF.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_senhaF.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_comfirSenha.Text == string.Empty)
            {
                vazio = true;
            }
            if (cb_sexoF.Text == string.Empty)
            {
                vazio = true;
            }
            if (cb_papel.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_senhaF.Text != txt_comfirSenha.Text)
            {
                MessageBox.Show(this,"Senhas Diferentes","Senha Incorreta", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (vazio)
            {
                MessageBox.Show(this, "Preencha todos os Campos", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime data = dt_datanasc.Value;
                DateTime datav = metroDateTime1.Value;

                int result = datav.Year - data.Year;

                if (result >= 18)
                {
                    dataF = data.Year + "-" + data.Month + "-" + data.Day;

                    Usuario pessoa = new Usuario();
                    //Comfirmar Funcionário 
                    permiF(pessoa);
                    if (txt_nbiF.Text != DadosEditar.EditarDados.nbi_conf_fu)
                    {
                        //Salvar Funcionário
                        salvar(pessoa);
                        limparcampoF();
                        
                    }
                    else
                    {
                        MessageBox.Show("O Funcioário já foi encontrado no Sistema com nome de " + DadosEditar.EditarDados.nomeconf, "O Funcionário ja Existe !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Este Funcionário não é Maior de Idade ", "Verifica a Data Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            #endregion
        }

        private void btn_imgF_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.Jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString();
                pic_imgF.ImageLocation = foto;
            }
        }

        #region Mudar de textbox e Negar Caracter especias 
        private void txt_nbiF_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txt_telefoneF.Focus();
            }
        }

        private void txt_telefoneF_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txt_emailF.Focus();
            }
        }

        private void txt_emailF_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txt_senhaF.Focus();
            }
        }

        private void txt_senhaF_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txt_comfirSenha.Focus();
            }
        }

        private void txt_nomeF_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            string n = "1234567890!#$%&/{[()]}='?«»+*ºª_-,.;:><@£§|";
            if (n.Contains(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_nbiF_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            string n = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (!n.Contains(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_telefoneF_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            string n = "1234567890";
            if (!n.Contains(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_emailF_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            string n = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (!n.Contains(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_senhaF_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            string n = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (!n.Contains(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_comfirSenha_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            string n = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (!n.Contains(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txt_nomeF_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txt_nbiF.Focus();
            }
        }

        #endregion
        private void lk_excluirRec_Click(object sender, EventArgs e)
        {
            #region Eliminar Funcionario na reciclagem
            if (MessageBox.Show(this, "Deseja realmente Excluir esta pessoa", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                Usuario pessoa = new Usuario();
                excluirRecUs(pessoa);
                limparcampoF();
            }
            #endregion
        }

        private void txt_nomeF_TextChanged(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pic_qrF.Image = qrcode.Draw(txt_nomeF.Text, 50);
        }

        private void txt_nbiF_Leave(object sender, EventArgs e)
        {
            
        }

        private void txt_nbiF_TextChanged(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pic_brF.Image = barcode.Draw(txt_nbiF.Text, 50);
        }

        private void lk_restaura_Click(object sender, EventArgs e)
        {
            #region Verificação dos campos
            bool vazio = false;
            if (txt_nomeF.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_nbiF.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_telefoneF.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_emailF.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_senhaF.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_comfirSenha.Text == string.Empty)
            {
                vazio = true;
            }
            if (cb_sexoF.Text == string.Empty)
            {
                vazio = true;
            }
            if (cb_papel.Text == string.Empty)
            {
                vazio = true;
            }
            if (txt_senhaF.Text != txt_comfirSenha.Text)
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
                DateTime data = dt_datanasc.Value;
                DateTime datav = metroDateTime1.Value;

                if (data <= datav)
                {
                    dataF = data.Year + "-" + data.Month + "-" + data.Day;

                    Usuario pessoa = new Usuario();
                    //Comfirmar Funcionário 
                    permiF(pessoa);
                    if (txt_nbiF.Text != DadosEditar.EditarDados.nbi_conf_fu)
                    {
                        //Salvar Funcionário
                        salvar(pessoa);
                        excluirRecUs(pessoa);
                        limparcampoF();

                    }
                    else
                    {
                        MessageBox.Show("O Funcioário já foi encontrado no Sistema com nome de " + DadosEditar.EditarDados.nomeconf, "O Funcionário ja Existe !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Ainda não estamos neste ano: " + data, "Verifica a Data Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            #endregion
        }

    }
}
