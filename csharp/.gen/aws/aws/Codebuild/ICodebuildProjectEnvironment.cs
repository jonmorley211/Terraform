using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectEnvironment), fullyQualifiedName: "aws.codebuild.CodebuildProjectEnvironment")]
    public interface ICodebuildProjectEnvironment
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#compute_type CodebuildProject#compute_type}.</summary>
        [JsiiProperty(name: "computeType", typeJson: "{\"primitive\":\"string\"}")]
        string ComputeType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#image CodebuildProject#image}.</summary>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        string Image
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#type CodebuildProject#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#certificate CodebuildProject#certificate}.</summary>
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Certificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>environment_variable block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#environment_variable CodebuildProject#environment_variable}
        /// </remarks>
        [JsiiProperty(name: "environmentVariable", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironmentEnvironmentVariable\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codebuild.ICodebuildProjectEnvironmentEnvironmentVariable[]? EnvironmentVariable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#image_pull_credentials_type CodebuildProject#image_pull_credentials_type}.</summary>
        [JsiiProperty(name: "imagePullCredentialsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImagePullCredentialsType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#privileged_mode CodebuildProject#privileged_mode}.</summary>
        [JsiiProperty(name: "privilegedMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrivilegedMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>registry_credential block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#registry_credential CodebuildProject#registry_credential}
        /// </remarks>
        [JsiiProperty(name: "registryCredential", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironmentRegistryCredential\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codebuild.ICodebuildProjectEnvironmentRegistryCredential? RegistryCredential
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectEnvironment), fullyQualifiedName: "aws.codebuild.CodebuildProjectEnvironment")]
        internal sealed class _Proxy : DeputyBase, aws.Codebuild.ICodebuildProjectEnvironment
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#compute_type CodebuildProject#compute_type}.</summary>
            [JsiiProperty(name: "computeType", typeJson: "{\"primitive\":\"string\"}")]
            public string ComputeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#image CodebuildProject#image}.</summary>
            [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
            public string Image
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#type CodebuildProject#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#certificate CodebuildProject#certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Certificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>environment_variable block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#environment_variable CodebuildProject#environment_variable}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environmentVariable", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironmentEnvironmentVariable\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Codebuild.ICodebuildProjectEnvironmentEnvironmentVariable[]? EnvironmentVariable
            {
                get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectEnvironmentEnvironmentVariable[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#image_pull_credentials_type CodebuildProject#image_pull_credentials_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imagePullCredentialsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImagePullCredentialsType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#privileged_mode CodebuildProject#privileged_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privilegedMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PrivilegedMode
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>registry_credential block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#registry_credential CodebuildProject#registry_credential}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "registryCredential", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironmentRegistryCredential\"}", isOptional: true)]
            public aws.Codebuild.ICodebuildProjectEnvironmentRegistryCredential? RegistryCredential
            {
                get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectEnvironmentRegistryCredential?>();
            }
        }
    }
}
