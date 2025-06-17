﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Common
{
    public class Response
    {
        public string JsonData { get; set; }
        public bool IsSuccessful { get; set; } = true;
        public string Message { get; set; }

        public T GetData<T>()
        {
            return JsonSerializer.Deserialize<T>(JsonData);
        }
    }
}
