using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tkey,Tval>
    {
        Tkey[] _keys;
        Tval[] _values;

        public MyDictionary() //initialize
        {
             _keys = new Tkey[0];
             _values = new Tval[0];

        }

        public void Add(Tkey key, Tval value)
        {
            Tkey[] _tempKeys = _keys;
            Tval[] _tempValues = _values;

            _keys = new Tkey[_keys.Length + 1];
            _values = new Tval[_values.Length + 1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _keys[i] = _tempKeys[i];
                _values[i] = _tempValues[i];

            }

            _keys[_tempKeys.Length] = key;
            _values[_tempValues.Length] = value;
        }

            

        public int Count
        {
            get { return _keys.Length; }
            
        }

        

        public Tkey[] Keys
        {
            get { return _keys; }
            
        }



        public Tval[] Values
        {
            get { return _values; }
            
        }





    }

    
}
