﻿namespace Project1
{
    // this class represents man object
    internal class CheckersMan
    {
        internal enum eType
        {
            O,
            X,
            U,
            K,
            None
        }

        internal eType m_Type;

        public CheckersMan(eType i_Type)
        {
            m_Type = i_Type;
        }

        internal string returnType()
        {
            string type = string.Empty;

            switch(m_Type)
            {
                case eType.O:
                    type = " O ";
                    break;
                case eType.X:
                    type = " X ";
                    break;
                case eType.U:
                    type = " U ";
                    break;
                case eType.K:
                    type = " K ";
                    break;
                case eType.None:
                    type = "   ";
                    break;
            }

            return type;
        }
    }
}
