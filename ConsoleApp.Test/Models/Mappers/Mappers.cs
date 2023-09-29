using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test.Models.Mappers
{
    internal static class Mappers
    {
        internal static Contact ToContact(this IDataReader reader)
        {
            return new Contact((int)reader["Id"], (string)reader["Nom"], (string)reader["Prenom"], (DateTime)reader["Anniversaire"]);
        }
    }
}
