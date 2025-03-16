namespace X_O
{
    partial class Main_Menue
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
            this.btnP2PForm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnP2PForm
            // 
            this.btnP2PForm.BackColor = System.Drawing.Color.Green;
            this.btnP2PForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnP2PForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP2PForm.Location = new System.Drawing.Point(319, 157);
            this.btnP2PForm.Name = "btnP2PForm";
            this.btnP2PForm.Size = new System.Drawing.Size(209, 125);
            this.btnP2PForm.TabIndex = 4;
            this.btnP2PForm.Text = "Person2Person game";
            this.btnP2PForm.UseVisualStyleBackColor = false;
            this.btnP2PForm.Click += new System.EventHandler(this.btnP2PForm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(30, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 56);
            this.label5.TabIndex = 35;
            this.label5.Text = "Aboda";
            // 
            // Main_Menue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnP2PForm);
            this.Name = "Main_Menue";
            this.Text = "Main Menue";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnP2PForm;
        private System.Windows.Forms.Label label5;
    }
}

