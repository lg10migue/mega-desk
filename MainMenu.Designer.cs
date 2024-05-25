namespace megaDesk
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            addQuote = new Button();
            searchQuotes = new Button();
            exit = new Button();
            label1 = new Label();
            viewQuotes = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // addQuote
            // 
            addQuote.Location = new Point(27, 80);
            addQuote.Margin = new Padding(3, 2, 3, 2);
            addQuote.Name = "addQuote";
            addQuote.Size = new Size(131, 38);
            addQuote.TabIndex = 0;
            addQuote.Text = "Add New Quote";
            addQuote.UseVisualStyleBackColor = true;
            addQuote.Click += addQuote_Click;
            // 
            // searchQuotes
            // 
            searchQuotes.Location = new Point(27, 164);
            searchQuotes.Margin = new Padding(3, 2, 3, 2);
            searchQuotes.Name = "searchQuotes";
            searchQuotes.Size = new Size(131, 38);
            searchQuotes.TabIndex = 1;
            searchQuotes.Text = "Search Quotes";
            searchQuotes.UseVisualStyleBackColor = true;
            searchQuotes.Click += searchButton_Click;
            // 
            // exit
            // 
            exit.Location = new Point(27, 243);
            exit.Margin = new Padding(3, 2, 3, 2);
            exit.Name = "exit";
            exit.Size = new Size(131, 38);
            exit.TabIndex = 3;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            label1.Location = new Point(145, 20);
            label1.Name = "label1";
            label1.Size = new Size(163, 38);
            label1.TabIndex = 4;
            label1.Text = "Mega Desk";
            label1.Click += label1_Click;
            // 
            // viewQuotes
            // 
            viewQuotes.Location = new Point(27, 122);
            viewQuotes.Margin = new Padding(3, 2, 3, 2);
            viewQuotes.Name = "viewQuotes";
            viewQuotes.Size = new Size(131, 38);
            viewQuotes.TabIndex = 5;
            viewQuotes.Text = "View Quotes";
            viewQuotes.UseVisualStyleBackColor = true;
            viewQuotes.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(189, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 302);
            Controls.Add(pictureBox1);
            Controls.Add(viewQuotes);
            Controls.Add(label1);
            Controls.Add(exit);
            Controls.Add(searchQuotes);
            Controls.Add(addQuote);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainMenu";
            Text = "MegaDesk";
            Load += MainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addQuote;
        private Button searchQuotes;
        private Button exit;
        private Label label1;
        private Button viewQuotes;
        private PictureBox pictureBox1;
    }
}
