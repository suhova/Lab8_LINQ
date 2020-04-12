using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8_LINQ
{
    /// <summary>
    /// Форма поиска
    /// </summary>
    public partial class SearchProperties : Form
    {
        MainForm context;
        public SearchProperties(MainForm context, int paramIndex, string paramValue)
        {
            InitializeComponent();
            this.context = context;
            this.searchParam.SelectedIndex = paramIndex;
            this.paramTxtBox.Text = paramValue;
            btnApply.Click += new System.EventHandler(OnBtnApplyClick);
        }
        /// <summary>
        /// Вызов метода, который выведет на экран найденных абонентов, закрытие формы
        /// </summary>
        private void OnBtnApplyClick(object sender, EventArgs e)
        {
            try
            {
                context.search(searchParam.SelectedIndex, paramTxtBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка:\n" + ex.Message, "Ошибка");
            }
            this.Close();
        }
    }
}
