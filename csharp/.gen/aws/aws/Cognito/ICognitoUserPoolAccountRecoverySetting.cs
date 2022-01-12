using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolAccountRecoverySetting), fullyQualifiedName: "aws.cognito.CognitoUserPoolAccountRecoverySetting")]
    public interface ICognitoUserPoolAccountRecoverySetting
    {
        /// <summary>recovery_mechanism block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#recovery_mechanism CognitoUserPool#recovery_mechanism}
        /// </remarks>
        [JsiiProperty(name: "recoveryMechanism", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognito.CognitoUserPoolAccountRecoverySettingRecoveryMechanism\"},\"kind\":\"array\"}}")]
        aws.Cognito.ICognitoUserPoolAccountRecoverySettingRecoveryMechanism[] RecoveryMechanism
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolAccountRecoverySetting), fullyQualifiedName: "aws.cognito.CognitoUserPoolAccountRecoverySetting")]
        internal sealed class _Proxy : DeputyBase, aws.Cognito.ICognitoUserPoolAccountRecoverySetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>recovery_mechanism block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#recovery_mechanism CognitoUserPool#recovery_mechanism}
            /// </remarks>
            [JsiiProperty(name: "recoveryMechanism", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognito.CognitoUserPoolAccountRecoverySettingRecoveryMechanism\"},\"kind\":\"array\"}}")]
            public aws.Cognito.ICognitoUserPoolAccountRecoverySettingRecoveryMechanism[] RecoveryMechanism
            {
                get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolAccountRecoverySettingRecoveryMechanism[]>()!;
            }
        }
    }
}
