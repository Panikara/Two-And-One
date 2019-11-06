using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Two_AND_One.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            RegisterDbEntities Dbcontext = new RegisterDbEntities();
            List<tblRegistration> _show = Dbcontext.tblRegistrations.ToList();

            return Json(_show, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Index1()
        {
            RegisterDbEntities Dbcontext = new RegisterDbEntities();
            List<passwordencrp> _show1 = Dbcontext.passwordencrps.ToList();

            return Json(_show1, JsonRequestBehavior.AllowGet);
        }

        //public void TryTO()
        //{
        //    RegisterDbEntities Dbcontext = new RegisterDbEntities();
        //    var sa = Dbcontext.tblRegistrations.ToList();

        //    DataTable dt = new DataTable();
        //    (from rec in Dbcontext.tblRegistrations.AsEnumerable()
        //     select new
        //     {
        //         id = rec.Id,
        //         name = rec.UserName,
        //         password = rec.Password,
        //         email = rec.Email,
        //         address = rec.Address
        //     }).Aggregate(Table,( dt,r) =>
        //                 {
        //                     dt.Rows.Add(r.Id,
        //      r.UserName,
        //          r.Password,
        //        r.Email,
        //          r.Address;
        //                     return dt;
        //                 });
        //    using (XLWorkbook wb = new XLWorkbook())
        //    {
        //        wb.Worksheets.Add(dt, "Customers");

        //        Response.Clear();
        //        Response.Buffer = true;
        //        Response.Charset = "";
        //        Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        //        Response.AddHeader("content-disposition", "attachment;filename=SqlExport.xlsx");
        //        using (MemoryStream MyMemoryStream = new MemoryStream())
        //        {
        //            wb.SaveAs(MyMemoryStream);
        //            MyMemoryStream.WriteTo(Response.OutputStream);
        //            Response.Flush();
        //            Response.End();
        //        }
        //    }
        //}
    }
}












