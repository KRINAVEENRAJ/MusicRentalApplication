﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Music.Models;

namespace Music.ViewModel
{
    public class RandomViewModel
    {
        public Movies Movie { get; set; }
        public List<Customer> Customer { get; set; }
    }
}