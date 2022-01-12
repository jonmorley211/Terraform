using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualRouterSpec")]
    public class AppmeshVirtualRouterSpec : aws.Appmesh.IAppmeshVirtualRouterSpec
    {
        /// <summary>listener block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_router#listener AppmeshVirtualRouter#listener}
        /// </remarks>
        [JsiiProperty(name: "listener", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualRouterSpecListener\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualRouterSpecListener Listener
        {
            get;
            set;
        }
    }
}
