﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechMania_Client.Model.ViewModel
{
    public class SmartPhoneOrderVM
    {
        public SmartPhoneOrderVM()
        {
            OrderDetails = new SmartPhoneOrderDetailDTO();
        }
        public SmartPhoneOrderDetailDTO OrderDetails { get; set; }
    }
}
