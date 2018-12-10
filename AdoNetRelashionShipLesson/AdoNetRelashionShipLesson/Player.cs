using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace AdoNetRelashionShipLesson
{
    public class Student
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public int Number { get; set; }
        public int TeamID { get; set; }
        public ICollection<University> Universities { get; set; }
    }
}
