using FriendshipMngSys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendshipMngSys.DBUtility
{
    /// <summary>
    /// 提供数据库类型和业务实际类型的转化
    /// </summary>
    public static class ModelConvertHelper
    {
        public static Person DBToModel(DBPerson db)
        {
            Person person = new Person();
            person.ID = db.ID; ;
            person.Name = db.Name;
            person.Age = db.Age;
            person.Birthplace = db.Birthplace;
            person.IsFemale = db.IsFemale;
            person.Score = db.Score;
            person.StuNum = db.StuNum;
            person.Tel = db.Tel;
            person.JobType = (E_JobType)db.JobType;
            person.Hourlypay = db.Hourlypay;
            person.HadDiscount = db.HadDiscount;
            person.CompanyList = new List<Company>();

            return person;
        }

        public static DBPerson ModelToDB(Person person)
        {
            DBPerson db = new DBPerson();
            db.ID = person.ID; 
            db.Name = person.Name;
            db.Age = person.Age;
            db.Birthplace = person.Birthplace;
            db.IsFemale = person.IsFemale;
            db.Score = person.Score;
            db.StuNum = person.StuNum;
            db.Tel = person.Tel;
            db.JobType = (int)person.JobType;
            db.Hourlypay = person.Hourlypay;
            db.HadDiscount = person.HadDiscount;


            return db;
        }
    }
}
