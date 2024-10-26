using System;

namespace API.Extensions;

public static class DateTimeExtensions
{
     public static int CalculateAge(this DateOnly dateofbirth){
        
        var today = DateOnly.FromDateTime(DateTime.Now);
        
        var age = today.Year - dateofbirth.Year;

        if(dateofbirth > today.AddYears(-age)) age--;

        return age;
     }

}
