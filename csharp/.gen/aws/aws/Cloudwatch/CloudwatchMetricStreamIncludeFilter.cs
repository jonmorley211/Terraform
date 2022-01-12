using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudwatch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatch.CloudwatchMetricStreamIncludeFilter")]
    public class CloudwatchMetricStreamIncludeFilter : aws.Cloudwatch.ICloudwatchMetricStreamIncludeFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_stream#namespace CloudwatchMetricStream#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Namespace
        {
            get;
            set;
        }
    }
}
