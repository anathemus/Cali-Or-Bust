using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OrBust.Models
{
    public class OrBustFirstProgress
    {
        public string UserName { get; private set; }
        public string FirstResponse { get; set; }
        public string SecondResponse { get; set; }
        public string ThirdResponse { get; set; }
        public bool HiddenOne { get; set; }
        public bool HiddenTwo { get; set; }
        public bool HiddenThree { get; set; }
    }
}
