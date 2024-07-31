using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_MemoryGameConsole.GameLogic
{
    internal class Card
    {
        private bool m_IsFlipped;
        private readonly uint r_Content;
        private readonly string r_Location;

        public Card(uint i_Data, string i_Location)
        {
            m_IsFlipped = false;
            r_Content = i_Data;
            r_Location = i_Location;
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

        public string Location
        {
            get
            {
                return r_Location;
            }
        }
    }
}
