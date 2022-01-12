using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerFeatureGroupOnlineStoreConfigOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerFeatureGroupOnlineStoreConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerFeatureGroupOnlineStoreConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerFeatureGroupOnlineStoreConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerFeatureGroupOnlineStoreConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerFeatureGroupOnlineStoreConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSecurityConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOnlineStoreConfigSecurityConfig\"}}]")]
        public virtual void PutSecurityConfig(aws.Sagemaker.ISagemakerFeatureGroupOnlineStoreConfigSecurityConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerFeatureGroupOnlineStoreConfigSecurityConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnableOnlineStore")]
        public virtual void ResetEnableOnlineStore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityConfig")]
        public virtual void ResetSecurityConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "securityConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOnlineStoreConfigSecurityConfigOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerFeatureGroupOnlineStoreConfigSecurityConfigOutputReference SecurityConfig
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerFeatureGroupOnlineStoreConfigSecurityConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableOnlineStoreInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableOnlineStoreInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityConfigInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOnlineStoreConfigSecurityConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerFeatureGroupOnlineStoreConfigSecurityConfig? SecurityConfigInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerFeatureGroupOnlineStoreConfigSecurityConfig?>();
        }

        [JsiiProperty(name: "enableOnlineStore", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableOnlineStore
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOnlineStoreConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerFeatureGroupOnlineStoreConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerFeatureGroupOnlineStoreConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
