using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_14
{
    interface IGarage
    {
        void AddCar(Car c);
        void TakeOutCar(Car c);
        void FixCar(Car c);
    }
}
