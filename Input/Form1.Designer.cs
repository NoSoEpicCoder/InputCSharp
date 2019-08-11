using System;

namespace Input {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btFirstNumber = new System.Windows.Forms.TextBox();
            this.tbSecondNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(90, 90);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(75, 25);
            this.btnAnswer.TabIndex = 0;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // btFirstNumber
            // 
            this.btFirstNumber.Location = new System.Drawing.Point(40, 35);
            this.btFirstNumber.Name = "btFirstNumber";
            this.btFirstNumber.Size = new System.Drawing.Size(50, 20);
            this.btFirstNumber.TabIndex = 1;
            this.btFirstNumber.Text = "5656";
            this.btFirstNumber.TextChanged += new System.EventHandler(this.BtFirstNumber_TextChanged);
            // 
            // tbSecondNumber
            // 
            this.tbSecondNumber.Location = new System.Drawing.Point(165, 35);
            this.tbSecondNumber.Name = "tbSecondNumber";
            this.tbSecondNumber.Size = new System.Drawing.Size(50, 20);
            this.tbSecondNumber.TabIndex = 2;
            this.tbSecondNumber.Text = "7";
            this.tbSecondNumber.TextChanged += new System.EventHandler(this.TbSecondNumber_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSecondNumber);
            this.Controls.Add(this.btFirstNumber);
            this.Controls.Add(this.btnAnswer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TbSecondNumber_TextChanged(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        private void BtFirstNumber_TextChanged(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.TextBox btFirstNumber;
        private System.Windows.Forms.TextBox tbSecondNumber;
    }
}

