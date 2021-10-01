
namespace PersonEntryForm
{
    partial class PersonDataEntryForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.massKgLabel = new System.Windows.Forms.Label();
            this.massKgTextBox = new System.Windows.Forms.TextBox();
            this.dataListBox = new System.Windows.Forms.ListBox();
            this.addDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(18, 76);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(154, 76);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(257, 31);
            this.nameTextBox.TabIndex = 1;
            // 
            // massKgLabel
            // 
            this.massKgLabel.AutoSize = true;
            this.massKgLabel.Location = new System.Drawing.Point(18, 128);
            this.massKgLabel.Name = "massKgLabel";
            this.massKgLabel.Size = new System.Drawing.Size(98, 25);
            this.massKgLabel.TabIndex = 2;
            this.massKgLabel.Text = "Mass in Kg";
            // 
            // massKgTextBox
            // 
            this.massKgTextBox.Location = new System.Drawing.Point(154, 128);
            this.massKgTextBox.Name = "massKgTextBox";
            this.massKgTextBox.Size = new System.Drawing.Size(75, 31);
            this.massKgTextBox.TabIndex = 3;
            // 
            // dataListBox
            // 
            this.dataListBox.FormattingEnabled = true;
            this.dataListBox.ItemHeight = 25;
            this.dataListBox.Location = new System.Drawing.Point(729, 45);
            this.dataListBox.Name = "dataListBox";
            this.dataListBox.Size = new System.Drawing.Size(286, 354);
            this.dataListBox.TabIndex = 4;
            // 
            // addDataButton
            // 
            this.addDataButton.Location = new System.Drawing.Point(733, 428);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(128, 37);
            this.addDataButton.TabIndex = 5;
            this.addDataButton.Text = "Add Data";
            this.addDataButton.UseVisualStyleBackColor = true;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // PersonDataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 474);
            this.Controls.Add(this.addDataButton);
            this.Controls.Add(this.dataListBox);
            this.Controls.Add(this.massKgTextBox);
            this.Controls.Add(this.massKgLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "PersonDataEntryForm";
            this.Text = "Person Data Entry";
            this.Load += new System.EventHandler(this.PersonDataEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label massKgLabel;
        private System.Windows.Forms.TextBox massKgTextBox;
        private System.Windows.Forms.ListBox dataListBox;
        private System.Windows.Forms.Button addDataButton;
    }
}

