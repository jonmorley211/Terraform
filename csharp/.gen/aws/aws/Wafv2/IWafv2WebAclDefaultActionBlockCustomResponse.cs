using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclDefaultActionBlockCustomResponse), fullyQualifiedName: "aws.wafv2.Wafv2WebAclDefaultActionBlockCustomResponse")]
    public interface IWafv2WebAclDefaultActionBlockCustomResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#response_code Wafv2WebAcl#response_code}.</summary>
        [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"number\"}")]
        double ResponseCode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#custom_response_body_key Wafv2WebAcl#custom_response_body_key}.</summary>
        [JsiiProperty(name: "customResponseBodyKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomResponseBodyKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>response_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#response_header Wafv2WebAcl#response_header}
        /// </remarks>
        [JsiiProperty(name: "responseHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionBlockCustomResponseResponseHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclDefaultActionBlockCustomResponseResponseHeader[]? ResponseHeader
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclDefaultActionBlockCustomResponse), fullyQualifiedName: "aws.wafv2.Wafv2WebAclDefaultActionBlockCustomResponse")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclDefaultActionBlockCustomResponse
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#response_code Wafv2WebAcl#response_code}.</summary>
            [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"number\"}")]
            public double ResponseCode
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#custom_response_body_key Wafv2WebAcl#custom_response_body_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customResponseBodyKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomResponseBodyKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>response_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#response_header Wafv2WebAcl#response_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "responseHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionBlockCustomResponseResponseHeader\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclDefaultActionBlockCustomResponseResponseHeader[]? ResponseHeader
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclDefaultActionBlockCustomResponseResponseHeader[]?>();
            }
        }
    }
}
