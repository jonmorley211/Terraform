using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apprunner
{
    [JsiiInterface(nativeType: typeof(IApprunnerServiceSourceConfiguration), fullyQualifiedName: "aws.apprunner.ApprunnerServiceSourceConfiguration")]
    public interface IApprunnerServiceSourceConfiguration
    {
        /// <summary>authentication_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#authentication_configuration ApprunnerService#authentication_configuration}
        /// </remarks>
        [JsiiProperty(name: "authenticationConfiguration", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationAuthenticationConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Apprunner.IApprunnerServiceSourceConfigurationAuthenticationConfiguration? AuthenticationConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#auto_deployments_enabled ApprunnerService#auto_deployments_enabled}.</summary>
        [JsiiProperty(name: "autoDeploymentsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoDeploymentsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>code_repository block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#code_repository ApprunnerService#code_repository}
        /// </remarks>
        [JsiiProperty(name: "codeRepository", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepository\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepository? CodeRepository
        {
            get
            {
                return null;
            }
        }

        /// <summary>image_repository block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#image_repository ApprunnerService#image_repository}
        /// </remarks>
        [JsiiProperty(name: "imageRepository", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationImageRepository\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Apprunner.IApprunnerServiceSourceConfigurationImageRepository? ImageRepository
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApprunnerServiceSourceConfiguration), fullyQualifiedName: "aws.apprunner.ApprunnerServiceSourceConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Apprunner.IApprunnerServiceSourceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>authentication_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#authentication_configuration ApprunnerService#authentication_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authenticationConfiguration", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationAuthenticationConfiguration\"}", isOptional: true)]
            public aws.Apprunner.IApprunnerServiceSourceConfigurationAuthenticationConfiguration? AuthenticationConfiguration
            {
                get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceSourceConfigurationAuthenticationConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#auto_deployments_enabled ApprunnerService#auto_deployments_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoDeploymentsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AutoDeploymentsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>code_repository block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#code_repository ApprunnerService#code_repository}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeRepository", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepository\"}", isOptional: true)]
            public aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepository? CodeRepository
            {
                get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepository?>();
            }

            /// <summary>image_repository block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#image_repository ApprunnerService#image_repository}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "imageRepository", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationImageRepository\"}", isOptional: true)]
            public aws.Apprunner.IApprunnerServiceSourceConfigurationImageRepository? ImageRepository
            {
                get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceSourceConfigurationImageRepository?>();
            }
        }
    }
}
