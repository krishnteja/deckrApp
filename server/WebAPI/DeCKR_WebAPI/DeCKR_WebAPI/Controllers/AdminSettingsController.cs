using DeCKR_WebAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

/*****************************************************
* Project Name: DeCKR                                *
* Date: 07/01/2019                                   *
* Course: CSC 687 - Computer Science Project II      *
* Instructor: Mudasser Wyne                          *
******************************************************/

namespace DeCKR_WebAPI.Controllers
{
   
    [RoutePrefix("api/adminsettings")]
    public class AdminSettingsController : ApiController
    {
        /// <summary>
        /// object for the domain model class
        /// </summary>
        DomainModel model = new DomainModel();

        //Gets all users settings 
        [Authorize]
        public List<AdminSettingsModel> Get()
        {
            return model.GetSettings().ToList();
        }

        //Gets single user settings 
        [Route("UserSettings/{employeeID}")]
        [Authorize]
        public List<AdminSettingsModel> GetUserSettings(int employeeID)
        {
            return model.GetUserSettings(employeeID).ToList();
        }


        //Gets Department  settings 
        [Route("DepartmentSettings/{departmentID}")]
        [Authorize]
        public List<AdminSettingsModel> GetDepartmentSettings(int departmentID)
        {
            return model.GetDepartmentSettings(departmentID).ToList();
        }

        [Route("SetUserSettings")]
        [Authorize]
        [HttpPost]
        public void SetUserSettings([FromBody]UserSettingsRequest userSettings)
        {
            bool result = model.SetUserSettings(userSettings);
        }

        [Route("SetDepartmentSettings")]
        [Authorize]
        [HttpPost]
        public void SetDepartmentSettings([FromBody] DepartmentSettingsRequest departmentSettings)
        {
            bool result = model.SetDepartmentSettings(departmentSettings);
        }
    }
}
