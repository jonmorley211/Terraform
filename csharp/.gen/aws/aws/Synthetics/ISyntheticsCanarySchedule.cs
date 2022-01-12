using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Synthetics
{
    [JsiiInterface(nativeType: typeof(ISyntheticsCanarySchedule), fullyQualifiedName: "aws.synthetics.SyntheticsCanarySchedule")]
    public interface ISyntheticsCanarySchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/synthetics_canary#expression SyntheticsCanary#expression}.</summary>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
        string Expression
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/synthetics_canary#duration_in_seconds SyntheticsCanary#duration_in_seconds}.</summary>
        [JsiiProperty(name: "durationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DurationInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISyntheticsCanarySchedule), fullyQualifiedName: "aws.synthetics.SyntheticsCanarySchedule")]
        internal sealed class _Proxy : DeputyBase, aws.Synthetics.ISyntheticsCanarySchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/synthetics_canary#expression SyntheticsCanary#expression}.</summary>
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
            public string Expression
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/synthetics_canary#duration_in_seconds SyntheticsCanary#duration_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "durationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DurationInSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
