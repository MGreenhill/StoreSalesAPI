﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using StoreSales.API.Entities;

namespace StoreSales.API.Models
{
    public class TransactionDto
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public int PersonId { get; set; }

        public PersonWithoutTransactionsDto Person { get; set; }

        public DateTime TimeOccurred { get; set; }

        public string? Note { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
