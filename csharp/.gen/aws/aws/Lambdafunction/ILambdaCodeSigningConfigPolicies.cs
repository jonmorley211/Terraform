using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiInterface(nativeType: typeof(ILambdaCodeSigningConfigPolicies), fullyQualifiedName: "aws.lambdafunction.LambdaCodeSigningConfigPolicies")]
    public interface ILambdaCodeSigningConfigPolicies
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_code_signing_config#untrusted_artifact_on_deployment LambdaCodeSigningConfig#untrusted_artifact_on_deployment}.</summary>
        [JsiiProperty(name: "untrustedArtifactOnDeployment", typeJson: "{\"primitive\":\"string\"}")]
        string UntrustedArtifactOnDeployment
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaCodeSigningConfigPolicies), fullyQualifiedName: "aws.lambdafunction.LambdaCodeSigningConfigPolicies")]
        internal sealed class _Proxy : DeputyBase, aws.Lambdafunction.ILambdaCodeSigningConfigPolicies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_code_signing_config#untrusted_artifact_on_deployment LambdaCodeSigningConfig#untrusted_artifact_on_deployment}.</summary>
            [JsiiProperty(name: "untrustedArtifactOnDeployment", typeJson: "{\"primitive\":\"string\"}")]
            public string UntrustedArtifactOnDeployment
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
