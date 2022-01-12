using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiClass(nativeType: typeof(aws.Glue.GlueTriggerPredicateOutputReference), fullyQualifiedName: "aws.glue.GlueTriggerPredicateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class GlueTriggerPredicateOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public GlueTriggerPredicateOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueTriggerPredicateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueTriggerPredicateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLogical")]
        public virtual void ResetLogical()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "conditionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueTriggerPredicateConditions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Glue.IGlueTriggerPredicateConditions[]? ConditionsInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueTriggerPredicateConditions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logicalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogicalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "conditions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueTriggerPredicateConditions\"},\"kind\":\"array\"}}")]
        public virtual aws.Glue.IGlueTriggerPredicateConditions[] Conditions
        {
            get => GetInstanceProperty<aws.Glue.IGlueTriggerPredicateConditions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logical", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Logical
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glue.GlueTriggerPredicate\"}", isOptional: true)]
        public virtual aws.Glue.IGlueTriggerPredicate? InternalValue
        {
            get => GetInstanceProperty<aws.Glue.IGlueTriggerPredicate?>();
            set => SetInstanceProperty(value);
        }
    }
}
