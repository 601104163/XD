using System.Collections.Generic;

namespace XD.Generic
{
    class Dictionary__<T_KEY, T_VALUE> : Dictionary<T_KEY, T_VALUE>
    {
        public short GetInt16(T_KEY key)
        {
            string s = this[key].ToString();
            short ret;
            short.TryParse(s, out ret);
            return ret;
        }

        public int GetInt32(T_KEY key)
        {
            string s = this[key].ToString();
            int ret;
            int.TryParse(s, out ret);
            return ret;
        }

        public long GetInt64(T_KEY key)
        {
            string s = this[key].ToString();
            long ret;
            long.TryParse(s, out ret);
            return ret;
        }

        public ushort GetUInt16(T_KEY key)
        {
            string s = this[key].ToString();
            ushort ret;
            ushort.TryParse(s, out ret);
            return ret;
        }

        public uint GetUInt32(T_KEY key)
        {
            string s = this[key].ToString();
            uint ret;
            uint.TryParse(s, out ret);
            return ret;
        }

        public ulong GetUInt64(T_KEY key)
        {
            string s = this[key].ToString();
            ulong ret;
            ulong.TryParse(s, out ret);
            return ret;
        }

        public float GetFloat(T_KEY key)
        {
            string s = this[key].ToString();
            float ret;
            float.TryParse(s, out ret);
            return ret;
        }

        public double GetDouble(T_KEY key)
        {
            string s = this[key].ToString();
            double ret;
            double.TryParse(s, out ret);
            return ret;
        }

        public char GetChar(T_KEY key)
        {
            string s = this[key].ToString();
            char[] _charArray = s.ToCharArray();
            char ret = '\0';
            if (_charArray.Length > 0)
                ret = _charArray[0];
            return ret;
        }
    }
}
