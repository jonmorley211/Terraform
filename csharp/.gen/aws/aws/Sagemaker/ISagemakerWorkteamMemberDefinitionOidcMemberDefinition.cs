using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerWorkteamMemberDefinitionOidcMemberDefinition), fullyQualifiedName: "aws.sagemaker.SagemakerWorkteamMemberDefinitionOidcMemberDefinition")]
    public interface ISagemakerWorkteamMemberDefinitionOidcMemberDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#groups SagemakerWorkteam#groups}.</summary>
        [JsiiProperty(name: "groups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Groups
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerWorkteamMemberDefinitionOidcMemberDefinition), fullyQualifiedName: "aws.sagemaker.SagemakerWorkteamMemberDefinitionOidcMemberDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerWorkteamMemberDefinitionOidcMemberDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workteam#groups SagemakerWorkteam#groups}.</summary>
            [JsiiProperty(name: "groups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Groups
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
