using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codebuild.CodebuildProjectEnvironmentRegistryCredential")]
    public class CodebuildProjectEnvironmentRegistryCredential : aws.Codebuild.ICodebuildProjectEnvironmentRegistryCredential
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#credential CodebuildProject#credential}.</summary>
        [JsiiProperty(name: "credential", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Credential
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#credential_provider CodebuildProject#credential_provider}.</summary>
        [JsiiProperty(name: "credentialProvider", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string CredentialProvider
        {
            get;
            set;
        }
    }
}
