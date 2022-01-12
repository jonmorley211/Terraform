using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNames), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNames")]
    public interface IAppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNames
    {
        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#match AppmeshVirtualGateway#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesMatch\"}")]
        aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesMatch Match
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNames), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNames")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNames
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#match AppmeshVirtualGateway#match}
            /// </remarks>
            [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesMatch\"}")]
            public aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesMatch Match
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesMatch>()!;
            }
        }
    }
}
