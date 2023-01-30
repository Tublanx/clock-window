namespace ClockProgram
{
    partial class PlusClock
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
            this.btnPressHourUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPressMinUp = new System.Windows.Forms.Button();
            this.btnPressSecUp = new System.Windows.Forms.Button();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.btnPressSecDown = new System.Windows.Forms.Button();
            this.btnPressMinDown = new System.Windows.Forms.Button();
            this.btnPressHourDown = new System.Windows.Forms.Button();
            this.tbxTtle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPressSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPressHourUp
            // 
            this.btnPressHourUp.Location = new System.Drawing.Point(31, 71);
            this.btnPressHourUp.Name = "btnPressHourUp";
            this.btnPressHourUp.Size = new System.Drawing.Size(75, 23);
            this.btnPressHourUp.TabIndex = 0;
            this.btnPressHourUp.Text = "△";
            this.btnPressHourUp.UseVisualStyleBackColor = true;
            this.btnPressHourUp.Click += new System.EventHandler(this.btnPressHourUp_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "새 타이머 추가";
            // 
            // btnPressMinUp
            // 
            this.btnPressMinUp.Location = new System.Drawing.Point(133, 71);
            this.btnPressMinUp.Name = "btnPressMinUp";
            this.btnPressMinUp.Size = new System.Drawing.Size(75, 23);
            this.btnPressMinUp.TabIndex = 0;
            this.btnPressMinUp.Text = "△";
            this.btnPressMinUp.UseVisualStyleBackColor = true;
            this.btnPressMinUp.Click += new System.EventHandler(this.btnPressMinUp_Click);
            // 
            // btnPressSecUp
            // 
            this.btnPressSecUp.Location = new System.Drawing.Point(234, 71);
            this.btnPressSecUp.Name = "btnPressSecUp";
            this.btnPressSecUp.Size = new System.Drawing.Size(75, 23);
            this.btnPressSecUp.TabIndex = 0;
            this.btnPressSecUp.Text = "△";
            this.btnPressSecUp.UseVisualStyleBackColor = true;
            this.btnPressSecUp.Click += new System.EventHandler(this.btnPressSecUp_Click);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHour.Location = new System.Drawing.Point(39, 97);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(58, 45);
            this.lblHour.TabIndex = 2;
            this.lblHour.Text = "00";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMin.Location = new System.Drawing.Point(141, 97);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(58, 45);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "00";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSec.Location = new System.Drawing.Point(242, 97);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(58, 45);
            this.lblSec.TabIndex = 2;
            this.lblSec.Text = "00";
            // 
            // btnPressSecDown
            // 
            this.btnPressSecDown.Location = new System.Drawing.Point(234, 145);
            this.btnPressSecDown.Name = "btnPressSecDown";
            this.btnPressSecDown.Size = new System.Drawing.Size(75, 23);
            this.btnPressSecDown.TabIndex = 3;
            this.btnPressSecDown.Text = "▽";
            this.btnPressSecDown.UseVisualStyleBackColor = true;
            this.btnPressSecDown.Click += new System.EventHandler(this.btnPressSecDown_Click);
            // 
            // btnPressMinDown
            // 
            this.btnPressMinDown.Location = new System.Drawing.Point(133, 145);
            this.btnPressMinDown.Name = "btnPressMinDown";
            this.btnPressMinDown.Size = new System.Drawing.Size(75, 23);
            this.btnPressMinDown.TabIndex = 4;
            this.btnPressMinDown.Text = "▽";
            this.btnPressMinDown.UseVisualStyleBackColor = true;
            this.btnPressMinDown.Click += new System.EventHandler(this.btnPressMinDown_Click);
            // 
            // btnPressHourDown
            // 
            this.btnPressHourDown.Location = new System.Drawing.Point(31, 145);
            this.btnPressHourDown.Name = "btnPressHourDown";
            this.btnPressHourDown.Size = new System.Drawing.Size(75, 23);
            this.btnPressHourDown.TabIndex = 5;
            this.btnPressHourDown.Text = "▽";
            this.btnPressHourDown.UseVisualStyleBackColor = true;
            this.btnPressHourDown.Click += new System.EventHandler(this.btnPressHourDown_Click);
            // 
            // tbxTtle
            // 
            this.tbxTtle.Location = new System.Drawing.Point(31, 205);
            this.tbxTtle.Name = "tbxTtle";
            this.tbxTtle.Size = new System.Drawing.Size(278, 21);
            this.tbxTtle.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(107, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 45);
            this.label5.TabIndex = 7;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(208, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 45);
            this.label6.TabIndex = 7;
            this.label6.Text = ":";
            // 
            // btnPressSave
            // 
            this.btnPressSave.Location = new System.Drawing.Point(31, 268);
            this.btnPressSave.Name = "btnPressSave";
            this.btnPressSave.Size = new System.Drawing.Size(129, 35);
            this.btnPressSave.TabIndex = 8;
            this.btnPressSave.Text = "저장";
            this.btnPressSave.UseVisualStyleBackColor = true;
            this.btnPressSave.Click += new System.EventHandler(this.btnPressSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(180, 268);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 35);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "취소";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PlusClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 325);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPressSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxTtle);
            this.Controls.Add(this.btnPressSecDown);
            this.Controls.Add(this.btnPressMinDown);
            this.Controls.Add(this.btnPressHourDown);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPressSecUp);
            this.Controls.Add(this.btnPressMinUp);
            this.Controls.Add(this.btnPressHourUp);
            this.Name = "PlusClock";
            this.Text = "PlusClock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPressHourUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPressMinUp;
        private System.Windows.Forms.Button btnPressSecUp;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Button btnPressSecDown;
        private System.Windows.Forms.Button btnPressMinDown;
        private System.Windows.Forms.Button btnPressHourDown;
        private System.Windows.Forms.TextBox tbxTtle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPressSave;
        private System.Windows.Forms.Button btnClose;
    }
}