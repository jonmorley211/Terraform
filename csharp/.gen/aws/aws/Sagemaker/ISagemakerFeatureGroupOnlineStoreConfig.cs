using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerFeatureGroupOnlineStoreConfig), fullyQualifiedName: "aws.sagemaker.SagemakerFeatureGroupOnlineStoreConfig")]
    public interface ISagemakerFeatureGroupOnlineStoreConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#enable_online_store SagemakerFeatureGroup#enable_online_store}.</summary>
        [JsiiProperty(name: "enableOnlineStore", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableOnlineStore
        {
            get
            {
                return null;
            }
        }

        /// <summary>security_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#security_config SagemakerFeatureGroup#security_config}
        /// </remarks>
        [JsiiProperty(name: "securityConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOnlineStoreConfigSecurityConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerFeatureGroupOnlineStoreConfigSecurityConfig? SecurityConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerFeatureGroupOnlineStoreConfig), fullyQualifiedName: "aws.sagemaker.SagemakerFeatureGroupOnlineStoreConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerFeatureGroupOnlineStoreConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#enable_online_store SagemakerFeatureGroup#enable_online_store}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableOnlineStore", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableOnlineStore
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>security_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group#security_config SagemakerFeatureGroup#security_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "securityConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOnlineStoreConfigSecurityConfig\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerFeatureGroupOnlineStoreConfigSecurityConfig? SecurityConfig
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerFeatureGroupOnlineStoreConfigSecurityConfig?>();
            }
        }
    }
}
