EportDataPlatform.IEntry接口定义
=====
### GetStatus（获取报关单状态信息）
## 接口地址
http://172.29.1.170:5180/api/EntRet/GetStatus/{param}
## 请求方式
HttpGet
## 参数信息param
* 自动识别
  * Z开头18位暂存编号
  * 0开头18位预录入编号
  * 5开头18位报关单编号
## 返回类型jsonData
* success:
  * true
  * false
* errors:
  * errorcode:
    * 5001 未知错误
    * 5002 参数错误
    * 5003 非致命错误
  * message:
  * detalmessage:
* param:
  * Save_Ref_ID:
  * Pre_Entry_ID:
  * Entry_ID:
* data[]:
  * F_NAME:
  * PRE_ENTRY_ID:
  * ENTRY_ID:
  * NOTICE_DATE:
  * CHANNEL:
    * 待补充
  * NOTE:
  * DECL_PORT:
  * AGENT_NAME:
  * DECLARE_NO:
  * TRADE_CO:
  * CUSTOMS_FIELD:
  * BONDED_NO:
  * I_E_DATE:
  * PACK_NO:
  * BILL_NO:
  * TRAF_MODE:
  * VOYAGE_NO:
  * NET_WT:
  * GROSS_WT:
  * D_DATE:
  * I_E_FLAG:
