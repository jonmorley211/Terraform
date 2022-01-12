using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiInterface(nativeType: typeof(ILambdaCodeSigningConfigAllowedPublishers), fullyQualifiedName: "aws.lambdafunction.LambdaCodeSigningConfigAllowedPublishers")]
    public interface ILambdaCodeSigningConfigAllowedPublishers
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_code_signing_config#signing_profile_version_arns LambdaCodeSigningConfig#signing_profile_version_arns}.</summary>
        [JsiiProperty(name: "signingProfileVersionArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SigningProfileVersionArns
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaCodeSigningConfigAllowedPublishers), fullyQualifiedName: "aws.lambdafunction.LambdaCodeSigningConfigAllowedPublishers")]
        internal sealed class _Proxy : DeputyBase, aws.Lambdafunction.ILambdaCodeSigningConfigAllowedPublishers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_code_signing_config#signing_profile_version_arns LambdaCodeSigningConfig#signing_profile_version_arns}.</summary>
            [JsiiProperty(name: "signingProfileVersionArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SigningProfileVersionArns
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
