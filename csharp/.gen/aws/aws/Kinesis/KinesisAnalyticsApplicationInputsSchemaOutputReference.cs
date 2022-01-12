using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiClass(nativeType: typeof(aws.Kinesis.KinesisAnalyticsApplicationInputsSchemaOutputReference), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputsSchemaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class KinesisAnalyticsApplicationInputsSchemaOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public KinesisAnalyticsApplicationInputsSchemaOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplicationInputsSchemaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplicationInputsSchemaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRecordFormat", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormat\"}}]")]
        public virtual void PutRecordFormat(aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormat @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormat)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRecordEncoding")]
        public virtual void ResetRecordEncoding()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "recordFormat", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatOutputReference\"}")]
        public virtual aws.Kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatOutputReference RecordFormat
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordColumnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordColumns\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordColumns[]? RecordColumnsInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordColumns[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordEncodingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RecordEncodingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordFormatInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormat\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormat? RecordFormatInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormat?>();
        }

        [JsiiProperty(name: "recordColumns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordColumns\"},\"kind\":\"array\"}}")]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordColumns[] RecordColumns
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordColumns[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recordEncoding", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecordEncoding
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchema\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationInputsSchema? InternalValue
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsSchema?>();
            set => SetInstanceProperty(value);
        }
    }
}
