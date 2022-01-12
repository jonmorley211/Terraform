using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apprunner
{
    [JsiiClass(nativeType: typeof(aws.Apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationOutputReference), fullyQualifiedName: "aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCodeConfigurationValues", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues\"}}]")]
        public virtual void PutCodeConfigurationValues(aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCodeConfigurationValues")]
        public virtual void ResetCodeConfigurationValues()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "codeConfigurationValues", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValuesOutputReference\"}")]
        public virtual aws.Apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValuesOutputReference CodeConfigurationValues
        {
            get => GetInstanceProperty<aws.Apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValuesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeConfigurationValuesInput", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues\"}", isOptional: true)]
        public virtual aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues? CodeConfigurationValuesInput
        {
            get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigurationSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "configurationSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationSource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration\"}", isOptional: true)]
        public virtual aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
