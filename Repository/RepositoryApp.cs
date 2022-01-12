using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository
{
    public class RepositoryApp : IRepositoryApp
    {
        IDataRepo _repo;

        public RepositoryApp(IDataRepo repo)
        {
            _repo = repo;
        }

        public void Run()
        {
            var data = _repo.GetAllData();
            var customer = _repo.GetCustomerByName();
            var animal = _repo.GetAnimalByName();

            _repo.SaveData(customer);
            _repo.SaveData(data);
            _repo.SaveData(animal);
        }
    }
}
