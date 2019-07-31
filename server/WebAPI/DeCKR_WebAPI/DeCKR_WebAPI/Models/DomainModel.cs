using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

/*****************************************************
* Project Name: DeCKR                                *
* Date: 07/01/2019                                   *
* Course: CSC 687 - Computer Science Project II      *
* Instructor: Mudasser Wyne                          *
******************************************************/
namespace DeCKR_WebAPI.Models
{
    public class DomainModel
    {
        /// <summary>
        /// Returns user with the specified userId
        /// </summary>
        /// <param name="EmployeeId">EmployeeId</param>
        /// <returns>user model object</returns>
        public UserModel GetUser(int EmployeeId)
        {
            UserModel user = new UserModel();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetUser";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@EmployeeId", EmployeeId));
                    SqlDataReader dr=cmd.ExecuteReader(CommandBehavior.Default);
                    while(dr.Read())
                    {
                        user.EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
                        user.Name = Convert.ToString(dr["Name"]);
                        user.JobRole = Convert.ToString(dr["JobRoleName"]);
                        user.Department = Convert.ToString(dr["DepartmentName"]);
                        user.EmailAddress= Convert.ToString(dr["EmailAddress"]);
                        user.UserType = Convert.ToString(dr["UserType"]);
                    }

                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return user;
        }

        public UserModel GetUserByUserName(string userName)
        {
            UserModel user = new UserModel();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetUserByName";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@userName", userName));
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        user.EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
                        user.Name = Convert.ToString(dr["Name"]);
                        user.JobRole = Convert.ToString(dr["JobRoleName"]);
                        user.Department = Convert.ToString(dr["DepartmentName"]);
                        user.EmailAddress = Convert.ToString(dr["EmailAddress"]);
                        user.UserType = Convert.ToString(dr["UserType"]);
                    }

                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return user;
        }

        /// <summary>
        /// Returns user with the specified userId
        /// </summary>
        /// <param name="EmployeeId">EmployeeId</param>
        /// <returns>user model object</returns>
        public UserModel GetUserLogin(int EmployeeId)
        {
            UserModel user = new UserModel();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetUser";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@EmployeeId", EmployeeId));
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        user.EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
                        user.Name = Convert.ToString(dr["Name"]);
                        user.JobRole = Convert.ToString(dr["JobRoleName"]);
                        user.Department = Convert.ToString(dr["DepartmentName"]);
                        user.EmailAddress = Convert.ToString(dr["EmailAddress"]);
                    }

                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return user;
        }

        /// <summary>
        /// Returns users list
        /// </summary>
        /// <returns>List of UserModel</returns>
        public List<UserModel> GetUsers()
        {
            List<UserModel> users = new List<UserModel>();
            UserModel user;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetUser";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                     SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        user = new UserModel();
                        user.EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
                        user.Name = Convert.ToString(dr["Name"]);
                        user.JobRole = Convert.ToString(dr["JobRoleName"]);
                        user.Department = Convert.ToString(dr["DepartmentName"]);
                        user.EmailAddress = Convert.ToString(dr["EmailAddress"]);
                        users.Add(user);
                    }

                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return users;
        }

        /// <summary>
        /// Returns list of users in a department
        /// </summary>
        /// <param name="departmentID">DepartmentID</param>
        /// <returns>List of UserModel object</returns>
        public List<UserModel> GetDepartmentUsers(int departmentID)
        {
            List<UserModel> users = new List<UserModel>();
            UserModel user;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetDepartmentUser";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@DepartmentID", departmentID));
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        user = new UserModel();
                        user.EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
                        user.Name = Convert.ToString(dr["Name"]);
                        user.JobRole = Convert.ToString(dr["JobRoleName"]);
                        user.Department = Convert.ToString(dr["DepartmentName"]);
                        user.EmailAddress = Convert.ToString(dr["EmailAddress"]);
                        
                        users.Add(user);
                    }
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return users;
        }

        /// <summary>
        /// Sets the password for a user
        /// </summary>
        /// <param name="employeeID">employeeID</param>
        /// <param name="passwordHash">password hash</param>
        /// <param name="salt">salt</param>
        /// <returns>password set result status</returns>
        public bool SetPassword (int employeeID, string passwordHash, string salt)
        {
            bool result = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "SetPassword";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@UserId", employeeID));
                    cmd.Parameters.Add(new SqlParameter("@PasswordHash", passwordHash));
                    cmd.Parameters.Add(new SqlParameter("@Salt", salt));
                    cmd.ExecuteNonQuery();
                    result = true;
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// retruns all security groups
        /// </summary>
        /// <returns>List of SecurityGroupModel objects</returns>
        public List<SecurityGroupModel> GetSecurityGroups()
        {
            List<SecurityGroupModel> groups = new List<SecurityGroupModel>();
            SecurityGroupModel group;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetSecurityGroup";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        group = new SecurityGroupModel();
                        group.Id= Convert.ToInt32(dr["SecurityId"]);
                        group.Name = Convert.ToString(dr["SecurityName"]);
                        group.Description = Convert.ToString(dr["SecurityDescription"]);
                        group.iconName= Convert.ToString(dr["IconName"]);
                        groups.Add(group);
                    }
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return groups;
        }

        /// <summary>
        /// Returns a single security group
        /// </summary>
        /// <param name="securityID">SecurityID</param>
        /// <returns>SecurityGroupModel object</returns>
        public SecurityGroupModel GetSecurityGroup(int securityID)
        {
            SecurityGroupModel group= new SecurityGroupModel(); ;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetSecurityGroup";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@SecurityID", securityID));
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        group.Id = Convert.ToInt32(dr["SecurityId"]);
                        group.Name = Convert.ToString(dr["SecurityName"]);
                        group.Description = Convert.ToString(dr["SecurityDescription"]);
                        group.iconName = Convert.ToString(dr["IconName"]);                      
                    }
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return group;
        }

        /// <summary>
        /// Returns trainings
        /// </summary>
        /// <returns>List of TrainingModel objects</returns>
        public List<TrainingModel> GetTrainings()
        {
            List<TrainingModel> trainings = new List<TrainingModel>();
            TrainingModel training;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetTraining";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        training = new TrainingModel();
                        training.Id = Convert.ToInt32(dr["TrainingID"]);
                        training.Name = Convert.ToString(dr["Name"]);
                        training.Description = Convert.ToString(dr["Description"]);
                        training.Duration = Convert.ToInt32(dr["Duration"]);
                        training.DueDate = Convert.ToDateTime(dr["DueDate"]);
                        training.TrainingURL = Convert.ToString(dr["TrainingURL"]); 
                        trainings.Add(training);
                    }
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return trainings;
        }

        /// <summary>
        /// Returns training by trainingID
        /// </summary>
        /// <param name="trainingID">trainingID</param>
        /// <returns>TrainingModel object</returns>
        public TrainingModel GetTraining(int trainingID)
        {
            TrainingModel training = new TrainingModel();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetTraining";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@TrainingID", trainingID));
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                       
                        training.Id = Convert.ToInt32(dr["TrainingID"]);
                        training.Name = Convert.ToString(dr["Name"]);
                        training.Description = Convert.ToString(dr["Description"]);
                        training.Duration = Convert.ToInt32(dr["Duration"]);
                        training.DueDate = Convert.ToDateTime(dr["DueDate"]);
                        training.TrainingURL = Convert.ToString(dr["TrainingURL"]);                        
                    }
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return training;
        }

        /// <summary>
        /// Returns Contracts
        /// </summary>
        /// <returns>List of ContractModel objects</returns>
        public List<ContractModel> GetContracts()
        {
            List<ContractModel> contracts = new List<ContractModel>();
            ContractModel contract;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetContract";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        contract = new ContractModel();
                        contract.Id = Convert.ToInt32(dr["ContractID"]);
                        contract.Name = Convert.ToString(dr["ContractName"]);
                        contract.ThumbnailURL = Convert.ToString(dr["ThumbnailURL"]);
                        contract.ContentURL = Convert.ToString(dr["ContentURL"]);

                        contracts.Add(contract);
                    }
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return contracts;
        }

        /// <summary>
        /// Returns Contract by ContractID
        /// </summary>
        /// <param name="contractId">ContractID</param>
        /// <returns>ContractModel object</returns>
        public ContractModel GetContract(int contractId)
        {
            ContractModel contract =new ContractModel(); ;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetContract";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@ContractID", contractId));
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        contract.Id = Convert.ToInt32(dr["ContractID"]);
                        contract.Name = Convert.ToString(dr["ContractName"]);
                        contract.ThumbnailURL = Convert.ToString(dr["ThumbnailURL"]);
                        contract.ContentURL = Convert.ToString(dr["ContentURL"]);                        
                    }
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return contract;
        }

        /// <summary>
        /// Returns Departments
        /// </summary>
        /// <returns>List of DepartmentModel objects</returns>
        public List<DepartmentModel> GetDepartments()
        {
            List<DepartmentModel> departments = new List<DepartmentModel>();
            DepartmentModel department;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetDepartment";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        department = new DepartmentModel();
                        department.Id = Convert.ToInt32(dr["DepartmentID"]);
                        department.Name = Convert.ToString(dr["DepartmentName"]);

                        departments.Add(department);
                    }
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return departments;
        }

        /// <summary>
        /// Returns Job Roles
        /// </summary>
        /// <returns>List of JobRoleModel objects</returns>
        public List<JobRoleModel> GetJobRoles()
        {
            List<JobRoleModel> jobRoles = new List<JobRoleModel>();
            JobRoleModel jobRole;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetJobRole";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        jobRole = new JobRoleModel();
                        jobRole.Id = Convert.ToInt32(dr["JobRoleID"]);
                        jobRole.Name = Convert.ToString(dr["JobRoleName"]);

                        jobRoles.Add(jobRole);
                    }
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return jobRoles;
        }


        /// <summary>
        /// Returns Job Roles
        /// </summary>
        /// <returns>List of JobRoleModel objects</returns>
        public List<ModuleModel> GetModules()
        {
            List<ModuleModel> modules = new List<ModuleModel>();
            ModuleModel module;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetModule";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        module = new ModuleModel();
                        module.ModuleID = Convert.ToInt32(dr["ModuleID"]);
                        module.ModuleName = Convert.ToString(dr["ModuleName"]);

                        modules.Add(module);
                    }
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return modules;
        }

        ///// <summary>
        ///// Returns Password
        ///// </summary>
        ///// <param name="employeeID">EmployeeID</param>
        ///// <returns>UserModel</returns>
        //public UserModel GetPassword(int employeeID)
        //{
        //    UserModel user = new UserModel();
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
        //        {
        //            conn.Open();
        //            string sqlStr = "GetPassword";
        //            SqlCommand cmd = new SqlCommand(sqlStr, conn);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.Add(new SqlParameter("@EmployeeID", employeeID));
        //            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
        //            while (dr.Read())
        //            {
        //                user.EmployeeID = Convert.ToInt32(dr["UserID"]);
        //                user.Name = Convert.ToString(dr["Name"]);                      
        //            }
        //            cmd.Parameters.Clear();
        //            cmd.Dispose();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    return user;
        //}

        /// <summary>
        /// Returns Users trainings
        /// </summary>
        /// <param name="EmployeeId">EmployeeID</param>
        /// <returns>List of UserTrainingModel objects</returns>
        public List<UserTrainingModel> GetUserTrainings(int EmployeeId)
        {
            List<UserTrainingModel> trainings = new List<UserTrainingModel>();
            UserTrainingModel training;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetUserTrainings";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@EmployeeId", EmployeeId));
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        training = new UserTrainingModel();
                        training.Training = new TrainingModel();
                        training.Training.Id = Convert.ToInt32(dr["TrainingID"]);
                        training.Training.Name = Convert.ToString(dr["Name"]);
                        training.Training.Description = Convert.ToString(dr["Description"]);
                        training.Training.Duration = Convert.ToInt32(dr["Duration"]);
                        training.Training.DueDate = Convert.ToDateTime(dr["DueDate"]);
                        training.Training.TrainingURL = Convert.ToString(dr["TrainingURL"]);
                        training.Progress= Convert.ToInt32(dr["Progress"]);
                        training.Status = Convert.ToString(dr["Status"]);
                        trainings.Add(training);
                    }
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return trainings;
        }

        /// <summary>
        /// Default Trainings
        /// </summary>
        /// <param name="EmployeeId">EmployeedID</param>
        /// <returns>List of TrainingModel objects</returns>
        public List<TrainingModel> GetDefaultTrainings(int EmployeeId)
        {
            List<TrainingModel> trainings = new List<TrainingModel>();
            TrainingModel training;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetDefaultTrainings";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeId));
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        training = new TrainingModel();
                        training.Id = Convert.ToInt32(dr["TrainingID"]);
                        training.Name = Convert.ToString(dr["Name"]);
                        training.Description = Convert.ToString(dr["Description"]);
                        training.Duration = Convert.ToInt32(dr["Duration"]);
                        training.DueDate = Convert.ToDateTime(dr["DueDate"]);
                        training.TrainingURL = Convert.ToString(dr["TrainingURL"]);

                        trainings.Add(training);
                    }
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return trainings;
        }

        /// <summary>
        /// Returns User Contracts
        /// </summary>
        /// <param name="EmployeeId">EmployeeID</param>
        /// <returns>List of ContractModel objects</returns>
        public List<ContractModel> GetUserContracts(int EmployeeId)
        {
            List<ContractModel> contracts = new List<ContractModel>();
            ContractModel contract;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetUserContracts";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeId));
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        contract = new ContractModel();
                        contract.Id = Convert.ToInt32(dr["ContractId"]);
                        contract.Name = Convert.ToString(dr["ContractName"]);
                        contract.ThumbnailURL = Convert.ToString(dr["ThumbnailURL"]);
                        contract.ContentURL = Convert.ToString(dr["ContentURL"]);
                        if (!dr.IsDBNull(dr.GetOrdinal("Date")))  contract.Date = Convert.ToDateTime(dr["Date"]);
                       
                        contracts.Add(contract);
                    }
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return contracts;
        }

        /// <summary>
        /// Returns Default Contracts
        /// </summary>
        /// <param name="EmployeeId">EmployeeID</param>
        /// <returns>List of ContractModel objects</returns>
        public List<ContractModel> GetDefaultContracts(int EmployeeId)
        {
            List<ContractModel> contracts = new List<ContractModel>();
            ContractModel contract;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetDefaultContracts";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeId));
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        contract = new ContractModel();
                        contract.Id = Convert.ToInt32(dr["ContractId"]);
                        contract.Name = Convert.ToString(dr["ContractName"]);
                        contract.ThumbnailURL = Convert.ToString(dr["ThumbnailURL"]);
                        contract.ContentURL = Convert.ToString(dr["ContentURL"]);
                        
                        contracts.Add(contract);
                    }
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return contracts;
        }

        /// <summary>
        /// Returns Default SecurityGroups
        /// </summary>
        /// <param name="EmployeeId">EmployeeID</param>
        /// <returns>List of SecurityGroupModel objects</returns>
        public List<SecurityGroupModel> GetDefaultSecurityGroups(int EmployeeId)
        {
            List<SecurityGroupModel> securityGroups = new List<SecurityGroupModel>();
            SecurityGroupModel securityGroup;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetDefaultSecurityGroups";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeId));
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        securityGroup = new SecurityGroupModel();
                        securityGroup.Id = Convert.ToInt32(dr["SecurityID"]);
                        securityGroup.Name = Convert.ToString(dr["SecurityName"]);
                        securityGroup.Description = Convert.ToString(dr["SecurityDescription"]);
                        securityGroup.iconName = Convert.ToString(dr["IconName"]);
                        securityGroups.Add(securityGroup);
                    }
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return securityGroups;
        }

        /// <summary>
        /// Returns User SecurityGroups
        /// </summary>
        /// <param name="employeeId">EmployeeID</param>
        /// <returns>List of UserSecurityGroupModel objects</returns>
        public List<UserSecurityGroupModel> GetUserSecurityGroups(int employeeId)
        {
            List<UserSecurityGroupModel> securityGroups = new List<UserSecurityGroupModel>();
            UserSecurityGroupModel securityGroup;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetUserSecurityGroups";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@EmployeeID", employeeId));
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        securityGroup = new UserSecurityGroupModel();
                       
                        securityGroup.SecurityGroup = new SecurityGroupModel();
                        securityGroup.SecurityGroup.Id= Convert.ToInt32(dr["SecurityID"]);
                        securityGroup.SecurityGroup.Name = Convert.ToString(dr["SecurityName"]);
                        securityGroup.SecurityGroup.Description = Convert.ToString(dr["SecurityDescription"]);
                        securityGroup.Status = Convert.ToString(dr["Status"]);
                        securityGroups.Add(securityGroup);
                    }
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return securityGroups;
        }

        /// <summary>
        /// Sets training status
        /// </summary>
        /// <param name="employeeID">EmployeeID</param>
        /// <param name="trainingId">TrainingID</param>
        /// <param name="status">Status</param>
        /// <param name="progress">Progress</param>
        /// <returns>Set status of training</returns>
        public bool SetTrainingStatus(int employeeID, int trainingId, string status, int progress)
        {
            bool result = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "SetTrainingStatus";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@EmployeeID", employeeID));
                    cmd.Parameters.Add(new SqlParameter("@TrainingId", trainingId));
                    cmd.Parameters.Add(new SqlParameter("@Status", status));
                    cmd.Parameters.Add(new SqlParameter("@Progress", progress));
                    cmd.ExecuteNonQuery();
                    result = true;
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// Updates User Contract
        /// </summary>
        /// <param name="employeeId">EmployeeID</param>
        /// <param name="contractId">ContractID</param>
        /// <param name="sign">Accept/Reject</param>
        /// <returns>Sign status of a user contract</returns>
        public bool SignContract(string employeeId, int contractId, bool sign)
        {
            bool result = false;
            try
            {
                if (sign)
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                    {
                        conn.Open();
                        string sqlStr = "SignContract";
                        SqlCommand cmd = new SqlCommand(sqlStr, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new SqlParameter("@EmployeeId", employeeId));
                        cmd.Parameters.Add(new SqlParameter("@ContractId", contractId));

                        cmd.ExecuteNonQuery();
                        result = true;
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// Update a user security group
        /// </summary>
        /// <param name="employeeId">EmployeeID</param>
        /// <param name="securityId">SecurityID</param>
        /// <param name="status">Status</param>
        /// <returns>update status of security group for a user</returns>
        public bool SetSecurityGroup(int employeeId, int securityId, string status)
        {
            bool result = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "SetSecurityGroup";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@SecurityID", securityId));
                    cmd.Parameters.Add(new SqlParameter("@EmployeeID", employeeId));
                    cmd.Parameters.Add(new SqlParameter("@Status", status));
                    cmd.ExecuteNonQuery();
                    result = true;
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }


        /// <summary>
        /// Registers user and returns employeeID
        /// </summary>
        /// <param name="name">Name of the User</param>
        /// <param name="emailaddress">Emial Address of the user</param>
        /// <param name="jobRole">Job Role of the user</param>
        /// <param name="password">Password of the user</param>
        /// <returns>EmployeeID</returns>
        public int RegisterUser(string name, string emailaddress, string jobRole)
        {
            int EmployeeID = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "RegisterUser";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@Name", name));
                    cmd.Parameters.Add(new SqlParameter("@EmailAddress", emailaddress));
                    cmd.Parameters.Add(new SqlParameter("@JobRole", jobRole));
                   
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
                    }

                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return EmployeeID;
        }

        public List<ModuleProgressModel> GetModulesProgress(int employeeID)
        {
            List<ModuleProgressModel> modules = new List<ModuleProgressModel>();
            ModuleProgressModel module;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetModuleProgress";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@EmployeeId", employeeID));
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        module = new ModuleProgressModel();
                        module.ModuleID = Convert.ToInt32(dr["ModuleID"]);
                        module.ModuleName = Convert.ToString(dr["ModuleName"]);
                        module.TotalTime = Convert.ToInt32(dr["TotalTime"]);
                        module.CompletedTime = Convert.ToInt32(dr["CompletedTime"]);
                        modules.Add(module);
                    }

                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return modules;
        }

        public ModuleProgressModel GetSecurityProgress(int employeeID)
        {
            ModuleProgressModel securityModule = new ModuleProgressModel();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetModuleProgress";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@EmployeeId", employeeID));
                    cmd.Parameters.Add(new SqlParameter("@ModuleID", 6));
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        securityModule.ModuleID = Convert.ToInt32(dr["ModuleID"]);
                        securityModule.ModuleName = Convert.ToString(dr["ModuleName"]);
                        securityModule.TotalTime = Convert.ToInt32(dr["TotalTime"]);
                        securityModule.CompletedTime = Convert.ToInt32(dr["CompletedTime"]);
                    }

                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return securityModule;
        }

        public ModuleProgressModel GetTrainingProgress(int employeeID)
        {
            ModuleProgressModel trainingModule = new ModuleProgressModel();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetModuleProgress";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@EmployeeId", employeeID));
                    cmd.Parameters.Add(new SqlParameter("@ModuleID", 4));
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        trainingModule.ModuleID = Convert.ToInt32(dr["ModuleID"]);
                        trainingModule.ModuleName = Convert.ToString(dr["ModuleName"]);
                        trainingModule.TotalTime = Convert.ToInt32(dr["TotalTime"]);
                        trainingModule.CompletedTime = Convert.ToInt32(dr["CompletedTime"]);
                    }

                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return trainingModule;
        }

        public ModuleProgressModel GetContractProgress(int employeeID)
        {
            ModuleProgressModel contractModule = new ModuleProgressModel();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetModuleProgress";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@EmployeeId", employeeID));
                    cmd.Parameters.Add(new SqlParameter("@ModuleID", 5));
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        contractModule.ModuleID = Convert.ToInt32(dr["ModuleID"]);
                        contractModule.ModuleName = Convert.ToString(dr["ModuleName"]);
                        contractModule.TotalTime = Convert.ToInt32(dr["TotalTime"]);
                        contractModule.CompletedTime = Convert.ToInt32(dr["CompletedTime"]);
                    }

                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return contractModule;
        }

        public List<AdminProgressModel> GetAllUsersProgress()
        {
            List<AdminProgressModel> allUsersProgress = new List<AdminProgressModel>();
            AdminProgressModel userProgress;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetUserProgress";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        userProgress = new AdminProgressModel();
                        userProgress.EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
                        userProgress.Name = Convert.ToString(dr["Name"]);
                        userProgress.TotalTime = Convert.ToInt32(dr["TotalTime"]);
                        userProgress.CompletedTime = Convert.ToInt32(dr["CompletedTime"]);
                        allUsersProgress.Add(userProgress);
                    }

                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return allUsersProgress;
        }

        public List<AdminProgressModel> GetDepartmentProgress(int departmentID)
        {
            List<AdminProgressModel> deptProgress = new List<AdminProgressModel>();
            AdminProgressModel userProgress;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetUserProgress";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@DepartmentID", departmentID));
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        userProgress = new AdminProgressModel();
                        userProgress.EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
                        userProgress.Name = Convert.ToString(dr["Name"]);
                        userProgress.TotalTime = Convert.ToInt32(dr["TotalTime"]);
                        userProgress.CompletedTime = Convert.ToInt32(dr["CompletedTime"]);
                        deptProgress.Add(userProgress);
                    }

                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return deptProgress;
        }

        public List<AdminSettingsModel> GetSettings()
        {
            List<AdminSettingsModel> settings = new List<AdminSettingsModel>();
            AdminSettingsModel setting;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetSettings";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
        
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        setting = new AdminSettingsModel();
                        setting.SettingID = Convert.ToInt32(dr["SettingID"]);
                        setting.SettingName = Convert.ToString(dr["SettingName"]);
                        setting.SettingDescription = Convert.ToString(dr["SettingDescription"]);
                        setting.SettingValue = Convert.ToInt32(dr["SettingValue"]);
                        setting.ModuleID = Convert.ToInt32(dr["ModuleID"]);
                        settings.Add(setting);
                    }

                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return settings;
        }

        public List<AdminSettingsModel> GetDepartmentSettings(int departmentID)
        {
            List<AdminSettingsModel> settings = new List<AdminSettingsModel>();
            AdminSettingsModel setting;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetSettings";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@DepartmentID", departmentID));
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        setting = new AdminSettingsModel();
                        setting.SettingID = Convert.ToInt32(dr["SettingID"]);
                        setting.SettingName = Convert.ToString(dr["SettingName"]);
                        setting.SettingDescription = Convert.ToString(dr["SettingDescription"]);
                        setting.SettingValue = Convert.ToInt32(dr["SettingValue"]);
                        setting.ModuleID = Convert.ToInt32(dr["ModuleID"]);
                        settings.Add(setting);
                    }

                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return settings;
        }

        public List<AdminSettingsModel> GetUserSettings(int employeeID)
        {
            List<AdminSettingsModel> settings = new List<AdminSettingsModel>();
            AdminSettingsModel setting;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                {
                    conn.Open();
                    string sqlStr = "GetSettings";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@EmployeeID", employeeID));
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        setting = new AdminSettingsModel();
                        setting.SettingID = Convert.ToInt32(dr["SettingID"]);
                        setting.SettingName = Convert.ToString(dr["SettingName"]);
                        setting.SettingDescription = Convert.ToString(dr["SettingDescription"]);
                        setting.SettingValue = Convert.ToInt32(dr["SettingValue"]);
                        setting.ModuleID = Convert.ToInt32(dr["ModuleID"]);
                        settings.Add(setting);
                    }

                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return settings;
        }

        public bool SetUserSettings(UserSettingsRequest userSettings)
        {
            List<SettingsModel> settings = userSettings.userSettings;
            int EmployeeID = userSettings.EmployeeID;

            bool result = false;
            try
            {
                foreach (SettingsModel setting in settings)
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                    {
                        conn.Open();
                        string sqlStr = "SetUserSettings";
                        SqlCommand cmd = new SqlCommand(sqlStr, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeID));
                        cmd.Parameters.Add(new SqlParameter("@SettingID", setting.SettingID));
                        cmd.Parameters.Add(new SqlParameter("@ModuleID", setting.ModuleID));
                        cmd.Parameters.Add(new SqlParameter("@SettingValue", setting.SettingValue));
                        cmd.ExecuteNonQuery();
                        result = true;
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public bool SetDepartmentSettings(DepartmentSettingsRequest departmentSettings)
        {
            List<SettingsModel> settings = departmentSettings.departmentSettings;
            int DepartmentID = departmentSettings.DepartmentID;

            bool result = false;
            try
            {
                foreach (SettingsModel setting in settings)
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString))
                    {
                        conn.Open();
                        string sqlStr = "SetDepartmentSettings";
                        SqlCommand cmd = new SqlCommand(sqlStr, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new SqlParameter("@DepartmentID", DepartmentID));
                        cmd.Parameters.Add(new SqlParameter("@SettingID", setting.SettingID));
                        cmd.Parameters.Add(new SqlParameter("@ModuleID", setting.ModuleID));
                        cmd.Parameters.Add(new SqlParameter("@SettingValue", setting.SettingValue));
                        cmd.ExecuteNonQuery();
                        result = true;
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }

    //public class FakeDomainModel : IDomainModel
    //{
    //    private List<UserModel> _userModels = new List<UserModel>() { new UserModel { EmployeeID = "1", Name = "krishna" }, new UserModel() { EmployeeID = "2", Name = "nish" } };
    //    public UserModel GetUser(string userId)
    //    {
    //        return _userModels.FirstOrDefault(d => d.EmployeeID == userId);
    //    }
    //}

    //public interface IDomainModel
    //{
    //    UserModel GetUser(string userId);
    //}
}