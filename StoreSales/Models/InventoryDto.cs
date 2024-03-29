﻿using Newtonsoft.Json;
using StoreSales.API.Entities;

namespace StoreSales.API.Models
{
    public class InventoryDto
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public int ItemId { get; set; }
        public ItemDto Item { get; set; }
        public int Quantity { get; set; }

    }
}
