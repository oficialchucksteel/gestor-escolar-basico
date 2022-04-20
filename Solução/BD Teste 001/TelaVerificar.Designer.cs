namespace BD_Teste_001
{
    partial class TelaVerificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVerificar));
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnTelaInicial = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbId = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCurso = new System.Windows.Forms.RadioButton();
            this.rbClasse = new System.Windows.Forms.RadioButton();
            this.rbDe = new System.Windows.Forms.RadioButton();
            this.rbDn = new System.Windows.Forms.RadioButton();
            this.rbDc = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResultado
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultado.Location = new System.Drawing.Point(12, 127);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(1074, 303);
            this.dgvResultado.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnProcurar);
            this.panel3.Controls.Add(this.btnTelaInicial);
            this.panel3.Location = new System.Drawing.Point(347, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 66);
            this.panel3.TabIndex = 13;
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Location = new System.Drawing.Point(3, 3);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(195, 58);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Verificar";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnTelaInicial
            // 
            this.btnTelaInicial.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTelaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTelaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaInicial.Location = new System.Drawing.Point(204, 3);
            this.btnTelaInicial.Name = "btnTelaInicial";
            this.btnTelaInicial.Size = new System.Drawing.Size(195, 58);
            this.btnTelaInicial.TabIndex = 3;
            this.btnTelaInicial.Text = "Tela Inicial";
            this.btnTelaInicial.UseVisualStyleBackColor = false;
            this.btnTelaInicial.Click += new System.EventHandler(this.btnTelaInicial_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ordenar por:";
            // 
            // rbId
            // 
            this.rbId.AutoSize = true;
            this.rbId.Checked = true;
            this.rbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbId.Location = new System.Drawing.Point(127, 3);
            this.rbId.Name = "rbId";
            this.rbId.Size = new System.Drawing.Size(45, 28);
            this.rbId.TabIndex = 6;
            this.rbId.TabStop = true;
            this.rbId.Text = "ID";
            this.rbId.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.Location = new System.Drawing.Point(178, 3);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(80, 28);
            this.rbNome.TabIndex = 7;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbCurso
            // 
            this.rbCurso.AutoSize = true;
            this.rbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCurso.Location = new System.Drawing.Point(264, 3);
            this.rbCurso.Name = "rbCurso";
            this.rbCurso.Size = new System.Drawing.Size(78, 28);
            this.rbCurso.TabIndex = 8;
            this.rbCurso.Text = "Curso";
            this.rbCurso.UseVisualStyleBackColor = true;
            this.rbCurso.CheckedChanged += new System.EventHandler(this.rbCurso_CheckedChanged);
            // 
            // rbClasse
            // 
            this.rbClasse.AutoSize = true;
            this.rbClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbClasse.Location = new System.Drawing.Point(348, 3);
            this.rbClasse.Name = "rbClasse";
            this.rbClasse.Size = new System.Drawing.Size(84, 28);
            this.rbClasse.TabIndex = 9;
            this.rbClasse.Text = "Classe";
            this.rbClasse.UseVisualStyleBackColor = true;
            // 
            // rbDe
            // 
            this.rbDe.AutoSize = true;
            this.rbDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDe.Location = new System.Drawing.Point(438, 3);
            this.rbDe.Name = "rbDe";
            this.rbDe.Size = new System.Drawing.Size(262, 28);
            this.rbDe.TabIndex = 10;
            this.rbDe.Text = "Data de entrada à Instituição";
            this.rbDe.UseVisualStyleBackColor = true;
            // 
            // rbDn
            // 
            this.rbDn.AutoSize = true;
            this.rbDn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDn.Location = new System.Drawing.Point(706, 3);
            this.rbDn.Name = "rbDn";
            this.rbDn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbDn.Size = new System.Drawing.Size(194, 28);
            this.rbDn.TabIndex = 11;
            this.rbDn.Text = "Data de nascimento";
            this.rbDn.UseVisualStyleBackColor = true;
            // 
            // rbDc
            // 
            this.rbDc.AutoSize = true;
            this.rbDc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDc.Location = new System.Drawing.Point(906, 3);
            this.rbDc.Name = "rbDc";
            this.rbDc.Size = new System.Drawing.Size(158, 28);
            this.rbDc.TabIndex = 12;
            this.rbDc.Text = "Data de criação";
            this.rbDc.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbDc);
            this.panel2.Controls.Add(this.rbDn);
            this.panel2.Controls.Add(this.rbDe);
            this.panel2.Controls.Add(this.rbClasse);
            this.panel2.Controls.Add(this.rbCurso);
            this.panel2.Controls.Add(this.rbNome);
            this.panel2.Controls.Add(this.rbId);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 37);
            this.panel2.TabIndex = 11;
            // 
            // TelaVerificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 442);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvResultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaVerificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificar os alunos - CS Studio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnTelaInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbId;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCurso;
        private System.Windows.Forms.RadioButton rbClasse;
        private System.Windows.Forms.RadioButton rbDe;
        private System.Windows.Forms.RadioButton rbDn;
        private System.Windows.Forms.RadioButton rbDc;
        private System.Windows.Forms.Panel panel2;




    }
}