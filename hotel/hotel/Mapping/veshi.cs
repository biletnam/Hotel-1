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
    public class veshi
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int id;
        [Column]
        public string nazvanie;
    }
    public class DBveshi : DataContext
    {
        public DBveshi(string cs) : base(cs) { }
        public System.Data.Linq.Table<veshi> veshi
        {
            get { return this.GetTable<veshi>(); }
        }
    }
    public class Metveshi
    {
        DBveshi dbveshi = new DBveshi(Program.Pole.pole);
        DBrezerv dbrezerv = new DBrezerv(Program.Pole.pole);
        DBveshinomera dbvn = new DBveshinomera(Program.Pole.pole);
        public void ADD(string nazvanie)
        {
            veshi pac = new veshi();
            pac.nazvanie = nazvanie;
            dbveshi.veshi.InsertOnSubmit(pac);
            dbveshi.SubmitChanges();
        }
        public void Edit(int id, string nazvanie)
        {
            veshi pac = dbveshi.veshi.Where(c => c.id == id).FirstOrDefault();
            pac.id = id;
            pac.nazvanie = nazvanie;
            dbveshi.SubmitChanges();
        }
        public void Delete(int id)
        {
            veshi pac = dbveshi.veshi.Where(c => c.id == id).FirstOrDefault();
            dbveshi.veshi.DeleteOnSubmit(pac);
            dbveshi.SubmitChanges();
            var pac2 = dbrezerv.rezerv.Where(c => c.idveshi == id);
                foreach(var i in pac2){
            dbrezerv.rezerv.DeleteOnSubmit(i);
            dbrezerv.SubmitChanges();
                }
            var pac3 = dbvn.veshinomera.Where(c => c.idveshi == id);
                foreach(var i in pac3){
            dbvn.veshinomera.DeleteOnSubmit(i);
            dbrezerv.SubmitChanges();
                }
        }
    }
}
