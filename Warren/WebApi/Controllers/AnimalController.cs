using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private AnimalRepository repo;

        public AnimalController()
        {
            this.repo = new AnimalRepository();
        }

        [HttpGet]
        public List<Animal> Get()
        {     
            return repo.GetAll();
        }
        [HttpPost]
        public string Post(Animal model)
        {
            return repo.Create(model);
        }
    }
}
