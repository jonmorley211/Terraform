using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    [JsiiInterface(nativeType: typeof(IMacie2ClassificationJobS3JobDefinitionScopingIncludes), fullyQualifiedName: "aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingIncludes")]
    public interface IMacie2ClassificationJobS3JobDefinitionScopingIncludes
    {
        /// <summary>and block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#and Macie2ClassificationJob#and}
        /// </remarks>
        [JsiiProperty(name: "and", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingIncludesAnd\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingIncludesAnd[]? And
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMacie2ClassificationJobS3JobDefinitionScopingIncludes), fullyQualifiedName: "aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingIncludes")]
        internal sealed class _Proxy : DeputyBase, aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingIncludes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>and block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#and Macie2ClassificationJob#and}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "and", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingIncludesAnd\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingIncludesAnd[]? And
            {
                get => GetInstanceProperty<aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingIncludesAnd[]?>();
            }
        }
    }
}
