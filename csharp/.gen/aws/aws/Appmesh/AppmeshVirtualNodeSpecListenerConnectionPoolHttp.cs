using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttp")]
    public class AppmeshVirtualNodeSpecListenerConnectionPoolHttp : aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#max_connections AppmeshVirtualNode#max_connections}.</summary>
        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MaxConnections
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#max_pending_requests AppmeshVirtualNode#max_pending_requests}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxPendingRequests", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxPendingRequests
        {
            get;
            set;
        }
    }
}
