using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudtrail
{
    [JsiiByValue(fqn: "aws.cloudtrail.CloudtrailEventSelector")]
    public class CloudtrailEventSelector : aws.Cloudtrail.ICloudtrailEventSelector
    {
        /// <summary>data_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#data_resource Cloudtrail#data_resource}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataResource", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudtrail.CloudtrailEventSelectorDataResource\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Cloudtrail.ICloudtrailEventSelectorDataResource[]? DataResource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#exclude_management_event_sources Cloudtrail#exclude_management_event_sources}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludeManagementEventSources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? ExcludeManagementEventSources
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#include_management_events Cloudtrail#include_management_events}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeManagementEvents", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? IncludeManagementEvents
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#read_write_type Cloudtrail#read_write_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readWriteType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ReadWriteType
        {
            get;
            set;
        }
    }
}
