using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecListenerTls")]
    public class AppmeshVirtualNodeSpecListenerTls : aws.Appmesh.IAppmeshVirtualNodeSpecListenerTls
    {
        /// <summary>certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#certificate AppmeshVirtualNode#certificate}
        /// </remarks>
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTlsCertificate\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsCertificate Certificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#mode AppmeshVirtualNode#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>validation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#validation AppmeshVirtualNode#validation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "validation", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidation\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidation? Validation
        {
            get;
            set;
        }
    }
}
