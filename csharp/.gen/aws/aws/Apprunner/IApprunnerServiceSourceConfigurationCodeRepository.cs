using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apprunner
{
    [JsiiInterface(nativeType: typeof(IApprunnerServiceSourceConfigurationCodeRepository), fullyQualifiedName: "aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepository")]
    public interface IApprunnerServiceSourceConfigurationCodeRepository
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#repository_url ApprunnerService#repository_url}.</summary>
        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
        string RepositoryUrl
        {
            get;
        }

        /// <summary>source_code_version block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#source_code_version ApprunnerService#source_code_version}
        /// </remarks>
        [JsiiProperty(name: "sourceCodeVersion", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion\"}")]
        aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion SourceCodeVersion
        {
            get;
        }

        /// <summary>code_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#code_configuration ApprunnerService#code_configuration}
        /// </remarks>
        [JsiiProperty(name: "codeConfiguration", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration? CodeConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApprunnerServiceSourceConfigurationCodeRepository), fullyQualifiedName: "aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepository")]
        internal sealed class _Proxy : DeputyBase, aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepository
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#repository_url ApprunnerService#repository_url}.</summary>
            [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string RepositoryUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>source_code_version block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#source_code_version ApprunnerService#source_code_version}
            /// </remarks>
            [JsiiProperty(name: "sourceCodeVersion", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion\"}")]
            public aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion SourceCodeVersion
            {
                get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion>()!;
            }

            /// <summary>code_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#code_configuration ApprunnerService#code_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeConfiguration", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration\"}", isOptional: true)]
            public aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration? CodeConfiguration
            {
                get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration?>();
            }
        }
    }
}
