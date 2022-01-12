using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListenerTimeoutGrpc), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutGrpc")]
    public interface IAppmeshVirtualNodeSpecListenerTimeoutGrpc
    {
        /// <summary>idle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#idle AppmeshVirtualNode#idle}
        /// </remarks>
        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutGrpcIdle\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutGrpcIdle? Idle
        {
            get
            {
                return null;
            }
        }

        /// <summary>per_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#per_request AppmeshVirtualNode#per_request}
        /// </remarks>
        [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutGrpcPerRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutGrpcPerRequest? PerRequest
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListenerTimeoutGrpc), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutGrpc")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutGrpc
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>idle block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#idle AppmeshVirtualNode#idle}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutGrpcIdle\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutGrpcIdle? Idle
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutGrpcIdle?>();
            }

            /// <summary>per_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#per_request AppmeshVirtualNode#per_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutGrpcPerRequest\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutGrpcPerRequest? PerRequest
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutGrpcPerRequest?>();
            }
        }
    }
}
