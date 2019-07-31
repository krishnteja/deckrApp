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
    public class ModuleController : ApiController
    {
        DomainModel model = new DomainModel();

        /// <summary>
        /// Gets all Modules list
        /// </summary>
        /// <returns>Modules List</returns>
        [Authorize]
        public List<ModuleModel> Get()
        {
            return model.GetModules().ToList();
        }
    }
}
