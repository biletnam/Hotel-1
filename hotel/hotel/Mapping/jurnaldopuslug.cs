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
    public class jurnaldopuslug
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int id;
        [Column]
        public int iddopuslug;
        [Column]
        public int idclienta;
        [Column]
        public int idjurnalanomera;
    }
    public class DBjurnaldopuslug : DataContext
    {
        public DBjurnaldopuslug(string cs) : base(cs) { }
        public System.Data.Linq.Table<jurnaldopuslug> jurnaldopuslug
        {
            get { return this.GetTable<jurnaldopuslug>(); }
        }
    }
    public class Metjurnaldopuslug
    {
        DBjurnaldopuslug dbjurnaldopuslug = new DBjurnaldopuslug(Program.Pole.pole);
        public void ADD(int iddopuslug,int idclienta,int idjurnalanomera)
        {
            jurnaldopuslug pac = new jurnaldopuslug();
            pac.idclienta = idclienta;
            pac.iddopuslug = iddopuslug;
            pac.idjurnalanomera = idjurnalanomera;
            dbjurnaldopuslug.jurnaldopuslug.InsertOnSubmit(pac);
            dbjurnaldopuslug.SubmitChanges();
        }
        public void Edit(int id, int iddopuslug, int idclienta, int idjurnalanomera)
        {
            jurnaldopuslug pac = dbjurnaldopuslug.jurnaldopuslug.Where(c => c.id == id).FirstOrDefault();
            pac.idclienta = idclienta;
            pac.iddopuslug = iddopuslug;
            pac.idjurnalanomera = idjurnalanomera;
            dbjurnaldopuslug.SubmitChanges();
        }
        public void Delete(int id)
        {
            jurnaldopuslug pac = dbjurnaldopuslug.jurnaldopuslug.Where(c => c.id == id).FirstOrDefault();
            dbjurnaldopuslug.jurnaldopuslug.DeleteOnSubmit(pac);
            dbjurnaldopuslug.SubmitChanges();
        }
    }
}
