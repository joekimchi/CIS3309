namespace ChangeCalculator
{
    partial class frmChangeCalculator
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
            this.lblAmountOfChangeDue = new System.Windows.Forms.Label();
            this.lblQuarters = new System.Windows.Forms.Label();
            this.lblDimes = new System.Windows.Forms.Label();
            this.lblNickels = new System.Windows.Forms.Label();
            this.lblPennies = new System.Windows.Forms.Label();
            this.txtAmountOfChangeDue = new System.Windows.Forms.TextBox();
            this.txtQuarters = new System.Windows.Forms.TextBox();
            this.txtDimes = new System.Windows.Forms.TextBox();
            this.txtNickels = new System.Windows.Forms.TextBox();
            this.txtPennies = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAmountOfChangeDue
            // 
            this.lblAmountOfChangeDue.AutoSize = true;
            this.lblAmountOfChangeDue.Location = new System.Drawing.Point(45, 36);
            this.lblAmountOfChangeDue.Name = "lblAmountOfChangeDue";
            this.lblAmountOfChangeDue.Size = new System.Drawing.Size(221, 20);
            this.lblAmountOfChangeDue.TabIndex = 0;
            this.lblAmountOfChangeDue.Text = "Amount of change due (0-99):";
            // 
            // lblQuarters
            // 
            this.lblQuarters.AutoSize = true;
            this.lblQuarters.Location = new System.Drawing.Point(196, 78);
            this.lblQuarters.Name = "lblQuarters";
            this.lblQuarters.Size = new System.Drawing.Size(75, 20);
            this.lblQuarters.TabIndex = 1;
            this.lblQuarters.Text = "Quarters:";
            // 
            // lblDimes
            // 
            this.lblDimes.AutoSize = true;
            this.lblDimes.Location = new System.Drawing.Point(209, 110);
            this.lblDimes.Name = "lblDimes";
            this.lblDimes.Size = new System.Drawing.Size(58, 20);
            this.lblDimes.TabIndex = 2;
            this.lblDimes.Text = "Dimes:";
            // 
            // lblNickels
            // 
            this.lblNickels.AutoSize = true;
            this.lblNickels.Location = new System.Drawing.Point(205, 145);
            this.lblNickels.Name = "lblNickels";
            this.lblNickels.Size = new System.Drawing.Size(63, 20);
            this.lblNickels.TabIndex = 3;
            this.lblNickels.Text = "Nickels:";
            // 
            // lblPennies
            // 
            this.lblPennies.AutoSize = true;
            this.lblPennies.Location = new System.Drawing.Point(198, 177);
            this.lblPennies.Name = "lblPennies";
            this.lblPennies.Size = new System.Drawing.Size(70, 20);
            this.lblPennies.TabIndex = 4;
            this.lblPennies.Text = "Pennies:";
            // 
            // txtAmountOfChangeDue
            // 
            this.txtAmountOfChangeDue.Location = new System.Drawing.Point(273, 29);
            this.txtAmountOfChangeDue.Name = "txtAmountOfChangeDue";
            this.txtAmountOfChangeDue.Size = new System.Drawing.Size(89, 26);
            this.txtAmountOfChangeDue.TabIndex = 0;
            // 
            // txtQuarters
            // 
            this.txtQuarters.Location = new System.Drawing.Point(273, 75);
            this.txtQuarters.Name = "txtQuarters";
            this.txtQuarters.ReadOnly = true;
            this.txtQuarters.Size = new System.Drawing.Size(89, 26);
            this.txtQuarters.TabIndex = 6;
            this.txtQuarters.TabStop = false;
            // 
            // txtDimes
            // 
            this.txtDimes.Location = new System.Drawing.Point(273, 107);
            this.txtDimes.Name = "txtDimes";
            this.txtDimes.ReadOnly = true;
            this.txtDimes.Size = new System.Drawing.Size(89, 26);
            this.txtDimes.TabIndex = 7;
            this.txtDimes.TabStop = false;
            // 
            // txtNickels
            // 
            this.txtNickels.Location = new System.Drawing.Point(273, 142);
            this.txtNickels.Name = "txtNickels";
            this.txtNickels.ReadOnly = true;
            this.txtNickels.Size = new System.Drawing.Size(89, 26);
            this.txtNickels.TabIndex = 8;
            this.txtNickels.TabStop = false;
            // 
            // txtPennies
            // 
            this.txtPennies.Location = new System.Drawing.Point(273, 174);
            this.txtPennies.Name = "txtPennies";
            this.txtPennies.ReadOnly = true;
            this.txtPennies.Size = new System.Drawing.Size(89, 26);
            this.txtPennies.TabIndex = 9;
            this.txtPennies.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalculate.Location = new System.Drawing.Point(93, 228);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(119, 31);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(244, 228);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmChangeCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(398, 286);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPennies);
            this.Controls.Add(this.txtNickels);
            this.Controls.Add(this.txtDimes);
            this.Controls.Add(this.txtQuarters);
            this.Controls.Add(this.txtAmountOfChangeDue);
            this.Controls.Add(this.lblPennies);
            this.Controls.Add(this.lblNickels);
            this.Controls.Add(this.lblDimes);
            this.Controls.Add(this.lblQuarters);
            this.Controls.Add(this.lblAmountOfChangeDue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmChangeCalculator";
            this.Text = "Change Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmountOfChangeDue;
        private System.Windows.Forms.Label lblQuarters;
        private System.Windows.Forms.Label lblDimes;
        private System.Windows.Forms.Label lblNickels;
        private System.Windows.Forms.Label lblPennies;
        private System.Windows.Forms.TextBox txtDimes;
        private System.Windows.Forms.TextBox txtNickels;
        private System.Windows.Forms.TextBox txtPennies;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtAmountOfChangeDue;
        private System.Windows.Forms.TextBox txtQuarters;
    }
}

