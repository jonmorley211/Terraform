using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiByValue(fqn: "aws.sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettings")]
    public class SagemakerDomainDefaultUserSettingsTensorBoardAppSettings : aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings
    {
        /// <summary>default_resource_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#default_resource_spec SagemakerDomain#default_resource_spec}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec? DefaultResourceSpec
        {
            get;
            set;
        }
    }
}
