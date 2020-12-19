
namespace DIgital_Diary.DesignInterface
{
    partial class RegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.RegFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegistrationButton = new Guna.UI2.WinForms.Guna2Button();
            this.RegConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegDateOfBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.GenderButton = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.loginclosed = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(66)))), ((int)(((byte)(123)))));
            this.label1.Location = new System.Drawing.Point(78, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "New user Registration";
            // 
            // RegFullName
            // 
            this.RegFullName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(77)))), ((int)(((byte)(164)))));
            this.RegFullName.BorderRadius = 10;
            this.RegFullName.BorderThickness = 2;
            this.RegFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegFullName.DefaultText = "";
            this.RegFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegFullName.DisabledState.Parent = this.RegFullName;
            this.RegFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegFullName.FocusedState.Parent = this.RegFullName;
            this.RegFullName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RegFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegFullName.HoverState.Parent = this.RegFullName;
            this.RegFullName.Location = new System.Drawing.Point(83, 76);
            this.RegFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegFullName.Name = "RegFullName";
            this.RegFullName.PasswordChar = '\0';
            this.RegFullName.PlaceholderText = "Full Name";
            this.RegFullName.SelectedText = "";
            this.RegFullName.ShadowDecoration.Parent = this.RegFullName;
            this.RegFullName.Size = new System.Drawing.Size(274, 49);
            this.RegFullName.TabIndex = 7;
            // 
            // RegPassword
            // 
            this.RegPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(77)))), ((int)(((byte)(164)))));
            this.RegPassword.BorderRadius = 10;
            this.RegPassword.BorderThickness = 2;
            this.RegPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegPassword.DefaultText = "";
            this.RegPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegPassword.DisabledState.Parent = this.RegPassword;
            this.RegPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegPassword.FocusedState.Parent = this.RegPassword;
            this.RegPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RegPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegPassword.HoverState.Parent = this.RegPassword;
            this.RegPassword.Location = new System.Drawing.Point(83, 253);
            this.RegPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegPassword.Name = "RegPassword";
            this.RegPassword.PasswordChar = '*';
            this.RegPassword.PlaceholderText = "Password";
            this.RegPassword.SelectedText = "";
            this.RegPassword.ShadowDecoration.Parent = this.RegPassword;
            this.RegPassword.Size = new System.Drawing.Size(274, 49);
            this.RegPassword.TabIndex = 11;
            // 
            // RegEmail
            // 
            this.RegEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(77)))), ((int)(((byte)(164)))));
            this.RegEmail.BorderRadius = 10;
            this.RegEmail.BorderThickness = 2;
            this.RegEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegEmail.DefaultText = "";
            this.RegEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegEmail.DisabledState.Parent = this.RegEmail;
            this.RegEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegEmail.FocusedState.Parent = this.RegEmail;
            this.RegEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RegEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegEmail.HoverState.Parent = this.RegEmail;
            this.RegEmail.Location = new System.Drawing.Point(83, 194);
            this.RegEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegEmail.Name = "RegEmail";
            this.RegEmail.PasswordChar = '\0';
            this.RegEmail.PlaceholderText = "Email";
            this.RegEmail.SelectedText = "";
            this.RegEmail.ShadowDecoration.Parent = this.RegEmail;
            this.RegEmail.Size = new System.Drawing.Size(274, 49);
            this.RegEmail.TabIndex = 10;
            // 
            // RegUserName
            // 
            this.RegUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(77)))), ((int)(((byte)(164)))));
            this.RegUserName.BorderRadius = 10;
            this.RegUserName.BorderThickness = 2;
            this.RegUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegUserName.DefaultText = "";
            this.RegUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegUserName.DisabledState.Parent = this.RegUserName;
            this.RegUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegUserName.FocusedState.Parent = this.RegUserName;
            this.RegUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RegUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegUserName.HoverState.Parent = this.RegUserName;
            this.RegUserName.Location = new System.Drawing.Point(83, 135);
            this.RegUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegUserName.Name = "RegUserName";
            this.RegUserName.PasswordChar = '\0';
            this.RegUserName.PlaceholderText = "username";
            this.RegUserName.SelectedText = "";
            this.RegUserName.ShadowDecoration.Parent = this.RegUserName;
            this.RegUserName.Size = new System.Drawing.Size(274, 49);
            this.RegUserName.TabIndex = 12;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BorderColor = System.Drawing.Color.White;
            this.RegistrationButton.BorderRadius = 10;
            this.RegistrationButton.BorderThickness = 2;
            this.RegistrationButton.CheckedState.Parent = this.RegistrationButton;
            this.RegistrationButton.CustomImages.Parent = this.RegistrationButton;
            this.RegistrationButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(77)))), ((int)(((byte)(164)))));
            this.RegistrationButton.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.RegistrationButton.ForeColor = System.Drawing.Color.White;
            this.RegistrationButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(66)))), ((int)(((byte)(123)))));
            this.RegistrationButton.HoverState.Parent = this.RegistrationButton;
            this.RegistrationButton.Location = new System.Drawing.Point(445, 240);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.ShadowDecoration.Parent = this.RegistrationButton;
            this.RegistrationButton.Size = new System.Drawing.Size(274, 49);
            this.RegistrationButton.TabIndex = 14;
            this.RegistrationButton.Text = "Registration";
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // RegConfirmPassword
            // 
            this.RegConfirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(77)))), ((int)(((byte)(164)))));
            this.RegConfirmPassword.BorderRadius = 10;
            this.RegConfirmPassword.BorderThickness = 2;
            this.RegConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegConfirmPassword.DefaultText = "";
            this.RegConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegConfirmPassword.DisabledState.Parent = this.RegConfirmPassword;
            this.RegConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegConfirmPassword.FocusedState.Parent = this.RegConfirmPassword;
            this.RegConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RegConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegConfirmPassword.HoverState.Parent = this.RegConfirmPassword;
            this.RegConfirmPassword.Location = new System.Drawing.Point(83, 312);
            this.RegConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegConfirmPassword.Name = "RegConfirmPassword";
            this.RegConfirmPassword.PasswordChar = '*';
            this.RegConfirmPassword.PlaceholderText = "Confirm Password";
            this.RegConfirmPassword.SelectedText = "";
            this.RegConfirmPassword.ShadowDecoration.Parent = this.RegConfirmPassword;
            this.RegConfirmPassword.Size = new System.Drawing.Size(274, 49);
            this.RegConfirmPassword.TabIndex = 15;
            this.RegConfirmPassword.TextChanged += new System.EventHandler(this.RegConfirmPassword_TextChanged);
            this.RegConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.RegConfirmPassword_Validating);
            this.RegConfirmPassword.Validated += new System.EventHandler(this.RegConfirmPassword_TextChanged);
            // 
            // RegDateOfBirthDate
            // 
            this.RegDateOfBirthDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(166)))));
            this.RegDateOfBirthDate.BorderRadius = 10;
            this.RegDateOfBirthDate.BorderThickness = 2;
            this.RegDateOfBirthDate.CheckedState.Parent = this.RegDateOfBirthDate;
            this.RegDateOfBirthDate.FillColor = System.Drawing.Color.White;
            this.RegDateOfBirthDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RegDateOfBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.RegDateOfBirthDate.HoverState.Parent = this.RegDateOfBirthDate;
            this.RegDateOfBirthDate.Location = new System.Drawing.Point(445, 63);
            this.RegDateOfBirthDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.RegDateOfBirthDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.RegDateOfBirthDate.Name = "RegDateOfBirthDate";
            this.RegDateOfBirthDate.ShadowDecoration.Parent = this.RegDateOfBirthDate;
            this.RegDateOfBirthDate.Size = new System.Drawing.Size(274, 49);
            this.RegDateOfBirthDate.TabIndex = 16;
            this.RegDateOfBirthDate.Value = new System.DateTime(2020, 12, 19, 23, 9, 44, 316);
            // 
            // GenderButton
            // 
            this.GenderButton.BackColor = System.Drawing.Color.Transparent;
            this.GenderButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(166)))));
            this.GenderButton.BorderRadius = 10;
            this.GenderButton.BorderThickness = 2;
            this.GenderButton.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GenderButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderButton.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderButton.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderButton.FocusedState.Parent = this.GenderButton;
            this.GenderButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GenderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.GenderButton.HoverState.Parent = this.GenderButton;
            this.GenderButton.ItemHeight = 45;
            this.GenderButton.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.GenderButton.ItemsAppearance.Parent = this.GenderButton;
            this.GenderButton.Location = new System.Drawing.Point(445, 139);
            this.GenderButton.Name = "GenderButton";
            this.GenderButton.ShadowDecoration.Parent = this.GenderButton;
            this.GenderButton.Size = new System.Drawing.Size(274, 51);
            this.GenderButton.StartIndex = 0;
            this.GenderButton.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(465, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Birth Of Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(465, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Gender";
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(699, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(38, 29);
            this.guna2ControlBox2.TabIndex = 21;
            // 
            // loginclosed
            // 
            this.loginclosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginclosed.BackColor = System.Drawing.Color.Transparent;
            this.loginclosed.FillColor = System.Drawing.Color.Transparent;
            this.loginclosed.HoverState.Parent = this.loginclosed;
            this.loginclosed.IconColor = System.Drawing.Color.Black;
            this.loginclosed.Location = new System.Drawing.Point(743, 3);
            this.loginclosed.Name = "loginclosed";
            this.loginclosed.ShadowDecoration.Parent = this.loginclosed;
            this.loginclosed.Size = new System.Drawing.Size(38, 29);
            this.loginclosed.TabIndex = 20;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeftChanged += new System.EventHandler(this.RegConfirmPassword_TextChanged);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.loginclosed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GenderButton);
            this.Controls.Add(this.RegDateOfBirthDate);
            this.Controls.Add(this.RegConfirmPassword);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.RegUserName);
            this.Controls.Add(this.RegPassword);
            this.Controls.Add(this.RegEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "        ";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox RegFullName;
        private Guna.UI2.WinForms.Guna2TextBox RegPassword;
        private Guna.UI2.WinForms.Guna2TextBox RegEmail;
        private Guna.UI2.WinForms.Guna2TextBox RegUserName;
        private Guna.UI2.WinForms.Guna2Button RegistrationButton;
        private Guna.UI2.WinForms.Guna2TextBox RegConfirmPassword;
        private Guna.UI2.WinForms.Guna2DateTimePicker RegDateOfBirthDate;
        private Guna.UI2.WinForms.Guna2ComboBox GenderButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox loginclosed;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}