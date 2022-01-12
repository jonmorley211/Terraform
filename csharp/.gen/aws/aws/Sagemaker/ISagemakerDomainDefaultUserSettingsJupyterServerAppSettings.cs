using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDefaultUserSettingsJupyterServerAppSettings), fullyQualifiedName: "aws.sagemaker.SagemakerDomainDefaultUserSettingsJupyterServerAppSettings")]
    public interface ISagemakerDomainDefaultUserSettingsJupyterServerAppSettings
    {
        /// <summary>default_resource_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#default_resource_spec SagemakerDomain#default_resource_spec}
        /// </remarks>
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsJupyterServerAppSettingsDefaultResourceSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerDomainDefaultUserSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec
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

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDefaultUserSettingsJupyterServerAppSettings), fullyQualifiedName: "aws.sagemaker.SagemakerDomainDefaultUserSettingsJupyterServerAppSettings")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerDomainDefaultUserSettingsJupyterServerAppSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_resource_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#default_resource_spec SagemakerDomain#default_resource_spec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsJupyterServerAppSettingsDefaultResourceSpec\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerDomainDefaultUserSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettingsJupyterServerAppSettingsDefaultResourceSpec?>();
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
