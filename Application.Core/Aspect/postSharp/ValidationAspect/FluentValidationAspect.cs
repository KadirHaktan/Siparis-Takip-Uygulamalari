using Application.Core.ValidationTools;
using FluentValidation;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Aspect.postSharp.ValidationAspect
{
    [Serializable]
    public class FluentValidationAspect : OnMethodBoundaryAspect
    {
        private Type _validationType { get; set; }

        public FluentValidationAspect(Type type)
        {
            this._validationType = type;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            var validatitor = (IValidator)Activator.CreateInstance(_validationType);
            var entity_type = _validationType.BaseType.GetGenericArguments()[0];
            var entities = args.Arguments.Where(t => t.GetType() == entity_type);


            foreach (var entity in entities)
            {
                FluentValidationTool.Validate(validatitor, entity);
            }
        }
    }
}


