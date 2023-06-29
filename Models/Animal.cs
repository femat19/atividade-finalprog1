using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{
    public class Animal
    {
        public int Id {get;set;}
        
        public string Name {get; set;}

        public Client Client {get;set;}
    }
}