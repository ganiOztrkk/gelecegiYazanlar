﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingApp.DataTransferObjects.responses
{
    public class CategoryDisplayResponseDto
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
    }
}
