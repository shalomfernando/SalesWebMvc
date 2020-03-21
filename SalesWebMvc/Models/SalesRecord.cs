﻿using SalesWebMvc.Models.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status   { get; set; }
        public Seller Seler { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seler)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seler = seler;
        }
    }
}
