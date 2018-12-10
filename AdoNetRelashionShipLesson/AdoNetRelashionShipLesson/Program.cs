using System.Linq;

namespace AdoNetRelashionShipLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Localhost())
            {
                var result = context.Players.ToList();
            }
        }
    }
}
