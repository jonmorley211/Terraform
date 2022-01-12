using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    /// <summary>AWS SageMaker.</summary>
    [JsiiInterface(nativeType: typeof(ISagemakerDeviceConfig), fullyQualifiedName: "aws.sagemaker.SagemakerDeviceConfig")]
    public interface ISagemakerDeviceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_device#device SagemakerDevice#device}
        /// </remarks>
        [JsiiProperty(name: "device", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDeviceDevice\"}")]
        aws.Sagemaker.ISagemakerDeviceDevice Device
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_device#device_fleet_name SagemakerDevice#device_fleet_name}.</summary>
        [JsiiProperty(name: "deviceFleetName", typeJson: "{\"primitive\":\"string\"}")]
        string DeviceFleetName
        {
            get;
        }

        /// <summary>AWS SageMaker.</summary>
        [JsiiTypeProxy(nativeType: typeof(ISagemakerDeviceConfig), fullyQualifiedName: "aws.sagemaker.SagemakerDeviceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerDeviceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>device block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_device#device SagemakerDevice#device}
            /// </remarks>
            [JsiiProperty(name: "device", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDeviceDevice\"}")]
            public aws.Sagemaker.ISagemakerDeviceDevice Device
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerDeviceDevice>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_device#device_fleet_name SagemakerDevice#device_fleet_name}.</summary>
            [JsiiProperty(name: "deviceFleetName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeviceFleetName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
