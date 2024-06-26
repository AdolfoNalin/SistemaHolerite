﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL
{
    public class Client 
    {
        public int Cod { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string NumPhone { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public string City { get; set; }
        public string Neighbordhood { get; set; }
        public string Street { get; set; }
        public int NumHome { get; set; }
        public string Complement { get; set; }
        public byte Img { get; set; }
    }
}
