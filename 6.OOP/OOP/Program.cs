using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal iAnimalobj = new Animal();
            IAnimal iMammalobj= new Mammal();
            IAnimal iPetobj = new Pet();
            IAnimal iHumanobj = new Human();
            IAnimal iCatobj = new Cat();
            IAnimal iDogobj = new Dog();
            IAnimal iBirdobj = new Birds();
            IAnimal iEagleobj = new Eagle();

            Mammal mHumanobj = new Human();
            Mammal mPetobj = new Pet();
            Mammal hCatobj = new Cat();
            Mammal hDogobj = new Dog();

            Human humanobj = new Human();

        }
    }
}
