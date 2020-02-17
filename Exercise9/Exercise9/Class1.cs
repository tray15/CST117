using System;
using System.Collections.Generic;
using System.Linq;

//Lydia's code - find the errors!
namespace Exercise9
{
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }
        
        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
                    /*
                    return true;
                else
                    return false;
                    */
            }
            return false;
            //always returned false. removed else statement.
            //return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {
            var unionedSet = new Set();

            for (int i = 0; i < this.elements.Count; i++)
            {
                unionedSet.addElement(this.elements[i]);
            }
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                unionedSet.addElement(rhs.elements[i]);
            }

            return unionedSet;

            // This loop only returns rhs which is the B set in the main program. another loop for this.elements was needed to get both halves
            // also a new set was needed to store both of them so the Set A was not overwritten with both lists after the union.
            /*
       
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                this.addElement(rhs.elements[i]);
            }
            return rhs;

            */
        }
    }
}
