using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Synthetics
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.synthetics.SyntheticsCanarySchedule")]
    public class SyntheticsCanarySchedule : aws.Synthetics.ISyntheticsCanarySchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/synthetics_canary#expression SyntheticsCanary#expression}.</summary>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Expression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/synthetics_canary#duration_in_seconds SyntheticsCanary#duration_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "durationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? DurationInSeconds
        {
            get;
            set;
        }
    }
}
