using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MerchantQRPortalCore.ViewModels
{
    public class SignInViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        //public UserRole UserRole { get; set; }
        //public string RoleName { get; set; }
    }
    public enum UserRole 
    {
        Administrator,
        User
    }
}
