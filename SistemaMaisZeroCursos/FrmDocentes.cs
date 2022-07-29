using System.Text;
using SistemaMaisZeroCursos.Comum;
using SistemaMaisZeroCursos.Repository;
using SistemaMaisZeroCursos.Model;

namespace SistemaMaisZeroCursos
{
    public partial class FrmDocentes : Form
    {
        public bool cadastrando = false;
        public bool editando = false;

        public FrmDocentes()
        {
            InitializeComponent();
            lstDocentes = new List<DocentesModel>();
        }

        private List<DocentesModel> lstDocentes { get; set; }

        private string ValidarRegistro()
        {
            StringBuilder sb = new StringBuilder();

            var name = txtNome;
            var cpf = txtCpf;
            var dataNascimento = dtNascimento;

            DateTime idadeCorreta = Convert.ToDateTime(DateTime.Now.AddYears(-18).ToShortDateString());

             if (name.Text.Length < 4)
            {
                sb.Append("O nome deve ter pelo menos 4 letras");
                name.Focus();
            }

            else if (!Cpf.validar(cpf.Text)) {
                sb.Append("O CPF não é válido.");
                cpf.Focus();
            }
            else if (cadastrando && lstDocentes.Any(c => Cpf.formatarCpf(c.Cpf) == Cpf.formatarCpf(cpf.Text)))
            {
                sb.Append("Esse CPF já está cadastrado.");
                cpf.Focus();
            }

            else if (Convert.ToDateTime(dataNascimento.Text) >= Convert.ToDateTime(idadeCorreta))
            {
                sb.Append("A idade tem que ser superior a 18 anos.");
                dataNascimento.Focus();
            }

            return sb.ToString();
        }

        public void Registro()
        {
            var DocenteRepository = new DocentesRepository();
            var lstDocente = new List<DocentesModel>();

            var name = txtNome.Text;
            var cpf = Cpf.formatarCpf(txtCpf.Text);
            DateTime dataNascimento = Convert.ToDateTime(dtNascimento.Text);

            var cbSexo = cboSexo.Text;
            var idCboSexo = Convert.ToInt32(cboSexo.SelectedValue);

            var txtStatus = cboStatus.Text;
            var idStatus = Convert.ToInt32(cboStatus.SelectedValue);

            var grauEscolarTxt = cboGrauEscolaridade.Text;
            var idGrauEscolar = Convert.ToInt32(cboGrauEscolaridade.SelectedValue);

            lstDocente = DocenteRepository.Cadastrar(name, cpf, cbSexo, idCboSexo, dataNascimento, txtStatus, idStatus,
                grauEscolarTxt, idGrauEscolar,
                DateTime.Now);

            dgViewDados.DataSource = lstDocente;

        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrando = true;
            ControlarComponentes();
            txtNome.Focus();
            Limpar();
        }

        private void FrmDocentes_Load(object sender, EventArgs e)
        {
            cboGrauEscolaridade.DataSource = ControlarStatus.StatusDocentes();
            cboGrauEscolaridade.DisplayMember = "Descricao";
            cboGrauEscolaridade.ValueMember = "Id";

            cboStatus.DataSource = ControlarStatus.CarregarStatus();
            cboStatus.DisplayMember = "Descricao";
            cboStatus.ValueMember = "Id";

            cboSexo.DataSource = ControlarStatus.statusSexo();
            cboSexo.DisplayMember = "Descricao";
            cboSexo.ValueMember = "Id";

            MostrarDadosTela();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Pesquisa()
        {
            var docentesFiltro = lstDocentes.Where(n => n.Name.Contains(txtSearch.Text)).ToList();

            MostrarDados(docentesFiltro);
        }

        public void MostrarDados(List<DocentesModel> lstDocentes)
        {
            var sourceBinding = new BindingSource();
            sourceBinding.DataSource = lstDocentes;

            dgViewDados.DataSource = sourceBinding;

            if (dgViewDados.DataSource != null && dgViewDados.Rows.Count > 0)
            {
                FormatarGrid();
            }
        }

        private void MostrarDadosTela()
        {
            var DocenteRepository = new DocentesRepository();

            lstDocentes = DocenteRepository.CarregarDados();
            MostrarDados(lstDocentes);

        }

        private void FormatarGrid()
        {
            dgViewDados.Columns["Name"].HeaderText = "Nome";
            dgViewDados.Columns["Cpf"].HeaderText = "CPF";
            dgViewDados.Columns["SexoDocente"].HeaderText = "Sexo";

            dgViewDados.Columns["DescStatus"].HeaderText = "Status";
            dgViewDados.Columns["grauEscolar"].HeaderText = "Grau Escolar";
            dgViewDados.Columns["dataNascimento"].HeaderText = "Nascimento";
            dgViewDados.Columns["DataCadastro"].HeaderText = "Cadastro";
            dgViewDados.Columns["DataAtualizacao"].HeaderText = "Atualização";
            dgViewDados.Columns["DataAtualizacao"].HeaderText = "Atualização";
            dgViewDados.Columns["DataAtualizacao"].HeaderText = "Atualização";

            dgViewDados.Columns["Id"].Visible = false;
            dgViewDados.Columns["IdSexo"].Visible = false;
            dgViewDados.Columns["IdGrauEscolar"].Visible = false;
            dgViewDados.Columns["IdStatus"].Visible = false;
            txtBoxId.Visible = false;


            dgViewDados.RowsDefaultCellStyle.BackColor = Color.White;
            dgViewDados.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void ControlarComponentes()
        {
            gbDocentes.Enabled = !gbDocentes.Enabled;
            btnBusca.Enabled = !btnBusca.Enabled;
            btnCancelar.Enabled = !btnCancelar.Enabled;
            btnSalvar.Enabled = !btnSalvar.Enabled;
            btnCadastrar.Enabled = !btnCadastrar.Enabled;
            btnEdit.Enabled = !btnEdit.Enabled;
            btnSair.Enabled = !btnSair.Enabled;
            dgViewDados.Enabled = !dgViewDados.Enabled;
        }

        private void Limpar()
        {
            txtNome.Text = String.Empty;
            txtCpf.Text = String.Empty;
            dtNascimento.Text = DateTime.Now.ToString();
            cboSexo.SelectedIndex = 0;
            cboGrauEscolaridade.SelectedIndex = 0;
        }

        private void Recarregar()
        {
            Limpar();
            ControlarComponentes();

            MostrarDadosTela();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                Pesquisa();
            }
            else
            {
                MostrarDados(lstDocentes);
            }
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

        public void AtualizarRegistro()
        {
            var docentesRepository = new DocentesRepository();
            editando = true;


            var docenteModel = new DocentesModel
            {
                Name = txtNome.Text,
                Id = int.Parse(txtBoxId.Text),
                Cpf = Cpf.formatarCpf(txtCpf.Text),
                SexoDocente = cboSexo.Text,
                IdSexo = Convert.ToInt32(cboSexo.SelectedValue),

                DataNascimento = Convert.ToDateTime(dtNascimento.Text),

                DescStatus = cboStatus.Text,
                IdStatus = Convert.ToInt32(cboStatus.SelectedValue),

                GrauEscolar = cboGrauEscolaridade.Text,
                IdGrauEscolar = Convert.ToInt32(cboGrauEscolaridade.SelectedValue),

                DataAtualizacao = DateTime.UtcNow.AddHours(-3),
            };
                docentesRepository.Atualizar(docenteModel);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Recarregar();
            cadastrando = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cadastrando = false;
            ControlarComponentes();
            txtNome.Focus();
        }

        private void dgViewDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtNome.Text = dgViewDados.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtCpf.Text = dgViewDados.Rows[e.RowIndex].Cells["Cpf"].Value.ToString();
                txtBoxId.Text = dgViewDados.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                cboSexo.SelectedValue = dgViewDados.Rows[e.RowIndex].Cells["IdSexo"].Value;
                dtNascimento.Text = dgViewDados.Rows[e.RowIndex].Cells["dataNascimento"].Value.ToString();
                cboStatus.SelectedValue = dgViewDados.Rows[e.RowIndex].Cells["IdStatus"].Value;
                cboGrauEscolaridade.SelectedValue = dgViewDados.Rows[e.RowIndex].Cells["IdGrauEscolar"].Value;
            }
        }
    }
}
