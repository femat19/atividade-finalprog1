using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Utils
{
    public static class Bootstrapper
    {
        public static void ChargeClients()
        {
            var c1 = new Client{
                Id = 1,
                FirstName = "Felipe Matheus",
                LastName = "da Rosa",
                CPF = "671.673.790-18",
                Email = "Fematheus567@gmail"
            };
            DataSet.Clients.Add(c1);

            DataSet.Clients.Add(
                new Client{
                    Id = 2,
                    FirstName = "Jefferson",
                    LastName = "caminhões",
                    CPF = "621.904.810-58",
                    Email = "jefferson.caminhoes@outlook.com"                    
                }
            );

             DataSet.Clients.Add(
                new Client{
                    Id = 3,
                    FirstName = "Lucas",
                    LastName = "Brazino",
                    CPF = "400.289.220-00",
                    Email = "brazino.jogodagalera@hotmail.com"                    
                }
            );            

        }
    }
}