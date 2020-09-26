namespace HardTrainning
{
    partial class frmCadastroAulas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.dgvAulas = new System.Windows.Forms.DataGridView();
            this.btnNova = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAulaID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aula";
            // 
            // txtAula
            // 
            this.txtAula.Enabled = false;
            this.txtAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAula.Location = new System.Drawing.Point(13, 34);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(573, 26);
            this.txtAula.TabIndex = 1;
            // 
            // dgvAulas
            // 
            this.dgvAulas.AllowUserToResizeColumns = false;
            this.dgvAulas.BackgroundColor = System.Drawing.Color.White;
            this.dgvAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAulas.GridColor = System.Drawing.Color.White;
            this.dgvAulas.Location = new System.Drawing.Point(15, 20);
            this.dgvAulas.MultiSelect = false;
            this.dgvAulas.Name = "dgvAulas";
            this.dgvAulas.ReadOnly = true;
            this.dgvAulas.RowHeadersVisible = false;
            this.dgvAulas.RowTemplate.ReadOnly = true;
            this.dgvAulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAulas.Size = new System.Drawing.Size(542, 233);
            this.dgvAulas.TabIndex = 72;
            this.dgvAulas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAulas_CellClick);
            // 
            // btnNova
            // 
            this.btnNova.Location = new System.Drawing.Point(605, 34);
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(109, 30);
            this.btnNova.TabIndex = 73;
            this.btnNova.Text = "Nova";
            this.btnNova.UseVisualStyleBackColor = true;
            this.btnNova.Click += new System.EventHandler(this.btnNova_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(605, 70);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 30);
            this.btnSalvar.TabIndex = 75;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(605, 106);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 30);
            this.btnEditar.TabIndex = 76;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(605, 142);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(109, 30);
            this.btnExcluir.TabIndex = 77;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAulas);
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 273);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aulas Cadastradas";
            // 
            // txtAulaID
            // 
            this.txtAulaID.Location = new System.Drawing.Point(605, 188);
            this.txtAulaID.Name = "txtAulaID";
            this.txtAulaID.ReadOnly = true;
            this.txtAulaID.Size = new System.Drawing.Size(109, 20);
            this.txtAulaID.TabIndex = 82;
            this.txtAulaID.Visible = false;
            // 
            // frmCadastroAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 359);
            this.Controls.Add(this.txtAulaID);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNova);
            this.Controls.Add(this.txtAula);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroAulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Aulas";
            this.Load += new System.EventHandler(this.frmCadastroAulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.DataGridView dgvAulas;
        private System.Windows.Forms.Button btnNova;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAulaID;
    }
}