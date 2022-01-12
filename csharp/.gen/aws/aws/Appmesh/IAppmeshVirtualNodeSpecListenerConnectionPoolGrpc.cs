using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListenerConnectionPoolGrpc), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolGrpc")]
    public interface IAppmeshVirtualNodeSpecListenerConnectionPoolGrpc
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#max_requests AppmeshVirtualNode#max_requests}.</summary>
        [JsiiProperty(name: "maxRequests", typeJson: "{\"primitive\":\"number\"}")]
        double MaxRequests
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListenerConnectionPoolGrpc), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolGrpc")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolGrpc
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#max_requests AppmeshVirtualNode#max_requests}.</summary>
            [JsiiProperty(name: "maxRequests", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxRequests
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
