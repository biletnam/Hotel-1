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
    public class Jurnal
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int id;        
        [Column]
        public DateTime data;
        [Column]
        public int summa;
        [Column]
        public int znak;
    }
    public class DBjurnal : DataContext
    {
        public DBjurnal(string cs) : base(cs) { }
        public System.Data.Linq.Table<Jurnal> Jurnal
        {
            get { return this.GetTable<Jurnal>(); }
        }
    }
    public class Metjurnal
    {
        DBjurnal dbbron = new DBjurnal(Program.Pole.pole);
        public void ADD(DateTime data,int summa,int znak)
        {
            Jurnal pac = new Jurnal();
            pac.data = data;
            pac.summa = summa;
            pac.znak = znak;
            dbbron.Jurnal.InsertOnSubmit(pac);
            dbbron.SubmitChanges();
        }
        public void ADD2(DateTime data, int summa)
        {
            Jurnal pac = new Jurnal();
            pac.data = data;
            pac.summa = summa;
            dbbron.Jurnal.InsertOnSubmit(pac);
            dbbron.SubmitChanges();
        }
    }
    }
