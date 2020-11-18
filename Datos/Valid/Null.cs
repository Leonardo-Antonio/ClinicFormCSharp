using System;

namespace Datos.Valid
{
    public class Null
    {
        public static DBNull String(string valid)
        {
            return string.IsNullOrEmpty(valid) ? DBNull.Value : null;
        }
    }
}