using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    [JsiiClass(nativeType: typeof(aws.Eks.EksNodeGroupUpdateConfigOutputReference), fullyQualifiedName: "aws.eks.EksNodeGroupUpdateConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EksNodeGroupUpdateConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public EksNodeGroupUpdateConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksNodeGroupUpdateConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksNodeGroupUpdateConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaxUnavailable")]
        public virtual void ResetMaxUnavailable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxUnavailablePercentage")]
        public virtual void ResetMaxUnavailablePercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxUnavailableInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxUnavailableInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxUnavailablePercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxUnavailablePercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maxUnavailable", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxUnavailable
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxUnavailablePercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxUnavailablePercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eks.EksNodeGroupUpdateConfig\"}", isOptional: true)]
        public virtual aws.Eks.IEksNodeGroupUpdateConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Eks.IEksNodeGroupUpdateConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
