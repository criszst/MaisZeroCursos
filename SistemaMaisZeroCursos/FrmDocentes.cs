using System.Text;
using SistemaMaisZeroCursos.Comum;

namespace SistemaMaisZeroCursos
{
    public partial class FrmDocentes : Form
    {
        public FrmDocentes()
        {
            InitializeComponent();
        }

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

            else if (!ValidarCpf.validar(cpf.Text)) {
                sb.Append("O CPF não é válido.");
                cpf.Focus();
            }

            else if (Convert.ToDateTime(dataNascimento.Text) >= Convert.ToDateTime(idadeCorreta))
            {
                sb.Append("A idade tem que ser superior a 18 anos.");
                dataNascimento.Focus();
            }

            return sb.ToString();
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ValidarRegistro()))
            {
                MessageBox.Show(ValidarRegistro());
            } else
            {
                // TODO: Realizar Cadastro
            }
            
        }

        private void FrmDocentes_Load(object sender, EventArgs e)
        {
            cboGrauEscolaridade.DataSource = ControlarStatus.StatusDocentes();
            cboGrauEscolaridade.DisplayMember = "Desc";
            cboGrauEscolaridade.ValueMember = "Id";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
