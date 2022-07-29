namespace SistemaMaisZeroCursos
{
    partial class FrmEspecializacao
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
            this.cboNmProfessor = new System.Windows.Forms.ComboBox();
            this.txtBoxDataAtualizacao = new System.Windows.Forms.TextBox();
            this.txtBoxDataCadastro = new System.Windows.Forms.TextBox();
            this.lblDataAtualizacao = new System.Windows.Forms.Label();
            this.labeltestedatacadastro = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.labeltesteID = new System.Windows.Forms.Label();
            this.cboDisciplina = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvEspecializacao = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.gbDados.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecializacao)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.cboNmProfessor);
            this.gbDados.Controls.Add(this.txtBoxDataAtualizacao);
            this.gbDados.Controls.Add(this.txtBoxDataCadastro);
            this.gbDados.Controls.Add(this.lblDataAtualizacao);
            this.gbDados.Controls.Add(this.labeltestedatacadastro);
            this.gbDados.Controls.Add(this.txtBoxID);
            this.gbDados.Controls.Add(this.labeltesteID);
            this.gbDados.Controls.Add(this.cboDisciplina);
            this.gbDados.Controls.Add(this.label4);
            this.gbDados.Controls.Add(this.label3);
            this.gbDados.Enabled = false;
            this.gbDados.Location = new System.Drawing.Point(12, 12);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(385, 174);
            this.gbDados.TabIndex = 1;
            this.gbDados.TabStop = false;
            // 
            // cboNmProfessor
            // 
            this.cboNmProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNmProfessor.FormattingEnabled = true;
            this.cboNmProfessor.Location = new System.Drawing.Point(6, 50);
            this.cboNmProfessor.Name = "cboNmProfessor";
            this.cboNmProfessor.Size = new System.Drawing.Size(151, 28);
            this.cboNmProfessor.TabIndex = 11;
            // 
            // txtBoxDataAtualizacao
            // 
            this.txtBoxDataAtualizacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxDataAtualizacao.Enabled = false;
            this.txtBoxDataAtualizacao.Location = new System.Drawing.Point(204, 116);
            this.txtBoxDataAtualizacao.Name = "txtBoxDataAtualizacao";
            this.txtBoxDataAtualizacao.ReadOnly = true;
            this.txtBoxDataAtualizacao.Size = new System.Drawing.Size(151, 27);
            this.txtBoxDataAtualizacao.TabIndex = 10;
            this.txtBoxDataAtualizacao.TextChanged += new System.EventHandler(this.txtBoxDataAtualizacao_TextChanged);
            // 
            // txtBoxDataCadastro
            // 
            this.txtBoxDataCadastro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxDataCadastro.Enabled = false;
            this.txtBoxDataCadastro.Location = new System.Drawing.Point(49, 116);
            this.txtBoxDataCadastro.Name = "txtBoxDataCadastro";
            this.txtBoxDataCadastro.ReadOnly = true;
            this.txtBoxDataCadastro.Size = new System.Drawing.Size(140, 27);
            this.txtBoxDataCadastro.TabIndex = 9;
            // 
            // lblDataAtualizacao
            // 
            this.lblDataAtualizacao.AutoSize = true;
            this.lblDataAtualizacao.Enabled = false;
            this.lblDataAtualizacao.Location = new System.Drawing.Point(221, 93);
            this.lblDataAtualizacao.Name = "lblDataAtualizacao";
            this.lblDataAtualizacao.Size = new System.Drawing.Size(123, 20);
            this.lblDataAtualizacao.TabIndex = 8;
            this.lblDataAtualizacao.Text = "Data Atualização";
            // 
            // labeltestedatacadastro
            // 
            this.labeltestedatacadastro.AutoSize = true;
            this.labeltestedatacadastro.Enabled = false;
            this.labeltestedatacadastro.Location = new System.Drawing.Point(66, 93);
            this.labeltestedatacadastro.Name = "labeltestedatacadastro";
            this.labeltestedatacadastro.Size = new System.Drawing.Size(104, 20);
            this.labeltestedatacadastro.TabIndex = 6;
            this.labeltestedatacadastro.Text = "Data Cadastro";
            // 
            // txtBoxID
            // 
            this.txtBoxID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxID.Enabled = false;
            this.txtBoxID.Location = new System.Drawing.Point(6, 116);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.ReadOnly = true;
            this.txtBoxID.Size = new System.Drawing.Size(25, 27);
            this.txtBoxID.TabIndex = 7;
            // 
            // labeltesteID
            // 
            this.labeltesteID.AutoSize = true;
            this.labeltesteID.Enabled = false;
            this.labeltesteID.Location = new System.Drawing.Point(6, 93);
            this.labeltesteID.Name = "labeltesteID";
            this.labeltesteID.Size = new System.Drawing.Size(29, 20);
            this.labeltesteID.TabIndex = 5;
            this.labeltesteID.Text = "Id: ";
            // 
            // cboDisciplina
            // 
            this.cboDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDisciplina.FormattingEnabled = true;
            this.cboDisciplina.Location = new System.Drawing.Point(204, 46);
            this.cboDisciplina.Name = "cboDisciplina";
            this.cboDisciplina.Size = new System.Drawing.Size(151, 28);
            this.cboDisciplina.TabIndex = 4;
            this.cboDisciplina.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Disciplina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Professor";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExcluir);
            this.groupBox4.Controls.Add(this.btnCancelar);
            this.groupBox4.Controls.Add(this.btnSalvar);
            this.groupBox4.Controls.Add(this.btnSair);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.btnCadastrar);
            this.groupBox4.Location = new System.Drawing.Point(417, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 636);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::SistemaMaisZeroCursos.Properties.Resources._4115238_delete_trash_icon;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(25, 224);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(176, 74);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::SistemaMaisZeroCursos.Properties.Resources._1904654_cancel_close_cross_delete_reject_icon;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(25, 434);
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
            this.btnSalvar.Location = new System.Drawing.Point(25, 326);
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
            this.btnSair.Location = new System.Drawing.Point(25, 542);
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
            this.btnEdit.Location = new System.Drawing.Point(25, 116);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(176, 74);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "E&ditar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = global::SistemaMaisZeroCursos.Properties.Resources._9133514_signup_register_login_icon;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(25, 22);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(176, 74);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvEspecializacao
            // 
            this.dgvEspecializacao.AllowUserToAddRows = false;
            this.dgvEspecializacao.AllowUserToDeleteRows = false;
            this.dgvEspecializacao.AllowUserToResizeColumns = false;
            this.dgvEspecializacao.AllowUserToResizeRows = false;
            this.dgvEspecializacao.BackgroundColor = System.Drawing.Color.White;
            this.dgvEspecializacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecializacao.GridColor = System.Drawing.Color.LightGray;
            this.dgvEspecializacao.Location = new System.Drawing.Point(12, 238);
            this.dgvEspecializacao.Name = "dgvEspecializacao";
            this.dgvEspecializacao.ReadOnly = true;
            this.dgvEspecializacao.RowHeadersVisible = false;
            this.dgvEspecializacao.RowHeadersWidth = 51;
            this.dgvEspecializacao.RowTemplate.Height = 29;
            this.dgvEspecializacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecializacao.Size = new System.Drawing.Size(385, 410);
            this.dgvEspecializacao.TabIndex = 4;
            this.dgvEspecializacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEspecializacao_CellContentClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(12, 196);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(189, 27);
            this.txtPesquisa.TabIndex = 11;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // cboFiltro
            // 
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Location = new System.Drawing.Point(246, 196);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(151, 28);
            this.cboFiltro.TabIndex = 12;
            // 
            // FrmEspecializacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 660);
            this.ControlBox = false;
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dgvEspecializacao);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbDados);
            this.Name = "FrmEspecializacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especialização";
            this.Load += new System.EventHandler(this.FrmEspecializacao_Load);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecializacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbDados;
        private TextBox txtBoxDataAtualizacao;
        private TextBox txtBoxDataCadastro;
        private Label lblDataAtualizacao;
        private Label labeltestedatacadastro;
        private TextBox txtBoxID;
        private Label labeltesteID;
        private ComboBox cboDisciplina;
        private Label label4;
        private Label label3;
        private GroupBox groupBox4;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnSair;
        private Button btnEdit;
        private Button btnCadastrar;
        private DataGridView dgvEspecializacao;
        private TextBox txtPesquisa;
        private ComboBox cboNmProfessor;
        private ComboBox cboFiltro;
        private Button btnExcluir;
    }
}