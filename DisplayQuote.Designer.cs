namespace megaDesk
{
    partial class DisplayQuote
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
            label1 = new Label();
            quoteDate = new Label();
            customerName = new Label();
            quotePrice = new Label();
            rush = new Label();
            rushlabel = new Label();
            pricelabel = new Label();
            customerlabel = new Label();
            datelabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(198, 47);
            label1.TabIndex = 5;
            label1.Text = "Quote Info";
            label1.Click += label1_Click;
            // 
            // quoteDate
            // 
            quoteDate.AutoSize = true;
            quoteDate.Location = new Point(34, 115);
            quoteDate.Name = "quoteDate";
            quoteDate.Size = new Size(50, 20);
            quoteDate.TabIndex = 6;
            quoteDate.Text = "label2";
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.Location = new Point(34, 173);
            customerName.Name = "customerName";
            customerName.Size = new Size(50, 20);
            customerName.TabIndex = 7;
            customerName.Text = "label2";
            // 
            // quotePrice
            // 
            quotePrice.AutoSize = true;
            quotePrice.Location = new Point(34, 231);
            quotePrice.Name = "quotePrice";
            quotePrice.Size = new Size(50, 20);
            quotePrice.TabIndex = 8;
            quotePrice.Text = "label2";
            // 
            // rush
            // 
            rush.AutoSize = true;
            rush.Location = new Point(33, 289);
            rush.Name = "rush";
            rush.Size = new Size(50, 20);
            rush.TabIndex = 9;
            rush.Text = "label2";
            // 
            // rushlabel
            // 
            rushlabel.AutoSize = true;
            rushlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rushlabel.Location = new Point(31, 266);
            rushlabel.Name = "rushlabel";
            rushlabel.Size = new Size(44, 20);
            rushlabel.TabIndex = 13;
            rushlabel.Text = "Rush";
            // 
            // pricelabel
            // 
            pricelabel.AutoSize = true;
            pricelabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            pricelabel.Location = new Point(32, 208);
            pricelabel.Name = "pricelabel";
            pricelabel.Size = new Size(40, 20);
            pricelabel.TabIndex = 12;
            pricelabel.Text = "Cost";
            // 
            // customerlabel
            // 
            customerlabel.AutoSize = true;
            customerlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            customerlabel.Location = new Point(32, 150);
            customerlabel.Name = "customerlabel";
            customerlabel.Size = new Size(77, 20);
            customerlabel.TabIndex = 11;
            customerlabel.Text = "Customer";
            // 
            // datelabel
            // 
            datelabel.AutoSize = true;
            datelabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            datelabel.Location = new Point(32, 92);
            datelabel.Name = "datelabel";
            datelabel.Size = new Size(42, 20);
            datelabel.TabIndex = 10;
            datelabel.Text = "Date";
            // 
            // DisplayQuote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 450);
            Controls.Add(rushlabel);
            Controls.Add(pricelabel);
            Controls.Add(customerlabel);
            Controls.Add(datelabel);
            Controls.Add(rush);
            Controls.Add(quotePrice);
            Controls.Add(customerName);
            Controls.Add(quoteDate);
            Controls.Add(label1);
            Name = "DisplayQuote";
            Text = "DisplayQuote";
            Load += DisplayQuote_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label quoteDate;
        private Label customerName;
        private Label quotePrice;
        private Label rush;
        private Label rushlabel;
        private Label pricelabel;
        private Label customerlabel;
        private Label datelabel;
    }
}