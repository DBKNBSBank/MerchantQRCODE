using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MerchantQRPortalCore.ViewModels
{
    public class JsonResultViewModel<T>
    {
        public int ErrorCode { get; set; }
        public T Data { get; set; }

    }
}
