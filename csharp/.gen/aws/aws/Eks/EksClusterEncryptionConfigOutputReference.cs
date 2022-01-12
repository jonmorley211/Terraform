using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    [JsiiClass(nativeType: typeof(aws.Eks.EksClusterEncryptionConfigOutputReference), fullyQualifiedName: "aws.eks.EksClusterEncryptionConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EksClusterEncryptionConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public EksClusterEncryptionConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksClusterEncryptionConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksClusterEncryptionConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putProvider", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eks.EksClusterEncryptionConfigProvider\"}}]")]
        public virtual void PutProvider(aws.Eks.IEksClusterEncryptionConfigProvider @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eks.IEksClusterEncryptionConfigProvider)}, new object[]{@value});
        }

        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"aws.eks.EksClusterEncryptionConfigProviderOutputReference\"}")]
        public virtual aws.Eks.EksClusterEncryptionConfigProviderOutputReference Provider
        {
            get => GetInstanceProperty<aws.Eks.EksClusterEncryptionConfigProviderOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "providerInput", typeJson: "{\"fqn\":\"aws.eks.EksClusterEncryptionConfigProvider\"}", isOptional: true)]
        public virtual aws.Eks.IEksClusterEncryptionConfigProvider? ProviderInput
        {
            get => GetInstanceProperty<aws.Eks.IEksClusterEncryptionConfigProvider?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ResourcesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Resources
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eks.EksClusterEncryptionConfig\"}", isOptional: true)]
        public virtual aws.Eks.IEksClusterEncryptionConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Eks.IEksClusterEncryptionConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
