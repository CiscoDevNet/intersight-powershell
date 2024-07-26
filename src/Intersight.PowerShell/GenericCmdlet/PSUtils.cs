using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Runtime.Serialization;
using Intersight.Model;
using System.Linq;
using System.Collections;
using System.Management.Automation;

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

        /// <summary>
        /// set the _Flag field to false,to ensure that it will not serialized the property which is not configured.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="modelObject"></param>
        public static void SetSerializeFalgToFalse(string propertyName, object modelObject)
        {
            var fieldName = string.Format("_flag{0}", propertyName);
            var fieldInfo = modelObject.GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldInfo != null)
            {
                var fieldVal = fieldInfo.GetValue(modelObject);
                if ((bool)fieldVal)
                {
                    fieldInfo.SetValue(modelObject, false);
                }
            }
        }


        /// <summary>
        /// Compare the Intersight Object based on Json data.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool CompareIntersightObject(object x, object y, ICommandRuntime commandRuntime = null)
        {
            string xJsonData = string.Empty;
            string yJsonData = string.Empty;

            if (x == null && y == null)
            {
                return true;
            }

            if (x == null || y == null)
            {
                return false;
            }

            var xType = x.GetType();
            var yType = y.GetType();

            if (xType.FullName != yType.FullName)
            {
                return false;
            }

            if (xType.FullName.StartsWith("Intersight.Model"))
            {
                var xMethodsInfo = xType.GetMethod("ToJson");
                if (xMethodsInfo != null)
                {
                    xJsonData = xMethodsInfo.Invoke(x, null).ToString();
                }

                var yMethodsInfo = yType.GetMethod("ToJson");
                if (yMethodsInfo != null)
                {
                    yJsonData = yMethodsInfo.Invoke(y, null).ToString();
                }

                return xJsonData == yJsonData;
            }
            if (commandRuntime != null)
            {
                commandRuntime.WriteVerbose(string.Format("comparing objects of type {0} and {0}", xType.Name, yType.Name));
            }
            return x == y;
        }

        /// <summary>
        /// return true if the both list is same otherwise returns false 
        /// Note: This method does not compare nested list.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool CompareList(object x, object y, ICommandRuntime commandRuntime = null)
        {
            if (x.GetType().Name != "List`1")
            {
                return false;
            }

            if (x.GetType() != y.GetType())
            {
                return false;
            }

            var xGenericTypeArguments = x.GetType().GenericTypeArguments;

            if (commandRuntime != null)
            {
                commandRuntime.WriteVerbose(String.Format("Comparing List of type {0}", xGenericTypeArguments[0].Name));
            }

            if (xGenericTypeArguments != null && xGenericTypeArguments.Length > 0 && xGenericTypeArguments[0].IsPrimitive)
            {
                return CompareListOfPrimitiveType(x, y, xGenericTypeArguments[0].Name);
            }

            var xIenumerable = x as IEnumerable<Object>;
            var yIenumerable = y as IEnumerable<Object>;

            // if both x and y is null return true
            if (xIenumerable == null && yIenumerable == null)
            {
                return true;
            }

            // return false if either x or y is null
            if (xIenumerable == null || yIenumerable == null)
            {
                return false;
            }

            //return true if both x and y has count 0
            if (xIenumerable.Count() == 0 && yIenumerable.Count() == 0)
            {
                return true;
            }

            // return false if x and y count mismatch.
            if (xIenumerable.Count() != yIenumerable.Count())
            {
                return false;
            }
            return Enumerable.SequenceEqual(yIenumerable, xIenumerable, new CustomComparer());
        }

        /// <summary>
        /// Compare two dictionary and return true if it is same. 
        /// Note: it does not compare netsed dictionary.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool CompareDictionary(object x, object y, ICommandRuntime commandRuntime = null)
        {
            var xDict = x as IDictionary;
            var yDict = y as IDictionary;
            bool isEqual = false;

            // return true if both dictionary is null
            if (xDict == null && yDict == null)
            {
                return true;
            }

            // return false if either of dictionary is null
            if (xDict == null || yDict == null)
            {
                return false;
            }

            // return true if both dictionary has count 0
            if (xDict.Count == 0 && yDict.Count == 0)
            {
                return true;
            }

            // return false if count mismatch
            if (xDict.Count != yDict.Count)
            {
                return false;
            }

            if (commandRuntime != null)
            {
                commandRuntime.WriteVerbose(string.Format("Comparing dictionary of type <{0},{1}>", xDict.GetType().GenericTypeArguments[0].Name, xDict.GetType().GenericTypeArguments[1].Name));
            }

            foreach (DictionaryEntry dictItem in yDict)
            {
                if (xDict.Contains(dictItem.Key))
                {
                    var getDictVal = xDict[dictItem.Key];
                    if (getDictVal.GetType().FullName != dictItem.Value.GetType().FullName)
                    {
                        return false;
                    }

                    if (getDictVal.GetType().IsPrimitive || getDictVal.GetType().IsEnum || getDictVal.GetType().Name == "String")
                    {
                        if (!(getDictVal.ToString() == dictItem.Value.ToString()))
                        {
                            return false;
                        }
                        isEqual = true;
                    }
                    else if (getDictVal.GetType().FullName.StartsWith("Intersight.Model"))
                    {
                        if (!(PSUtils.CompareIntersightObject(getDictVal, dictItem.Value)))
                        {
                            return false;
                        }
                        isEqual = true;
                    }
                    else if (getDictVal.GetType().Name == "List`1")
                    {
                        if (!(PSUtils.CompareList(getDictVal, dictItem.Value)))
                        {
                            return false;
                        }
                        isEqual = true;
                    }
                    else if (getDictVal.GetType().Name == "JObject")
                    {
                        var xJobject = (Newtonsoft.Json.Linq.JObject)getDictVal;
                        var yJobject = (Newtonsoft.Json.Linq.JObject)dictItem.Value;
                        if (!(xJobject.ToString() == yJobject.ToString()))
                        {
                            return false;
                        }
                        isEqual = true;
                    }
                    else
                    {
                        var xJobject = Newtonsoft.Json.Linq.JObject.FromObject(getDictVal).ToString();
                        var yJobject = Newtonsoft.Json.Linq.JObject.FromObject(dictItem.Value).ToString();
                        if (!(xJobject == yJobject))
                        {
                            return false;
                        }
                        isEqual = true;
                    }
                }
            }
            return isEqual;
        }

        /// <summary>
        /// compare list of primitive type
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static bool CompareListOfPrimitiveType(object x, object y, string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return false;
            }

            switch (typeName.ToLower())
            {
                case "boolean":
                case "bool": return Enumerable.SequenceEqual((IEnumerable<bool>)x, (IEnumerable<bool>)y);
                case "byte": return Enumerable.SequenceEqual((IEnumerable<byte>)x, (IEnumerable<byte>)y);
                case "sbyte": return Enumerable.SequenceEqual((IEnumerable<sbyte>)x, (IEnumerable<sbyte>)y);
                case "char": return Enumerable.SequenceEqual((IEnumerable<char>)x, (IEnumerable<char>)y);
                case "decimal": return Enumerable.SequenceEqual((IEnumerable<decimal>)x, (IEnumerable<decimal>)y);
                case "single":
                case "float": return Enumerable.SequenceEqual((IEnumerable<float>)x, (IEnumerable<float>)y);
                case "int32":
                case "int": return Enumerable.SequenceEqual((IEnumerable<int>)x, (IEnumerable<int>)y);
                case "uint32":
                case "uint": return Enumerable.SequenceEqual((IEnumerable<uint>)x, (IEnumerable<uint>)y);
                case "intptr":
                case "nint": return Enumerable.SequenceEqual((IEnumerable<nint>)x, (IEnumerable<nint>)y);
                case "uintptr":
                case "nuint": return Enumerable.SequenceEqual((IEnumerable<nuint>)x, (IEnumerable<nuint>)y);
                case "uint64":
                case "ulong": return Enumerable.SequenceEqual((IEnumerable<ulong>)x, (IEnumerable<ulong>)y);
                case "int64":
                case "long": return Enumerable.SequenceEqual((IEnumerable<long>)x, (IEnumerable<long>)y);
                case "int16":
                case "short": return Enumerable.SequenceEqual((IEnumerable<short>)x, (IEnumerable<short>)y);
                case "uint16":
                case "ushort": return Enumerable.SequenceEqual((IEnumerable<ushort>)x, (IEnumerable<ushort>)y);
            }
            return false;
        }
    }
}
