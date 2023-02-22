using Oil_task_database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_task_database.Views
{
    public interface IMainView
    {
        EventHandler<EventArgs> SelectionOilChange { get; set; }
        EventHandler<EventArgs> LoadMain { get; set; }
        EventHandler<EventArgs> LiterChange { get; set; }
        EventHandler<EventArgs> MoneyChange { get; set; }
        Oil SelectedOil { get; }
        List<Oil> Oils { set; }
        string PriceText { get; set; }
        string LiterText { get; set; }
        string MoneyText { get; set; }
        string TotalPaymentText { get; set; }
    }
}
