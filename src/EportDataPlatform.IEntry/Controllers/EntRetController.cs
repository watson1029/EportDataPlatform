using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EportDataPlatform.IEntry.Controllers
{
    [Produces("application/json")]
    [Route("api/EntRet")]
    public class EntRetController : Controller
    {
        //private DataAccess.Context.EntRetDbContext _context;
        //public EntRetController(DataAccess.Context.EntRetDbContext context)
        //{
        //    _context = context;
        //}
        [Route("GetStatus/{param}")]
        [HttpGet]
        public Entity.DataBase.ENTRY_RETURN GetStatus(string param)
        {
            DataAccess.DataBase.ENTRY_RETURN ent = new DataAccess.DataBase.ENTRY_RETURN();
            return ent.GetAll()[0];            
        }
    }
}
