using Entitnies;
using NetCore.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace NetCore.Common
{
    public class Reflections
    {
        public static string isNullOrEmpty<T>(T t) where T : BaseEntity
        {
            Type type = typeof(T);
            T Entity = (T)Activator.CreateInstance(type);
            foreach(var pro in type.GetProperties())
            {
                if (pro.IsDefined(typeof(NotNullAttribute), true))
                {
                    PropertyInfo propertyInfo = type.GetProperty(pro.Name);
                    object value = propertyInfo.GetValue(t);
                    if (string.IsNullOrEmpty(Convert.ToString(value)))
                    {
                        return "字段存在空值，请检查";
                    }
                }
            }
            return "";
        }
    }
}
