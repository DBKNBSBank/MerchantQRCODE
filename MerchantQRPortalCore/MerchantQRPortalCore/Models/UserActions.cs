using System;
using System.Collections.Generic;

namespace MerchantQRPortalCore.Models
{
    public partial class UserActions
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Rolename { get; set; }
        public string Action { get; set; }
        public DateTime? DateConducted { get; set; }
    }
}
