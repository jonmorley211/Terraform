using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognito.CognitoUserPoolLambdaConfigCustomEmailSender")]
    public class CognitoUserPoolLambdaConfigCustomEmailSender : aws.Cognito.ICognitoUserPoolLambdaConfigCustomEmailSender
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#lambda_arn CognitoUserPool#lambda_arn}.</summary>
        [JsiiProperty(name: "lambdaArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LambdaArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#lambda_version CognitoUserPool#lambda_version}.</summary>
        [JsiiProperty(name: "lambdaVersion", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LambdaVersion
        {
            get;
            set;
        }
    }
}
