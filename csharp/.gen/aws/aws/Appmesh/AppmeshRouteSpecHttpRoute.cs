using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshRouteSpecHttpRoute")]
    public class AppmeshRouteSpecHttpRoute : aws.Appmesh.IAppmeshRouteSpecHttpRoute
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#action AppmeshRoute#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteAction\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecHttpRouteAction Action
        {
            get;
            set;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#match AppmeshRoute#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteMatch\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecHttpRouteMatch Match
        {
            get;
            set;
        }

        /// <summary>retry_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#retry_policy AppmeshRoute#retry_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteRetryPolicy\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecHttpRouteRetryPolicy? RetryPolicy
        {
            get;
            set;
        }

        /// <summary>timeout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#timeout AppmeshRoute#timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteTimeout\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeout? Timeout
        {
            get;
            set;
        }
    }
}
