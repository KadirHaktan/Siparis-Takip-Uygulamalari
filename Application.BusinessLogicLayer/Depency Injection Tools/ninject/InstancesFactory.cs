using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Application.BusinessLogicLayer.Depency_Injection_Tools.ninject
{
   public class InstancesFactory
    {
        public static T CreateInstance<T>()
        {
            var kernel = new StandardKernel(new BusinessModules());

            return kernel.Get<T>();

        }
    }
}
