using System;
using CrudCoreTest.Domain;

namespace FatemehMontazeriCrudCoreTest.Presentation.ExtenstionMethods
{
    public static class DateTimeExtensionMethods
    {

        public static DateTime ToDateTime(this string datetimeString)
        {
        
            var inputArr = datetimeString.Split('/');
            if(inputArr.Length<3) throw  new BusinessException("Enter your birthdate correctly");
            return  new DateTime(Int32.Parse(inputArr[2]) , Int32.Parse(inputArr[1]) , Int32.Parse(inputArr[0]));
        }

        public static string ToStringFormat(this DateTime dateTtime)
        {
            return $"{dateTtime.Day}/{dateTtime.Month}/{dateTtime.Year}";
        }
    }
}