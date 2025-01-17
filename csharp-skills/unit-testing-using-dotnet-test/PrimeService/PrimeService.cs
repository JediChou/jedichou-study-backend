﻿using System;

namespace Prime.Service
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            int i = 0;
            if (candidate < 2) return false; 
            for (var divisor = 2; divisor <= Math.Sqrt(candidate); divisor++) 
                if (candidate % divisor == 0) return false; 
            return true; 
        }
    }
}