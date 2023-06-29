using Arquivos.Views;
using Arquivos.Utils;


Bootstrapper.ChargeClients();


int option = 0;

do
{
    Console.WriteLine("*******************************************");
    Console.WriteLine("Software for read and export data");
    Console.WriteLine("*******************************************");
    Console.WriteLine("");    
    Console.WriteLine("1 - Clients");
    Console.WriteLine("2 - Animals");

    option = Convert.ToInt32( Console.ReadLine() );

    switch(option)
    {
        case 1 :
            Console.WriteLine("CLIENTS OPTIONS");
            ClientView clientView = new ClientView();
        break;

        case 2 :
            Console.WriteLine("ANIMALS OPTIONS");
            AnimalView animalView = new AnimalView();
        break;        
    }
}
while( option > 0 );