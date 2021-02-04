using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace task_on_cSharp
{
    public class TripActions : ITrip
    {
       private List<Trip_Model> trip_Models;
       private int trips;
        private int counter = 0;
        private int searchCounter = 0;
        public void addTrip()
        {
           
            Console.WriteLine("\nHow many trips want you to add : ");
             trips = Convert.ToInt32(Console.ReadLine());
            if (trips>0) {
                trip_Models = new List<Trip_Model>();

                for (int i = 0; i < trips; i++)
                {
                    counter = i + 1;
                    Console.WriteLine("Enter trip " + counter + " info : ");
                    Console.WriteLine("Enter trip id ");
                    int tripId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter passenger name ");
                    String passengerName = Console.ReadLine();
                    Console.WriteLine("Enter price ");
                    String price = Console.ReadLine();
                    Console.WriteLine("Enter country ");
                    String country = Console.ReadLine();
                    trip_Models.Add(new Trip_Model(tripId, passengerName, price, country));
                }
            }
            else
                Console.WriteLine("You must enter number more than 0");


        }

        public void deleteTrip()
        {
            if (trip_Models.Count == 0) {
                Console.WriteLine("You have no trips to delete");

            }
            else {
                Console.WriteLine("You have : " + trip_Models.Count + " trips");
                Console.WriteLine("Enter trip id you want to delete");
                int tripId = Convert.ToInt32(Console.ReadLine());
                Trip_Model deletedTrip = trip_Models.Find(trip => tripId == trip.id);
                bool isDeleted = trip_Models.Remove(deletedTrip);
                if (isDeleted)
                    Console.WriteLine("Now you have : " + trip_Models.Count + " trips");
                else
                    Console.WriteLine("Please check trip id");
            }
          
            }



            public void editPassenger()
        {
            if (trip_Models.Count == 0)
            {
                Console.WriteLine("You have no passenger to edit");

            }
            else
            {

                Console.WriteLine("Enter trip id edit its passenger");
                int tripId = Convert.ToInt32(Console.ReadLine());
                Trip_Model editTrip = trip_Models.Find(trip => tripId == trip.id);
                Console.WriteLine("Enter passenger name ");
                String passengerName = Console.ReadLine();
                editTrip.passengerName = passengerName;
               

                Console.WriteLine("\nYour trips after edit");
                for (int i = 0; i < trips; i++)
                {
                    Console.WriteLine("Trip id : " + trip_Models[i].id + "\n" + "Passenger name : " + trip_Models[i].passengerName + "\n" + "Country : " + trip_Models[i].country + "\n" + "Price : " + trip_Models[i].price + "\n");
                }

            }
        }

        public void editTrip()
        {
            if (trip_Models.Count == 0)
            {
                Console.WriteLine("You have no trips to edit");

            }
            else
            {
                 
                Console.WriteLine("Enter trip id you want to edit");
                int tripId = Convert.ToInt32(Console.ReadLine());
                Trip_Model editTrip = trip_Models.Find(trip => tripId == trip.id);
                Console.WriteLine("Enter passenger name ");
                String passengerName = Console.ReadLine();
                editTrip.passengerName = passengerName;
                Console.WriteLine("Enter price ");
                String price = Console.ReadLine();
                editTrip.price = price;
                Console.WriteLine("Enter country ");
                String country = Console.ReadLine();
                editTrip.country = country;

                Console.WriteLine("\nYour trips after edit");
                for (int i = 0; i < trips; i++)
                {
                    Console.WriteLine("Trip id : " + trip_Models[i].id + "\n" + "Passenger name : " + trip_Models[i].passengerName + "\n" + "Country : " + trip_Models[i].country + "\n" + "Price : " + trip_Models[i].price + "\n");
                }
                 
            }
        }

        public void  exit()
        {

        }

        public void  searchByPrice(String price)
        {
            if (trip_Models.Count != 0)
            {
                for (int i = 0; i < trips; i++)
                {
                    if (trip_Models[i].price.Equals(price))
                    {
                        searchCounter++;
                        continue;
                    }
                }
                Console.WriteLine("You have " + searchCounter + " trip for this price");

            }
            else
                Console.WriteLine("You have no trips to view");
        }

        public void viewLatestTrips()
        {
            if (trip_Models.Count!=0) 
            Console.WriteLine("Trip id : " + trip_Models[trips - 1].id + "\n" + "Passenger name : " + trip_Models[trips - 1].passengerName + "\n" + "Country : " + trip_Models[trips - 1].country + "\n" + "Price : " + trip_Models[trips - 1].price + "\n");
          else
                Console.WriteLine("You have no trips to view");
        }

        public void  viewPassengers()
        {
            if (trip_Models.Count != 0)
            {
                for (int i = 0; i < trips; i++)
                {
                    Console.WriteLine( "Passenger name : " + trip_Models[i].passengerName);
                }
            }
            else
                Console.WriteLine("You have no passengers to view");
        }



        public void  viewTrips()
        {
            if (trip_Models.Count != 0) {
                for (int i = 0; i < trips; i++)
                {
                    Console.WriteLine("Trip id : " + trip_Models[i].id + "\n" + "Passenger name : " + trip_Models[i].passengerName + "\n" + "Country : " + trip_Models[i].country + "\n" + "Price : " + trip_Models[i].price + "\n");
                }
            }
            else
                Console.WriteLine("You have no trips to view");
        }
    }
}
