namespace MukemmelSayi
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lboxPerfect = new System.Windows.Forms.ListBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Number:";
            // 
            // tboxNum
            // 
            this.tboxNum.Location = new System.Drawing.Point(167, 91);
            this.tboxNum.Name = "tboxNum";
            this.tboxNum.Size = new System.Drawing.Size(100, 20);
            this.tboxNum.TabIndex = 1;
            this.tboxNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxNum_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Perfect Number";
            // 
            // lboxPerfect
            // 
            this.lboxPerfect.FormattingEnabled = true;
            this.lboxPerfect.Location = new System.Drawing.Point(70, 163);
            this.lboxPerfect.Name = "lboxPerfect";
            this.lboxPerfect.Size = new System.Drawing.Size(168, 56);
            this.lboxPerfect.TabIndex = 3;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFind.Location = new System.Drawing.Point(216, 117);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(51, 26);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 231);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lboxPerfect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboxPerfect;
        private System.Windows.Forms.Button btnFind;
    }
}

