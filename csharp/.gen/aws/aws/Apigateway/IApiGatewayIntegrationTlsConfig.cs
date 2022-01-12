using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    [JsiiInterface(nativeType: typeof(IApiGatewayIntegrationTlsConfig), fullyQualifiedName: "aws.apigateway.ApiGatewayIntegrationTlsConfig")]
    public interface IApiGatewayIntegrationTlsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#insecure_skip_verification ApiGatewayIntegration#insecure_skip_verification}.</summary>
        [JsiiProperty(name: "insecureSkipVerification", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InsecureSkipVerification
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayIntegrationTlsConfig), fullyQualifiedName: "aws.apigateway.ApiGatewayIntegrationTlsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Apigateway.IApiGatewayIntegrationTlsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#insecure_skip_verification ApiGatewayIntegration#insecure_skip_verification}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "insecureSkipVerification", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? InsecureSkipVerification
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
