using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGym.DataObject
{
    class ListService
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }

        public ListService(int id, string name, decimal cost, string description)
        {
            this.Cost = cost;
            this.Description = description;
            this.Name = name;
            this.ID = id;
        }
    }
}