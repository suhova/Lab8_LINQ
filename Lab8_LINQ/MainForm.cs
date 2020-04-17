using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8_LINQ
{
    public partial class MainForm : Form
    {
        public int paramIndex = 0;
        public string paramValue = "";
        public string source = "../../../source.xml";
        public MainForm()
        {
            InitializeComponent(); showAll(null, null);
            this.showAllToolStripMenuItem.Click += new EventHandler(showAll);
            this.clearToolStripMenuItem.Click += new EventHandler(clear);
            this.deleteToolStripMenuItem.Click += new EventHandler(OnDelClick);
            this.setSearchToolStripMenuItem.Click += new System.EventHandler(this.OnSetSearchClick);
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnSaveClick);
        }
        /// <summary>
        /// Вывести всех абонентов
        /// </summary>
        public void showAll(object sender, EventArgs e)
        {
            try
            {
                XDocument xdoc = XDocument.Load(source);
                var subscribers = xdoc.Element("subscribers");
                tableView.Text = "";
                foreach (XElement xe in subscribers.Elements("subscriber"))
                {
                    tableView.Text += getSubsInfo(xe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка:\n" + ex.Message, "Ошибка");
                return;
            }
        }
        /// <summary>
        /// Очистить экран
        /// </summary>
        public void clear(object sender, EventArgs e)
        {
            tableView.Text = "";
        }
        /// <summary>
        /// Получение информации об абоненте в виде строки
        /// </summary>
        /// <param name="xe">XElement с информацией об абоненте</param>
        /// <returns>информация об абоненте</returns>
        public string getSubsInfo(XElement xe)
        {
            string info = "";
            XElement surname = xe.Element("surname");
            XElement district = xe.Element("district");
            XElement address = xe.Element("address");
            XElement phone = xe.Element("phone");
            XElement contractNum = xe.Element("contractNum");
            XElement installPayment = xe.Element("installPayment");
            XElement contractDate = xe.Element("contractDate");
            XElement monthlyFee = xe.Element("monthlyFee");
            XElement lastPaymentDay = xe.Element("lastPaymentDay");

            if (surname != null && district != null && address != null && phone != null && installPayment != null && contractNum != null && contractDate != null && monthlyFee != null && lastPaymentDay != null)
            {
                info = "Фамилия: " + surname.Value + Environment.NewLine +
                    "Район: " + district.Value + Environment.NewLine +
                    "Адрес: " + address.Value + Environment.NewLine +
                    "Телефон: " + phone.Value + Environment.NewLine +
                    "Номер договора: " + contractNum.Value + Environment.NewLine +
                    "Дата подписания договора: " + contractDate.Value + Environment.NewLine +
                    "Оплата установки: " + installPayment.Value + Environment.NewLine +
                    "Абонентская плата: " + monthlyFee.Value + Environment.NewLine +
                    "Дата последнего платежа: " + lastPaymentDay.Value + Environment.NewLine + Environment.NewLine;
            }
            return info;
        }
        /// <summary>
        /// Открытие формы с изменением параметров поиска
        /// </summary>
        private void OnSetSearchClick(object sender, EventArgs e)
        {
            SearchProperties setFilterForm = new SearchProperties(this, paramIndex, paramValue);
            setFilterForm.Show();
        }
        /// <summary>
        /// Открытие формы с изменением параметров поиска
        /// </summary>
        private void OnAddClick(object sender, EventArgs e)
        {
            AddProperties addProp = new AddProperties(this);
            addProp.Show();
        }
        /// <summary>
        /// Открытие формы с изменением параметров поиска
        /// </summary>
        private void OnDelClick(object sender, EventArgs e)
        {
            Delete del = new Delete(this);
            del.Show();
        }
        /// <summary>
        /// Сохранение файла данных
        /// </summary>
        private void OnSaveClick(object sender, EventArgs e)
        {
            try
            {
                XDocument.Load(source).Save(source);
                MessageBox.Show("Изменения успешно сохранены!");
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения");
            }
        }
        /// <summary>
        /// Метод, который выводит на экран, найденных абонентов
        /// </summary>
        /// <param name="paramIndex">номер параметра для сравнения</param>
        /// <param name="str">подстрока, по которой нужно найти абонентов</param>
        public void search(int paramIndex, String str)
        {
            paramValue = str;
            this.paramIndex = paramIndex;
            String param = "";
            switch (paramIndex)
            {
                case 0:
                    param = "surname";
                    break;
                case 1:
                    param = "district";
                    break;
                case 2:
                    param = "contractDate";
                    break;
                case 3:
                    param = "lastPaymentDay";
                    break;
            }
            this.tableView.Text = "";
            var res = XDocument.Load(source).Element("subscribers").Elements("subscriber").Where(s => s.Element(param).Value.ToLower().Contains(str.ToLower()));
            foreach (XElement xe in res)
            {
                this.tableView.Text += getSubsInfo(xe);
            }
        }
        public void setText(string str)
        {
            tableView.Text = str;
        }
    }
}
