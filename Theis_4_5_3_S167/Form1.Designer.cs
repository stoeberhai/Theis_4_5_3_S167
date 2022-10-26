namespace Theis_4_5_3_S167
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnShow = new System.Windows.Forms.Button();
            this.LblInputData = new System.Windows.Forms.Label();
            this.LblOutputData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(322, 9);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(75, 23);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Anzeige";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // LblInputData
            // 
            this.LblInputData.AutoSize = true;
            this.LblInputData.Location = new System.Drawing.Point(12, 9);
            this.LblInputData.Name = "LblInputData";
            this.LblInputData.Size = new System.Drawing.Size(52, 15);
            this.LblInputData.TabIndex = 1;
            this.LblInputData.Text = "EIngabe:";
            // 
            // LblOutputData
            // 
            this.LblOutputData.AutoSize = true;
            this.LblOutputData.Location = new System.Drawing.Point(12, 53);
            this.LblOutputData.Name = "LblOutputData";
            this.LblOutputData.Size = new System.Drawing.Size(56, 15);
            this.LblOutputData.TabIndex = 2;
            this.LblOutputData.Text = "Ausgabe:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 91);
            this.Controls.Add(this.LblOutputData);
            this.Controls.Add(this.LblInputData);
            this.Controls.Add(this.BtnShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnShow;
        private Label LblInputData;
        private Label LblOutputData;
    }
}