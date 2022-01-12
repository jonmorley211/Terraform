using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshRouteSpecGrpcRoute")]
    public class AppmeshRouteSpecGrpcRoute : aws.Appmesh.IAppmeshRouteSpecGrpcRoute
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#action AppmeshRoute#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteAction\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecGrpcRouteAction Action
        {
            get;
            set;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#match AppmeshRoute#match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteMatch\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecGrpcRouteMatch? Match
        {
            get;
            set;
        }

        /// <summary>retry_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#retry_policy AppmeshRoute#retry_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteRetryPolicy\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecGrpcRouteRetryPolicy? RetryPolicy
        {
            get;
            set;
        }

        /// <summary>timeout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#timeout AppmeshRoute#timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteTimeout\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeout? Timeout
        {
            get;
            set;
        }
    }
}
