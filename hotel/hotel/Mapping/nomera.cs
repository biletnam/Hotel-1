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
    public class nomera
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int id;
        [Column]
        public string nomer;
        [Column]
        public int cena;
        [Column]
        public string stavka;
        [Column]
        public string tip;
        [Column]
        public string mesta;
        [Column]
        public string zanitost;
    }
    public class DBnomera : DataContext
    {
        public DBnomera(string cs) : base(cs) { }
        public System.Data.Linq.Table<nomera> nomera
        {
            get { return this.GetTable<nomera>(); }
        }
    }
    public class Metnomera
    {
        DBnomera dbnomera = new DBnomera(Program.Pole.pole);
        DBveshinomera dbvn = new DBveshinomera(Program.Pole.pole);
        public void ADD(string nomer, int cena, string stavka, string tip, string zanitost, string mesta)
        {
            nomera pac = new nomera();
            pac.nomer = nomer;
            pac.cena = cena;
            pac.tip = tip;
            pac.stavka = stavka;
            pac.zanitost = zanitost;
            pac.mesta =  mesta;
            dbnomera.nomera.InsertOnSubmit(pac);
            dbnomera.SubmitChanges();
        }
        public void Edit(int id, string nomer, int cena, string stavka, string tip, string zanitost, string mesta)
        {
            nomera pac = dbnomera.nomera.Where(c => c.id == id).FirstOrDefault();
            pac.id = id;
            pac.nomer = nomer;
            pac.cena = cena;
            pac.tip = tip;
            pac.stavka = stavka;
            pac.zanitost = zanitost;
            pac.mesta =  mesta;
            dbnomera.SubmitChanges();
        }
        public void Zan(int id,string zanitost)
        {
            nomera pac = dbnomera.nomera.Where(c => c.id == id).FirstOrDefault();
            pac.id = id;
            pac.zanitost = zanitost;
            dbnomera.SubmitChanges();
        }
        public void Delete(int id)
        {
            nomera pac = dbnomera.nomera.Where(c => c.id == id).FirstOrDefault();
            dbnomera.nomera.DeleteOnSubmit(pac);
            dbnomera.SubmitChanges();
            var pac2 = dbvn.veshinomera.Where(c => c.idnomera== id);
            foreach (var i in pac2)
            {
                dbvn.veshinomera.DeleteOnSubmit(i);
                dbvn.SubmitChanges();
            }
        }
    }
        
}
