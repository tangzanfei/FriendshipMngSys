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


    public class Person
    {
        private string name;

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool isFemale;

        /// <summary>
        /// 性别
        /// </summary>
        public bool IsFemale
        {
            get { return isFemale; }
            set { isFemale = value; }
        }


        private List<Company> companyList;

        public List<Company> CompanyList
        {
            get { return companyList; }
            set { companyList = value; }
        }


        private string birthplace;
        /// <summary>
        /// 祖籍
        /// </summary>
        public string Birthplace
        {
            get { return birthplace; }
            set { birthplace = value; }
        }

        private int stuNum;

        /// <summary>
        /// 学生数
        /// </summary>
        public int StuNum
        {
            get { return stuNum; }
            set { stuNum = value; }
        }

        private string tel;

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        private int score;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        private E_JobType jobType;

        public E_JobType JobType
        {
            get { return jobType; }
            set { jobType = value; }
        }

        private double hourlypay;

        public double Hourlypay
        {
            get { return hourlypay; }
            set { hourlypay = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private bool hadDiscount;

        public bool HadDiscount
        {
            get { return hadDiscount; }
            set { hadDiscount = value; }
        }


    }
}
