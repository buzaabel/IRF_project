
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
            this.car1btn = new System.Windows.Forms.Button();
            this.car2btn = new System.Windows.Forms.Button();
            this.car3btn = new System.Windows.Forms.Button();
            this.car4btn = new System.Windows.Forms.Button();
            this.nextbtn = new System.Windows.Forms.Button();
            this.newgamebtn = new System.Windows.Forms.Button();
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
            // car1btn
            // 
            this.car1btn.Location = new System.Drawing.Point(295, 117);
            this.car1btn.Name = "car1btn";
            this.car1btn.Size = new System.Drawing.Size(116, 53);
            this.car1btn.TabIndex = 3;
            this.car1btn.Text = "button1";
            this.car1btn.UseVisualStyleBackColor = true;
            this.car1btn.Click += new System.EventHandler(this.car1btn_Click);
            // 
            // car2btn
            // 
            this.car2btn.Location = new System.Drawing.Point(431, 117);
            this.car2btn.Name = "car2btn";
            this.car2btn.Size = new System.Drawing.Size(116, 53);
            this.car2btn.TabIndex = 4;
            this.car2btn.Text = "button2";
            this.car2btn.UseVisualStyleBackColor = true;
            this.car2btn.Click += new System.EventHandler(this.car2btn_Click);
            // 
            // car3btn
            // 
            this.car3btn.Location = new System.Drawing.Point(295, 193);
            this.car3btn.Name = "car3btn";
            this.car3btn.Size = new System.Drawing.Size(116, 53);
            this.car3btn.TabIndex = 5;
            this.car3btn.Text = "button3";
            this.car3btn.UseVisualStyleBackColor = true;
            this.car3btn.Click += new System.EventHandler(this.car3btn_Click);
            // 
            // car4btn
            // 
            this.car4btn.Location = new System.Drawing.Point(431, 193);
            this.car4btn.Name = "car4btn";
            this.car4btn.Size = new System.Drawing.Size(116, 53);
            this.car4btn.TabIndex = 6;
            this.car4btn.Text = "button4";
            this.car4btn.UseVisualStyleBackColor = true;
            this.car4btn.Click += new System.EventHandler(this.car4btn_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.Location = new System.Drawing.Point(565, 250);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(158, 33);
            this.nextbtn.TabIndex = 7;
            this.nextbtn.Text = "Next";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // newgamebtn
            // 
            this.newgamebtn.BackColor = System.Drawing.Color.Coral;
            this.newgamebtn.Location = new System.Drawing.Point(37, 23);
            this.newgamebtn.Name = "newgamebtn";
            this.newgamebtn.Size = new System.Drawing.Size(128, 45);
            this.newgamebtn.TabIndex = 8;
            this.newgamebtn.Text = "New Game";
            this.newgamebtn.UseVisualStyleBackColor = false;
            this.newgamebtn.Click += new System.EventHandler(this.newgamebtn_Click);
            // 
            // pontoklabel
            // 
            this.pontoklabel.AutoSize = true;
            this.pontoklabel.Location = new System.Drawing.Point(271, 257);
            this.pontoklabel.Name = "pontoklabel";
            this.pontoklabel.Size = new System.Drawing.Size(35, 13);
            this.pontoklabel.TabIndex = 9;
            this.pontoklabel.Text = "label3";
            // 
            // GuessGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pontoklabel);
            this.Controls.Add(this.newgamebtn);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.car4btn);
            this.Controls.Add(this.car3btn);
            this.Controls.Add(this.car2btn);
            this.Controls.Add(this.car1btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.autotb);
            this.Controls.Add(this.label1);
            this.Name = "GuessGameForm";
            this.Text = "GuessGameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button car1btn;
        private System.Windows.Forms.Button car2btn;
        private System.Windows.Forms.Button car3btn;
        private System.Windows.Forms.Button car4btn;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.Button newgamebtn;
        private System.Windows.Forms.TextBox autotb;
        private System.Windows.Forms.Label pontoklabel;
    }
}