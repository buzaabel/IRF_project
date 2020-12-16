
namespace ivok11_IRF_Project
{
    partial class LearningCardsForm
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
            this.NewCardBtn = new System.Windows.Forms.Button();
            this.Filewritingbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewCardBtn
            // 
            this.NewCardBtn.Location = new System.Drawing.Point(292, 131);
            this.NewCardBtn.Name = "NewCardBtn";
            this.NewCardBtn.Size = new System.Drawing.Size(179, 75);
            this.NewCardBtn.TabIndex = 0;
            this.NewCardBtn.Text = "New card";
            this.NewCardBtn.UseVisualStyleBackColor = true;
            this.NewCardBtn.Click += new System.EventHandler(this.NewCardBtn_Click);
            // 
            // Filewritingbtn
            // 
            this.Filewritingbtn.Location = new System.Drawing.Point(292, 224);
            this.Filewritingbtn.Name = "Filewritingbtn";
            this.Filewritingbtn.Size = new System.Drawing.Size(178, 31);
            this.Filewritingbtn.TabIndex = 1;
            this.Filewritingbtn.Text = "Write cards in file";
            this.Filewritingbtn.UseVisualStyleBackColor = true;
            this.Filewritingbtn.Click += new System.EventHandler(this.Filewritingbtn_Click);
            // 
            // LearningCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Filewritingbtn);
            this.Controls.Add(this.NewCardBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LearningCardsForm";
            this.Text = "LearningCardsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewCardBtn;
        private System.Windows.Forms.Button Filewritingbtn;
    }
}