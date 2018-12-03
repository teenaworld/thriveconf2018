﻿using System;

namespace Books.Shared
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }

        public override string ToString() => Title;
    }
}
