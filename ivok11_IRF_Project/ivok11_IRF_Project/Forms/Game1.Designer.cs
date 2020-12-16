
namespace ivok11_IRF_Project
{
    partial class Game1
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
            this.Btnnext = new System.Windows.Forms.Button();
            this.tbresult = new System.Windows.Forms.TextBox();
            this.labelpontok = new System.Windows.Forms.Label();
            this.BtnNewGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Car2 = new ivok11_IRF_Project.PlayingButton();
            this.Car1 = new ivok11_IRF_Project.PlayingButton();
            this.SuspendLayout();
            // 
            // Btnnext
            // 
            this.Btnnext.Location = new System.Drawing.Point(530, 238);
            this.Btnnext.Name = "Btnnext";
            this.Btnnext.Size = new System.Drawing.Size(103, 28);
            this.Btnnext.TabIndex = 9;
            this.Btnnext.Text = "Következő";
            this.Btnnext.UseVisualStyleBackColor = true;
            this.Btnnext.Click += new System.EventHandler(this.Btnnext_Click);
            // 
            // tbresult
            // 
            this.tbresult.Location = new System.Drawing.Point(398, 246);
            this.tbresult.Name = "tbresult";
            this.tbresult.Size = new System.Drawing.Size(110, 20);
            this.tbresult.TabIndex = 10;
            // 
            // labelpontok
            // 
            this.labelpontok.AutoSize = true;
            this.labelpontok.Location = new System.Drawing.Point(304, 241);
            this.labelpontok.Name = "labelpontok";
            this.labelpontok.Size = new System.Drawing.Size(35, 13);
            this.labelpontok.TabIndex = 11;
            this.labelpontok.Text = "label1";
            // 
            // BtnNewGame
            // 
            this.BtnNewGame.BackColor = System.Drawing.Color.Coral;
            this.BtnNewGame.Location = new System.Drawing.Point(46, 39);
            this.BtnNewGame.Name = "BtnNewGame";
            this.BtnNewGame.Size = new System.Drawing.Size(106, 44);
            this.BtnNewGame.TabIndex = 12;
            this.BtnNewGame.Text = "New Game";
            this.BtnNewGame.UseVisualStyleBackColor = false;
            this.BtnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Melyik autó a drágább?";
            // 
            // Car2
            // 
            this.Car2.Location = new System.Drawing.Point(477, 123);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(140, 62);
            this.Car2.TabIndex = 5;
            this.Car2.UseVisualStyleBackColor = true;
            this.Car2.Value = 0;
            this.Car2.Click += new System.EventHandler(this.Car2_Click);
            // 
            // Car1
            // 
            this.Car1.Location = new System.Drawing.Point(287, 123);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(140, 62);
            this.Car1.TabIndex = 4;
            this.Car1.UseVisualStyleBackColor = true;
            this.Car1.Value = 0;
            this.Car1.Click += new System.EventHandler(this.Car1_Click);
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNewGame);
            this.Controls.Add(this.labelpontok);
            this.Controls.Add(this.tbresult);
            this.Controls.Add(this.Btnnext);
            this.Controls.Add(this.Car2);
            this.Controls.Add(this.Car1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game1";
            this.Text = "Game1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlayingButton Car1;
        private PlayingButton Car2;
        private System.Windows.Forms.Button Btnnext;
        private System.Windows.Forms.TextBox tbresult;
        private System.Windows.Forms.Label labelpontok;
        private System.Windows.Forms.Button BtnNewGame;
        private System.Windows.Forms.Label label1;
    }
}