using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNames")]
    public class AppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNames : aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNames
    {
        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#match AppmeshVirtualNode#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNamesMatch\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNamesMatch Match
        {
            get;
            set;
        }
    }
}
