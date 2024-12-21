namespace LR1
{
    partial class AddUserForm
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
            this.btBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbPassRep = new System.Windows.Forms.TextBox();
            this.tbEMail = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbRole = new System.Windows.Forms.ComboBox();
            this.bindingSourceRole = new System.Windows.Forms.BindingSource(this.components);
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.tbName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRole)).BeginInit();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(13, 14);
            this.btBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(112, 35);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление нового пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Повторите пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Эл. почта:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Телефон:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Имя:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Фамилия:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(468, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Роль:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(468, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Пол:";
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(218, 168);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(185, 26);
            this.tbLog.TabIndex = 11;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(218, 216);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(185, 26);
            this.tbPass.TabIndex = 12;
            // 
            // tbPassRep
            // 
            this.tbPassRep.Location = new System.Drawing.Point(218, 264);
            this.tbPassRep.Name = "tbPassRep";
            this.tbPassRep.PasswordChar = '*';
            this.tbPassRep.Size = new System.Drawing.Size(185, 26);
            this.tbPassRep.TabIndex = 13;
            // 
            // tbEMail
            // 
            this.tbEMail.Location = new System.Drawing.Point(218, 310);
            this.tbEMail.Name = "tbEMail";
            this.tbEMail.Size = new System.Drawing.Size(185, 26);
            this.tbEMail.TabIndex = 14;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(570, 219);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(185, 26);
            this.tbSurname.TabIndex = 15;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(644, 421);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(112, 35);
            this.btAdd.TabIndex = 17;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(218, 360);
            this.tbPhone.Mask = "+7 (000) 000 00-00";
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(185, 26);
            this.tbPhone.TabIndex = 18;
            // 
            // tbRole
            // 
            this.tbRole.DataSource = this.bindingSourceRole;
            this.tbRole.DisplayMember = "Name";
            this.tbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbRole.FormattingEnabled = true;
            this.tbRole.Location = new System.Drawing.Point(570, 270);
            this.tbRole.Name = "tbRole";
            this.tbRole.Size = new System.Drawing.Size(185, 28);
            this.tbRole.TabIndex = 19;
            this.tbRole.ValueMember = "ID";
            // 
            // bindingSourceRole
            // 
            this.bindingSourceRole.DataSource = typeof(LR1.DBContext.Roles);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Checked = true;
            this.rbFemale.Location = new System.Drawing.Point(614, 314);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(98, 24);
            this.rbFemale.TabIndex = 20;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Женщина";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(614, 344);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(94, 24);
            this.rbMale.TabIndex = 21;
            this.rbMale.Text = "Мужчина";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(570, 171);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(185, 26);
            this.tbName.TabIndex = 22;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 470);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.tbRole);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbEMail);
            this.Controls.Add(this.tbPassRep);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbPassRep;
        private System.Windows.Forms.TextBox tbEMail;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.MaskedTextBox tbPhone;
        private System.Windows.Forms.ComboBox tbRole;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.BindingSource bindingSourceRole;
    }
}