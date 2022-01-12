using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerWorkforceCognitoConfig")]
    public class SagemakerWorkforceCognitoConfig : aws.Sagemaker.ISagemakerWorkforceCognitoConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#client_id SagemakerWorkforce#client_id}.</summary>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#user_pool SagemakerWorkforce#user_pool}.</summary>
        [JsiiProperty(name: "userPool", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string UserPool
        {
            get;
            set;
        }
    }
}
