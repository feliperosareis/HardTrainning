namespace HardTrainning
{
    partial class frmCheckin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cboAulas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.txtAlunoID = new System.Windows.Forms.TextBox();
            this.dgvCheckin = new System.Windows.Forms.DataGridView();
            this.txtAulaID = new System.Windows.Forms.TextBox();
            this.txtAlunoIDConfirmado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(263, 160);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(263, 206);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 43);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cboAulas
            // 
            this.cboAulas.DisplayMember = "Id";
            this.cboAulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboAulas.FormattingEnabled = true;
            this.cboAulas.Location = new System.Drawing.Point(21, 37);
            this.cboAulas.Name = "cboAulas";
            this.cboAulas.Size = new System.Drawing.Size(559, 28);
            this.cboAulas.TabIndex = 4;
            this.cboAulas.ValueMember = "Id";
            this.cboAulas.SelectedIndexChanged += new System.EventHandler(this.cboAulas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecione uma Aula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Alunos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirmados na Aula";
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.GridColor = System.Drawing.Color.White;
            this.dgvAlunos.Location = new System.Drawing.Point(21, 97);
            this.dgvAlunos.MultiSelect = false;
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.RowHeadersVisible = false;
            this.dgvAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunos.Size = new System.Drawing.Size(235, 349);
            this.dgvAlunos.TabIndex = 8;
            this.dgvAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellClick);
            this.dgvAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellContentClick);
            // 
            // txtAlunoID
            // 
            this.txtAlunoID.Location = new System.Drawing.Point(180, 77);
            this.txtAlunoID.Name = "txtAlunoID";
            this.txtAlunoID.ReadOnly = true;
            this.txtAlunoID.Size = new System.Drawing.Size(76, 20);
            this.txtAlunoID.TabIndex = 9;
            this.txtAlunoID.Visible = false;
            // 
            // dgvCheckin
            // 
            this.dgvCheckin.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheckin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckin.GridColor = System.Drawing.Color.White;
            this.dgvCheckin.Location = new System.Drawing.Point(346, 97);
            this.dgvCheckin.MultiSelect = false;
            this.dgvCheckin.Name = "dgvCheckin";
            this.dgvCheckin.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckin.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheckin.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvCheckin.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCheckin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckin.Size = new System.Drawing.Size(234, 349);
            this.dgvCheckin.TabIndex = 10;
            this.dgvCheckin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckin_CellContentClick);
            // 
            // txtAulaID
            // 
            this.txtAulaID.Location = new System.Drawing.Point(263, 11);
            this.txtAulaID.Name = "txtAulaID";
            this.txtAulaID.Size = new System.Drawing.Size(75, 20);
            this.txtAulaID.TabIndex = 11;
            this.txtAulaID.Visible = false;
            // 
            // txtAlunoIDConfirmado
            // 
            this.txtAlunoIDConfirmado.Location = new System.Drawing.Point(504, 77);
            this.txtAlunoIDConfirmado.Name = "txtAlunoIDConfirmado";
            this.txtAlunoIDConfirmado.ReadOnly = true;
            this.txtAlunoIDConfirmado.Size = new System.Drawing.Size(76, 20);
            this.txtAlunoIDConfirmado.TabIndex = 12;
            this.txtAlunoIDConfirmado.Visible = false;
            // 
            // frmCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 462);
            this.Controls.Add(this.txtAlunoIDConfirmado);
            this.Controls.Add(this.txtAulaID);
            this.Controls.Add(this.dgvCheckin);
            this.Controls.Add(this.txtAlunoID);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAulas);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmCheckin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check-in Hardtrainning";
            this.Load += new System.EventHandler(this.frmCheckin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cboAulas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.TextBox txtAlunoID;
        private System.Windows.Forms.DataGridView dgvCheckin;
        private System.Windows.Forms.TextBox txtAulaID;
        private System.Windows.Forms.TextBox txtAlunoIDConfirmado;
    }
}