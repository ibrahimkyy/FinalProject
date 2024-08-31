using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {


        public Result(bool success, string message):this(success)//tek parametreli olan constracterin çalışmasını istiyosam değişkeni yazar sonra onu tek parametreli successe yönlendiririm
        {
            Message = message;
           
        }

        public Result(bool success)
        {
            
            Success = success;
        }

        public bool Success { get; }
        //Burda set konulmamasına rağmen cevap yazıyo olmamızın sebebi okunurluğu standardize etmek 
        public string Message { get; }

     
    }
}
