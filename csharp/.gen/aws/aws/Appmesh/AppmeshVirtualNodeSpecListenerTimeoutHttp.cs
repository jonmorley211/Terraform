using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp")]
    public class AppmeshVirtualNodeSpecListenerTimeoutHttp : aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp
    {
        /// <summary>idle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#idle AppmeshVirtualNode#idle}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpIdle\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttpIdle? Idle
        {
            get;
            set;
        }

        /// <summary>per_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#per_request AppmeshVirtualNode#per_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpPerRequest\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttpPerRequest? PerRequest
        {
            get;
            set;
        }
    }
}
