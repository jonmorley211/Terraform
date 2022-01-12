using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutTcp")]
    public class AppmeshVirtualNodeSpecListenerTimeoutTcp : aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutTcp
    {
        /// <summary>idle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#idle AppmeshVirtualNode#idle}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutTcpIdle\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutTcpIdle? Idle
        {
            get;
            set;
        }
    }
}
