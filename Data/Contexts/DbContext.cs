﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Core.Entities;

namespace Data.Contexts
{
    public static class DbContext
    {
        public static List<Core.Entities.Group> Groups { get; set; }
    }
}