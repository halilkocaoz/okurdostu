﻿using System;
using System.Collections.Generic;

namespace Okurdostu.Data
{
    public partial class NeedItem
    {
        public NeedItem()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
        public Guid NeedId { get; set; }
        public string Link { get; set; }
        public string Picture { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string PlatformName { get; set; }
        public bool IsRemoved { get; set; }
        public bool IsWrong { get; set; }

        public virtual Need Need { get; set; }
    }
}
