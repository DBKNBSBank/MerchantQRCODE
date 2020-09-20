using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MerchantQRPortalCore.ViewModels
{
    public class JsonResultViewModel<T>
    {
        public bool success { get; set; }
        public string token { get; set; }

        public string roleslug { get; set; }

    }
}
