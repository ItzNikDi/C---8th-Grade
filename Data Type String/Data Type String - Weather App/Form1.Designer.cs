namespace Data_Type_String___Weather_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnShow = new System.Windows.Forms.Button();
            this.lblDay = new System.Windows.Forms.Label();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.lblAll = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShow.Location = new System.Drawing.Point(12, 99);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(366, 101);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Покажи температура";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblDay
            // 
            this.lblDay.Font = new System.Drawing.Font("Segoe UI", 13.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) | System.Drawing.FontStyle.Underline))));
            this.lblDay.Location = new System.Drawing.Point(12, 9);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(123, 29);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "Въведи ден:";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDay
            // 
            this.tbDay.Font = new System.Drawing.Font("Segoe UI", 13.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDay.Location = new System.Drawing.Point(12, 41);
            this.tbDay.Multiline = true;
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(123, 29);
            this.tbDay.TabIndex = 2;
            this.tbDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTemp
            // 
            this.lblTemp.Font = new System.Drawing.Font("Segoe UI", 13.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) | System.Drawing.FontStyle.Underline))));
            this.lblTemp.Location = new System.Drawing.Point(160, 9);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(218, 29);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "Въведи температура:";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTemp
            // 
            this.tbTemp.Font = new System.Drawing.Font("Segoe UI", 13.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTemp.Location = new System.Drawing.Point(160, 41);
            this.tbTemp.Multiline = true;
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.Size = new System.Drawing.Size(218, 29);
            this.tbTemp.TabIndex = 4;
            this.tbTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAll
            // 
            this.lblAll.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAll.Location = new System.Drawing.Point(12, 229);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(366, 29);
            this.lblAll.TabIndex = 5;
            this.lblAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAll.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] { "понеделник", "вторник", "сряда", "четвъртък", "петък", "събота", "неделя" });
            this.listBox1.Location = new System.Drawing.Point(104, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 17);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(390, 267);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblAll);
            this.Controls.Add(this.tbTemp);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.tbDay);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.btnShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.Label lblAll;

        private System.Windows.Forms.Label lblTemp;

        private System.Windows.Forms.TextBox tbDay;

        private System.Windows.Forms.Label lblDay;

        private System.Windows.Forms.Button btnShow;

        #endregion
    }
}