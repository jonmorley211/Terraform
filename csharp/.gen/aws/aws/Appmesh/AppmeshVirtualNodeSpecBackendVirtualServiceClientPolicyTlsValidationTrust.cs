using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrust")]
    public class AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrust : aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrust
    {
        /// <summary>acm block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#acm AppmeshVirtualNode#acm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acm", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcm\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcm? Acm
        {
            get;
            set;
        }

        /// <summary>file block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#file AppmeshVirtualNode#file}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustFile\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustFile? File
        {
            get;
            set;
        }

        /// <summary>sds block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#sds AppmeshVirtualNode#sds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sds", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustSds\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustSds? Sds
        {
            get;
            set;
        }
    }
}
