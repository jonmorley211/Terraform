using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNames), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNames")]
    public interface IAppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNames
    {
        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#match AppmeshVirtualNode#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNamesMatch\"}")]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNamesMatch Match
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNames), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNames")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNames
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#match AppmeshVirtualNode#match}
            /// </remarks>
            [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNamesMatch\"}")]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNamesMatch Match
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationSubjectAlternativeNamesMatch>()!;
            }
        }
    }
}
