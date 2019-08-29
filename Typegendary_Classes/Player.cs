namespace Typegendary_Classes
{
    /// <summary>
    /// 角色属性
    /// </summary>
    public class Player
    {
        public enum Directions { Left, Up, Right, Down }
        public Directions Direction { get; set; }
        public uint X { get; private set; }
        public uint Y { get; private set; }

        /// <summary> 生命值 </summary>
        public int Life { get; private set; } = 100;
        /// <summary> 最大生命值 </summary>
        public int Life_Max { get; private set; } = 100;
        /// <summary> 法力值 </summary>
        public int Mana { get; private set; } = 0;
        /// <summary> 最大法力值 </summary>
        public int Mana_Max { get; private set; } = 10;
        /// <summary> 法术攻击力 </summary>
        public int Ap_Offence { get; private set; }
        /// <summary> 物理攻击力 </summary>
        public int Ad_Offence { get; private set; }
        /// <summary> 物理攻击距离 </summary>
        public int Ad_Distance { get; private set; }

        
    }
}
