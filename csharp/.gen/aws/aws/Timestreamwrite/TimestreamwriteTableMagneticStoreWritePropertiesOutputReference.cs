using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Timestreamwrite
{
    [JsiiClass(nativeType: typeof(aws.Timestreamwrite.TimestreamwriteTableMagneticStoreWritePropertiesOutputReference), fullyQualifiedName: "aws.timestreamwrite.TimestreamwriteTableMagneticStoreWritePropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class TimestreamwriteTableMagneticStoreWritePropertiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public TimestreamwriteTableMagneticStoreWritePropertiesOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TimestreamwriteTableMagneticStoreWritePropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TimestreamwriteTableMagneticStoreWritePropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMagneticStoreRejectedDataLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.timestreamwrite.TimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocation\"}}]")]
        public virtual void PutMagneticStoreRejectedDataLocation(aws.Timestreamwrite.ITimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Timestreamwrite.ITimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnableMagneticStoreWrites")]
        public virtual void ResetEnableMagneticStoreWrites()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMagneticStoreRejectedDataLocation")]
        public virtual void ResetMagneticStoreRejectedDataLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "magneticStoreRejectedDataLocation", typeJson: "{\"fqn\":\"aws.timestreamwrite.TimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocationOutputReference\"}")]
        public virtual aws.Timestreamwrite.TimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocationOutputReference MagneticStoreRejectedDataLocation
        {
            get => GetInstanceProperty<aws.Timestreamwrite.TimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableMagneticStoreWritesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableMagneticStoreWritesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "magneticStoreRejectedDataLocationInput", typeJson: "{\"fqn\":\"aws.timestreamwrite.TimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocation\"}", isOptional: true)]
        public virtual aws.Timestreamwrite.ITimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocation? MagneticStoreRejectedDataLocationInput
        {
            get => GetInstanceProperty<aws.Timestreamwrite.ITimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocation?>();
        }

        [JsiiProperty(name: "enableMagneticStoreWrites", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableMagneticStoreWrites
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.timestreamwrite.TimestreamwriteTableMagneticStoreWriteProperties\"}", isOptional: true)]
        public virtual aws.Timestreamwrite.ITimestreamwriteTableMagneticStoreWriteProperties? InternalValue
        {
            get => GetInstanceProperty<aws.Timestreamwrite.ITimestreamwriteTableMagneticStoreWriteProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
