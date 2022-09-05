using System;

namespace OperatorMonitor.Business.Extensions
{
    public static class EnumExtensions
    {
        public static string ToDescription(this Enum enumeration)
        {
            var type = enumeration.GetType();
            var memInfo = type.GetMember(enumeration.ToString());
            if (memInfo.Length > 0)
            {
                var attrs = memInfo[0].GetCustomAttributes(typeof(EnumDescription), false);
                if (attrs.Length > 0)
                    return ((EnumDescription)attrs[0]).Description;
            }
            return enumeration.ToString();
        }
    }


    public class EnumDescription : Attribute
    {
        public EnumDescription(string description)
        {
            Description = description;
        }

        public string Description { get; private set; }
    }
}
