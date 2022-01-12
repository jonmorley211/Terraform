using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListenerTimeout), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTimeout")]
    public interface IAppmeshVirtualNodeSpecListenerTimeout
    {
        /// <summary>grpc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#grpc AppmeshVirtualNode#grpc}
        /// </remarks>
        [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutGrpc\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutGrpc? Grpc
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
        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp? Http
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
        [JsiiProperty(name: "http2", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2? Http2
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
        [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutTcp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutTcp? Tcp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListenerTimeout), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTimeout")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeout
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>grpc block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#grpc AppmeshVirtualNode#grpc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutGrpc\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutGrpc? Grpc
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutGrpc?>();
            }

            /// <summary>http block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#http AppmeshVirtualNode#http}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp? Http
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp?>();
            }

            /// <summary>http2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#http2 AppmeshVirtualNode#http2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http2", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2? Http2
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2?>();
            }

            /// <summary>tcp block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#tcp AppmeshVirtualNode#tcp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutTcp\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutTcp? Tcp
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutTcp?>();
            }
        }
    }
}
