using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshGatewayRouteSpecHttpRouteActionTargetVirtualService")]
    public class AppmeshGatewayRouteSpecHttpRouteActionTargetVirtualService : aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteActionTargetVirtualService
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#virtual_service_name AppmeshGatewayRoute#virtual_service_name}.</summary>
        [JsiiProperty(name: "virtualServiceName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string VirtualServiceName
        {
            get;
            set;
        }
    }
}
