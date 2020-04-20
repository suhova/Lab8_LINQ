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
        ///  ���� �������
        /// </summary>
        [TestMethod]
        public void TestOneSub()
        {
            string expected = "�������: ���������" + Environment.NewLine +
                    "�����: ����������������" + Environment.NewLine +
                    "�����: ������� ��. ��, �. 14" + Environment.NewLine +
                    "�������: 88005551515" + Environment.NewLine +
                    "����� ��������: 4" + Environment.NewLine +
                    "���� ���������� ��������: 22.02.2003" + Environment.NewLine +
                    "������ ���������: 600" + Environment.NewLine +
                    "����������� �����: 1400" + Environment.NewLine +
                    "���� ���������� �������: 13.02.2016" + Environment.NewLine + Environment.NewLine;
            MainForm.source = "../../../../Lab8_Test/sources/f1.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  ��� ��������
        /// </summary>
        [TestMethod]
        public void TestTwoSub()
        {
            string expected = "�������: ���������" + Environment.NewLine +
                    "�����: ����������������" + Environment.NewLine +
                    "�����: ������� ��. ��, �. 14" + Environment.NewLine +
                    "�������: 88005551515" + Environment.NewLine +
                    "����� ��������: 4" + Environment.NewLine +
                    "���� ���������� ��������: 22.02.2003" + Environment.NewLine +
                    "������ ���������: 600" + Environment.NewLine +
                    "����������� �����: 1400" + Environment.NewLine +
                    "���� ���������� �������: 13.02.2016" + Environment.NewLine + Environment.NewLine +
                    "�������: �������" + Environment.NewLine +
                    "�����: �����������������" + Environment.NewLine +
                    "�����: ��������������� ��., � 10" + Environment.NewLine +
                    "�������: 88005550505" + Environment.NewLine +
                    "����� ��������: 5" + Environment.NewLine +
                    "���� ���������� ��������: 12.10.2004" + Environment.NewLine +
                    "������ ���������: 340" + Environment.NewLine +
                    "����������� �����: 1300" + Environment.NewLine +
                    "���� ���������� �������: 30.12.2016" + Environment.NewLine + Environment.NewLine;
            MainForm.source = "../../../../Lab8_Test/sources/f2.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  0 ���������
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
        ///  ������ ��� �����
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
        ///  ������ ��� ��������� �������
        /// </summary>
        [TestMethod]
        public void TestNoLastPaymentDay()
        {
            string expected = "�������: ���������" + Environment.NewLine +
                  "�����: ����������������" + Environment.NewLine +
                  "�����: ������� ��. ��, �. 14" + Environment.NewLine +
                  "�������: 88005551515" + Environment.NewLine +
                  "����� ��������: 4" + Environment.NewLine +
                  "���� ���������� ��������: 22.02.2003" + Environment.NewLine +
                  "������ ���������: 600" + Environment.NewLine +
                  "����������� �����: 1400" + Environment.NewLine +
                  "���� ���������� �������: " + Environment.NewLine + Environment.NewLine;
            MainForm.source = "../../../../Lab8_Test/sources/f10.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  ������ ��� ������
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
        ///  ������ ��� ������
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
        ///  ������ ��� ��������
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
        ///  ������ ��� ������ ���������
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
        ///  ������ ��� ���� ���������� ���������
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
