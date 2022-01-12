using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdafunction.LambdaCodeSigningConfigAllowedPublishers")]
    public class LambdaCodeSigningConfigAllowedPublishers : aws.Lambdafunction.ILambdaCodeSigningConfigAllowedPublishers
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_code_signing_config#signing_profile_version_arns LambdaCodeSigningConfig#signing_profile_version_arns}.</summary>
        [JsiiProperty(name: "signingProfileVersionArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] SigningProfileVersionArns
        {
            get;
            set;
        }
    }
}
