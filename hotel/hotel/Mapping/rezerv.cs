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
    public class rezerv
    {
        [Column(IsDbGenerated=true,IsPrimaryKey=true)]
        public int id;
        [Column]
        public int idveshi;
        [Column]
        public int kolichestvo;
    }
    public class DBrezerv:DataContext
    {
        public DBrezerv(string cs):base(cs){}
        public System.Data.Linq.Table<rezerv> rezerv
            {
                get{return this.GetTable<rezerv>();}
            }
    }
    public class Metrezerv
    {
        DBrezerv dbrezerv = new DBrezerv(Program.Pole.pole);
        public void ADD(int idveshi,int kolichestv)
        {
            rezerv pac = new rezerv();
            pac.idveshi = idveshi;
            pac.kolichestvo = kolichestv;
            dbrezerv.rezerv.InsertOnSubmit(pac);
            dbrezerv.SubmitChanges();
        }
        public void Edit(int id, int idveshi,int kolichestv)
        {
            rezerv pac = dbrezerv.rezerv.Where(c => c.id == id).FirstOrDefault();
            pac.id = id;
            pac.idveshi = idveshi;
            pac.kolichestvo = kolichestv;
            dbrezerv.SubmitChanges();
        }
        public void Delete(int id)
        {
            rezerv pac = dbrezerv.rezerv.Where(c => c.id == id).FirstOrDefault();
            dbrezerv.rezerv.DeleteOnSubmit(pac);
            dbrezerv.SubmitChanges();
        }
    }
}
