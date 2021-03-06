using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    [JsiiClass(nativeType: typeof(aws.Config.ConfigRemediationConfigurationExecutionControlsSsmControlsOutputReference), fullyQualifiedName: "aws.config.ConfigRemediationConfigurationExecutionControlsSsmControlsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ConfigRemediationConfigurationExecutionControlsSsmControlsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public ConfigRemediationConfigurationExecutionControlsSsmControlsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigRemediationConfigurationExecutionControlsSsmControlsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigRemediationConfigurationExecutionControlsSsmControlsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetConcurrentExecutionRatePercentage")]
        public virtual void ResetConcurrentExecutionRatePercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetErrorPercentage")]
        public virtual void ResetErrorPercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "concurrentExecutionRatePercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConcurrentExecutionRatePercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorPercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ErrorPercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "concurrentExecutionRatePercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConcurrentExecutionRatePercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "errorPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ErrorPercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.config.ConfigRemediationConfigurationExecutionControlsSsmControls\"}", isOptional: true)]
        public virtual aws.Config.IConfigRemediationConfigurationExecutionControlsSsmControls? InternalValue
        {
            get => GetInstanceProperty<aws.Config.IConfigRemediationConfigurationExecutionControlsSsmControls?>();
            set => SetInstanceProperty(value);
        }
    }
}
