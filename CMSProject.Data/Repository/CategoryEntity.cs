using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMSProject.Core;
using CMSProject.Data.Context;

namespace CMSProject.Data.Repository
{
    public class CategoryEntity : IDataHelper<Category>
    {

        private readonly MyDBContext _database;

        public CategoryEntity(MyDBContext database)
        {
            _database = database;
        }

        List<Category> IDataHelper<Category>.GetAllData()
        {
            return _database.Categories.ToList();
        }

        List<Category> IDataHelper<Category>.GetDataByUser(int User_Id)
        {
            throw new NotImplementedException();
        }

        List<Category> IDataHelper<Category>.Search(string SearchItem)
        {
            return _database.Categories.Where(x => x.Name.Contains(SearchItem) || x.Id.ToString() == SearchItem).ToList();
        }
        void IDataHelper<Category>.Add(Category table)
        {
            _database.Categories.Add(table);
            _database.SaveChanges();
        }

        void IDataHelper<Category>.Delete(int User_Id)
        {
            var targetUser = (from x in _database.Categories where x.Id == User_Id select x).FirstOrDefault();
            _database.Categories.Remove(targetUser);
            _database.SaveChanges();
        }

        void IDataHelper<Category>.Edit(int User_Id, Category table)
        {
            var targetUser = _database.Categories.Find(User_Id);
            targetUser.Name = table.Name;
            _database.SaveChanges();
        }

        Category IDataHelper<Category>.Find(int User_Id)
        {
            return (from x in _database.Categories where x.Id == User_Id select x).FirstOrDefault();
        }

    }

}
