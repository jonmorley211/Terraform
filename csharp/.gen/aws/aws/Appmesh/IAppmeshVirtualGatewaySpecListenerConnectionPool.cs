using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualGatewaySpecListenerConnectionPool), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPool")]
    public interface IAppmeshVirtualGatewaySpecListenerConnectionPool
    {
        /// <summary>grpc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#grpc AppmeshVirtualGateway#grpc}
        /// </remarks>
        [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolGrpc\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolGrpc? Grpc
        {
            get
            {
                return null;
            }
        }

        /// <summary>http block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#http AppmeshVirtualGateway#http}
        /// </remarks>
        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp? Http
        {
            get
            {
                return null;
            }
        }

        /// <summary>http2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#http2 AppmeshVirtualGateway#http2}
        /// </remarks>
        [JsiiProperty(name: "http2", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp2? Http2
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualGatewaySpecListenerConnectionPool), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPool")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPool
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>grpc block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#grpc AppmeshVirtualGateway#grpc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolGrpc\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolGrpc? Grpc
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolGrpc?>();
            }

            /// <summary>http block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#http AppmeshVirtualGateway#http}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp? Http
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp?>();
            }

            /// <summary>http2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#http2 AppmeshVirtualGateway#http2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http2", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp2\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp2? Http2
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp2?>();
            }
        }
    }
}
