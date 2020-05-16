using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendshipMngSys.Model
{

    public class Person : ModelBase
    {

        private string name;

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            { 
                name = value;
                NotifyPropertyChange("Name"); 
            }
        }

        private bool isFemale;

        /// <summary>
        /// 性别
        /// </summary>
        public bool IsFemale
        {
            get { return isFemale; }
            set {
                isFemale = value;
                NotifyPropertyChange("IsFemale");

            }
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
            set { birthplace = value; NotifyPropertyChange("Birthplace"); }
        }

        private int stuNum;

        /// <summary>
        /// 学生数
        /// </summary>
        public int StuNum
        {
            get { return stuNum; }
            set { stuNum = value; NotifyPropertyChange("StuNum"); }
        }

        private string tel;

        public string Tel
        {
            get { return tel; }
            set { tel = value; NotifyPropertyChange("Tel"); }
        }

        private int score;



        /*
         * 
课时费240以上的老师加5分（单次）
学生数量高于25个以上加5分（单次）
参加过比赛加5分（累加）
参加过多钢琴加10分（累加）
买了教学琴加5分（单次）
介绍调律加5分（累加）
租场5分（累加）
成交10分（累加）
备案5分（单次）
调律5分（累加）
         * 
         * 
         * */
        public int Score
        {
            get { return score; }
            set { score = value; NotifyPropertyChange("Score"); }
        }



        private int hourlypay;

        public int Hourlypay
        {
            get { return hourlypay; }
            set { hourlypay = value; NotifyPropertyChange("Hourlypay"); }
        }

        private string age="80后";

        public string Age
        {
            get { return age; }
            set { age = value; NotifyPropertyChange("Age"); }
        }

        private bool hadDiscount;


        public bool HadDiscount
        {
            get { return hadDiscount; }
            set { hadDiscount = value; NotifyPropertyChange("HadDiscount"); }
        }
                
        private Dictionary<Company,E_JobType> _CompanyDic=new Dictionary<Company, E_JobType>();

        public Dictionary<Company,E_JobType> CompanyDic
        {
            get { return _CompanyDic; }
            set { _CompanyDic = value; }
        }

    }
}
