using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class Hero
    {
        private string name;
        private Kingdoms kingdoms;
        private int magatama;
        private string skill;


        // 掉血 被动技能 重写
        public int Magatama
        {
            set
            {
                if (value < magatama)
                {
                    // 委托掉血 被动技能
                }
                magatama = value;
            }
            get
            {
                return magatama;
            }
        }

        public void SetSkill()
        {

        }

        // skill  技能目标 附体

    }
}
