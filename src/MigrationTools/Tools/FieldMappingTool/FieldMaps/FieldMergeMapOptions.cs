﻿using System.Collections.Generic;
using MigrationTools.Tools.Infrastructure;

namespace MigrationTools.Tools
{
    /// <summary>
    /// Ever wanted to merge two or three fields? This mapping will let you do just that.
    /// </summary>
    /// <status>ready</status>
    /// <processingtarget>Work Item Field</processingtarget>
    public class FieldMergeMapOptions : IFieldMapOptions
    {
        public string WorkItemTypeName { get; set; }
        public List<string> sourceFields { get; set; }
        public string targetField { get; set; }
        public string formatExpression { get; set; }

        public string FieldMap
        {
            get
            {
                return "FieldMergeMap";
            }
        }

        public void SetExampleConfigDefaults()
        {
            WorkItemTypeName= "*";
            sourceFields = new List<string>
            {
                "System.Description",
                "System.Status"
            };
            targetField = "System.Description";
            formatExpression = "{0} \n {1}";

        }
    }
}