using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerUserProfileUserSettingsTensorBoardAppSettings), fullyQualifiedName: "aws.sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettings")]
    public interface ISagemakerUserProfileUserSettingsTensorBoardAppSettings
    {
        /// <summary>default_resource_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#default_resource_spec SagemakerUserProfile#default_resource_spec}
        /// </remarks>
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettingsDefaultResourceSpec\"}")]
        aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettingsDefaultResourceSpec DefaultResourceSpec
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerUserProfileUserSettingsTensorBoardAppSettings), fullyQualifiedName: "aws.sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettings")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_resource_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#default_resource_spec SagemakerUserProfile#default_resource_spec}
            /// </remarks>
            [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettingsDefaultResourceSpec\"}")]
            public aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettingsDefaultResourceSpec DefaultResourceSpec
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettingsDefaultResourceSpec>()!;
            }
        }
    }
}
