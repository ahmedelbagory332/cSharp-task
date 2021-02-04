using System;
using System.Collections;
using System.Text;

namespace task_on_cSharp
{
    public class Trip_Model
    {

        public int id;
        public String passengerName;
        public String price;
        public String country;

        public Trip_Model(int id, String passengerName, String price, String country)
        {
            this.id = id;
            this.passengerName = passengerName;
            this.price = price;
            this.country = country;
        }


    }

}


