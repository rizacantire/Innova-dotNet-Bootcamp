﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class BookAddDto
    {
        public string Name { get; set; }
        public int Page { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
    }
}
