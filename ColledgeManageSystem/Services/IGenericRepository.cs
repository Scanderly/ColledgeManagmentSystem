using ColledgeManageSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColledgeManageSystem.Services
{
    public interface IGenericRepository<T> where T : Entity
    {
        IReadOnlyList<T> GetAllEntities();
        T GetItemById(int? id);
        void CreateItem(T obj);
        void SaveItem();
        void Update(T obj);
        void Delete(int? id);
    }
}
