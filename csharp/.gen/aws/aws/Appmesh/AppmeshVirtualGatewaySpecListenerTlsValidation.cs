using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidation")]
    public class AppmeshVirtualGatewaySpecListenerTlsValidation : aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidation
    {
        /// <summary>trust block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#trust AppmeshVirtualGateway#trust}
        /// </remarks>
        [JsiiProperty(name: "trust", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationTrust\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationTrust Trust
        {
            get;
            set;
        }

        /// <summary>subject_alternative_names block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#subject_alternative_names AppmeshVirtualGateway#subject_alternative_names}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNames\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNames? SubjectAlternativeNames
        {
            get;
            set;
        }
    }
}
