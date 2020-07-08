using CS321_W4D1_BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS321_W4D1_BookAPI.Services
{
    interface IPublisherService
    {
        Publisher Add(Publisher todo);
        // read
        Publisher Get(int id);
        // update
        Publisher Update(Publisher todo);
        // delete
        void Remove(Publisher todo);
        // list
        IEnumerable<Publisher> GetAll();
    }
}
