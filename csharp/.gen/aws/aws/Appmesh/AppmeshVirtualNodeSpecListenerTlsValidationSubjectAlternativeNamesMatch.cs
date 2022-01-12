using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNamesMatch")]
    public class AppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNamesMatch : aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNamesMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#exact AppmeshVirtualNode#exact}.</summary>
        [JsiiProperty(name: "exact", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Exact
        {
            get;
            set;
        }
    }
}
