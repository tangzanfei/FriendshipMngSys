using FriendshipMngSys.BLL;
using FriendshipMngSys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendshipMngSys.DBUtility
{
    public static class DbHelper
    {
		private static PersonBLL personBLL=new PersonBLL();

		public static PersonBLL PersonBLL
		{
			get { return personBLL; }
		}

		private static FriendshipBLL friendshipBLL=new FriendshipBLL();

		public static FriendshipBLL FriendshipBLL
		{
			get { return friendshipBLL; }
		}

		private static CompanyShipBLL companyShipBLL=new CompanyShipBLL();

		public static CompanyShipBLL CompanyShipBLL
		{
			get { return companyShipBLL; }
		}

		private static ScoreDetailBLL scoreDetailBLL=new ScoreDetailBLL();

		public static ScoreDetailBLL ScoreDetailBLL
		{
			get { return scoreDetailBLL; }
		}


		private static CompanyBLL companyBLL=new CompanyBLL();

		public static CompanyBLL CompanyBLL
		{
			get { return companyBLL; }
		}



		public static List<Person> GetFriendListByID(string personID)
		{
			List<Person> friendList = new List<Person>();
			var datalist = DbHelper.FriendshipBLL.GetModelList("PersonID='" + personID + "'");
			if (datalist!=null)
			{
				foreach (var data in datalist)
				{
					var person = PersonBLL.GetModel(data.FriendID);
					if (person!=null)
					{
						friendList.Add(ModelConvertHelper.DBToModel(person));
					}
				}
			}
			return friendList;
		}

		public static bool UpdateFriendShip(string personID, IList<Person> friendList)
		{
			bool success = true;
			try
			{
				var dblist = DbHelper.GetFriendListByID(personID);

				foreach (var friend in friendList)
				{
					if (!dblist.Contains(friend,new PersonIdComparer()))
					{
						//新增的朋友
						var fs1 = new DBFriendship();
						var fs2 = new DBFriendship();
						fs1.ID=Guid.NewGuid().ToString();
						fs1.PersonID = personID;
						fs1.FriendID = friend.ID;

						fs2.ID = Guid.NewGuid().ToString();
						fs2.FriendID = personID;
						fs2.PersonID = friend.ID;

						if (!FriendshipBLL.Add(fs1))
						{
							success = false;
						}
						if (!FriendshipBLL.Add(fs2))
						{
							success = false;
						}
					}
				}
				foreach (var friend in dblist)
				{
					if (!friendList.Contains(friend, new PersonIdComparer()))
					{
						//被删除的朋友
						if (!friendshipBLL.DeleteByFriendShip(personID, friend.ID))
						{
							success = false;
						}
						if (!friendshipBLL.DeleteByFriendShip(friend.ID, personID))
						{
							success = false;
						}
					}
				}
			}
			catch (Exception e)
			{
				success = false;
				throw e;
			}
			return success;
		}
	}
}
