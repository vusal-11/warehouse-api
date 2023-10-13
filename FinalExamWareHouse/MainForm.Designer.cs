namespace FinalExamWareHouse
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            labelwelcome = new Label();
            labelusernameenter = new Label();
            labelpasswordenter = new Label();
            usernametextboxenter = new TextBox();
            mainpanel = new Panel();
            pictureBox1 = new PictureBox();
            signinbtn = new Button();
            signupbtn = new Button();
            passwordtextboxentering = new TextBox();
            clientpanel = new Panel();
            clientbuttonremove = new Button();
            listViewclient = new ListView();
            ClientName = new ColumnHeader();
            ClientSurname = new ColumnHeader();
            ClientEmail = new ColumnHeader();
            ClientPhone = new ColumnHeader();
            ClientAdress = new ColumnHeader();
            OrderPanel = new Panel();
            deleteorderbutton = new Button();
            listVieworder = new ListView();
            OrderName = new ColumnHeader();
            OrderProduct = new ColumnHeader();
            OrderQuantity = new ColumnHeader();
            OrderArrive = new ColumnHeader();
            ProductPanel = new Panel();
            deleteproductbutton = new Button();
            listViewproduct = new ListView();
            ProductName = new ColumnHeader();
            ProductPrice = new ColumnHeader();
            ProductQuantity = new ColumnHeader();
            ProductDescription = new ColumnHeader();
            mainmenuStrip = new MenuStrip();
            clientToolStripMenuItem2 = new ToolStripMenuItem();
            addclientmenustrip = new ToolStripMenuItem();
            listclientsmenustrip = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            acceptordermenustrip = new ToolStripMenuItem();
            listordersmenustrip = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            addproductmenustrip = new ToolStripMenuItem();
            listproductmenustrip = new ToolStripMenuItem();
            logOutToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenu = new ToolStripMenuItem();
            Filterlabel = new Label();
            filtertextBox = new TextBox();
            mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            clientpanel.SuspendLayout();
            OrderPanel.SuspendLayout();
            ProductPanel.SuspendLayout();
            mainmenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // labelwelcome
            // 
            labelwelcome.AutoSize = true;
            labelwelcome.Font = new Font("Tahoma", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelwelcome.Location = new Point(211, 104);
            labelwelcome.Name = "labelwelcome";
            labelwelcome.Size = new Size(302, 33);
            labelwelcome.TabIndex = 0;
            labelwelcome.Text = "Welcome to Program";
            // 
            // labelusernameenter
            // 
            labelusernameenter.AutoSize = true;
            labelusernameenter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelusernameenter.Location = new Point(143, 161);
            labelusernameenter.Name = "labelusernameenter";
            labelusernameenter.Size = new Size(83, 21);
            labelusernameenter.TabIndex = 1;
            labelusernameenter.Text = "Username";
            // 
            // labelpasswordenter
            // 
            labelpasswordenter.AutoSize = true;
            labelpasswordenter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelpasswordenter.Location = new Point(143, 204);
            labelpasswordenter.Name = "labelpasswordenter";
            labelpasswordenter.Size = new Size(79, 21);
            labelpasswordenter.TabIndex = 2;
            labelpasswordenter.Text = "Password";
            // 
            // usernametextboxenter
            // 
            usernametextboxenter.Location = new Point(253, 161);
            usernametextboxenter.Margin = new Padding(3, 2, 3, 2);
            usernametextboxenter.Name = "usernametextboxenter";
            usernametextboxenter.Size = new Size(209, 23);
            usernametextboxenter.TabIndex = 3;
            // 
            // mainpanel
            // 
            mainpanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mainpanel.BackColor = Color.SteelBlue;
            mainpanel.Controls.Add(pictureBox1);
            mainpanel.Controls.Add(signinbtn);
            mainpanel.Controls.Add(signupbtn);
            mainpanel.Controls.Add(passwordtextboxentering);
            mainpanel.Controls.Add(labelusernameenter);
            mainpanel.Controls.Add(usernametextboxenter);
            mainpanel.Controls.Add(labelwelcome);
            mainpanel.Controls.Add(labelpasswordenter);
            mainpanel.Location = new Point(34, 65);
            mainpanel.Margin = new Padding(3, 2, 3, 2);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(576, 343);
            mainpanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(494, 137);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 101);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // signinbtn
            // 
            signinbtn.BackColor = SystemColors.Info;
            signinbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            signinbtn.Location = new Point(383, 241);
            signinbtn.Margin = new Padding(3, 2, 3, 2);
            signinbtn.Name = "signinbtn";
            signinbtn.Size = new Size(76, 35);
            signinbtn.TabIndex = 6;
            signinbtn.Text = "Sign in";
            signinbtn.UseVisualStyleBackColor = false;
            signinbtn.Click += signinbtn_Click;
            // 
            // signupbtn
            // 
            signupbtn.BackColor = SystemColors.Info;
            signupbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            signupbtn.Location = new Point(253, 241);
            signupbtn.Margin = new Padding(3, 2, 3, 2);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(76, 35);
            signupbtn.TabIndex = 5;
            signupbtn.Text = "Sign up";
            signupbtn.UseVisualStyleBackColor = false;
            // 
            // passwordtextboxentering
            // 
            passwordtextboxentering.Location = new Point(253, 204);
            passwordtextboxentering.Margin = new Padding(3, 2, 3, 2);
            passwordtextboxentering.Name = "passwordtextboxentering";
            passwordtextboxentering.Size = new Size(209, 23);
            passwordtextboxentering.TabIndex = 4;
            // 
            // clientpanel
            // 
            clientpanel.Controls.Add(clientbuttonremove);
            clientpanel.Controls.Add(listViewclient);
            clientpanel.Location = new Point(732, 39);
            clientpanel.Margin = new Padding(3, 2, 3, 2);
            clientpanel.Name = "clientpanel";
            clientpanel.Size = new Size(730, 409);
            clientpanel.TabIndex = 5;
            // 
            // clientbuttonremove
            // 
            clientbuttonremove.BackColor = Color.SteelBlue;
            clientbuttonremove.Location = new Point(606, 2);
            clientbuttonremove.Margin = new Padding(3, 2, 3, 2);
            clientbuttonremove.Name = "clientbuttonremove";
            clientbuttonremove.Size = new Size(82, 22);
            clientbuttonremove.TabIndex = 11;
            clientbuttonremove.Text = "Delete";
            clientbuttonremove.UseVisualStyleBackColor = false;
            // 
            // listViewclient
            // 
            listViewclient.Columns.AddRange(new ColumnHeader[] { ClientName, ClientSurname, ClientEmail, ClientPhone, ClientAdress });
            listViewclient.Location = new Point(26, 0);
            listViewclient.Margin = new Padding(3, 2, 3, 2);
            listViewclient.Name = "listViewclient";
            listViewclient.Size = new Size(677, 461);
            listViewclient.TabIndex = 1;
            listViewclient.UseCompatibleStateImageBehavior = false;
            listViewclient.View = View.Details;
            // 
            // ClientName
            // 
            ClientName.Text = "Name";
            ClientName.Width = 100;
            // 
            // ClientSurname
            // 
            ClientSurname.Text = "Surname";
            ClientSurname.Width = 100;
            // 
            // ClientEmail
            // 
            ClientEmail.Text = "Email";
            ClientEmail.Width = 150;
            // 
            // ClientPhone
            // 
            ClientPhone.Text = "Phone";
            ClientPhone.Width = 135;
            // 
            // ClientAdress
            // 
            ClientAdress.Text = "Adress";
            ClientAdress.Width = 155;
            // 
            // OrderPanel
            // 
            OrderPanel.Controls.Add(deleteorderbutton);
            OrderPanel.Controls.Add(listVieworder);
            OrderPanel.Location = new Point(797, 452);
            OrderPanel.Margin = new Padding(3, 2, 3, 2);
            OrderPanel.Name = "OrderPanel";
            OrderPanel.Size = new Size(695, 483);
            OrderPanel.TabIndex = 6;
            // 
            // deleteorderbutton
            // 
            deleteorderbutton.BackColor = Color.SteelBlue;
            deleteorderbutton.Location = new Point(468, 14);
            deleteorderbutton.Margin = new Padding(3, 2, 3, 2);
            deleteorderbutton.Name = "deleteorderbutton";
            deleteorderbutton.Size = new Size(82, 22);
            deleteorderbutton.TabIndex = 1;
            deleteorderbutton.Text = "Delete";
            deleteorderbutton.UseVisualStyleBackColor = false;
            // 
            // listVieworder
            // 
            listVieworder.Columns.AddRange(new ColumnHeader[] { OrderName, OrderProduct, OrderQuantity, OrderArrive });
            listVieworder.Location = new Point(30, 14);
            listVieworder.Margin = new Padding(3, 2, 3, 2);
            listVieworder.Name = "listVieworder";
            listVieworder.Size = new Size(677, 461);
            listVieworder.TabIndex = 0;
            listVieworder.UseCompatibleStateImageBehavior = false;
            listVieworder.View = View.Details;
            // 
            // OrderName
            // 
            OrderName.Text = "Name";
            OrderName.Width = 100;
            // 
            // OrderProduct
            // 
            OrderProduct.Text = "Product";
            OrderProduct.Width = 120;
            // 
            // OrderQuantity
            // 
            OrderQuantity.Text = "Quantity";
            OrderQuantity.Width = 100;
            // 
            // OrderArrive
            // 
            OrderArrive.Text = "Arrive Date";
            OrderArrive.Width = 160;
            // 
            // ProductPanel
            // 
            ProductPanel.Controls.Add(deleteproductbutton);
            ProductPanel.Controls.Add(listViewproduct);
            ProductPanel.Location = new Point(22, 452);
            ProductPanel.Margin = new Padding(3, 2, 3, 2);
            ProductPanel.Name = "ProductPanel";
            ProductPanel.Size = new Size(705, 483);
            ProductPanel.TabIndex = 7;
            // 
            // deleteproductbutton
            // 
            deleteproductbutton.BackColor = Color.SteelBlue;
            deleteproductbutton.Location = new Point(422, 2);
            deleteproductbutton.Margin = new Padding(3, 2, 3, 2);
            deleteproductbutton.Name = "deleteproductbutton";
            deleteproductbutton.Size = new Size(82, 22);
            deleteproductbutton.TabIndex = 3;
            deleteproductbutton.Text = "Delete";
            deleteproductbutton.UseVisualStyleBackColor = false;
            // 
            // listViewproduct
            // 
            listViewproduct.Columns.AddRange(new ColumnHeader[] { ProductName, ProductPrice, ProductQuantity, ProductDescription });
            listViewproduct.Location = new Point(26, 2);
            listViewproduct.Margin = new Padding(3, 2, 3, 2);
            listViewproduct.Name = "listViewproduct";
            listViewproduct.Size = new Size(677, 461);
            listViewproduct.TabIndex = 2;
            listViewproduct.UseCompatibleStateImageBehavior = false;
            listViewproduct.View = View.Details;
            // 
            // ProductName
            // 
            ProductName.Text = "Name";
            ProductName.Width = 100;
            // 
            // ProductPrice
            // 
            ProductPrice.Text = "Price";
            ProductPrice.Width = 100;
            // 
            // ProductQuantity
            // 
            ProductQuantity.Text = "Quantity";
            ProductQuantity.Width = 100;
            // 
            // ProductDescription
            // 
            ProductDescription.Text = "Description";
            ProductDescription.Width = 140;
            // 
            // mainmenuStrip
            // 
            mainmenuStrip.BackColor = Color.SteelBlue;
            mainmenuStrip.ImageScalingSize = new Size(20, 20);
            mainmenuStrip.Items.AddRange(new ToolStripItem[] { clientToolStripMenuItem2, orderToolStripMenuItem, productToolStripMenuItem, logOutToolStripMenuItem1 });
            mainmenuStrip.Location = new Point(0, 0);
            mainmenuStrip.Name = "mainmenuStrip";
            mainmenuStrip.Padding = new Padding(5, 2, 0, 2);
            mainmenuStrip.Size = new Size(1590, 24);
            mainmenuStrip.TabIndex = 8;
            mainmenuStrip.Text = "menuStrip3";
            // 
            // clientToolStripMenuItem2
            // 
            clientToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { addclientmenustrip, listclientsmenustrip });
            clientToolStripMenuItem2.Name = "clientToolStripMenuItem2";
            clientToolStripMenuItem2.Size = new Size(50, 20);
            clientToolStripMenuItem2.Text = "Client";
            // 
            // addclientmenustrip
            // 
            addclientmenustrip.Name = "addclientmenustrip";
            addclientmenustrip.Size = new Size(96, 22);
            addclientmenustrip.Text = "Add";
            // 
            // listclientsmenustrip
            // 
            listclientsmenustrip.Name = "listclientsmenustrip";
            listclientsmenustrip.Size = new Size(96, 22);
            listclientsmenustrip.Text = "List";
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acceptordermenustrip, listordersmenustrip });
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(49, 20);
            orderToolStripMenuItem.Text = "Order";
            // 
            // acceptordermenustrip
            // 
            acceptordermenustrip.Name = "acceptordermenustrip";
            acceptordermenustrip.Size = new Size(111, 22);
            acceptordermenustrip.Text = "Accept";
            // 
            // listordersmenustrip
            // 
            listordersmenustrip.Name = "listordersmenustrip";
            listordersmenustrip.Size = new Size(111, 22);
            listordersmenustrip.Text = "List";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addproductmenustrip, listproductmenustrip });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(61, 20);
            productToolStripMenuItem.Text = "Product";
            // 
            // addproductmenustrip
            // 
            addproductmenustrip.Name = "addproductmenustrip";
            addproductmenustrip.Size = new Size(96, 22);
            addproductmenustrip.Text = "Add";
            // 
            // listproductmenustrip
            // 
            listproductmenustrip.Name = "listproductmenustrip";
            listproductmenustrip.Size = new Size(96, 22);
            listproductmenustrip.Text = "List";
            // 
            // logOutToolStripMenuItem1
            // 
            logOutToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenu });
            logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            logOutToolStripMenuItem1.Size = new Size(62, 20);
            logOutToolStripMenuItem1.Text = "Log Out";
            // 
            // exitToolStripMenu
            // 
            exitToolStripMenu.Name = "exitToolStripMenu";
            exitToolStripMenu.Size = new Size(93, 22);
            exitToolStripMenu.Text = "Exit";
            // 
            // Filterlabel
            // 
            Filterlabel.AutoSize = true;
            Filterlabel.Location = new Point(385, 11);
            Filterlabel.Name = "Filterlabel";
            Filterlabel.Size = new Size(33, 15);
            Filterlabel.TabIndex = 9;
            Filterlabel.Text = "Filter";
            // 
            // filtertextBox
            // 
            filtertextBox.Location = new Point(427, 9);
            filtertextBox.Margin = new Padding(3, 2, 3, 2);
            filtertextBox.Name = "filtertextBox";
            filtertextBox.Size = new Size(230, 23);
            filtertextBox.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1590, 791);
            Controls.Add(filtertextBox);
            Controls.Add(Filterlabel);
            Controls.Add(ProductPanel);
            Controls.Add(OrderPanel);
            Controls.Add(clientpanel);
            Controls.Add(mainpanel);
            Controls.Add(mainmenuStrip);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WareHouse";
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            clientpanel.ResumeLayout(false);
            OrderPanel.ResumeLayout(false);
            ProductPanel.ResumeLayout(false);
            mainmenuStrip.ResumeLayout(false);
            mainmenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelwelcome;
        private Label labelusernameenter;
        private Label labelpasswordenter;
        private TextBox usernametextboxenter;
        private Panel mainpanel;
        private Button signinbtn;
        private Button signupbtn;
        private TextBox passwordtextboxentering;
        private Panel clientpanel;
        private ListView listViewclient;
        private ColumnHeader ClientName;
        private ColumnHeader ClientSurname;
        private ColumnHeader ClientEmail;
        private ColumnHeader ClientPhone;
        private ColumnHeader ClientAdress;
        private Panel OrderPanel;
        private Panel ProductPanel;
        private ListView listViewproduct;
        private ColumnHeader ProductName;
        private ColumnHeader ProductPrice;
        private ColumnHeader ProductQuantity;
        private ColumnHeader ProductDescription;
        private MenuStrip mainmenuStrip;
        private ToolStripMenuItem clientToolStripMenuItem2;
        private ToolStripMenuItem addclientmenustrip;
        private ToolStripMenuItem listclientsmenustrip;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem acceptordermenustrip;
        private ToolStripMenuItem listordersmenustrip;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem addproductmenustrip;
        private ToolStripMenuItem listproductmenustrip;
        private ToolStripMenuItem logOutToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenu;
        private ListView listVieworder;
        private ColumnHeader OrderName;
        private ColumnHeader OrderProduct;
        private ColumnHeader OrderQuantity;
        private ColumnHeader OrderArrive;
        private Label Filterlabel;
        private TextBox filtertextBox;
        private Button clientbuttonremove;
        private Button deleteproductbutton;
        private Button deleteorderbutton;
        private PictureBox pictureBox1;
    }
}