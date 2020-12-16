
namespace DIgital_Diary
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnTag = new FontAwesome.Sharp.IconButton();
            this.btnCreateNote = new FontAwesome.Sharp.IconButton();
            this.btnAllNote = new FontAwesome.Sharp.IconButton();
            this.Panellogo = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paneltop = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Searchbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelMenu.SuspendLayout();
            this.Panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.btnSetting);
            this.panelMenu.Controls.Add(this.btnTag);
            this.panelMenu.Controls.Add(this.btnCreateNote);
            this.panelMenu.Controls.Add(this.btnAllNote);
            this.panelMenu.Controls.Add(this.Panellogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(193, 666);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnSetting.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 256);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(193, 60);
            this.btnSetting.TabIndex = 7;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnTag
            // 
            this.btnTag.FlatAppearance.BorderSize = 0;
            this.btnTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTag.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.btnTag.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnTag.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.btnTag.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTag.Location = new System.Drawing.Point(0, 322);
            this.btnTag.Name = "btnTag";
            this.btnTag.Size = new System.Drawing.Size(193, 60);
            this.btnTag.TabIndex = 6;
            this.btnTag.Text = "Tag";
            this.btnTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTag.UseVisualStyleBackColor = true;
            this.btnTag.Click += new System.EventHandler(this.btnTag_Click);
            // 
            // btnCreateNote
            // 
            this.btnCreateNote.FlatAppearance.BorderSize = 0;
            this.btnCreateNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNote.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.btnCreateNote.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnCreateNote.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.btnCreateNote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreateNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNote.Location = new System.Drawing.Point(0, 190);
            this.btnCreateNote.Name = "btnCreateNote";
            this.btnCreateNote.Size = new System.Drawing.Size(193, 60);
            this.btnCreateNote.TabIndex = 5;
            this.btnCreateNote.Text = "Create Note";
            this.btnCreateNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateNote.UseVisualStyleBackColor = true;
            this.btnCreateNote.Click += new System.EventHandler(this.btnCreateNote_Click);
            // 
            // btnAllNote
            // 
            this.btnAllNote.FlatAppearance.BorderSize = 0;
            this.btnAllNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllNote.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.btnAllNote.IconChar = FontAwesome.Sharp.IconChar.Swatchbook;
            this.btnAllNote.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.btnAllNote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAllNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllNote.Location = new System.Drawing.Point(0, 124);
            this.btnAllNote.Name = "btnAllNote";
            this.btnAllNote.Size = new System.Drawing.Size(193, 60);
            this.btnAllNote.TabIndex = 4;
            this.btnAllNote.Text = "All Notes";
            this.btnAllNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllNote.UseVisualStyleBackColor = true;
            this.btnAllNote.Click += new System.EventHandler(this.btnAllNote_Click);
            // 
            // Panellogo
            // 
            this.Panellogo.Controls.Add(this.pictureBox1);
            this.Panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panellogo.Location = new System.Drawing.Point(0, 0);
            this.Panellogo.Name = "Panellogo";
            this.Panellogo.Size = new System.Drawing.Size(193, 108);
            this.Panellogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.paneltop.Controls.Add(this.pictureBox2);
            this.paneltop.Controls.Add(this.Searchbox);
            this.paneltop.Controls.Add(this.guna2ControlBox2);
            this.paneltop.Controls.Add(this.guna2ControlBox1);
            this.paneltop.Location = new System.Drawing.Point(195, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1055, 62);
            this.paneltop.TabIndex = 1;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(961, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(38, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1005, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(38, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // Searchbox
            // 
            this.Searchbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.Searchbox.BorderRadius = 10;
            this.Searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Searchbox.DefaultText = "";
            this.Searchbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Searchbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Searchbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchbox.DisabledState.Parent = this.Searchbox;
            this.Searchbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchbox.FocusedState.Parent = this.Searchbox;
            this.Searchbox.Font = new System.Drawing.Font("JetBrains Mono", 9.749999F);
            this.Searchbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchbox.HoverState.Parent = this.Searchbox;
            this.Searchbox.Location = new System.Drawing.Point(50, 13);
            this.Searchbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.PasswordChar = '\0';
            this.Searchbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Searchbox.PlaceholderText = "Search Note";
            this.Searchbox.SelectedText = "";
            this.Searchbox.ShadowDecoration.Parent = this.Searchbox;
            this.Searchbox.Size = new System.Drawing.Size(327, 37);
            this.Searchbox.TabIndex = 2;
            this.Searchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(89, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.panelMenu;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.TargetControl = this.paneltop;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1250, 666);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panelMenu.ResumeLayout(false);
            this.Panellogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.FlowLayoutPanel Panellogo;
        private System.Windows.Forms.Panel paneltop;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnTag;
        private FontAwesome.Sharp.IconButton btnCreateNote;
        private FontAwesome.Sharp.IconButton btnAllNote;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox Searchbox;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
    }
}