using FriendshipMngSys.BLL;
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

	}
}
