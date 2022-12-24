using AyatDataAccess;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AyatProcessManager.Custom_Classes;

namespace AyatProcessManager
{
    //  [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false)]

    public class AyatProcessManager
    {
        public static ILog _log = LogManager.GetLogger("HCM");


        #region Base Implimentation
        #region ROLE


        public static List<Role> RoleSelectAll()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.Roles.ToList();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at RoleSelectAll", ex);
                throw;
            }
        }
        public static int RoleInsert(Role role)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spRoleInsert(role.description, role.parent, role.cashRF, role.cashSF, role.loanRF,role.type,role.orderIndex, role.remark).FirstOrDefault().Value;
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at RoleInsert", ex);
                throw;
            }
        }
        public static bool RoleUpdate(Role role)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spRoleUpdate(role.ID, role.description, role.parent, role.cashRF, role.cashSF, role.loanRF, role.type,role.orderIndex, role.remark));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at RoleUpdate", ex);
                throw;
            }
        }
        public static List<spGetRoleByid_Result> GetRoleByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetRoleByid(Id).ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at GetRoleByid", ex);
                throw;
            }
        }
        public static bool DeleteRoleByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteRoleByid(Id));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteRoleByid", ex);
                throw;
            }
        }
        public static bool DeleteAllRole()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteAllRole());
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteAllRole", ex);
                throw;
            }
        }
        #endregion
        #region USERNAME

        public static bool DeleteAllUserName()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteAllUserName());
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteAllUserName", ex);
                throw;
            }
        }
        public static List<UserName> UserNameSelectAll()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spUserNameSelectAll().ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at UserNameSelectAll", ex);
                throw;
            }
        }
        public static bool UserNameInsert(UserName username)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spUserNameInsert(username.empID, username.name, username.password, username.hint, username.isActive, username.remark).FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at UserNameInsert", ex);
                throw;
            }
        }
        public static bool UserNameUpdate(UserName username)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spUserNameUpdate(username.ID, username.empID, username.name, username.password, username.hint, username.isActive, username.remark));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at UserNameUpdate", ex);
                throw;
            }
        }
        public static List<spGetUserNameByid_Result> GetUserNameByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetUserNameByid(Id).ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at GetUserNameByid", ex);
                throw;
            }
        }
        public static bool DeleteUserNameByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteUserNameByid(Id));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteUserNameByid", ex);
                throw;
            }
        }
        #endregion
        #region ROLEINCREMENTS

        public static bool DeleteAllRoleIncrements()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteAllRoleIncrements());
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteAllRoleIncrements", ex);
                throw;
            }
        }

        public static bool DeleteRoleIncrementsByRole(int role)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteRoleIncrementsByRole(role));
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at DeleteAllRoleIncrements", ex);
                throw;
            }
        }

        
        public static List<spRoleIncrementsSelectAll_Result> RoleIncrementsSelectAll()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spRoleIncrementsSelectAll().ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at RoleIncrementsSelectAll", ex);
                throw;
            }
        }
        public static bool RoleIncrementsInsert(RoleIncrement roleincrements)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spRoleIncrementsInsert(roleincrements.roleID, roleincrements.percentage, roleincrements.increment, roleincrements.remark).FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at RoleIncrementsInsert", ex);
                throw;
            }
        }
        public static bool RoleIncrementsInsertList(List<RoleIncrement> roleincrementslist)
        {
            try
            {
                bool ret = false;
                foreach (RoleIncrement roleincrements in roleincrementslist)
                {
                    using (AyatEntities context = new AyatEntities())
                    {
                        ret =  Convert.ToBoolean(context.spRoleIncrementsInsert(roleincrements.roleID, roleincrements.percentage, roleincrements.increment, roleincrements.remark).FirstOrDefault());
                    }
                }
                return ret;
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at RoleIncrementsInsert", ex);
                throw;
            }
        }


        
        public static bool RoleIncrementsUpdate(RoleIncrement roleincrements)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spRoleIncrementsUpdate(roleincrements.ID, roleincrements.roleID, roleincrements.percentage, roleincrements.increment, roleincrements.remark));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at RoleIncrementsUpdate", ex);
                throw;
            }
        }
        public static List<spGetRoleIncrementsByid_Result> GetRoleIncrementsByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetRoleIncrementsByid(Id).ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at GetRoleIncrementsByid", ex);
                throw;
            }
        }

        public static List<RoleIncrement> RoleIncrementsSelectByRole(int role)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spRoleIncrementsSelectByRole(role).ToList();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at RoleIncrementsSelectByRole", ex);
                throw;
            }
        }

        
        public static bool DeleteRoleIncrementsByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteRoleIncrementsByid(Id));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteRoleIncrementsByid", ex);
                throw;
            }
        }
        #endregion
        #region DEVICE

        public static bool DeleteAllDevice()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteAllDevice());
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteAllDevice", ex);
                throw;
            }
        }
        public static List<Device> DeviceSelectAll()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spDeviceSelectAll().ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeviceSelectAll", ex);
                throw;
            }
        }
        public static bool DeviceInsert(Device device)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeviceInsert(device.type, device.deviceName, device.isActive, device.IP, device.connectionType, device.value, device.brand, device.model, device.MAC, device.port, device.remark).FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeviceInsert", ex);
                throw;
            }
        }
        public static bool DeviceUpdate(Device device)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeviceUpdate(device.ID, device.type, device.deviceName, device.isActive, device.IP, device.connectionType, device.value, device.brand, device.model, device.MAC, device.port, device.remark));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeviceUpdate", ex);
                throw;
            }
        }
        public static List<spGetDeviceByid_Result> GetDeviceByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetDeviceByid(Id).ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at GetDeviceByid", ex);
                throw;
            }
        }
        public static List<Device> GetDeviceByName(string name)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetDeviceByName(name).ToList();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at GetDeviceByid", ex);
                throw;
            }
        }



        
        public static bool DeleteDeviceByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteDeviceByid(Id));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteDeviceByid", ex);
                throw;
            }
        }
        #endregion
        #region PAYMENTPLAN

        public static bool DeleteAllPaymentPlan()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteAllPaymentPlan());
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteAllPaymentPlan", ex);
                throw;
            }
        }
        public static List<PaymentPlan> PaymentPlanSelectAll()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spPaymentPlanSelectAll().ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at PaymentPlanSelectAll", ex);
                throw;
            }
        }
        public static bool Insert_Payment_Plan_And_Commission(List<PaymentPlan> paymentPlans, List<Commission_Employee> employees)
        {
            try
            {
                int? payId = 0;
                using (AyatEntities context = new AyatEntities())
                {
                    foreach (PaymentPlan paymentplan in paymentPlans)
                    {
                        payId = context.spPaymentPlanInsert(paymentplan.salesID, paymentplan.description, paymentplan.payRate, paymentplan.payAmount, paymentplan.paidAmount, paymentplan.RemainingAmount, paymentplan.payStatus, paymentplan.commRate, paymentplan.commAmount, paymentplan.remark).FirstOrDefault();
                        if (payId != null && payId > 0)
                        {
                            foreach (Commission_Employee empl in employees)
                            {
                                if (!Convert.ToBoolean(context.spCommissionInsert(paymentplan.salesID, payId, empl.employee_ID, empl.role, empl.commission_Rate, (paymentplan.commAmount * empl.commission_Rate) / 100, (int)Commission_Status.notAvailable, null).FirstOrDefault()))
                                    return false;
                            }
                        }
                        else
                        {
                            context.spDeletePaymentPlanBySalesId(paymentplan.salesID);
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at PaymentPlanListInsert", ex);
                throw;
            }
        }
        public static int? PaymentPlanInsert(PaymentPlan paymentplan)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spPaymentPlanInsert(paymentplan.salesID, paymentplan.description, paymentplan.payRate, paymentplan.payAmount, paymentplan.paidAmount, paymentplan.RemainingAmount, paymentplan.payStatus, paymentplan.commRate, paymentplan.commAmount, paymentplan.remark).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at PaymentPlanInsert", ex);
                throw;
            }
        }
        public static bool PaymentPlanUpdate(PaymentPlan paymentplan)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spPaymentPlanUpdate(paymentplan.ID, paymentplan.salesID, paymentplan.description, paymentplan.payRate, paymentplan.payAmount, paymentplan.paidAmount, paymentplan.RemainingAmount, paymentplan.payStatus, paymentplan.commRate, paymentplan.commAmount, paymentplan.remark));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at PaymentPlanUpdate", ex);
                throw;
            }
        }
        public static List<PaymentPlan> GetPaymentPlanByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetPaymentPlanByid(Id).ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at GetPaymentPlanByid", ex);
                throw;
            }
        }
        public static bool DeletePaymentPlanByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeletePaymentPlanByid(Id));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeletePaymentPlanByid", ex);
                throw;
            }
        }
        public static List<PaymentPlan> GetPaymentPlanBySalesID(int salesID)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetPaymentPlanBySalesID(salesID).ToList();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at GetPaymentPlanByid", ex);
                throw;
            }
        }
        #endregion
        #region ACTIVITYLOG

        public static bool DeleteAllActivityLog()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteAllActivityLog());
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteAllActivityLog", ex);
                throw;
            }
        }
        public static List<spActivityLogSelectAll_Result> ActivityLogSelectAll()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spActivityLogSelectAll().ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at ActivityLogSelectAll", ex);
                throw;
            }
        }
        public static bool ActivityLogInsert(ActivityLog activitylog)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spActivityLogInsert(activitylog.type, activitylog.reference, activitylog.description, activitylog.dateCreated, activitylog.userID, activitylog.deviceID, activitylog.note, activitylog.remark).FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at ActivityLogInsert", ex);
                throw;
            }
        }
        public static bool ActivityLogUpdate(ActivityLog activitylog)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spActivityLogUpdate(activitylog.ID, activitylog.type, activitylog.reference, activitylog.description, activitylog.dateCreated, activitylog.userID, activitylog.deviceID, activitylog.note, activitylog.remark));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at ActivityLogUpdate", ex);
                throw;
            }
        }
        public static List<spGetActivityLogByid_Result> GetActivityLogByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetActivityLogByid(Id).ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at GetActivityLogByid", ex);
                throw;
            }
        }
        public static bool DeleteActivityLogByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteActivityLogByid(Id));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteActivityLogByid", ex);
                throw;
            }
        }
        #endregion
        #region COMPANY

        public static bool DeleteAllCompany()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteAllCompany());
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteAllCompany", ex);
                throw;
            }
        }
        public static List<spCompanySelectAll_Result> CompanySelectAll()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spCompanySelectAll().ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at CompanySelectAll", ex);
                throw;
            }
        }
        public static bool CompanyInsert(Company company)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spCompanyInsert(company.name, company.TIN, company.website, company.branch, company.telephone, company.mobile, company.fax, company.email, company.city, company.subCity, company.woreda, company.houseNo, company.remark).FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at CompanyInsert", ex);
                throw;
            }
        }
        public static bool CompanyUpdate(Company company)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spCompanyUpdate(company.ID, company.name, company.TIN, company.website, company.branch, company.telephone, company.mobile, company.fax, company.email, company.city, company.subCity, company.woreda, company.houseNo, company.remark));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at CompanyUpdate", ex);
                throw;
            }
        }
        public static List<spGetCompanyByid_Result> GetCompanyByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetCompanyByid(Id).ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at GetCompanyByid", ex);
                throw;
            }
        }
        public static bool DeleteCompanyByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteCompanyByid(Id));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteCompanyByid", ex);
                throw;
            }
        }
        #endregion
        #region EMPLOYEE

        public static bool DeleteAllEmployee()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteAllEmployee());
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteAllEmployee", ex);
                throw;
            }
        }
        public static List<Employee> EmployeeSelectAll()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spEmployeeSelectAll().ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at EmployeeSelectAll", ex);
                throw;
            }
        }
        public static bool EmployeeInsert(Employee employee)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spEmployeeInsert(employee.firstName, employee.middleName, employee.lastName, employee.fullName, employee.gender,employee.picture, employee.role, employee.isActive, employee.status, employee.hiredate, employee.dob, employee.city, employee.homephone, employee.mobilephone, employee.email, employee.supervisor, employee.employeeImage, employee.remark).FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at EmployeeInsert", ex);
                throw;
            }
        }
        public static bool EmployeeUpdate(Employee employee)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spEmployeeUpdate(employee.ID, employee.firstName, employee.middleName, employee.lastName, employee.fullName, employee.gender, employee.picture, employee.role, employee.isActive, employee.status, employee.hiredate, employee.dob, employee.city, employee.homephone, employee.mobilephone, employee.email, employee.supervisor, employee.employeeImage, employee.remark));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at EmployeeUpdate", ex);
                throw;
            }
        }
        public static List<Employee> GetEmployeeByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetEmployeeByid(Id).ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at GetEmployeeByid", ex);
                throw;
            }
        }
        public static bool DeleteEmployeeByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteEmployeeByid(Id));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteEmployeeByid", ex);
                throw;
            }
        }
        #endregion
        #region SALES

        public static bool DeleteAllSales()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteAllSales());
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteAllSales", ex);
                throw;
            }
        }
        public static List<Sale> SalesSelectAll()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spSalesSelectAll().ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at SalesSelectAll", ex);
                throw;
            }
        }
        public static int? SalesInsert(Sale sales)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spSalesInsert(sales.code, sales.Type, (Nullable<DateTime>)sales.Date, sales.Total, sales.VAT, sales.Ad, sales.FirstPayment, sales.RegFee, sales.FAName, sales.SAName, sales.EthCity, sales.EthSubCity, sales.EthWoreda, sales.EthHouseNo, sales.EthHomePhone, sales.EthMobileNo, sales.EthEmail, sales.Country, sales.City, sales.POBox, sales.StreetCode, sales.HomePhone, sales.MobilePhone, sales.Email, sales.Site, sales.BuildingNo, sales.FloorNo, sales.HouseNo, sales.HouseType, sales.Area, sales.BedRoom, sales.isActive, sales.status, sales.PrepareuserID, sales.PreparedeviceID, sales.ApproveuserID, sales.ApprovedeviceID, sales.remark).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at SalesInsert", ex);
                throw;
            }
        }
        public static bool SalesUpdate(Sale sales)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spSalesUpdate(sales.ID, sales.code, sales.Type, sales.Date, sales.Total, sales.VAT, sales.Ad, sales.FirstPayment, sales.RegFee, sales.FAName, sales.SAName, sales.EthCity, sales.EthSubCity, sales.EthWoreda, sales.EthHouseNo, sales.EthHomePhone, sales.EthMobileNo, sales.EthEmail, sales.Country, sales.City, sales.POBox, sales.StreetCode, sales.HomePhone, sales.MobilePhone, sales.Email, sales.Site, sales.BuildingNo, sales.FloorNo, sales.HouseNo, sales.HouseType, sales.Area, sales.BedRoom, sales.isActive, sales.status, sales.PrepareuserID, sales.PreparedeviceID, sales.ApproveuserID, sales.ApprovedeviceID, sales.remark));
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at SalesUpdate", ex);
                throw;
            }
        }
        public static List<Sale> GetSalesByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetSalesByid(Id).ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at GetSalesByid", ex);
                throw;
            }
        }
        public static bool DeleteSalesByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteSalesByid(Id));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteSalesByid", ex);
                throw;
            }
        }
        #endregion
        #region COMMISSION

        public static bool DeleteAllCommission()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteAllCommission());
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteAllCommission", ex);
                throw;
            }
        }
        public static List<Commission> CommissionSelectAll()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spCommissionSelectAll().ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at CommissionSelectAll", ex);
                throw;
            }
        }
        public static bool CommissionInsert(Commission commission)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spCommissionInsert(commission.salesID, commission.payID, commission.empID, commission.role, commission.rate, commission.amount, commission.status, commission.remark).FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at CommissionInsert", ex);
                throw;
            }
        }
        public static bool CommissionUpdate(Commission commission)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spCommissionUpdate(commission.ID, commission.salesID, commission.payID, commission.empID, commission.role, commission.rate, commission.amount, commission.status, commission.remark));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at CommissionUpdate", ex);
                throw;
            }
        }
        public static bool Update_Commission_List(List<Commission> commissions)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    foreach (var commission in commissions)
                    {
                        if (!Convert.ToBoolean(context.spCommissionUpdate(commission.ID, commission.salesID, commission.payID, commission.empID, commission.role, commission.rate, commission.amount, commission.status, commission.remark)))
                            return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at CommissionUpdate", ex);
                throw;
            }
        }
        public static List<spGetCommissionByid_Result> GetCommissionByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetCommissionByid(Id).ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at GetCommissionByid", ex);
                throw;
            }
        }
        public static bool DeleteCommissionByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteCommissionByid(Id));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteCommissionByid", ex);
                throw;
            }
        }
        #endregion
        #region PAYMENT

        public static bool DeleteAllPayment()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteAllPayment());
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeleteAllPayment", ex);
                throw;
            }
        }
        public static List<Payment> PaymentSelectAll()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spPaymentSelectAll().ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at PaymentSelectAll", ex);
                throw;
            }
        }
        public static bool PaymentInsert(Payment payment)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spPaymentInsert(payment.salesID, payment.payID, payment.FsNo, payment.recieptNo, payment.date, payment.amount, payment.remark).FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at PaymentInsert", ex);
                throw;
            }
        }
        public static bool PaymentUpdate(Payment payment)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spPaymentUpdate(payment.ID, payment.salesID, payment.payID, payment.FsNo, payment.recieptNo, payment.date, payment.amount, payment.remark));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at PaymentUpdate", ex);
                throw;
            }
        }
        public static List<Payment> GetPaymentByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetPaymentByid(Id).ToList();
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at GetPaymentByid", ex);
                throw;
            }
        }
        public static bool DeletePaymentByid(int Id)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeletePaymentByid(Id));
                }
            }
            catch (Exception ex)
            {
               _log.Error("HCM App Server Failure at DeletePaymentByid", ex);
                throw;
            }
        }
        public static List<Payment> Get_Payment_By_FS_And_Receipt_No(string fs_No, string receipt_No)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.Database.SqlQuery<Payment>(string.Format("SELECT * FROM dbo.Payment WHERE FsNo = '{0}' AND recieptNo = '{1}'", fs_No, receipt_No)).ToList();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at Get_Payment_By_FS_And_Receipt_No", ex);
                throw;
            }
        }
        #endregion
        #endregion

        #region Report
        public static List<Sale> GetSalesListbyFilterCriteria(string Id, string user, string name, string startDateTime, string endDateTime, string site, string building, string floorNo, string houseNo, string houseType, string area, string bedroom, string device, string isactive, string status, string code)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetSalesList(Id, user, name, startDateTime, endDateTime, site, building, floorNo, houseNo, houseType, area, bedroom, device, isactive, status, code).ToList();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at GetSalesByid", ex);
                throw;
            }
        }
        public static List<Commission> GetCommissionBySalesId(int SalesId)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetCommissionBySaleId(SalesId).ToList();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at GetCommissionByid", ex);
                throw;
            }
        }
        public static List<Commission> GetCommissionByPaymentPlanId(int PaymentPlanId)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetCommissionByPaymentPlanId(PaymentPlanId).ToList();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at GetCommissionByid", ex);
                throw;
            }
        }
        public static List<Payment> GetPaymentBySalesid(int SalesId)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetPaymentBySalesId(SalesId).ToList();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at GetPaymentByid", ex);
                throw;
            }
        }
        #endregion

        #region Access


        public static List<Access> AccessPrivilageSelectAll()
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.Accesses.AsNoTracking().ToList();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at AccessPrivilageSelectAll", ex);
                throw;
            }
        }


        public static int AccessPrivilageInsert(Access acc)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spAccessInsert(acc.userID, acc.accessPrivilage, acc.remark).FirstOrDefault().Value;
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at AccessPrivilageInsert", ex);
                throw;
            }
        }


        public static bool accessInsertList(List<Access> accesslist)
        {
            try
            {
                bool ret = false;
                foreach (Access acc in accesslist)
                {
                    using (AyatEntities context = new AyatEntities())
                    {
                        ret = Convert.ToBoolean(context.spAccessInsert(acc.userID, acc.accessPrivilage, acc.remark).FirstOrDefault());
                    }
                }
                return ret;
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at RoleIncrementsInsert", ex);
                throw;
            }
        }
        public static List<Access> GetAccessByUserid(int UserId)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetAccessByuserid(UserId).ToList();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at GetAccessByUserid", ex);
                throw;
            }
        }


        public static bool DeleteAccessPrivilageByUserid(int userId)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spDeleteAccessByuserid(userId));
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at DeleteRoleByid", ex);
                throw;
            }
        }

        #endregion

        #region Dashboard 

        public static List<spGetDashboardStats_Result> GetDashboardBottomData()
        {

            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetDashboardStats().ToList();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at GetDashboardBottomData", ex);
                throw;
            }
        }
        public static List<DashboardGroupResult> GetDashboardSalesData(int GroupNo, DateTime Fromdate, DateTime ToDate)
        {

            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    var value = context.spDashboardGetSalesTotalValue(Fromdate, ToDate, GroupNo).ToList();
                    if (value != null)
                        return value.Select(x => new DashboardGroupResult { GroupNo = x.GroupNo, Total = x.Total }).ToList();
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at GetDashboardBottomData", ex);
                throw;
            }
        }
        public static List<DashboardGroupResult> GetDashboardPaymentData(int GroupNo, DateTime Fromdate, DateTime ToDate)
        {

            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    var value = context.spDashboardGetPaymentTotalValue(Fromdate, ToDate, GroupNo).ToList();
                    if (value != null)
                        return value.Select(x => new DashboardGroupResult { GroupNo = x.GroupNo, Total = x.Total }).ToList();
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at GetDashboardBottomData", ex);
                throw;
            }
        }

        #endregion

        public static List<spGetPaymentListByDateRange_Result> GetSalesPaymentWithRange(string fromdate, string todate)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetPaymentListByDateRange(fromdate, todate).ToList();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at GetSalesPaymentWithRange", ex);
                throw;
            }
        }


        public static List<Sale> GetSalesByCommissionEmployeeId(string empoyeeId)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetSalesByCommissionEmployeeId(empoyeeId).ToList();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at GetSalesByid", ex);
                throw;
            }
        }

        public static List<Commission> GetCommissionByEmployeeId(int EmployeeId)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetCommissionByEmployeeId(EmployeeId).ToList();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at GetCommissionByid", ex);
                throw;
            }
        }
        public static List<spGetCommissionDetail_Result> Get_Commission_Summary(int? employee_ID = null, DateTime? start = null, DateTime? end = null)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetCommissionDetail(employee_ID, start, end).ToList();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at GetCommissionByid", ex);
                throw;
            }
        }
        public static int Commission_Payment_Insert(CommissionPayment comPayment)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spCommissionPaymentInsert(comPayment.IssuedDate, comPayment.PreparedDate, comPayment.ApprovedDate, comPayment.Amount, comPayment.BankPaymentNo, comPayment.BankPaymentDate, comPayment.Status, comPayment.IsVoid, comPayment.PreparingUser, comPayment.PreparingDevice, comPayment.ApprovingUser, comPayment.ApprovingDevice, comPayment.Remark).FirstOrDefault().Value;
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at AccessPrivilageInsert", ex);
                throw;
            }
        }
        public static bool Commission_Payment_Update(CommissionPayment comPayment)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spCommissionPaymentUpdate(comPayment.ID, comPayment.IssuedDate, comPayment.PreparedDate, comPayment.ApprovedDate, comPayment.Amount, comPayment.BankPaymentNo, comPayment.BankPaymentDate, comPayment.Status, comPayment.IsVoid, comPayment.PreparingUser, comPayment.PreparingDevice, comPayment.ApprovingUser, comPayment.ApprovingDevice, comPayment.Remark));
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at AccessPrivilageInsert", ex);
                throw;
            }
        }
        public static int Commission_Payment_Detail_Insert(CommissionPaymentDetail comPaymentDetail)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spCommissionPaymentDetailInsert(comPaymentDetail.CommissionPaymentID, comPaymentDetail.SalesID, comPaymentDetail.EmployeeID, comPaymentDetail.RoleID, comPaymentDetail.CommissionID, comPaymentDetail.Amount, comPaymentDetail.Remark).FirstOrDefault().Value;
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at AccessPrivilageInsert", ex);
                throw;
            }
        }
        public static bool Commission_Payment_Detail_Update(CommissionPaymentDetail comPaymentDetail)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spCommissionPaymentDetailUpdate(comPaymentDetail.ID, comPaymentDetail.CommissionPaymentID, comPaymentDetail.SalesID, comPaymentDetail.EmployeeID, comPaymentDetail.RoleID, comPaymentDetail.CommissionID, comPaymentDetail.Amount, comPaymentDetail.Remark));
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at AccessPrivilageInsert", ex);
                throw;
            }
        }
        public static bool Commission_Payment_Detail_List_Insert(List<CommissionPaymentDetail> comPaymentDetails)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    foreach (var comPaymentDetail in comPaymentDetails)
                    {
                        if (context.spCommissionPaymentDetailInsert(comPaymentDetail.CommissionPaymentID, comPaymentDetail.SalesID, comPaymentDetail.EmployeeID, comPaymentDetail.RoleID, comPaymentDetail.CommissionID, comPaymentDetail.Amount, comPaymentDetail.Remark).FirstOrDefault().Value == 0)
                            return false;
                        context.spCommissionStatusUpdate(comPaymentDetail.CommissionID, (int)Commission_Status.pendingBankPayment);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at CommissionUpdate", ex);
                throw;
            }
        }
        public static List<spGetCommissionPaymentsAndDetails_Result> Get_Commission_Payments_And_Details(int status, DateTime? start = null, DateTime? end = null)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetCommissionPaymentsAndDetails(status, start, end).ToList();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at CommissionUpdate", ex);
                throw;
            }
        }
        public static bool Approve_Commission_Payment(int ID,string bank_Payment_No,DateTime bank_Payment_Date,DateTime approved_Date, int approving_User,int approving_Device)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return Convert.ToBoolean(context.spApproveCommissionPayment(ID, bank_Payment_No, bank_Payment_Date, approved_Date, approving_User, approving_Device).FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at CommissionUpdate", ex);
                throw;
            }
        }
        public static List<spGetPaidCommissionReport_Result> Get_Paid_Commssion_Report(int? employeeID,string bankPaymentNo, DateTime? start = null, DateTime? end = null)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetPaidCommissionReport(employeeID, bankPaymentNo, start, end).ToList();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at CommissionUpdate", ex);
                throw;
            }
        }
        public static List<Sale> Get_Sales_By_Status(int status)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetSalesByStatus(status).ToList();
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at spGetSalesByStatus", ex);
                throw;
            }
        }
        public static bool Approve_Contract_Agreement(int ID)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.Database.ExecuteSqlCommand(string.Format("UPDATE [dbo].[Sales] SET status = 1 WHERE ID = {0}", ID)) > 0;
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at spGetSalesByStatus", ex);
                throw;
            }
        }
        public static List<Sale> Get_Contract_Agreements(string agreement_Code, int? status, DateTime? start, DateTime? end)
        {
            try
            {
                var query = "SELECT * FROM [dbo].[Sales]";
                var filter = "";
                if (!string.IsNullOrEmpty(agreement_Code))
                    filter += string.Format("code = '{0}'", agreement_Code);
                if (status != null)
                {
                    if (!string.IsNullOrEmpty(filter))
                        filter += string.Format(" AND [status] = {0}", status);
                    else
                        filter += string.Format("[status] = {0}", status);
                }
                if (start != null)
                {
                    if (end != null)
                    {
                        if (!string.IsNullOrEmpty(filter))
                            filter += string.Format(" AND DATEDIFF(DAY,[Date],'{0}') <= 0 AND DATEDIFF(DAY,[Date],'{1}') >= 0", start.ToString(), end.ToString());
                        else
                            filter += string.Format("DATEDIFF(DAY,[Date],'{0}') <= 0 AND DATEDIFF(DAY,[Date],'{1}') >= 0", start.ToString(), end.ToString());
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(filter))
                            filter += string.Format(" AND DATEDIFF(DAY,[Date],'{0}') = 0", start.ToString());
                        else
                            filter += string.Format("DATEDIFF(DAY,[Date],'{0}') = 0", start.ToString());
                    }
                }
                if (!string.IsNullOrEmpty(filter))
                {
                    using (AyatEntities context = new AyatEntities())
                    {
                        return context.Database.SqlQuery<Sale>(query + " WHERE " + filter).ToList();
                    }
                }
                else
                {
                    using (AyatEntities context = new AyatEntities())
                    {
                        return context.Database.SqlQuery<Sale>(query).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Error("HCM App Server Failure at spGetSalesByStatus", ex);
                throw;
            }
        }
        public static List<spGetEmployeeCommissionSummary_Result> Get_Employee_Commission_Summary(int employee_ID)
        {
            try
            {
                using (AyatEntities context = new AyatEntities())
                {
                    return context.spGetEmployeeCommissionSummary(employee_ID).ToList();
                }
            }
            catch(Exception ex)
            {
                _log.Error("HCM App Server Failure at spGetSalesByStatus", ex);
                throw;
            }
        }
    }
}
