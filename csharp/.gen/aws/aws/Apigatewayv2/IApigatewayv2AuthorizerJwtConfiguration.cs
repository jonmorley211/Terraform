using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2AuthorizerJwtConfiguration), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2AuthorizerJwtConfiguration")]
    public interface IApigatewayv2AuthorizerJwtConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#audience Apigatewayv2Authorizer#audience}.</summary>
        [JsiiProperty(name: "audience", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Audience
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#issuer Apigatewayv2Authorizer#issuer}.</summary>
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Issuer
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2AuthorizerJwtConfiguration), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2AuthorizerJwtConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Apigatewayv2.IApigatewayv2AuthorizerJwtConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#audience Apigatewayv2Authorizer#audience}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "audience", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Audience
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#issuer Apigatewayv2Authorizer#issuer}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Issuer
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
