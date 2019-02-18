namespace ScoreCalculator
{
    partial class ScoreCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreCalculator));
            this.btnClearScores = new System.Windows.Forms.Button();
            this.lblScoreTotal = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtScoreTotal = new System.Windows.Forms.TextBox();
            this.txtScoreCount = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnDisplayScores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClearScores
            // 
            this.btnClearScores.Location = new System.Drawing.Point(251, 189);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(124, 37);
            this.btnClearScores.TabIndex = 2;
            this.btnClearScores.Text = "&Clear Scores";
            this.btnClearScores.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblScoreTotal
            // 
            this.lblScoreTotal.Location = new System.Drawing.Point(40, 76);
            this.lblScoreTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreTotal.Name = "lblScoreTotal";
            this.lblScoreTotal.Size = new System.Drawing.Size(108, 25);
            this.lblScoreTotal.TabIndex = 3;
            this.lblScoreTotal.Text = "Score total:";
            this.lblScoreTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.Location = new System.Drawing.Point(40, 111);
            this.lblScoreCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(108, 25);
            this.lblScoreCount.TabIndex = 5;
            this.lblScoreCount.Text = "Score count:";
            this.lblScoreCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(251, 243);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(251, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(158, 39);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(58, 26);
            this.txtScore.TabIndex = 0;
            // 
            // lblAverage
            // 
            this.lblAverage.Location = new System.Drawing.Point(40, 148);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(108, 25);
            this.lblAverage.TabIndex = 7;
            this.lblAverage.Text = "Average:";
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(42, 40);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(108, 25);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score:";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtScoreTotal
            // 
            this.txtScoreTotal.Location = new System.Drawing.Point(156, 75);
            this.txtScoreTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtScoreTotal.Name = "txtScoreTotal";
            this.txtScoreTotal.ReadOnly = true;
            this.txtScoreTotal.Size = new System.Drawing.Size(60, 26);
            this.txtScoreTotal.TabIndex = 4;
            this.txtScoreTotal.TabStop = false;
            // 
            // txtScoreCount
            // 
            this.txtScoreCount.Location = new System.Drawing.Point(156, 111);
            this.txtScoreCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtScoreCount.Name = "txtScoreCount";
            this.txtScoreCount.ReadOnly = true;
            this.txtScoreCount.Size = new System.Drawing.Size(60, 26);
            this.txtScoreCount.TabIndex = 6;
            this.txtScoreCount.TabStop = false;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(156, 147);
            this.txtAverage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(60, 26);
            this.txtAverage.TabIndex = 8;
            this.txtAverage.TabStop = false;
            // 
            // btnDisplayScores
            // 
            this.btnDisplayScores.Location = new System.Drawing.Point(92, 189);
            this.btnDisplayScores.Name = "btnDisplayScores";
            this.btnDisplayScores.Size = new System.Drawing.Size(124, 37);
            this.btnDisplayScores.TabIndex = 9;
            this.btnDisplayScores.Text = "&Display Scores";
            this.btnDisplayScores.Click += new System.EventHandler(this.btnDisplayScores_Click);
            // 
            // ScoreCalculator
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(399, 312);
            this.Controls.Add(this.btnDisplayScores);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtScoreCount);
            this.Controls.Add(this.txtScoreTotal);
            this.Controls.Add(this.btnClearScores);
            this.Controls.Add(this.lblScoreTotal);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ScoreCalculator";
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnClearScores;
        internal System.Windows.Forms.Label lblScoreTotal;
        internal System.Windows.Forms.Label lblScoreCount;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.TextBox txtScore;
        internal System.Windows.Forms.Label lblAverage;
        internal System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtScoreTotal;
        private System.Windows.Forms.TextBox txtScoreCount;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnDisplayScores;
    }
}

