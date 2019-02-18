namespace CalculateLetterGrade
{
    partial class frmCalculateGrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculateGrade));
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtNumberGrade = new System.Windows.Forms.TextBox();
            this.txtLetterGrade = new System.Windows.Forms.TextBox();
            this.lblNumberGrade = new System.Windows.Forms.Label();
            this.lblLetterGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalculate.Location = new System.Drawing.Point(43, 218);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 43);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(218, 218);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 43);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtNumberGrade
            // 
            this.txtNumberGrade.Location = new System.Drawing.Point(182, 65);
            this.txtNumberGrade.Name = "txtNumberGrade";
            this.txtNumberGrade.Size = new System.Drawing.Size(100, 26);
            this.txtNumberGrade.TabIndex = 1;
            // 
            // txtLetterGrade
            // 
            this.txtLetterGrade.Location = new System.Drawing.Point(182, 113);
            this.txtLetterGrade.Name = "txtLetterGrade";
            this.txtLetterGrade.ReadOnly = true;
            this.txtLetterGrade.Size = new System.Drawing.Size(100, 26);
            this.txtLetterGrade.TabIndex = 2;
            this.txtLetterGrade.TabStop = false;
            // 
            // lblNumberGrade
            // 
            this.lblNumberGrade.AutoSize = true;
            this.lblNumberGrade.Location = new System.Drawing.Point(58, 68);
            this.lblNumberGrade.Name = "lblNumberGrade";
            this.lblNumberGrade.Size = new System.Drawing.Size(118, 20);
            this.lblNumberGrade.TabIndex = 6;
            this.lblNumberGrade.Text = "&Number Grade:";
            // 
            // lblLetterGrade
            // 
            this.lblLetterGrade.AutoSize = true;
            this.lblLetterGrade.Location = new System.Drawing.Point(72, 119);
            this.lblLetterGrade.Name = "lblLetterGrade";
            this.lblLetterGrade.Size = new System.Drawing.Size(104, 20);
            this.lblLetterGrade.TabIndex = 7;
            this.lblLetterGrade.Text = "Letter Grade:";
            // 
            // frmCalculateGrade
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(400, 289);
            this.Controls.Add(this.lblLetterGrade);
            this.Controls.Add(this.lblNumberGrade);
            this.Controls.Add(this.txtLetterGrade);
            this.Controls.Add(this.txtNumberGrade);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculateGrade";
            this.Text = "Calculate Letter Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtNumberGrade;
        private System.Windows.Forms.TextBox txtLetterGrade;
        private System.Windows.Forms.Label lblNumberGrade;
        private System.Windows.Forms.Label lblLetterGrade;
    }
}

