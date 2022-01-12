using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListenerTimeoutTcp), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutTcp")]
    public interface IAppmeshVirtualNodeSpecListenerTimeoutTcp
    {
        /// <summary>idle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#idle AppmeshVirtualNode#idle}
        /// </remarks>
        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutTcpIdle\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutTcpIdle? Idle
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListenerTimeoutTcp), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutTcp")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutTcp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>idle block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#idle AppmeshVirtualNode#idle}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutTcpIdle\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutTcpIdle? Idle
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutTcpIdle?>();
            }
        }
    }
}
