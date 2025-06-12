using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IFilmyService
    {
        public IEnumerable<FilmyDTO> Get();
        public FilmyDTO GetById(int id);
        public void Delete(int id);
        public void Put(int id, FilmyPostDTO filmyPostDTO);
        public void Post(FilmyPostDTO filmyPostDTO);
    }
}
