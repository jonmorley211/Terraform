using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    [JsiiInterface(nativeType: typeof(IMacie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTerm), fullyQualifiedName: "aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTerm")]
    public interface IMacie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTerm
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#comparator Macie2ClassificationJob#comparator}.</summary>
        [JsiiProperty(name: "comparator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Comparator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#key Macie2ClassificationJob#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Key
        {
            get
            {
                return null;
            }
        }

        /// <summary>tag_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#tag_values Macie2ClassificationJob#tag_values}
        /// </remarks>
        [JsiiProperty(name: "tagValues", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTermTagValues\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTermTagValues[]? TagValues
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#target Macie2ClassificationJob#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Target
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMacie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTerm), fullyQualifiedName: "aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTerm")]
        internal sealed class _Proxy : DeputyBase, aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTerm
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#comparator Macie2ClassificationJob#comparator}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "comparator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Comparator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#key Macie2ClassificationJob#key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Key
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tag_values block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#tag_values Macie2ClassificationJob#tag_values}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tagValues", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTermTagValues\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTermTagValues[]? TagValues
            {
                get => GetInstanceProperty<aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTermTagValues[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#target Macie2ClassificationJob#target}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Target
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
