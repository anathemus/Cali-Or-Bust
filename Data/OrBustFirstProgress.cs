using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OrBust.Data
{
    [Table("First_Progress")]
    public class OrBustFirstProgress
    {
        public string UserName { get; private set; }
        public string FirstResponse { get; set; }
        public string SecondResponse { get; set; }
        public string ThirdResponse { get; set; }
        public string SecondResponseText { get; set; }
        public string ThirdResponseText { get; set; }
        public bool HiddenOne { get; set; }
        public bool HiddenTwo { get; set; }
        public bool HiddenThree { get; set; }
        public bool HiddenFour { get; set; }
    }
}
