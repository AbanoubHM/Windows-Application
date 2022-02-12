using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatt {
    public class FontC {
        public Color color { get; set; }= Color.Black;
        public int size { get; set; } = 14;
        public string font { get; set; }
        public FontStyle f { get; set; }= FontStyle.Regular;
    }
}
