﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlogLab.Models.Exceptions
{
    public class ApiException
    {
        public int StatusCode { get; set; }

        public string Message { get; set; }

        public override string ToString() 
        {
            return JsonConvert.SerializeObject(this);
        } 
    }
}
