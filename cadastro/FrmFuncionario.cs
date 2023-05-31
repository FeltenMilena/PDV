using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class FrmFuncionario : Form
    {

        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string foto;

        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            LimparFoto();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo Nome inválido", "Cadastro Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (txtCPF.Text == "   ,   ,   -" || txtCPF.Text.Length < 14)
            {
                MessageBox.Show("Campo CPF inválido", "Cadastro Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCPF.Focus();
                return;
            }

            con.AbrirConexao();

            sql = "INSERT INTO funcionarios(nome, cpf, telefone, cargo, endereco, data, foto) VALUES(@nome, @cpf, @telefone, @cargo, @endereco, curDate(), @foto)";

            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@cargo", cbxCargo.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@foto", imagem());

            cmd.ExecuteNonQuery();
            con.FecharConexao();

            LimparFoto();
            MessageBox.Show("Registro Salvo com Sucesso!", "Cadastro Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            habilitarCampos(false);
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg; *.png) | *.jpg; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString();
                image.ImageLocation = foto;
            }
        }

        private byte[] imagem()
        {
            byte[] imagem_byte = null;
            if (foto == "")
            {
                return null;
            }

            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            imagem_byte = br.ReadBytes((int)fs.Length);
            return imagem_byte;
        }
        private void LimparFoto()
        {
            image.Image = Properties.Resources.funcionarioSemFoto;
            foto = "imagens/funcionarioSemFoto.png";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos(true);
        }

        public void habilitarCampos(bool habilita)
        {
            txtNome.Enabled = habilita;
            txtCPF.Enabled = habilita;
            txtTelefone.Enabled = habilita;
            cbxCargo.Enabled = habilita;
            txtEndereco.Enabled = habilita;
            image.Enabled = habilita;
            btnFoto.Enabled = habilita;
            btnSalvar.Enabled = habilita;
            btnNovo.Enabled = ! habilita;
        }
    }
}
