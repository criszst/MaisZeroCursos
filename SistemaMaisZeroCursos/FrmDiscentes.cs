using MaisZeroCursos.DTO.Model;
using SistemaMaisZeroCursos.Comum;
using SistemaMaisZeroCursos.Repository;
using System.Text;

namespace SistemaMaisZeroCursos
{
    public partial class FrmDiscentes : Form
    {
        public bool cadastrando = false;
        public bool editando = false;
        public FrmDiscentes()
        {
            InitializeComponent();
            lstDiscentes = new List<DiscentesModel>();
        }

        private List<DiscentesModel> lstDiscentes { get; set; }
        private string ValidarRegistro()
        {
            StringBuilder sb = new StringBuilder();

            var name = txtNome;
            var cpf = txtCpf;
            var dataNascimento = dtNascimento;

            DateTime idadeCorreta = Convert.ToDateTime(DateTime.Now.AddYears(-6).ToShortDateString());

            if (name.Text.Length < 4)
            {
                sb.Append("O nome deve ter pelo menos 4 letras.");
                name.Focus();
            }

            else if (!Cpf.validar(cpf.Text))
            {
                sb.Append("O CPF não é válido.");
                cpf.Focus();
            }

            else if (cadastrando && lstDiscentes.Any(c => c.Cpf == Cpf.formatarCpf(cpf.Text)))
            {
                sb.Append("Esse CPF já está registrado.");
                cpf.Focus();
            }

            else if (Convert.ToDateTime(dataNascimento.Text) >= Convert.ToDateTime(idadeCorreta))
            {
                sb.Append("A idade minima permitida é 6 anos.");
                dataNascimento.Focus();
            }

            return sb.ToString();
        }

        public void Registro()
        {
            var DiscenteRepository = new DiscentesRepository();
            _ = new List<DiscentesModel>();

            var name = txtNome.Text;
            var cpf = Cpf.formatarCpf(txtCpf.Text);
            DateTime dataNascimento = Convert.ToDateTime(dtNascimento.Text);

            var cbSexo = cboSexo.Text;
            var idCboSexo = Convert.ToInt32(cboSexo.SelectedValue);

            var txtStatus = cboStatus.Text;
            var idStatus = Convert.ToInt32(cboStatus.SelectedValue);

            var periodo = cboPeriodo.Text;
            var idPeriodo = Convert.ToInt32(cboPeriodo.SelectedValue);

            List<DiscentesModel>? lstDiscente = DiscenteRepository.Cadastrar(name, cpf, cbSexo, idCboSexo,
                dataNascimento, txtStatus, idStatus, periodo, idPeriodo,
                DateTime.Now);

            dgvDadosDiscentes.DataSource = lstDiscente;

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrando = true;
            ControlarComponentes();
            txtNome.Focus();
            Limpar();
        }

        private void FrmDiscentes_Load(object sender, EventArgs e)
        {
            cboPeriodo.DataSource = ControlarStatus.statusPeriodo();
            cboPeriodo.DisplayMember = "Descricao";
            cboPeriodo.ValueMember = "Id";

            cboSexo.DataSource = ControlarStatus.statusSexo();
            cboSexo.DisplayMember = "Descricao";
            cboSexo.ValueMember = "Id";

            cboStatus.DataSource = ControlarStatus.CarregarStatus();
            cboStatus.DisplayMember = "Descricao";
            cboStatus.ValueMember = "Id";

            txtBoxId.Visible = false;

            MostrarDadosTela();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void Pesquisar()
        {
            var discentesFiltro = lstDiscentes.Where(n => n.Name.Contains(txtSearch.Text)).ToList();

            MostrarDados(discentesFiltro);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                Pesquisar();
            }
            else
            {
                MostrarDadosTela();
            }
        }

        public void MostrarDados(List<DiscentesModel> lstDiscentes)
        {
            var sourceBinding = new BindingSource();
            sourceBinding.DataSource = lstDiscentes;

            dgvDadosDiscentes.DataSource = sourceBinding;

            if (dgvDadosDiscentes.DataSource != null && dgvDadosDiscentes.Rows.Count > 0)
            {
                FormatarGrid();
            }
        }

        private void MostrarDadosTela()
        {
            var DiscenteRepository = new DiscentesRepository();

            lstDiscentes = DiscenteRepository.CarregarDados();
            MostrarDados(lstDiscentes);

        }

        private void FormatarGrid()
        {
            dgvDadosDiscentes.Columns["Name"].HeaderText = "Nome";
            dgvDadosDiscentes.Columns["Cpf"].HeaderText = "CPF";
            dgvDadosDiscentes.Columns["SexoDiscente"].HeaderText = "Sexo";

            dgvDadosDiscentes.Columns["Status"].HeaderText = "Status";

            dgvDadosDiscentes.Columns["DataNascimento"].HeaderText = "Nascimento";
            dgvDadosDiscentes.Columns["DataCadastro"].HeaderText = "Cadastro";
            dgvDadosDiscentes.Columns["DataAtualizacao"].HeaderText = "Atualização";
            dgvDadosDiscentes.Columns["Periodo"].HeaderText = "Período";

            dgvDadosDiscentes.Columns["Id"].Visible = false;
            dgvDadosDiscentes.Columns["IdSexo"].Visible = false;
            dgvDadosDiscentes.Columns["Id"].Visible = false;
            dgvDadosDiscentes.Columns["IdStatus"].Visible = false;
            dgvDadosDiscentes.Columns["idPeriodo"].Visible = false;


            dgvDadosDiscentes.RowsDefaultCellStyle.BackColor = Color.White;
            dgvDadosDiscentes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void ControlarComponentes()
        {
            gbDiscentes.Enabled = !gbDiscentes.Enabled;
            btnBusca.Enabled = !btnBusca.Enabled;
            btnCancelar.Enabled = !btnCancelar.Enabled;
            btnSalvar.Enabled = !btnSalvar.Enabled;
            btnCadastrar.Enabled = !btnCadastrar.Enabled;
            btnEdit.Enabled = !btnEdit.Enabled;
            btnSair.Enabled = !btnSair.Enabled;
            dgvDadosDiscentes.Enabled = !dgvDadosDiscentes.Enabled;
        }

        private void Limpar()
        {
            txtNome.Text = String.Empty;
            txtCpf.Text = String.Empty;
            dtNascimento.Text = DateTime.Now.ToString();
            cboSexo.SelectedIndex = 0;
            cboPeriodo.SelectedIndex = 0;
        }
        private void Recarregar()
        {
            Limpar();
            ControlarComponentes();

            MostrarDadosTela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ValidarRegistro()))
            {
                if (cadastrando)
                {
                    Registro();
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
                MessageBox.Show(ValidarRegistro());
            }
        }

        private void dgvDadosDiscentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void AtualizarRegistro()
        {
            var discentesRepository = new DiscentesRepository();
            editando = true;


            var discenteModel = new DiscentesModel
            {
                Name = txtNome.Text,
                Id = int.Parse(txtBoxId.Text),
                Cpf = Cpf.formatarCpf(txtCpf.Text),
                SexoDiscente = cboSexo.Text,
                IdSexo = Convert.ToInt32(cboSexo.SelectedValue),

                DataNascimento = Convert.ToDateTime(dtNascimento.Text),

                Status = cboStatus.Text,
                IdStatus = Convert.ToInt32(cboStatus.SelectedValue),

                Periodo = cboPeriodo.Text,
                idPeriodo = Convert.ToInt32(cboPeriodo.SelectedValue),

                DataAtualizacao = DateTime.UtcNow.AddHours(-3),
            };
            discentesRepository.Atualizar(discenteModel);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cadastrando = false;
            ControlarComponentes();
            txtNome.Focus();
        }

        private void dgvDadosDiscentes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtNome.Text = dgvDadosDiscentes.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtCpf.Text = dgvDadosDiscentes.Rows[e.RowIndex].Cells["Cpf"].Value.ToString();
                txtBoxId.Text = dgvDadosDiscentes.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                cboSexo.SelectedValue = dgvDadosDiscentes.Rows[e.RowIndex].Cells["IdSexo"].Value;
                dtNascimento.Text = dgvDadosDiscentes.Rows[e.RowIndex].Cells["DataNascimento"].Value.ToString();
                cboStatus.SelectedValue = dgvDadosDiscentes.Rows[e.RowIndex].Cells["IdStatus"].Value;
                cboPeriodo.SelectedValue = dgvDadosDiscentes.Rows[e.RowIndex].Cells["idPeriodo"].Value;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Recarregar();
            cadastrando = false;
        }
    }
}
