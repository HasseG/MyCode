using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;


        public int Age
        {
            set 
            {   
                age = value;
                if (value <= 0)
                {
                    this.age= 0;
                }
                else
                {
                    this.age = 81;
                }
                
            }
            get { return age; }

        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public bool TreeAlive
        {
            get { return treeAlive; }
            set { treeAlive = value; }
        }
        public int NumOranges
        {
            get { return numOranges; }
        }
        
        public int OrangesEaten
        {
            get { return orangesEaten; }
        }
        public void OneYearPasses()
        {
            age++;

            if (age < 80) 
                {
                treeAlive = true;
                height = height + 2;
                }
            else
            {
                treeAlive = false;
            }
           
            
            if (age < 80)
            {
                numOranges = 0;
                numOranges = 5 * (age - 1);
            }
            else
            {
                numOranges = 0;
            }
            orangesEaten = 0;
                
        }
        public int EatOrange(int count)
        {
            if (numOranges > 0)
            {
                numOranges = numOranges - count;
                orangesEaten = orangesEaten + count;
            }
            return orangesEaten;
        }
    }
}
    
