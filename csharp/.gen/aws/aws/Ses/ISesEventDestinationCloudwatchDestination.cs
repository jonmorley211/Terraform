using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    [JsiiInterface(nativeType: typeof(ISesEventDestinationCloudwatchDestination), fullyQualifiedName: "aws.ses.SesEventDestinationCloudwatchDestination")]
    public interface ISesEventDestinationCloudwatchDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#default_value SesEventDestination#default_value}.</summary>
        [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultValue
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#dimension_name SesEventDestination#dimension_name}.</summary>
        [JsiiProperty(name: "dimensionName", typeJson: "{\"primitive\":\"string\"}")]
        string DimensionName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#value_source SesEventDestination#value_source}.</summary>
        [JsiiProperty(name: "valueSource", typeJson: "{\"primitive\":\"string\"}")]
        string ValueSource
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISesEventDestinationCloudwatchDestination), fullyQualifiedName: "aws.ses.SesEventDestinationCloudwatchDestination")]
        internal sealed class _Proxy : DeputyBase, aws.Ses.ISesEventDestinationCloudwatchDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#default_value SesEventDestination#default_value}.</summary>
            [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultValue
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#dimension_name SesEventDestination#dimension_name}.</summary>
            [JsiiProperty(name: "dimensionName", typeJson: "{\"primitive\":\"string\"}")]
            public string DimensionName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#value_source SesEventDestination#value_source}.</summary>
            [JsiiProperty(name: "valueSource", typeJson: "{\"primitive\":\"string\"}")]
            public string ValueSource
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
