using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecBackend), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecBackend")]
    public interface IAppmeshVirtualNodeSpecBackend
    {
        /// <summary>virtual_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#virtual_service AppmeshVirtualNode#virtual_service}
        /// </remarks>
        [JsiiProperty(name: "virtualService", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualService\"}")]
        aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualService VirtualService
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecBackend), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecBackend")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecBackend
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>virtual_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#virtual_service AppmeshVirtualNode#virtual_service}
            /// </remarks>
            [JsiiProperty(name: "virtualService", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualService\"}")]
            public aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualService VirtualService
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualService>()!;
            }
        }
    }
}
