using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apprunner
{
    [JsiiClass(nativeType: typeof(aws.Apprunner.ApprunnerServiceSourceConfigurationImageRepositoryImageConfigurationOutputReference), fullyQualifiedName: "aws.apprunner.ApprunnerServiceSourceConfigurationImageRepositoryImageConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ApprunnerServiceSourceConfigurationImageRepositoryImageConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public ApprunnerServiceSourceConfigurationImageRepositoryImageConfigurationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApprunnerServiceSourceConfigurationImageRepositoryImageConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApprunnerServiceSourceConfigurationImageRepositoryImageConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetPort")]
        public virtual void ResetPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuntimeEnvironmentVariables")]
        public virtual void ResetRuntimeEnvironmentVariables()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartCommand")]
        public virtual void ResetStartCommand()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PortInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimeEnvironmentVariablesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? RuntimeEnvironmentVariablesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startCommandInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartCommandInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Port
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runtimeEnvironmentVariables", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object RuntimeEnvironmentVariables
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startCommand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartCommand
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration\"}", isOptional: true)]
        public virtual aws.Apprunner.IApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
