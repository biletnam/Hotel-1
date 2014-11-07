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
    public class Oplata
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int id;
        [Column]
        public DateTime Data;
        [Column]
        public int Summa;
        [Column]
        public int SchetKlienta;
        [Column]
        public int idJurnala;
    }
    public class DBOplata : DataContext
    {
        public DBOplata(string cs) : base(cs) { }
        public System.Data.Linq.Table<Oplata> Oplata
        {
            get { return this.GetTable<Oplata>(); }
        }
    }
    public class MetOplata
    {
        DBOplata dboplata = new DBOplata(Program.Pole.pole);
        public void ADD(DateTime Data,int Summa,int SchetKlienta,int idJurnala)
        {
            Oplata pac = new Oplata();
            pac.Data = Data ;
            pac.Summa =Summa ;
            pac.SchetKlienta =SchetKlienta ;
            pac.idJurnala =idJurnala ;
            dboplata.Oplata.InsertOnSubmit(pac);
            dboplata.SubmitChanges();
        }
        
    }
}
