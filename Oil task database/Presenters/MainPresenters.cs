using Oil_task_database.Data;
using Oil_task_database.Model;
using Oil_task_database.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_task_database.Presenters
{
    public class MainPresenters
    {
        private readonly IMainView _view;
        private readonly OilContext _db;
        public List<Oil> oils = new List<Oil>()
        {
            new Oil()
            {
                Name="AI-92",
                Price=1
            },
            new Oil()
            {
                Name="AI-95",
                Price=1.8
            },
            new Oil()
            {
                Name="AI-98",
                Price=2
            },
            new Oil()
            {
                Name="Diesel",
                Price=0.8
            }
        };
        /// <summary>
        /// 
        /// </summary>
        /// <param name="view"></param>
        public MainPresenters(IMainView view)
        {
            _view = view;
            _db = new OilContext();
            AddAllOils();
            _view.SelectionOilChange += ViewSelectionOilChange;
            _view.LoadMain += ViewLoadMain;
            _view.MoneyChange += ViewMoneyChange;
            _view.LiterChange += ViewLiterChange;
        }
        private void ViewMoneyChange(object sender, EventArgs e)
        {
            if(_view.MoneyText!= string.Empty)
            {
                _view.TotalPaymentText = double.Parse(_view.MoneyText).ToString();
            }
            else
            {
                _view.TotalPaymentText = "0.0";
            }
        }
        private void ViewLiterChange(object sender, EventArgs e)
        {
            if (_view.LiterText != String.Empty)
            {
                _view.TotalPaymentText = (decimal.Parse(_view.LiterText) * decimal.Parse(_view.PriceText)).ToString();
            }
            else
            {
                _view.TotalPaymentText = "0.00";
            }
        }
        private void AddAllOils()
        {
            if (_db.Oils.Any())
            {
                _db.Oils.AddRange(oils);
                _db.SaveChanges();
            }
        }
        private void ViewLoadMain(object sender, EventArgs e)
        {
            var petroloils = _db.Oils.ToList();
            _view.Oils = petroloils;
        }
        private void ViewSelectionOilChange(object sender, EventArgs e)
        {
            var oil = _view.SelectedOil;
            _view.PriceText = oil.Price.ToString();
        }
    }
}
