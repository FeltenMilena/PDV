using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.EC;
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
        bool alterouImagem = false;
        string id;

        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void FormatarGrid()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "CPF";
            grid.Columns[3].HeaderText = "Telefone";
            grid.Columns[4].HeaderText = "Cargo";
            grid.Columns[5].HeaderText = "Endereço";
            grid.Columns[6].HeaderText = "Data";
            grid.Columns[7].HeaderText = "Imagem";

            grid.Columns[0].Visible = false;
            grid.Columns[7].Visible = false;
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            LimparFoto();
            Listar();
            alterouImagem = false;
        }

        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM funcionarios ORDER BY nome ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            FormatarGrid();
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
            HabilitaBotoes(true, false, true, false, false);
            habilitarCampos(false);
            LimparCampos();
            Listar();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg; *.png) | *.jpg; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString();
                image.ImageLocation = foto;
                alterouImagem = true;
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
            HabilitaBotoes(false, true, true, false, false);
            LimparCampos();
            txtNome.Focus();
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
        }

        public void LimparCampos()
        {
            txtNome.Text = "";
            txtCPF.Text = "";
            txtTelefone.Text = "";
            cbxCargo.Text = "";
            txtEndereco.Text = "";
            image.Text = "";
            LimparFoto();
        }

        public void HabilitaBotoes(bool novo, bool salvar, bool cancelar, bool editar, bool excluir)
        {
            btnNovo.Enabled = novo;
            btnSalvar.Enabled = salvar;
            btnCancelar.Enabled = cancelar;
            btnEditar.Enabled = editar;
            btnExcluir.Enabled = excluir;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitaBotoes(true, false, true, false, false);
            LimparCampos();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                habilitarCampos(true);
                HabilitaBotoes(false, false, true, true, true);

                id = grid.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txtCPF.Text = grid.CurrentRow.Cells[2].Value.ToString();
                txtTelefone.Text = grid.CurrentRow.Cells[3].Value.ToString();
                cbxCargo.Text = grid.CurrentRow.Cells[4].Value.ToString();
                txtEndereco.Text = grid.CurrentRow.Cells[5].Value.ToString();

                if (grid.CurrentRow.Cells[7].Value != DBNull.Value)
                {
                    byte[] imagem = (byte[])grid.Rows[e.RowIndex].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imagem);

                    image.Image = Image.FromStream(ms);
                }
                else
                {
                    image.Image = Properties.Resources.funcionarioSemFoto;
                }
            }
            else
            {
                return;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
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

            if (alterouImagem)
            {
                sql = "UPDATE funcionarios SET nome = @nome, cpf = @cpf, telefone = @telefone, cargo = @cargo, endereco = @endereco, foto = @foto WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@cargo", cbxCargo.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@foto", imagem());
            }
            else
            {
                sql = "UPDATE funcionarios SET nome = @nome, cpf = @cpf, telefone = @telefone, cargo = @cargo, endereco = @endereco WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@cargo", cbxCargo.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            }
            cmd.ExecuteNonQuery();
            con.FecharConexao();
            Listar();
            habilitarCampos(false);
            HabilitaBotoes(true, false, true, false, false);
            MessageBox.Show("Registro Editado com Sucesso!", "Cadastro Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
