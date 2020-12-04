
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
            this.tbresult = new System.Windows.Forms.TextBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.labelpontok = new System.Windows.Forms.Label();
            this.btnnext = new System.Windows.Forms.Button();
            this.car2 = new ivok11_IRF_Project.PlayingButton();
            this.car1 = new ivok11_IRF_Project.PlayingButton();
            this.LCardsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbresult
            // 
            this.tbresult.Location = new System.Drawing.Point(458, 218);
            this.tbresult.Name = "tbresult";
            this.tbresult.Size = new System.Drawing.Size(110, 20);
            this.tbresult.TabIndex = 5;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(12, 56);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(106, 44);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // labelpontok
            // 
            this.labelpontok.AutoSize = true;
            this.labelpontok.Location = new System.Drawing.Point(328, 221);
            this.labelpontok.Name = "labelpontok";
            this.labelpontok.Size = new System.Drawing.Size(35, 13);
            this.labelpontok.TabIndex = 7;
            this.labelpontok.Text = "label1";
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(611, 213);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(103, 28);
            this.btnnext.TabIndex = 8;
            this.btnnext.Text = "Következő";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // car2
            // 
            this.car2.Location = new System.Drawing.Point(541, 47);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(140, 62);
            this.car2.TabIndex = 4;
            this.car2.Text = "playingButton2";
            this.car2.UseVisualStyleBackColor = true;
            this.car2.Value = 0;
            this.car2.Click += new System.EventHandler(this.car2_Click);
            // 
            // car1
            // 
            this.car1.Location = new System.Drawing.Point(331, 47);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(140, 62);
            this.car1.TabIndex = 3;
            this.car1.Text = "playingButton1";
            this.car1.UseVisualStyleBackColor = true;
            this.car1.Value = 0;
            this.car1.Click += new System.EventHandler(this.car1_Click);
            // 
            // LCardsBtn
            // 
            this.LCardsBtn.Location = new System.Drawing.Point(13, 119);
            this.LCardsBtn.Name = "LCardsBtn";
            this.LCardsBtn.Size = new System.Drawing.Size(104, 42);
            this.LCardsBtn.TabIndex = 9;
            this.LCardsBtn.Text = "Learning cards";
            this.LCardsBtn.UseVisualStyleBackColor = true;
            this.LCardsBtn.Click += new System.EventHandler(this.LCardsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LCardsBtn);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.labelpontok);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.tbresult);
            this.Controls.Add(this.car2);
            this.Controls.Add(this.car1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PlayingButton car1;
        private PlayingButton car2;
        private System.Windows.Forms.TextBox tbresult;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label labelpontok;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button LCardsBtn;
    }
}

