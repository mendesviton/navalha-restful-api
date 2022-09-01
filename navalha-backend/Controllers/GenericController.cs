using Microsoft.AspNetCore.Mvc;
using data.model;
using data.repository;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T, R> : ControllerBase where T : BaseModel where R : BaseRepository<T>
    {
        private BaseRepository<T> repo;
        public GenericController()
        {
            this.repo =  Activator.CreateInstance<R>();
        }



        public GenericController(R repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public List<T> Get()
        {
            return repo.GetAll();
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return repo.GetById(id);
        }

        [HttpPost]
        public string Post(T model)
        {
            return repo.Create(model);
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return repo.Delete(id);
        }

        [HttpPut]
        public string Put(T model)
        {
            return repo.Update(model);
        }
    }
}
