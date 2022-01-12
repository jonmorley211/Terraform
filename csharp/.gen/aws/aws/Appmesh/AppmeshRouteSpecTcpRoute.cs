using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshRouteSpecTcpRoute")]
    public class AppmeshRouteSpecTcpRoute : aws.Appmesh.IAppmeshRouteSpecTcpRoute
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#action AppmeshRoute#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRouteAction\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecTcpRouteAction Action
        {
            get;
            set;
        }

        /// <summary>timeout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#timeout AppmeshRoute#timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRouteTimeout\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecTcpRouteTimeout? Timeout
        {
            get;
            set;
        }
    }
}
