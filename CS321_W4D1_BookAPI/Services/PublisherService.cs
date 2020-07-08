using CS321_W4D1_BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS321_W4D1_BookAPI.Services
{
    public class PublisherService
    {
        private readonly BookContext _bookContext;

        public AuthorService(BookContext bookContext)
        {
            // TODO: keep a reference to the AuthorContext in _AuthorContext
            _bookContext = bookContext;
        }

        public Author Add(Author Author)
        {
            // TODO: implement add
            _bookContext.Authors.Add(Author);
            _bookContext.SaveChanges();
            return Author;
        }

        public Author Get(int id)
        {
            // TODO: return the specified Author using Find()
            return _bookContext.Authors.Find(id);
        }

        public IEnumerable<Author> GetAll()
        {
            // TODO: return all Authors using ToList()
            return _bookContext.Authors.ToList();
        }

        public Author Update(Author updatedAuthor)
        {
            // get the ToDo object in the current list with this id 
            var currentAuthor = _bookContext.Authors.Find(updatedAuthor.Id);

            // return null if todo to update isn't found
            if (currentAuthor == null) return null;

            _bookContext.Entry(currentAuthor)
                .CurrentValues
                .SetValues(updatedAuthor);

            // update the todo and save
            _bookContext.Publisher.Update(currentPublisher);
            _bookContext.SaveChanges();
            return currentAuthor;
        }

        public void Remove(Publisher Publisher)
        {
            _bookContext.Publisher.Remove(Publisher);
            _bookContext.SaveChanges();
        }
    }
}
