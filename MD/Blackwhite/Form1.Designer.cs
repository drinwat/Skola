
namespace Blackwhite
{
    partial class Form1
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
            this.butsarkans = new System.Windows.Forms.Button();
            this.butroza = new System.Windows.Forms.Button();
            this.butdzeltens = new System.Windows.Forms.Button();
            this.butzals = new System.Windows.Forms.Button();
            this.butzils = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klikšķini uz atiecīgo pogu, lai mainītu fona krāsu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // butsarkans
            // 
            this.butsarkans.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butsarkans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butsarkans.ForeColor = System.Drawing.Color.Red;
            this.butsarkans.Location = new System.Drawing.Point(78, 181);
            this.butsarkans.Name = "butsarkans";
            this.butsarkans.Size = new System.Drawing.Size(146, 84);
            this.butsarkans.TabIndex = 1;
            this.butsarkans.Text = "Sarkans";
            this.butsarkans.UseVisualStyleBackColor = false;
            this.butsarkans.Click += new System.EventHandler(this.button1_Click);
            // 
            // butroza
            // 
            this.butroza.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butroza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butroza.ForeColor = System.Drawing.Color.Pink;
            this.butroza.Location = new System.Drawing.Point(487, 181);
            this.butroza.Name = "butroza";
            this.butroza.Size = new System.Drawing.Size(120, 91);
            this.butroza.TabIndex = 2;
            this.butroza.Text = "Rozā";
            this.butroza.UseVisualStyleBackColor = false;
            this.butroza.Click += new System.EventHandler(this.butroza_Click);
            // 
            // butdzeltens
            // 
            this.butdzeltens.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butdzeltens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butdzeltens.ForeColor = System.Drawing.Color.Yellow;
            this.butdzeltens.Location = new System.Drawing.Point(440, 310);
            this.butdzeltens.Name = "butdzeltens";
            this.butdzeltens.Size = new System.Drawing.Size(148, 68);
            this.butdzeltens.TabIndex = 3;
            this.butdzeltens.Text = "Dzeltens";
            this.butdzeltens.UseVisualStyleBackColor = false;
            this.butdzeltens.Click += new System.EventHandler(this.butdzeltens_Click);
            // 
            // butzals
            // 
            this.butzals.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butzals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butzals.ForeColor = System.Drawing.Color.Green;
            this.butzals.Location = new System.Drawing.Point(209, 310);
            this.butzals.Name = "butzals";
            this.butzals.Size = new System.Drawing.Size(138, 73);
            this.butzals.TabIndex = 4;
            this.butzals.Text = "Zaļš";
            this.butzals.UseVisualStyleBackColor = false;
            this.butzals.Click += new System.EventHandler(this.butzals_Click);
            // 
            // butzils
            // 
            this.butzils.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butzils.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butzils.ForeColor = System.Drawing.Color.Blue;
            this.butzils.Location = new System.Drawing.Point(297, 181);
            this.butzils.Name = "butzils";
            this.butzils.Size = new System.Drawing.Size(127, 84);
            this.butzils.TabIndex = 5;
            this.butzils.Text = "Zils";
            this.butzils.UseVisualStyleBackColor = false;
            this.butzils.Click += new System.EventHandler(this.butzils_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butzils);
            this.Controls.Add(this.butzals);
            this.Controls.Add(this.butdzeltens);
            this.Controls.Add(this.butroza);
            this.Controls.Add(this.butsarkans);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butsarkans;
        private System.Windows.Forms.Button butroza;
        private System.Windows.Forms.Button butdzeltens;
        private System.Windows.Forms.Button butzals;
        private System.Windows.Forms.Button butzils;
    }
}

