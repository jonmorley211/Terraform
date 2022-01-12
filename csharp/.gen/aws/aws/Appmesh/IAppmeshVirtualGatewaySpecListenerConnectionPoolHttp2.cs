using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp2), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp2")]
    public interface IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp2
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#max_requests AppmeshVirtualGateway#max_requests}.</summary>
        [JsiiProperty(name: "maxRequests", typeJson: "{\"primitive\":\"number\"}")]
        double MaxRequests
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp2), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp2")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#max_requests AppmeshVirtualGateway#max_requests}.</summary>
            [JsiiProperty(name: "maxRequests", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxRequests
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
