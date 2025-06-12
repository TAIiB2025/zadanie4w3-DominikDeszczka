using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class FilmyDTO
    {
        public int ID { get; init; }
        public required string Tytul { get; init; }
        public required string Rezyser { get; init; }
        public required string Gatunek { get; init; }
        public int Rok_wydania { get; init; }
    }
}
