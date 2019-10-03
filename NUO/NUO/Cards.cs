using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUO
{
    class Cards
    {
        public Cards()
        {

        }

        public Cards(int idCard, int colorCard, int valueCard, int idPlayerCard)
        {
            Id = idCard;
            Color = colorCard;
            Value = valueCard;
            IdPlayer = idPlayerCard;
        }

        public int Id { get; set; }
        public int Color { get; set; }
        public int Value { get; set; }
        public int IdPlayer { get; set; }

    }
}
