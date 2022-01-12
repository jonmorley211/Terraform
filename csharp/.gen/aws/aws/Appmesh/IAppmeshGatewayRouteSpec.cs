using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshGatewayRouteSpec), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpec")]
    public interface IAppmeshGatewayRouteSpec
    {
        /// <summary>grpc_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#grpc_route AppmeshGatewayRoute#grpc_route}
        /// </remarks>
        [JsiiProperty(name: "grpcRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRoute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRoute? GrpcRoute
        {
            get
            {
                return null;
            }
        }

        /// <summary>http2_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#http2_route AppmeshGatewayRoute#http2_route}
        /// </remarks>
        [JsiiProperty(name: "http2Route", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2Route\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshGatewayRouteSpecHttp2Route? Http2Route
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#http_route AppmeshGatewayRoute#http_route}
        /// </remarks>
        [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRoute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshGatewayRouteSpecHttpRoute? HttpRoute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshGatewayRouteSpec), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpec")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshGatewayRouteSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>grpc_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#grpc_route AppmeshGatewayRoute#grpc_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grpcRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRoute\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRoute? GrpcRoute
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRoute?>();
            }

            /// <summary>http2_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#http2_route AppmeshGatewayRoute#http2_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http2Route", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2Route\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshGatewayRouteSpecHttp2Route? Http2Route
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttp2Route?>();
            }

            /// <summary>http_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#http_route AppmeshGatewayRoute#http_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRoute\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshGatewayRouteSpecHttpRoute? HttpRoute
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttpRoute?>();
            }
        }
    }
}
