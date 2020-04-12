namespace Lab8_LINQ
{
    partial class SearchProperties
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
        private System.Windows.Forms.TextBox paramTxtBox;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label paramLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.ComboBox searchParam;
        private void InitializeComponent()
        {
            this.searchParam = new System.Windows.Forms.ComboBox();
            this.paramTxtBox = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.paramLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // paramLabel
            //
            this.paramLabel.Name = "paramLabel";
            this.paramLabel.Width = 150;
            this.paramLabel.Location = new System.Drawing.Point(20, 10);
            this.paramLabel.Text = "Параметр поиска:";
            //
            // searchParam
            //
            this.searchParam.Name = "searchParam";
            this.searchParam.Width = 270;
            this.searchParam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchParam.Location = new System.Drawing.Point(20, 30);
            this.searchParam.Items.Add("фамилия");
            this.searchParam.Items.Add("район");
            this.searchParam.Items.Add("дата заключения договора");
            this.searchParam.Items.Add("дата последнего платежа");
            //
            // valueLabel
            //
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Width = 150;
            this.valueLabel.Location = new System.Drawing.Point(20, 60);
            this.valueLabel.Text = "Значение: ";
            // 
            // paramTxtBox
            // 
            this.paramTxtBox.Location = new System.Drawing.Point(20, 85);
            this.paramTxtBox.Name = "paramTxtBox";
            this.paramTxtBox.Size = new System.Drawing.Size(270, 22);
            this.paramTxtBox.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(80, 120);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(160, 24);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Показать";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // SearchProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 149);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.searchParam);
            this.Controls.Add(this.paramLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.paramTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SearchProperties";
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}