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
    * L 海关入库回执
    * E 海关退单/不受理回执
    * G 海关接单交单回执
    * F 海关放行回执
    * W 海关无纸验放通知（审结）
    * I 海关无纸放行通知（放行）
    * C 海关无纸验放查验通知书（放行）
    * B 海关担保验放
    * P 海关已放行
    * R 海关已结关回执
    * H 海关挂起，需手工申报
    * M 海关重新审批通过
    * A 海关放行前删除或异常处理（手工申报通知）
    * D 海关放行后删除
    * X 海关准予进港回执（保税港区专用）
    * V 报关单转现场验估岗
    * Q 现场验估岗处理反馈
    * O 准予进卡
    * N
    * K 通关无纸化担保放行
    * J 审单中心确定办理税费及证件手续
    * 3 上载成功
    * 4 上载失败
    * 7 申报成功
    * 8 申报失败，上载成功，但是没有申报权限，请办理现场授权
    * 9 直接申报时处理失败，状态不对/请联系数据中心进行处理
    * Y 没有申报权限，请办理现场授权/状态不对/请联系数据中心进行处理
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
