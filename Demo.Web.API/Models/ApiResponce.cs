using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Web.API.Models
{
    public class ApiResponce<T>
    {
        public T Responce { get; set; }

        public string Status { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;
    }
}