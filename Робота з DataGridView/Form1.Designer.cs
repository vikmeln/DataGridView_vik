namespace Робота_з_DataGridView
{
    partial class frmMass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.TextBox();
            this.txtm = new System.Windows.Forms.TextBox();
            this.txtRez = new System.Windows.Forms.TextBox();
            this.dgvMass = new System.Windows.Forms.DataGridView();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество строк n=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество столбцов m=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Результат:";
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(52, 95);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(206, 35);
            this.txtn.TabIndex = 3;
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(52, 230);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(206, 35);
            this.txtm.TabIndex = 4;
            // 
            // txtRez
            // 
            this.txtRez.Location = new System.Drawing.Point(63, 366);
            this.txtRez.Multiline = true;
            this.txtRez.Name = "txtRez";
            this.txtRez.Size = new System.Drawing.Size(372, 184);
            this.txtRez.TabIndex = 5;
            // 
            // dgvMass
            // 
            this.dgvMass.AllowUserToOrderColumns = true;
            this.dgvMass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMass.Location = new System.Drawing.Point(564, 26);
            this.dgvMass.Name = "dgvMass";
            this.dgvMass.RowHeadersWidth = 62;
            this.dgvMass.RowTemplate.Height = 28;
            this.dgvMass.Size = new System.Drawing.Size(649, 524);
            this.dgvMass.TabIndex = 6;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(63, 575);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(239, 51);
            this.cmdStart.TabIndex = 7;
            this.cmdStart.Text = "Вычислить";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(969, 575);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(244, 51);
            this.cmdExit.TabIndex = 8;
            this.cmdExit.Text = "Завершить работу";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(511, 575);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(259, 51);
            this.cmdClear.TabIndex = 9;
            this.cmdClear.Text = "Очистка полей";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // frmMass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 652);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.dgvMass);
            this.Controls.Add(this.txtRez);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMass";
            this.Text = "Двумерные массивы";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.TextBox txtRez;
        private System.Windows.Forms.DataGridView dgvMass;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdClear;
    }
}

