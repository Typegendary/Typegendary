using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typegendary2_Server.InfoClass
{
    /// <summary>
    /// 材料类型
    /// </summary>
    public enum MaterialType
    {
        即时血包,
        应急血包,
        可存血包,

    }

    /// <summary>
    /// 材料信息
    /// </summary>
    public class MaterialInfo
    {
        private MaterialType Type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

    }
}
