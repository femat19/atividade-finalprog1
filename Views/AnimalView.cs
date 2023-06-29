using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Controllers;
using Arquivos.Models;

namespace Arquivos.Views
{
    public class AnimalView
    {

        private AnimalController animalController;
        private ClientController clientController;

        public AnimalView()
        {
            animalController = new AnimalController();
            clientController = new ClientController();
            this.Init();
        }        

        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("YOU ARE AT ANIMALS");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Insert Animal");
            Console.WriteLine("2 - List All Animals");
            Console.WriteLine("3 - Export Animals");
            Console.WriteLine("4 - Import Animals");
            Console.WriteLine("5 - Search For Animals");
            Console.WriteLine("");

            int option = 0;
            option = Convert.ToInt32( Console.ReadLine() );

            switch(option)
            {
                case 1 : 
                    Insert();
                break;

                case 2 :                    
                break;

                case 3 :                    
                break;

                case 4 :                    
                break;

                case 5 :                    
                break;                

                default: 
                break;
            }
        }

        private void Insert()
        {
            Animal animal = new Animal();

            animal.Id = animalController.GetNextId();

            Console.WriteLine("Inform the name of the Animal:");
            animal.Name = Console.ReadLine();

            Console.WriteLine("Select client for ID:");
            Console.WriteLine("------------");
            foreach(var client in clientController.List())
            {
                Console.WriteLine(client.ToString());
                Console.WriteLine("------------");
            }
            Console.WriteLine("------------");
            Console.WriteLine("Inform ID:");
            int id = Convert.ToInt32( Console.ReadLine() );

            animal.Client = clientController.GetClientById(id);

            bool retorno = animalController.Insert(animal);

            if( retorno )
                Console.WriteLine("successfully inserted animal");
            else    
                Console.WriteLine("fail to insert the animal, please try again");
        }        

    }
}