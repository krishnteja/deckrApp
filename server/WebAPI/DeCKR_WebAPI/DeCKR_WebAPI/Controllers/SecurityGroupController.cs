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
  //  [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [RoutePrefix("api/securitygroup")]
    public class SecurityGroupController : ApiController
    {
        DomainModel model = new DomainModel();

        [Authorize]
        public List<SecurityGroupModel> Get()
        {
            return model.GetSecurityGroups().ToList();
        }
      
        /// <summary>
        /// Returns a contract
        /// </summary>
        /// <param name="Id">ContractId</param>
        /// <returns>List of user Contracts</returns>
        [ActionName("SingleSecurity")]
        [Authorize]
        public SecurityGroupModel GetSecurity(int Id)
        {
            return model.GetSecurityGroup(Id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        [Route("UserSecurityGroups/{employeeID}")]
        [Authorize]
        public List<UserSecurityGroupModel> GetUserSecuritys(int employeeID)
        {
            return model.GetUserSecurityGroups(employeeID).ToList();
        }

        [HttpPost]
        [Authorize]
        public void Post(int employeeId, int securityId, string status)
        {
            bool result = model.SetSecurityGroup(employeeId, securityId, status);
        }
    }
}
