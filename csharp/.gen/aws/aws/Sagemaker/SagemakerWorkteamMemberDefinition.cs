using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiByValue(fqn: "aws.sagemaker.SagemakerWorkteamMemberDefinition")]
    public class SagemakerWorkteamMemberDefinition : aws.Sagemaker.ISagemakerWorkteamMemberDefinition
    {
        /// <summary>cognito_member_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#cognito_member_definition SagemakerWorkteam#cognito_member_definition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cognitoMemberDefinition", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkteamMemberDefinitionCognitoMemberDefinition\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerWorkteamMemberDefinitionCognitoMemberDefinition? CognitoMemberDefinition
        {
            get;
            set;
        }

        /// <summary>oidc_member_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#oidc_member_definition SagemakerWorkteam#oidc_member_definition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oidcMemberDefinition", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkteamMemberDefinitionOidcMemberDefinition\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerWorkteamMemberDefinitionOidcMemberDefinition? OidcMemberDefinition
        {
            get;
            set;
        }
    }
}
