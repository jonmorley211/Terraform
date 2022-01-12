using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiClass(nativeType: typeof(aws.Cognito.CognitoUserPoolSchemaStringAttributeConstraintsOutputReference), fullyQualifiedName: "aws.cognito.CognitoUserPoolSchemaStringAttributeConstraintsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CognitoUserPoolSchemaStringAttributeConstraintsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CognitoUserPoolSchemaStringAttributeConstraintsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPoolSchemaStringAttributeConstraintsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPoolSchemaStringAttributeConstraintsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaxLength")]
        public virtual void ResetMaxLength()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinLength")]
        public virtual void ResetMinLength()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxLengthInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxLengthInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minLengthInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MinLengthInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "maxLength", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxLength
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minLength", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinLength
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolSchemaStringAttributeConstraints\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolSchemaStringAttributeConstraints? InternalValue
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolSchemaStringAttributeConstraints?>();
            set => SetInstanceProperty(value);
        }
    }
}
