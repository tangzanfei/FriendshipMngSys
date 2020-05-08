/**  版本信息模板在安装目录下，可自行修改。
* DBScoreDetail.cs
*
* 功 能： N/A
* 类 名： DBScoreDetail
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
	/// DBScoreDetail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DBScoreDetail
	{
		public DBScoreDetail()
		{}
		#region Model
		private string _id;
		private string _personid;
		private int _课时费高=0;
		private int _学生多=0;
		private int _已备案=0;
		private int _已买教学琴=0;
		private int _参加比赛=0;
		private int _参加多钢琴=0;
		private int _租场=0;
		private int _成交=0;
		private int _调律=0;
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
		public int 课时费高
		{
			set{ _课时费高=value;}
			get{return _课时费高;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int 学生多
		{
			set{ _学生多=value;}
			get{return _学生多;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int 已备案
		{
			set{ _已备案=value;}
			get{return _已备案;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int 已买教学琴
		{
			set{ _已买教学琴=value;}
			get{return _已买教学琴;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int 参加比赛
		{
			set{ _参加比赛=value;}
			get{return _参加比赛;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int 参加多钢琴
		{
			set{ _参加多钢琴=value;}
			get{return _参加多钢琴;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int 租场
		{
			set{ _租场=value;}
			get{return _租场;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int 成交
		{
			set{ _成交=value;}
			get{return _成交;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int 调律
		{
			set{ _调律=value;}
			get{return _调律;}
		}
		#endregion Model

	}
}

