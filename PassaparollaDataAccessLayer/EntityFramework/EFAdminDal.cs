using PassaparollaDataAccessLayer.Abstract;
using PassaparollaDataAccessLayer.Repository;
using PassaparollaEntityLayer.ConCreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassaparollaDataAccessLayer.EntityFramework
{
    public class EFAdminDal : AdminRepository, IAdminDal
    {
    }
}
