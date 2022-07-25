namespace SistemaMaisZeroCursos
{
    partial class FrmDiscentes
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
            this.gbDiscentes = new System.Windows.Forms.GroupBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblDtNascimento = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvDadosDiscentes = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.gbDiscentes.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosDiscentes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDiscentes
            // 
            this.gbDiscentes.Controls.Add(this.lblSexo);
            this.gbDiscentes.Controls.Add(this.cboSexo);
            this.gbDiscentes.Controls.Add(this.comboBox1);
            this.gbDiscentes.Controls.Add(this.cboPeriodo);
            this.gbDiscentes.Controls.Add(this.cboStatus);
            this.gbDiscentes.Controls.Add(this.lblStatus);
            this.gbDiscentes.Controls.Add(this.lblPeriodo);
            this.gbDiscentes.Controls.Add(this.dtNascimento);
            this.gbDiscentes.Controls.Add(this.txtCpf);
            this.gbDiscentes.Controls.Add(this.lblDtNascimento);
            this.gbDiscentes.Controls.Add(this.lblCpf);
            this.gbDiscentes.Controls.Add(this.txtNome);
            this.gbDiscentes.Controls.Add(this.lblNome);
            this.gbDiscentes.Enabled = false;
            this.gbDiscentes.Location = new System.Drawing.Point(12, 12);
            this.gbDiscentes.Name = "gbDiscentes";
            this.gbDiscentes.Size = new System.Drawing.Size(696, 174);
            this.gbDiscentes.TabIndex = 2;
            this.gbDiscentes.TabStop = false;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(539, 22);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 20);
            this.lblSexo.TabIndex = 19;
            this.lblSexo.Text = "Sexo";
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(539, 45);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(151, 28);
            this.cboSexo.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(273, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 18;
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(469, 125);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(221, 28);
            this.cboPeriodo.TabIndex = 18;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(203, 125);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(231, 28);
            this.cboStatus.TabIndex = 17;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(203, 88);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(469, 88);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(60, 20);
            this.lblPeriodo.TabIndex = 13;
            this.lblPeriodo.Text = "Período";
            // 
            // dtNascimento
            // 
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(6, 126);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(167, 27);
            this.dtNascimento.TabIndex = 12;
            // 
            // txtCpf
            // 
            this.txtCpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCpf.Location = new System.Drawing.Point(360, 46);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(167, 27);
            this.txtCpf.TabIndex = 11;
            // 
            // lblDtNascimento
            // 
            this.lblDtNascimento.AutoSize = true;
            this.lblDtNascimento.Location = new System.Drawing.Point(6, 88);
            this.lblDtNascimento.Name = "lblDtNascimento";
            this.lblDtNascimento.Size = new System.Drawing.Size(142, 20);
            this.lblDtNascimento.TabIndex = 5;
            this.lblDtNascimento.Text = "Data de nascimento";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(360, 23);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(33, 20);
            this.lblCpf.TabIndex = 3;
            this.lblCpf.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(6, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(338, 27);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancelar);
            this.groupBox4.Controls.Add(this.btnSalvar);
            this.groupBox4.Controls.Add(this.btnSair);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.btnCadastrar);
            this.groupBox4.Location = new System.Drawing.Point(738, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 628);
            this.groupBox4.TabIndex = 4;
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
            // dgvDadosDiscentes
            // 
            this.dgvDadosDiscentes.AllowUserToAddRows = false;
            this.dgvDadosDiscentes.AllowUserToDeleteRows = false;
            this.dgvDadosDiscentes.AllowUserToResizeColumns = false;
            this.dgvDadosDiscentes.AllowUserToResizeRows = false;
            this.dgvDadosDiscentes.BackgroundColor = System.Drawing.Color.White;
            this.dgvDadosDiscentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosDiscentes.GridColor = System.Drawing.Color.LightGray;
            this.dgvDadosDiscentes.Location = new System.Drawing.Point(18, 265);
            this.dgvDadosDiscentes.Name = "dgvDadosDiscentes";
            this.dgvDadosDiscentes.ReadOnly = true;
            this.dgvDadosDiscentes.RowHeadersVisible = false;
            this.dgvDadosDiscentes.RowHeadersWidth = 51;
            this.dgvDadosDiscentes.RowTemplate.Height = 29;
            this.dgvDadosDiscentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosDiscentes.Size = new System.Drawing.Size(690, 375);
            this.dgvDadosDiscentes.TabIndex = 7;
            this.dgvDadosDiscentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDadosDiscentes_CellContentClick_1);
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Location = new System.Drawing.Point(18, 218);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(424, 27);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnBusca
            // 
            this.btnBusca.Image = global::SistemaMaisZeroCursos.Properties.Resources._211818_search_icon;
            this.btnBusca.Location = new System.Drawing.Point(516, 205);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(186, 40);
            this.btnBusca.TabIndex = 9;
            this.btnBusca.UseVisualStyleBackColor = true;
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(463, 218);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(32, 27);
            this.txtBoxId.TabIndex = 10;
            // 
            // FrmDiscentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 662);
            this.ControlBox = false;
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvDadosDiscentes);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbDiscentes);
            this.Name = "FrmDiscentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discentes";
            this.Load += new System.EventHandler(this.FrmDiscentes_Load);
            this.gbDiscentes.ResumeLayout(false);
            this.gbDiscentes.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosDiscentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbDiscentes;
        private Label lblSexo;
        private ComboBox cboSexo;
        private ComboBox comboBox1;
        private ComboBox cboPeriodo;
        private ComboBox cboStatus;
        private Label lblStatus;
        private Label lblPeriodo;
        private DateTimePicker dtNascimento;
        private TextBox txtCpf;
        private Label lblDtNascimento;
        private Label lblCpf;
        private TextBox txtNome;
        private Label lblNome;
        private GroupBox groupBox4;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnSair;
        private Button btnEdit;
        private Button btnCadastrar;
        private DataGridView dgvDadosDiscentes;
        private TextBox txtSearch;
        private Button btnBusca;
        private TextBox txtBoxId;
    }
}