using Lab8_LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Lab8_Test
{
    [TestClass]
    public class MainTest
    {
        /// <summary>
        ///  Один абонент
        /// </summary>
        [TestMethod]
        public void TestOneSub()
        {
            string expected = "Фамилия: Квашонкин" + Environment.NewLine +
                    "Район: Василеостровский" + Environment.NewLine +
                    "Адрес: Большой пр. ВО, д. 14" + Environment.NewLine +
                    "Телефон: 88005551515" + Environment.NewLine +
                    "Номер договора: 4" + Environment.NewLine +
                    "Дата подписания договора: 22.02.2003" + Environment.NewLine +
                    "Оплата установки: 600" + Environment.NewLine +
                    "Абонентская плата: 1400" + Environment.NewLine +
                    "Дата последнего платежа: 13.02.2016" + Environment.NewLine + Environment.NewLine;
            MainForm.source = "../../../../Lab8_Test/sources/f1.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  Два абонента
        /// </summary>
        [TestMethod]
        public void TestTwoSub()
        {
            string expected = "Фамилия: Квашонкин" + Environment.NewLine +
                    "Район: Василеостровский" + Environment.NewLine +
                    "Адрес: Большой пр. ВО, д. 14" + Environment.NewLine +
                    "Телефон: 88005551515" + Environment.NewLine +
                    "Номер договора: 4" + Environment.NewLine +
                    "Дата подписания договора: 22.02.2003" + Environment.NewLine +
                    "Оплата установки: 600" + Environment.NewLine +
                    "Абонентская плата: 1400" + Environment.NewLine +
                    "Дата последнего платежа: 13.02.2016" + Environment.NewLine + Environment.NewLine +
                    "Фамилия: Бухаров" + Environment.NewLine +
                    "Район: Красногвардейский" + Environment.NewLine +
                    "Адрес: Среднеохтинский пр., д 10" + Environment.NewLine +
                    "Телефон: 88005550505" + Environment.NewLine +
                    "Номер договора: 5" + Environment.NewLine +
                    "Дата подписания договора: 12.10.2004" + Environment.NewLine +
                    "Оплата установки: 340" + Environment.NewLine +
                    "Абонентская плата: 1300" + Environment.NewLine +
                    "Дата последнего платежа: 30.12.2016" + Environment.NewLine + Environment.NewLine;
            MainForm.source = "../../../../Lab8_Test/sources/f2.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  0 абонентов
        /// </summary>
        [TestMethod]
        public void TestNoSub()
        {
            string expected = "";
            MainForm.source = "../../../../Lab8_Test/sources/f3.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  Абоент без имени
        /// </summary>
        [TestMethod]
        public void TestNoName()
        {
            string expected = "";
            MainForm.source = "../../../../Lab8_Test/sources/f4.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  Абоент без последней выплаты
        /// </summary>
        [TestMethod]
        public void TestNoLastPaymentDay()
        {
            string expected = "Фамилия: Квашонкин" + Environment.NewLine +
                  "Район: Василеостровский" + Environment.NewLine +
                  "Адрес: Большой пр. ВО, д. 14" + Environment.NewLine +
                  "Телефон: 88005551515" + Environment.NewLine +
                  "Номер договора: 4" + Environment.NewLine +
                  "Дата подписания договора: 22.02.2003" + Environment.NewLine +
                  "Оплата установки: 600" + Environment.NewLine +
                  "Абонентская плата: 1400" + Environment.NewLine +
                  "Дата последнего платежа: " + Environment.NewLine + Environment.NewLine;
            MainForm.source = "../../../../Lab8_Test/sources/f10.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  Абоент без района
        /// </summary>
        [TestMethod]
        public void TestNoDistrict()
        {
            string expected = "";
            MainForm.source = "../../../../Lab8_Test/sources/f5.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  Абоент без адреса
        /// </summary>
        [TestMethod]
        public void TestNoAddress()
        {
            string expected = "";
            MainForm.source = "../../../../Lab8_Test/sources/f6.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  Абоент без телефона
        /// </summary>
        [TestMethod]
        public void TestNoPhone()
        {
            string expected = "";
            MainForm.source = "../../../../Lab8_Test/sources/f7.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  Абоент без номера контракта
        /// </summary>
        [TestMethod]
        public void TestNoContractNum()
        {
            string expected = "";
            MainForm.source = "../../../../Lab8_Test/sources/f8.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  Абоент без даты подписания контракта
        /// </summary>
        [TestMethod]
        public void TestNoContractDate()
        {
            string expected = "";
            MainForm.source = "../../../../Lab8_Test/sources/f9.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
    }
}
