using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteMatch")]
    public class AppmeshGatewayRouteSpecHttp2RouteMatch : aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#prefix AppmeshGatewayRoute#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Prefix
        {
            get;
            set;
        }
    }
}
