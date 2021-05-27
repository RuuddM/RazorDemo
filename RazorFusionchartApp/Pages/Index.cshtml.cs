using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using FusionCharts.DataEngine;
using FusionCharts.Visualization;
using System.Data;

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

            // create data table to store data
            DataTable ChartData = new DataTable();
            // Add columns to data table
            ChartData.Columns.Add("Neigborhood", typeof(System.String));
            ChartData.Columns.Add("Number of listing", typeof(System.Double));
            // Add rows to data table

            ChartData.Rows.Add("Bijlmer-Centrum", 100);
            ChartData.Rows.Add("Bijlmer-Oost", 98);
            ChartData.Rows.Add("Centrum-Oost", 1610);
            ChartData.Rows.Add("Centrum-West", 2179);
            ChartData.Rows.Add("Noord-Oost", 218);
            ChartData.Rows.Add("Noord-West", 262);

            // Create static source with this data table
            StaticSource source = new StaticSource(ChartData);
            // Create instance of DataModel class
            DataModel model = new DataModel();
            // Add DataSource to the DataModel
            model.DataSources.Add(source);


        }
    }
}
