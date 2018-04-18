using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace Tamagotchi.Models
{
    public class TamaName
    {
        private string _name;
        private int _id;
        private Attributes _attributes;
        private static List<TamaName> _instances = new List<TamaName> {};


        public TamaName(string Name, Attributes attributes)
        {
            _name = Name;
            _attributes = attributes;
            _instances.Add(this);
            _id = _instances.Count;

        }

        public void SetName(string newName)
        {
            _name = newName;
        }
        public string GetName()
        {
            return _name;
        }

        public Attributes GetAttributes()
        {
          return _attributes;
        }

        public int GetId()
        {
            return _id;
        }
        public static List<TamaName> GetAll()
        {
            return _instances;
        }
        public static TamaName Find(int searchId)
        {
            return _instances[searchId-1];
        }


    }
}
