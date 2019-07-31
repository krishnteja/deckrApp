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
    /// <summary>
    /// Job Role Controller class
    /// </summary>
   // [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class JobRoleController : ApiController
    {
        DomainModel model = new DomainModel();

        /// <summary>
        /// Gets all Job Roles list
        /// </summary>
        /// <returns>Job Roles List</returns>
        [AllowAnonymous]
        public List<JobRoleModel> Get()
        {
            return model.GetJobRoles().ToList();
        }
    }
}
