using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_Practice_Generics
{
    internal class DataList<T>
    {

        private T[] _datas;
        private static object[] _data;

        public DataList()
        {
            _datas = Array.Empty<T>();
        }

        public void Add(T data)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[_datas.Length - 1] = data;
        }

        public T[] GetAll()
        {
            return _datas;
        }

        public static T[] Get_datas<T>()
        {
                    
            return _datas;
        }

        public static T[] Delete<T>(T[] data, int index, T[] _datas)

        {
            if(index < 0 || index >= data.Length)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            {
                Array.Resize(ref _datas, _datas.Length - 1 );
                _datas[_datas.Length + 1] = data;
            }

            return data;

        }



        


    }

}

