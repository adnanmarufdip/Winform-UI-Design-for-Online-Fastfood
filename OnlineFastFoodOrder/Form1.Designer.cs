namespace OnlineFastFoodOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.CustomersBtn = new System.Windows.Forms.Button();
            this.PaymentsBtn = new System.Windows.Forms.Button();
            this.TakeawayBtn = new System.Windows.Forms.Button();
            this.DeliveryBtn = new System.Windows.Forms.Button();
            this.CollectionBtn = new System.Windows.Forms.Button();
            this.EatInBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.HomePage = new OnlineFastFoodOrder.FirstCustomerControl();
            this.EatInPage = new OnlineFastFoodOrder.SecondCustomerControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.CustomersBtn);
            this.panel1.Controls.Add(this.PaymentsBtn);
            this.panel1.Controls.Add(this.TakeawayBtn);
            this.panel1.Controls.Add(this.DeliveryBtn);
            this.panel1.Controls.Add(this.CollectionBtn);
            this.panel1.Controls.Add(this.EatInBtn);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 585);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 85);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 3;
            // 
            // button14
            // 
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(4, 551);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(28, 31);
            this.button14.TabIndex = 3;
            this.button14.Text = "?";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // CustomersBtn
            // 
            this.CustomersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomersBtn.FlatAppearance.BorderSize = 0;
            this.CustomersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomersBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersBtn.ForeColor = System.Drawing.Color.White;
            this.CustomersBtn.Image = global::OnlineFastFoodOrder.Properties.Resources.multiple_users_silhouette;
            this.CustomersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomersBtn.Location = new System.Drawing.Point(12, 445);
            this.CustomersBtn.Name = "CustomersBtn";
            this.CustomersBtn.Size = new System.Drawing.Size(200, 54);
            this.CustomersBtn.TabIndex = 3;
            this.CustomersBtn.Text = "      Customers";
            this.CustomersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CustomersBtn.UseVisualStyleBackColor = true;
            this.CustomersBtn.Click += new System.EventHandler(this.CustomersBtn_Click);
            // 
            // PaymentsBtn
            // 
            this.PaymentsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaymentsBtn.FlatAppearance.BorderSize = 0;
            this.PaymentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentsBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentsBtn.ForeColor = System.Drawing.Color.White;
            this.PaymentsBtn.Image = global::OnlineFastFoodOrder.Properties.Resources.Cash;
            this.PaymentsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PaymentsBtn.Location = new System.Drawing.Point(12, 385);
            this.PaymentsBtn.Name = "PaymentsBtn";
            this.PaymentsBtn.Size = new System.Drawing.Size(200, 54);
            this.PaymentsBtn.TabIndex = 3;
            this.PaymentsBtn.Text = "      Payments";
            this.PaymentsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PaymentsBtn.UseVisualStyleBackColor = true;
            this.PaymentsBtn.Click += new System.EventHandler(this.PaymentsBtn_Click);
            // 
            // TakeawayBtn
            // 
            this.TakeawayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TakeawayBtn.FlatAppearance.BorderSize = 0;
            this.TakeawayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TakeawayBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakeawayBtn.ForeColor = System.Drawing.Color.White;
            this.TakeawayBtn.Image = global::OnlineFastFoodOrder.Properties.Resources.pizza;
            this.TakeawayBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TakeawayBtn.Location = new System.Drawing.Point(12, 325);
            this.TakeawayBtn.Name = "TakeawayBtn";
            this.TakeawayBtn.Size = new System.Drawing.Size(200, 54);
            this.TakeawayBtn.TabIndex = 3;
            this.TakeawayBtn.Text = "      Take Away";
            this.TakeawayBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TakeawayBtn.UseVisualStyleBackColor = true;
            this.TakeawayBtn.Click += new System.EventHandler(this.TakeawayBtn_Click);
            // 
            // DeliveryBtn
            // 
            this.DeliveryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeliveryBtn.FlatAppearance.BorderSize = 0;
            this.DeliveryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliveryBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryBtn.ForeColor = System.Drawing.Color.White;
            this.DeliveryBtn.Image = global::OnlineFastFoodOrder.Properties.Resources.delivery_truck_with_packages_behind;
            this.DeliveryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeliveryBtn.Location = new System.Drawing.Point(12, 265);
            this.DeliveryBtn.Name = "DeliveryBtn";
            this.DeliveryBtn.Size = new System.Drawing.Size(200, 54);
            this.DeliveryBtn.TabIndex = 3;
            this.DeliveryBtn.Text = "      Delivery";
            this.DeliveryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeliveryBtn.UseVisualStyleBackColor = true;
            this.DeliveryBtn.Click += new System.EventHandler(this.DeliveryBtn_Click);
            // 
            // CollectionBtn
            // 
            this.CollectionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CollectionBtn.FlatAppearance.BorderSize = 0;
            this.CollectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollectionBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectionBtn.ForeColor = System.Drawing.Color.White;
            this.CollectionBtn.Image = global::OnlineFastFoodOrder.Properties.Resources.list_with_dots;
            this.CollectionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CollectionBtn.Location = new System.Drawing.Point(12, 205);
            this.CollectionBtn.Name = "CollectionBtn";
            this.CollectionBtn.Size = new System.Drawing.Size(200, 54);
            this.CollectionBtn.TabIndex = 3;
            this.CollectionBtn.Text = "      Collection";
            this.CollectionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CollectionBtn.UseVisualStyleBackColor = true;
            this.CollectionBtn.Click += new System.EventHandler(this.CollectionBtn_Click);
            // 
            // EatInBtn
            // 
            this.EatInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EatInBtn.FlatAppearance.BorderSize = 0;
            this.EatInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EatInBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EatInBtn.ForeColor = System.Drawing.Color.White;
            this.EatInBtn.Image = global::OnlineFastFoodOrder.Properties.Resources.meal;
            this.EatInBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EatInBtn.Location = new System.Drawing.Point(12, 145);
            this.EatInBtn.Name = "EatInBtn";
            this.EatInBtn.Size = new System.Drawing.Size(200, 54);
            this.EatInBtn.TabIndex = 3;
            this.EatInBtn.Text = "      Eat-In";
            this.EatInBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EatInBtn.UseVisualStyleBackColor = true;
            this.EatInBtn.Click += new System.EventHandler(this.EatInBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Image = global::OnlineFastFoodOrder.Properties.Resources.ComputerClientt;
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.Location = new System.Drawing.Point(12, 85);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(200, 54);
            this.HomeBtn.TabIndex = 3;
            this.HomeBtn.Text = "      Home";
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(211, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(243, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(101, 126);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Online";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fast Foods";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OnlineFastFoodOrder.Properties.Resources.FastFoodIco;
            this.pictureBox1.Location = new System.Drawing.Point(17, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(352, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Online Fast Food Delivery";
            // 
            // QuitBtn
            // 
            this.QuitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitBtn.FlatAppearance.BorderSize = 0;
            this.QuitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitBtn.ForeColor = System.Drawing.Color.White;
            this.QuitBtn.Image = global::OnlineFastFoodOrder.Properties.Resources.power;
            this.QuitBtn.Location = new System.Drawing.Point(1061, 24);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(32, 30);
            this.QuitBtn.TabIndex = 3;
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // button12
            // 
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Image = global::OnlineFastFoodOrder.Properties.Resources.settings_work_tool;
            this.button12.Location = new System.Drawing.Point(1015, 24);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(32, 30);
            this.button12.TabIndex = 3;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = global::OnlineFastFoodOrder.Properties.Resources.notifications_bell_button;
            this.button11.Location = new System.Drawing.Point(969, 24);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(32, 30);
            this.button11.TabIndex = 3;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = global::OnlineFastFoodOrder.Properties.Resources.instagram1;
            this.button10.Location = new System.Drawing.Point(818, 24);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(32, 30);
            this.button10.TabIndex = 3;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = global::OnlineFastFoodOrder.Properties.Resources.twitter_logo_on_black_background1;
            this.button9.Location = new System.Drawing.Point(744, 24);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(32, 30);
            this.button9.TabIndex = 3;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::OnlineFastFoodOrder.Properties.Resources.facebook_logo1;
            this.button8.Location = new System.Drawing.Point(669, 24);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 30);
            this.button8.TabIndex = 3;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.HomePage.Location = new System.Drawing.Point(212, 132);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(909, 452);
            this.HomePage.TabIndex = 7;
            // 
            // EatInPage
            // 
            this.EatInPage.Location = new System.Drawing.Point(212, 133);
            this.EatInPage.Name = "EatInPage";
            this.EatInPage.Size = new System.Drawing.Size(909, 452);
            this.EatInPage.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 585);
            this.Controls.Add(this.HomePage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EatInPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button PaymentsBtn;
        private System.Windows.Forms.Button TakeawayBtn;
        private System.Windows.Forms.Button DeliveryBtn;
        private System.Windows.Forms.Button CollectionBtn;
        private System.Windows.Forms.Button EatInBtn;
        private System.Windows.Forms.Button CustomersBtn;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button button14;
        private FirstCustomerControl HomePage;
        private SecondCustomerControl EatInPage;
    }
}

