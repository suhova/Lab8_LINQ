namespace Lab8_LINQ
{
    partial class Delete
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
        private System.Windows.Forms.TextBox delTxtBox;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label delLabel;
        private void InitializeComponent()
        {
            this.delTxtBox = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.delLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // delLabel
            //
            this.delLabel.Name = "delLabel";
            this.delLabel.Width = 270;
            this.delLabel.Location = new System.Drawing.Point(20, 10);
            this.delLabel.Text = "Введите номер договора абонента:";
            // 
            // delTxtBox
            // 
            this.delTxtBox.Location = new System.Drawing.Point(20, 40);
            this.delTxtBox.Name = "delTxtBox";
            this.delTxtBox.Size = new System.Drawing.Size(310, 22);
            this.delTxtBox.TabIndex = 0;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(80, 80);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(180, 24);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 120);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.delLabel);
            this.Controls.Add(this.delTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Delete";
            this.Text = "Удаление абонента";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}