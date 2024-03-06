using MaisZeroCursos.DTO.Model;
using SistemaMaisZeroCursos.Comum;
using SistemaMaisZeroCursos.Repository;
using SistemaMaisZeroCursos.WebAPI;
using System;
using System.Text;

namespace SistemaMaisZeroCursos
{
    public partial class FrmEspecializacao : Form
    {
        public bool cadastrando = false;
        public bool editando = false;
        public bool excluindo = false;

        public FrmEspecializacao()
        {
            InitializeComponent();
            lstEspecializacao = new List<EspecializacaoModel>();
        }

        private List<EspecializacaoModel> lstEspecializacao { get; set; }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEspecializacao_Load(object sender, EventArgs e)
        {
            cboDisciplina.DataSource = ControlarStatus.DisciplinaEspecializada();
            cboDisciplina.DisplayMember = "NomeDisciplina";
            cboDisciplina.ValueMember = "Id";

            cboNmProfessor.DataSource = ControlarStatus.NomeProfessor();
            cboNmProfessor.DisplayMember = "Name";
            cboNmProfessor.ValueMember = "Id";

            cboFiltro.DataSource = ControlarStatus.BuscaFiltro();
            cboFiltro.DisplayMember = "Descricao";
            cboNmProfessor.ValueMember = "Id";

            MostrarDadosTela();
        }

        private void Registrar()
        {
            var repository = new EspecializacaoRepository();

            if (cboNmProfessor.SelectedIndex != -1 && cboDisciplina.SelectedIndex != -1)
            {
                var especializacao = new EspecializacaoModel
                {
                    NomeProfessor = cboNmProfessor.Text,
                    idNomeProfessor = Convert.ToInt32(cboNmProfessor.SelectedValue),
                    Especializacao = cboDisciplina.Text,
                    idEspecializacao = Convert.ToInt32(cboDisciplina.SelectedValue),
                    DataCadastro = DateTime.UtcNow.AddHours(-3),
                };
                //var nmProfessor = cboNmProfessor.Text;
                //var idProfessor = Convert.ToInt32(cboNmProfessor.SelectedValue);
                //var disciplina = cboDisciplina.Text;
                //var idDisciplina = Convert.ToInt32(cboDisciplina.SelectedValue);

                //lstEspecializacao = repository.Cadastrar(nmProfessor, idProfessor, disciplina, idDisciplina, DateTime.UtcNow.AddHours(-3));

                var api = new EspecializacaoWebApi();

                dgvEspecializacao.DataSource = api.Cadastrar(especializacao);
            }
        }

        private string Validar()
        {
            StringBuilder sb = new StringBuilder();

            var idProfessor = Convert.ToInt32(cboNmProfessor.SelectedValue);
            var idDisciplina = Convert.ToInt32(cboDisciplina.SelectedValue);

            if (cadastrando && lstEspecializacao != null && lstEspecializacao.Any(l => l.idNomeProfessor == idProfessor && l.idEspecializacao == idDisciplina))
            {
                sb.Append("Esse professor já foi vinculado para esta especialização.");
                cboNmProfessor.Focus();
            }
            else if (cadastrando && lstEspecializacao != null && lstEspecializacao.FindAll(l => l.idNomeProfessor == idProfessor).Count == 3)
            {
                sb.Append("Esse professor já tem o máximo de disciplinas cadastradas possíveis.");
                cboNmProfessor.Focus();
            }
            else if (editando && lstEspecializacao != null && lstEspecializacao.Any(l => l.idEspecializacao == idDisciplina))
            {
                sb.Append("Esse professor já foi vinculado para esta especialização.");
                cboNmProfessor.Focus();
            }

            return sb.ToString();
        }

        public void MostrarDados(List<EspecializacaoModel> lstEspecializacao)
        {
            var sourceBinding = new BindingSource();
            sourceBinding.DataSource = lstEspecializacao;

            dgvEspecializacao.DataSource = sourceBinding;

            if (dgvEspecializacao.DataSource != null && dgvEspecializacao.Rows.Count > -1)
            {
                FormatarGrid();
            }
        }

        private void MostrarDadosTela()
        {
            var repository = new EspecializacaoRepository();

            lstEspecializacao = repository.CarregarDados();

            var api = new EspecializacaoWebApi();

            MostrarDados(api.CarregarDados());

        }

        private void FormatarGrid()
        {
            dgvEspecializacao.Columns["NomeProfessor"].HeaderText = "Professor";
            dgvEspecializacao.Columns["Especializacao"].HeaderText = "Especialização";
            dgvEspecializacao.Columns["DataCadastro"].HeaderText = "Cadastro";
            dgvEspecializacao.Columns["DataAtualizacao"].HeaderText = "Atualização";

            dgvEspecializacao.Columns["Id"].Visible = false;
            dgvEspecializacao.Columns["idNomeProfessor"].Visible = false;
            dgvEspecializacao.Columns["idEspecializacao"].Visible = false;

            dgvEspecializacao.RowsDefaultCellStyle.BackColor = Color.White;
            dgvEspecializacao.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrando = true;

            ControlarComponentes();
            cboNmProfessor.Focus();
            Limpar();

            btnExcluir.Enabled = false;
        }

        private void Pesquisa()
        {
            int filtroSelecionado = cboFiltro.SelectedIndex;
            var api = new EspecializacaoWebApi();

            if (filtroSelecionado == 0)
            {
                var pesquisa = api.Pesquisar(txtPesquisa.Text, 1);
                MostrarDados(pesquisa);
            }
            //MostrarDados(lstEspecializacao.Where(n => n.NomeProfessor.Contains(txtPesquisa.Text)).ToList());
            else
            {
                var pesquisa = api.Pesquisar(txtPesquisa.Text, 2);
                MostrarDados(pesquisa);
            }
            // MostrarDados(lstEspecializacao.Where(n => n.Especializacao.Contains(txtPesquisa.Text)).ToList());
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPesquisa.Text))
            {
                Pesquisa();
            }
            else
            {
                MostrarDados(lstEspecializacao);
            }
        }

        private void ControlarComponentes()
        {
            gbDados.Enabled = !gbDados.Enabled;
            btnCancelar.Enabled = !btnCancelar.Enabled;
            btnSalvar.Enabled = !btnSalvar.Enabled;
            btnCadastrar.Enabled = !btnCadastrar.Enabled;
            btnEdit.Enabled = !btnEdit.Enabled;
            btnSair.Enabled = !btnSair.Enabled;
            dgvEspecializacao.Enabled = !dgvEspecializacao.Enabled;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var msg = Validar();
            if (string.IsNullOrEmpty(msg))
            {
                string tipoAcao = "Cadastro realizado";
                if (cadastrando)
                {
                    Registrar();
                    Recarregar();
                }
                else
                {
                    tipoAcao = "Atualização realizada";
                    AtualizarRegistro();
                    Recarregar();
                }
                MessageBox.Show($"{tipoAcao} com sucesso.");
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void Limpar()
        {
            cboNmProfessor.SelectedIndex = 0;
            cboDisciplina.SelectedIndex = 0;
        }

        private void Recarregar()
        {
            Limpar();
            ControlarComponentes();

            MostrarDadosTela();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Recarregar();
            cadastrando = false;
        }

        private void dgvEspecializacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnExcluir.Enabled = false;

            if (e.RowIndex > -1)
            {
                cboNmProfessor.SelectedValue = dgvEspecializacao.Rows[e.RowIndex].Cells["idNomeProfessor"].Value;
                cboDisciplina.SelectedValue = dgvEspecializacao.Rows[e.RowIndex].Cells["idEspecializacao"].Value;
                txtBoxID.Text = dgvEspecializacao.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtBoxDataCadastro.Text = dgvEspecializacao.Rows[e.RowIndex].Cells["DataCadastro"].Value.ToString();
                DateTime dtAtualizacao = new DateTime();

                DateTime.TryParse(dgvEspecializacao.Rows[e.RowIndex].Cells["DataAtualizacao"].Value.ToString(), out dtAtualizacao);
                txtBoxDataAtualizacao.Text = dtAtualizacao != DateTime.MinValue ? dtAtualizacao.ToString() : "";
                btnExcluir.Enabled = true;
            }
        }

        private void txtBoxDataAtualizacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cadastrando = false;
            editando = true;
            ControlarComponentes();
            cboDisciplina.Focus();
            btnExcluir.Enabled = false;
        }

        public void AtualizarRegistro()
        {
            editando = true;

            var especializacaoModel = new EspecializacaoModel
            {
                NomeProfessor = cboNmProfessor.Text,
                Id = int.Parse(txtBoxID.Text),
                idNomeProfessor = Convert.ToInt32(cboNmProfessor.SelectedValue),
                Especializacao = cboDisciplina.Text,
                idEspecializacao = Convert.ToInt32(cboDisciplina.SelectedValue),

                DataAtualizacao = DateTime.UtcNow.AddHours(-3),
            };
            var api = new EspecializacaoWebApi();
            api.Atualizar(especializacaoModel);
        }

        public void ExcluirRegistro()
        {
            var confirm = MessageBox.Show(
                $"Você tem certeza de que deseja excluir {cboNmProfessor.Text} e {cboDisciplina.Text} do registro?",
                "Confirmação",
                MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                var api = new EspecializacaoWebApi();
                editando = true;

                var especializacaoModel = new EspecializacaoModel
                {
                    NomeProfessor = cboNmProfessor.Text,
                    Id = int.Parse(txtBoxID.Text),
                    idNomeProfessor = Convert.ToInt32(cboNmProfessor.SelectedValue),
                    Especializacao = cboDisciplina.Text,
                    idEspecializacao = Convert.ToInt32(cboDisciplina.SelectedValue),
                };

                api.Excluir(especializacaoModel);

                MessageBox.Show("Excluído com sucesso.");
                btnExcluir.Enabled = false;
            }
            else
            {
                MessageBox.Show("Exclusão negada.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cadastrando = false;
            editando = false;

            ControlarComponentes();
            gbDados.Enabled = false;
            cboDisciplina.Focus();

            ExcluirRegistro();
            Recarregar();

            excluindo = true;
        }
    }
}
