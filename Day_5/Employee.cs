using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class Employee
    {
        private string _fio;
        private double _wages;
        private int _department;
        private int _id;
        public Employee(string fio, double wages, int department, int id)
        {
            _fio = fio;
            _wages = wages;
            _department = department;
            _id = id;
        }
        public string fio
        {
            get => _fio;
            set => _fio = value;
        }
        public double wages
        {
            get => _wages;
            set => _wages = value;
        }
        public int department
        {
            get => _department;
            set => _department = value;
        }
        public int Id
        {
            get => _id;
            set => _id = value;
        }

    }
}

