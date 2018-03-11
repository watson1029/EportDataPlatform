/**  版本信息模板在安装目录下，可自行修改。
* ENTRY_HEAD.cs
*
* 功 能： N/A
* 类 名： ENTRY_HEAD
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/11/11 11:41:43   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.ComponentModel.DataAnnotations;

namespace EportDataPlatform.Entity.DataBase
{
	/// <summary>
	/// ENTRY_HEAD:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ENTRY_HEAD
	{
		public ENTRY_HEAD()
		{}
		#region Model
		private string _f_name;
		private string _pre_entry_id;
		private string _entry_type;
		private string _entry_id;
		private string _i_e_flag;
		private string _decl_port;
		private string _i_e_port;
		private string _i_e_date;
		private string _d_date;
		private string _destination_port;
		private string _traf_mode;
		private string _traf_name;
		private string _voyage_no;
		private string _bill_no;
		private string _trade_co;
		private string _trade_name;
		private string _co_owner;
		private string _owner_code;
		private string _owner_name;
		private string _district_code;
		private string _agent_code;
		private string _agent_name;
		private string _contr_no;
		private string _in_ratio;
		private string _trade_country;
		private string _trade_mode;
		private string _cut_mode;
		private string _trans_mode;
		private string _container_no;
		private string _pay_way;
		private string _fee_mark;
		private string _fee_curr;
		private string _fee_rate;
		private string _insur_mark;
		private string _insur_curr;
		private string _insur_rate;
		private string _other_mark;
		private string _other_curr;
		private string _other_rate;
		private string _pack_no;
		private string _gross_wt;
		private string _net_wt;
		private string _wrap_type;
		private string _license_no;
		private string _appr_no;
		private string _manual_no;
		private string _relative_id;
		private string _relative_manual_no;
		private string _bonded_no;
		private string _customs_field;
		private string _edi_id;
		private string _edi_remark;
		private string _partener_id;
		private string _p_date;
		private string _typist_no;
		private string _declare_no;
		private string _bp_no;
		private string _note_s;
		private string _hyexport_2016;
		/// <summary>
		/// 
		/// </summary>
        [Key]
		public string F_NAME
		{
			set{ _f_name=value;}
			get{return _f_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRE_ENTRY_ID
		{
			set{ _pre_entry_id=value;}
			get{return _pre_entry_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ENTRY_TYPE
		{
			set{ _entry_type=value;}
			get{return _entry_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ENTRY_ID
		{
			set{ _entry_id=value;}
			get{return _entry_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string I_E_FLAG
		{
			set{ _i_e_flag=value;}
			get{return _i_e_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DECL_PORT
		{
			set{ _decl_port=value;}
			get{return _decl_port;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string I_E_PORT
		{
			set{ _i_e_port=value;}
			get{return _i_e_port;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string I_E_DATE
		{
			set{ _i_e_date=value;}
			get{return _i_e_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string D_DATE
		{
			set{ _d_date=value;}
			get{return _d_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DESTINATION_PORT
		{
			set{ _destination_port=value;}
			get{return _destination_port;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TRAF_MODE
		{
			set{ _traf_mode=value;}
			get{return _traf_mode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TRAF_NAME
		{
			set{ _traf_name=value;}
			get{return _traf_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VOYAGE_NO
		{
			set{ _voyage_no=value;}
			get{return _voyage_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BILL_NO
		{
			set{ _bill_no=value;}
			get{return _bill_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TRADE_CO
		{
			set{ _trade_co=value;}
			get{return _trade_co;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TRADE_NAME
		{
			set{ _trade_name=value;}
			get{return _trade_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CO_OWNER
		{
			set{ _co_owner=value;}
			get{return _co_owner;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OWNER_CODE
		{
			set{ _owner_code=value;}
			get{return _owner_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OWNER_NAME
		{
			set{ _owner_name=value;}
			get{return _owner_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DISTRICT_CODE
		{
			set{ _district_code=value;}
			get{return _district_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AGENT_CODE
		{
			set{ _agent_code=value;}
			get{return _agent_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AGENT_NAME
		{
			set{ _agent_name=value;}
			get{return _agent_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CONTR_NO
		{
			set{ _contr_no=value;}
			get{return _contr_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IN_RATIO
		{
			set{ _in_ratio=value;}
			get{return _in_ratio;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TRADE_COUNTRY
		{
			set{ _trade_country=value;}
			get{return _trade_country;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TRADE_MODE
		{
			set{ _trade_mode=value;}
			get{return _trade_mode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CUT_MODE
		{
			set{ _cut_mode=value;}
			get{return _cut_mode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TRANS_MODE
		{
			set{ _trans_mode=value;}
			get{return _trans_mode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CONTAINER_NO
		{
			set{ _container_no=value;}
			get{return _container_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PAY_WAY
		{
			set{ _pay_way=value;}
			get{return _pay_way;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FEE_MARK
		{
			set{ _fee_mark=value;}
			get{return _fee_mark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FEE_CURR
		{
			set{ _fee_curr=value;}
			get{return _fee_curr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FEE_RATE
		{
			set{ _fee_rate=value;}
			get{return _fee_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INSUR_MARK
		{
			set{ _insur_mark=value;}
			get{return _insur_mark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INSUR_CURR
		{
			set{ _insur_curr=value;}
			get{return _insur_curr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INSUR_RATE
		{
			set{ _insur_rate=value;}
			get{return _insur_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OTHER_MARK
		{
			set{ _other_mark=value;}
			get{return _other_mark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OTHER_CURR
		{
			set{ _other_curr=value;}
			get{return _other_curr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OTHER_RATE
		{
			set{ _other_rate=value;}
			get{return _other_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PACK_NO
		{
			set{ _pack_no=value;}
			get{return _pack_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GROSS_WT
		{
			set{ _gross_wt=value;}
			get{return _gross_wt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NET_WT
		{
			set{ _net_wt=value;}
			get{return _net_wt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WRAP_TYPE
		{
			set{ _wrap_type=value;}
			get{return _wrap_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LICENSE_NO
		{
			set{ _license_no=value;}
			get{return _license_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPR_NO
		{
			set{ _appr_no=value;}
			get{return _appr_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MANUAL_NO
		{
			set{ _manual_no=value;}
			get{return _manual_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RELATIVE_ID
		{
			set{ _relative_id=value;}
			get{return _relative_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RELATIVE_MANUAL_NO
		{
			set{ _relative_manual_no=value;}
			get{return _relative_manual_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BONDED_NO
		{
			set{ _bonded_no=value;}
			get{return _bonded_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CUSTOMS_FIELD
		{
			set{ _customs_field=value;}
			get{return _customs_field;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EDI_ID
		{
			set{ _edi_id=value;}
			get{return _edi_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EDI_REMARK
		{
			set{ _edi_remark=value;}
			get{return _edi_remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARTENER_ID
		{
			set{ _partener_id=value;}
			get{return _partener_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string P_DATE
		{
			set{ _p_date=value;}
			get{return _p_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TYPIST_NO
		{
			set{ _typist_no=value;}
			get{return _typist_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DECLARE_NO
		{
			set{ _declare_no=value;}
			get{return _declare_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BP_NO
		{
			set{ _bp_no=value;}
			get{return _bp_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NOTE_S
		{
			set{ _note_s=value;}
			get{return _note_s;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HYExport_2016
		{
			set{ _hyexport_2016=value;}
			get{return _hyexport_2016;}
		}
		#endregion Model

	}
}

