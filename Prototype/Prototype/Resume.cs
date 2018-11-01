using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Resume:ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private WorkExperience work;

        public Resume(string name)
        {
            this.name = name;
            work = new WorkExperience();
        }

        private Resume(WorkExperience work)
        {
            this.work = (WorkExperience)work.Clone();
        }

        public void SetPersonalInfo(string sex,string age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void SetWorkExperience(string workDate,string company)
        {
            work.WorkDate = workDate;
            work.Company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", name, sex, age);
            Console.WriteLine("工作经历： {0} {1}", work.WorkDate, work.Company);
        }

        public object Clone()
        {
            Resume resume = new Resume(this.work);
            resume.name = this.name;
            resume.sex = this.sex;
            resume.age = this.age;
            return resume;
        }
    }
}
