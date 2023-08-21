using cSharpConcepts.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpConcepts.Generics
{
    internal interface ICovariant<out T> { }
    internal interface IContravariant<in T> { }
    internal class Covariant<T> : ICovariant<T> { }
    internal class Contravariant<T> : IContravariant<T> { }

    internal class Test 
    { 
        public void Covariant(ICovariant<Employee> employeeCov) { }
        public void Contravariant(IContravariant<Manager> managerCov) { }
        
        public void Covariance() 
        {
            ICovariant<Employee> empCov = new Covariant<Employee>();
            ICovariant<Manager> manCov = new Covariant<Manager>();

            Covariant(empCov);
            Covariant(manCov); //Manager is casted to employee, Without the out, this don't work.
        }

        public void Contravariace() 
        { 
            IContravariant<Employee> empCont = new Contravariant<Employee>();
            IContravariant<Manager> manCont = new Contravariant<Manager>();
            Contravariant(empCont); //Emcontr is downcasted to emplyee, without the in, it doesn't work.
            Contravariant(manCont);
        }
    }
}