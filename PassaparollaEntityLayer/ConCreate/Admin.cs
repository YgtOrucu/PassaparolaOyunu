using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassaparollaEntityLayer.ConCreate
{
    public class Admin
    {
        public int ID { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public string KullanıcıAdı { get; set; }
        public string Sıfre { get; set; }

        public int RoleID { get; set; }
        public virtual Role Role { get; set; }

    }
}
