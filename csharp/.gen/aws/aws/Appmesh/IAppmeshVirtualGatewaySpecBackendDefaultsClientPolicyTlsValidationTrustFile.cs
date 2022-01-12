using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsValidationTrustFile), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsValidationTrustFile")]
    public interface IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsValidationTrustFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#certificate_chain AppmeshVirtualGateway#certificate_chain}.</summary>
        [JsiiProperty(name: "certificateChain", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateChain
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsValidationTrustFile), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsValidationTrustFile")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsValidationTrustFile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#certificate_chain AppmeshVirtualGateway#certificate_chain}.</summary>
            [JsiiProperty(name: "certificateChain", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateChain
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
