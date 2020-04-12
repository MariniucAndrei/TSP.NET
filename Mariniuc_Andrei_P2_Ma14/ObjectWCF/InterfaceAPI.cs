using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPhotos;
using System.ServiceModel;

namespace MyPhotoWCF
{
    [ServiceContract]
    interface InterfaceAPI
    {
        [OperationContract]
         void Create(string table, string name, string date, string path, string isDeleted, int idZone, int idGroup, int idEvent);

        [OperationContract]
        void CreateNew(string table, string name, string id);

        [OperationContract]
        string Read(string table);

        [OperationContract]
        void Update(string name, string NewName);

        [OperationContract]
        void Delete(string table, string name);

        [OperationContract]
        string Search(string table, string name);

        [OperationContract]
        string Filter(string name, string date, string path, string isDeleted, int idZone, int idGroup, int idEvent);

        [OperationContract]
        void Save();

    }

    [ServiceContract]
    interface IAPI : InterfaceAPI
    {

    }
}
