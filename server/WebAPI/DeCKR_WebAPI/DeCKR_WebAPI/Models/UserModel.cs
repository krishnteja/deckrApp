using System;

/*****************************************************
* Project Name: DeCKR                                *
* Date: 07/01/2019                                   *
* Course: CSC 687 - Computer Science Project II      *
* Instructor: Mudasser Wyne                          *
******************************************************/

namespace DeCKR_WebAPI.Models
{
    /// <summary>
    /// User View Model Class
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// Employee ID of the user
        /// </summary>
        public int EmployeeID { get; set; }

        /// <summary>
        /// Password of the User
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Name of the user
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// User name of the user
        /// </summary>
       // public string UserName { get; set; }

        /// <summary>
        /// type of the user
        /// </summary>
       public string UserType { get; set; }

        /// <summary>
        /// Job Role id of the user
        /// </summary>
        public string JobRole { get; set; }

        /// <summary>
        /// Department Id of the user
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// Email Address of the user
        /// </summary>
        public string EmailAddress { get; set; }

    }
}