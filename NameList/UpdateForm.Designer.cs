namespace NameList
{
    partial class UpdateForm
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
            System.Windows.Forms.Label createdDateTimeLabel;
            System.Windows.Forms.Label departmentIdLabel;
            System.Windows.Forms.Label detailLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label mailAddressLabel;
            System.Windows.Forms.Label personIdLabel;
            System.Windows.Forms.Label personNameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label updatedDateTimeLabel;
            this.createdDateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.departmentIdTextBox = new System.Windows.Forms.TextBox();
            this.detailTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.mailAddressTextBox = new System.Windows.Forms.TextBox();
            this.personIdTextBox = new System.Windows.Forms.TextBox();
            this.personNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.updatedDateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addBt = new System.Windows.Forms.Button();
            createdDateTimeLabel = new System.Windows.Forms.Label();
            departmentIdLabel = new System.Windows.Forms.Label();
            detailLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            mailAddressLabel = new System.Windows.Forms.Label();
            personIdLabel = new System.Windows.Forms.Label();
            personNameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            updatedDateTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // createdDateTimeLabel
            // 
            createdDateTimeLabel.AutoSize = true;
            createdDateTimeLabel.Location = new System.Drawing.Point(37, 233);
            createdDateTimeLabel.Name = "createdDateTimeLabel";
            createdDateTimeLabel.Size = new System.Drawing.Size(55, 12);
            createdDateTimeLabel.TabIndex = 1;
            createdDateTimeLabel.Text = "作成日時:";
            // 
            // createdDateTimeDateTimePicker
            // 
            this.createdDateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personBindingSource, "createdDateTime", true));
            this.createdDateTimeDateTimePicker.Location = new System.Drawing.Point(114, 229);
            this.createdDateTimeDateTimePicker.Name = "createdDateTimeDateTimePicker";
            this.createdDateTimeDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.createdDateTimeDateTimePicker.TabIndex = 2;
            // 
            // departmentIdLabel
            // 
            departmentIdLabel.AutoSize = true;
            departmentIdLabel.Location = new System.Drawing.Point(37, 157);
            departmentIdLabel.Name = "departmentIdLabel";
            departmentIdLabel.Size = new System.Drawing.Size(42, 12);
            departmentIdLabel.TabIndex = 3;
            departmentIdLabel.Text = "部署ID:";
            // 
            // departmentIdTextBox
            // 
            this.departmentIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "departmentId", true));
            this.departmentIdTextBox.Location = new System.Drawing.Point(114, 154);
            this.departmentIdTextBox.Name = "departmentIdTextBox";
            this.departmentIdTextBox.Size = new System.Drawing.Size(200, 19);
            this.departmentIdTextBox.TabIndex = 4;
            // 
            // detailLabel
            // 
            detailLabel.AutoSize = true;
            detailLabel.Location = new System.Drawing.Point(37, 182);
            detailLabel.Name = "detailLabel";
            detailLabel.Size = new System.Drawing.Size(31, 12);
            detailLabel.TabIndex = 5;
            detailLabel.Text = "詳細:";
            // 
            // detailTextBox
            // 
            this.detailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "detail", true));
            this.detailTextBox.Location = new System.Drawing.Point(114, 179);
            this.detailTextBox.Name = "detailTextBox";
            this.detailTextBox.Size = new System.Drawing.Size(200, 19);
            this.detailTextBox.TabIndex = 6;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(37, 30);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(16, 12);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(114, 27);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 19);
            this.idTextBox.TabIndex = 8;
            // 
            // mailAddressLabel
            // 
            mailAddressLabel.AutoSize = true;
            mailAddressLabel.Location = new System.Drawing.Point(37, 107);
            mailAddressLabel.Name = "mailAddressLabel";
            mailAddressLabel.Size = new System.Drawing.Size(71, 12);
            mailAddressLabel.TabIndex = 9;
            mailAddressLabel.Text = "メールアドレス:";
            // 
            // mailAddressTextBox
            // 
            this.mailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "mailAddress", true));
            this.mailAddressTextBox.Location = new System.Drawing.Point(114, 104);
            this.mailAddressTextBox.Name = "mailAddressTextBox";
            this.mailAddressTextBox.Size = new System.Drawing.Size(200, 19);
            this.mailAddressTextBox.TabIndex = 10;
            // 
            // personIdLabel
            // 
            personIdLabel.AutoSize = true;
            personIdLabel.Location = new System.Drawing.Point(37, 55);
            personIdLabel.Name = "personIdLabel";
            personIdLabel.Size = new System.Drawing.Size(42, 12);
            personIdLabel.TabIndex = 11;
            personIdLabel.Text = "社員ID:";
            // 
            // personIdTextBox
            // 
            this.personIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "personId", true));
            this.personIdTextBox.Location = new System.Drawing.Point(114, 52);
            this.personIdTextBox.Name = "personIdTextBox";
            this.personIdTextBox.Size = new System.Drawing.Size(200, 19);
            this.personIdTextBox.TabIndex = 12;
            // 
            // personNameLabel
            // 
            personNameLabel.AutoSize = true;
            personNameLabel.Location = new System.Drawing.Point(37, 82);
            personNameLabel.Name = "personNameLabel";
            personNameLabel.Size = new System.Drawing.Size(31, 12);
            personNameLabel.TabIndex = 13;
            personNameLabel.Text = "名前:";
            // 
            // personNameTextBox
            // 
            this.personNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "personName", true));
            this.personNameTextBox.Location = new System.Drawing.Point(114, 79);
            this.personNameTextBox.Name = "personNameTextBox";
            this.personNameTextBox.Size = new System.Drawing.Size(200, 19);
            this.personNameTextBox.TabIndex = 14;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(37, 132);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(55, 12);
            phoneNumberLabel.TabIndex = 15;
            phoneNumberLabel.Text = "電話番号:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "phoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(114, 129);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(200, 19);
            this.phoneNumberTextBox.TabIndex = 16;
            // 
            // updatedDateTimeLabel
            // 
            updatedDateTimeLabel.AutoSize = true;
            updatedDateTimeLabel.Location = new System.Drawing.Point(37, 208);
            updatedDateTimeLabel.Name = "updatedDateTimeLabel";
            updatedDateTimeLabel.Size = new System.Drawing.Size(55, 12);
            updatedDateTimeLabel.TabIndex = 17;
            updatedDateTimeLabel.Text = "更新日時:";
            // 
            // updatedDateTimeDateTimePicker
            // 
            this.updatedDateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personBindingSource, "updatedDateTime", true));
            this.updatedDateTimeDateTimePicker.Location = new System.Drawing.Point(114, 204);
            this.updatedDateTimeDateTimePicker.Name = "updatedDateTimeDateTimePicker";
            this.updatedDateTimeDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.updatedDateTimeDateTimePicker.TabIndex = 18;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(NameList.Model.Person);
            // 
            // addBt
            // 
            this.addBt.Location = new System.Drawing.Point(239, 254);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(75, 23);
            this.addBt.TabIndex = 19;
            this.addBt.Text = "更新";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 296);
            this.Controls.Add(this.addBt);
            this.Controls.Add(createdDateTimeLabel);
            this.Controls.Add(this.createdDateTimeDateTimePicker);
            this.Controls.Add(departmentIdLabel);
            this.Controls.Add(this.departmentIdTextBox);
            this.Controls.Add(detailLabel);
            this.Controls.Add(this.detailTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(mailAddressLabel);
            this.Controls.Add(this.mailAddressTextBox);
            this.Controls.Add(personIdLabel);
            this.Controls.Add(this.personIdTextBox);
            this.Controls.Add(personNameLabel);
            this.Controls.Add(this.personNameTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(updatedDateTimeLabel);
            this.Controls.Add(this.updatedDateTimeDateTimePicker);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DateTimePicker createdDateTimeDateTimePicker;
        private System.Windows.Forms.TextBox departmentIdTextBox;
        private System.Windows.Forms.TextBox detailTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox mailAddressTextBox;
        private System.Windows.Forms.TextBox personIdTextBox;
        private System.Windows.Forms.TextBox personNameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.DateTimePicker updatedDateTimeDateTimePicker;
        private System.Windows.Forms.Button addBt;
    }
}