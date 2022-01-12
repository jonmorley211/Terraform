using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidation")]
    public class AppmeshVirtualNodeSpecListenerTlsValidation : aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidation
    {
        /// <summary>trust block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#trust AppmeshVirtualNode#trust}
        /// </remarks>
        [JsiiProperty(name: "trust", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrust\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationTrust Trust
        {
            get;
            set;
        }

        /// <summary>subject_alternative_names block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#subject_alternative_names AppmeshVirtualNode#subject_alternative_names}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNames\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNames? SubjectAlternativeNames
        {
            get;
            set;
        }
    }
}
