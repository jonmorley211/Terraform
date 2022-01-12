using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apprunner
{
    [JsiiClass(nativeType: typeof(aws.Apprunner.ApprunnerServiceSourceConfigurationImageRepositoryOutputReference), fullyQualifiedName: "aws.apprunner.ApprunnerServiceSourceConfigurationImageRepositoryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ApprunnerServiceSourceConfigurationImageRepositoryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public ApprunnerServiceSourceConfigurationImageRepositoryOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApprunnerServiceSourceConfigurationImageRepositoryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApprunnerServiceSourceConfigurationImageRepositoryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putImageConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration\"}}]")]
        public virtual void PutImageConfiguration(aws.Apprunner.IApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apprunner.IApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetImageConfiguration")]
        public virtual void ResetImageConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "imageConfiguration", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationImageRepositoryImageConfigurationOutputReference\"}")]
        public virtual aws.Apprunner.ApprunnerServiceSourceConfigurationImageRepositoryImageConfigurationOutputReference ImageConfiguration
        {
            get => GetInstanceProperty<aws.Apprunner.ApprunnerServiceSourceConfigurationImageRepositoryImageConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageConfigurationInput", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration\"}", isOptional: true)]
        public virtual aws.Apprunner.IApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration? ImageConfigurationInput
        {
            get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageRepositoryTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageRepositoryTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "imageIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageRepositoryType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageRepositoryType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationImageRepository\"}", isOptional: true)]
        public virtual aws.Apprunner.IApprunnerServiceSourceConfigurationImageRepository? InternalValue
        {
            get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceSourceConfigurationImageRepository?>();
            set => SetInstanceProperty(value);
        }
    }
}
