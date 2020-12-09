
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
            this.filewritingbtn = new System.Windows.Forms.Button();
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
            // filewritingbtn
            // 
            this.filewritingbtn.Location = new System.Drawing.Point(292, 224);
            this.filewritingbtn.Name = "filewritingbtn";
            this.filewritingbtn.Size = new System.Drawing.Size(178, 31);
            this.filewritingbtn.TabIndex = 1;
            this.filewritingbtn.Text = "Write cards in file";
            this.filewritingbtn.UseVisualStyleBackColor = true;
            this.filewritingbtn.Click += new System.EventHandler(this.filewritingbtn_Click);
            // 
            // LearningCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filewritingbtn);
            this.Controls.Add(this.NewCardBtn);
            this.Name = "LearningCardsForm";
            this.Text = "LearningCardsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewCardBtn;
        private System.Windows.Forms.Button filewritingbtn;
    }
}