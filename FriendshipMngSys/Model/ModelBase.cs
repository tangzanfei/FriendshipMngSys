using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendshipMngSys.Model
{
    /// <summary>
    /// 逻辑实体类基类
    /// </summary>
    public class ModelBase:NotifyBase
    {
        /// <summary>
        /// 全球唯一标识
        /// </summary>
        public string ID { get; set; }
        public ModelBase()
        {
            ID = Guid.NewGuid().ToString();
        }
        public ModelBase Copy()
        {
            return (ModelBase)this.MemberwiseClone();
        }

    }
}
