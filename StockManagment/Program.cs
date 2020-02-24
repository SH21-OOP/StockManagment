using StockManagment.DataExchange;
using StockManagment.StockManagment.Logic;
using System;
using System.Windows.Forms;

namespace StockManagment.StockManagment
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppFields appFields = new AppFields();
            Form window = new Form(appFields);
            StockManager logic = new StockManager(appFields);
            Application.Run(window);
        }
    }
}
