using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudtrail
{
    [JsiiInterface(nativeType: typeof(ICloudtrailAdvancedEventSelector), fullyQualifiedName: "aws.cloudtrail.CloudtrailAdvancedEventSelector")]
    public interface ICloudtrailAdvancedEventSelector
    {
        /// <summary>field_selector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#field_selector Cloudtrail#field_selector}
        /// </remarks>
        [JsiiProperty(name: "fieldSelector", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudtrail.CloudtrailAdvancedEventSelectorFieldSelector\"},\"kind\":\"array\"}}")]
        aws.Cloudtrail.ICloudtrailAdvancedEventSelectorFieldSelector[] FieldSelector
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#name Cloudtrail#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudtrailAdvancedEventSelector), fullyQualifiedName: "aws.cloudtrail.CloudtrailAdvancedEventSelector")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudtrail.ICloudtrailAdvancedEventSelector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_selector block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#field_selector Cloudtrail#field_selector}
            /// </remarks>
            [JsiiProperty(name: "fieldSelector", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudtrail.CloudtrailAdvancedEventSelectorFieldSelector\"},\"kind\":\"array\"}}")]
            public aws.Cloudtrail.ICloudtrailAdvancedEventSelectorFieldSelector[] FieldSelector
            {
                get => GetInstanceProperty<aws.Cloudtrail.ICloudtrailAdvancedEventSelectorFieldSelector[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#name Cloudtrail#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
