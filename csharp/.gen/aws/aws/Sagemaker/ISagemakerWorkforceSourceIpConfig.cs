using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerWorkforceSourceIpConfig), fullyQualifiedName: "aws.sagemaker.SagemakerWorkforceSourceIpConfig")]
    public interface ISagemakerWorkforceSourceIpConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#cidrs SagemakerWorkforce#cidrs}.</summary>
        [JsiiProperty(name: "cidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Cidrs
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerWorkforceSourceIpConfig), fullyQualifiedName: "aws.sagemaker.SagemakerWorkforceSourceIpConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerWorkforceSourceIpConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#cidrs SagemakerWorkforce#cidrs}.</summary>
            [JsiiProperty(name: "cidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Cidrs
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
