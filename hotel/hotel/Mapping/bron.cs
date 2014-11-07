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
    public class bron
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int id;
        [Column]
        public int idclienta;
        [Column]
        public int idnomera;
        [Column]
        public DateTime databroni;
        [Column]
        public DateTime datazaezda;
        [Column]
        public DateTime dataviezda;
    }
    public class DBbron : DataContext
    {
        public DBbron(string cs) : base(cs) { }
        public System.Data.Linq.Table<bron> bron
        {
            get { return this.GetTable<bron>(); }
        }
    }
    public class Metbron
    {
        DBbron dbbron = new DBbron(Program.Pole.pole);
        public void ADD(int idclienta, int idnomera, DateTime databroni, DateTime datazaezda, DateTime dataviezda)
        {
            bron pac = new bron();
            pac.idclienta = idclienta;
            pac.idnomera = idnomera;
            pac.databroni = databroni;
            pac.datazaezda = datazaezda;
            pac.dataviezda = dataviezda;
            dbbron.bron.InsertOnSubmit(pac);
            dbbron.SubmitChanges();
        }
        public void Edit(int id, int idclienta, int idnomera, DateTime databroni, DateTime datazaezda, DateTime dataviezda)
        {
            bron pac = dbbron.bron.Where(c => c.id == id).FirstOrDefault();
            pac.idclienta = idclienta;
            pac.idnomera = idnomera;
            pac.databroni = databroni;
            pac.datazaezda = datazaezda;
            pac.dataviezda = dataviezda;
            dbbron.SubmitChanges();
        }
        public void Delete(int id)
        {
            bron pac = dbbron.bron.Where(c => c.id == id).FirstOrDefault();
            dbbron.bron.DeleteOnSubmit(pac);
            dbbron.SubmitChanges();
        }
    }
}
