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
    /// Training Controller class
    /// </summary>
   // [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [RoutePrefix("api/training")]
    public class TrainingController : ApiController
    {
        DomainModel model = new DomainModel();

        /// <summary>
        /// Get all trainings
        /// </summary>
        /// <returns>Trainings List</returns>
        [Authorize]
        public List<TrainingModel> Get()
        {
            return model.GetTrainings().ToList();
        }

        /// <summary>
        /// Returns a training
        /// </summary>
        /// <param name="Id">trainingid</param>
        /// <returns>single training</returns>
        [ActionName("SingleTraining")]
        [Authorize]
        public TrainingModel GetTraining(int Id)
        {
            return model.GetTraining(Id);
        }

        /// <summary>
        /// Returns user trainings
        /// </summary>
        /// <param name="employeeID">employee ID</param>
        /// <returns>list of user trainings</returns>
        [Route("UserTrainings/{employeeID}")]
        [Authorize]
        public List<UserTrainingModel> GetUserTrainings(int employeeID)
        {
            return model.GetUserTrainings(employeeID).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="trainingId"></param>
        /// <param name="status"></param>
        /// <param name="completion"></param>
        [HttpPost]
        [Authorize]
        public void Post(int employeeID, int trainingId, string status, int progress)
        {
            bool result = model.SetTrainingStatus(employeeID, trainingId,status, progress);
        }
    }
}
