using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettings), fullyQualifiedName: "aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettings")]
    public interface ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettings
    {
        /// <summary>custom_image block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#custom_image SagemakerDomain#custom_image}
        /// </remarks>
        [JsiiProperty(name: "customImage", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsCustomImage\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsCustomImage[]? CustomImage
        {
            get
            {
                return null;
            }
        }

        /// <summary>default_resource_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#default_resource_spec SagemakerDomain#default_resource_spec}
        /// </remarks>
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#lifecycle_config_arns SagemakerDomain#lifecycle_config_arns}.</summary>
        [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LifecycleConfigArns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettings), fullyQualifiedName: "aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettings")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>custom_image block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#custom_image SagemakerDomain#custom_image}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customImage", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsCustomImage\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsCustomImage[]? CustomImage
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsCustomImage[]?>();
            }

            /// <summary>default_resource_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#default_resource_spec SagemakerDomain#default_resource_spec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#lifecycle_config_arns SagemakerDomain#lifecycle_config_arns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LifecycleConfigArns
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
