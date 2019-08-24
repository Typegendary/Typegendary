using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typegendary2_Server.InfoClass
{
    public class PlayerInfo
    {
        /// <summary>
        /// 生命值
        /// </summary>
        public int Life { get; private set; }
        public void Life_Add(int value) => Life += value;
        /// <summary>
        /// 防御力
        /// </summary>
        public int Equipment { get; private set; }
        public void Equipment_Set(int value) => Equipment = value;
        /// <summary>
        /// 攻击力
        /// </summary>
        public int Arms { get; private set; }
        public void Arms_Set(int value) => Arms = value;
        /// <summary>
        /// 携带的物品(*6)
        /// </summary>
        public int[] Goods { get; private set; } = new int[6];
        public void Goods_Set(int index, int value) => Goods[index] = value;
        //
        //
        //

    }
}
