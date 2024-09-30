using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Doctor : Person
    {
        public int DoctorID { get; set; }
        public string Specialization { get; set; }
        public List<Patient> PatientsList { get; set; }

        public Doctor(string Name, int Age, Gender gender, int DoctorID, string Specialization) : base(Name, Age, gender)
        {

            this.PatientsList = new List<Patient>();    
            this.DoctorID = DoctorID;
            this.Specialization = Specialization;

        }

        public void AddPatient(Patient patient)
        {

            PatientsList.Add(patient);
            Console.WriteLine($"patient : {patient.Name} add to doctor {Name} list ");
 
        }
        public void RemovePatient(Patient patient) 
        { 
        
            PatientsList.Remove(patient);
            Console.WriteLine($"patient : {patient.Name} Rmove from doctor {Name} list ");


        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"DoctorID: {DoctorID} | Specialization: {Specialization} ");
        }



    }

}
