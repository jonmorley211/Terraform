using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerWorkteamMemberDefinitionOidcMemberDefinition")]
    public class SagemakerWorkteamMemberDefinitionOidcMemberDefinition : aws.Sagemaker.ISagemakerWorkteamMemberDefinitionOidcMemberDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#groups SagemakerWorkteam#groups}.</summary>
        [JsiiProperty(name: "groups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Groups
        {
            get;
            set;
        }
    }
}
