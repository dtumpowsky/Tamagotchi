using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace Tomagotchi.Models
{
    public class TomaName
    {
        private string _name;
        private int _id;
        private Attributes _attributes;
        private static List<TomaName> _instances = new List<TomaName> {};


        public TomaName(string Name, Attributes attributes)
        {
            _name = Name;
            _instances.Add(this);
            _id = _instances.Count;
            _attributes = attributes;
        }

        public void SetName(string newName)
        {
            _name = newName;
        }
        public string GetName()
        {
            return _name;
        }

        public Attributes GetAttribute()
        {
          return _attributes;
        }

        public int GetId()
        {
            return _id;
        }
        public static List<TomaName> GetAll()
        {
            return _instances;
        }
        public static TomaName Find(int searchId)
        {
            return _instances[searchId-1];
        }
    }
}
