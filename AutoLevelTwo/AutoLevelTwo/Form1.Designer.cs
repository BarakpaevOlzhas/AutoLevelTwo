namespace AutoLevelTwo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Admin = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBaseDataSet = new AutoLevelTwo.UserBaseDataSet();
            this.usersTableAdapter = new AutoLevelTwo.UserBaseDataSetTableAdapters.UsersTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button2 = new System.Windows.Forms.Button();
            this.IdDelete = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(79, 79);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 20);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(79, 125);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(79, 177);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(100, 20);
            this.Adres.TabIndex = 2;
            this.Adres.Text = "Adres";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(79, 226);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(100, 20);
            this.Phone.TabIndex = 3;
            this.Phone.Text = "Phone";
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Location = new System.Drawing.Point(79, 272);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(55, 17);
            this.Admin.TabIndex = 4;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(79, 32);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 20);
            this.Id.TabIndex = 6;
            this.Id.Text = "Id";
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource, "Id", true));
            this.listBox1.DataSource = this.usersBindingSource;
            this.listBox1.DisplayMember = "Login";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(443, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(301, 355);
            this.listBox1.TabIndex = 7;
            this.listBox1.ValueMember = "Login";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.userBaseDataSet;
            // 
            // userBaseDataSet
            // 
            this.userBaseDataSet.DataSetName = "UserBaseDataSet";
            this.userBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.userBaseDataSet;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1021, 25);
            this.fillByToolStrip.TabIndex = 8;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IdDelete
            // 
            this.IdDelete.Location = new System.Drawing.Point(257, 226);
            this.IdDelete.Name = "IdDelete";
            this.IdDelete.Size = new System.Drawing.Size(100, 20);
            this.IdDelete.TabIndex = 10;
            this.IdDelete.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 485);
            this.Controls.Add(this.IdDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.CheckBox Admin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.ListBox listBox1;
        private UserBaseDataSet userBaseDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private UserBaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox IdDelete;
    }
}

