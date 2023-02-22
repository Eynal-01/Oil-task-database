using Oil_task_database.Model;
using Oil_task_database.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oil_task_database
{
    public partial class Form1 : Form, IMainView
    {
        public Form1()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> SelectionOilChange { get; set; }
        public EventHandler<EventArgs> LoadMain { get; set; }
        public EventHandler<EventArgs> LiterChange { get; set; }
        public EventHandler<EventArgs> MoneyChange { get; set; }

        public Oil SelectedOil
        {
            get
            {
                return OilscomboBox.SelectedItem as Oil;
            }
        }

        public List<Oil> Oils
        {
            set
            {
                OilscomboBox.DataSource = null;
                OilscomboBox.DataSource = value;
            }
        }
        public string PriceText { get => PriceLbl.Text; set => PriceLbl.Text=value; }
        public string LiterText { get => LiterTxtb.Text; set => LiterTxtb.Text=value; }
        public string MoneyText { get => MoneyTxtb.Text; set => MoneyTxtb.Text=value; }
        public string TotalPaymentText { get => MustPayLbl.Text; set => MustPayLbl.Text=value; }

        private void OilscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectionOilChange.Invoke(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMain.Invoke(sender, e);
        }

        private void LiterTxtb_TextChanged(object sender, EventArgs e)
        {
            LiterChange.Invoke(sender, e);
        }

        private void MoneyTxtb_TextChanged(object sender, EventArgs e)
        {
            MoneyChange.Invoke(sender, e);
        }

        private void PriceLbl_TextChanged(object sender, EventArgs e)
        {
            MoneyChange.Invoke(sender, e);
        }

        public bool Money { get; set; }

        private void WithMoneyRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!Money)
            {
                MoneyTxtb.Enabled = true;
            }
            else
            {
                MoneyTxtb.Enabled = false;
            }
            Money = !Money;
        }

        public bool Liter { get; set; }

        private void WithLiterRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!Liter)
            {
                LiterTxtb.Enabled = true;
            }
            else
            {
                LiterTxtb.Enabled = false;
            }
            Liter = !Liter;
        }
    }
}
