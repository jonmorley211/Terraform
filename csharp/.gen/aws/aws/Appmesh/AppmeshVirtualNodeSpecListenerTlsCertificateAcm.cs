using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecListenerTlsCertificateAcm")]
    public class AppmeshVirtualNodeSpecListenerTlsCertificateAcm : aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsCertificateAcm
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#certificate_arn AppmeshVirtualNode#certificate_arn}.</summary>
        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string CertificateArn
        {
            get;
            set;
        }
    }
}
