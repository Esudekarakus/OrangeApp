﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekKalori.Domain.Enums;

namespace YemekKalori.Domain.Entities
{
    public abstract class BaseClass
    {
        public BaseClass()
        {
            CreatedDate = DateTime.Now;
            Status = Status.Added;
        }
        public int Id { get; set; }
        public Status Status { get; set; } // Enum to represent the data entrys status.

        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
