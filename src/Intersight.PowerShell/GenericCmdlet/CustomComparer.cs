using Intersight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Intersight.PowerShell
{
    class CustomComparer : IEqualityComparer<Object>
    {
        /// <summary>
        /// Check whether list item of two different list is same or not. 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool Equals(object x, object y)
        {
            //Check whether the compared objects reference the same data.
            if (Object.ReferenceEquals(x, y)) return true;

            //Check whether any of the compared objects is null.
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            var xType = x.GetType();
            var yType = y.GetType();

            //Check wether both the types are same or not. if type of x and y is not same then return false.
            if (xType.FullName != yType.FullName)
            {
                return false;
            }

            if (xType.Name == "String" || xType.IsPrimitive || xType.IsEnum)
            {
                return x.ToString() == y.ToString();
            }

            if (xType.FullName.EndsWith("Relationship"))
            {
                MoMoRef xMoMoRef = null;
                MoMoRef yMoMoRef = null;
                var xMoMorefMethod = xType.GetMethod("GetMoMoRef");
                var yMoMorefMethod = yType.GetMethod("GetMoMoRef");

                if (xMoMorefMethod != null)
                {
                    xMoMoRef = (Intersight.Model.MoMoRef)xMoMorefMethod.Invoke(x, null);
                }

                if (yMoMorefMethod != null)
                {
                    yMoMoRef = (Intersight.Model.MoMoRef)yMoMorefMethod.Invoke(y, null);
                }

                return xMoMoRef != null && yMoMoRef != null && xMoMoRef.Moid == yMoMoRef.Moid;
            }

            if (xType.FullName == "Intersight.Model.MoTag")
            {
                MoTag xMoTag = (Intersight.Model.MoTag)x;
                MoTag yMoTag = (Intersight.Model.MoTag)y;
                return xMoTag != null && yMoTag != null && xMoTag.Key == yMoTag.Key && xMoTag.Value == yMoTag.Value;
            }
            return PSUtils.CompareIntersightObject(x, y);
        }

        /// <summary>
        /// If Equals() returns true for a pair of objects
        /// then GetHashCode() must return the same value for these objects.
        /// </summary>
        /// <param name="listItem"></param>
        /// <returns></returns>
        public int GetHashCode(object listItem)
        {
            var getHashCodeMethod = listItem.GetType().GetMethod("GetHashCode");
            if (getHashCodeMethod != null)
            {
                return (int)getHashCodeMethod.Invoke(listItem, null);
            }
            return 0;
        }
    }
}
