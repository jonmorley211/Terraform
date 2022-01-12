using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdafunction.LambdaCodeSigningConfigPolicies")]
    public class LambdaCodeSigningConfigPolicies : aws.Lambdafunction.ILambdaCodeSigningConfigPolicies
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_code_signing_config#untrusted_artifact_on_deployment LambdaCodeSigningConfig#untrusted_artifact_on_deployment}.</summary>
        [JsiiProperty(name: "untrustedArtifactOnDeployment", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string UntrustedArtifactOnDeployment
        {
            get;
            set;
        }
    }
}
