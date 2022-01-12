using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshRouteSpecTcpRouteTimeout")]
    public class AppmeshRouteSpecTcpRouteTimeout : aws.Appmesh.IAppmeshRouteSpecTcpRouteTimeout
    {
        /// <summary>idle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#idle AppmeshRoute#idle}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRouteTimeoutIdle\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecTcpRouteTimeoutIdle? Idle
        {
            get;
            set;
        }
    }
}
