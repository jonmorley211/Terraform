using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Timestreamwrite
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/timestreamwrite_table aws_timestreamwrite_table}.</summary>
    [JsiiClass(nativeType: typeof(aws.Timestreamwrite.TimestreamwriteTable), fullyQualifiedName: "aws.timestreamwrite.TimestreamwriteTable", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.timestreamwrite.TimestreamwriteTableConfig\"}}]")]
    public class TimestreamwriteTable : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/timestreamwrite_table aws_timestreamwrite_table} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public TimestreamwriteTable(Constructs.Construct scope, string id, aws.Timestreamwrite.ITimestreamwriteTableConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TimestreamwriteTable(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TimestreamwriteTable(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMagneticStoreWriteProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.timestreamwrite.TimestreamwriteTableMagneticStoreWriteProperties\"}}]")]
        public virtual void PutMagneticStoreWriteProperties(aws.Timestreamwrite.ITimestreamwriteTableMagneticStoreWriteProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Timestreamwrite.ITimestreamwriteTableMagneticStoreWriteProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRetentionProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.timestreamwrite.TimestreamwriteTableRetentionProperties\"}}]")]
        public virtual void PutRetentionProperties(aws.Timestreamwrite.ITimestreamwriteTableRetentionProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Timestreamwrite.ITimestreamwriteTableRetentionProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMagneticStoreWriteProperties")]
        public virtual void ResetMagneticStoreWriteProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetentionProperties")]
        public virtual void ResetRetentionProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Timestreamwrite.TimestreamwriteTable))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "magneticStoreWriteProperties", typeJson: "{\"fqn\":\"aws.timestreamwrite.TimestreamwriteTableMagneticStoreWritePropertiesOutputReference\"}")]
        public virtual aws.Timestreamwrite.TimestreamwriteTableMagneticStoreWritePropertiesOutputReference MagneticStoreWriteProperties
        {
            get => GetInstanceProperty<aws.Timestreamwrite.TimestreamwriteTableMagneticStoreWritePropertiesOutputReference>()!;
        }

        [JsiiProperty(name: "retentionProperties", typeJson: "{\"fqn\":\"aws.timestreamwrite.TimestreamwriteTableRetentionPropertiesOutputReference\"}")]
        public virtual aws.Timestreamwrite.TimestreamwriteTableRetentionPropertiesOutputReference RetentionProperties
        {
            get => GetInstanceProperty<aws.Timestreamwrite.TimestreamwriteTableRetentionPropertiesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "magneticStoreWritePropertiesInput", typeJson: "{\"fqn\":\"aws.timestreamwrite.TimestreamwriteTableMagneticStoreWriteProperties\"}", isOptional: true)]
        public virtual aws.Timestreamwrite.ITimestreamwriteTableMagneticStoreWriteProperties? MagneticStoreWritePropertiesInput
        {
            get => GetInstanceProperty<aws.Timestreamwrite.ITimestreamwriteTableMagneticStoreWriteProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionPropertiesInput", typeJson: "{\"fqn\":\"aws.timestreamwrite.TimestreamwriteTableRetentionProperties\"}", isOptional: true)]
        public virtual aws.Timestreamwrite.ITimestreamwriteTableRetentionProperties? RetentionPropertiesInput
        {
            get => GetInstanceProperty<aws.Timestreamwrite.ITimestreamwriteTableRetentionProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TableNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsAllInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
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

        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object Tags
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object TagsAll
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
