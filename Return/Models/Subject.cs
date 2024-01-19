﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Return.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual User Teacher { get; set; }
        public int TeacherId { get; set; }
        public virtual Section Section { get; set; }
        public int SectionId { get; set; }
    }
}