using System;
using System.Collections.Generic;

namespace Planner {
    public class City {
        private string _name;
        public string Mayor { get; set; }
        public int YearEstablished { get; set; }
        private List<Building> Buildings;

        public City (string name) {
            _name = name;
        }
    }
};