﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApp.Models
{
    public class AccommodationViewModel
    {
        public Guid ClientId { get; set; }
        public Guid RoomId { get; set; }
    }
}