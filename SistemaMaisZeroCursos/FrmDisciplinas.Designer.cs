namespace SistemaMaisZeroCursos
{
    partial class FrmDisciplinas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.txtBoxDataAtualizacao = new System.Windows.Forms.TextBox();
            this.txtBoxDataCadastro = new System.Windows.Forms.TextBox();
            this.lblDataAtualizacao = new System.Windows.Forms.Label();
            this.labeltestedatacadastro = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.labeltesteID = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDisciplinas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.txtBoxDataAtualizacao);
            this.gbDados.Controls.Add(this.txtBoxDataCadastro);
            this.gbDados.Controls.Add(this.lblDataAtualizacao);
            this.gbDados.Controls.Add(this.labeltestedatacadastro);
            this.gbDados.Controls.Add(this.txtBoxID);
            this.gbDados.Controls.Add(this.labeltesteID);
            this.gbDados.Controls.Add(this.cboStatus);
            this.gbDados.Controls.Add(this.label4);
            this.gbDados.Controls.Add(this.txtDisciplinas);
            this.gbDados.Controls.Add(this.label3);
            this.gbDados.Enabled = false;
            this.gbDados.Location = new System.Drawing.Point(12, 12);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(371, 174);
            this.gbDados.TabIndex = 0;
            this.gbDados.TabStop = false;
            // 
            // txtBoxDataAtualizacao
            // 
            this.txtBoxDataAtualizacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxDataAtualizacao.Location = new System.Drawing.Point(204, 116);
            this.txtBoxDataAtualizacao.Name = "txtBoxDataAtualizacao";
            this.txtBoxDataAtualizacao.ReadOnly = true;
            this.txtBoxDataAtualizacao.Size = new System.Drawing.Size(151, 27);
            this.txtBoxDataAtualizacao.TabIndex = 10;
            // 
            // txtBoxDataCadastro
            // 
            this.txtBoxDataCadastro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxDataCadastro.Location = new System.Drawing.Point(49, 116);
            this.txtBoxDataCadastro.Name = "txtBoxDataCadastro";
            this.txtBoxDataCadastro.ReadOnly = true;
            this.txtBoxDataCadastro.Size = new System.Drawing.Size(140, 27);
            this.txtBoxDataCadastro.TabIndex = 9;
            // 
            // lblDataAtualizacao
            // 
            this.lblDataAtualizacao.AutoSize = true;
            this.lblDataAtualizacao.Location = new System.Drawing.Point(221, 93);
            this.lblDataAtualizacao.Name = "lblDataAtualizacao";
            this.lblDataAtualizacao.Size = new System.Drawing.Size(123, 20);
            this.lblDataAtualizacao.TabIndex = 8;
            this.lblDataAtualizacao.Text = "Data Atualização";
            // 
            // labeltestedatacadastro
            // 
            this.labeltestedatacadastro.AutoSize = true;
            this.labeltestedatacadastro.Location = new System.Drawing.Point(66, 93);
            this.labeltestedatacadastro.Name = "labeltestedatacadastro";
            this.labeltestedatacadastro.Size = new System.Drawing.Size(104, 20);
            this.labeltestedatacadastro.TabIndex = 6;
            this.labeltestedatacadastro.Text = "Data Cadastro";
            // 
            // txtBoxID
            // 
            this.txtBoxID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxID.Location = new System.Drawing.Point(6, 116);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.ReadOnly = true;
            this.txtBoxID.Size = new System.Drawing.Size(25, 27);
            this.txtBoxID.TabIndex = 7;
            // 
            // labeltesteID
            // 
            this.labeltesteID.AutoSize = true;
            this.labeltesteID.Location = new System.Drawing.Point(6, 93);
            this.labeltesteID.Name = "labeltesteID";
            this.labeltesteID.Size = new System.Drawing.Size(29, 20);
            this.labeltesteID.TabIndex = 5;
            this.labeltesteID.Text = "Id: ";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(204, 46);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(151, 28);
            this.cboStatus.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // txtDisciplinas
            // 
            this.txtDisciplinas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDisciplinas.Location = new System.Drawing.Point(6, 46);
            this.txtDisciplinas.Name = "txtDisciplinas";
            this.txtDisciplinas.Size = new System.Drawing.Size(167, 27);
            this.txtDisciplinas.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Disciplina";
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToResizeColumns = false;
            this.dgvDados.AllowUserToResizeRows = false;
            this.dgvDados.BackgroundColor = System.Drawing.Color.White;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.GridColor = System.Drawing.Color.LightGray;
            this.dgvDados.Location = new System.Drawing.Point(12, 264);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.RowHeadersWidth = 51;
            this.dgvDados.RowTemplate.Height = 29;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(371, 375);
            this.dgvDados.TabIndex = 1;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancelar);
            this.groupBox4.Controls.Add(this.btnSalvar);
            this.groupBox4.Controls.Add(this.btnSair);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.btnCadastrar);
            this.groupBox4.Location = new System.Drawing.Point(421, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 601);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::SistemaMaisZeroCursos.Properties.Resources._1904654_cancel_close_cross_delete_reject_icon;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(25, 375);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(176, 74);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Ca&ncelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = global::SistemaMaisZeroCursos.Properties.Resources._2931176_diskette_guardar_save_disk_drive_icon;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(25, 253);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(176, 74);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::SistemaMaisZeroCursos.Properties.Resources._2931185_door_enter_exit_leave_out_icon;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(25, 500);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(176, 74);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::SistemaMaisZeroCursos.Properties.Resources._3643749_edit_pen_pencil_write_writing_icon;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(25, 137);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(176, 74);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = global::SistemaMaisZeroCursos.Properties.Resources._9133514_signup_register_login_icon;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(25, 26);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(176, 74);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(18, 209);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(262, 27);
            this.txtPesquisa.TabIndex = 3;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::SistemaMaisZeroCursos.Properties.Resources._211818_search_icon;
            this.btnBuscar.Location = new System.Drawing.Point(289, 202);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 41);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmDisciplinas
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 651);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.gbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "FrmDisciplinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disciplinas";
            this.Load += new System.EventHandler(this.FrmDisciplinas_Load_1);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox GbCampos;
        private Label label2;
        private ComboBox cbStatus;
        private TextBox txtDisciplina;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnEditar;
        private Button btnSair;
        private Button btnCadastro;
        private GroupBox groupBox2;
        private DataGridView DgvDadosDisciplina;
        private ToolTip toolTip1;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private TextBox txtDisci;
        private ComboBox cbSt;
        private DataGridView DvgDisciplina;
        private Panel panel1;
        private Button button3;
        private Button btnCancelar;
        private Button btnSalvar;
        private GroupBox gbDados;
        private ComboBox cboStatus;
        private Label label4;
        private TextBox txtDisciplinas;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvDados;
        private GroupBox groupBox4;
        private Button btnEdit;
        private Button btnCadastrar;
        private Button btnBuscar;
        private Label labeltesteID;
        private Label labeltestedatacadastro;
        private TextBox txtBoxDataAtualizacao;
        private TextBox txtBoxDataCadastro;
        private Label lblDataAtualizacao;
        private TextBox txtBoxID;
    }
}