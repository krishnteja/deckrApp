using DeCKR_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
    [RoutePrefix("api/adminhome")]
    public class AdminHomeController : ApiController
    {

        /// <summary>
        /// object for the domain model class
        /// </summary>
        DomainModel model = new DomainModel();

        //Gets all users progress 
        [Authorize]
        public List<AdminProgressModel> Get()
        {
            return model.GetAllUsersProgress().ToList();
        }

        //Gets progress for a department
        [Route("DepartmentProgress/{departmentID}")]
        [Authorize]
        public List<AdminProgressModel> GetDepartmentProgress(int departmentID)
        {
            return model.GetDepartmentProgress(departmentID).ToList();
        }

        ////Gets progress for a department
        //[Route("DepartmentProgress/{departmentID}")]
        //[Authorize]
        //public List<AdminProgressModel> GetDepartmentProgress(int departmentID)
        //{
        //    return model.GetDepartmentProgress(departmentID).ToList();
        //}
    }
}
