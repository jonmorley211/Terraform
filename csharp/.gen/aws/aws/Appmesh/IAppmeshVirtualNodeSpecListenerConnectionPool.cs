using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListenerConnectionPool), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPool")]
    public interface IAppmeshVirtualNodeSpecListenerConnectionPool
    {
        /// <summary>grpc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#grpc AppmeshVirtualNode#grpc}
        /// </remarks>
        [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolGrpc\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolGrpc? Grpc
        {
            get
            {
                return null;
            }
        }

        /// <summary>http block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#http AppmeshVirtualNode#http}
        /// </remarks>
        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp? Http
        {
            get
            {
                return null;
            }
        }

        /// <summary>http2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#http2 AppmeshVirtualNode#http2}
        /// </remarks>
        [JsiiProperty(name: "http2", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttp2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp2? Http2
        {
            get
            {
                return null;
            }
        }

        /// <summary>tcp block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#tcp AppmeshVirtualNode#tcp}
        /// </remarks>
        [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolTcp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolTcp? Tcp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListenerConnectionPool), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPool")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPool
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>grpc block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#grpc AppmeshVirtualNode#grpc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolGrpc\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolGrpc? Grpc
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolGrpc?>();
            }

            /// <summary>http block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#http AppmeshVirtualNode#http}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttp\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp? Http
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp?>();
            }

            /// <summary>http2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#http2 AppmeshVirtualNode#http2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http2", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttp2\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp2? Http2
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp2?>();
            }

            /// <summary>tcp block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#tcp AppmeshVirtualNode#tcp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolTcp\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolTcp? Tcp
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolTcp?>();
            }
        }
    }
}
