using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerWorkteamMemberDefinition), fullyQualifiedName: "aws.sagemaker.SagemakerWorkteamMemberDefinition")]
    public interface ISagemakerWorkteamMemberDefinition
    {
        /// <summary>cognito_member_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#cognito_member_definition SagemakerWorkteam#cognito_member_definition}
        /// </remarks>
        [JsiiProperty(name: "cognitoMemberDefinition", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkteamMemberDefinitionCognitoMemberDefinition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerWorkteamMemberDefinitionCognitoMemberDefinition? CognitoMemberDefinition
        {
            get
            {
                return null;
            }
        }

        /// <summary>oidc_member_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#oidc_member_definition SagemakerWorkteam#oidc_member_definition}
        /// </remarks>
        [JsiiProperty(name: "oidcMemberDefinition", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkteamMemberDefinitionOidcMemberDefinition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerWorkteamMemberDefinitionOidcMemberDefinition? OidcMemberDefinition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerWorkteamMemberDefinition), fullyQualifiedName: "aws.sagemaker.SagemakerWorkteamMemberDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerWorkteamMemberDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cognito_member_definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#cognito_member_definition SagemakerWorkteam#cognito_member_definition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cognitoMemberDefinition", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkteamMemberDefinitionCognitoMemberDefinition\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerWorkteamMemberDefinitionCognitoMemberDefinition? CognitoMemberDefinition
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerWorkteamMemberDefinitionCognitoMemberDefinition?>();
            }

            /// <summary>oidc_member_definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#oidc_member_definition SagemakerWorkteam#oidc_member_definition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oidcMemberDefinition", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkteamMemberDefinitionOidcMemberDefinition\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerWorkteamMemberDefinitionOidcMemberDefinition? OidcMemberDefinition
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerWorkteamMemberDefinitionOidcMemberDefinition?>();
            }
        }
    }
}
