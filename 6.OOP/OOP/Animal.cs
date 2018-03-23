using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
   public class Animal:IAnimal
    {

        public int Age { get; set; }


        public virtual void Move()  {  }
    }
}
