using System;
using System.Collections.Generic;
using System.Text;

namespace IT_WFA_ADO
{
    public class Category
    {
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => $"{Id} - {Name}";
    }
}
