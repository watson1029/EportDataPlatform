/**  版本信息模板在安装目录下，可自行修改。
* ENTRY_RETURN.cs
*
* 功 能： N/A
* 类 名： ENTRY_RETURN
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/2/1 14:49:46   N/A    初版
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
	/// ENTRY_RETURN:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ENTRY_RETURN
	{
		public ENTRY_RETURN()
		{}
		#region Model
		private string _f_name;
		private string _pre_entry_id;
		private string _entry_id;
		private DateTime? _notice_date;
		private string _channel;
		private string _note;
		private string _decl_port;
		private string _agent_name;
		private string _declare_no;
		private string _trade_co;
		private string _customs_field;
		private string _bonded_no;
		private DateTime? _i_e_date;
		private string _pack_no;
		private string _bill_no;
		private string _traf_mode;
		private string _voyage_no;
		private string _net_wt;
		private string _gross_wt;
		private DateTime? _d_date;
		private string _i_e_flag;
        private string _save_ref_id;
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
		public string ENTRY_ID
		{
			set{ _entry_id=value;}
			get{return _entry_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? NOTICE_DATE
		{
			set{ _notice_date=value;}
			get{return _notice_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CHANNEL
		{
			set{ _channel=value;}
			get{return _channel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NOTE
		{
			set{ _note=value;}
			get{return _note;}
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
		public string AGENT_NAME
		{
			set{ _agent_name=value;}
			get{return _agent_name;}
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
		public string TRADE_CO
		{
			set{ _trade_co=value;}
			get{return _trade_co;}
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
		public string BONDED_NO
		{
			set{ _bonded_no=value;}
			get{return _bonded_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? I_E_DATE
		{
			set{ _i_e_date=value;}
			get{return _i_e_date;}
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
		public string BILL_NO
		{
			set{ _bill_no=value;}
			get{return _bill_no;}
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
		public string VOYAGE_NO
		{
			set{ _voyage_no=value;}
			get{return _voyage_no;}
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
		public string GROSS_WT
		{
			set{ _gross_wt=value;}
			get{return _gross_wt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? D_DATE
		{
			set{ _d_date=value;}
			get{return _d_date;}
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
        //public string SAVE_REF_ID
        //{
        //    set { _save_ref_id = value; }
        //    get { return _save_ref_id; }
        //}
		#endregion Model

	}
}

