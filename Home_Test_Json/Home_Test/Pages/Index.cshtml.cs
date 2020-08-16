using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Home_Test.Services;
using Home_Test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Home_Test.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public Stock_Markert_Service Stock_Market;
        public IEnumerable<Stock_Market> data { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, Stock_Markert_Service stock_market)
        {
            _logger = logger;
            Stock_Market = stock_market;

        }

        public void OnGet()
        {
            data = Stock_Market.Getdata();
        }
    }
}
