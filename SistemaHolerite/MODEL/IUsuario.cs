using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL
{
    public interface IUsuario
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<String> Permissions { get; set; }
        public float Wage { get; set; }
    }
}
