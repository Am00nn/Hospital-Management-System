using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Appointment
    {

        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime AppointmentDate { get; set; }

        public Appointment(Patient patient, Doctor doctor, DateTime appointmentDate)
        {
            Patient = patient;
            Doctor = doctor;
            AppointmentDate = appointmentDate;

        }

        public void ScheduleAppointment(DateTime date) {

            AppointmentDate = date;
            Console.WriteLine($"Appointment scheduled for {Patient.Name} with Dr. {Doctor.Name} at {AppointmentDate} ");

        }
        public void CancelAppointment(DateTime date)
        {

            AppointmentDate = date;

            Console.WriteLine($"Appointment for this Patient {Patient.Name} with {Doctor.Name} has been cancelled ");
        
        }
        public void GetAppointmentDetails(DateTime date) 
        
        {
            if (AppointmentDate != date)
            {
                Console.WriteLine($"Appointment scheduled for {Patient.Name} with Dr. {Doctor.Name} at {AppointmentDate} ");

            }
            else
            { 
            
                Console.WriteLine("No Appointment scheduled ");
            
            }
        
        
        }


    }
}