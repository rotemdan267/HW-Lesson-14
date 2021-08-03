using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_14
{
    class Garage : IGarage
    {
        public Car[] cars;
        public string[] carTypes { get; set; }

        public Garage(params string[] carTypes)
        {
            this.carTypes = carTypes;
        }
        public Garage(params Car[] _cars)
        {
            this.cars = _cars;
        }

        public void AddCar(Car c)
        {
            bool flag = true;
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == c)
                {
                    flag = false;
                }
            }
            if (!flag)
            {
                throw new CarAlreadyHereException("Car already here");
            }
            if (c.TotalLost)
            {
                throw new WeDoNotFixTotalLostException("We Do Not Fix Total Lost");
            }
            flag = false;
            for (int i = 0; i < carTypes.Length; i++)
            {
                if (c.Brand == carTypes[i])
                {
                    flag = true;
                }
            }
            if (!flag)
            {
                throw new WrongGarageException("we do not fix this type of car");
            }
            if (c == null)
            {
                throw new CarNullException("null");
            }
            if (c.NeedsRepair == false)
            {
                throw new RepairMismatchException("this car is OK");
            }
        }

        public void TakeOutCar(Car c)
        {
            if (c == null)
            {
                throw new CarNullException("null");
            }
            bool flag = false;
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == c)
                {
                    flag = true;
                }
            }
            if (!flag)
            {
                throw new CarNotInGarageException("car not in garage");
            }
            if (c.NeedsRepair == true)
            {
                throw new CarNotReady("car not ready");
            }
        }

        public void FixCar(Car c)
        {
            if (c == null)
            {
                throw new CarNullException("null");
            }

            bool flag = false;
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == c)
                {
                    flag = true;
                }
            }
            if (!flag)
            {
                throw new CarNotInGarageException("car not in garage");
            }

            if (c.NeedsRepair == false)
            {
                throw new RepairMismatchException("this car is OK");
            }

            c.NeedsRepair = false;
        }
    }
}
