using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttp2")]
    public class AppmeshVirtualNodeSpecListenerConnectionPoolHttp2 : aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp2
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#max_requests AppmeshVirtualNode#max_requests}.</summary>
        [JsiiProperty(name: "maxRequests", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MaxRequests
        {
            get;
            set;
        }
    }
}
