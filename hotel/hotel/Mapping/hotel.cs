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
    public class hotel
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int id;
        [Column]
        public string nazvanie;
        [Column]
        public string fioglbuha;
        [Column]
        public string adres;
        [Column]
        public string email;
    }
    public class DBhotel : DataContext
    {
        public DBhotel(string cs) : base(cs) { }
        public System.Data.Linq.Table<hotel> hotel
        {
            get { return this.GetTable<hotel>(); }
        }

    }
    public class Methotel
    {
        DBhotel dbhotel = new DBhotel(Program.Pole.pole);
        public void ADD(string nazvanie,string fioglbuha,string adres,string email)
        {
            hotel pac = new hotel();
            pac.nazvanie = nazvanie;
            pac.fioglbuha = fioglbuha;
            pac.adres = adres;
            pac.email = email;
            dbhotel.hotel.InsertOnSubmit(pac);
            dbhotel.SubmitChanges();
        }
        public void Edit(int id, string nazvanie,  string fioglbuha, string adres, string email)
        {
            try
            {
                hotel pac = dbhotel.hotel.Where(c => c.id == id).FirstOrDefault();
                pac.nazvanie = nazvanie;
                pac.fioglbuha = fioglbuha;
                pac.adres = adres;
                pac.email = email;
                dbhotel.SubmitChanges();
            }
            catch (NullReferenceException)
            {
                ADD(nazvanie,fioglbuha,adres,email);
            }
        }
    }
}
