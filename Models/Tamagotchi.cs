using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace Tomagotchi.Models
{
    public class Attributes
    {
        private int _food;
        private int _attention;
        private int _sleep;
        // private Attributes _attributes;
        // private static List<TomaName> _instances = new List<TomaName> {};

        public Attributes(int food, int attention, int sleep)
        {
            _food = food;
            _attention = attention;
            _sleep = sleep;
        }

        public void SetFood(int newFood)
        {
            _food = newFood;
        }
        public int GetFood()
        {
            return _food;
        }

        public int GetTomaInfo()
        {
            return _food + _attention + _sleep;
        }

        public void SetAttention(int newAttention)
        {
            _attention = newAttention;
        }
        public int GetAttention()
        {
            return _attention;
        }

        public void SetSleep(int newSleep)
        {
            _sleep = newSleep;
        }
        public int GetSleep()
        {
            return _sleep;
        }
    }
}
