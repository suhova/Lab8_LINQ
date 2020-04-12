using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8_LINQ
{
   /// <summary>
   /// Форма удаления
   /// </summary>
    public partial class Delete : Form
    {
        MainForm context;
        public Delete(MainForm context)
        {
            InitializeComponent();
            this.context = context;
            btnDel.Click += new EventHandler(OnBtnDelClick);
        }
        /// <summary>
        /// Удаление абонента по номеру договора
        /// </summary>
        /// <remarks>При возникновении ошибки на экране появляется соответсвующая надпись</remarks>
        private void OnBtnDelClick(object sender, EventArgs e)
        {
            IEnumerable<XElement> deleteQuery = null;
            try
            {
                XDocument xdoc = XDocument.Load("../../../source.xml");
                deleteQuery = xdoc.Element("subscribers").Elements("subscriber").Where(s => s.Element("contractNum").Value == delTxtBox.Text);

                if (deleteQuery.Count() == 0)
                {
                    MessageBox.Show("Не найден абонент с номером договора: " + delTxtBox.Text, "Ошибка");
                }
                else
                {
                    foreach (var query in deleteQuery)
                    {
                        try
                        {
                            MessageBox.Show("Удалён абонент: \n" + context.getSubsInfo(query), "Удаление...");
                            query.RemoveAll();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Произошла ошибка при удалении.\n" + ex.Message, "Ошибка");
                        }
                    }
                    context.showAll(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не найден абонент с номером договора " + delTxtBox.Text,"Ошибка");
            }
            this.Close();
        }
    }
}
