using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshRouteSpecHttp2RouteTimeout")]
    public class AppmeshRouteSpecHttp2RouteTimeout : aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeout
    {
        /// <summary>idle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#idle AppmeshRoute#idle}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteTimeoutIdle\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeoutIdle? Idle
        {
            get;
            set;
        }

        /// <summary>per_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#per_request AppmeshRoute#per_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteTimeoutPerRequest\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeoutPerRequest? PerRequest
        {
            get;
            set;
        }
    }
}
