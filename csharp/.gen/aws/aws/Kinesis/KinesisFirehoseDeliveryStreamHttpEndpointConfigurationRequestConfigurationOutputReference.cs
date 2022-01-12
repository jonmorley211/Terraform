using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiClass(nativeType: typeof(aws.Kinesis.KinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationOutputReference), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class KinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public KinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCommonAttributes")]
        public virtual void ResetCommonAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContentEncoding")]
        public virtual void ResetContentEncoding()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "commonAttributesInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationCommonAttributes\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationCommonAttributes[]? CommonAttributesInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationCommonAttributes[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentEncodingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContentEncodingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "commonAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationCommonAttributes\"},\"kind\":\"array\"}}")]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationCommonAttributes[] CommonAttributes
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationCommonAttributes[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "contentEncoding", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContentEncoding
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfiguration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamHttpEndpointConfigurationRequestConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
