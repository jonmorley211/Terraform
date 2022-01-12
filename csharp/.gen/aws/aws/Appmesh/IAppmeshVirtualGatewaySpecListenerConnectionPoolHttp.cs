using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp")]
    public interface IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#max_connections AppmeshVirtualGateway#max_connections}.</summary>
        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}")]
        double MaxConnections
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#max_pending_requests AppmeshVirtualGateway#max_pending_requests}.</summary>
        [JsiiProperty(name: "maxPendingRequests", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxPendingRequests
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#max_connections AppmeshVirtualGateway#max_connections}.</summary>
            [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxConnections
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#max_pending_requests AppmeshVirtualGateway#max_pending_requests}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxPendingRequests", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxPendingRequests
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
