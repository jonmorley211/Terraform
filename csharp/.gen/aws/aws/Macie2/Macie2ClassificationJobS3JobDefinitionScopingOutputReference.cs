using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    [JsiiClass(nativeType: typeof(aws.Macie2.Macie2ClassificationJobS3JobDefinitionScopingOutputReference), fullyQualifiedName: "aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Macie2ClassificationJobS3JobDefinitionScopingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Macie2ClassificationJobS3JobDefinitionScopingOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2ClassificationJobS3JobDefinitionScopingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2ClassificationJobS3JobDefinitionScopingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExcludes", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludes\"}}]")]
        public virtual void PutExcludes(aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludes @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludes)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIncludes", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingIncludes\"}}]")]
        public virtual void PutIncludes(aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingIncludes @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingIncludes)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExcludes")]
        public virtual void ResetExcludes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludes")]
        public virtual void ResetIncludes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "excludes", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludesOutputReference\"}")]
        public virtual aws.Macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludesOutputReference Excludes
        {
            get => GetInstanceProperty<aws.Macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludesOutputReference>()!;
        }

        [JsiiProperty(name: "includes", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingIncludesOutputReference\"}")]
        public virtual aws.Macie2.Macie2ClassificationJobS3JobDefinitionScopingIncludesOutputReference Includes
        {
            get => GetInstanceProperty<aws.Macie2.Macie2ClassificationJobS3JobDefinitionScopingIncludesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludesInput", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludes\"}", isOptional: true)]
        public virtual aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludes? ExcludesInput
        {
            get => GetInstanceProperty<aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludes?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includesInput", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingIncludes\"}", isOptional: true)]
        public virtual aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingIncludes? IncludesInput
        {
            get => GetInstanceProperty<aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingIncludes?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScoping\"}", isOptional: true)]
        public virtual aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScoping? InternalValue
        {
            get => GetInstanceProperty<aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScoping?>();
            set => SetInstanceProperty(value);
        }
    }
}
