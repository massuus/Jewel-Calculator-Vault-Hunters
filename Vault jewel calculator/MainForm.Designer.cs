namespace Vault_jewel_calculator
{
    partial class MainForm
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.jewelListBox = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.maxSpaceLabel = new System.Windows.Forms.Label();
            this.maxSpaceTextBox = new System.Windows.Forms.TextBox();
            this.bestJewelsLabel = new System.Windows.Forms.Label();
            this.bestJewelsTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.pasteButton = new System.Windows.Forms.Button();
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.totalValue = new System.Windows.Forms.Label();
            this.totalSizeLabel = new System.Windows.Forms.Label();
            this.totalSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(20, 242);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 44);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Craft";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(20, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(92, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Jewel Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(20, 42);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 27);
            this.nameTextBox.TabIndex = 2;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(20, 73);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(39, 20);
            this.sizeLabel.TabIndex = 3;
            this.sizeLabel.Text = "Size:";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(20, 97);
            this.sizeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(121, 27);
            this.sizeTextBox.TabIndex = 4;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(20, 128);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(48, 20);
            this.valueLabel.TabIndex = 5;
            this.valueLabel.Text = "Value:";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(20, 152);
            this.valueTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(121, 27);
            this.valueTextBox.TabIndex = 6;
            // 
            // jewelListBox
            // 
            this.jewelListBox.FormattingEnabled = true;
            this.jewelListBox.ItemHeight = 20;
            this.jewelListBox.Location = new System.Drawing.Point(191, 8);
            this.jewelListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.jewelListBox.Name = "jewelListBox";
            this.jewelListBox.Size = new System.Drawing.Size(233, 344);
            this.jewelListBox.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(20, 298);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 44);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // maxSpaceLabel
            // 
            this.maxSpaceLabel.AutoSize = true;
            this.maxSpaceLabel.Location = new System.Drawing.Point(20, 183);
            this.maxSpaceLabel.Name = "maxSpaceLabel";
            this.maxSpaceLabel.Size = new System.Drawing.Size(84, 20);
            this.maxSpaceLabel.TabIndex = 9;
            this.maxSpaceLabel.Text = "Max Space:";
            // 
            // maxSpaceTextBox
            // 
            this.maxSpaceTextBox.Location = new System.Drawing.Point(20, 207);
            this.maxSpaceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maxSpaceTextBox.Name = "maxSpaceTextBox";
            this.maxSpaceTextBox.Size = new System.Drawing.Size(121, 27);
            this.maxSpaceTextBox.TabIndex = 10;
            // 
            // bestJewelsLabel
            // 
            this.bestJewelsLabel.AutoSize = true;
            this.bestJewelsLabel.Location = new System.Drawing.Point(440, 12);
            this.bestJewelsLabel.Name = "bestJewelsLabel";
            this.bestJewelsLabel.Size = new System.Drawing.Size(106, 20);
            this.bestJewelsLabel.TabIndex = 11;
            this.bestJewelsLabel.Text = "Jewels To Add:";
            // 
            // bestJewelsTextBox
            // 
            this.bestJewelsTextBox.Location = new System.Drawing.Point(444, 42);
            this.bestJewelsTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bestJewelsTextBox.Multiline = true;
            this.bestJewelsTextBox.Name = "bestJewelsTextBox";
            this.bestJewelsTextBox.ReadOnly = true;
            this.bestJewelsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bestJewelsTextBox.Size = new System.Drawing.Size(268, 262);
            this.bestJewelsTextBox.TabIndex = 12;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(20, 348);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 44);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(128, 298);
            this.copyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(57, 44);
            this.copyButton.TabIndex = 14;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // pasteButton
            // 
            this.pasteButton.Location = new System.Drawing.Point(128, 348);
            this.pasteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(57, 44);
            this.pasteButton.TabIndex = 15;
            this.pasteButton.Text = "Paste";
            this.pasteButton.UseVisualStyleBackColor = true;
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.AutoSize = true;
            this.totalValueLabel.Location = new System.Drawing.Point(440, 326);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(85, 20);
            this.totalValueLabel.TabIndex = 16;
            this.totalValueLabel.Text = "Total Value:";
            // 
            // totalValue
            // 
            this.totalValue.AutoSize = true;
            this.totalValue.Location = new System.Drawing.Point(533, 326);
            this.totalValue.Name = "totalValue";
            this.totalValue.Size = new System.Drawing.Size(0, 20);
            this.totalValue.TabIndex = 17;
            // 
            // totalSizeLabel
            // 
            this.totalSizeLabel.AutoSize = true;
            this.totalSizeLabel.Location = new System.Drawing.Point(440, 366);
            this.totalSizeLabel.Name = "totalSizeLabel";
            this.totalSizeLabel.Size = new System.Drawing.Size(76, 20);
            this.totalSizeLabel.TabIndex = 18;
            this.totalSizeLabel.Text = "Total Size:";
            // 
            // totalSize
            // 
            this.totalSize.AutoSize = true;
            this.totalSize.Location = new System.Drawing.Point(533, 366);
            this.totalSize.Name = "totalSize";
            this.totalSize.Size = new System.Drawing.Size(0, 20);
            this.totalSize.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Made By: Massuus";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalSize);
            this.Controls.Add(this.totalSizeLabel);
            this.Controls.Add(this.totalValue);
            this.Controls.Add(this.totalValueLabel);
            this.Controls.Add(this.pasteButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.bestJewelsTextBox);
            this.Controls.Add(this.bestJewelsLabel);
            this.Controls.Add(this.maxSpaceTextBox);
            this.Controls.Add(this.maxSpaceLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.jewelListBox);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Vault Hunters Jewel Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.ListBox jewelListBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label maxSpaceLabel;
        private System.Windows.Forms.TextBox maxSpaceTextBox;
        private System.Windows.Forms.Label bestJewelsLabel;
        private System.Windows.Forms.TextBox bestJewelsTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button pasteButton;
        private System.Windows.Forms.Label totalValueLabel;
        private System.Windows.Forms.Label totalValue;
        private System.Windows.Forms.Label totalSizeLabel;
        private System.Windows.Forms.Label totalSize;
        private Label label1;
    }
}
