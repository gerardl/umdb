﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMDB.Data
{
    public class PlayerData
    {
        public ICollection<InventoryData> Inventory { get; set; }
    }
}