using System;
using System.Collections.Generic;

namespace BackEnd.Service.DTO
{
    public partial class CustomerSubscribeDTO
    {
        public bool? Plateform { get; set; }
        public string Token { get; set; }
        public Guid? Cityid { get; set; }
    }
}
