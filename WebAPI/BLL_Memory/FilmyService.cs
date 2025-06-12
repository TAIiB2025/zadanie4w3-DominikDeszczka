using BLL;
using BLL.Models;
using BLL_Memory.Extensions;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Memory
{
    public class FilmyService : IFilmyService
    {
        private static int IdGen = 1;
        private static List<FilmyEntity> filmy =
            [
  new FilmyEntity() { ID = IdGen++, Tytul = "Incepcja", Rezyser = "Christopher Nolan", Gatunek = "Sci-Fi", Rok_wydania = 2010 },
  new FilmyEntity() { ID = IdGen++, Tytul = "Parasite", Rezyser = "Bong Joon-ho", Gatunek = "Dramat", Rok_wydania = 2019 },
  new FilmyEntity() { ID = IdGen++, Tytul = "Skazani na Shawshank", Rezyser = "Frank Darabont", Gatunek = "Dramat", Rok_wydania = 1994 },
  new FilmyEntity() { ID = IdGen++, Tytul = "Matrix", Rezyser = "Lana i Lilly Wachowski", Gatunek = "Sci-Fi", Rok_wydania = 1999 },
  new FilmyEntity() { ID = IdGen++, Tytul = "Gladiator", Rezyser = "Ridley Scott", Gatunek = "Historyczny", Rok_wydania = 2000 }
            ];

        public void Delete(int id)
        {
            var film = filmy.FirstOrDefault(f => f.ID == id);
            if (film == null)
            {
                throw new ApplicationException($"Film o ID {id} nie został znaleziony.");
            }

            filmy.Remove(film);
        }

        public IEnumerable<FilmyDTO> Get()
        {
            return filmy.Select(f => f.ToDTO());
        }

        public FilmyDTO GetById(int id)
        {
            FilmyEntity? filmyEntity = filmy.Find(os => os.ID == id);
            if (filmyEntity is null) { throw new ApplicationException("Not found {id}"); }
            return filmyEntity.ToDTO();
        }

        public void Post(FilmyPostDTO filmyPostDTO)
        {
            FilmyEntity filmyEntity = new FilmyEntity
            {
                Tytul = filmyPostDTO.Tytul,
                Rezyser = filmyPostDTO.Rezyser,
                ID = IdGen++,
                Rok_wydania = filmyPostDTO.Rok_wydania,
                Gatunek = filmyPostDTO.Gatunek
            };

            filmy.Add(filmyEntity);
        }

        public void Put(int id, FilmyPostDTO filmyPostDTO)
        {
            var film = filmy.FirstOrDefault(f => f.ID == id);
            if (film == null)
            {
                throw new ApplicationException($"Film o ID {id} nie został znaleziony.");
            }

            film.Tytul = filmyPostDTO.Tytul;
            film.Rezyser = filmyPostDTO.Rezyser;
            film.Rok_wydania = filmyPostDTO.Rok_wydania;
            film.Gatunek = filmyPostDTO.Gatunek;
        }
    }
}
