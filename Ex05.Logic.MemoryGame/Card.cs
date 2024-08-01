using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.Logic.MemoryGame
{
    public class Card
    {
        private bool m_IsFlipped;
        private readonly uint r_Content;
        private readonly int r_Row;
        private readonly int r_Col;

        public Card(uint i_Data, int i_Row, int i_Col)
        {
            m_IsFlipped = false;
            r_Content = i_Data;
            r_Row = i_Row;
            r_Col = i_Col;
        }

        public bool IsFlipped
        {
            get 
            {
                return m_IsFlipped;
            }
            set 
            {
                m_IsFlipped = value;
            }
        }

        public uint Content
        {
            get 
            {
                return r_Content;
            }
        }
    }
}
