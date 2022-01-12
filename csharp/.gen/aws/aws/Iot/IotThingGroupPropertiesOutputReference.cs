using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    [JsiiClass(nativeType: typeof(aws.Iot.IotThingGroupPropertiesOutputReference), fullyQualifiedName: "aws.iot.IotThingGroupPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class IotThingGroupPropertiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public IotThingGroupPropertiesOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotThingGroupPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotThingGroupPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAttributePayload", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iot.IotThingGroupPropertiesAttributePayload\"}}]")]
        public virtual void PutAttributePayload(aws.Iot.IIotThingGroupPropertiesAttributePayload @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Iot.IIotThingGroupPropertiesAttributePayload)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAttributePayload")]
        public virtual void ResetAttributePayload()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "attributePayload", typeJson: "{\"fqn\":\"aws.iot.IotThingGroupPropertiesAttributePayloadOutputReference\"}")]
        public virtual aws.Iot.IotThingGroupPropertiesAttributePayloadOutputReference AttributePayload
        {
            get => GetInstanceProperty<aws.Iot.IotThingGroupPropertiesAttributePayloadOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributePayloadInput", typeJson: "{\"fqn\":\"aws.iot.IotThingGroupPropertiesAttributePayload\"}", isOptional: true)]
        public virtual aws.Iot.IIotThingGroupPropertiesAttributePayload? AttributePayloadInput
        {
            get => GetInstanceProperty<aws.Iot.IIotThingGroupPropertiesAttributePayload?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.iot.IotThingGroupProperties\"}", isOptional: true)]
        public virtual aws.Iot.IIotThingGroupProperties? InternalValue
        {
            get => GetInstanceProperty<aws.Iot.IIotThingGroupProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
