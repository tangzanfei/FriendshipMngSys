/**  版本信息模板在安装目录下，可自行修改。
* DBFriendship.cs
*
* 功 能： N/A
* 类 名： DBFriendship
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/5/8 星期五 下午 4:19:56   N/A    初版
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
	/// DBFriendship:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DBFriendship
	{
		public DBFriendship()
		{}
		#region Model
		private string _id;
		private string _personid;
		private string _friendid;
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
		public string PersonID
		{
			set{ _personid=value;}
			get{return _personid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FriendID
		{
			set{ _friendid=value;}
			get{return _friendid;}
		}
		#endregion Model

	}
}

