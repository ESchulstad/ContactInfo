using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactInfo.Models
{
    public class ContactModel
    {
        private string firstName;
        private string lastName;
        private string phoneNums;
        private string email;

        [Key]
        public int RecordNumber {get; set;}

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string PhoneNums
        {
            get { return this.phoneNums; }
            set { this.phoneNums = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }


    }
}