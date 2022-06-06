/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// A <code>Field</code> of the channel that you want to search.
    /// </summary>
    public partial class SearchField
    {
        private SearchFieldKey _key;
        private SearchFieldOperator _operator;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// An <code>enum</code> value that indicates the key to search the channel on. <code>MEMBERS</code>
        /// allows you to search channels based on memberships. You can use it with the <code>EQUALS</code>
        /// operator to get channels whose memberships are equal to the specified values, and
        /// with the <code>INCLUDES</code> operator to get channels whose memberships include
        /// the specified values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SearchFieldKey Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The operator used to compare field values, currently <code>EQUALS</code> or <code>INCLUDES</code>.
        /// Use the <code>EQUALS</code> operator to find channels whose memberships equal the
        /// specified values. Use the <code>INCLUDES</code> operator to find channels whose memberships
        /// include the specified values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SearchFieldOperator Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values that you want to search for, a list of strings. The values must be <code>AppInstanceUserArns</code>
        /// specified as a list of strings.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation isn't supported for <code>AppInstanceUsers</code> with large number
        /// of memberships.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}