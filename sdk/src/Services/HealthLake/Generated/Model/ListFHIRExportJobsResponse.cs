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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// This is the response object from the ListFHIRExportJobs operation.
    /// </summary>
    public partial class ListFHIRExportJobsResponse : AmazonWebServiceResponse
    {
        private List<ExportJobProperties> _exportJobPropertiesList = new List<ExportJobProperties>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ExportJobPropertiesList. 
        /// <para>
        ///  The properties of listed FHIR export jobs, including the ID, ARN, name, and the status
        /// of the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ExportJobProperties> ExportJobPropertiesList
        {
            get { return this._exportJobPropertiesList; }
            set { this._exportJobPropertiesList = value; }
        }

        // Check to see if ExportJobPropertiesList property is set
        internal bool IsSetExportJobPropertiesList()
        {
            return this._exportJobPropertiesList != null && this._exportJobPropertiesList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A pagination token used to identify the next page of results to return for a ListFHIRExportJobs
        /// query. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}