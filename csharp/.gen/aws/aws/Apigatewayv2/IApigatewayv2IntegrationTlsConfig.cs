using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2IntegrationTlsConfig), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2IntegrationTlsConfig")]
    public interface IApigatewayv2IntegrationTlsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_integration#server_name_to_verify Apigatewayv2Integration#server_name_to_verify}.</summary>
        [JsiiProperty(name: "serverNameToVerify", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServerNameToVerify
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2IntegrationTlsConfig), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2IntegrationTlsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Apigatewayv2.IApigatewayv2IntegrationTlsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_integration#server_name_to_verify Apigatewayv2Integration#server_name_to_verify}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serverNameToVerify", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServerNameToVerify
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
