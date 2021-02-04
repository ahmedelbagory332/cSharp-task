using System;
using task_on_cSharp;

namespace task_on_cSharp
{
    public class Program
    {

         static void Main(string[] args)
        {
            int option ;
            String repeat = "";
            Console.WriteLine("\n\t1 - Add Trip\t\t5 - View Trips\n\t2 - Edit Trip\t\t6 - View Latest Trips\n\t3 - Delete Trip\t\t7 - Edit Passenger \n\t4 - Search By Price\t8 - View Passengers\n\n\t\t\t9 - Exit ");
            
            Console.WriteLine("\n\n Choose option : ");
            option = Convert.ToInt32(Console.ReadLine());
            TripActions tripActions = new TripActions();

        A: switch (option)
                {
                    case 1:
                        tripActions.addTrip();
                        break;
                    case 2:
                    tripActions.editTrip();
                    break;
                    case 3:
                        tripActions.deleteTrip();
                        break;
                    case 4:
                        Console.WriteLine("\n\n Enter price ");
                        String price = Console.ReadLine();
                        tripActions.searchByPrice(price); 
                    break;
                    case 5:
                       tripActions.viewTrips();
                    break;
                    case 6:
                        tripActions.viewLatestTrips();
                        break;
                    case 7:
                        tripActions.editPassenger();
                    break;
                    case 8:
                        tripActions.viewPassengers();
                    break;
                    case 9:
                        tripActions.exit();
                        break;
                    default:
                        Console.WriteLine("Wrong choose");
                        break;
                }
               Console.WriteLine("Do you want to choose another option(y/n)");
               repeat = Console.ReadLine();
            if (repeat.ToLower().Equals("y")) {
                Console.WriteLine("\n\n Choose option : ");
                option = Convert.ToInt32(Console.ReadLine());
                goto A;
            }












        }
    }

}

