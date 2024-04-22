using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string NumPhone { get; set; }
        public string Email { get; set; }
        public float Salario { get; set; }
        public string Cargo { get; set; }
        public string Senha { get; set; }
        public string CEP { get; set; }
        public string City { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public int HomeNum { get; set; }
        public string Complemento { get; set; }
        public byte Img { get; set; }
    }
}
