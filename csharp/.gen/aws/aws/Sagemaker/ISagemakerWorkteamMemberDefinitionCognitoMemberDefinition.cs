using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerWorkteamMemberDefinitionCognitoMemberDefinition), fullyQualifiedName: "aws.sagemaker.SagemakerWorkteamMemberDefinitionCognitoMemberDefinition")]
    public interface ISagemakerWorkteamMemberDefinitionCognitoMemberDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#client_id SagemakerWorkteam#client_id}.</summary>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#user_group SagemakerWorkteam#user_group}.</summary>
        [JsiiProperty(name: "userGroup", typeJson: "{\"primitive\":\"string\"}")]
        string UserGroup
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#user_pool SagemakerWorkteam#user_pool}.</summary>
        [JsiiProperty(name: "userPool", typeJson: "{\"primitive\":\"string\"}")]
        string UserPool
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerWorkteamMemberDefinitionCognitoMemberDefinition), fullyQualifiedName: "aws.sagemaker.SagemakerWorkteamMemberDefinitionCognitoMemberDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerWorkteamMemberDefinitionCognitoMemberDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#client_id SagemakerWorkteam#client_id}.</summary>
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#user_group SagemakerWorkteam#user_group}.</summary>
            [JsiiProperty(name: "userGroup", typeJson: "{\"primitive\":\"string\"}")]
            public string UserGroup
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#user_pool SagemakerWorkteam#user_pool}.</summary>
            [JsiiProperty(name: "userPool", typeJson: "{\"primitive\":\"string\"}")]
            public string UserPool
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
