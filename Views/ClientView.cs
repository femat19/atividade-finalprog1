using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Views
{
    public class ClientView
    {
        private ClientController clientController;

        public ClientView()
        {
            clientController = new ClientController();
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("YOU ARE AT CLIENTS");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Insert Client");
            Console.WriteLine("2 - List Clients");
            Console.WriteLine("3 - Export Clients");
            Console.WriteLine("4 - Import Clients");
            Console.WriteLine("5 - Search Clients");
            Console.WriteLine("");

            int option = 0;
            option = Convert.ToInt32( Console.ReadLine() );

            switch(option)
            {
                case 1 : 
                    Insert();
                break;

                case 2 :
                    List();
                break;

                case 3 :
                    Export();
                break;

                case 4 :
                    Import();
                break;

                case 5 :
                    SearchByName();
                break;                

                default: 
                break;
            }
        }

        private void List()
        {
            List<Client> listagem = 
                clientController.List();

            for(int i = 0; i < listagem.Count; i++)
            {                
                Console.WriteLine( Print( listagem[i] ) );
            }

        }

        private string Print(Client client)
        {
            string retorno = "";
            retorno += $"Id: {client.Id} \n";
            retorno += $"Name: {client.FirstName} {client.LastName} \n";
            retorno += "-------------------------------------------\n";

            return retorno;

        }

        private void Insert()
        {
            Client client = new Client();

            client.Id = clientController.GetNextId();

            Console.WriteLine("Inform the first name:");
            client.FirstName = Console.ReadLine();

            Console.WriteLine("Inform the last name");
            client.LastName = Console.ReadLine();

            Console.WriteLine("Inform CPF:");
            client.CPF = Console.ReadLine();            

            Console.WriteLine("Inform the Email:");
            client.Email = Console.ReadLine();     

            bool return = clientController.Insert(client);

            if( return )
                Console.WriteLine("sucessfully inserted client!");
            else    
                Console.WriteLine("fail to insert, please try again!");
        }


        private void Export()
        {
            if( clientController.ExportToTextFile() )            
                Console.WriteLine("Successfully created file");            
            else                            
                Console.WriteLine("The process has failed");
        }

        private void Import()
        {
            if(clientController.ImportFromTxtFile())
                Console.WriteLine("Data imported successfully!");
            else
                Console.WriteLine("Error to import data");
        }

        private void SearchByName()
        {
            Console.WriteLine("Search for client name");
            Console.WriteLine("Write the name:");
            string name = Console.ReadLine();

            foreach( Client c in 
                clientController.SearchByName(name) )
            {
                Console.WriteLine( c.ToString() );
            }
        }
    }
}