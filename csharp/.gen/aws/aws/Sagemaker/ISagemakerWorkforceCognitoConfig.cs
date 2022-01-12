using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerWorkforceCognitoConfig), fullyQualifiedName: "aws.sagemaker.SagemakerWorkforceCognitoConfig")]
    public interface ISagemakerWorkforceCognitoConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#client_id SagemakerWorkforce#client_id}.</summary>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#user_pool SagemakerWorkforce#user_pool}.</summary>
        [JsiiProperty(name: "userPool", typeJson: "{\"primitive\":\"string\"}")]
        string UserPool
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerWorkforceCognitoConfig), fullyQualifiedName: "aws.sagemaker.SagemakerWorkforceCognitoConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerWorkforceCognitoConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#client_id SagemakerWorkforce#client_id}.</summary>
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#user_pool SagemakerWorkforce#user_pool}.</summary>
            [JsiiProperty(name: "userPool", typeJson: "{\"primitive\":\"string\"}")]
            public string UserPool
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
