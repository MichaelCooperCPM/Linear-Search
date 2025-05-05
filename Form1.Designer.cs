namespace Linear_Search
{
    partial class Form1
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
            GenerateArrayButton = new Button();
            ArraySizeTextbox = new TextBox();
            label1 = new Label();
            DisplayArrayListbox = new ListBox();
            label2 = new Label();
            SearchResultLabel = new Label();
            SearchedValueTextbox = new TextBox();
            LinearSearchButton = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // GenerateArrayButton
            // 
            GenerateArrayButton.Location = new Point(320, 119);
            GenerateArrayButton.Name = "GenerateArrayButton";
            GenerateArrayButton.Size = new Size(161, 41);
            GenerateArrayButton.TabIndex = 0;
            GenerateArrayButton.Text = "Generate and Display Array";
            GenerateArrayButton.UseVisualStyleBackColor = true;
            GenerateArrayButton.Click += GenerateArrayButton_Click;
            // 
            // ArraySizeTextbox
            // 
            ArraySizeTextbox.Location = new Point(350, 79);
            ArraySizeTextbox.Name = "ArraySizeTextbox";
            ArraySizeTextbox.Size = new Size(100, 23);
            ArraySizeTextbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 43);
            label1.Name = "label1";
            label1.Size = new Size(281, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter the number of indexes for the generated array:";
            // 
            // DisplayArrayListbox
            // 
            DisplayArrayListbox.FormattingEnabled = true;
            DisplayArrayListbox.Location = new Point(320, 169);
            DisplayArrayListbox.Name = "DisplayArrayListbox";
            DisplayArrayListbox.Size = new Size(161, 154);
            DisplayArrayListbox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 505);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Result:";
            // 
            // SearchResultLabel
            // 
            SearchResultLabel.AutoSize = true;
            SearchResultLabel.Location = new Point(373, 505);
            SearchResultLabel.Name = "SearchResultLabel";
            SearchResultLabel.Size = new Size(103, 15);
            SearchResultLabel.TabIndex = 5;
            SearchResultLabel.Text = "Search not yet run";
            SearchResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SearchedValueTextbox
            // 
            SearchedValueTextbox.Location = new Point(350, 407);
            SearchedValueTextbox.Name = "SearchedValueTextbox";
            SearchedValueTextbox.Size = new Size(100, 23);
            SearchedValueTextbox.TabIndex = 6;
            // 
            // LinearSearchButton
            // 
            LinearSearchButton.Location = new Point(342, 446);
            LinearSearchButton.Name = "LinearSearchButton";
            LinearSearchButton.Size = new Size(117, 36);
            LinearSearchButton.TabIndex = 7;
            LinearSearchButton.Text = "Run Linear Search";
            LinearSearchButton.UseVisualStyleBackColor = true;
            LinearSearchButton.Click += LinearSearchButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 380);
            label3.Name = "label3";
            label3.Size = new Size(157, 15);
            label3.TabIndex = 8;
            label3.Text = "Enter the value to search for:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(label3);
            Controls.Add(LinearSearchButton);
            Controls.Add(SearchedValueTextbox);
            Controls.Add(SearchResultLabel);
            Controls.Add(label2);
            Controls.Add(DisplayArrayListbox);
            Controls.Add(label1);
            Controls.Add(ArraySizeTextbox);
            Controls.Add(GenerateArrayButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenerateArrayButton;
        private TextBox ArraySizeTextbox;
        private Label label1;
        private ListBox DisplayArrayListbox;
        private Label label2;
        private Label SearchResultLabel;
        private TextBox SearchedValueTextbox;
        private Button LinearSearchButton;
        private Label label3;
    }
}
