/**  版本信息模板在安装目录下，可自行修改。
* DBCompanyShip.cs
*
* 功 能： N/A
* 类 名： DBCompanyShip
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/5/8 星期五 下午 4:19:55   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace FriendshipMngSys.Model
{
	/// <summary>
	/// DBCompanyShip:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DBCompanyShip
	{
		public DBCompanyShip()
		{}
		#region Model
		private string _id;
		private string _companyid;
		private string _personid;
		private int _jobtype=0;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyID
		{
			set{ _companyid=value;}
			get{return _companyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PersonID
		{
			set{ _personid=value;}
			get{return _personid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int JobType
		{
			set{ _jobtype=value;}
			get{return _jobtype;}
		}
		#endregion Model

	}
}

