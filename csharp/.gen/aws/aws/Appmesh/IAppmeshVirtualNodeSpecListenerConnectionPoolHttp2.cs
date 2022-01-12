using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListenerConnectionPoolHttp2), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttp2")]
    public interface IAppmeshVirtualNodeSpecListenerConnectionPoolHttp2
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#max_requests AppmeshVirtualNode#max_requests}.</summary>
        [JsiiProperty(name: "maxRequests", typeJson: "{\"primitive\":\"number\"}")]
        double MaxRequests
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListenerConnectionPoolHttp2), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttp2")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp2
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
