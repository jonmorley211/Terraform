using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListenerTimeoutHttp), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp")]
    public interface IAppmeshVirtualNodeSpecListenerTimeoutHttp
    {
        /// <summary>idle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#idle AppmeshVirtualNode#idle}
        /// </remarks>
        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpIdle\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttpIdle? Idle
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
        [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpPerRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttpPerRequest? PerRequest
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListenerTimeoutHttp), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>idle block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#idle AppmeshVirtualNode#idle}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpIdle\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttpIdle? Idle
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttpIdle?>();
            }

            /// <summary>per_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#per_request AppmeshVirtualNode#per_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpPerRequest\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttpPerRequest? PerRequest
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttpPerRequest?>();
            }
        }
    }
}
