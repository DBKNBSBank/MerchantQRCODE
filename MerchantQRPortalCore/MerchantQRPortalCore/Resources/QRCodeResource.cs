using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MerchantQRPortalCore.Resources
{
    public class QRCodeResource
    {
        [Required]
        [Display(Name = "Merchant Name")]
        public string MerchantName { get; set; }
        [Required]
        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }
        [Required]
        [Display(Name = "Merchant Code")]
        public string MerchantCode { get; set; }
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }
    }
}
