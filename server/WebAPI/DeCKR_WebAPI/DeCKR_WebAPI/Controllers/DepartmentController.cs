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
    /// Department Controller class
    /// </summary>
  //  [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class DepartmentController : ApiController
    {
        DomainModel model = new DomainModel();
        /// <summary>
        /// Gets all departments list
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public List<DepartmentModel> Get()
        {
            return model.GetDepartments().ToList();
        }
        
    }
}
