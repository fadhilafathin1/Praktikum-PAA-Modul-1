using Microsoft.AspNetCore.Mvc;
using PercobaanApi1.Models;

namespace PercobaanApi1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("api/person")]
        public ActionResult<Person> ListPerson()
        {
            IsiPerson context = new IsiPerson();
            List<Person> ListPerson = context.ListPerson();
            return Ok(ListPerson);
        }
        [HttpGet("api/person/{id}")]
        public ActionResult<Person> GetPerson(int id)
        {
            IsiPerson context = new IsiPerson();
            var person = context.ListPerson().FirstOrDefault(p => p.id_person == id);

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }
    }
}
