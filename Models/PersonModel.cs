using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The unqiue identifier for person
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The first name of the person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The Last name of the person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The email address of the person
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The cellphone number of the person
        /// </summary>
        public string TelephoneNumber { get; set; }

    
        public string FullName
        {
            get { return $"{ FirstName } { LastName }"; }

        }

    }
}
