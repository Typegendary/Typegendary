using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typegendary2_Server.InfoClass
{
    /// <summary>
    /// 角色属性
    /// </summary>
    partial class PlayerInfo
    {
        // 角色属性
        /// <summary>
        /// 生命值
        /// </summary>
        public int Life { get; private set; } = 100;
        /// <summary>
        /// 最大生命值
        /// </summary>
        public int Life_Max { get; private set; } = 100;
        /// <summary>
        /// 法力值
        /// </summary>
        public int Mana { get; private set; } = 0;
        /// <summary>
        /// 最大法力值
        /// </summary>
        public int Mana_Max { get; private set; } = 10;

        // 物理攻击（近程）
        /// <summary>
        /// 物理防御力
        /// </summary>
        public int Ad_Defence { get; private set; }
        /// <summary>
        /// 物理攻击力
        /// </summary>
        public int Ad_Offence { get; private set; }
        /// <summary>
        /// 物理攻击距离
        /// </summary>
        public int Ad_Distance { get; private set; }

        // 法术攻击（远程）
        /// <summary>
        /// 法术防御力
        /// </summary>
        public int Ap_Defence { get; private set; }
        /// <summary>
        /// 法术攻击力
        /// </summary>
        public int Ap_Offence { get; private set; }
    }

    /// <summary>
    /// 调整属性值
    /// </summary>
    public partial class PlayerInfo
    {

    }
}
