using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorFusionchartApp.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger) {
            _logger = logger;
        }

        // create a public property. OnGet method() set the chart configuration json in this property.
        // When the page is being loaded, OnGet method will be  invoked
        public string ChartJson { get; internal set; }
        public void OnGet() {

        }
    }
}
