using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiClass(nativeType: typeof(aws.Cognito.CognitoUserPoolSchemaNumberAttributeConstraintsOutputReference), fullyQualifiedName: "aws.cognito.CognitoUserPoolSchemaNumberAttributeConstraintsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CognitoUserPoolSchemaNumberAttributeConstraintsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CognitoUserPoolSchemaNumberAttributeConstraintsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPoolSchemaNumberAttributeConstraintsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPoolSchemaNumberAttributeConstraintsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaxValue")]
        public virtual void ResetMaxValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinValue")]
        public virtual void ResetMinValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MinValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "maxValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolSchemaNumberAttributeConstraints\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolSchemaNumberAttributeConstraints? InternalValue
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolSchemaNumberAttributeConstraints?>();
            set => SetInstanceProperty(value);
        }
    }
}
