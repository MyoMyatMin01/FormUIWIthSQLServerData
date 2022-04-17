namespace FormUI
{
    partial class Dashboard
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
            this.lastName = new System.Windows.Forms.Label();
            this.idInput = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastName.Location = new System.Drawing.Point(82, 120);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(79, 20);
            this.lastName.TabIndex = 1;
            this.lastName.Text = "Last Name";
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(211, 48);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(152, 23);
            this.idInput.TabIndex = 2;
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertButton.Location = new System.Drawing.Point(263, 279);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(100, 34);
            this.insertButton.TabIndex = 3;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(115, 163);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(46, 20);
            this.email.TabIndex = 4;
            this.email.Text = "Email";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phone.Location = new System.Drawing.Point(111, 213);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(50, 20);
            this.phone.TabIndex = 5;
            this.phone.Text = "Phone";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstName.Location = new System.Drawing.Point(81, 86);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(80, 20);
            this.firstName.TabIndex = 6;
            this.firstName.Text = "First Name";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Id.Location = new System.Drawing.Point(137, 47);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(24, 20);
            this.Id.TabIndex = 7;
            this.Id.Text = "ID";
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(263, 83);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(100, 23);
            this.firstNameInput.TabIndex = 8;
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(263, 164);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(100, 23);
            this.emailInput.TabIndex = 9;
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(263, 117);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(100, 23);
            this.lastNameInput.TabIndex = 10;
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(263, 213);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(100, 23);
            this.phoneInput.TabIndex = 11;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 433);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.lastName);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lastName;
        private TextBox idInput;
        private Button insertButton;
        private Label email;
        private Label phone;
        private Label firstName;
        private Label Id;
        private TextBox firstNameInput;
        private TextBox emailInput;
        private TextBox lastNameInput;
        private TextBox phoneInput;
    }
}