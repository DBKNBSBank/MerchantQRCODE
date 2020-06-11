using System;
using System.Collections.Generic;

namespace MerchantQRPortalCore.Models
{
    public partial class Transactions
    {
        public int RecordId { get; set; }
        public int? QrcodeRecordId { get; set; }
        public string TxnRef { get; set; }
        public string CustomerAccountNumber { get; set; }
        public double Amount { get; set; }
        public DateTime DateCreated { get; set; }
        public int? MerchantQrcodeRecordId { get; set; }

        public virtual QrCodes MerchantQrcodeRecord { get; set; }
        public virtual QrCodes QrcodeRecord { get; set; }
    }
}
