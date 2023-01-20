using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDay.Domain;

namespace WorkDay.Validations
{
    public class DomainValidation
    {


        public static bool Validate(Building building)
        { 
            var assingmentValitador = new AssingmentValidator();
            var isValid = true;

            foreach(var assignment in building.Assignments)
            {
                var result = assingmentValitador.Validate(assignment);

                if(!result.IsValid) 
                {
                    result.Errors.ForEach(x => Console.WriteLine(string.Format("ERROR: Assingment id: {0} - {1}", assignment.Id, x.ErrorMessage.ToString())));
                    isValid = false;
                }
            }
            return isValid;
        }


    }
}
