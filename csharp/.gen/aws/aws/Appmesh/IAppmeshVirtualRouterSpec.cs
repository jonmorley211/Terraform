using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualRouterSpec), fullyQualifiedName: "aws.appmesh.AppmeshVirtualRouterSpec")]
    public interface IAppmeshVirtualRouterSpec
    {
        /// <summary>listener block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_router#listener AppmeshVirtualRouter#listener}
        /// </remarks>
        [JsiiProperty(name: "listener", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualRouterSpecListener\"}")]
        aws.Appmesh.IAppmeshVirtualRouterSpecListener Listener
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualRouterSpec), fullyQualifiedName: "aws.appmesh.AppmeshVirtualRouterSpec")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualRouterSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>listener block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_router#listener AppmeshVirtualRouter#listener}
            /// </remarks>
            [JsiiProperty(name: "listener", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualRouterSpecListener\"}")]
            public aws.Appmesh.IAppmeshVirtualRouterSpecListener Listener
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualRouterSpecListener>()!;
            }
        }
    }
}
