using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    /// <summary>AWS WAF V2.</summary>
    [JsiiInterface(nativeType: typeof(IWafv2WebAclLoggingConfigurationConfig), fullyQualifiedName: "aws.wafv2.Wafv2WebAclLoggingConfigurationConfig")]
    public interface IWafv2WebAclLoggingConfigurationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>AWS Kinesis Firehose Delivery Stream ARNs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#log_destination_configs Wafv2WebAclLoggingConfiguration#log_destination_configs}
        /// </remarks>
        [JsiiProperty(name: "logDestinationConfigs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] LogDestinationConfigs
        {
            get;
        }

        /// <summary>AWS WebACL ARN.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#resource_arn Wafv2WebAclLoggingConfiguration#resource_arn}
        /// </remarks>
        [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceArn
        {
            get;
        }

        /// <summary>logging_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#logging_filter Wafv2WebAclLoggingConfiguration#logging_filter}
        /// </remarks>
        [JsiiProperty(name: "loggingFilter", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilter? LoggingFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>redacted_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#redacted_fields Wafv2WebAclLoggingConfiguration#redacted_fields}
        /// </remarks>
        [JsiiProperty(name: "redactedFields", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFields\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFields[]? RedactedFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS WAF V2.</summary>
        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclLoggingConfigurationConfig), fullyQualifiedName: "aws.wafv2.Wafv2WebAclLoggingConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclLoggingConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>AWS Kinesis Firehose Delivery Stream ARNs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#log_destination_configs Wafv2WebAclLoggingConfiguration#log_destination_configs}
            /// </remarks>
            [JsiiProperty(name: "logDestinationConfigs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] LogDestinationConfigs
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>AWS WebACL ARN.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#resource_arn Wafv2WebAclLoggingConfiguration#resource_arn}
            /// </remarks>
            [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>logging_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#logging_filter Wafv2WebAclLoggingConfiguration#logging_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loggingFilter", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilter\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilter? LoggingFilter
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilter?>();
            }

            /// <summary>redacted_fields block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#redacted_fields Wafv2WebAclLoggingConfiguration#redacted_fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redactedFields", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFields\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFields[]? RedactedFields
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFields[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
