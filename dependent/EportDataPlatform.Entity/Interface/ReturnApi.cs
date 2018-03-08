using System;
using System.Collections.Generic;
using System.Text;

namespace EportDataPlatform.Entity.Interface.ReturnApi
{
    public class GetStatus_Response
    {
        public bool success { get; set; }
        public List<Error> errors { get; set; }
        public List<DataBase.ENTRY_RETURN> data { get; set; }
        public GetStatusParam param { get; set; }
        public GetStatus_Response()
        {
            errors = new List<Error>();
            data = new List<DataBase.ENTRY_RETURN>();
            param = new GetStatusParam();
        }
    }

    public class Error
    {
        public ErrorCode errorcode { get; set; }
        public string message { get; set; }
        public string detalmessage { get; set; }
        public Error(ErrorCode errorcode, string message, string detalmessage)
        {
            this.errorcode = errorcode;
            this.message = message;
            this.detalmessage = detalmessage;
        }
    }

    public class GetStatusParam
    {
        public string Save_Ref_ID { get; set; }
        public string Pre_Entry_ID { get; set; }
        public string Entry_ID { get; set; }
    }

    public enum ErrorCode
    {
        未知错误 = 5001,
        参数错误 = 5002,
        非致命错误 = 5003,
    }
}
