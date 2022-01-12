using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshGatewayRouteSpecHttpRouteActionTarget")]
    public class AppmeshGatewayRouteSpecHttpRouteActionTarget : aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteActionTarget
    {
        /// <summary>virtual_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#virtual_service AppmeshGatewayRoute#virtual_service}
        /// </remarks>
        [JsiiProperty(name: "virtualService", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteActionTargetVirtualService\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshGatewayRouteSpecHttpRouteActionTargetVirtualService VirtualService
        {
            get;
            set;
        }
    }
}
