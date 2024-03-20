using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSProject.Data
{
    public interface IDataHelper<Table>
    {
        List<Table> GetAllData();
        List<Table> GetDataByUser(int User_Id); 
        List<Table> Search(string SearchItem); 
        Table Find(int User_Id);

        void Add(Table table);
        void Delete(int User_Id);
        void Edit(int User_Id, Table table);
    }
}
