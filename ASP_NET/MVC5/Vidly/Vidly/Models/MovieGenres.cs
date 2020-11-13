using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MovieGenres
    {
        public byte Id { get; set; }
        public string Name { get; set; }

        public static readonly byte Comedy = 0;
        public static readonly byte Action = 1;
        public static readonly byte Family = 2;
        public static readonly byte Romance = 3;
    }
}