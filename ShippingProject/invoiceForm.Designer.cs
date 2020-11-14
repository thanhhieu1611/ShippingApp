namespace ShippingProject
{
    partial class invoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoiceForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.getInvoiceBtn = new System.Windows.Forms.Button();
            this.printInvoiceBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.getInvDataBaseBtn = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBox1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(9, 11);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 277);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backBtn.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBtn.Location = new System.Drawing.Point(383, 340);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(262, 46);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "Return to Order Form";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // getInvoiceBtn
            // 
            this.getInvoiceBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getInvoiceBtn.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getInvoiceBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.getInvoiceBtn.Image = ((System.Drawing.Image)(resources.GetObject("getInvoiceBtn.Image")));
            this.getInvoiceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getInvoiceBtn.Location = new System.Drawing.Point(36, 290);
            this.getInvoiceBtn.Margin = new System.Windows.Forms.Padding(2);
            this.getInvoiceBtn.Name = "getInvoiceBtn";
            this.getInvoiceBtn.Size = new System.Drawing.Size(260, 46);
            this.getInvoiceBtn.TabIndex = 12;
            this.getInvoiceBtn.Text = "Today Invoices";
            this.getInvoiceBtn.UseVisualStyleBackColor = false;
            this.getInvoiceBtn.Click += new System.EventHandler(this.getInvoiceBtn_Click);
            // 
            // printInvoiceBtn
            // 
            this.printInvoiceBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printInvoiceBtn.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printInvoiceBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.printInvoiceBtn.Image = ((System.Drawing.Image)(resources.GetObject("printInvoiceBtn.Image")));
            this.printInvoiceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printInvoiceBtn.Location = new System.Drawing.Point(383, 290);
            this.printInvoiceBtn.Margin = new System.Windows.Forms.Padding(2);
            this.printInvoiceBtn.Name = "printInvoiceBtn";
            this.printInvoiceBtn.Size = new System.Drawing.Size(262, 46);
            this.printInvoiceBtn.TabIndex = 14;
            this.printInvoiceBtn.Text = "Print Invoice";
            this.printInvoiceBtn.UseVisualStyleBackColor = false;
            this.printInvoiceBtn.Click += new System.EventHandler(this.printInvoiceBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Location = new System.Drawing.Point(360, 11);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(598, 275);
            this.richTextBox1.TabIndex = 106;
            this.richTextBox1.Text = "Invoice Content";
            // 
            // getInvDataBaseBtn
            // 
            this.getInvDataBaseBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getInvDataBaseBtn.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getInvDataBaseBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.getInvDataBaseBtn.Image = ((System.Drawing.Image)(resources.GetObject("getInvDataBaseBtn.Image")));
            this.getInvDataBaseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getInvDataBaseBtn.Location = new System.Drawing.Point(36, 340);
            this.getInvDataBaseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.getInvDataBaseBtn.Name = "getInvDataBaseBtn";
            this.getInvDataBaseBtn.Size = new System.Drawing.Size(260, 46);
            this.getInvDataBaseBtn.TabIndex = 13;
            this.getInvDataBaseBtn.Text = "Database Invoices";
            this.getInvDataBaseBtn.UseVisualStyleBackColor = false;
            this.getInvDataBaseBtn.Click += new System.EventHandler(this.getInvDataBaseBtn_Click_1);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // invoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(970, 414);
            this.Controls.Add(this.getInvDataBaseBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.printInvoiceBtn);
            this.Controls.Add(this.getInvoiceBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "invoiceForm";
            this.Text = "invoiceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button getInvoiceBtn;
        private System.Windows.Forms.Button printInvoiceBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button getInvDataBaseBtn;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}