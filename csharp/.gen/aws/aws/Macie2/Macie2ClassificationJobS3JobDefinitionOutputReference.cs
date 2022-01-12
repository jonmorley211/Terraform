using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    [JsiiClass(nativeType: typeof(aws.Macie2.Macie2ClassificationJobS3JobDefinitionOutputReference), fullyQualifiedName: "aws.macie2.Macie2ClassificationJobS3JobDefinitionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Macie2ClassificationJobS3JobDefinitionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Macie2ClassificationJobS3JobDefinitionOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2ClassificationJobS3JobDefinitionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2ClassificationJobS3JobDefinitionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putScoping", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScoping\"}}]")]
        public virtual void PutScoping(aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScoping @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScoping)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBucketDefinitions")]
        public virtual void ResetBucketDefinitions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScoping")]
        public virtual void ResetScoping()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "scoping", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingOutputReference\"}")]
        public virtual aws.Macie2.Macie2ClassificationJobS3JobDefinitionScopingOutputReference Scoping
        {
            get => GetInstanceProperty<aws.Macie2.Macie2ClassificationJobS3JobDefinitionScopingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketDefinitionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionBucketDefinitions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Macie2.IMacie2ClassificationJobS3JobDefinitionBucketDefinitions[]? BucketDefinitionsInput
        {
            get => GetInstanceProperty<aws.Macie2.IMacie2ClassificationJobS3JobDefinitionBucketDefinitions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scopingInput", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScoping\"}", isOptional: true)]
        public virtual aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScoping? ScopingInput
        {
            get => GetInstanceProperty<aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScoping?>();
        }

        [JsiiProperty(name: "bucketDefinitions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionBucketDefinitions\"},\"kind\":\"array\"}}")]
        public virtual aws.Macie2.IMacie2ClassificationJobS3JobDefinitionBucketDefinitions[] BucketDefinitions
        {
            get => GetInstanceProperty<aws.Macie2.IMacie2ClassificationJobS3JobDefinitionBucketDefinitions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinition\"}", isOptional: true)]
        public virtual aws.Macie2.IMacie2ClassificationJobS3JobDefinition? InternalValue
        {
            get => GetInstanceProperty<aws.Macie2.IMacie2ClassificationJobS3JobDefinition?>();
            set => SetInstanceProperty(value);
        }
    }
}
