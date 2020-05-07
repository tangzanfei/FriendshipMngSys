/**  版本信息模板在安装目录下，可自行修改。
* ScoreDetailDAL.cs
*
* 功 能： N/A
* 类 名： ScoreDetailDAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/5/7 星期四 下午 5:19:17   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using FriendshipMngSys.DBUtility;//Please add references
namespace FriendshipMngSys.DAL
{
	/// <summary>
	/// 数据访问类:ScoreDetailDAL
	/// </summary>
	public partial class ScoreDetailDAL
	{
		public ScoreDetailDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("ID", "ScoreDetail"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ScoreDetail");
			strSql.Append(" where ID=@ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ID", DbType.Int32,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(FriendshipMngSys.Model.DBScoreDetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ScoreDetail(");
			strSql.Append("PersonID,课时费高,学生多,已备案,已买教学琴,参加比赛,参加多钢琴,租场,成交,调律)");
			strSql.Append(" values (");
			strSql.Append("@PersonID,@课时费高,@学生多,@已备案,@已买教学琴,@参加比赛,@参加多钢琴,@租场,@成交,@调律)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PersonID", DbType.Int32,8),
					new SQLiteParameter("@课时费高", DbType.Int32,4),
					new SQLiteParameter("@学生多", DbType.Int32,4),
					new SQLiteParameter("@已备案", DbType.Int32,4),
					new SQLiteParameter("@已买教学琴", DbType.Int32,4),
					new SQLiteParameter("@参加比赛", DbType.Int32,4),
					new SQLiteParameter("@参加多钢琴", DbType.Int32,4),
					new SQLiteParameter("@租场", DbType.Int32,4),
					new SQLiteParameter("@成交", DbType.Int32,4),
					new SQLiteParameter("@调律", DbType.Int32,4)};
			parameters[0].Value = model.PersonID;
			parameters[1].Value = model.课时费高;
			parameters[2].Value = model.学生多;
			parameters[3].Value = model.已备案;
			parameters[4].Value = model.已买教学琴;
			parameters[5].Value = model.参加比赛;
			parameters[6].Value = model.参加多钢琴;
			parameters[7].Value = model.租场;
			parameters[8].Value = model.成交;
			parameters[9].Value = model.调律;

			object obj = DbHelperSQLite.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(FriendshipMngSys.Model.DBScoreDetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ScoreDetail set ");
			strSql.Append("PersonID=@PersonID,");
			strSql.Append("课时费高=@课时费高,");
			strSql.Append("学生多=@学生多,");
			strSql.Append("已备案=@已备案,");
			strSql.Append("已买教学琴=@已买教学琴,");
			strSql.Append("参加比赛=@参加比赛,");
			strSql.Append("参加多钢琴=@参加多钢琴,");
			strSql.Append("租场=@租场,");
			strSql.Append("成交=@成交,");
			strSql.Append("调律=@调律");
			strSql.Append(" where ID=@ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@PersonID", DbType.Int32,8),
					new SQLiteParameter("@课时费高", DbType.Int32,4),
					new SQLiteParameter("@学生多", DbType.Int32,4),
					new SQLiteParameter("@已备案", DbType.Int32,4),
					new SQLiteParameter("@已买教学琴", DbType.Int32,4),
					new SQLiteParameter("@参加比赛", DbType.Int32,4),
					new SQLiteParameter("@参加多钢琴", DbType.Int32,4),
					new SQLiteParameter("@租场", DbType.Int32,4),
					new SQLiteParameter("@成交", DbType.Int32,4),
					new SQLiteParameter("@调律", DbType.Int32,4),
					new SQLiteParameter("@ID", DbType.Int32,8)};
			parameters[0].Value = model.PersonID;
			parameters[1].Value = model.课时费高;
			parameters[2].Value = model.学生多;
			parameters[3].Value = model.已备案;
			parameters[4].Value = model.已买教学琴;
			parameters[5].Value = model.参加比赛;
			parameters[6].Value = model.参加多钢琴;
			parameters[7].Value = model.租场;
			parameters[8].Value = model.成交;
			parameters[9].Value = model.调律;
			parameters[10].Value = model.ID;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ScoreDetail ");
			strSql.Append(" where ID=@ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ID", DbType.Int32,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ScoreDetail ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public FriendshipMngSys.Model.DBScoreDetail GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,PersonID,课时费高,学生多,已备案,已买教学琴,参加比赛,参加多钢琴,租场,成交,调律 from ScoreDetail ");
			strSql.Append(" where ID=@ID");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ID", DbType.Int32,4)
			};
			parameters[0].Value = ID;

			FriendshipMngSys.Model.DBScoreDetail model=new FriendshipMngSys.Model.DBScoreDetail();
			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public FriendshipMngSys.Model.DBScoreDetail DataRowToModel(DataRow row)
		{
			FriendshipMngSys.Model.DBScoreDetail model=new FriendshipMngSys.Model.DBScoreDetail();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["PersonID"]!=null && row["PersonID"].ToString()!="")
				{
					model.PersonID=int.Parse(row["PersonID"].ToString());
				}
				if(row["课时费高"]!=null && row["课时费高"].ToString()!="")
				{
					model.课时费高=int.Parse(row["课时费高"].ToString());
				}
				if(row["学生多"]!=null && row["学生多"].ToString()!="")
				{
					model.学生多=int.Parse(row["学生多"].ToString());
				}
				if(row["已备案"]!=null && row["已备案"].ToString()!="")
				{
					model.已备案=int.Parse(row["已备案"].ToString());
				}
				if(row["已买教学琴"]!=null && row["已买教学琴"].ToString()!="")
				{
					model.已买教学琴=int.Parse(row["已买教学琴"].ToString());
				}
				if(row["参加比赛"]!=null && row["参加比赛"].ToString()!="")
				{
					model.参加比赛=int.Parse(row["参加比赛"].ToString());
				}
				if(row["参加多钢琴"]!=null && row["参加多钢琴"].ToString()!="")
				{
					model.参加多钢琴=int.Parse(row["参加多钢琴"].ToString());
				}
				if(row["租场"]!=null && row["租场"].ToString()!="")
				{
					model.租场=int.Parse(row["租场"].ToString());
				}
				if(row["成交"]!=null && row["成交"].ToString()!="")
				{
					model.成交=int.Parse(row["成交"].ToString());
				}
				if(row["调律"]!=null && row["调律"].ToString()!="")
				{
					model.调律=int.Parse(row["调律"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,PersonID,课时费高,学生多,已备案,已买教学琴,参加比赛,参加多钢琴,租场,成交,调律 ");
			strSql.Append(" FROM ScoreDetail ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM ScoreDetail ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from ScoreDetail T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tblName", DbType.VarChar, 255),
					new SQLiteParameter("@fldName", DbType.VarChar, 255),
					new SQLiteParameter("@PageSize", DbType.Int32),
					new SQLiteParameter("@PageIndex", DbType.Int32),
					new SQLiteParameter("@IsReCount", DbType.bit),
					new SQLiteParameter("@OrderType", DbType.bit),
					new SQLiteParameter("@strWhere", DbType.VarChar,1000),
					};
			parameters[0].Value = "ScoreDetail";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQLite.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

