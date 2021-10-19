using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Runtime.Serialization;
using Intersight.Model;

namespace Intersight.PowerShell
{
    public class PSUtils
    {
        public const string ObjectType = "ObjectType";
        public const string Moid = "Moid";
        public const string CmdletParam = "cmdletParam";
        public const string JsonData = "jsonData";

        public static string GetPath(string objectType)
        {
            var path = string.Empty;
            var tempList = objectType.Split('.');
            tempList[tempList.Length - 1] = GetPlurals(tempList[tempList.Length - 1]);
            path = string.Join('/', tempList);
            return path;
        }

        public static string GetPlurals(string str)
        {
            var result = string.Empty;
            var charArray = str.ToCharArray();
            var lastChar = charArray[charArray.Length - 1];
            var secondLastChar = charArray[charArray.Length - 2];
            if (lastChar == 'o')
            {
                result = string.Concat(str, "es");
            }
            else if (lastChar == 'y')
            {
                if (isVowel(secondLastChar))
                {
                    result = string.Concat(str, "s");
                }
                else
                {
                    var temp = charArray;
                    temp[temp.Length - 1] = 'i';
                    result = string.Concat(string.Join("", temp), "es");
                }

            }
            else if (isVowel(lastChar) && isVowel(secondLastChar))
            {
                result = string.Concat(str, "s");
            }
            else
            {
                result = string.Concat(str, "s");
            }

            return result;
        }

        public static bool isVowel(char ch)
        {
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            if (vowels.Contains(ch))
            {
                return true;
            }
            return false;
        }

        
        public static string GetObjectTypeDisplayName(string objectType)
        {
            string result = String.Empty;
            var enumVals = Enum.GetNames(typeof(MoBaseMo.ObjectTypeEnum));
            var enumList = new List<string>(enumVals);
            if (enumList.Contains(objectType))
            {
                var testType = MoBaseMo.ObjectTypeEnum.AaaAuditRecord;
                FieldInfo info = testType.GetType().GetField(objectType);
                EnumMemberAttribute[] attributes = (EnumMemberAttribute[])info.GetCustomAttributes(typeof(EnumMemberAttribute), false);
                if (attributes != null && attributes.Length > 0)
                {
                    result = attributes[0].Value;
                }

            }

            return result;
        }
    }
}
