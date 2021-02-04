using System;
using System.Collections.Generic;
using System.Text;

namespace task_on_cSharp
{
    public interface ITrip
    {

        public void addTrip();

        public void editTrip();

        public void deleteTrip();

        public void searchByPrice(String price);

        public void viewTrips();

        public void viewLatestTrips();

        public void editPassenger();

        public void viewPassengers();

        public void exit();

    }

}

