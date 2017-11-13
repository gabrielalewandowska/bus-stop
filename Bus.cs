using System;
using System.Collections.Generic;

namespace bus_lab
{
    public class Bus
    {

        public int Number { get; set; }
        public string Destination { get; set; }
        public List<Person> Passengers { get; set; }
         
        public Bus(int number, string destination){
            this.Number = number;
            this.Destination = destination;
            this.Passengers = new List<Person>();
        }

        public string Drive(){
            return "Brum brum!";
        }

        public int GetNumberOfPassengers(){
            //int counter = 0;
            //foreach(var person in this.Passengers){
            //    if(person != null){
            //        counter++;
            //    }
            //}
            //return counter;
            return this.Passengers.Count;
        }

        //public bool IsFull()
        //{
        //    return this.GetNumberOfPassengers() == this.Passengers.Length;
        //}

        public void PickUp(Person passenger)
        {
            //if (this.IsFull())
            //{
            //    return;
            //}

            //int passengerCount = this.GetNumberOfPassengers();
            //this.Passengers[passengerCount] = passenger;
            this.Passengers.Add(passenger);
        }

        public void DropOff(Person passenger)
        {
            //for (var i = 0; i < this.Passengers.Count; i++)
            //{
            //    if(this.Passengers[i] == passenger)
            //    {
            //        this.Passengers[i] = null;
            //    }
            //}

            this.Passengers.Remove(passenger);
        }

        public void Empty()
        {
            //for (var i = 0; i < this.Passengers.Length; i++)
            //{
            //    this.Passengers[i] = null;
            //}

            this.Passengers.Clear();
        }
 
    }
}

