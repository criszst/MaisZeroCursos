using MaisZeroCursos.DTO.Model;
using SistemaMaisZeroCursos.Comum;
using SistemaMaisZeroCursos.Repository;
using SistemaMaisZeroCursos.WebAPI;
using System.Text;
using System.Xml.Linq;

namespace SistemaMaisZeroCursos
{
    public partial class FrmDisciplinas : Form
    {
        public bool cadastrando = false;
        public bool editando = false;
        public FrmDisciplinas()
        {
            InitializeComponent();
            LstDisciplinas = new List<DisciplinasModel>();
        }

        private List<DisciplinasModel> LstDisciplinas { get; set; }

        private string Validar()
        {
            StringBuilder sbMsg = new StringBuilder();
            if (string.IsNullOrEmpty(txtDisciplinas.Text))
            {
                sbMsg.Append("Campo disciplina não pode estar vazio.");
                txtDisciplinas.Focus();
            }
            else if (txtDisciplinas.TextLength < 5)
            {
                sbMsg.Append("O nome da disciplina não pode ter menos que 5 letras.");
                txtDisciplinas.Focus();

            }
            else if (LstDisciplinas.Any(d => d.NomeDisciplina == txtDisciplinas.Text))
            {
                sbMsg.Append("Já existe uma disciplina cadastrada com esse nome.");
                txtDisciplinas.Focus();
            }

            return sbMsg.ToString();

        }

        private void Registrar()
        {
            if (cboStatus.SelectedIndex != -1)
            {
                var disciplina = new DisciplinasModel
                {
                    NomeDisciplina = txtDisciplinas.Text,
                    IdStatus = Convert.ToInt32(cboStatus.SelectedValue),
                    DescricaoStatus = cboStatus.Text,
                    DataCadastro = DateTime.UtcNow.AddHours(-3)
                };

                var webApi = new DisciplinaWebApi();

               dgvDados.DataSource = webApi.Cadastrar(disciplina);
            }
        }

        private void FrmDisciplinas_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void FrmDisciplinas_Load_1(object sender, EventArgs e)
        {
            cboStatus.DataSource = ControlarStatus.CarregarStatus();
            cboStatus.DisplayMember = "Descricao";
            cboStatus.ValueMember = "Id";

            MostrarDadosTela();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrando = true;
            ControlarComponentes();
            txtDisciplinas.Focus();
            Limpar();
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                txtDisciplinas.Text = dgvDados.Rows[e.RowIndex].Cells["NomeDisciplina"].Value.ToString();
                cboStatus.SelectedValue = dgvDados.Rows[e.RowIndex].Cells["IdStatus"].Value;
                txtBoxID.Text = dgvDados.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtBoxDataCadastro.Text = dgvDados.Rows[e.RowIndex].Cells["DataCadastro"].Value.ToString();
                txtBoxDataAtualizacao.Text = dgvDados.Rows[e.RowIndex].Cells["DataAtualizacao"].Value.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPesquisa.Text))
            {
                Pesquisar();
            }
            else
            {
                MessageBox.Show("Digite um valor para pesquisar");
            }
        }

        public void MostrarDados(List<DisciplinasModel> lstDisciplina)
        {
            var sourceBinding = new BindingSource();

            sourceBinding.DataSource = lstDisciplina;

            dgvDados.DataSource = sourceBinding;

            if (dgvDados.DataSource != null && dgvDados.Rows.Count > 0)
            {
                FormatarGrid();
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPesquisa.Text))
            {
                Pesquisar();
            }
            else
            {
                var webApi = new DisciplinaWebApi();

                var lstApi = webApi.CarregarDados();
                
                MostrarDados(lstApi);
            }
        }

        public void Pesquisar()
        {
            var webApi = new DisciplinaWebApi();

            var pesquisa = webApi.PesquisarNome(txtPesquisa.Text);

            MostrarDados(pesquisa);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cadastrando = false;
            ControlarComponentes();
            txtDisciplinas.Focus();
        }

        private void ControlarComponentes()
        {
            gbDados.Enabled = !gbDados.Enabled;
            btnBuscar.Enabled = !btnBuscar.Enabled;
            btnCancelar.Enabled = !btnCancelar.Enabled;
            btnSalvar.Enabled = !btnSalvar.Enabled;
            btnCadastrar.Enabled = !btnCadastrar.Enabled;
            btnEdit.Enabled = !btnEdit.Enabled;
            btnSair.Enabled = !btnSair.Enabled;
            dgvDados.Enabled = !dgvDados.Enabled;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var msg = Validar();
            if (string.IsNullOrEmpty(msg))
            {
                if (cadastrando)
                {
                    Registrar();
                    Recarregar();
                }
                else
                {
                    AtualizarRegistro();

                    if (editando) Recarregar();
                }

            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void Limpar()
        {
            txtDisciplinas.Text = string.Empty;
            txtPesquisa.Text = string.Empty;
            cboStatus.SelectedIndex = 0;
        }

        private void Recarregar()
        {
            Limpar();
            ControlarComponentes();

            MostrarDadosTela();
        }

        private void MostrarDadosTela()
        {
            var webApi = new DisciplinaWebApi();

            var lstApi = webApi.CarregarDados();

            MostrarDados(lstApi);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Recarregar();
            cadastrando = false;
        }

        private void AtualizarRegistro()
        {
            editando = true;

            if (cboStatus.SelectedIndex != -1)
            {
                var disciplinaModel = new DisciplinasModel
                {
                    NomeDisciplina = txtDisciplinas.Text,
                    DescricaoStatus = cboStatus.Text,
                    Id = int.Parse(txtBoxID.Text),
                    IdStatus = Convert.ToInt32(cboStatus.SelectedValue),
                    DataAtualizacao = DateTime.UtcNow.AddHours(-3),
                };

                var webApi = new DisciplinaWebApi();

                webApi.Atualizar(disciplinaModel);

            }

        }

        private void FormatarGrid()
        {
            dgvDados.Columns["Id"].HeaderText = "Código";
            dgvDados.Columns["NomeDisciplina"].HeaderText = "Disciplina";
            dgvDados.Columns["IdStatus"].HeaderText = "Código Status";
            dgvDados.Columns["DescricaoStatus"].HeaderText = "Status";
            dgvDados.Columns["DataCadastro"].HeaderText = "Cadastro";
            dgvDados.Columns["DataAtualizacao"].HeaderText = "Atualização";

            dgvDados.Columns["Id"].Visible = false;
            dgvDados.Columns["IdStatus"].Visible = false;

            dgvDados.RowsDefaultCellStyle.BackColor = Color.White;
            dgvDados.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }
    }
}
