namespace getData
{
    partial class Form1
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
            this.Items = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGetListFromText = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pgbWaitLoadCharFavour = new System.Windows.Forms.ProgressBar();
            this.btnGetCharFavourite = new System.Windows.Forms.Button();
            this.txtXmlPath = new System.Windows.Forms.TextBox();
            this.btnGetCharacter = new System.Windows.Forms.Button();
            this.txtLoadInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGetAllItem = new System.Windows.Forms.Button();
            this.txtCharFav = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnGetHtmlCooking = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCookingLink = new System.Windows.Forms.TextBox();
            this.txtAll = new System.Windows.Forms.RichTextBox();
            this.txtXmlRecipePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetRecipeCLass = new System.Windows.Forms.Button();
            this.Items.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Items
            // 
            this.Items.Controls.Add(this.tabPage1);
            this.Items.Controls.Add(this.tabPage2);
            this.Items.Controls.Add(this.tabPage3);
            this.Items.Controls.Add(this.tabPage4);
            this.Items.Location = new System.Drawing.Point(29, 167);
            this.Items.Name = "Items";
            this.Items.SelectedIndex = 0;
            this.Items.Size = new System.Drawing.Size(565, 221);
            this.Items.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGetListFromText);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(557, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CharacterList";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGetListFromText
            // 
            this.btnGetListFromText.Location = new System.Drawing.Point(21, 44);
            this.btnGetListFromText.Name = "btnGetListFromText";
            this.btnGetListFromText.Size = new System.Drawing.Size(158, 23);
            this.btnGetListFromText.TabIndex = 1;
            this.btnGetListFromText.Text = "get list of character";
            this.btnGetListFromText.UseVisualStyleBackColor = true;
            this.btnGetListFromText.Click += new System.EventHandler(this.btnGetListFromText_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "get the link";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pgbWaitLoadCharFavour);
            this.tabPage2.Controls.Add(this.btnGetCharFavourite);
            this.tabPage2.Controls.Add(this.txtXmlPath);
            this.tabPage2.Controls.Add(this.btnGetCharacter);
            this.tabPage2.Controls.Add(this.txtLoadInfo);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(557, 195);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Character Item";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pgbWaitLoadCharFavour
            // 
            this.pgbWaitLoadCharFavour.Location = new System.Drawing.Point(181, 58);
            this.pgbWaitLoadCharFavour.Name = "pgbWaitLoadCharFavour";
            this.pgbWaitLoadCharFavour.Size = new System.Drawing.Size(296, 23);
            this.pgbWaitLoadCharFavour.TabIndex = 4;
            // 
            // btnGetCharFavourite
            // 
            this.btnGetCharFavourite.Location = new System.Drawing.Point(483, 58);
            this.btnGetCharFavourite.Name = "btnGetCharFavourite";
            this.btnGetCharFavourite.Size = new System.Drawing.Size(75, 23);
            this.btnGetCharFavourite.TabIndex = 3;
            this.btnGetCharFavourite.Text = "GetFavourite";
            this.btnGetCharFavourite.UseVisualStyleBackColor = true;
            this.btnGetCharFavourite.Click += new System.EventHandler(this.btnGetCharFavourite_Click);
            // 
            // txtXmlPath
            // 
            this.txtXmlPath.Location = new System.Drawing.Point(146, 16);
            this.txtXmlPath.Name = "txtXmlPath";
            this.txtXmlPath.Size = new System.Drawing.Size(331, 20);
            this.txtXmlPath.TabIndex = 2;
            this.txtXmlPath.Text = "E:\\chilly projects\\new BTN data getter\\Answer\\character list.xml";
            // 
            // btnGetCharacter
            // 
            this.btnGetCharacter.Location = new System.Drawing.Point(483, 14);
            this.btnGetCharacter.Name = "btnGetCharacter";
            this.btnGetCharacter.Size = new System.Drawing.Size(75, 23);
            this.btnGetCharacter.TabIndex = 1;
            this.btnGetCharacter.Text = "get Character Data";
            this.btnGetCharacter.UseVisualStyleBackColor = true;
            this.btnGetCharacter.Click += new System.EventHandler(this.btnGetCharacter_Click);
            // 
            // txtLoadInfo
            // 
            this.txtLoadInfo.AutoSize = true;
            this.txtLoadInfo.Location = new System.Drawing.Point(178, 94);
            this.txtLoadInfo.Name = "txtLoadInfo";
            this.txtLoadInfo.Size = new System.Drawing.Size(13, 13);
            this.txtLoadInfo.TabIndex = 0;
            this.txtLoadInfo.Text = "..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "and test Serialization Character";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "** get a List(Character)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "** get a List(Character)";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnGetAllItem);
            this.tabPage3.Controls.Add(this.txtCharFav);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(557, 195);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Items";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGetAllItem
            // 
            this.btnGetAllItem.Location = new System.Drawing.Point(386, 20);
            this.btnGetAllItem.Name = "btnGetAllItem";
            this.btnGetAllItem.Size = new System.Drawing.Size(110, 23);
            this.btnGetAllItem.TabIndex = 4;
            this.btnGetAllItem.Text = "GetAllItemFromFavour";
            this.btnGetAllItem.UseVisualStyleBackColor = true;
            this.btnGetAllItem.Click += new System.EventHandler(this.btnGetAllItem_Click);
            // 
            // txtCharFav
            // 
            this.txtCharFav.Location = new System.Drawing.Point(32, 20);
            this.txtCharFav.Name = "txtCharFav";
            this.txtCharFav.Size = new System.Drawing.Size(331, 20);
            this.txtCharFav.TabIndex = 3;
            this.txtCharFav.Text = "E:\\chilly projects\\new BTN data getter\\Answer\\character favour (3)  normalized.xm" +
                "l";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnGetRecipeCLass);
            this.tabPage4.Controls.Add(this.btnGetHtmlCooking);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.txtXmlRecipePath);
            this.tabPage4.Controls.Add(this.txtCookingLink);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(557, 195);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cooking";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnGetHtmlCooking
            // 
            this.btnGetHtmlCooking.Location = new System.Drawing.Point(426, 15);
            this.btnGetHtmlCooking.Name = "btnGetHtmlCooking";
            this.btnGetHtmlCooking.Size = new System.Drawing.Size(98, 23);
            this.btnGetHtmlCooking.TabIndex = 2;
            this.btnGetHtmlCooking.Text = "get the link";
            this.btnGetHtmlCooking.UseVisualStyleBackColor = true;
            this.btnGetHtmlCooking.Click += new System.EventHandler(this.btnGetHtmlCooking_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "web :";
            // 
            // txtCookingLink
            // 
            this.txtCookingLink.Location = new System.Drawing.Point(78, 15);
            this.txtCookingLink.Name = "txtCookingLink";
            this.txtCookingLink.Size = new System.Drawing.Size(342, 20);
            this.txtCookingLink.TabIndex = 0;
            this.txtCookingLink.Text = "http://harvestmoonbacktonatureguide.com/cooking.html";
            // 
            // txtAll
            // 
            this.txtAll.Location = new System.Drawing.Point(29, 12);
            this.txtAll.Name = "txtAll";
            this.txtAll.Size = new System.Drawing.Size(565, 149);
            this.txtAll.TabIndex = 2;
            this.txtAll.Text = "";
            // 
            // txtXmlRecipePath
            // 
            this.txtXmlRecipePath.Location = new System.Drawing.Point(78, 50);
            this.txtXmlRecipePath.Name = "txtXmlRecipePath";
            this.txtXmlRecipePath.Size = new System.Drawing.Size(342, 20);
            this.txtXmlRecipePath.TabIndex = 0;
            this.txtXmlRecipePath.Text = "E:\\chilly projects\\new BTN data getter\\Answer\\recipe.xml";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "get object :";
            // 
            // btnGetRecipeCLass
            // 
            this.btnGetRecipeCLass.Location = new System.Drawing.Point(426, 47);
            this.btnGetRecipeCLass.Name = "btnGetRecipeCLass";
            this.btnGetRecipeCLass.Size = new System.Drawing.Size(98, 23);
            this.btnGetRecipeCLass.TabIndex = 2;
            this.btnGetRecipeCLass.Text = "get REcpieClasses";
            this.btnGetRecipeCLass.UseVisualStyleBackColor = true;
            this.btnGetRecipeCLass.Click += new System.EventHandler(this.btnGetRecipeCLass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 400);
            this.Controls.Add(this.txtAll);
            this.Controls.Add(this.Items);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Items.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Items;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtAll;
        private System.Windows.Forms.Button btnGetListFromText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetCharacter;
        private System.Windows.Forms.TextBox txtXmlPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetCharFavourite;
        private System.Windows.Forms.ProgressBar pgbWaitLoadCharFavour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtLoadInfo;
        private System.Windows.Forms.TextBox txtCharFav;
        private System.Windows.Forms.Button btnGetAllItem;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtCookingLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetHtmlCooking;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtXmlRecipePath;
        private System.Windows.Forms.Button btnGetRecipeCLass;
    }
}

