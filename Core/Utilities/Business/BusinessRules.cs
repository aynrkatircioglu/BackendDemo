using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) //logic: kural
        {
            
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic; 
                    //parametre ile gönderilen iş kurallarından başarısız olanları businessa yolluyoruz
                    //bütün kuralları gez o kurala uymayan varsa geri döndür
                }
            }

            return null;
        }
    }
}
