using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signum.NET
{
    public static class Extensions
    {
        public static string PrintInterfaceData(this object obj)
        {

            obj.GetType().GetInterfaces();

            StringBuilder sb = new();
            sb.AppendLine();

            foreach (Type iface in obj.GetType().GetInterfaces())
            {
                sb.AppendLine($"Interface Name: {iface.Name}");
                sb.AppendLine("-----------------------------");
                sb.AppendLine("Header - Value");
                sb.AppendLine("-----------------------------");

                foreach (var item in iface.GetProperties())
                {
                    sb.Append(item.Name);
                    sb.Append(" - ");
                    sb.Append(item.GetValue(obj));
                    sb.AppendLine();

                }
                sb.AppendLine();
            }

            return sb.ToString();



        }


    }
}
