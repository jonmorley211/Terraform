using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apprunner
{
    [JsiiClass(nativeType: typeof(aws.Apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryOutputReference), fullyQualifiedName: "aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ApprunnerServiceSourceConfigurationCodeRepositoryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public ApprunnerServiceSourceConfigurationCodeRepositoryOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApprunnerServiceSourceConfigurationCodeRepositoryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApprunnerServiceSourceConfigurationCodeRepositoryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCodeConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration\"}}]")]
        public virtual void PutCodeConfiguration(aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceCodeVersion", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion\"}}]")]
        public virtual void PutSourceCodeVersion(aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCodeConfiguration")]
        public virtual void ResetCodeConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "codeConfiguration", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationOutputReference\"}")]
        public virtual aws.Apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationOutputReference CodeConfiguration
        {
            get => GetInstanceProperty<aws.Apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "sourceCodeVersion", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersionOutputReference\"}")]
        public virtual aws.Apprunner.ApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersionOutputReference SourceCodeVersion
        {
            get => GetInstanceProperty<aws.Apprunner.ApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeConfigurationInput", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration\"}", isOptional: true)]
        public virtual aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration? CodeConfigurationInput
        {
            get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceCodeVersionInput", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion\"}", isOptional: true)]
        public virtual aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion? SourceCodeVersionInput
        {
            get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion?>();
        }

        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepository\"}", isOptional: true)]
        public virtual aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepository? InternalValue
        {
            get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepository?>();
            set => SetInstanceProperty(value);
        }
    }
}
