using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshGatewayRouteSpec")]
    public class AppmeshGatewayRouteSpec : aws.Appmesh.IAppmeshGatewayRouteSpec
    {
        /// <summary>grpc_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#grpc_route AppmeshGatewayRoute#grpc_route}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grpcRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRoute\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRoute? GrpcRoute
        {
            get;
            set;
        }

        /// <summary>http2_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#http2_route AppmeshGatewayRoute#http2_route}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "http2Route", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2Route\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshGatewayRouteSpecHttp2Route? Http2Route
        {
            get;
            set;
        }

        /// <summary>http_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#http_route AppmeshGatewayRoute#http_route}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRoute\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshGatewayRouteSpecHttpRoute? HttpRoute
        {
            get;
            set;
        }
    }
}
