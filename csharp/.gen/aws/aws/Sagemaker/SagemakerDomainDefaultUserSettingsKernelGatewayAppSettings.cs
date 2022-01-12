using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiByValue(fqn: "aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettings")]
    public class SagemakerDomainDefaultUserSettingsKernelGatewayAppSettings : aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettings
    {
        /// <summary>custom_image block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#custom_image SagemakerDomain#custom_image}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customImage", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsCustomImage\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsCustomImage[]? CustomImage
        {
            get;
            set;
        }

        /// <summary>default_resource_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#default_resource_spec SagemakerDomain#default_resource_spec}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#lifecycle_config_arns SagemakerDomain#lifecycle_config_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? LifecycleConfigArns
        {
            get;
            set;
        }
    }
}
