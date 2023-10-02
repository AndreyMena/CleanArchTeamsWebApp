using Domain.Teams.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Teams.Interfaces
{
    public interface IFootbalService
    {
        string GetStadiumName(int id);
    }
}
