using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshRouteSpecHttp2RouteAction")]
    public class AppmeshRouteSpecHttp2RouteAction : aws.Appmesh.IAppmeshRouteSpecHttp2RouteAction
    {
        /// <summary>weighted_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#weighted_target AppmeshRoute#weighted_target}
        /// </remarks>
        [JsiiProperty(name: "weightedTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteActionWeightedTarget\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecHttp2RouteActionWeightedTarget[] WeightedTarget
        {
            get;
            set;
        }
    }
}
