using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiClass(nativeType: typeof(aws.Kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationOutputReference), fullyQualifiedName: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApplicationRestoreConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationApplicationRestoreConfiguration\"}}]")]
        public virtual void PutApplicationRestoreConfiguration(aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationApplicationRestoreConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationApplicationRestoreConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFlinkRunConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfiguration\"}}]")]
        public virtual void PutFlinkRunConfiguration(aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApplicationRestoreConfiguration")]
        public virtual void ResetApplicationRestoreConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFlinkRunConfiguration")]
        public virtual void ResetFlinkRunConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "applicationRestoreConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationApplicationRestoreConfigurationOutputReference\"}")]
        public virtual aws.Kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationApplicationRestoreConfigurationOutputReference ApplicationRestoreConfiguration
        {
            get => GetInstanceProperty<aws.Kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationApplicationRestoreConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "flinkRunConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfigurationOutputReference\"}")]
        public virtual aws.Kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfigurationOutputReference FlinkRunConfiguration
        {
            get => GetInstanceProperty<aws.Kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationRestoreConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationApplicationRestoreConfiguration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationApplicationRestoreConfiguration? ApplicationRestoreConfigurationInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationApplicationRestoreConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "flinkRunConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfiguration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfiguration? FlinkRunConfigurationInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfiguration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
