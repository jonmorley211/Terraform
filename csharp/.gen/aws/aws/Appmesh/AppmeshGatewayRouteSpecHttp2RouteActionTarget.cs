using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTarget")]
    public class AppmeshGatewayRouteSpecHttp2RouteActionTarget : aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTarget
    {
        /// <summary>virtual_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#virtual_service AppmeshGatewayRoute#virtual_service}
        /// </remarks>
        [JsiiProperty(name: "virtualService", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService VirtualService
        {
            get;
            set;
        }
    }
}
