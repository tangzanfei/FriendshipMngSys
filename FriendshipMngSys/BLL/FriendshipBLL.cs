/**  版本信息模板在安装目录下，可自行修改。
* FriendshipBLL.cs
*
* 功 能： N/A
* 类 名： FriendshipBLL
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
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using FriendshipMngSys.Model;
namespace FriendshipMngSys.BLL
{
	/// <summary>
	/// FriendshipBLL
	/// </summary>
	public partial class FriendshipBLL
	{
		private readonly FriendshipMngSys.DAL.FriendshipDAL dal=new FriendshipMngSys.DAL.FriendshipDAL();
		public FriendshipBLL()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(FriendshipMngSys.Model.DBFriendship model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(FriendshipMngSys.Model.DBFriendship model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public FriendshipMngSys.Model.DBFriendship GetModel(string ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public FriendshipMngSys.Model.DBFriendship GetModelByCache(string ID)
		{
			
			string CacheKey = "DBFriendshipModel-" + ID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (FriendshipMngSys.Model.DBFriendship)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<FriendshipMngSys.Model.DBFriendship> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<FriendshipMngSys.Model.DBFriendship> DataTableToList(DataTable dt)
		{
			List<FriendshipMngSys.Model.DBFriendship> modelList = new List<FriendshipMngSys.Model.DBFriendship>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				FriendshipMngSys.Model.DBFriendship model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
		//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteByFriendShip(string ID,string FID)
		{

			return dal.DeleteByFriendship(ID, FID);
		}


		#endregion  ExtensionMethod
	}
}

