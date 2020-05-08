/**  版本信息模板在安装目录下，可自行修改。
* DBPerson.cs
*
* 功 能： N/A
* 类 名： DBPerson
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
	/// DBPerson:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DBPerson
	{
		public DBPerson()
		{}
		#region Model
		private string _id;
		private string _name;
		private int _age=0;
		private bool _isfemale= false;
		private int _stunum=0;
		private string _birthplace;
		private string _tel;
		private int _jobtype=0;
		private int _hourlypay=0;
		private bool _haddiscount= false;
		private int _score=0;
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
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Age
		{
			set{ _age=value;}
			get{return _age;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsFemale
		{
			set{ _isfemale=value;}
			get{return _isfemale;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int StuNum
		{
			set{ _stunum=value;}
			get{return _stunum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Birthplace
		{
			set{ _birthplace=value;}
			get{return _birthplace;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int JobType
		{
			set{ _jobtype=value;}
			get{return _jobtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Hourlypay
		{
			set{ _hourlypay=value;}
			get{return _hourlypay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool HadDiscount
		{
			set{ _haddiscount=value;}
			get{return _haddiscount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Score
		{
			set{ _score=value;}
			get{return _score;}
		}
		#endregion Model

	}
}

