using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettings")]
    public class SagemakerUserProfileUserSettingsJupyterServerAppSettings : aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettings
    {
        /// <summary>default_resource_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#default_resource_spec SagemakerUserProfile#default_resource_spec}
        /// </remarks>
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettingsDefaultResourceSpec\"}", isOverride: true)]
        public aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettingsDefaultResourceSpec DefaultResourceSpec
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#lifecycle_config_arns SagemakerUserProfile#lifecycle_config_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? LifecycleConfigArns
        {
            get;
            set;
        }
    }
}
