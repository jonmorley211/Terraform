using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersHeader), fullyQualifiedName: "aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersHeader")]
    public interface ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#is_value_secret CloudwatchEventConnection#is_value_secret}.</summary>
        [JsiiProperty(name: "isValueSecret", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsValueSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#key CloudwatchEventConnection#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Key
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#value CloudwatchEventConnection#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersHeader), fullyQualifiedName: "aws.eventbridge.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersHeader")]
        internal sealed class _Proxy : DeputyBase, aws.Eventbridge.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParametersHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#is_value_secret CloudwatchEventConnection#is_value_secret}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isValueSecret", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IsValueSecret
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#key CloudwatchEventConnection#key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Key
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_connection#value CloudwatchEventConnection#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
