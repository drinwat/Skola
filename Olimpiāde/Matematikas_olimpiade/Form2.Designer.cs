
namespace Matematikas_olimpiade
{
    partial class Form2
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
            this.butatbilde1 = new System.Windows.Forms.Button();
            this.butatbilde2 = new System.Windows.Forms.Button();
            this.butatbilde3 = new System.Windows.Forms.Button();
            this.labpiemeri = new System.Windows.Forms.Label();
            this.labjautajums = new System.Windows.Forms.Label();
            this.labpunkti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butatbilde1
            // 
            this.butatbilde1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butatbilde1.Location = new System.Drawing.Point(119, 250);
            this.butatbilde1.Name = "butatbilde1";
            this.butatbilde1.Size = new System.Drawing.Size(591, 40);
            this.butatbilde1.TabIndex = 0;
            this.butatbilde1.Text = "1. atbilde";
            this.butatbilde1.UseVisualStyleBackColor = true;
            // 
            // butatbilde2
            // 
            this.butatbilde2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butatbilde2.Location = new System.Drawing.Point(119, 309);
            this.butatbilde2.Name = "butatbilde2";
            this.butatbilde2.Size = new System.Drawing.Size(591, 40);
            this.butatbilde2.TabIndex = 1;
            this.butatbilde2.Text = "2. atbilde";
            this.butatbilde2.UseVisualStyleBackColor = true;
            // 
            // butatbilde3
            // 
            this.butatbilde3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butatbilde3.Location = new System.Drawing.Point(119, 367);
            this.butatbilde3.Name = "butatbilde3";
            this.butatbilde3.Size = new System.Drawing.Size(591, 39);
            this.butatbilde3.TabIndex = 2;
            this.butatbilde3.Text = "3. atbilde";
            this.butatbilde3.UseVisualStyleBackColor = true;
            // 
            // labpiemeri
            // 
            this.labpiemeri.AutoSize = true;
            this.labpiemeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labpiemeri.Location = new System.Drawing.Point(57, 61);
            this.labpiemeri.Name = "labpiemeri";
            this.labpiemeri.Size = new System.Drawing.Size(137, 25);
            this.labpiemeri.TabIndex = 3;
            this.labpiemeri.Text = "1. no 10 jaut.";
            // 
            // labjautajums
            // 
            this.labjautajums.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labjautajums.Location = new System.Drawing.Point(159, 130);
            this.labjautajums.Name = "labjautajums";
            this.labjautajums.Size = new System.Drawing.Size(498, 86);
            this.labjautajums.TabIndex = 4;
            this.labjautajums.Text = "jautājums";
            this.labjautajums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labpunkti
            // 
            this.labpunkti.AutoSize = true;
            this.labpunkti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labpunkti.Location = new System.Drawing.Point(659, 70);
            this.labpunkti.Name = "labpunkti";
            this.labpunkti.Size = new System.Drawing.Size(88, 25);
            this.labpunkti.TabIndex = 5;
            this.labpunkti.Text = "0 punkti";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labpunkti);
            this.Controls.Add(this.labjautajums);
            this.Controls.Add(this.labpiemeri);
            this.Controls.Add(this.butatbilde3);
            this.Controls.Add(this.butatbilde2);
            this.Controls.Add(this.butatbilde1);
            this.Name = "Form2";
            this.Text = "Matemātikas_Olimpiāde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butatbilde1;
        private System.Windows.Forms.Button butatbilde2;
        private System.Windows.Forms.Button butatbilde3;
        private System.Windows.Forms.Label labpiemeri;
        private System.Windows.Forms.Label labjautajums;
        private System.Windows.Forms.Label labpunkti;
    }
}