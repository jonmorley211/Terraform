using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apprunner
{
    [JsiiClass(nativeType: typeof(aws.Apprunner.ApprunnerServiceSourceConfigurationOutputReference), fullyQualifiedName: "aws.apprunner.ApprunnerServiceSourceConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ApprunnerServiceSourceConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public ApprunnerServiceSourceConfigurationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApprunnerServiceSourceConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApprunnerServiceSourceConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuthenticationConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationAuthenticationConfiguration\"}}]")]
        public virtual void PutAuthenticationConfiguration(aws.Apprunner.IApprunnerServiceSourceConfigurationAuthenticationConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apprunner.IApprunnerServiceSourceConfigurationAuthenticationConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCodeRepository", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepository\"}}]")]
        public virtual void PutCodeRepository(aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepository @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepository)}, new object[]{@value});
        }

        [JsiiMethod(name: "putImageRepository", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationImageRepository\"}}]")]
        public virtual void PutImageRepository(aws.Apprunner.IApprunnerServiceSourceConfigurationImageRepository @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apprunner.IApprunnerServiceSourceConfigurationImageRepository)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthenticationConfiguration")]
        public virtual void ResetAuthenticationConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoDeploymentsEnabled")]
        public virtual void ResetAutoDeploymentsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCodeRepository")]
        public virtual void ResetCodeRepository()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageRepository")]
        public virtual void ResetImageRepository()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "authenticationConfiguration", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationAuthenticationConfigurationOutputReference\"}")]
        public virtual aws.Apprunner.ApprunnerServiceSourceConfigurationAuthenticationConfigurationOutputReference AuthenticationConfiguration
        {
            get => GetInstanceProperty<aws.Apprunner.ApprunnerServiceSourceConfigurationAuthenticationConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "codeRepository", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryOutputReference\"}")]
        public virtual aws.Apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryOutputReference CodeRepository
        {
            get => GetInstanceProperty<aws.Apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryOutputReference>()!;
        }

        [JsiiProperty(name: "imageRepository", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationImageRepositoryOutputReference\"}")]
        public virtual aws.Apprunner.ApprunnerServiceSourceConfigurationImageRepositoryOutputReference ImageRepository
        {
            get => GetInstanceProperty<aws.Apprunner.ApprunnerServiceSourceConfigurationImageRepositoryOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationConfigurationInput", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationAuthenticationConfiguration\"}", isOptional: true)]
        public virtual aws.Apprunner.IApprunnerServiceSourceConfigurationAuthenticationConfiguration? AuthenticationConfigurationInput
        {
            get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceSourceConfigurationAuthenticationConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoDeploymentsEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutoDeploymentsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeRepositoryInput", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepository\"}", isOptional: true)]
        public virtual aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepository? CodeRepositoryInput
        {
            get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepository?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageRepositoryInput", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationImageRepository\"}", isOptional: true)]
        public virtual aws.Apprunner.IApprunnerServiceSourceConfigurationImageRepository? ImageRepositoryInput
        {
            get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceSourceConfigurationImageRepository?>();
        }

        [JsiiProperty(name: "autoDeploymentsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AutoDeploymentsEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfiguration\"}", isOptional: true)]
        public virtual aws.Apprunner.IApprunnerServiceSourceConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceSourceConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
