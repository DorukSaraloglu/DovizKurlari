using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DovizKurlari
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lbxCurrency.Items.Clear();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            XmlElement rooteleman = xmldoc.DocumentElement; //tüm döküman
            XmlNodeList list = rooteleman.GetElementsByTagName("Currency");
            List<Currency> clist = new List<Currency>();
            foreach (var item in list)
            {
                Currency c = new Currency();
                XmlElement currency = (XmlElement)item;
                string name = currency.GetElementsByTagName("Isim").Item(0).InnerText;
                c.CurrencyName = name;
                string purchasePrice = currency.GetElementsByTagName("ForexBuying").Item(0).InnerText;
                string salePrice = currency.GetElementsByTagName("ForexSelling").Item(0).InnerText;
                string unit = currency.GetElementsByTagName("Unit").Item(0).InnerText;

                if (!string.IsNullOrEmpty(purchasePrice))
                {
                    c.PurchasePrice = Convert.ToDecimal(purchasePrice);
                }
                if (!string.IsNullOrEmpty(salePrice))
                {
                    c.SalePrice = Convert.ToDecimal(salePrice);
                }
                if (!string.IsNullOrEmpty(unit))
                {
                    c.Unit = Convert.ToInt32(unit);
                }
                lbxCurrency.Items.Add(c);
                clist.Add(c);
            }
            dgvCurrency.DataSource = clist;
            int i = 0;
            foreach (var item in clist)
            {
                try
                {
                    dgvList.Rows.Add();
                    dgvList.Rows[i].Cells[0].Value = item.CurrencyName;
                    dgvList.Rows[i].Cells[1].Value = item.SalePrice;
                    i++;
                }
                catch (Exception)
                {

                }
            }
        }

        private void lstBoxDoviz_SelectedIndexChanged(object sender, EventArgs e)
        {
            Currency selectedCurrency = (Currency)lbxCurrency.SelectedItem;
            lblPurchase.Text = selectedCurrency.PurchasePrice.ToString();
            lblSale.Text = selectedCurrency.SalePrice.ToString();
            lblUnit.Text = selectedCurrency.Unit.ToString();
        }
    }
}
