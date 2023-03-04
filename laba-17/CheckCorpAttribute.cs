using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace laba_17
{
    public class CheckCorpAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is decimal val)
            {
                if (val > 0 && val < 4)
                {
                    return true;
                }
            }
            ErrorMessage = "Некорректный корпус";
            return false;

        }
    }
}
