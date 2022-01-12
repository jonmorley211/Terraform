using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Synthetics
{
    [JsiiByValue(fqn: "aws.synthetics.SyntheticsCanaryRunConfig")]
    public class SyntheticsCanaryRunConfig : aws.Synthetics.ISyntheticsCanaryRunConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/synthetics_canary#active_tracing SyntheticsCanary#active_tracing}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "activeTracing", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? ActiveTracing
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/synthetics_canary#memory_in_mb SyntheticsCanary#memory_in_mb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryInMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MemoryInMb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/synthetics_canary#timeout_in_seconds SyntheticsCanary#timeout_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? TimeoutInSeconds
        {
            get;
            set;
        }
    }
}
