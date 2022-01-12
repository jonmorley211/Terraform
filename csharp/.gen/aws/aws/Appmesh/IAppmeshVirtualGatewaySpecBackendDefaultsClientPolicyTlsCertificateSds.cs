using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsCertificateSds), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsCertificateSds")]
    public interface IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsCertificateSds
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#secret_name AppmeshVirtualGateway#secret_name}.</summary>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        string SecretName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsCertificateSds), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsCertificateSds")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsCertificateSds
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#secret_name AppmeshVirtualGateway#secret_name}.</summary>
            [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
