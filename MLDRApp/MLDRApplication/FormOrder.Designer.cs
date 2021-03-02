namespace MLDRApplication
{
    partial class FormOrder
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
            this.label_OrderForm_Title = new System.Windows.Forms.Label();
            this.labelOrderSN = new System.Windows.Forms.Label();
            this.label_chooseCustomer = new System.Windows.Forms.Label();
            this.comboBoxOrderingCustomer = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCalcWholeOrder = new System.Windows.Forms.Button();
            this.comboBoxTypeRowSeven = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxOpRowSeven = new System.Windows.Forms.ComboBox();
            this.textBoxQuantRowSeven = new System.Windows.Forms.TextBox();
            this.comboBoxTypeRowSix = new System.Windows.Forms.ComboBox();
            this.comboBoxOpRowSix = new System.Windows.Forms.ComboBox();
            this.textBoxQuantRowSix = new System.Windows.Forms.TextBox();
            this.comboBoxTypeRowFive = new System.Windows.Forms.ComboBox();
            this.comboBoxOpRowFive = new System.Windows.Forms.ComboBox();
            this.textBoxQuantRowFive = new System.Windows.Forms.TextBox();
            this.comboBoxTypeRowFour = new System.Windows.Forms.ComboBox();
            this.comboBoxOpRowFour = new System.Windows.Forms.ComboBox();
            this.textBoxQuantRowFour = new System.Windows.Forms.TextBox();
            this.comboBoxTypeRowThree = new System.Windows.Forms.ComboBox();
            this.comboBoxOpRowThree = new System.Windows.Forms.ComboBox();
            this.textBoxQuantRowThree = new System.Windows.Forms.TextBox();
            this.comboBoxTypeRowTwo = new System.Windows.Forms.ComboBox();
            this.comboBoxOpRowTwo = new System.Windows.Forms.ComboBox();
            this.textBoxQuantRowTwo = new System.Windows.Forms.TextBox();
            this.comboBoxTypeRowOne = new System.Windows.Forms.ComboBox();
            this.comboBoxOpRowOne = new System.Windows.Forms.ComboBox();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonPrintOrder = new System.Windows.Forms.Button();
            this.buttonSaveOrder = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxQuantRowOne = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotCostRowOne = new System.Windows.Forms.Label();
            this.labelTotCostRowTwo = new System.Windows.Forms.Label();
            this.labelTotCostRowFour = new System.Windows.Forms.Label();
            this.labelTotCostRowThree = new System.Windows.Forms.Label();
            this.labelTotCostRowFive = new System.Windows.Forms.Label();
            this.labelTotCostRowSix = new System.Windows.Forms.Label();
            this.labelTotCostRowSeven = new System.Windows.Forms.Label();
            this.labelTotOrderWithOutVat = new System.Windows.Forms.Label();
            this.labelVatPercent = new System.Windows.Forms.Label();
            this.labelTotOrderWithVat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_OrderForm_Title
            // 
            this.label_OrderForm_Title.AutoSize = true;
            this.label_OrderForm_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OrderForm_Title.Location = new System.Drawing.Point(544, 9);
            this.label_OrderForm_Title.Name = "label_OrderForm_Title";
            this.label_OrderForm_Title.Size = new System.Drawing.Size(108, 25);
            this.label_OrderForm_Title.TabIndex = 0;
            this.label_OrderForm_Title.Text = "הזמנה  מספר";
            this.label_OrderForm_Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelOrderSN
            // 
            this.labelOrderSN.AutoSize = true;
            this.labelOrderSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderSN.Location = new System.Drawing.Point(483, 9);
            this.labelOrderSN.Name = "labelOrderSN";
            this.labelOrderSN.Size = new System.Drawing.Size(56, 25);
            this.labelOrderSN.TabIndex = 1;
            this.labelOrderSN.Text = "0000";
            this.labelOrderSN.Click += new System.EventHandler(this.label_FormOrder_OrderNumberOut_Click);
            // 
            // label_chooseCustomer
            // 
            this.label_chooseCustomer.AutoSize = true;
            this.label_chooseCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chooseCustomer.Location = new System.Drawing.Point(745, 72);
            this.label_chooseCustomer.Name = "label_chooseCustomer";
            this.label_chooseCustomer.Size = new System.Drawing.Size(81, 20);
            this.label_chooseCustomer.TabIndex = 2;
            this.label_chooseCustomer.Text = "בחר  לקוח";
            // 
            // comboBoxOrderingCustomer
            // 
            this.comboBoxOrderingCustomer.FormattingEnabled = true;
            this.comboBoxOrderingCustomer.Location = new System.Drawing.Point(488, 72);
            this.comboBoxOrderingCustomer.Name = "comboBoxOrderingCustomer";
            this.comboBoxOrderingCustomer.Size = new System.Drawing.Size(236, 24);
            this.comboBoxOrderingCustomer.TabIndex = 3;
            this.comboBoxOrderingCustomer.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTotOrderWithVat);
            this.groupBox1.Controls.Add(this.labelVatPercent);
            this.groupBox1.Controls.Add(this.labelTotOrderWithOutVat);
            this.groupBox1.Controls.Add(this.labelTotCostRowSeven);
            this.groupBox1.Controls.Add(this.labelTotCostRowSix);
            this.groupBox1.Controls.Add(this.labelTotCostRowFive);
            this.groupBox1.Controls.Add(this.labelTotCostRowFour);
            this.groupBox1.Controls.Add(this.labelTotCostRowThree);
            this.groupBox1.Controls.Add(this.labelTotCostRowTwo);
            this.groupBox1.Controls.Add(this.labelTotCostRowOne);
            this.groupBox1.Controls.Add(this.buttonCalcWholeOrder);
            this.groupBox1.Controls.Add(this.comboBoxTypeRowSeven);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxOpRowSeven);
            this.groupBox1.Controls.Add(this.textBoxQuantRowSeven);
            this.groupBox1.Controls.Add(this.comboBoxTypeRowSix);
            this.groupBox1.Controls.Add(this.comboBoxOpRowSix);
            this.groupBox1.Controls.Add(this.textBoxQuantRowSix);
            this.groupBox1.Controls.Add(this.comboBoxTypeRowFive);
            this.groupBox1.Controls.Add(this.comboBoxOpRowFive);
            this.groupBox1.Controls.Add(this.textBoxQuantRowFive);
            this.groupBox1.Controls.Add(this.comboBoxTypeRowFour);
            this.groupBox1.Controls.Add(this.comboBoxOpRowFour);
            this.groupBox1.Controls.Add(this.textBoxQuantRowFour);
            this.groupBox1.Controls.Add(this.comboBoxTypeRowThree);
            this.groupBox1.Controls.Add(this.comboBoxOpRowThree);
            this.groupBox1.Controls.Add(this.textBoxQuantRowThree);
            this.groupBox1.Controls.Add(this.comboBoxTypeRowTwo);
            this.groupBox1.Controls.Add(this.comboBoxOpRowTwo);
            this.groupBox1.Controls.Add(this.textBoxQuantRowTwo);
            this.groupBox1.Controls.Add(this.comboBoxTypeRowOne);
            this.groupBox1.Controls.Add(this.comboBoxOpRowOne);
            this.groupBox1.Controls.Add(this.buttonGoBack);
            this.groupBox1.Controls.Add(this.buttonPrintOrder);
            this.groupBox1.Controls.Add(this.buttonSaveOrder);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxQuantRowOne);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(95, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 581);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "פרטי  הזמנה";
            // 
            // buttonCalcWholeOrder
            // 
            this.buttonCalcWholeOrder.Location = new System.Drawing.Point(824, 427);
            this.buttonCalcWholeOrder.Name = "buttonCalcWholeOrder";
            this.buttonCalcWholeOrder.Size = new System.Drawing.Size(138, 51);
            this.buttonCalcWholeOrder.TabIndex = 60;
            this.buttonCalcWholeOrder.Text = "חשב  הזמנה";
            this.buttonCalcWholeOrder.UseVisualStyleBackColor = true;
            this.buttonCalcWholeOrder.Click += new System.EventHandler(this.button_CalcOrder_Click);
            // 
            // comboBoxTypeRowSeven
            // 
            this.comboBoxTypeRowSeven.FormattingEnabled = true;
            this.comboBoxTypeRowSeven.Location = new System.Drawing.Point(597, 300);
            this.comboBoxTypeRowSeven.Name = "comboBoxTypeRowSeven";
            this.comboBoxTypeRowSeven.Size = new System.Drawing.Size(201, 24);
            this.comboBoxTypeRowSeven.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(308, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "סכום  בש\'\'ח";
            // 
            // comboBoxOpRowSeven
            // 
            this.comboBoxOpRowSeven.FormattingEnabled = true;
            this.comboBoxOpRowSeven.Location = new System.Drawing.Point(390, 300);
            this.comboBoxOpRowSeven.Name = "comboBoxOpRowSeven";
            this.comboBoxOpRowSeven.Size = new System.Drawing.Size(201, 24);
            this.comboBoxOpRowSeven.TabIndex = 54;
            // 
            // textBoxQuantRowSeven
            // 
            this.textBoxQuantRowSeven.Location = new System.Drawing.Point(804, 300);
            this.textBoxQuantRowSeven.Name = "textBoxQuantRowSeven";
            this.textBoxQuantRowSeven.Size = new System.Drawing.Size(156, 22);
            this.textBoxQuantRowSeven.TabIndex = 53;
            this.textBoxQuantRowSeven.Text = "0";
            // 
            // comboBoxTypeRowSix
            // 
            this.comboBoxTypeRowSix.FormattingEnabled = true;
            this.comboBoxTypeRowSix.Location = new System.Drawing.Point(597, 260);
            this.comboBoxTypeRowSix.Name = "comboBoxTypeRowSix";
            this.comboBoxTypeRowSix.Size = new System.Drawing.Size(201, 24);
            this.comboBoxTypeRowSix.TabIndex = 51;
            // 
            // comboBoxOpRowSix
            // 
            this.comboBoxOpRowSix.FormattingEnabled = true;
            this.comboBoxOpRowSix.Location = new System.Drawing.Point(390, 260);
            this.comboBoxOpRowSix.Name = "comboBoxOpRowSix";
            this.comboBoxOpRowSix.Size = new System.Drawing.Size(201, 24);
            this.comboBoxOpRowSix.TabIndex = 50;
            // 
            // textBoxQuantRowSix
            // 
            this.textBoxQuantRowSix.Location = new System.Drawing.Point(804, 260);
            this.textBoxQuantRowSix.Name = "textBoxQuantRowSix";
            this.textBoxQuantRowSix.Size = new System.Drawing.Size(156, 22);
            this.textBoxQuantRowSix.TabIndex = 49;
            this.textBoxQuantRowSix.Text = "0";
            // 
            // comboBoxTypeRowFive
            // 
            this.comboBoxTypeRowFive.FormattingEnabled = true;
            this.comboBoxTypeRowFive.Location = new System.Drawing.Point(597, 219);
            this.comboBoxTypeRowFive.Name = "comboBoxTypeRowFive";
            this.comboBoxTypeRowFive.Size = new System.Drawing.Size(201, 24);
            this.comboBoxTypeRowFive.TabIndex = 47;
            // 
            // comboBoxOpRowFive
            // 
            this.comboBoxOpRowFive.FormattingEnabled = true;
            this.comboBoxOpRowFive.Location = new System.Drawing.Point(390, 219);
            this.comboBoxOpRowFive.Name = "comboBoxOpRowFive";
            this.comboBoxOpRowFive.Size = new System.Drawing.Size(201, 24);
            this.comboBoxOpRowFive.TabIndex = 46;
            // 
            // textBoxQuantRowFive
            // 
            this.textBoxQuantRowFive.Location = new System.Drawing.Point(804, 219);
            this.textBoxQuantRowFive.Name = "textBoxQuantRowFive";
            this.textBoxQuantRowFive.Size = new System.Drawing.Size(156, 22);
            this.textBoxQuantRowFive.TabIndex = 45;
            this.textBoxQuantRowFive.Text = "0";
            // 
            // comboBoxTypeRowFour
            // 
            this.comboBoxTypeRowFour.FormattingEnabled = true;
            this.comboBoxTypeRowFour.Location = new System.Drawing.Point(597, 177);
            this.comboBoxTypeRowFour.Name = "comboBoxTypeRowFour";
            this.comboBoxTypeRowFour.Size = new System.Drawing.Size(201, 24);
            this.comboBoxTypeRowFour.TabIndex = 43;
            // 
            // comboBoxOpRowFour
            // 
            this.comboBoxOpRowFour.FormattingEnabled = true;
            this.comboBoxOpRowFour.Location = new System.Drawing.Point(390, 177);
            this.comboBoxOpRowFour.Name = "comboBoxOpRowFour";
            this.comboBoxOpRowFour.Size = new System.Drawing.Size(201, 24);
            this.comboBoxOpRowFour.TabIndex = 42;
            // 
            // textBoxQuantRowFour
            // 
            this.textBoxQuantRowFour.Location = new System.Drawing.Point(804, 177);
            this.textBoxQuantRowFour.Name = "textBoxQuantRowFour";
            this.textBoxQuantRowFour.Size = new System.Drawing.Size(156, 22);
            this.textBoxQuantRowFour.TabIndex = 41;
            this.textBoxQuantRowFour.Text = "0";
            // 
            // comboBoxTypeRowThree
            // 
            this.comboBoxTypeRowThree.FormattingEnabled = true;
            this.comboBoxTypeRowThree.Location = new System.Drawing.Point(597, 136);
            this.comboBoxTypeRowThree.Name = "comboBoxTypeRowThree";
            this.comboBoxTypeRowThree.Size = new System.Drawing.Size(201, 24);
            this.comboBoxTypeRowThree.TabIndex = 39;
            // 
            // comboBoxOpRowThree
            // 
            this.comboBoxOpRowThree.FormattingEnabled = true;
            this.comboBoxOpRowThree.Location = new System.Drawing.Point(390, 136);
            this.comboBoxOpRowThree.Name = "comboBoxOpRowThree";
            this.comboBoxOpRowThree.Size = new System.Drawing.Size(201, 24);
            this.comboBoxOpRowThree.TabIndex = 38;
            // 
            // textBoxQuantRowThree
            // 
            this.textBoxQuantRowThree.Location = new System.Drawing.Point(804, 136);
            this.textBoxQuantRowThree.Name = "textBoxQuantRowThree";
            this.textBoxQuantRowThree.Size = new System.Drawing.Size(156, 22);
            this.textBoxQuantRowThree.TabIndex = 37;
            this.textBoxQuantRowThree.Text = "0";
            // 
            // comboBoxTypeRowTwo
            // 
            this.comboBoxTypeRowTwo.FormattingEnabled = true;
            this.comboBoxTypeRowTwo.Location = new System.Drawing.Point(597, 95);
            this.comboBoxTypeRowTwo.Name = "comboBoxTypeRowTwo";
            this.comboBoxTypeRowTwo.Size = new System.Drawing.Size(201, 24);
            this.comboBoxTypeRowTwo.TabIndex = 35;
            // 
            // comboBoxOpRowTwo
            // 
            this.comboBoxOpRowTwo.FormattingEnabled = true;
            this.comboBoxOpRowTwo.Location = new System.Drawing.Point(390, 95);
            this.comboBoxOpRowTwo.Name = "comboBoxOpRowTwo";
            this.comboBoxOpRowTwo.Size = new System.Drawing.Size(201, 24);
            this.comboBoxOpRowTwo.TabIndex = 34;
            // 
            // textBoxQuantRowTwo
            // 
            this.textBoxQuantRowTwo.Location = new System.Drawing.Point(804, 95);
            this.textBoxQuantRowTwo.Name = "textBoxQuantRowTwo";
            this.textBoxQuantRowTwo.Size = new System.Drawing.Size(156, 22);
            this.textBoxQuantRowTwo.TabIndex = 33;
            this.textBoxQuantRowTwo.Text = "0";
            this.textBoxQuantRowTwo.TextChanged += new System.EventHandler(this.textBox_quantityRow_2_TextChanged);
            // 
            // comboBoxTypeRowOne
            // 
            this.comboBoxTypeRowOne.FormattingEnabled = true;
            this.comboBoxTypeRowOne.Location = new System.Drawing.Point(597, 54);
            this.comboBoxTypeRowOne.Name = "comboBoxTypeRowOne";
            this.comboBoxTypeRowOne.Size = new System.Drawing.Size(201, 24);
            this.comboBoxTypeRowOne.TabIndex = 27;
            this.comboBoxTypeRowOne.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBoxOpRowOne
            // 
            this.comboBoxOpRowOne.FormattingEnabled = true;
            this.comboBoxOpRowOne.Location = new System.Drawing.Point(390, 54);
            this.comboBoxOpRowOne.Name = "comboBoxOpRowOne";
            this.comboBoxOpRowOne.Size = new System.Drawing.Size(201, 24);
            this.comboBoxOpRowOne.TabIndex = 26;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(545, 528);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(143, 47);
            this.buttonGoBack.TabIndex = 12;
            this.buttonGoBack.Text = "חזור";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonPrintOrder
            // 
            this.buttonPrintOrder.Location = new System.Drawing.Point(694, 528);
            this.buttonPrintOrder.Name = "buttonPrintOrder";
            this.buttonPrintOrder.Size = new System.Drawing.Size(124, 47);
            this.buttonPrintOrder.TabIndex = 11;
            this.buttonPrintOrder.Text = "הדפס";
            this.buttonPrintOrder.UseVisualStyleBackColor = true;
            // 
            // buttonSaveOrder
            // 
            this.buttonSaveOrder.Location = new System.Drawing.Point(824, 528);
            this.buttonSaveOrder.Name = "buttonSaveOrder";
            this.buttonSaveOrder.Size = new System.Drawing.Size(136, 47);
            this.buttonSaveOrder.TabIndex = 10;
            this.buttonSaveOrder.Text = "שמור";
            this.buttonSaveOrder.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(390, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "סה\"כ כולל מע\"מ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(390, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "שיעור מע\"מ באחוזים";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(540, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "פעולה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "נטו ללא מע\"מ";
            // 
            // textBoxQuantRowOne
            // 
            this.textBoxQuantRowOne.Location = new System.Drawing.Point(804, 54);
            this.textBoxQuantRowOne.Name = "textBoxQuantRowOne";
            this.textBoxQuantRowOne.Size = new System.Drawing.Size(156, 22);
            this.textBoxQuantRowOne.TabIndex = 25;
            this.textBoxQuantRowOne.Text = "0";
            this.textBoxQuantRowOne.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(746, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "פרטים";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(916, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "כמות";
            // 
            // labelTotCostRowOne
            // 
            this.labelTotCostRowOne.AutoSize = true;
            this.labelTotCostRowOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotCostRowOne.Location = new System.Drawing.Point(328, 54);
            this.labelTotCostRowOne.Name = "labelTotCostRowOne";
            this.labelTotCostRowOne.Size = new System.Drawing.Size(56, 25);
            this.labelTotCostRowOne.TabIndex = 61;
            this.labelTotCostRowOne.Text = "0000";
            this.labelTotCostRowOne.Click += new System.EventHandler(this.labelRow1TotakCost_Click);
            // 
            // labelTotCostRowTwo
            // 
            this.labelTotCostRowTwo.AutoSize = true;
            this.labelTotCostRowTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotCostRowTwo.Location = new System.Drawing.Point(328, 95);
            this.labelTotCostRowTwo.Name = "labelTotCostRowTwo";
            this.labelTotCostRowTwo.Size = new System.Drawing.Size(56, 25);
            this.labelTotCostRowTwo.TabIndex = 62;
            this.labelTotCostRowTwo.Text = "0000";
            // 
            // labelTotCostRowFour
            // 
            this.labelTotCostRowFour.AutoSize = true;
            this.labelTotCostRowFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotCostRowFour.Location = new System.Drawing.Point(328, 176);
            this.labelTotCostRowFour.Name = "labelTotCostRowFour";
            this.labelTotCostRowFour.Size = new System.Drawing.Size(56, 25);
            this.labelTotCostRowFour.TabIndex = 64;
            this.labelTotCostRowFour.Text = "0000";
            // 
            // labelTotCostRowThree
            // 
            this.labelTotCostRowThree.AutoSize = true;
            this.labelTotCostRowThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotCostRowThree.Location = new System.Drawing.Point(328, 136);
            this.labelTotCostRowThree.Name = "labelTotCostRowThree";
            this.labelTotCostRowThree.Size = new System.Drawing.Size(56, 25);
            this.labelTotCostRowThree.TabIndex = 63;
            this.labelTotCostRowThree.Text = "0000";
            // 
            // labelTotCostRowFive
            // 
            this.labelTotCostRowFive.AutoSize = true;
            this.labelTotCostRowFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotCostRowFive.Location = new System.Drawing.Point(328, 218);
            this.labelTotCostRowFive.Name = "labelTotCostRowFive";
            this.labelTotCostRowFive.Size = new System.Drawing.Size(56, 25);
            this.labelTotCostRowFive.TabIndex = 65;
            this.labelTotCostRowFive.Text = "0000";
            // 
            // labelTotCostRowSix
            // 
            this.labelTotCostRowSix.AutoSize = true;
            this.labelTotCostRowSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotCostRowSix.Location = new System.Drawing.Point(328, 260);
            this.labelTotCostRowSix.Name = "labelTotCostRowSix";
            this.labelTotCostRowSix.Size = new System.Drawing.Size(56, 25);
            this.labelTotCostRowSix.TabIndex = 66;
            this.labelTotCostRowSix.Text = "0000";
            // 
            // labelTotCostRowSeven
            // 
            this.labelTotCostRowSeven.AutoSize = true;
            this.labelTotCostRowSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotCostRowSeven.Location = new System.Drawing.Point(328, 296);
            this.labelTotCostRowSeven.Name = "labelTotCostRowSeven";
            this.labelTotCostRowSeven.Size = new System.Drawing.Size(56, 25);
            this.labelTotCostRowSeven.TabIndex = 67;
            this.labelTotCostRowSeven.Text = "0000";
            // 
            // labelTotOrderWithOutVat
            // 
            this.labelTotOrderWithOutVat.AutoSize = true;
            this.labelTotOrderWithOutVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotOrderWithOutVat.Location = new System.Drawing.Point(307, 367);
            this.labelTotOrderWithOutVat.Name = "labelTotOrderWithOutVat";
            this.labelTotOrderWithOutVat.Size = new System.Drawing.Size(56, 25);
            this.labelTotOrderWithOutVat.TabIndex = 68;
            this.labelTotOrderWithOutVat.Text = "0000";
            // 
            // labelVatPercent
            // 
            this.labelVatPercent.AutoSize = true;
            this.labelVatPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVatPercent.Location = new System.Drawing.Point(307, 414);
            this.labelVatPercent.Name = "labelVatPercent";
            this.labelVatPercent.Size = new System.Drawing.Size(56, 25);
            this.labelVatPercent.TabIndex = 69;
            this.labelVatPercent.Text = "0000";
            // 
            // labelTotOrderWithVat
            // 
            this.labelTotOrderWithVat.AutoSize = true;
            this.labelTotOrderWithVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotOrderWithVat.Location = new System.Drawing.Point(307, 457);
            this.labelTotOrderWithVat.Name = "labelTotOrderWithVat";
            this.labelTotOrderWithVat.Size = new System.Drawing.Size(56, 25);
            this.labelTotOrderWithVat.TabIndex = 70;
            this.labelTotOrderWithVat.Text = "0000";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 735);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxOrderingCustomer);
            this.Controls.Add(this.label_chooseCustomer);
            this.Controls.Add(this.labelOrderSN);
            this.Controls.Add(this.label_OrderForm_Title);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_OrderForm_Title;
        private System.Windows.Forms.Label labelOrderSN;
        private System.Windows.Forms.Label label_chooseCustomer;
        private System.Windows.Forms.ComboBox comboBoxOrderingCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonPrintOrder;
        private System.Windows.Forms.Button buttonSaveOrder;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.TextBox textBoxQuantRowOne;
        private System.Windows.Forms.ComboBox comboBoxTypeRowOne;
        private System.Windows.Forms.ComboBox comboBoxOpRowOne;
        private System.Windows.Forms.ComboBox comboBoxTypeRowSeven;
        private System.Windows.Forms.ComboBox comboBoxOpRowSeven;
        private System.Windows.Forms.TextBox textBoxQuantRowSeven;
        private System.Windows.Forms.ComboBox comboBoxTypeRowSix;
        private System.Windows.Forms.ComboBox comboBoxOpRowSix;
        private System.Windows.Forms.TextBox textBoxQuantRowSix;
        private System.Windows.Forms.ComboBox comboBoxTypeRowFive;
        private System.Windows.Forms.ComboBox comboBoxOpRowFive;
        private System.Windows.Forms.TextBox textBoxQuantRowFive;
        private System.Windows.Forms.ComboBox comboBoxTypeRowFour;
        private System.Windows.Forms.ComboBox comboBoxOpRowFour;
        private System.Windows.Forms.TextBox textBoxQuantRowFour;
        private System.Windows.Forms.ComboBox comboBoxTypeRowThree;
        private System.Windows.Forms.ComboBox comboBoxOpRowThree;
        private System.Windows.Forms.TextBox textBoxQuantRowThree;
        private System.Windows.Forms.ComboBox comboBoxTypeRowTwo;
        private System.Windows.Forms.ComboBox comboBoxOpRowTwo;
        private System.Windows.Forms.TextBox textBoxQuantRowTwo;
        private System.Windows.Forms.Button buttonCalcWholeOrder;
        private System.Windows.Forms.Label labelTotCostRowOne;
        private System.Windows.Forms.Label labelTotOrderWithVat;
        private System.Windows.Forms.Label labelVatPercent;
        private System.Windows.Forms.Label labelTotOrderWithOutVat;
        private System.Windows.Forms.Label labelTotCostRowSeven;
        private System.Windows.Forms.Label labelTotCostRowSix;
        private System.Windows.Forms.Label labelTotCostRowFive;
        private System.Windows.Forms.Label labelTotCostRowFour;
        private System.Windows.Forms.Label labelTotCostRowThree;
        private System.Windows.Forms.Label labelTotCostRowTwo;
    }
}