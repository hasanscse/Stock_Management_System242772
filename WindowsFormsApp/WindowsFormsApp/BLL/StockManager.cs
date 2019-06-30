using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWinApp.Repository;
using System.Data;

namespace WindowsFormsApp.BLL
{
    public class StockManager
    {
         
        StockRepository _stockRepository = new StockRepository();
        public bool Insert(Stock stock)
        {

            return _stockRepository.Insert(stock);
        



    }
}
