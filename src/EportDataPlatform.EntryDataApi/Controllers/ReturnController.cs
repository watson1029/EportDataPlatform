using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EportDataPlatform.Entity.Interface.ReturnApi;

namespace EportDataPlatform.EntryDataApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Return")]
    public class ReturnController : Controller
    {
        [Route("GetStatus/{param}")]
        [HttpGet]
        public GetStatus_Response GetStatus(string param)
        {
            GetStatus_Response obj = new GetStatus_Response();
            try
            {
                DataAccess.DataBase.ENTRY_RETURN da = new DataAccess.DataBase.ENTRY_RETURN();
                obj.success = true;
                switch (param[0])
                {
                    case 'Z':
                        obj.data = da.GetBySaveRefID(param);
                        obj.param.Save_Ref_ID = param;
                        obj.param.Pre_Entry_ID = obj.data[obj.data.Count - 1].PRE_ENTRY_ID;
                        obj.param.Entry_ID = obj.data[obj.data.Count - 1].ENTRY_ID;
                        break;
                    case '0':
                        obj.data = da.GetByPreEntryID(param);
                        obj.param.Save_Ref_ID = da.GetSaveByPre(param);
                        obj.param.Pre_Entry_ID = param;
                        obj.param.Entry_ID = obj.data[obj.data.Count - 1].ENTRY_ID;
                        break;
                    case '5':
                        obj.data = da.GetByEntryID(param);
                        obj.param.Save_Ref_ID = da.GetSaveByEntry(param);
                        obj.param.Pre_Entry_ID = obj.data[obj.data.Count - 1].PRE_ENTRY_ID;
                        obj.param.Entry_ID = param;
                        break;
                    default:
                        obj.success = false;
                        obj.errors.Add(new Error(ErrorCode.参数错误, $"{ErrorCode.参数错误.ToString()}:param={param}", $"请输入正确的暂存编号(Z开头)/预录入编号（0开头）/报关单号（5开头）."));
                        break;
                }
            }
            catch (Exception ex)
            {
                obj.success = false;
                obj.errors.Add(new Error(ErrorCode.未知错误, $"{ErrorCode.未知错误.ToString()}:param={param},{ex.Message}", $"{ex.ToString()}"));
            }
            return obj;
        }
    }
}