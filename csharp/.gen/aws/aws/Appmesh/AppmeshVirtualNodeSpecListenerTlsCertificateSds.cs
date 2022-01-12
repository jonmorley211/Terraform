using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecListenerTlsCertificateSds")]
    public class AppmeshVirtualNodeSpecListenerTlsCertificateSds : aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsCertificateSds
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#secret_name AppmeshVirtualNode#secret_name}.</summary>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SecretName
        {
            get;
            set;
        }
    }
}
