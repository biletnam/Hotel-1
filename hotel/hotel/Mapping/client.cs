using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Configuration;


namespace hotel.Mapping
{
    [Table]
    public class client
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int id;
        [Column]
        public string fio;
        [Column]
        public string email;
    }
    public class DBclient : DataContext
    {
        public DBclient(string cs) : base(cs) { }
        public System.Data.Linq.Table<client> client
        {
            get { return this.GetTable<client>(); }
        }
    }
    public class Metclient
    {
        DBclient dbclient = new DBclient(Program.Pole.pole);
        public void ADD(string fio, string email)
        {
            client pac = new client();
            pac.fio = fio;
            pac.email = email;
            dbclient.client.InsertOnSubmit(pac);
            dbclient.SubmitChanges();
        }
        public void Edit(int id, string fio, string email)
        {
            client pac = dbclient.client.Where(c => c.id == id).FirstOrDefault();
            pac.fio = fio;
            pac.email = email;
            dbclient.SubmitChanges();
        }
        public void Delete(int id)
        {
            client pac = dbclient.client.Where(c => c.id == id).FirstOrDefault();
            dbclient.client.DeleteOnSubmit(pac);
            dbclient.SubmitChanges();
        }
    }
}
