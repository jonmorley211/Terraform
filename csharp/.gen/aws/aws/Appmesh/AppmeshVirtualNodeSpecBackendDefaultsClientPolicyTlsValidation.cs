using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidation")]
    public class AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidation : aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidation
    {
        /// <summary>trust block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#trust AppmeshVirtualNode#trust}
        /// </remarks>
        [JsiiProperty(name: "trust", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrust\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrust Trust
        {
            get;
            set;
        }

        /// <summary>subject_alternative_names block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#subject_alternative_names AppmeshVirtualNode#subject_alternative_names}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames? SubjectAlternativeNames
        {
            get;
            set;
        }
    }
}
