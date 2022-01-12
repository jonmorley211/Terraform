using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshRouteSpecHttp2Route")]
    public class AppmeshRouteSpecHttp2Route : aws.Appmesh.IAppmeshRouteSpecHttp2Route
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#action AppmeshRoute#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteAction\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecHttp2RouteAction Action
        {
            get;
            set;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#match AppmeshRoute#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteMatch\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecHttp2RouteMatch Match
        {
            get;
            set;
        }

        /// <summary>retry_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#retry_policy AppmeshRoute#retry_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteRetryPolicy\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecHttp2RouteRetryPolicy? RetryPolicy
        {
            get;
            set;
        }

        /// <summary>timeout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#timeout AppmeshRoute#timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteTimeout\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeout? Timeout
        {
            get;
            set;
        }
    }
}
