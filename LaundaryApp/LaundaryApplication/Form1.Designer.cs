namespace LaundaryApplication
{
    partial class LaundaryApp
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
            this.button_exit = new System.Windows.Forms.Button();
            this.comboBox_customersSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_LoadCustomers = new System.Windows.Forms.Button();
            this.button_GetDetails = new System.Windows.Forms.Button();
            this.button_buildNewOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_exit.Location = new System.Drawing.Point(13, 189);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(115, 37);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // comboBox_customersSelector
            // 
            this.comboBox_customersSelector.AccessibleDescription = "bobo";
            this.comboBox_customersSelector.AccessibleName = "Pick_customer";
            this.comboBox_customersSelector.FormattingEnabled = true;
            this.comboBox_customersSelector.Items.AddRange(new object[] {
            "Avi halevi",
            "Nono monez",
            "kala stemala",
            "jose luis",
            "konstantien vorans"});
            this.comboBox_customersSelector.Location = new System.Drawing.Point(264, 29);
            this.comboBox_customersSelector.Name = "comboBox_customersSelector";
            this.comboBox_customersSelector.Size = new System.Drawing.Size(212, 24);
            this.comboBox_customersSelector.TabIndex = 3;
            this.comboBox_customersSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customers List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_LoadCustomers
            // 
            this.button_LoadCustomers.Location = new System.Drawing.Point(264, 70);
            this.button_LoadCustomers.Name = "button_LoadCustomers";
            this.button_LoadCustomers.Size = new System.Drawing.Size(211, 35);
            this.button_LoadCustomers.TabIndex = 5;
            this.button_LoadCustomers.Text = "Load Customers";
            this.button_LoadCustomers.UseVisualStyleBackColor = true;
            this.button_LoadCustomers.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_GetDetails
            // 
            this.button_GetDetails.Location = new System.Drawing.Point(175, 189);
            this.button_GetDetails.Name = "button_GetDetails";
            this.button_GetDetails.Size = new System.Drawing.Size(154, 37);
            this.button_GetDetails.TabIndex = 6;
            this.button_GetDetails.Text = "Get Details";
            this.button_GetDetails.UseVisualStyleBackColor = true;
            this.button_GetDetails.Click += new System.EventHandler(this.button_GetDetails_Click);
            // 
            // button_buildNewOrder
            // 
            this.button_buildNewOrder.Location = new System.Drawing.Point(378, 189);
            this.button_buildNewOrder.Name = "button_buildNewOrder";
            this.button_buildNewOrder.Size = new System.Drawing.Size(133, 37);
            this.button_buildNewOrder.TabIndex = 7;
            this.button_buildNewOrder.Text = "צור  הזמנה";
            this.button_buildNewOrder.UseVisualStyleBackColor = true;
            this.button_buildNewOrder.Click += new System.EventHandler(this.button_buildNewOrder_Click);
            // 
            // LaundaryApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(564, 238);
            this.Controls.Add(this.button_buildNewOrder);
            this.Controls.Add(this.button_GetDetails);
            this.Controls.Add(this.button_LoadCustomers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_customersSelector);
            this.Controls.Add(this.button_exit);
            this.Name = "LaundaryApp";
            this.Text = "LaundaryApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.ComboBox comboBox_customersSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_LoadCustomers;
        private System.Windows.Forms.Button button_GetDetails;
        private System.Windows.Forms.Button button_buildNewOrder;
        //private System.Windows.Forms.Button button_generateOrder;
    }
}

