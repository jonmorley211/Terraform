using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    [JsiiClass(nativeType: typeof(aws.Config.ConfigRemediationConfigurationExecutionControlsOutputReference), fullyQualifiedName: "aws.config.ConfigRemediationConfigurationExecutionControlsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ConfigRemediationConfigurationExecutionControlsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public ConfigRemediationConfigurationExecutionControlsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigRemediationConfigurationExecutionControlsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigRemediationConfigurationExecutionControlsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSsmControls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.config.ConfigRemediationConfigurationExecutionControlsSsmControls\"}}]")]
        public virtual void PutSsmControls(aws.Config.IConfigRemediationConfigurationExecutionControlsSsmControls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Config.IConfigRemediationConfigurationExecutionControlsSsmControls)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSsmControls")]
        public virtual void ResetSsmControls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "ssmControls", typeJson: "{\"fqn\":\"aws.config.ConfigRemediationConfigurationExecutionControlsSsmControlsOutputReference\"}")]
        public virtual aws.Config.ConfigRemediationConfigurationExecutionControlsSsmControlsOutputReference SsmControls
        {
            get => GetInstanceProperty<aws.Config.ConfigRemediationConfigurationExecutionControlsSsmControlsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ssmControlsInput", typeJson: "{\"fqn\":\"aws.config.ConfigRemediationConfigurationExecutionControlsSsmControls\"}", isOptional: true)]
        public virtual aws.Config.IConfigRemediationConfigurationExecutionControlsSsmControls? SsmControlsInput
        {
            get => GetInstanceProperty<aws.Config.IConfigRemediationConfigurationExecutionControlsSsmControls?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.config.ConfigRemediationConfigurationExecutionControls\"}", isOptional: true)]
        public virtual aws.Config.IConfigRemediationConfigurationExecutionControls? InternalValue
        {
            get => GetInstanceProperty<aws.Config.IConfigRemediationConfigurationExecutionControls?>();
            set => SetInstanceProperty(value);
        }
    }
}
