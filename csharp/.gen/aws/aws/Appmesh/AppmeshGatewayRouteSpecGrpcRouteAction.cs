using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteAction")]
    public class AppmeshGatewayRouteSpecGrpcRouteAction : aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteAction
    {
        /// <summary>target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#target AppmeshGatewayRoute#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTarget\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteActionTarget Target
        {
            get;
            set;
        }
    }
}
