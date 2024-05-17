namespace megaDesk
{
    partial class AddQuote
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            deskWidth = new TextBox();
            deskDepth = new TextBox();
            drawerCount = new TextBox();
            bindingSource1 = new BindingSource(components);
            button1 = new Button();
            material = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            addButton = new Button();
            customerName = new TextBox();
            label5 = new Label();
            rush = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // deskWidth
            // 
            deskWidth.Font = new Font("Microsoft Sans Serif", 18F);
            deskWidth.ForeColor = Color.Navy;
            deskWidth.Location = new Point(601, 151);
            deskWidth.Margin = new Padding(4);
            deskWidth.Name = "deskWidth";
            deskWidth.Size = new Size(380, 41);
            deskWidth.TabIndex = 0;
            deskWidth.Validating += deskWidth_Validating;
            // 
            // deskDepth
            // 
            deskDepth.Font = new Font("Microsoft Sans Serif", 18F);
            deskDepth.ForeColor = Color.Navy;
            deskDepth.Location = new Point(601, 246);
            deskDepth.Margin = new Padding(4);
            deskDepth.Name = "deskDepth";
            deskDepth.Size = new Size(380, 41);
            deskDepth.TabIndex = 1;
            deskDepth.TextChanged += deskDepth_TextChanged;
            // 
            // drawerCount
            // 
            drawerCount.Font = new Font("Microsoft Sans Serif", 18F);
            drawerCount.ForeColor = Color.Navy;
            drawerCount.Location = new Point(601, 341);
            drawerCount.Margin = new Padding(4);
            drawerCount.Name = "drawerCount";
            drawerCount.Size = new Size(380, 41);
            drawerCount.TabIndex = 2;
            drawerCount.TextChanged += drawerCount_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(117, 559);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(130, 40);
            button1.TabIndex = 4;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // material
            // 
            material.DropDownStyle = ComboBoxStyle.DropDownList;
            material.FormattingEnabled = true;
            material.Location = new Point(601, 436);
            material.Margin = new Padding(4);
            material.Name = "material";
            material.Size = new Size(380, 36);
            material.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(604, 123);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 6;
            label1.Text = "Width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(601, 218);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 7;
            label2.Text = "Depth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(604, 313);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 8;
            label3.Text = "Drawers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(601, 408);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 9;
            label4.Text = "Material";
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.Location = new Point(478, 549);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 51);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // customerName
            // 
            customerName.Font = new Font("Microsoft Sans Serif", 18F);
            customerName.ForeColor = Color.Navy;
            customerName.Location = new Point(79, 174);
            customerName.Margin = new Padding(4);
            customerName.Name = "customerName";
            customerName.Size = new Size(388, 41);
            customerName.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 142);
            label5.Name = "label5";
            label5.Size = new Size(153, 28);
            label5.TabIndex = 12;
            label5.Text = "Customer Name";
            // 
            // rush
            // 
            rush.DropDownStyle = ComboBoxStyle.DropDownList;
            rush.FormattingEnabled = true;
            rush.Items.AddRange(new object[] { "3 Day", "5 Day", "7 Day", "Standard (14 days)" });
            rush.Location = new Point(79, 268);
            rush.Margin = new Padding(4);
            rush.Name = "rush";
            rush.Size = new Size(388, 36);
            rush.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 236);
            label6.Name = "label6";
            label6.Size = new Size(110, 28);
            label6.TabIndex = 14;
            label6.Text = "Rush Order";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(735, 62);
            label7.Name = "label7";
            label7.Size = new Size(129, 28);
            label7.TabIndex = 15;
            label7.Text = "Desk Options";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(210, 63);
            label8.Name = "label8";
            label8.Size = new Size(102, 28);
            label8.TabIndex = 16;
            label8.Text = "Order Info";
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 629);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(rush);
            Controls.Add(label5);
            Controls.Add(customerName);
            Controls.Add(addButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(material);
            Controls.Add(button1);
            Controls.Add(drawerCount);
            Controls.Add(deskDepth);
            Controls.Add(deskWidth);
            Font = new Font("Segoe UI", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AddQuote";
            Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox deskWidth;
        private TextBox deskDepth;
        private TextBox drawerCount;
        private BindingSource bindingSource1;
        private Button button1;
        private ComboBox material;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button addButton;
        private TextBox customerName;
        private Label label5;
        private ComboBox rush;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}