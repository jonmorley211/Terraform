using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    /// <summary>AWS Macie 2.</summary>
    [JsiiInterface(nativeType: typeof(IMacie2CustomDataIdentifierConfig), fullyQualifiedName: "aws.macie2.Macie2CustomDataIdentifierConfig")]
    public interface IMacie2CustomDataIdentifierConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_custom_data_identifier#description Macie2CustomDataIdentifier#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_custom_data_identifier#ignore_words Macie2CustomDataIdentifier#ignore_words}.</summary>
        [JsiiProperty(name: "ignoreWords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IgnoreWords
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_custom_data_identifier#keywords Macie2CustomDataIdentifier#keywords}.</summary>
        [JsiiProperty(name: "keywords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Keywords
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_custom_data_identifier#maximum_match_distance Macie2CustomDataIdentifier#maximum_match_distance}.</summary>
        [JsiiProperty(name: "maximumMatchDistance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumMatchDistance
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_custom_data_identifier#name Macie2CustomDataIdentifier#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_custom_data_identifier#name_prefix Macie2CustomDataIdentifier#name_prefix}.</summary>
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_custom_data_identifier#regex Macie2CustomDataIdentifier#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Regex
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_custom_data_identifier#tags Macie2CustomDataIdentifier#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_custom_data_identifier#tags_all Macie2CustomDataIdentifier#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Macie 2.</summary>
        [JsiiTypeProxy(nativeType: typeof(IMacie2CustomDataIdentifierConfig), fullyQualifiedName: "aws.macie2.Macie2CustomDataIdentifierConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Macie2.IMacie2CustomDataIdentifierConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_custom_data_identifier#description Macie2CustomDataIdentifier#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_custom_data_identifier#ignore_words Macie2CustomDataIdentifier#ignore_words}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreWords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IgnoreWords
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_custom_data_identifier#keywords Macie2CustomDataIdentifier#keywords}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keywords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Keywords
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_custom_data_identifier#maximum_match_distance Macie2CustomDataIdentifier#maximum_match_distance}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumMatchDistance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumMatchDistance
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_custom_data_identifier#name Macie2CustomDataIdentifier#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_custom_data_identifier#name_prefix Macie2CustomDataIdentifier#name_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_custom_data_identifier#regex Macie2CustomDataIdentifier#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Regex
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_custom_data_identifier#tags Macie2CustomDataIdentifier#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Tags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_custom_data_identifier#tags_all Macie2CustomDataIdentifier#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? TagsAll
            {
                get => GetInstanceProperty<object?>();
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