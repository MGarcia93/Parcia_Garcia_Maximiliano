using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Mago
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Casa casa { get; set; }
        public List<Hechizo> hechizos { get; set; }

        public Mago()
        {
            casa = new Casa();
        }
    }

}
