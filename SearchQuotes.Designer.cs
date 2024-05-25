namespace megaDesk
{
    partial class SearchQuotes
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            materialSearch = new ComboBox();
            label1 = new Label();
            results = new ListView();
            customerName = new ColumnHeader();
            material = new ColumnHeader();
            dimensions = new ColumnHeader();
            quoteDate = new ColumnHeader();
            quote = new ColumnHeader();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // materialSearch
            // 
            materialSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            materialSearch.FormattingEnabled = true;
            materialSearch.Location = new Point(12, 58);
            materialSearch.Name = "materialSearch";
            materialSearch.Size = new Size(211, 28);
            materialSearch.TabIndex = 1;
            materialSearch.SelectedIndexChanged += materialSearch_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 2;
            label1.Text = "Search by material";
            // 
            // results
            // 
            results.Columns.AddRange(new ColumnHeader[] { customerName, material, dimensions, quoteDate, quote });
            results.Location = new Point(241, 12);
            results.Name = "results";
            results.Size = new Size(547, 426);
            results.TabIndex = 3;
            results.UseCompatibleStateImageBehavior = false;
            results.View = View.Details;
            // 
            // customerName
            // 
            customerName.Text = "Customer Name";
            customerName.Width = 180;
            // 
            // material
            // 
            material.Text = "Material";
            material.Width = 100;
            // 
            // dimensions
            // 
            dimensions.Text = "Desk Size";
            dimensions.Width = 100;
            // 
            // quoteDate
            // 
            quoteDate.Text = "Date";
            quoteDate.Width = 100;
            // 
            // quote
            // 
            quote.Text = "Cost";
            quote.Width = 100;
            // 
            // SearchQuotes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(results);
            Controls.Add(label1);
            Controls.Add(materialSearch);
            Controls.Add(button1);
            Name = "SearchQuotes";
            Text = "SearchQuotes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private ComboBox materialSearch;
        private Label label1;
        private ListView results;
        private ColumnHeader customerName;
        private ColumnHeader material;
        private ColumnHeader quoteDate;
        private ColumnHeader quote;
        private ColumnHeader dimensions;
    }
}