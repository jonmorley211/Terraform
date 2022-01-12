using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListenerConnectionPoolHttp), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttp")]
    public interface IAppmeshVirtualNodeSpecListenerConnectionPoolHttp
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#max_connections AppmeshVirtualNode#max_connections}.</summary>
        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}")]
        double MaxConnections
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#max_pending_requests AppmeshVirtualNode#max_pending_requests}.</summary>
        [JsiiProperty(name: "maxPendingRequests", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxPendingRequests
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListenerConnectionPoolHttp), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttp")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#max_connections AppmeshVirtualNode#max_connections}.</summary>
            [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxConnections
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#max_pending_requests AppmeshVirtualNode#max_pending_requests}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxPendingRequests", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxPendingRequests
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
