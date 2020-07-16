using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.API.ModelBinding
{
    public class MarketImageModel
    {
        [Microsoft.AspNetCore.Mvc.ModelBinder(typeof(JsonWithFilesFormDataModelBinder), Name = "json")]
        public Service.Models.MarketVM Market { get; set; }
        public Microsoft.AspNetCore.Http.IFormFile Image { get; set; }

    }
}
