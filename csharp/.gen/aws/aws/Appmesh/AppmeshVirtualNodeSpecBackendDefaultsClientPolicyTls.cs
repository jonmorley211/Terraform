using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTls")]
    public class AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTls : aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTls
    {
        /// <summary>validation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#validation AppmeshVirtualNode#validation}
        /// </remarks>
        [JsiiProperty(name: "validation", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidation\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidation Validation
        {
            get;
            set;
        }

        /// <summary>certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#certificate AppmeshVirtualNode#certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsCertificate\"}", isOptional: true, isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsCertificate? Certificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#enforce AppmeshVirtualNode#enforce}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enforce", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? Enforce
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#ports AppmeshVirtualNode#ports}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ports", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public double[]? Ports
        {
            get;
            set;
        }
    }
}
