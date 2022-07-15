using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DatabaseRepository
{
   public  interface IRepository<T> where T:class
    {
        List<T> GetAll(IDomainObject obj);
        T login(T obj);
        int GetNewId(IDomainObject obj);
        List<IDomainObject> GetSpecific(IDomainObject obj);
        List<T> getAllJoin(IDomainObject obj);
        void Save(T obj);
        void Update(T obj);
        void Delete(T obj);
        List<T> Search(string kriterijum);
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
