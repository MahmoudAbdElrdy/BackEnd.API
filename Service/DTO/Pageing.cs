using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.DTO
{
    public class Pageing
    {
        public int pageNumber { get; set; } = 0;
        public int pageSize { get; set; } = 10;
        public int skip { get { return pageNumber * pageSize; } }
    }
}
