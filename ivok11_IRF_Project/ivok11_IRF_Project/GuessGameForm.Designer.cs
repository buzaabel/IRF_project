
namespace ivok11_IRF_Project
{
    partial class GuessGameForm
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
            this.autotb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Car1btn = new System.Windows.Forms.Button();
            this.Car2btn = new System.Windows.Forms.Button();
            this.Car3btn = new System.Windows.Forms.Button();
            this.Car4btn = new System.Windows.Forms.Button();
            this.Nextbtn = new System.Windows.Forms.Button();
            this.Newgamebtn = new System.Windows.Forms.Button();
            this.pontoklabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mennyibe kerül a(z)";
            // 
            // autotb
            // 
            this.autotb.Enabled = false;
            this.autotb.Location = new System.Drawing.Point(371, 53);
            this.autotb.Name = "autotb";
            this.autotb.Size = new System.Drawing.Size(185, 20);
            this.autotb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "?";
            // 
            // Car1btn
            // 
            this.Car1btn.Location = new System.Drawing.Point(295, 117);
            this.Car1btn.Name = "Car1btn";
            this.Car1btn.Size = new System.Drawing.Size(116, 53);
            this.Car1btn.TabIndex = 3;
            this.Car1btn.UseVisualStyleBackColor = true;
            this.Car1btn.Click += new System.EventHandler(this.Car1btn_Click);
            // 
            // Car2btn
            // 
            this.Car2btn.Location = new System.Drawing.Point(431, 117);
            this.Car2btn.Name = "Car2btn";
            this.Car2btn.Size = new System.Drawing.Size(116, 53);
            this.Car2btn.TabIndex = 4;
            this.Car2btn.UseVisualStyleBackColor = true;
            this.Car2btn.Click += new System.EventHandler(this.Car2btn_Click);
            // 
            // Car3btn
            // 
            this.Car3btn.Location = new System.Drawing.Point(295, 193);
            this.Car3btn.Name = "Car3btn";
            this.Car3btn.Size = new System.Drawing.Size(116, 53);
            this.Car3btn.TabIndex = 5;
            this.Car3btn.UseVisualStyleBackColor = true;
            this.Car3btn.Click += new System.EventHandler(this.Car3btn_Click);
            // 
            // Car4btn
            // 
            this.Car4btn.Location = new System.Drawing.Point(431, 193);
            this.Car4btn.Name = "Car4btn";
            this.Car4btn.Size = new System.Drawing.Size(116, 53);
            this.Car4btn.TabIndex = 6;
            this.Car4btn.UseVisualStyleBackColor = true;
            this.Car4btn.Click += new System.EventHandler(this.Car4btn_Click);
            // 
            // Nextbtn
            // 
            this.Nextbtn.Location = new System.Drawing.Point(565, 250);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(158, 33);
            this.Nextbtn.TabIndex = 7;
            this.Nextbtn.Text = "Next";
            this.Nextbtn.UseVisualStyleBackColor = true;
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // Newgamebtn
            // 
            this.Newgamebtn.BackColor = System.Drawing.Color.Coral;
            this.Newgamebtn.Location = new System.Drawing.Point(37, 23);
            this.Newgamebtn.Name = "Newgamebtn";
            this.Newgamebtn.Size = new System.Drawing.Size(128, 45);
            this.Newgamebtn.TabIndex = 8;
            this.Newgamebtn.Text = "New Game";
            this.Newgamebtn.UseVisualStyleBackColor = false;
            this.Newgamebtn.Click += new System.EventHandler(this.Newgamebtn_Click);
            // 
            // pontoklabel
            // 
            this.pontoklabel.AutoSize = true;
            this.pontoklabel.Location = new System.Drawing.Point(271, 257);
            this.pontoklabel.Name = "pontoklabel";
            this.pontoklabel.Size = new System.Drawing.Size(13, 13);
            this.pontoklabel.TabIndex = 9;
            this.pontoklabel.Text = "0";
            // 
            // GuessGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pontoklabel);
            this.Controls.Add(this.Newgamebtn);
            this.Controls.Add(this.Nextbtn);
            this.Controls.Add(this.Car4btn);
            this.Controls.Add(this.Car3btn);
            this.Controls.Add(this.Car2btn);
            this.Controls.Add(this.Car1btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.autotb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GuessGameForm";
            this.Text = "GuessGameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Car1btn;
        private System.Windows.Forms.Button Car2btn;
        private System.Windows.Forms.Button Car3btn;
        private System.Windows.Forms.Button Car4btn;
        private System.Windows.Forms.Button Nextbtn;
        private System.Windows.Forms.Button Newgamebtn;
        private System.Windows.Forms.TextBox autotb;
        private System.Windows.Forms.Label pontoklabel;
    }
}