using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudwatch
{
    [JsiiInterface(nativeType: typeof(ICloudwatchMetricStreamExcludeFilter), fullyQualifiedName: "aws.cloudwatch.CloudwatchMetricStreamExcludeFilter")]
    public interface ICloudwatchMetricStreamExcludeFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_stream#namespace CloudwatchMetricStream#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchMetricStreamExcludeFilter), fullyQualifiedName: "aws.cloudwatch.CloudwatchMetricStreamExcludeFilter")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudwatch.ICloudwatchMetricStreamExcludeFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_stream#namespace CloudwatchMetricStream#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
