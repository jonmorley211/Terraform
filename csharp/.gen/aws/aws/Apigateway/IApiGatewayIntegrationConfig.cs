using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    /// <summary>API Gateway.</summary>
    [JsiiInterface(nativeType: typeof(IApiGatewayIntegrationConfig), fullyQualifiedName: "aws.apigateway.ApiGatewayIntegrationConfig")]
    public interface IApiGatewayIntegrationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#http_method ApiGatewayIntegration#http_method}.</summary>
        [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}")]
        string HttpMethod
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#resource_id ApiGatewayIntegration#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#rest_api_id ApiGatewayIntegration#rest_api_id}.</summary>
        [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
        string RestApiId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#type ApiGatewayIntegration#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#cache_key_parameters ApiGatewayIntegration#cache_key_parameters}.</summary>
        [JsiiProperty(name: "cacheKeyParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CacheKeyParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#cache_namespace ApiGatewayIntegration#cache_namespace}.</summary>
        [JsiiProperty(name: "cacheNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CacheNamespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#connection_id ApiGatewayIntegration#connection_id}.</summary>
        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#connection_type ApiGatewayIntegration#connection_type}.</summary>
        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectionType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#content_handling ApiGatewayIntegration#content_handling}.</summary>
        [JsiiProperty(name: "contentHandling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentHandling
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#credentials ApiGatewayIntegration#credentials}.</summary>
        [JsiiProperty(name: "credentials", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Credentials
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#integration_http_method ApiGatewayIntegration#integration_http_method}.</summary>
        [JsiiProperty(name: "integrationHttpMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IntegrationHttpMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#passthrough_behavior ApiGatewayIntegration#passthrough_behavior}.</summary>
        [JsiiProperty(name: "passthroughBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PassthroughBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#request_parameters ApiGatewayIntegration#request_parameters}.</summary>
        [JsiiProperty(name: "requestParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#request_templates ApiGatewayIntegration#request_templates}.</summary>
        [JsiiProperty(name: "requestTemplates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestTemplates
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#timeout_milliseconds ApiGatewayIntegration#timeout_milliseconds}.</summary>
        [JsiiProperty(name: "timeoutMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeoutMilliseconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>tls_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#tls_config ApiGatewayIntegration#tls_config}
        /// </remarks>
        [JsiiProperty(name: "tlsConfig", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayIntegrationTlsConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Apigateway.IApiGatewayIntegrationTlsConfig? TlsConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#uri ApiGatewayIntegration#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uri
        {
            get
            {
                return null;
            }
        }

        /// <summary>API Gateway.</summary>
        [JsiiTypeProxy(nativeType: typeof(IApiGatewayIntegrationConfig), fullyQualifiedName: "aws.apigateway.ApiGatewayIntegrationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Apigateway.IApiGatewayIntegrationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#http_method ApiGatewayIntegration#http_method}.</summary>
            [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}")]
            public string HttpMethod
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#resource_id ApiGatewayIntegration#resource_id}.</summary>
            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#rest_api_id ApiGatewayIntegration#rest_api_id}.</summary>
            [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
            public string RestApiId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#type ApiGatewayIntegration#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#cache_key_parameters ApiGatewayIntegration#cache_key_parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheKeyParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CacheKeyParameters
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#cache_namespace ApiGatewayIntegration#cache_namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CacheNamespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#connection_id ApiGatewayIntegration#connection_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#connection_type ApiGatewayIntegration#connection_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectionType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#content_handling ApiGatewayIntegration#content_handling}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contentHandling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContentHandling
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#credentials ApiGatewayIntegration#credentials}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "credentials", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Credentials
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#integration_http_method ApiGatewayIntegration#integration_http_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "integrationHttpMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IntegrationHttpMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#passthrough_behavior ApiGatewayIntegration#passthrough_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passthroughBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PassthroughBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#request_parameters ApiGatewayIntegration#request_parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requestParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? RequestParameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#request_templates ApiGatewayIntegration#request_templates}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requestTemplates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? RequestTemplates
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#timeout_milliseconds ApiGatewayIntegration#timeout_milliseconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimeoutMilliseconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>tls_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#tls_config ApiGatewayIntegration#tls_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tlsConfig", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayIntegrationTlsConfig\"}", isOptional: true)]
            public aws.Apigateway.IApiGatewayIntegrationTlsConfig? TlsConfig
            {
                get => GetInstanceProperty<aws.Apigateway.IApiGatewayIntegrationTlsConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#uri ApiGatewayIntegration#uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
