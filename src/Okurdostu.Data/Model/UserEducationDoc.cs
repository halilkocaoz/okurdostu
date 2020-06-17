﻿using System;
using System.Collections.Generic;

namespace Okurdostu.Data.Model
{
    public partial class UserEducationDoc
    {
        public long Id { get; set; }
        public long UserEducationId { get; set; }
        public string DocumentUrl { get; set; }
        public string DocumentPath { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual UserEducation UserEducation { get; set; }
    }
}
