using System;
using System.Collections.Generic;

namespace MerchantQRPortalCore.Models
{
    public partial class QrCodes
    {
        public QrCodes()
        {
            TransactionsMerchantQrcodeRecord = new HashSet<Transactions>();
            TransactionsQrcodeRecord = new HashSet<Transactions>();
        }

        public int RecordId { get; set; }
        public string MerchantName { get; set; }
        public string AccountNumber { get; set; }
        public string MerchantCode { get; set; }
        public DateTime DateCreated { get; set; }
        public string ImagePath { get; set; }

        public virtual ICollection<Transactions> TransactionsMerchantQrcodeRecord { get; set; }
        public virtual ICollection<Transactions> TransactionsQrcodeRecord { get; set; }
    }
}
