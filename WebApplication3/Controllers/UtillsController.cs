using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication3.Models;
using WebApplication3.Services;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UtillsController : Controller
    {
        [HttpGet]
        public List<Student> GetStudents()
        {
            return new UtillsService().GetStudents();




        }
  
    }
}
