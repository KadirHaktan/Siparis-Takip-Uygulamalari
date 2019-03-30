using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.ValidationTools
{
   public class FluentValidationTool
    {
        public static void Validate(IValidator validate,object entity)
        {
            var result = validate.Validate(entity);

            if (result.Errors.Count > 0)
            {
                throw new Exception(result.Errors.ToString());
            }
        }
    }
}
