using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository
{
    public class DataRepo : IDataRepo
    {
        SimulatedDatabase _database = new SimulatedDatabase();
        public string GetAllData()
        {
            string data = _database.Load("Dataset A");
            return data;
        }

        public string GetAnimalByName()
        {
            var animal = _database.Load("From Table Animal Where Owner==Steve");
            return animal;
        }

        public string GetCustomerByName()
        {
            var customer = _database.Load("From Table Customer Where Name==Steve");
            return customer;
        }

        

        public void SaveData(string data)
        {
            _database.Save(data);
            
        }
    }
}
