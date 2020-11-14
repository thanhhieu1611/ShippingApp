namespace ShippingProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.companySelectBox = new System.Windows.Forms.ComboBox();
            this.twoDayBtn = new System.Windows.Forms.RadioButton();
            this.overnightBtn = new System.Windows.Forms.RadioButton();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstBoxOrder = new System.Windows.Forms.ListBox();
            this.grBoxShipMethod = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.finishBtn = new System.Windows.Forms.Button();
            this.lstBoxOrderSummary = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.printLabelBtn = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.retrieveInvBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.newOrderBtn = new System.Windows.Forms.Button();
            this.grBoxShipMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(638, 461);
            this.label1.MinimumSize = new System.Drawing.Size(225, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 30);
            this.label1.TabIndex = 102;
            this.label1.Text = "Desired Shipping Company";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // companySelectBox
            // 
            this.companySelectBox.BackColor = System.Drawing.Color.Black;
            this.companySelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companySelectBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companySelectBox.ForeColor = System.Drawing.SystemColors.Info;
            this.companySelectBox.FormattingEnabled = true;
            this.companySelectBox.Items.AddRange(new object[] {
            "UPS",
            "USPS",
            "FedEx"});
            this.companySelectBox.Location = new System.Drawing.Point(638, 500);
            this.companySelectBox.MinimumSize = new System.Drawing.Size(225, 0);
            this.companySelectBox.Name = "companySelectBox";
            this.companySelectBox.Size = new System.Drawing.Size(225, 29);
            this.companySelectBox.TabIndex = 4;
            // 
            // twoDayBtn
            // 
            this.twoDayBtn.AutoSize = true;
            this.twoDayBtn.Location = new System.Drawing.Point(19, 39);
            this.twoDayBtn.Name = "twoDayBtn";
            this.twoDayBtn.Size = new System.Drawing.Size(92, 25);
            this.twoDayBtn.TabIndex = 1;
            this.twoDayBtn.TabStop = true;
            this.twoDayBtn.Text = "Two Day";
            this.twoDayBtn.UseVisualStyleBackColor = true;
            // 
            // overnightBtn
            // 
            this.overnightBtn.AutoSize = true;
            this.overnightBtn.Location = new System.Drawing.Point(143, 39);
            this.overnightBtn.Name = "overnightBtn";
            this.overnightBtn.Size = new System.Drawing.Size(101, 25);
            this.overnightBtn.TabIndex = 2;
            this.overnightBtn.TabStop = true;
            this.overnightBtn.Text = "Overnight";
            this.overnightBtn.UseVisualStyleBackColor = true;
            // 
            // weightBox
            // 
            this.weightBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.weightBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightBox.ForeColor = System.Drawing.SystemColors.Info;
            this.weightBox.Location = new System.Drawing.Point(339, 501);
            this.weightBox.MinimumSize = new System.Drawing.Size(225, 30);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(226, 29);
            this.weightBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(339, 461);
            this.label3.MinimumSize = new System.Drawing.Size(225, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 30);
            this.label3.TabIndex = 101;
            this.label3.Text = " Enter Package Weight (oz)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBoxOrder
            // 
            this.lstBoxOrder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstBoxOrder.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxOrder.ForeColor = System.Drawing.SystemColors.Info;
            this.lstBoxOrder.FormattingEnabled = true;
            this.lstBoxOrder.HorizontalScrollbar = true;
            this.lstBoxOrder.ItemHeight = 21;
            this.lstBoxOrder.Location = new System.Drawing.Point(11, 48);
            this.lstBoxOrder.Name = "lstBoxOrder";
            this.lstBoxOrder.Size = new System.Drawing.Size(604, 382);
            this.lstBoxOrder.TabIndex = 10;
            // 
            // grBoxShipMethod
            // 
            this.grBoxShipMethod.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grBoxShipMethod.Controls.Add(this.overnightBtn);
            this.grBoxShipMethod.Controls.Add(this.twoDayBtn);
            this.grBoxShipMethod.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxShipMethod.ForeColor = System.Drawing.SystemColors.Info;
            this.grBoxShipMethod.Location = new System.Drawing.Point(11, 461);
            this.grBoxShipMethod.MinimumSize = new System.Drawing.Size(225, 30);
            this.grBoxShipMethod.Name = "grBoxShipMethod";
            this.grBoxShipMethod.Size = new System.Drawing.Size(250, 80);
            this.grBoxShipMethod.TabIndex = 0;
            this.grBoxShipMethod.TabStop = false;
            this.grBoxShipMethod.Text = "Select Shipping Method:";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addBtn.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Location = new System.Drawing.Point(638, 193);
            this.addBtn.MinimumSize = new System.Drawing.Size(225, 30);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(228, 46);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add Order";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeBtn.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.removeBtn.Image = ((System.Drawing.Image)(resources.GetObject("removeBtn.Image")));
            this.removeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeBtn.Location = new System.Drawing.Point(638, 342);
            this.removeBtn.MinimumSize = new System.Drawing.Size(225, 30);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(230, 49);
            this.removeBtn.TabIndex = 8;
            this.removeBtn.Text = "Remove Order";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // finishBtn
            // 
            this.finishBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.finishBtn.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.finishBtn.Image = ((System.Drawing.Image)(resources.GetObject("finishBtn.Image")));
            this.finishBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.finishBtn.Location = new System.Drawing.Point(638, 241);
            this.finishBtn.MinimumSize = new System.Drawing.Size(225, 30);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(228, 49);
            this.finishBtn.TabIndex = 6;
            this.finishBtn.Text = "Finish Order";
            this.finishBtn.UseVisualStyleBackColor = false;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // lstBoxOrderSummary
            // 
            this.lstBoxOrderSummary.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstBoxOrderSummary.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxOrderSummary.ForeColor = System.Drawing.SystemColors.Info;
            this.lstBoxOrderSummary.FormattingEnabled = true;
            this.lstBoxOrderSummary.ItemHeight = 21;
            this.lstBoxOrderSummary.Location = new System.Drawing.Point(641, 47);
            this.lstBoxOrderSummary.MinimumSize = new System.Drawing.Size(226, 4);
            this.lstBoxOrderSummary.Name = "lstBoxOrderSummary";
            this.lstBoxOrderSummary.Size = new System.Drawing.Size(226, 88);
            this.lstBoxOrderSummary.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(704, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.MinimumSize = new System.Drawing.Size(112, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 30);
            this.label2.TabIndex = 103;
            this.label2.Text = "Total";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printLabelBtn
            // 
            this.printLabelBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printLabelBtn.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printLabelBtn.Image = ((System.Drawing.Image)(resources.GetObject("printLabelBtn.Image")));
            this.printLabelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printLabelBtn.Location = new System.Drawing.Point(638, 292);
            this.printLabelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.printLabelBtn.Name = "printLabelBtn";
            this.printLabelBtn.Size = new System.Drawing.Size(230, 47);
            this.printLabelBtn.TabIndex = 7;
            this.printLabelBtn.Text = "Print Label";
            this.printLabelBtn.UseVisualStyleBackColor = false;
            this.printLabelBtn.Click += new System.EventHandler(this.printLabelBtn_Click_1);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // retrieveInvBtn
            // 
            this.retrieveInvBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.retrieveInvBtn.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrieveInvBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.retrieveInvBtn.Image = ((System.Drawing.Image)(resources.GetObject("retrieveInvBtn.Image")));
            this.retrieveInvBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.retrieveInvBtn.Location = new System.Drawing.Point(638, 392);
            this.retrieveInvBtn.Margin = new System.Windows.Forms.Padding(2);
            this.retrieveInvBtn.Name = "retrieveInvBtn";
            this.retrieveInvBtn.Size = new System.Drawing.Size(230, 46);
            this.retrieveInvBtn.TabIndex = 9;
            this.retrieveInvBtn.Text = "Retrieve Invoice";
            this.retrieveInvBtn.UseVisualStyleBackColor = false;
            this.retrieveInvBtn.Click += new System.EventHandler(this.retrieveInvBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(173, 9);
            this.label4.MinimumSize = new System.Drawing.Size(225, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 30);
            this.label4.TabIndex = 105;
            this.label4.Text = " Current Order ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newOrderBtn
            // 
            this.newOrderBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newOrderBtn.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderBtn.Image = ((System.Drawing.Image)(resources.GetObject("newOrderBtn.Image")));
            this.newOrderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newOrderBtn.Location = new System.Drawing.Point(638, 144);
            this.newOrderBtn.Name = "newOrderBtn";
            this.newOrderBtn.Size = new System.Drawing.Size(228, 46);
            this.newOrderBtn.TabIndex = 11;
            this.newOrderBtn.Text = "New Order";
            this.newOrderBtn.UseVisualStyleBackColor = false;
            this.newOrderBtn.Click += new System.EventHandler(this.newOrderBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(876, 553);
            this.Controls.Add(this.newOrderBtn);
            this.Controls.Add(this.retrieveInvBtn);
            this.Controls.Add(this.printLabelBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstBoxOrderSummary);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.grBoxShipMethod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstBoxOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.companySelectBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Name = "Form1";
            this.Text = "Fastest Delivery Service";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grBoxShipMethod.ResumeLayout(false);
            this.grBoxShipMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox companySelectBox;
        private System.Windows.Forms.RadioButton twoDayBtn;
        private System.Windows.Forms.RadioButton overnightBtn;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstBoxOrder;
        private System.Windows.Forms.GroupBox grBoxShipMethod;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.ListBox lstBoxOrderSummary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button printLabelBtn;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button retrieveInvBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button newOrderBtn;
    }
}

