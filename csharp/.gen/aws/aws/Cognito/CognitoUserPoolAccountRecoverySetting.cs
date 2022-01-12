using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognito.CognitoUserPoolAccountRecoverySetting")]
    public class CognitoUserPoolAccountRecoverySetting : aws.Cognito.ICognitoUserPoolAccountRecoverySetting
    {
        /// <summary>recovery_mechanism block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#recovery_mechanism CognitoUserPool#recovery_mechanism}
        /// </remarks>
        [JsiiProperty(name: "recoveryMechanism", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognito.CognitoUserPoolAccountRecoverySettingRecoveryMechanism\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Cognito.ICognitoUserPoolAccountRecoverySettingRecoveryMechanism[] RecoveryMechanism
        {
            get;
            set;
        }
    }
}
