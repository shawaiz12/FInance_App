using Finance_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance_app.Interfaces
{
    public interface IFMPServince
    {
        Task<Stock> FindStockBySymbolAsync(string symbol);
    }
}
