using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2_BlogApplication.DTOs
{
    public class AppUserDTO
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
    }
}