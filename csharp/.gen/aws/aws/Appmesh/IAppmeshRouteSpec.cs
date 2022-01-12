using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpec), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpec")]
    public interface IAppmeshRouteSpec
    {
        /// <summary>grpc_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#grpc_route AppmeshRoute#grpc_route}
        /// </remarks>
        [JsiiProperty(name: "grpcRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRoute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecGrpcRoute? GrpcRoute
        {
            get
            {
                return null;
            }
        }

        /// <summary>http2_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#http2_route AppmeshRoute#http2_route}
        /// </remarks>
        [JsiiProperty(name: "http2Route", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2Route\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecHttp2Route? Http2Route
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#http_route AppmeshRoute#http_route}
        /// </remarks>
        [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRoute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecHttpRoute? HttpRoute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#priority AppmeshRoute#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>tcp_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#tcp_route AppmeshRoute#tcp_route}
        /// </remarks>
        [JsiiProperty(name: "tcpRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRoute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecTcpRoute? TcpRoute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpec), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpec")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshRouteSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>grpc_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#grpc_route AppmeshRoute#grpc_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grpcRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRoute\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecGrpcRoute? GrpcRoute
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecGrpcRoute?>();
            }

            /// <summary>http2_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#http2_route AppmeshRoute#http2_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http2Route", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2Route\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecHttp2Route? Http2Route
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttp2Route?>();
            }

            /// <summary>http_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#http_route AppmeshRoute#http_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRoute\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecHttpRoute? HttpRoute
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRoute?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#priority AppmeshRoute#priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>tcp_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#tcp_route AppmeshRoute#tcp_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcpRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRoute\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecTcpRoute? TcpRoute
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecTcpRoute?>();
            }
        }
    }
}
