namespace RandomNumberFiler
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
            this.inputLB = new System.Windows.Forms.Label();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.startBUT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputLB
            // 
            this.inputLB.Location = new System.Drawing.Point(13, 13);
            this.inputLB.Name = "inputLB";
            this.inputLB.Size = new System.Drawing.Size(103, 56);
            this.inputLB.TabIndex = 0;
            this.inputLB.Text = "How many numbers 1-100 do you want to put into a text file?";
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(16, 73);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(100, 20);
            this.inputTB.TabIndex = 1;
            // 
            // startBUT
            // 
            this.startBUT.Location = new System.Drawing.Point(25, 99);
            this.startBUT.Name = "startBUT";
            this.startBUT.Size = new System.Drawing.Size(75, 23);
            this.startBUT.TabIndex = 3;
            this.startBUT.Text = "Start";
            this.startBUT.UseVisualStyleBackColor = true;
            this.startBUT.Click += new System.EventHandler(this.startBUT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(121, 133);
            this.Controls.Add(this.startBUT);
            this.Controls.Add(this.inputTB);
            this.Controls.Add(this.inputLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLB;
        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.Button startBUT;
    }
}

