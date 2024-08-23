using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data,bool success,string message):base(success,message) //base burda result o yüzden this demeye gerek yok burda base yazmamızın sebebi veriyi newlemek zorunda kalmamak otomatik baseye gönderiyoruz
        {
           Data = data;
        }
        public DataResult(T data ,bool success):base(success) 
        {
            Data = data;
        }
        public T Data { get; }
    }
}