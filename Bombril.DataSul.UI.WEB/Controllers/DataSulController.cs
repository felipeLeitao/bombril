using Bombril.DataSul.UI.WEB.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bombril.DataSul.UI.WEB.Controllers
{
    public class DataSulController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(PlanilhaMOD model)
        {
            ExcelPackage package = new ExcelPackage(model.File.InputStream);

            ExcelWorksheet workSheet = package.Workbook.Worksheets.First();

            for (int i = workSheet.Dimension.Start.Column; i <= workSheet.Dimension.End.Column; i++)
            {
                for (int j = workSheet.Dimension.Start.Row; j <= workSheet.Dimension.End.Row; j++)
                {
                    var valor = workSheet.Cells[i, j].Value;
                }
            }

            return View();
        }


    }
}