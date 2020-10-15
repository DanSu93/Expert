namespace Expert
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numExperts = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numAlternatives = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numCriteria = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExpertNumber = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblTableName = new System.Windows.Forms.Label();
            this.lblTableNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numExperts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlternatives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCriteria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // numExperts
            // 
            this.numExperts.Location = new System.Drawing.Point(121, 12);
            this.numExperts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numExperts.Name = "numExperts";
            this.numExperts.Size = new System.Drawing.Size(42, 20);
            this.numExperts.TabIndex = 0;
            this.numExperts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numExperts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кол-во экспертов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кол-во альтернатив";
            // 
            // numAlternatives
            // 
            this.numAlternatives.Location = new System.Drawing.Point(299, 12);
            this.numAlternatives.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAlternatives.Name = "numAlternatives";
            this.numAlternatives.Size = new System.Drawing.Size(42, 20);
            this.numAlternatives.TabIndex = 2;
            this.numAlternatives.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAlternatives.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Кол-во критериев";
            // 
            // numCriteria
            // 
            this.numCriteria.Location = new System.Drawing.Point(469, 12);
            this.numCriteria.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCriteria.Name = "numCriteria";
            this.numCriteria.Size = new System.Drawing.Size(42, 20);
            this.numCriteria.TabIndex = 4;
            this.numCriteria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCriteria.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(552, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AllowUserToResizeColumns = false;
            this.dgvTable.AllowUserToResizeRows = false;
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(21, 89);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 130;
            this.dgvTable.Size = new System.Drawing.Size(606, 312);
            this.dgvTable.TabIndex = 7;
            this.dgvTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellValueChanged);
            this.dgvTable.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvTable_ColumnAdded);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Эксперт:";
            // 
            // lblExpertNumber
            // 
            this.lblExpertNumber.AutoSize = true;
            this.lblExpertNumber.Location = new System.Drawing.Point(136, 43);
            this.lblExpertNumber.Name = "lblExpertNumber";
            this.lblExpertNumber.Size = new System.Drawing.Size(13, 13);
            this.lblExpertNumber.TabIndex = 9;
            this.lblExpertNumber.Text = "1";
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(552, 407);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Далее";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Location = new System.Drawing.Point(18, 63);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(121, 13);
            this.lblTableName.TabIndex = 12;
            this.lblTableName.Text = "Матрица по критерию:";
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Location = new System.Drawing.Point(136, 63);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(13, 13);
            this.lblTableNumber.TabIndex = 13;
            this.lblTableNumber.Text = "1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 446);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblExpertNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numCriteria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numAlternatives);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numExperts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Эксперт";
            ((System.ComponentModel.ISupportInitialize)(this.numExperts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlternatives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCriteria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numExperts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numAlternatives;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCriteria;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblExpertNumber;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Label lblTableNumber;
    }
}

