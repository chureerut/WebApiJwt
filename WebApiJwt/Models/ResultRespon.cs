using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiJwt.Models
{
    public class ResultRespon<T>
    {
        public bool isSuccess { get; set; }
        public T data { get; set; }
        public string messageError { get; set; }
    }
}