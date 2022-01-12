using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecBackendDefaults")]
    public class AppmeshVirtualNodeSpecBackendDefaults : aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaults
    {
        /// <summary>client_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#client_policy AppmeshVirtualNode#client_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientPolicy", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicy\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicy? ClientPolicy
        {
            get;
            set;
        }
    }
}
