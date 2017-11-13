using System;
namespace bus_lab
{
    public class Bus
    {

        public int Number { get; set; }
        public string Destination { get; set; }
        public Person[] Passengers { get; set; }
         
        public Bus(int number, string destination){
            this.Number = number;
            this.Destination = destination;
            this.Passengers = new Person[20];
        }

        public string Drive(){
            return "Brum brum!";
        }

        public int GetNumberOfPassengers(){
            int counter = 0;
            foreach(var person in this.Passengers){
                if(person != null){
                    counter++;
                }
            }
            return counter;
        }

        public bool IsFull()
        {
            return this.GetNumberOfPassengers() == this.Passengers.Length;
        }

        public void PickUp(Person passenger)
        {
            if (this.IsFull())
            {
                return;
            }

            int passengerCount = this.GetNumberOfPassengers();
            this.Passengers[passengerCount] = passenger;
        }

        public void DropOff(Person passenger)
        {
            for (var i = 0; i < this.Passengers.Length; i++)
            {
                if(this.Passengers[i] == passenger)
                {
                    this.Passengers[i] = null;
                }
            }
        }

        public void Empty()
        {
            for (var i = 0; i < this.Passengers.Length; i++)
            {
                this.Passengers[i] = null;
            }
        }
 
    }
}

