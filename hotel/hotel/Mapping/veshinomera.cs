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
    public  class veshinomera
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int id;
        [Column]
        public int idveshi;
        [Column]
        public int idnomera;
        [Column]
        public int kolichestvo;
    }
    public class DBveshinomera : DataContext
    {
        public DBveshinomera(string cs) : base(cs) { }
        public System.Data.Linq.Table<veshinomera> veshinomera
        {
            get { return this.GetTable<veshinomera>(); }
        }
    }
    public class Metveshinomera
    {
        DBveshinomera dbveshinomera = new DBveshinomera(Program.Pole.pole);
        public void ADD(int idveshi, int idnomera, int kolichestvo)
        {
            veshinomera pac = new veshinomera();
            pac.idveshi = idveshi;
            pac.idnomera = idnomera;
            pac.kolichestvo = kolichestvo;
            dbveshinomera.veshinomera.InsertOnSubmit(pac);
            dbveshinomera.SubmitChanges();
        }
        public void Edit(int id, int idveshi, int idnomera, int kolichestvo)
        {
            veshinomera pac = dbveshinomera.veshinomera.Where(c => c.id == id).FirstOrDefault();
            pac.id = id;
            pac.idveshi = idveshi;
            pac.idnomera = idnomera;
            pac.kolichestvo = kolichestvo;
            dbveshinomera.SubmitChanges();
        }
        public void Delete(int id)
        {
            veshinomera pac = dbveshinomera.veshinomera.Where(c => c.id == id).FirstOrDefault();
            dbveshinomera.veshinomera.DeleteOnSubmit(pac);
            dbveshinomera.SubmitChanges();
        }
    }
            
}
