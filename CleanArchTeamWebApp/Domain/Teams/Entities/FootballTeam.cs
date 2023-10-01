using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Teams.Entities
{
    public class FootballTeam : Team
    {
        public string StadiumName { get; private set; }

        public FootballTeam(string name, string region, int foundation, string stadiumName) : base(name, region, foundation)
        {
            StadiumName = stadiumName;
        }
    }
}
