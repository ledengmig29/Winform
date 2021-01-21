
namespace Test.MainForm
{
    partial class MainWinForm
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
            FontAwesome.Sharp.IconButton btnSetting;
            FontAwesome.Sharp.IconButton btnMarketing;
            FontAwesome.Sharp.IconButton btnCustomer;
            FontAwesome.Sharp.IconButton btnProduct;
            FontAwesome.Sharp.IconButton btnOrder;
            FontAwesome.Sharp.IconButton btnDashboard;
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            btnSetting = new FontAwesome.Sharp.IconButton();
            btnMarketing = new FontAwesome.Sharp.IconButton();
            btnCustomer = new FontAwesome.Sharp.IconButton();
            btnProduct = new FontAwesome.Sharp.IconButton();
            btnOrder = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(btnSetting);
            this.panelMenu.Controls.Add(btnMarketing);
            this.panelMenu.Controls.Add(btnCustomer);
            this.panelMenu.Controls.Add(btnProduct);
            this.panelMenu.Controls.Add(btnOrder);
            this.panelMenu.Controls.Add(btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(247, 783);
            this.panelMenu.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.PictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(247, 160);
            this.panelLogo.TabIndex = 1;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.pictureBox4);
            this.panelTitleBar.Controls.Add(this.pictureBox3);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(247, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1042, 95);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitleChildForm.Location = new System.Drawing.Point(50, 41);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(39, 15);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "HOME";
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(62)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(247, 95);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1042, 9);
            this.panelShadow.TabIndex = 3;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(247, 104);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1042, 679);
            this.panelDesktop.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Test.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(335, 187);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(376, 244);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(178)))), ((int)(((byte)(111)))));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Test.Properties.Resources.minimize_window_80px;
            this.pictureBox4.Location = new System.Drawing.Point(926, 8);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(178)))), ((int)(((byte)(111)))));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Test.Properties.Resources.maximize_window_80px;
            this.pictureBox3.Location = new System.Drawing.Point(968, 8);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(178)))), ((int)(((byte)(111)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Test.Properties.Resources.close_window_32px;
            this.btnClose.Location = new System.Drawing.Point(1010, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 10;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(121)))), ((int)(((byte)(220)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(121)))), ((int)(((byte)(220)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(16, 34);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // btnSetting
            // 
            btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnSetting.IconChar = FontAwesome.Sharp.IconChar.Sync;
            btnSetting.IconColor = System.Drawing.Color.White;
            btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSetting.IconSize = 32;
            btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSetting.Location = new System.Drawing.Point(0, 460);
            btnSetting.Name = "btnSetting";
            btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            btnSetting.Size = new System.Drawing.Size(247, 60);
            btnSetting.TabIndex = 6;
            btnSetting.Text = "系统设置";
            btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnMarketing
            // 
            btnMarketing.Dock = System.Windows.Forms.DockStyle.Top;
            btnMarketing.FlatAppearance.BorderSize = 0;
            btnMarketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMarketing.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnMarketing.IconChar = FontAwesome.Sharp.IconChar.Ravelry;
            btnMarketing.IconColor = System.Drawing.Color.White;
            btnMarketing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMarketing.IconSize = 32;
            btnMarketing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMarketing.Location = new System.Drawing.Point(0, 400);
            btnMarketing.Name = "btnMarketing";
            btnMarketing.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            btnMarketing.Size = new System.Drawing.Size(247, 60);
            btnMarketing.TabIndex = 5;
            btnMarketing.Text = "知识产权";
            btnMarketing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMarketing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnMarketing.UseVisualStyleBackColor = true;
            btnMarketing.Click += new System.EventHandler(this.btnMarketing_Click);
            // 
            // btnCustomer
            // 
            btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnCustomer.IconChar = FontAwesome.Sharp.IconChar.Rainbow;
            btnCustomer.IconColor = System.Drawing.Color.White;
            btnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCustomer.IconSize = 32;
            btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCustomer.Location = new System.Drawing.Point(0, 340);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            btnCustomer.Size = new System.Drawing.Size(247, 60);
            btnCustomer.TabIndex = 4;
            btnCustomer.Text = "商标注册";
            btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnProduct
            // 
            btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnProduct.IconChar = FontAwesome.Sharp.IconChar.PhotoVideo;
            btnProduct.IconColor = System.Drawing.Color.White;
            btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProduct.IconSize = 32;
            btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProduct.Location = new System.Drawing.Point(0, 280);
            btnProduct.Name = "btnProduct";
            btnProduct.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            btnProduct.Size = new System.Drawing.Size(247, 60);
            btnProduct.TabIndex = 3;
            btnProduct.Text = "专利增加";
            btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnOrder
            // 
            btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnOrder.IconChar = FontAwesome.Sharp.IconChar.Procedures;
            btnOrder.IconColor = System.Drawing.Color.White;
            btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOrder.IconSize = 32;
            btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnOrder.Location = new System.Drawing.Point(0, 220);
            btnOrder.Name = "btnOrder";
            btnOrder.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            btnOrder.Size = new System.Drawing.Size(247, 60);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "专利监控";
            btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Archive;
            btnDashboard.IconColor = System.Drawing.Color.White;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 32;
            btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDashboard.Location = new System.Drawing.Point(0, 160);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            btnDashboard.Size = new System.Drawing.Size(247, 60);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "专利布局";
            btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::Test.Properties.Resources.logo;
            this.PictureBox1.Location = new System.Drawing.Point(4, 34);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(231, 100);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 24;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // MainWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 783);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainWinForm";
            this.Text = "MainWinForm";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        internal System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.PictureBox btnClose;
        internal System.Windows.Forms.PictureBox pictureBox3;
        internal System.Windows.Forms.PictureBox pictureBox4;
    }
}