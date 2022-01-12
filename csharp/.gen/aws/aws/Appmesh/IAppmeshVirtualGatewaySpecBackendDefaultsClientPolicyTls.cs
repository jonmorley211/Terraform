using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTls), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTls")]
    public interface IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTls
    {
        /// <summary>validation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#validation AppmeshVirtualGateway#validation}
        /// </remarks>
        [JsiiProperty(name: "validation", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsValidation\"}")]
        aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsValidation Validation
        {
            get;
        }

        /// <summary>certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#certificate AppmeshVirtualGateway#certificate}
        /// </remarks>
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsCertificate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsCertificate? Certificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#enforce AppmeshVirtualGateway#enforce}.</summary>
        [JsiiProperty(name: "enforce", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enforce
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#ports AppmeshVirtualGateway#ports}.</summary>
        [JsiiProperty(name: "ports", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? Ports
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTls), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTls")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>validation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#validation AppmeshVirtualGateway#validation}
            /// </remarks>
            [JsiiProperty(name: "validation", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsValidation\"}")]
            public aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsValidation Validation
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsValidation>()!;
            }

            /// <summary>certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#certificate AppmeshVirtualGateway#certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsCertificate\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsCertificate? Certificate
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicyTlsCertificate?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#enforce AppmeshVirtualGateway#enforce}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enforce", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enforce
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_gateway#ports AppmeshVirtualGateway#ports}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ports", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? Ports
            {
                get => GetInstanceProperty<double[]?>();
            }
        }
    }
}
