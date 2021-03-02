namespace MLDRApplication
{
    partial class Form_MLDR_Application
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAppendCustomer = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "צור  הזמנה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(283, 72);
            this.button2.TabIndex = 2;
            this.button2.Text = "חפש  הזמנה";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(852, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 219);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "לשונית  הזמנה";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAppendCustomer);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(376, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 218);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "לשונית  לקוח";
            // 
            // buttonAppendCustomer
            // 
            this.buttonAppendCustomer.Location = new System.Drawing.Point(19, 31);
            this.buttonAppendCustomer.Name = "buttonAppendCustomer";
            this.buttonAppendCustomer.Size = new System.Drawing.Size(283, 68);
            this.buttonAppendCustomer.TabIndex = 1;
            this.buttonAppendCustomer.Text = "הוסף  לקוח";
            this.buttonAppendCustomer.UseVisualStyleBackColor = true;
            this.buttonAppendCustomer.Click += new System.EventHandler(this.buttonAppendCustomer_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(283, 72);
            this.button4.TabIndex = 2;
            this.button4.Text = "חפש לקוח";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(495, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(283, 72);
            this.button5.TabIndex = 3;
            this.button5.Text = "דוח סוף חודש";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(19, 61);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(283, 70);
            this.button6.TabIndex = 7;
            this.button6.Text = "יציאה";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(495, 61);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(283, 70);
            this.button7.TabIndex = 8;
            this.button7.Text = "הפעל  מחדש";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(13, 13);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Location = new System.Drawing.Point(376, 462);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(794, 224);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "לשונית  הנהלה";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(19, 132);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(283, 72);
            this.button10.TabIndex = 6;
            this.button10.Text = "ערוך  מחירים";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(19, 42);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(283, 72);
            this.button9.TabIndex = 5;
            this.button9.Text = "ערוך  לקוח/ות";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(495, 132);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(283, 72);
            this.button8.TabIndex = 4;
            this.button8.Text = "הדפס  הזמנות לחודש הנוכחי";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Location = new System.Drawing.Point(376, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(794, 166);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "לשונית  בקרה";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // Form_MLDR_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 698);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_MLDR_Application";
            this.Text = "MLDR Application Main Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAppendCustomer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

