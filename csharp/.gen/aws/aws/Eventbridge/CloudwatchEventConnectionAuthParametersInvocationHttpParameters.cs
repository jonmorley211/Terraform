using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiByValue(fqn: "aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParameters")]
    public class CloudwatchEventConnectionAuthParametersInvocationHttpParameters : aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters
    {
        /// <summary>body block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#body CloudwatchEventConnection#body}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "body", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersBody\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersBody[]? Body
        {
            get;
            set;
        }

        /// <summary>header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#header CloudwatchEventConnection#header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersHeader\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersHeader[]? Header
        {
            get;
            set;
        }

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#query_string CloudwatchEventConnection#query_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventConnectionAuthParametersInvocationHttpParametersQueryString\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Eventbridge.ICloudwatchEventConnectionAuthParametersInvocationHttpParametersQueryString[]? QueryString
        {
            get;
            set;
        }
    }
}
