using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPhotos;

namespace MyPhotoWCF
{
    public class API : IAPI
    {
        DataBaseAPI myphoto = new DataBaseAPI();

        public void Create(string table, string name, string date, string path, string isDeleted, int idZone, int idGroup, int idEvent)
        {
            myphoto.Create(table, name, date, path, isDeleted, idZone, idGroup, idEvent);
        }
        public void CreateNew(string table, string name, string id)
        {
            myphoto.CreateNew(table, name, id);
        }
        public IList<string> Read(string table)
        {
            return myphoto.Read(table);
        }
        public void Update(string name, string NewName)
        {
            myphoto.Update(name, NewName);
        }
        public void Delete(string table, string name)
        {
            myphoto.Delete(table, name);
        }
        public string Search(string table, string name)
        {
            return myphoto.Search(table, name);
        }
        public string Filter(string name, string date, string path, string isDeleted, int idZone, int idGroup, int idEvent)
        {
            return myphoto.Filter(name, date, path, isDeleted, idZone, idGroup, idEvent);
        }
        public void Save()
        {
            myphoto.Save();
        }
    }
}
