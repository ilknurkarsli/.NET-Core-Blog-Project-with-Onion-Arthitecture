using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using _1_BlogCore.DomainModels.BaseModels;
using Microsoft.AspNetCore.Identity;

namespace _1_BlogCore.DomainModels.Models
{
    public class AppUser: IdentityUser, IBaseEntity
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _normalizedFirstName;
        public string NormalizedFirstName
        {
            get { return _normalizedFirstName; }
            set { _normalizedFirstName = _firstName.ToUpper(); }
        }
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private string _normalizedLastName;
        public string NormalizedLastName
        {
            get { return _normalizedLastName; }
            set { _normalizedLastName = _lastName.ToUpper(); }
        }
        [NotMapped]
        public string FullName { get{return _firstName+" "+_lastName;}}
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}