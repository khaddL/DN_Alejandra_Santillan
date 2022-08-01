using GymManager.DataAccess.Reports;
using LanguageExt.UnitsOfMeasure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Reporting.NETCore;
using System;
using System.IO;
using Wkhtmltopdf.NetCore;

namespace GymManager.web.Controllers
{
    public class ReportsController : Controller
    {
        private readonly IGeneratePdf _generatePdf;
        private readonly IWebHostEnvironment _envitoment;

        public ReportsController(IWebHostEnvironment enviroment, IGeneratePdf generatePdf)
        { 
            _generatePdf = generatePdf;
            _envitoment = enviroment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewMembers()
        {
            string path = System.IO.Path.Combine(_envitoment.ContentRootPath , "Reports\\NewMembers.rdlc");
            Stream reportDefinition = System.IO.File.OpenRead(path);

            LocalReport report = new LocalReport();
            report.EnableExternalImages = true;
            report.LoadReportDefinition(reportDefinition);


            MembersDataSet dataSet = new MembersDataSet();
            Random random = new Random();

            String[] membershipTypes = new string[] { "Basic", "Family", "Premium" };

            for (int i = 0; i < 28; i++)
            { 
                MembersDataSet.MemberRow row = dataSet.Member.NewMemberRow();
                row.Name = $"Member Perez {i}";
                int day = random.Next(1, 10) * -1;
                int membershipIndex = random.Next(0, 2);

                row.RegisteredOn = DateTime.Today.AddDays(day);
                row.MembershipType = membershipTypes[membershipIndex]; 

                dataSet.Member.Rows.Add(row);
            }


            byte[] streamBytes = null;
            string mimeType = "";
            string encoding = "";
            string filenameExtension = "";
            string reportName = "NewMembers";
            string[] streamids = null;
            Warning[] warnings = null;

            report.SetParameters(new ReportParameter[] {new ReportParameter("DateFrom", DateTime.Today.AddDays(-10).ToString() ),
                                 new ReportParameter("DateTo", DateTime.Today.ToString())});

            report.DataSources.Add(new ReportDataSource("Members", (System.Data.DataTable)dataSet.Member));

            streamBytes = report.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);



            return File(streamBytes, mimeType,$"{reportName}.{filenameExtension}"); 
        }
    }
}
