using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustAcm")]
    public class AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustAcm : aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustAcm
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#certificate_authority_arns AppmeshVirtualNode#certificate_authority_arns}.</summary>
        [JsiiProperty(name: "certificateAuthorityArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] CertificateAuthorityArns
        {
            get;
            set;
        }
    }
}
