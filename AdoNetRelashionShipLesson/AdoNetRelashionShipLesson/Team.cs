using System.Collections.Generic;

namespace AdoNetRelashionShipLesson
{
   public class University
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
