namespace Lab8_LINQ
{
    partial class AddProperties
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

        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox surnameTxtBox;
        private System.Windows.Forms.TextBox districtTxtBox;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.TextBox phoneTxtBox;
        private System.Windows.Forms.TextBox contractNumTxtBox;
        private System.Windows.Forms.TextBox installPaymentTxtBox;
        private System.Windows.Forms.TextBox contractDateTxtBox;
        private System.Windows.Forms.TextBox monthlyFeeTxtBox;
        private System.Windows.Forms.TextBox lastPaymentDayTxtBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label districtLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label contractNumLabel;
        private System.Windows.Forms.Label installPaymentLabel;
        private System.Windows.Forms.Label contractDateLabel;
        private System.Windows.Forms.Label monthlyFeeLabel;
        private System.Windows.Forms.Label lastPaymentDayLabel;
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.surnameTxtBox = new System.Windows.Forms.TextBox();
            this.districtTxtBox = new System.Windows.Forms.TextBox();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.phoneTxtBox = new System.Windows.Forms.TextBox();
            this.contractNumTxtBox = new System.Windows.Forms.TextBox();
            this.installPaymentTxtBox = new System.Windows.Forms.TextBox();
            this.contractDateTxtBox = new System.Windows.Forms.TextBox();
            this.monthlyFeeTxtBox = new System.Windows.Forms.TextBox();
            this.lastPaymentDayTxtBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.districtLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.contractNumLabel = new System.Windows.Forms.Label();
            this.installPaymentLabel = new System.Windows.Forms.Label();
            this.contractDateLabel = new System.Windows.Forms.Label();
            this.monthlyFeeLabel = new System.Windows.Forms.Label();
            this.lastPaymentDayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // surnameLabel
            //
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Width = 150;
            this.surnameLabel.Location = new System.Drawing.Point(20, 10);
            this.surnameLabel.Text = "Фамилия: ";
            // 
            // surnameTxtBox
            // 
            this.surnameTxtBox.Location = new System.Drawing.Point(20, 35);
            this.surnameTxtBox.Name = "surnameTxtBox";
            this.surnameTxtBox.Size = new System.Drawing.Size(350, 22);
            this.surnameTxtBox.TabIndex = 0;
            //
            // districtLabel
            //
            this.districtLabel.Name = "districtLabel";
            this.districtLabel.Width = 150;
            this.districtLabel.Location = new System.Drawing.Point(20, 60);
            this.districtLabel.Text = "Район: ";
            // 
            // districtTxtBox
            // 
            this.districtTxtBox.Location = new System.Drawing.Point(20, 85);
            this.districtTxtBox.Name = "districtTxtBox";
            this.districtTxtBox.Size = new System.Drawing.Size(350, 22);
            this.districtTxtBox.TabIndex = 1;
            //
            // addressLabel
            //
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Width = 150;
            this.addressLabel.Location = new System.Drawing.Point(20, 110);
            this.addressLabel.Text = "Адрес: ";
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(20, 135);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(350, 22);
            this.addressTxtBox.TabIndex = 2;
            //
            // phoneLabel
            //
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Width = 150;
            this.phoneLabel.Location = new System.Drawing.Point(20, 160);
            this.phoneLabel.Text = "Номер телефона: ";
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Location = new System.Drawing.Point(20, 185);
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(350, 22);
            this.phoneTxtBox.TabIndex = 3;
            //
            // contractNumLabel
            //
            this.contractNumLabel.Name = "contractNumLabel";
            this.contractNumLabel.Width = 150;
            this.contractNumLabel.Location = new System.Drawing.Point(20, 210);
            this.contractNumLabel.Text = "Номер контракта: ";
            // 
            // contractNumTxtBox
            // 
            this.contractNumTxtBox.Location = new System.Drawing.Point(20, 235);
            this.contractNumTxtBox.Name = "contractNumTxtBox";
            this.contractNumTxtBox.Size = new System.Drawing.Size(350, 22);
            this.contractNumTxtBox.TabIndex = 4;
            //
            // installPaymentLabel
            //
            this.installPaymentLabel.Name = "installPaymentLabel";
            this.installPaymentLabel.Width = 300;
            this.installPaymentLabel.Location = new System.Drawing.Point(20, 260);
            this.installPaymentLabel.Text = "Оплата установки: ";
            // 
            // installPaymentTxtBox
            // 
            this.installPaymentTxtBox.Location = new System.Drawing.Point(20, 285);
            this.installPaymentTxtBox.Name = "installPaymentTxtBox";
            this.installPaymentTxtBox.Size = new System.Drawing.Size(350, 22);
            this.installPaymentTxtBox.TabIndex = 5;
            //
            // contractDateLabel
            //
            this.contractDateLabel.Name = "contractDateLabel";
            this.contractDateLabel.Width = 300;
            this.contractDateLabel.Location = new System.Drawing.Point(20, 310);
            this.contractDateLabel.Text = "Дата подписания контракта: ";
            // 
            // contractDateTxtBox
            // 
            this.contractDateTxtBox.Location = new System.Drawing.Point(20, 335);
            this.contractDateTxtBox.Name = "contractDateTxtBox";
            this.contractDateTxtBox.Size = new System.Drawing.Size(350, 22);
            this.contractDateTxtBox.TabIndex = 6;
            //
            // monthlyFeeLabel
            //
            this.monthlyFeeLabel.Name = "monthlyFeeLabel";
            this.monthlyFeeLabel.Width = 300;
            this.monthlyFeeLabel.Location = new System.Drawing.Point(20, 360);
            this.monthlyFeeLabel.Text = "Абонентская плата: ";
            // 
            // monthlyFeeTxtBox
            // 
            this.monthlyFeeTxtBox.Location = new System.Drawing.Point(20, 385);
            this.monthlyFeeTxtBox.Name = "monthlyFeeTxtBox";
            this.monthlyFeeTxtBox.Size = new System.Drawing.Size(350, 22);
            this.monthlyFeeTxtBox.TabIndex = 7;
            //
            // lastPaymentDayLabel
            //
            this.lastPaymentDayLabel.Name = "lastPaymentDayLabel";
            this.lastPaymentDayLabel.Width = 300;
            this.lastPaymentDayLabel.Location = new System.Drawing.Point(20, 410);
            this.lastPaymentDayLabel.Text = "Дата последней выплаты: ";
            // 
            // lastPaymentDayTxtBox
            // 
            this.lastPaymentDayTxtBox.Location = new System.Drawing.Point(20, 435);
            this.lastPaymentDayTxtBox.Name = "lastPaymentDayTxtBox";
            this.lastPaymentDayTxtBox.Size = new System.Drawing.Size(350, 22);
            this.lastPaymentDayTxtBox.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 470);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 24);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // AddProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.districtLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.contractDateLabel);
            this.Controls.Add(this.installPaymentLabel);
            this.Controls.Add(this.contractNumLabel);
            this.Controls.Add(this.monthlyFeeLabel);
            this.Controls.Add(this.lastPaymentDayLabel);
            this.Controls.Add(this.surnameTxtBox);
            this.Controls.Add(this.districtTxtBox);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.phoneTxtBox);
            this.Controls.Add(this.contractNumTxtBox);
            this.Controls.Add(this.installPaymentTxtBox);
            this.Controls.Add(this.contractDateTxtBox);
            this.Controls.Add(this.monthlyFeeTxtBox);
            this.Controls.Add(this.lastPaymentDayTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddProperties";
            this.Text = "Добавить абонента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}