
namespace ivok11_IRF_Project
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
            this.LCardsBtn = new System.Windows.Forms.Button();
            this.GuessGamebtn = new System.Windows.Forms.Button();
            this.game1btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LCardsBtn
            // 
            this.LCardsBtn.Location = new System.Drawing.Point(300, 114);
            this.LCardsBtn.Name = "LCardsBtn";
            this.LCardsBtn.Size = new System.Drawing.Size(195, 80);
            this.LCardsBtn.TabIndex = 9;
            this.LCardsBtn.Text = "Learning cards";
            this.LCardsBtn.UseVisualStyleBackColor = true;
            this.LCardsBtn.Click += new System.EventHandler(this.LCardsBtn_Click);
            // 
            // GuessGamebtn
            // 
            this.GuessGamebtn.Location = new System.Drawing.Point(34, 128);
            this.GuessGamebtn.Name = "GuessGamebtn";
            this.GuessGamebtn.Size = new System.Drawing.Size(217, 57);
            this.GuessGamebtn.TabIndex = 10;
            this.GuessGamebtn.Text = "Guess Game";
            this.GuessGamebtn.UseVisualStyleBackColor = true;
            this.GuessGamebtn.Click += new System.EventHandler(this.GuessGamebtn_Click);
            // 
            // game1btn
            // 
            this.game1btn.Location = new System.Drawing.Point(545, 128);
            this.game1btn.Name = "game1btn";
            this.game1btn.Size = new System.Drawing.Size(206, 57);
            this.game1btn.TabIndex = 11;
            this.game1btn.Text = "Guess Game2";
            this.game1btn.UseVisualStyleBackColor = true;
            this.game1btn.Click += new System.EventHandler(this.game1btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.game1btn);
            this.Controls.Add(this.GuessGamebtn);
            this.Controls.Add(this.LCardsBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button LCardsBtn;
        private System.Windows.Forms.Button GuessGamebtn;
        private System.Windows.Forms.Button game1btn;
    }
}

