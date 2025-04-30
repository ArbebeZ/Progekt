namespace Proekt
{
    partial class GeneralMenu
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
            this.expBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.labelExp3 = new System.Windows.Forms.Label();
            this.healthBar1 = new System.Windows.Forms.ProgressBar();
            this.HealthLabel3 = new System.Windows.Forms.Label();
            this.ManaBar1 = new System.Windows.Forms.ProgressBar();
            this.ManaLabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // expBar1
            // 
            this.expBar1.Location = new System.Drawing.Point(12, 89);
            this.expBar1.Name = "expBar1";
            this.expBar1.Size = new System.Drawing.Size(240, 32);
            this.expBar1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // labelExp3
            // 
            this.labelExp3.AutoSize = true;
            this.labelExp3.Location = new System.Drawing.Point(127, 73);
            this.labelExp3.Name = "labelExp3";
            this.labelExp3.Size = new System.Drawing.Size(0, 13);
            this.labelExp3.TabIndex = 3;
            // 
            // healthBar1
            // 
            this.healthBar1.Location = new System.Drawing.Point(12, 167);
            this.healthBar1.Name = "healthBar1";
            this.healthBar1.Size = new System.Drawing.Size(240, 32);
            this.healthBar1.TabIndex = 4;
            // 
            // HealthLabel3
            // 
            this.HealthLabel3.AutoSize = true;
            this.HealthLabel3.Location = new System.Drawing.Point(13, 148);
            this.HealthLabel3.Name = "HealthLabel3";
            this.HealthLabel3.Size = new System.Drawing.Size(0, 13);
            this.HealthLabel3.TabIndex = 5;
            // 
            // ManaBar1
            // 
            this.ManaBar1.Location = new System.Drawing.Point(12, 241);
            this.ManaBar1.Name = "ManaBar1";
            this.ManaBar1.Size = new System.Drawing.Size(240, 32);
            this.ManaBar1.TabIndex = 6;
            // 
            // ManaLabel3
            // 
            this.ManaLabel3.AutoSize = true;
            this.ManaLabel3.Location = new System.Drawing.Point(12, 222);
            this.ManaLabel3.Name = "ManaLabel3";
            this.ManaLabel3.Size = new System.Drawing.Size(0, 13);
            this.ManaLabel3.TabIndex = 7;
            // 
            // GeneralMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 431);
            this.Controls.Add(this.ManaLabel3);
            this.Controls.Add(this.ManaBar1);
            this.Controls.Add(this.HealthLabel3);
            this.Controls.Add(this.healthBar1);
            this.Controls.Add(this.labelExp3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expBar1);
            this.Controls.Add(this.label1);
            this.Name = "GeneralMenu";
            this.Text = "GeneralMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar expBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelExp3;
        private System.Windows.Forms.ProgressBar healthBar1;
        private System.Windows.Forms.Label HealthLabel3;
        private System.Windows.Forms.ProgressBar ManaBar1;
        private System.Windows.Forms.Label ManaLabel3;
    }
}