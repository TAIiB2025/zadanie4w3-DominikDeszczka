using BLL;
using BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmyController :ControllerBase
    {
        private readonly IFilmyService filmyService;
   

         public FilmyController(IFilmyService filmyService)
        {
            this.filmyService = filmyService;
        }

        //serwer/api/filmy
        [HttpGet]
        public IEnumerable<FilmyDTO> Get()
        {
            return filmyService.Get();
        }

        //serwer/api/filmy/4
        [HttpGet("{id}")]
        public FilmyDTO GetByID(int id)
        {
            return filmyService.GetById(id);
        }

        //server/api/filmy
        [HttpPost]
        public void Post([FromBody] FilmyPostDTO o)
        {
            filmyService.Post(o);
        }

        //server/api/filmy/4
        [HttpPut("{id}")]
        public void Put(int id, FilmyPostDTO film)
        {
            filmyService.Put(id, film);
        }

        //server/api/filmy/4
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            filmyService.Delete(id);
        }
    }
}