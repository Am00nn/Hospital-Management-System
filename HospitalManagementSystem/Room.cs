using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Room
    {

        public int RoomNumber { get; set; }
        public bool IsOccupied { get; set; }
        public enum RoomType
        {
            General,
            ICU,
            OperationTheater
        }
        public RoomType Type { get; set; }

        public void OccupyRoom()
        {
            if (IsOccupied)
            {

                Console.WriteLine($"Room {RoomNumber} is now occupied.");


            }

            else 
            {
                Console.WriteLine($"Room {RoomNumber} is already occupied.");

            }
        
        
        }

        public void VacateRoom() 
        {

            if (IsOccupied)
            {
                Console.WriteLine($"Room {RoomNumber} is now available.");


            }
            else 
            {

                Console.WriteLine($"Room {RoomNumber} is already available.");

            }
        
        }

    }
}
