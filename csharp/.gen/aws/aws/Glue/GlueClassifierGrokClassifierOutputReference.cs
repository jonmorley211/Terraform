using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiClass(nativeType: typeof(aws.Glue.GlueClassifierGrokClassifierOutputReference), fullyQualifiedName: "aws.glue.GlueClassifierGrokClassifierOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class GlueClassifierGrokClassifierOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public GlueClassifierGrokClassifierOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueClassifierGrokClassifierOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueClassifierGrokClassifierOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCustomPatterns")]
        public virtual void ResetCustomPatterns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "classificationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClassificationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customPatternsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomPatternsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "grokPatternInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GrokPatternInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Classification
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customPatterns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomPatterns
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "grokPattern", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GrokPattern
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierGrokClassifier\"}", isOptional: true)]
        public virtual aws.Glue.IGlueClassifierGrokClassifier? InternalValue
        {
            get => GetInstanceProperty<aws.Glue.IGlueClassifierGrokClassifier?>();
            set => SetInstanceProperty(value);
        }
    }
}
