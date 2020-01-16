using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using FNCORCL2.Oracle;
using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;


namespace FNCORCL2.Controllers
{
    public class FormsController : Controller
    {
        //private readonly OracleConn _orcl;

        //public FormsController(OracleConn orcl)
        //{
        //    _orcl = orcl;
        //}
        private readonly OracleDataContext _db;

        public FormsController(OracleDataContext oracleContext)
        {
            _db = oracleContext;
        }

        //------------------------------------------- OPITO & GWO table ------------------------------------------
        public IActionResult OpitoGWO(string personCode, string unitInstanceCode, string ucaloccCode, string certificateExpiryDate,
            string newCertStartDate, string refreshCertEndDate, string surname, string forename, string createdBy, 
            string createdDate, string updatedBy, string updatedDate)
        {
            //string conString = "User Id=sys;Password=Burnleyfc_12;Data Source=localhost:1521/FNC";
            
            using (OracleConnection cn = new OracleConnection( ))
            {
                OracleDataAdapter da = new OracleDataAdapter();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = cn;
                cmd.InitialLONGFetchSize = 1000;
                cmd.CommandText = _db + "populate_opito_certificates";// Call Oracle stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("PERSON_CODE", OracleDbType.Int32).Value = personCode;
                cmd.Parameters.Add("UI_CODE", OracleDbType.Char).Value = unitInstanceCode;
                cmd.Parameters.Add("UCALOCC_CODE", OracleDbType.Char).Value = ucaloccCode;
                cmd.Parameters.Add("CERTIFICATE_EXPIRY_DATE", OracleDbType.Date).Value = certificateExpiryDate;
                cmd.Parameters.Add("NEW_CERT_START_DATE", OracleDbType.Date).Value = newCertStartDate;
                cmd.Parameters.Add("REFRESH_CERT_END_DATE", OracleDbType.Date).Value = refreshCertEndDate;
                cmd.Parameters.Add("SURNAME", OracleDbType.Char).Value = surname;
                cmd.Parameters.Add("FORENAME", OracleDbType.Char).Value = forename;
                cmd.Parameters.Add("CREATED_BY", OracleDbType.Char).Value = createdBy;
                cmd.Parameters.Add("CREATED_DATE", OracleDbType.Date).Value = createdDate;
                cmd.Parameters.Add("UPDATED_BY", OracleDbType.Char).Value = updatedBy;
                cmd.Parameters.Add("UPDATED_DATE", OracleDbType.Date).Value = updatedDate;
                da.SelectCommand = cmd;
               // DataTable dt = new DataTable();
                //da.Fill(dt);
                return Json(cmd);
            }
        }

        //------------------------------------- Non Opito table-----------------------------------------
        public IActionResult NonOpito(string personCode, string unitInstanceCode, string ucaloccCode, string generateCertificate,
            string newCertStartDate, string refreshCertEndDate, string surname, string forename, string createdBy,
            string createdDate, string updatedBy, string updatedDate)
        {
            string conString = "User Id=sys;Password=Burnleyfc_12;Data Source=localhost:1521/FNC";

            using (OracleConnection cn = new OracleConnection(conString))
            {
                OracleDataAdapter da = new OracleDataAdapter();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = cn;
                cmd.InitialLONGFetchSize = 1000;
                cmd.CommandText = conString + "gen_certificate_no"; // Call Oracle stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("PERSON_CODE", OracleDbType.Int32).Value = personCode;
                cmd.Parameters.Add("UI_CODE", OracleDbType.Char).Value = unitInstanceCode;
                cmd.Parameters.Add("UCALOCC_CODE", OracleDbType.Char).Value = ucaloccCode;
                cmd.Parameters.Add("GENERATE_CERTIFICATE", OracleDbType.Char).Value = generateCertificate;
                cmd.Parameters.Add("SURNAME", OracleDbType.Char).Value = surname;
                cmd.Parameters.Add("FORENAME", OracleDbType.Char).Value = forename;
                cmd.Parameters.Add("CREATED_BY", OracleDbType.Char).Value = createdBy;
                cmd.Parameters.Add("CREATED_DATE", OracleDbType.Date).Value = createdDate;
                cmd.Parameters.Add("UPDATED_BY", OracleDbType.Char).Value = updatedBy;
                cmd.Parameters.Add("UPDATED_DATE", OracleDbType.Date).Value = updatedDate;
                da.SelectCommand = cmd;
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                return Json(cmd.Parameters);
            }
        }
    }

    public class LoadData
    {
    }
}