using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshRouteSpec")]
    public class AppmeshRouteSpec : aws.Appmesh.IAppmeshRouteSpec
    {
        /// <summary>grpc_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#grpc_route AppmeshRoute#grpc_route}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grpcRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRoute\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecGrpcRoute? GrpcRoute
        {
            get;
            set;
        }

        /// <summary>http2_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#http2_route AppmeshRoute#http2_route}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "http2Route", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2Route\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecHttp2Route? Http2Route
        {
            get;
            set;
        }

        /// <summary>http_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#http_route AppmeshRoute#http_route}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRoute\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecHttpRoute? HttpRoute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#priority AppmeshRoute#priority}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <summary>tcp_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#tcp_route AppmeshRoute#tcp_route}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tcpRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRoute\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecTcpRoute? TcpRoute
        {
            get;
            set;
        }
    }
}
