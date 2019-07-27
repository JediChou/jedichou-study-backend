using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyTest_VS2008.generic.example1
{
    public class FindRacer
    {
        private readonly string _car;

        public FindRacer(string car)
        {
            _car = car;
        }

        public bool DrivingCarPredicate(Racer racer)
        {
            return racer.Car == _car;
        }
    }
}
