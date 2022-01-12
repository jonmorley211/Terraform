using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecListenerTlsCertificateFile")]
    public class AppmeshVirtualNodeSpecListenerTlsCertificateFile : aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsCertificateFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#certificate_chain AppmeshVirtualNode#certificate_chain}.</summary>
        [JsiiProperty(name: "certificateChain", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string CertificateChain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#private_key AppmeshVirtualNode#private_key}.</summary>
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string PrivateKey
        {
            get;
            set;
        }
    }
}
