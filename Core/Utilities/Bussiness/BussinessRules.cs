using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Bussiness
{
    public class BussinessRules
    {
        public static IResult Run(params IResult[] logics)//params verince metod içerisine istediğimiz kadar parametre gönderebiliyoruz
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }

            return null;
        }
    }
}
