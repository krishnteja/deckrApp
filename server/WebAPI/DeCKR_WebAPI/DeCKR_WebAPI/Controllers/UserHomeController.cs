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
   // [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [RoutePrefix("api/userhome")]
    public class UserHomeController : ApiController
    {
        /// <summary>
        /// object for the domain model class
        /// </summary>
        DomainModel model = new DomainModel();

        //Gets all Modules Data for the user
        [Route("UserProgress/{employeeID}")]
        [Authorize]
        public List<ModuleProgressModel> Get(int employeeID)
        {
            return model.GetModulesProgress(employeeID).ToList();
        }

        //Gets Security Groups Progress for the user
        [Route("SecurityProgress/{employeeID}")]
        [Authorize]
        public ModuleProgressModel GetSecurityProgress(int employeeID)
        {
            return model.GetSecurityProgress(employeeID);
        }

        //Gets Trainings Progress for the user
        [Route("TrainingProgress/{employeeID}")]
        [Authorize]
        public ModuleProgressModel GetTrainingProgress(int employeeID)
        {
            return model.GetTrainingProgress(employeeID);
        }

        //Gets Contracts Progress for the user
        [Route("ContractProgress/{employeeID}")]
        [Authorize]
        public ModuleProgressModel GetContractProgress(int employeeID)
        {
            return model.GetContractProgress(employeeID);
        }
    }
}
