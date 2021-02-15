using System;
using System.Collections.Generic;
using System.Text;

namespace Op.Wealth.Funds.Models
{
    static class Helpers
    {
        private const string dateFormat = "yyyy-MM-dd";
        // TODO: See if date check and conversion could be done in a fumction
        public static Tuple<string, string> DateParser(DateTime DtSince, DateTime DtUntil)
        {
            if (DtSince != default && DtUntil != default)
            {
                string since = DtSince.ToString(dateFormat);
                string until = DtUntil.ToString(dateFormat);

                return Tuple.Create(since, until);
            }
            else
            {
                return Tuple.Create("", "");
            }
        }
    }
}
