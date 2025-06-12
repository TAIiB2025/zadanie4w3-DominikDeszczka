using BLL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Memory.Extensions
{
    internal static class FilmyEntityExtensions
    {
        public static FilmyDTO ToDTO(this FilmyEntity filmyEntity)
        {
            return new FilmyDTO
            {
                Tytul = filmyEntity.Tytul,
                Rezyser = filmyEntity.Rezyser,
                Gatunek = filmyEntity.Gatunek,
                Rok_wydania = filmyEntity.Rok_wydania,
                ID = filmyEntity.ID
            };
        }
    }
}
