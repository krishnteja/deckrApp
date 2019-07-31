/*****************************************************
* Project Name: DeCKR                                *
* Date: 07/01/2019                                   *
* Course: CSC 687 - Computer Science Project II      *
* Instructor: Mudasser Wyne                          *
******************************************************/

using System.Collections.Generic;

namespace DeCKR_WebAPI.Models
{
    /// <summary>
    /// Admin Settings Class
    /// </summary>
    public class AdminSettingsModel
    {
        /// <summary>
        /// Setting ID
        /// </summary>
        public int SettingID { get; set; }

        /// <summary>
        /// Setting Name
        /// </summary>
        public string SettingName { get; set; }

        /// <summary>
        /// Setting Description
        /// </summary>
        public string SettingDescription { get; set; }

        /// <summary>
        /// Setting Value
        /// </summary>
        public int SettingValue { get; set; }

        /// <summary>
        /// ModuleID
        /// </summary>
        public int ModuleID { get; set; }
    }

    public class SettingsModel
    {
        public int SettingID { get; set; }

        /// <summary>
        /// Setting Value
        /// </summary>
        public int SettingValue { get; set; }

        /// <summary>
        /// ModuleID
        /// </summary>
        public int ModuleID { get; set; }

    }


    public class UserSettingsRequest
    {
        public List<SettingsModel> userSettings { get; set; }

        public int EmployeeID { get; set; }
    }


    public class DepartmentSettingsRequest
    {
        public List<SettingsModel> departmentSettings { get; set; }

        public int DepartmentID { get; set; }
    }

    /// <summary>
    /// Module Class
    /// </summary>
    public class ModuleModel
    {
        /// <summary>
        /// Module ID
        /// </summary>
        public int ModuleID { get; set; }

        /// <summary>
        /// Module Name
        /// </summary>
        public string ModuleName { get; set; }
    }
}