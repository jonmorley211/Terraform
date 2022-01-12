using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentPropertiesPropertyGroup), fullyQualifiedName: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentPropertiesPropertyGroup")]
    public interface IKinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentPropertiesPropertyGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#property_group_id Kinesisanalyticsv2Application#property_group_id}.</summary>
        [JsiiProperty(name: "propertyGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string PropertyGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#property_map Kinesisanalyticsv2Application#property_map}.</summary>
        [JsiiProperty(name: "propertyMap", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        object PropertyMap
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentPropertiesPropertyGroup), fullyQualifiedName: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentPropertiesPropertyGroup")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentPropertiesPropertyGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#property_group_id Kinesisanalyticsv2Application#property_group_id}.</summary>
            [JsiiProperty(name: "propertyGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string PropertyGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#property_map Kinesisanalyticsv2Application#property_map}.</summary>
            [JsiiProperty(name: "propertyMap", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
            public object PropertyMap
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
