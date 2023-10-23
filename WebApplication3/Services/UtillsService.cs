using System.Collections.Generic;
using System.Linq;
using WebApplication3.Models;

namespace WebApplication3.Services
{
    public class UtillsService
    {
        BMContext db = new BMContext();
        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }
    }
}
