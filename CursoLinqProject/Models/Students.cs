using System;
using System.Collections.Generic;

namespace CursoLinqProject.Models
{
    class Students
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Gender { get; set; }
        public List<string> Subjects { get; set; }


    }
}