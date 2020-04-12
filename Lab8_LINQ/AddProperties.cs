using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8_LINQ
{
    /// <summary>
    /// Форма добавления
    /// </summary>
    public partial class AddProperties : Form
    {
        MainForm context;
        public AddProperties(MainForm context)
        {
            InitializeComponent();
            this.context = context;
            btnAdd.Click += new EventHandler(OnBtnAddClick);
        }
        /// <summary>
        /// Добавление новго абонента в файл и вывод информации о нём на экран
        /// </summary>
        /// <remarks>При возникновении ошибки на экране появляется соответсвующая надпись</remarks>
        private void OnBtnAddClick(object sender, EventArgs e)
        {
            if (surnameTxtBox.Text != "" && districtTxtBox.Text != ""
                && addressTxtBox.Text != "" && phoneTxtBox.Text != ""
                && installPaymentTxtBox.Text != "" && contractNumTxtBox.Text != ""
                && contractDateTxtBox.Text != "" && monthlyFeeTxtBox.Text != "")
            {
               string result = "Фамилия: " + surnameTxtBox.Text + Environment.NewLine +
                    "Район: " + districtTxtBox.Text + Environment.NewLine +
                    "Адрес: " + addressTxtBox.Text + Environment.NewLine +
                    "Телефон: " + phoneTxtBox.Text + Environment.NewLine +
                    "Номер договора: " + contractNumTxtBox.Text + Environment.NewLine +
                    "Оплата установки: " + installPaymentTxtBox.Text + Environment.NewLine +
                    "Дата подписания договора: " + contractDateTxtBox.Text + Environment.NewLine +
                    "Абонентская плата: " + monthlyFeeTxtBox.Text + Environment.NewLine +
                    "Дата последнего платежа: " + lastPaymentDayTxtBox.Text + Environment.NewLine + Environment.NewLine;
                try
                {
                    XDocument xdoc = XDocument.Load("../../../source.xml");
                    xdoc.Element("subscribers").Add(new XElement("subscriber",
                        new XElement("surname", surnameTxtBox.Text),
                        new XElement("district", districtTxtBox.Text),
                        new XElement("address", addressTxtBox.Text),
                        new XElement("phone", phoneTxtBox.Text),
                        new XElement("contractNum", contractNumTxtBox.Text),
                        new XElement("installPayment", installPaymentTxtBox.Text),
                        new XElement("contractDate", contractDateTxtBox.Text),
                        new XElement("monthlyFee", monthlyFeeTxtBox.Text),
                        new XElement("lastPaymentDay", lastPaymentDayTxtBox.Text)));
                    context.setText(result);
                } catch
                {
                    MessageBox.Show("Ошибка записи в файл");
                }
            } else
            {
                MessageBox.Show("Ошибка! Некорректные введённые данные.");
            }
            this.Close();
        }
    }
}
