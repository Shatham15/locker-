﻿using Microsoft.VisualBasic;

namespace lockerSystem.Models
{
    public class tblSemster
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public bool IsActive { get; set; }
        // year
        public DateTime startSemster { get; set; }
        public DateTime endSemster { get; set; }
        public string semsterNameAr { get; set; }
        public string semsterNameEn { get; set; }
        public ICollection<tblSemster> Booking { get; set; }
    }
    }

