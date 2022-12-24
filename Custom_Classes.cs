using AyatDataAccess;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyatProcessManager
{
    public class Custom_Classes
    {
        public class Payment_Plan
        {
            public string description { get; set; }
            public decimal payment { get; set; }
            public decimal comission { get; set; }
        }
        public class Role_Employees
        {
            public int role_Id { get; set; }
            public string role_Name { get; set; }
            public decimal role_Commission_Rate { get; set; }
            public int? role_Employee { get; set; }
            public int role_Type { get; set; }
            public int? role_Index { get; set; }
        }
        public class Commission_Employee
        {
            public int employee_ID { get; set; }
            public int role { get; set; }
            public decimal commission_Rate { get; set; }
        }
        public class Employee_Detail
        {
            public int code { get; set; }
            public string FullName { get; set; }
            public string Address { get; set; }
            public string PhoneNo { get; set; }
            public string Email { get; set; }
            public Image Photo { get; set; }
        }
        public enum Commission_Status
        {
            notAvailable = 0,
            available = 1,
            paid = 2,
            pendingBankPayment = 3
        }
        public enum Payment_Status
        {
            notPaid = 0,
            paid = 1
        }
        public enum Commission_Payment_Status
        {
            prepared = 0,
            approved = 1
        }
        public enum Sales_Status
        {
            prepared = 0,
            approved = 1
        }
        public enum Sales_Type
        {
            Cash = 0,
            Credit = 1
        }
        public enum House_Type
        {
            Semi_Finished = 0,
            Fully_Furnished = 1
        }
        public enum Role_Type
        {
            Sales = 0,
            Normal = 1,
            OtherEmployee = 2
        }
        public class AccessPrivilageDTO
        {
            public bool select { get; set; }
            public int id { get; set; }
            public string description { get; set; }
            public string group { get; set; }
        }
        public class DashboardGroupResult
        {
            public int? GroupNo { get; set; }
            public decimal? Total { get; set; }
        }
        public class Commission_Summary
        {
            public bool selected { get; set; }
            public int? Employee_ID { get; set; }
            public string Employee_Name { get; set; }
            public string Employee_Type { get; set; }
            public string Role { get; set; }
            public decimal Commission_Amount { get; set; }
            public List<Commission_Detail> Commision_Details { get; set; }
        }
        public class Commission_Detail
        {
            public int Sales_ID { get; set; }
            public string Sales_Code { get; set; }
            public int commission_ID { get; set; }
            public int commission_Status { get; set; }
            public int? employee_ID { get; set; }
            public int? role_ID { get; set; }
            public string Payment_Description { get; set; }
            public DateTime Payment_Date { get; set; }
            public decimal Commission_Amount { get; set; }
            public decimal Payment_Amount { get; set; }
            public string Receipt_NO { get; set; }
            public string FS_NO { get; set; }
        }
        public class Prepared_Commission
        {
            public int ID { get; set; }
            public DateTime Issued_Date { get; set; }
            public DateTime Prepared_Date { get; set; }
            public decimal Amount { get; set; }
            public string user { get; set; }
            public string deviceName { get; set; }
            public List<Commission_Payment_Detail> Details { get; set; }
        }
        public class Commission_Payment_Detail
        {
            public string Employee_Name { get; set; }
            public string Role { get; set; }
            public decimal Amount { get; set; }
        }
        public class Approved_Commission
        {
            public DateTime Prepared_Date { get; set; }
            public DateTime? Approved_Date { get; set; }
            public decimal Amount { get; set; }
            public string Bank_Payment_No { get; set; }
            public DateTime? Bank_Payment_Date { get; set; }
            public string Prepared_By { get; set; }
            public string Approved_By { get; set; }
            public List<Commission_Payment_Detail> Details { get; set; }
        }
        public class Paid_Commission_Report
        {
            public string Employee_Name { get; set; }
            public string Employee_Type { get; set; }
            public string Role { get; set; }
            public string Bank_Payment_No { get; set; }
            public decimal Amount { get; set; }
            public DateTime? Bank_Payment_Date { get; set; }
            public string User { get; set; }
            public List<Report_Detail> Detail { get; set; }
        }
        public class Report_Detail
        {
            public string Sales_Code { get; set; }
            public string Customer { get; set; }
            public string Site { get; set; }
            public string Building_No { get; set; }
            public string Payment_For { get; set; }
            public decimal Commission_Amount { get; set; }
            public List<Payment_Detail> Payment_Detail { get; set; }
        }
        public class Payment_Detail
        {
            public string FS_No { get; set; }
            public string Receipt_No { get; set; }
            public decimal Paid_Amount { get; set; }   
            public DateTime Payment_Date { get; set; }
        }
        public class Agreement_Info
        {
            public int ID { get; set; }
            public int status { get; set; }
            public string code { get; set; }
            public string customer { get; set; }
            public DateTime prepared_Date { get; set; }
            public string prepared_By { get; set; }
            public string approved_By { get; set; }
            public decimal total_Amount { get; set; }
            public string site { get; set; }
            public string building_No { get; set; }
            public string house_No { get; set; }
        }
    }
}
