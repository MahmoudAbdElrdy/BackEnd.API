﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.Models
{
    public class ApplicationSettings
    {
        public string JWT_Secret { get; set; }

        public string Client_URL { get; set; }

      // public string Report_Connection { get; set; }
    }
}
