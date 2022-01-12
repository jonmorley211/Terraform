using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiClass(nativeType: typeof(aws.Glue.GlueMlTransformParametersFindMatchesParametersOutputReference), fullyQualifiedName: "aws.glue.GlueMlTransformParametersFindMatchesParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class GlueMlTransformParametersFindMatchesParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public GlueMlTransformParametersFindMatchesParametersOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueMlTransformParametersFindMatchesParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueMlTransformParametersFindMatchesParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAccuracyCostTradeOff")]
        public virtual void ResetAccuracyCostTradeOff()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnforceProvidedLabels")]
        public virtual void ResetEnforceProvidedLabels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrecisionRecallTradeOff")]
        public virtual void ResetPrecisionRecallTradeOff()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrimaryKeyColumnName")]
        public virtual void ResetPrimaryKeyColumnName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "accuracyCostTradeOffInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AccuracyCostTradeOffInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enforceProvidedLabelsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnforceProvidedLabelsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "precisionRecallTradeOffInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PrecisionRecallTradeOffInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primaryKeyColumnNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrimaryKeyColumnNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accuracyCostTradeOff", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AccuracyCostTradeOff
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enforceProvidedLabels", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnforceProvidedLabels
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "precisionRecallTradeOff", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PrecisionRecallTradeOff
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "primaryKeyColumnName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryKeyColumnName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glue.GlueMlTransformParametersFindMatchesParameters\"}", isOptional: true)]
        public virtual aws.Glue.IGlueMlTransformParametersFindMatchesParameters? InternalValue
        {
            get => GetInstanceProperty<aws.Glue.IGlueMlTransformParametersFindMatchesParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
