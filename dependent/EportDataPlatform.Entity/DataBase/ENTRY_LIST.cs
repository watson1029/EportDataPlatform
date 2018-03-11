/**  版本信息模板在安装目录下，可自行修改。
* ENTRY_LIST.cs
*
* 功 能： N/A
* 类 名： ENTRY_LIST
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/11/11 11:41:44   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace EportDataPlatform.Entity.DataBase
{
	/// <summary>
	/// ENTRY_LIST:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
    public partial class ENTRY_LIST
	{
        public ENTRY_LIST()
		{}
		#region Model
		private string _f_name;
		private string _pre_entry_id;
		private decimal _g_no;
		private string _code_ts;
		private string _class_mark;
		private string _g_name;
		private string _g_model;
		private string _origin_country;
		private decimal? _contr_item;
		private string _g_qty;
		private string _g_unit;
		private string _qty_1;
		private string _unit_1;
		private string _qty_2;
		private string _unit_2;
		private string _trade_curr;
		private string _decl_price;
		private string _decl_total;
		private string _use_to;
		private string _duty_mode;
		private string _work_usd;
		private string _prdt_no;
		private string _goods_id;
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
		public decimal G_NO
		{
			set{ _g_no=value;}
			get{return _g_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CODE_TS
		{
			set{ _code_ts=value;}
			get{return _code_ts;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLASS_MARK
		{
			set{ _class_mark=value;}
			get{return _class_mark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string G_NAME
		{
			set{ _g_name=value;}
			get{return _g_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string G_MODEL
		{
			set{ _g_model=value;}
			get{return _g_model;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORIGIN_COUNTRY
		{
			set{ _origin_country=value;}
			get{return _origin_country;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CONTR_ITEM
		{
			set{ _contr_item=value;}
			get{return _contr_item;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string G_QTY
		{
			set{ _g_qty=value;}
			get{return _g_qty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string G_UNIT
		{
			set{ _g_unit=value;}
			get{return _g_unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QTY_1
		{
			set{ _qty_1=value;}
			get{return _qty_1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UNIT_1
		{
			set{ _unit_1=value;}
			get{return _unit_1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QTY_2
		{
			set{ _qty_2=value;}
			get{return _qty_2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UNIT_2
		{
			set{ _unit_2=value;}
			get{return _unit_2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TRADE_CURR
		{
			set{ _trade_curr=value;}
			get{return _trade_curr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DECL_PRICE
		{
			set{ _decl_price=value;}
			get{return _decl_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DECL_TOTAL
		{
			set{ _decl_total=value;}
			get{return _decl_total;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USE_TO
		{
			set{ _use_to=value;}
			get{return _use_to;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DUTY_MODE
		{
			set{ _duty_mode=value;}
			get{return _duty_mode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WORK_USD
		{
			set{ _work_usd=value;}
			get{return _work_usd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRDT_NO
		{
			set{ _prdt_no=value;}
			get{return _prdt_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GOODS_ID
		{
			set{ _goods_id=value;}
			get{return _goods_id;}
		}
		#endregion Model

	}
}

