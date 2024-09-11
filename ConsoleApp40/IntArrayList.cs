using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    public class IntArrayList
    {
        private int[] _mass;
        private int _massSize;
        private int _realMassSize;
        private readonly int _massDefaultSize = 2;
        private readonly int Count;
        private readonly int Capacity;
        public int index =0;
        public IntArrayList() 
        {
            _mass = new int[_massDefaultSize];

        }
        public IntArrayList(int value)
        {
            _mass = new int[value];
        }
        public void PushBack(int value)
        {
            if(index <= _mass.Length-1)
            {
                _mass[index] = value;
            }
            else
            {
                int[] newMass = new int[_mass.Length * 2];
                for (int i = _mass.Length-1; i > 0; i--)
                {
                    newMass[i] = _mass[i];
                }
                _mass = newMass;
                _mass[index] = value;

            }
            index++;


        }
        public void PopBack()
        {
            if(index == 0)
            {
                return;
            }
            else
            {
                index--;
                int[] newMass = new int[_mass.Length];
                for(int i = 0; i <= index; i++)
                {
                        newMass[i] = _mass[i];
                    

                }

            }
        }
        public bool TryInsert(int index, int value) 
        {
            if (index < 0)
            {
                return false;
            }
            else if(index <= _mass.Length)
            {
                _mass[index-1] = value;
                return true;
            }
            else if(index == _mass.Length)
            {
                PushBack(value);
                return true;
            }
            return false;
        }
        public bool TryErase(int index)
        {
            if (index < 0 || index > _mass.Length)
            {
                return false;
            }
            int[] newMass = new int[_mass.Length];
            for (int i = 0; i <= index; i++)
            {
                if(i!=index)
                {
                    newMass[i] = _mass[i];
                }



            }
            return true;
        }
        public bool TryGetAt(int index, out int result)
        {
            if (index < 0 || index > _mass.Length)
            {
                result = 0;
                return false;
                
            }
            else
            {
                result = _mass[index];
                return true;
            }

        }
        public void Clear()
        {
            index = 0;
            int[] newMass = new int[0];
            _mass = newMass;
        }
        public bool TryForceCapacity(int newCapacity)
        {
            if (newCapacity<0)
            {
                return false;
            }
            int[] newMass = new int[newCapacity];

            for (int i = 0; i < newCapacity; i++)
            {
                if (_mass.Length-1 < i)
                {
                    break;
                }
                newMass[i] = _mass[i];
            }
            return true;
        }
        public int Find(int value)
        {
            int findValue = -1;
            for(int i = 0; i < _mass.Length; i++)
            {
                if (_mass[i]== value)
                {
                    findValue = i;
                }


            }
            return findValue;
        }

    }
}
