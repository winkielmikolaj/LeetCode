using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    public class ParkingSystem
    {
        private int[] cars;

        public ParkingSystem(int big, int medium, int small)
        {
            cars = [0, big, medium, small];
        }

        public bool AddCar(int carType)
        {

            if (cars[carType] > 0)
            {
                cars[carType] = cars[carType] - 1;
                return true;
            }

            return false;
        }
    }
}
