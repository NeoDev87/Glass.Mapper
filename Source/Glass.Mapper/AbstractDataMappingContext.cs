/*
   Copyright 2012 Michael Edwards
 
   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 
*/ 
//-CRE-

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glass.Mapper
{
    /// <summary>
    /// Represents the context when a CMS value is mapper to/from a .Net property value
    /// </summary>
    public class AbstractDataMappingContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractDataMappingContext"/> class.
        /// </summary>
        /// <param name="obj">The obj.</param>
        public AbstractDataMappingContext(object obj)
        {
            this.Object = obj;
        }

        /// <summary>
        /// Value stored by the CMS
        /// </summary>
        /// <value>The CMS value.</value>
        public string CmsValue { get; set; }

        /// <summary>
        /// Value stored by the Property
        /// </summary>
        /// <value>The property value.</value>
        public object PropertyValue { get; set; }

        /// <summary>
        /// The object containing the property being mapped
        /// </summary>
        /// <value>The object.</value>
        public object Object { get; private set; }
    }
}




