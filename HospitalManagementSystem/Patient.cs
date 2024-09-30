using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Patient : Person
    {
        public int PatientID { get; set; }
        public string Ailment { get; set; }
        public Doctor AssignedDoctor { get; set; }
        public Room AssignedRoom { get; set; }


        public Patient(string Name, int Age, Gender gender , int PatientID , string Ailment , Doctor AssignedDoctor ,Room AssignedRoom)  : base (Name, Age, gender)
        {
            this.PatientID = PatientID;
            this.Ailment = Ailment; 
            this.AssignedDoctor = AssignedDoctor;
            this.AssignedRoom = AssignedRoom;
        }

        public void AssignRoom(Room room) 
        
        {
            AssignedRoom = room;
            Console.WriteLine($"This room {AssignedRoom} for this patient {Name} ");
        }

        public void Discharge() 
        {

            AssignedRoom = null;
            Console.WriteLine($"Patient {Name} has been discharged.");



        }

        public override void DisplayInfo()
        {
        
            base.DisplayInfo();
            Console.WriteLine($"PatientID: {PatientID} | Ailment: {Ailment} ");

        }
        
        






    }
}
