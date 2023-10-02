using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Core.Entities;

namespace Domain.Teams.Entities
{
    public class Team : AggregateRoot
    {
        public string Name { get; private set; }
        public string Region { get; private set; }
        public int Foundation { get; private set; }
        public Team(string name, string region, int foundation)
        {
            Name = name;
            Region = region;
            Foundation = foundation;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetRegion()
        {
            return Region;
        }
        public int GetFoundation()
        {
            return Foundation;
        }
        public virtual int GetPlayerSize() 
        {
            return 0;
        }
    }
}
