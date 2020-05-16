using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendshipMngSys.Model
{

    /// <summary>
    /// 工作类型
    /// </summary>
    public enum E_JobType
    {
        /// <summary>
        /// 老板
        /// </summary>
        Boss = 0,         //老板
        /// <summary>
        /// 全职
        /// </summary>
        FullTime = 1,     //全职
        /// <summary>
        /// 兼职
        /// </summary>
        PartTime = 2,     //兼职
    }

    public class Company : ModelBase
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private string address;

        public string Addiress
        {
            get { return address; }
            set { address = value; }
        }




    }
}
