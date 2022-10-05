
namespace Nopan_heitto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelWinner = new System.Windows.Forms.Label();
            this.buttonPlayer1Roll = new System.Windows.Forms.Button();
            this.buttonPlayer2Roll = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Location = new System.Drawing.Point(196, 87);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(0, 15);
            this.labelPlayer1.TabIndex = 0;
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Location = new System.Drawing.Point(373, 87);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(0, 15);
            this.labelPlayer2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Player 2";
            // 
            // labelWinner
            // 
            this.labelWinner.AutoSize = true;
            this.labelWinner.Location = new System.Drawing.Point(288, 41);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(0, 15);
            this.labelWinner.TabIndex = 4;
            // 
            // buttonPlayer1Roll
            // 
            this.buttonPlayer1Roll.Location = new System.Drawing.Point(125, 173);
            this.buttonPlayer1Roll.Name = "buttonPlayer1Roll";
            this.buttonPlayer1Roll.Size = new System.Drawing.Size(119, 23);
            this.buttonPlayer1Roll.TabIndex = 5;
            this.buttonPlayer1Roll.Text = "Player 1 Roll";
            this.buttonPlayer1Roll.UseVisualStyleBackColor = true;
            this.buttonPlayer1Roll.Click += new System.EventHandler(this.buttonPlayer1Roll_Click);
            // 
            // buttonPlayer2Roll
            // 
            this.buttonPlayer2Roll.Location = new System.Drawing.Point(373, 173);
            this.buttonPlayer2Roll.Name = "buttonPlayer2Roll";
            this.buttonPlayer2Roll.Size = new System.Drawing.Size(119, 23);
            this.buttonPlayer2Roll.TabIndex = 6;
            this.buttonPlayer2Roll.Text = "Player 2 Roll";
            this.buttonPlayer2Roll.UseVisualStyleBackColor = true;
            this.buttonPlayer2Roll.Click += new System.EventHandler(this.buttonPlayer2Roll_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(268, 246);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonPlayer2Roll);
            this.Controls.Add(this.buttonPlayer1Roll);
            this.Controls.Add(this.labelWinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelWinner;
        private System.Windows.Forms.Button buttonPlayer1Roll;
        private System.Windows.Forms.Button buttonPlayer2Roll;
        private System.Windows.Forms.Button buttonReset;
    }
}

