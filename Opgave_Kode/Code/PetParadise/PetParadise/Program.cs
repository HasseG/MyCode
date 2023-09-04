using System;

namespace PetParadise
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.GetAllPets();

            foreach (Pet pet in controller.GetAllPets())
            {
                Console.WriteLine(pet.ToString());

            }
            Console.ReadKey();

            //OwnerRepo repo = new OwnerRepo();
            //foreach(Owner owner in repo.owners)
            //{
            //    Console.WriteLine(owner.ToString());

            //}
            //Console.ReadKey();
        }
    }
}
