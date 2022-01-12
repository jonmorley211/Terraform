using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsValidationTrustAcm")]
    public class AppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsValidationTrustAcm : aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsValidationTrustAcm
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#certificate_authority_arns AppmeshVirtualGateway#certificate_authority_arns}.</summary>
        [JsiiProperty(name: "certificateAuthorityArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] CertificateAuthorityArns
        {
            get;
            set;
        }
    }
}
