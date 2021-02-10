using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> :  DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message)
        {

        }

        public SuccessDataResult(T data) : base(data,true)
        {

        }
        public SuccessDataResult(string message): base(default,true,message) //Çok fazla kullanılmaz ama alternatif kullanımdır
        {

        }

        public SuccessDataResult():base(default,true)//Çok fazla kullanılmaz ama alternatif kullanımdır
        {

        }
    }
}
