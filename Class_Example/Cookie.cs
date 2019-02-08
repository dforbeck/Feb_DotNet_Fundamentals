using System.Collections.Generic;

namespace Class_Example
{
    public class Cookie
    {
        public int BatchSize { get; set; }
        public string  Name { get; set; }
        public List<string> Ingredients { get; set; }
        public bool IsGlutenFree { get; set; }
    }
}