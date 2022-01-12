using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshRouteSpecHttp2RouteActionWeightedTarget")]
    public class AppmeshRouteSpecHttp2RouteActionWeightedTarget : aws.Appmesh.IAppmeshRouteSpecHttp2RouteActionWeightedTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#virtual_node AppmeshRoute#virtual_node}.</summary>
        [JsiiProperty(name: "virtualNode", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string VirtualNode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#weight AppmeshRoute#weight}.</summary>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Weight
        {
            get;
            set;
        }
    }
}
