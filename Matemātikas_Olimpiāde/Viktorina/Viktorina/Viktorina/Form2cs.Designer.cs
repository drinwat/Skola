
namespace Viktorina
{
    partial class Form2cs
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
            this.labpiemers = new System.Windows.Forms.Label();
            this.labpunkti = new System.Windows.Forms.Label();
            this.labjautajums = new System.Windows.Forms.Label();
            this.butatbilde1 = new System.Windows.Forms.Button();
            this.butatbilde2 = new System.Windows.Forms.Button();
            this.butatbilde3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labpiemers
            // 
            this.labpiemers.AutoSize = true;
            this.labpiemers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labpiemers.Location = new System.Drawing.Point(43, 58);
            this.labpiemers.Name = "labpiemers";
            this.labpiemers.Size = new System.Drawing.Size(160, 29);
            this.labpiemers.TabIndex = 0;
            this.labpiemers.Text = "1. no 10 uzd.";
            this.labpiemers.Click += new System.EventHandler(this.label1_Click);
            // 
            // labpunkti
            // 
            this.labpunkti.AutoSize = true;
            this.labpunkti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labpunkti.Location = new System.Drawing.Point(840, 62);
            this.labpunkti.Name = "labpunkti";
            this.labpunkti.Size = new System.Drawing.Size(90, 25);
            this.labpunkti.TabIndex = 1;
            this.labpunkti.Text = "0 Punkti";
            // 
            // labjautajums
            // 
            this.labjautajums.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labjautajums.ForeColor = System.Drawing.Color.Maroon;
            this.labjautajums.Location = new System.Drawing.Point(92, 134);
            this.labjautajums.Name = "labjautajums";
            this.labjautajums.Size = new System.Drawing.Size(781, 107);
            this.labjautajums.TabIndex = 2;
            this.labjautajums.Text = "jautājums";
            this.labjautajums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labjautajums.Click += new System.EventHandler(this.label3_Click);
            // 
            // butatbilde1
            // 
            this.butatbilde1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butatbilde1.Location = new System.Drawing.Point(95, 298);
            this.butatbilde1.Name = "butatbilde1";
            this.butatbilde1.Size = new System.Drawing.Size(778, 46);
            this.butatbilde1.TabIndex = 3;
            this.butatbilde1.Text = "1. atbilde";
            this.butatbilde1.UseVisualStyleBackColor = true;
            // 
            // butatbilde2
            // 
            this.butatbilde2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butatbilde2.Location = new System.Drawing.Point(95, 350);
            this.butatbilde2.Name = "butatbilde2";
            this.butatbilde2.Size = new System.Drawing.Size(778, 58);
            this.butatbilde2.TabIndex = 4;
            this.butatbilde2.Text = "2. atbilde";
            this.butatbilde2.UseVisualStyleBackColor = true;
            // 
            // butatbilde3
            // 
            this.butatbilde3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butatbilde3.Location = new System.Drawing.Point(92, 414);
            this.butatbilde3.Name = "butatbilde3";
            this.butatbilde3.Size = new System.Drawing.Size(781, 48);
            this.butatbilde3.TabIndex = 5;
            this.butatbilde3.Text = "3. atbilde";
            this.butatbilde3.UseVisualStyleBackColor = true;
            // 
            // Form2cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 533);
            this.Controls.Add(this.butatbilde3);
            this.Controls.Add(this.butatbilde2);
            this.Controls.Add(this.butatbilde1);
            this.Controls.Add(this.labjautajums);
            this.Controls.Add(this.labpunkti);
            this.Controls.Add(this.labpiemers);
            this.Name = "Form2cs";
            this.Text = "Matemātikas_Olimpiāde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labpiemers;
        private System.Windows.Forms.Label labpunkti;
        private System.Windows.Forms.Label labjautajums;
        private System.Windows.Forms.Button butatbilde1;
        private System.Windows.Forms.Button butatbilde2;
        private System.Windows.Forms.Button butatbilde3;
    }
}