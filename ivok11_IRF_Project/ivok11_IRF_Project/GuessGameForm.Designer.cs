
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.car1btn = new System.Windows.Forms.Button();
            this.car2btn = new System.Windows.Forms.Button();
            this.car3btn = new System.Windows.Forms.Button();
            this.car4btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mennyibe kerül a(z)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "?";
            // 
            // car1btn
            // 
            this.car1btn.Location = new System.Drawing.Point(137, 117);
            this.car1btn.Name = "car1btn";
            this.car1btn.Size = new System.Drawing.Size(116, 53);
            this.car1btn.TabIndex = 3;
            this.car1btn.Text = "button1";
            this.car1btn.UseVisualStyleBackColor = true;
            // 
            // car2btn
            // 
            this.car2btn.Location = new System.Drawing.Point(295, 117);
            this.car2btn.Name = "car2btn";
            this.car2btn.Size = new System.Drawing.Size(116, 53);
            this.car2btn.TabIndex = 4;
            this.car2btn.Text = "button2";
            this.car2btn.UseVisualStyleBackColor = true;
            // 
            // car3btn
            // 
            this.car3btn.Location = new System.Drawing.Point(137, 193);
            this.car3btn.Name = "car3btn";
            this.car3btn.Size = new System.Drawing.Size(116, 53);
            this.car3btn.TabIndex = 5;
            this.car3btn.Text = "button3";
            this.car3btn.UseVisualStyleBackColor = true;
            // 
            // car4btn
            // 
            this.car4btn.Location = new System.Drawing.Point(295, 193);
            this.car4btn.Name = "car4btn";
            this.car4btn.Size = new System.Drawing.Size(116, 53);
            this.car4btn.TabIndex = 6;
            this.car4btn.Text = "button4";
            this.car4btn.UseVisualStyleBackColor = true;
            // 
            // GuessGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.car4btn);
            this.Controls.Add(this.car3btn);
            this.Controls.Add(this.car2btn);
            this.Controls.Add(this.car1btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "GuessGameForm";
            this.Text = "GuessGameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button car1btn;
        private System.Windows.Forms.Button car2btn;
        private System.Windows.Forms.Button car3btn;
        private System.Windows.Forms.Button car4btn;
    }
}