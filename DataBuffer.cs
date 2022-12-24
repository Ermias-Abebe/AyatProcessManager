using AyatDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AyatProcessManager.Custom_Classes;

namespace AyatProcessManager
{
    public class DataBuffer
    {
        public static List<Role> RoleList { get; set; }
        public static List<Employee> EmployeeList { get; set; }
        public static List<UserName> UserNameList { get; set; }
        public static UserName thisUser { get; set; }
        public static List<RoleIncrement> RoleIncrementList { get; set; }
        public static List<Device> DeviceList { get; set; }
        public static Device thisDevice { get; set; }
        public static List<Company> CompanyList { get; set; }
        public static List<Access> AccessesList { get; set; }
        public static List<Access> thisUserAccessPrivilages { get; set; }

        private static DateTime TrialExpiryDateTime = Convert.ToDateTime("1/19/2022");

        public static bool CheckTrialDateExpiry()
        {
            if (DateTime.Now > TrialExpiryDateTime)
            {
                return false;
            }
            return true;
        }
        public static void GetBufferData()
        {
            RoleList = AyatProcessManager.RoleSelectAll();
            EmployeeList = AyatProcessManager.EmployeeSelectAll();
            UserNameList = AyatProcessManager.UserNameSelectAll();
            DeviceList = AyatProcessManager.DeviceSelectAll();
            AccessesList = AyatProcessManager.AccessPrivilageSelectAll();
        }
        #region Access Privilage 
        public static List<AccessPrivilageDTO> AccessPrivilageDTOList = new List<AccessPrivilageDTO>()
            {
                    new AccessPrivilageDTO()
                    {
                        id = 1,
                        description="Full Access",
                        group ="System Access"

                    },
                    new AccessPrivilageDTO()
                    {
                        id = 2,
                        description="Sales Encoder",
                        group ="System Access"

                    },
                    new AccessPrivilageDTO()
                    {
                        id = 3,
                        description="Commission",
                        group ="System Access"

                    },
                    new AccessPrivilageDTO()
                    {
                        id = 4,
                        description="Payment Processor",
                        group ="System Access"
                     },
                    new AccessPrivilageDTO()
                    {
                        id = 5,
                        description="Report",
                        group ="System Access"
                     },
                    new AccessPrivilageDTO()
                    {
                        id = 6,
                        description="Dashboard Sales Analysis",
                        group ="Dashboard Access"

                    }

            };
        #endregion



    }
}
