using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettings")]
    public class SagemakerUserProfileUserSettingsTensorBoardAppSettings : aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettings
    {
        /// <summary>default_resource_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#default_resource_spec SagemakerUserProfile#default_resource_spec}
        /// </remarks>
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettingsDefaultResourceSpec\"}", isOverride: true)]
        public aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettingsDefaultResourceSpec DefaultResourceSpec
        {
            get;
            set;
        }
    }
}
