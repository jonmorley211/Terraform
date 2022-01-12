using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerWorkteamMemberDefinitionCognitoMemberDefinition")]
    public class SagemakerWorkteamMemberDefinitionCognitoMemberDefinition : aws.Sagemaker.ISagemakerWorkteamMemberDefinitionCognitoMemberDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#client_id SagemakerWorkteam#client_id}.</summary>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#user_group SagemakerWorkteam#user_group}.</summary>
        [JsiiProperty(name: "userGroup", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string UserGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#user_pool SagemakerWorkteam#user_pool}.</summary>
        [JsiiProperty(name: "userPool", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string UserPool
        {
            get;
            set;
        }
    }
}
