namespace WinFormUI
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NudFirstNumber = new System.Windows.Forms.NumericUpDown();
            this.NudSecondNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnSubtract = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtResults = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnAddPerson = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbUsers = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFirstNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSecondNumber)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtResults);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnDivide);
            this.groupBox1.Controls.Add(this.BtnMultiply);
            this.groupBox1.Controls.Add(this.BtnSubtract);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.NudSecondNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NudFirstNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // NudFirstNumber
            // 
            this.NudFirstNumber.Location = new System.Drawing.Point(131, 44);
            this.NudFirstNumber.Name = "NudFirstNumber";
            this.NudFirstNumber.Size = new System.Drawing.Size(105, 22);
            this.NudFirstNumber.TabIndex = 1;
            // 
            // NudSecondNumber
            // 
            this.NudSecondNumber.Location = new System.Drawing.Point(131, 72);
            this.NudSecondNumber.Name = "NudSecondNumber";
            this.NudSecondNumber.Size = new System.Drawing.Size(105, 22);
            this.NudSecondNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second Number";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(9, 108);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(93, 27);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnSubtract
            // 
            this.BtnSubtract.Location = new System.Drawing.Point(9, 141);
            this.BtnSubtract.Name = "BtnSubtract";
            this.BtnSubtract.Size = new System.Drawing.Size(93, 27);
            this.BtnSubtract.TabIndex = 4;
            this.BtnSubtract.Text = "Subtract";
            this.BtnSubtract.UseVisualStyleBackColor = true;
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Location = new System.Drawing.Point(9, 174);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(93, 27);
            this.BtnMultiply.TabIndex = 4;
            this.BtnMultiply.Text = "Multiply";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            // 
            // BtnDivide
            // 
            this.BtnDivide.Location = new System.Drawing.Point(9, 207);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(93, 27);
            this.BtnDivide.TabIndex = 4;
            this.BtnDivide.Text = "Divide";
            this.BtnDivide.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Results";
            // 
            // TxtResults
            // 
            this.TxtResults.Location = new System.Drawing.Point(131, 176);
            this.TxtResults.Name = "TxtResults";
            this.TxtResults.Size = new System.Drawing.Size(93, 22);
            this.TxtResults.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CbUsers);
            this.groupBox2.Controls.Add(this.TxtLastName);
            this.groupBox2.Controls.Add(this.TxtFirstName);
            this.groupBox2.Controls.Add(this.BtnAddPerson);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(288, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 243);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database Section";
            // 
            // BtnAddPerson
            // 
            this.BtnAddPerson.Location = new System.Drawing.Point(79, 207);
            this.BtnAddPerson.Name = "BtnAddPerson";
            this.BtnAddPerson.Size = new System.Drawing.Size(114, 23);
            this.BtnAddPerson.TabIndex = 4;
            this.BtnAddPerson.Text = "Add Person";
            this.BtnAddPerson.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "First Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(95, 113);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(152, 22);
            this.TxtFirstName.TabIndex = 7;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(94, 140);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(152, 22);
            this.TxtLastName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Users";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // CbUsers
            // 
            this.CbUsers.FormattingEnabled = true;
            this.CbUsers.Location = new System.Drawing.Point(62, 70);
            this.CbUsers.Name = "CbUsers";
            this.CbUsers.Size = new System.Drawing.Size(185, 24);
            this.CbUsers.TabIndex = 8;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 303);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Dashboard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFirstNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSecondNumber)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button BtnSubtract;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.NumericUpDown NudSecondNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NudFirstNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Button BtnAddPerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbUsers;
        private System.Windows.Forms.Label label7;
    }
}

