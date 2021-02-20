using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace libraryservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        string AddRecord(Book bk);

        [OperationContract]
        DataSet GetRecords();

        [OperationContract]
        string DeleteRecords(Book bk);

        [OperationContract]
        DataSet SearchRecord(Book bk);

        [OperationContract]
        string Updateinfo(Book bk);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Book
    {
        string _Id = "";
        string _student_name = "";
        string _student_id = "";
        string _book_name = "";
        string _author_name = "";
        string _price = "";

        [DataMember]
        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        [DataMember]
        public string student_name
        {
            get { return _student_name; }
            set { _student_name = value; }
        }

        [DataMember]
        public string student_id
        {
            get { return _student_id; }
            set { _student_id = value; }
        }

        [DataMember]
        public string book_name
        {
            get { return _book_name; }
            set { _book_name = value; }
        }

        [DataMember]
        public string author_name
        {
            get { return _author_name; }
            set { _author_name = value; }
        }
        [DataMember]
        public string price
        {
            get { return _price; }
            set { _price = value; }
        }

    }
}
