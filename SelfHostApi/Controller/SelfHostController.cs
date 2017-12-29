using System.Collections.Generic;
using System.Web.Http;
using System.Linq;

namespace SelfHostApi.Controller
{
    public class SelfHostController : ApiController
    {
        private static List<Cartoon> _cartoons = new List<Cartoon>()
        {
            new Cartoon { Id = 0, Name = "Pepe Le Pew"},
            new Cartoon { Id = 1, Name = "Charlie Brown"},
            new Cartoon { Id = 2, Name = "Piu-Piu" },
            new Cartoon { Id = 3, Name = "Frajola" },
            new Cartoon { Id = 4, Name = "Bob Esponja" }
        };

        // GET api/selfhost 
        public IEnumerable<Cartoon> Get()
        {
            return _cartoons;
        }

        // GET api/selfhost/3
        public Cartoon Get(int id)
        {
            return _cartoons.Where(x => x.Id == id).FirstOrDefault();
        }
    }

    public class Cartoon
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
