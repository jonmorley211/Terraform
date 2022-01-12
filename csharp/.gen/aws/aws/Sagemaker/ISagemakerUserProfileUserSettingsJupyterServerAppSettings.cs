using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerUserProfileUserSettingsJupyterServerAppSettings), fullyQualifiedName: "aws.sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettings")]
    public interface ISagemakerUserProfileUserSettingsJupyterServerAppSettings
    {
        /// <summary>default_resource_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#default_resource_spec SagemakerUserProfile#default_resource_spec}
        /// </remarks>
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettingsDefaultResourceSpec\"}")]
        aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettingsDefaultResourceSpec DefaultResourceSpec
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#lifecycle_config_arns SagemakerUserProfile#lifecycle_config_arns}.</summary>
        [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LifecycleConfigArns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerUserProfileUserSettingsJupyterServerAppSettings), fullyQualifiedName: "aws.sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettings")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_resource_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#default_resource_spec SagemakerUserProfile#default_resource_spec}
            /// </remarks>
            [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettingsDefaultResourceSpec\"}")]
            public aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettingsDefaultResourceSpec DefaultResourceSpec
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettingsDefaultResourceSpec>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#lifecycle_config_arns SagemakerUserProfile#lifecycle_config_arns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LifecycleConfigArns
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
