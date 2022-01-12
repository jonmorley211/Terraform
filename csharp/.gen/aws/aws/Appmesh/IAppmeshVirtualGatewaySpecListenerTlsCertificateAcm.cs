using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualGatewaySpecListenerTlsCertificateAcm), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsCertificateAcm")]
    public interface IAppmeshVirtualGatewaySpecListenerTlsCertificateAcm
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#certificate_arn AppmeshVirtualGateway#certificate_arn}.</summary>
        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualGatewaySpecListenerTlsCertificateAcm), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsCertificateAcm")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsCertificateAcm
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#certificate_arn AppmeshVirtualGateway#certificate_arn}.</summary>
            [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
