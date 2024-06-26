﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class DataHandler
    {
        private string dataFileName;
        public string DataFileName
        {
            get { return dataFileName; }
        }

        public DataHandler(string dataFileName)
        {
            this.dataFileName = dataFileName;
        }
        
        public void SavePerson(Person person)
        {
            using (StreamWriter sw = new StreamWriter(DataFileName))
            {
                sw.Write(person.MakeTitle());
            }
        }
        public Person LoadPerson()
        {
            using (StreamReader sr = new StreamReader(DataFileName))
            {
                string line = sr.ReadLine();
                string[] data = line.Split(";");
                Person person = new Person(data[0], DateTime.Parse(data[1]), double.Parse(data[2]), bool.Parse(data[3]), int.Parse(data[4]));

                return person;
            }
        }
    }
}
