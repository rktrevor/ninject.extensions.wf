//-------------------------------------------------------------------------------
// <copyright file="ObjectExtensions.cs" company="bbv Software Services AG">
//   Copyright (c) 2010 bbv Software Services AG
//   Author: Daniel Marbach
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Ninject.Extensions.Wf.Extensions
{
    using System.Collections.Generic;

    /// <summary>
    /// Contains extension methods for System.Object.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Turns the specified object into a dictionary by using the property key as dictionary key.
        /// </summary>
        /// <param name="value">The object to be serialized.</param>
        /// <returns>A dictionary representing the object.</returns>
        public static IDictionary<string, object> ToDict(this object value)
        {
            var dictionary = new Dictionary<string, object>();

            var publicProperties =
                value.GetType().GetProperties();
            
            foreach (var publicProperty in publicProperties)
            {
                dictionary.Add(publicProperty.Name, publicProperty.GetValue(value, null));    
            }

            return dictionary;
        }
    }
}