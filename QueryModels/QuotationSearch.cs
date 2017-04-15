﻿using System;

namespace MixERP.Sales.QueryModels
{
    public sealed class QuotationSearch
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public DateTime ExpectedFrom { get; set; }
        public DateTime ExpectedTo { get; set; }
        public string QuotationId { get; set; }
        public string ReferenceNumber { get; set; }
        public string Customer { get; set; }
        public string Terms { get; set; }
        public string Memo { get; set; }
        public string PostedBy { get; set; }
        public string Office { get; set; }
        public decimal Amount { get; set; }
    }
}