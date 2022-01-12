using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings), fullyQualifiedName: "aws.sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettings")]
    public interface ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings
    {
        /// <summary>default_resource_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#default_resource_spec SagemakerDomain#default_resource_spec}
        /// </remarks>
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec? DefaultResourceSpec
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings), fullyQualifiedName: "aws.sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettings")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_resource_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#default_resource_spec SagemakerDomain#default_resource_spec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec? DefaultResourceSpec
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec?>();
            }
        }
    }
}
