using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    internal class Employee
    {
        private string _name;
        private string _surName;
        private int _salary;
        public string MyProperty
        {
            get => this._name;
            set
            {
                if (nameSurnameControl(value))
                {



                    this._name = value;
                }
            }

        }
        public string MyProperty1 { get => this._surName;
                set
            {
                if (nameSurnameControl(value))
                {
                    this._surName= value;
                }
            } 
   
        }
        public int MyProperty2 { get=> this._salary;
                set
            {
                if (value>250)
                {
                    this._salary = value;
                }
            }
        }
        public bool nameSurnameControl(string a)
        {
            if (string.IsNullOrWhiteSpace(a))
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (char.IsUpper(a[0]) && char.IsLetter(a[i]))
                    {
                        return true;


                    }

                }
                

            }
            return false;





        }
        




    }
    }

