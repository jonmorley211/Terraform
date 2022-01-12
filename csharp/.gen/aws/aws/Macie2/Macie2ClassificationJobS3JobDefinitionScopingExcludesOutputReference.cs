using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    [JsiiClass(nativeType: typeof(aws.Macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludesOutputReference), fullyQualifiedName: "aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Macie2ClassificationJobS3JobDefinitionScopingExcludesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Macie2ClassificationJobS3JobDefinitionScopingExcludesOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2ClassificationJobS3JobDefinitionScopingExcludesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2ClassificationJobS3JobDefinitionScopingExcludesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAnd")]
        public virtual void ResetAnd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "andInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludesAnd\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAnd[]? AndInput
        {
            get => GetInstanceProperty<aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAnd[]?>();
        }

        [JsiiProperty(name: "and", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludesAnd\"},\"kind\":\"array\"}}")]
        public virtual aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAnd[] And
        {
            get => GetInstanceProperty<aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAnd[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludes\"}", isOptional: true)]
        public virtual aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludes? InternalValue
        {
            get => GetInstanceProperty<aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludes?>();
            set => SetInstanceProperty(value);
        }
    }
}
