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
    public class dopuslugi
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int id;
        [Column]
        public string nazvanie;
        [Column]
        public int cena;
        [Column]
        public string stavka;

    }
    public class DBdopuslugi : DataContext
    {
        public DBdopuslugi(string cs) : base(cs) { }
        public System.Data.Linq.Table<dopuslugi> dopuslugi
        {
            get { return this.GetTable<dopuslugi>(); }
        }
    }
    public class Metdopuslugi
    {
        DBdopuslugi dbdopuslugi = new DBdopuslugi(Program.Pole.pole);
        public void ADD(string nazvanie, int cena, string stavka)
        {
            dopuslugi pac = new dopuslugi();
            pac.nazvanie = nazvanie;
            pac.cena = cena;
            pac.stavka = stavka;
            dbdopuslugi.dopuslugi.InsertOnSubmit(pac);
            dbdopuslugi.SubmitChanges();
        }
        public void Edit(int id, string nazvanie, int cena, string stavka)
        {
            dopuslugi pac = dbdopuslugi.dopuslugi.Where(c => c.id == id).FirstOrDefault();
            pac.nazvanie = nazvanie;
            pac.cena = cena;
            pac.stavka = stavka;
            dbdopuslugi.SubmitChanges();
        }
        public void Delete(int id)
        {
            dopuslugi pac = dbdopuslugi.dopuslugi.Where(c => c.id == id).FirstOrDefault();
            dbdopuslugi.dopuslugi.DeleteOnSubmit(pac);
            dbdopuslugi.SubmitChanges();
        }
    }
}
