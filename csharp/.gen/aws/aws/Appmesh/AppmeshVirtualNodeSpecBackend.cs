using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecBackend")]
    public class AppmeshVirtualNodeSpecBackend : aws.Appmesh.IAppmeshVirtualNodeSpecBackend
    {
        /// <summary>virtual_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#virtual_service AppmeshVirtualNode#virtual_service}
        /// </remarks>
        [JsiiProperty(name: "virtualService", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualService\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualService VirtualService
        {
            get;
            set;
        }
    }
}
