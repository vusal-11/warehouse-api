namespace FinalExamWareHouse
{
    partial class AddProduct
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
            productnamelabel = new Label();
            textBoxproductname = new TextBox();
            Priceproductlabel = new Label();
            productpricetextbox = new TextBox();
            QuantityproductLabel = new Label();
            Descriptionproductlabel = new Label();
            productrichTextBox = new RichTextBox();
            saveprductbtn = new Button();
            quantitynumericupdown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)quantitynumericupdown).BeginInit();
            SuspendLayout();
            // 
            // productnamelabel
            // 
            productnamelabel.AutoSize = true;
            productnamelabel.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            productnamelabel.Location = new Point(73, 56);
            productnamelabel.Name = "productnamelabel";
            productnamelabel.Size = new Size(49, 23);
            productnamelabel.TabIndex = 0;
            productnamelabel.Text = "Name";
            // 
            // textBoxproductname
            // 
            textBoxproductname.Location = new Point(166, 56);
            textBoxproductname.Margin = new Padding(3, 2, 3, 2);
            textBoxproductname.Name = "textBoxproductname";
            textBoxproductname.Size = new Size(110, 23);
            textBoxproductname.TabIndex = 1;
            // 
            // Priceproductlabel
            // 
            Priceproductlabel.AutoSize = true;
            Priceproductlabel.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Priceproductlabel.Location = new Point(73, 93);
            Priceproductlabel.Name = "Priceproductlabel";
            Priceproductlabel.Size = new Size(45, 23);
            Priceproductlabel.TabIndex = 2;
            Priceproductlabel.Text = "Price";
            // 
            // productpricetextbox
            // 
            productpricetextbox.Location = new Point(166, 96);
            productpricetextbox.Margin = new Padding(3, 2, 3, 2);
            productpricetextbox.Name = "productpricetextbox";
            productpricetextbox.Size = new Size(110, 23);
            productpricetextbox.TabIndex = 3;
            // 
            // QuantityproductLabel
            // 
            QuantityproductLabel.AutoSize = true;
            QuantityproductLabel.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            QuantityproductLabel.Location = new Point(71, 128);
            QuantityproductLabel.Name = "QuantityproductLabel";
            QuantityproductLabel.Size = new Size(69, 23);
            QuantityproductLabel.TabIndex = 4;
            QuantityproductLabel.Text = "Quantity";
            // 
            // Descriptionproductlabel
            // 
            Descriptionproductlabel.AutoSize = true;
            Descriptionproductlabel.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Descriptionproductlabel.Location = new Point(65, 170);
            Descriptionproductlabel.Name = "Descriptionproductlabel";
            Descriptionproductlabel.Size = new Size(89, 23);
            Descriptionproductlabel.TabIndex = 6;
            Descriptionproductlabel.Text = "Description";
            // 
            // productrichTextBox
            // 
            productrichTextBox.Location = new Point(166, 173);
            productrichTextBox.Margin = new Padding(3, 2, 3, 2);
            productrichTextBox.Name = "productrichTextBox";
            productrichTextBox.Size = new Size(229, 129);
            productrichTextBox.TabIndex = 7;
            productrichTextBox.Text = "";
            // 
            // saveprductbtn
            // 
            saveprductbtn.BackColor = Color.SeaShell;
            saveprductbtn.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            saveprductbtn.Location = new Point(303, 320);
            saveprductbtn.Margin = new Padding(3, 2, 3, 2);
            saveprductbtn.Name = "saveprductbtn";
            saveprductbtn.Size = new Size(92, 34);
            saveprductbtn.TabIndex = 8;
            saveprductbtn.Text = "Save";
            saveprductbtn.UseVisualStyleBackColor = false;
         
            // 
            // quantitynumericupdown
            // 
            quantitynumericupdown.Location = new Point(166, 132);
            quantitynumericupdown.Margin = new Padding(3, 2, 3, 2);
            quantitynumericupdown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            quantitynumericupdown.Name = "quantitynumericupdown";
            quantitynumericupdown.Size = new Size(131, 23);
            quantitynumericupdown.TabIndex = 9;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(453, 374);
            Controls.Add(quantitynumericupdown);
            Controls.Add(saveprductbtn);
            Controls.Add(productrichTextBox);
            Controls.Add(Descriptionproductlabel);
            Controls.Add(QuantityproductLabel);
            Controls.Add(productpricetextbox);
            Controls.Add(Priceproductlabel);
            Controls.Add(textBoxproductname);
            Controls.Add(productnamelabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)quantitynumericupdown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productnamelabel;
        private TextBox textBoxproductname;
        private Label Priceproductlabel;
        private TextBox productpricetextbox;
        private Label QuantityproductLabel;
        private Label Descriptionproductlabel;
        private RichTextBox productrichTextBox;
        private Button saveprductbtn;
        private NumericUpDown quantitynumericupdown;
    }
}