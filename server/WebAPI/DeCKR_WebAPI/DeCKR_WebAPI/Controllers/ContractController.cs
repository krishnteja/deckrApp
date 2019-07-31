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
    /// Contract Controller Class
    /// </summary>
   // [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [RoutePrefix("api/contract")]
   public class ContractController : ApiController
    {
        /// <summary>
        /// object for the domain model class
        /// </summary>
        DomainModel model = new DomainModel();

        /// <summary>
        /// Returns all the contracts
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public List<ContractModel> Get()
        {
            return model.GetContracts().ToList();
        }

        /// <summary>
        /// Returns a contract
        /// </summary>
        /// <param name="Id">ContractId</param>
        /// <returns>List of user Contracts</returns>
        [ActionName("SingleContract")]
        public ContractModel GetContract(int Id)
        {
            return model.GetContract(Id);
        }

        /// <summary>
        /// Returns a contract
        /// </summary>
        /// <param name="employeeId">EmployeeId</param>
        /// <returns>List of user Contracts</returns>
        [Route("UserContracts/{employeeId}")]
        public List<ContractModel> GetUserContracts(int employeeId)
        {
            return model.GetUserContracts(employeeId).ToList<ContractModel>();
        }

        ///// <summary>
        ///// Returns a contract
        ///// </summary>
        ///// <param name="employeeId">jobRoleId</param>
        ///// <returns>List of user Contracts</returns>
        //[ActionName("DefaultContracts")]
        //public List<ContractModel> GeDefaultContracts(int employeeId)
        //{
        //    return model.GetDefaultContracts(employeeId).ToList<ContractModel>();
        //}

        /// <summary>
        /// Update Contract object
        /// </summary>
        /// <param name="Id">EmployeeId</param>
        /// <param name="contractId"></param>
        /// <param name="sign"></param>
        [HttpPost]
        public void Post(string Id, int contractId, bool sign)
        {
            bool result = model.SignContract(Id, contractId, sign);
        }
    }
}
