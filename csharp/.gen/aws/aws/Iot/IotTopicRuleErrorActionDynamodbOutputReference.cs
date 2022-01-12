using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    [JsiiClass(nativeType: typeof(aws.Iot.IotTopicRuleErrorActionDynamodbOutputReference), fullyQualifiedName: "aws.iot.IotTopicRuleErrorActionDynamodbOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class IotTopicRuleErrorActionDynamodbOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public IotTopicRuleErrorActionDynamodbOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotTopicRuleErrorActionDynamodbOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotTopicRuleErrorActionDynamodbOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetHashKeyType")]
        public virtual void ResetHashKeyType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOperation")]
        public virtual void ResetOperation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPayloadField")]
        public virtual void ResetPayloadField()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRangeKeyField")]
        public virtual void ResetRangeKeyField()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRangeKeyType")]
        public virtual void ResetRangeKeyType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRangeKeyValue")]
        public virtual void ResetRangeKeyValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "hashKeyFieldInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HashKeyFieldInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hashKeyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HashKeyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hashKeyValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HashKeyValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "operationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OperationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "payloadFieldInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PayloadFieldInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rangeKeyFieldInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RangeKeyFieldInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rangeKeyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RangeKeyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rangeKeyValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RangeKeyValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TableNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "hashKeyField", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HashKeyField
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hashKeyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HashKeyType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hashKeyValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HashKeyValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Operation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "payloadField", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayloadField
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rangeKeyField", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RangeKeyField
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rangeKeyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RangeKeyType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rangeKeyValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RangeKeyValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionDynamodb\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorActionDynamodb? InternalValue
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionDynamodb?>();
            set => SetInstanceProperty(value);
        }
    }
}
