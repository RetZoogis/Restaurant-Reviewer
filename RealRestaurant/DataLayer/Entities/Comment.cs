﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Restaurant { get; set; }
        public string Message { get; set; }
    }
}
