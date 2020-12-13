
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
            this.car1 = new ivok11_IRF_Project.PlayingButton();
            this.car2 = new ivok11_IRF_Project.PlayingButton();
            this.btnnext = new System.Windows.Forms.Button();
            this.tbresult = new System.Windows.Forms.TextBox();
            this.labelpontok = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // car1
            // 
            this.car1.Location = new System.Drawing.Point(287, 123);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(140, 62);
            this.car1.TabIndex = 4;
            this.car1.Text = "playingButton1";
            this.car1.UseVisualStyleBackColor = true;
            this.car1.Value = 0;
            this.car1.Click += new System.EventHandler(this.car1_Click);
            // 
            // car2
            // 
            this.car2.Location = new System.Drawing.Point(477, 123);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(140, 62);
            this.car2.TabIndex = 5;
            this.car2.Text = "playingButton2";
            this.car2.UseVisualStyleBackColor = true;
            this.car2.Value = 0;
            this.car2.Click += new System.EventHandler(this.car2_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(530, 238);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(103, 28);
            this.btnnext.TabIndex = 9;
            this.btnnext.Text = "Következő";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
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
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(46, 39);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(106, 44);
            this.btnNewGame.TabIndex = 12;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.labelpontok);
            this.Controls.Add(this.tbresult);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.car2);
            this.Controls.Add(this.car1);
            this.Name = "Game1";
            this.Text = "Game1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlayingButton car1;
        private PlayingButton car2;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.TextBox tbresult;
        private System.Windows.Forms.Label labelpontok;
        private System.Windows.Forms.Button btnNewGame;
    }
}