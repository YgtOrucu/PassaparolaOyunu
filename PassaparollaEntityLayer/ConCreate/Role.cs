using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassaparollaEntityLayer.ConCreate
{
    public class Role
    {
        public int ID { get; set; }
        public string RoleType { get; set; }

        public ICollection<Admin> Admins { get; set; }
    }
}
