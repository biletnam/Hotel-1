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
    public class jurnalnomera
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int id;
        [Column]
        public string nalichbroni;
        [Column]
        public int idbroni;
        [Column]
        public int idnomera;
        [Column]
        public int idclienta;
        [Column]
        public DateTime datazaezda;
        [Column]
        public DateTime dataviezda;
    }
    public class DBjurnalnomera:DataContext
    {
        public DBjurnalnomera(string cs):base(cs){}
            public System.Data.Linq.Table<jurnalnomera> jurnalnomera
            {
                get{return this.GetTable<jurnalnomera>();}
            }
    }
    public class Metjurnalnomera
    {
        DBjurnalnomera dbjurnalnomera = new DBjurnalnomera(Program.Pole.pole);
        public void ADD(string nalichbroni, int idbroni, int idnomera, int idclienta, DateTime datazaezda, DateTime dataviezda)
        {
            if ("Да" == nalichbroni)
            {
                jurnalnomera pac = new jurnalnomera();
                pac.nalichbroni = nalichbroni;
                pac.idbroni = idbroni;
                pac.idnomera = idnomera;
                pac.idclienta = idclienta;
                pac.datazaezda = datazaezda;
                pac.dataviezda = dataviezda;
                dbjurnalnomera.jurnalnomera.InsertOnSubmit(pac);
                dbjurnalnomera.SubmitChanges();
            }
            else 
            {
                jurnalnomera pac = new jurnalnomera();
                pac.nalichbroni = nalichbroni;
                pac.idnomera = idnomera;
                pac.idclienta = idclienta;
                pac.datazaezda = datazaezda;
                pac.dataviezda = dataviezda;
                dbjurnalnomera.jurnalnomera.InsertOnSubmit(pac);
                dbjurnalnomera.SubmitChanges();
            }
        }
        public void Edit(int id, string nalichbroni, int idbroni, int idnomera, int idclienta, DateTime datazaezda, DateTime dataviezda)
        {
            jurnalnomera pac = dbjurnalnomera.jurnalnomera.Where(c => c.id == id).FirstOrDefault();
            pac.id = id;
            pac.nalichbroni = nalichbroni;
            pac.idbroni = idbroni;
            pac.idnomera = idnomera;
            pac.idclienta = idclienta;
            pac.datazaezda = datazaezda;
            pac.dataviezda = dataviezda;
            dbjurnalnomera.SubmitChanges();
        }
        public void Delete(int id)
        {
            jurnalnomera pac = dbjurnalnomera.jurnalnomera.Where(c => c.id == id).FirstOrDefault();
            dbjurnalnomera.jurnalnomera.DeleteOnSubmit(pac);
            dbjurnalnomera.SubmitChanges();
        }
    }

}
