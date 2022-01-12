using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiClass(nativeType: typeof(aws.Ec2.Ec2FleetLaunchTemplateConfigOutputReference), fullyQualifiedName: "aws.ec2.Ec2FleetLaunchTemplateConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Ec2FleetLaunchTemplateConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Ec2FleetLaunchTemplateConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2FleetLaunchTemplateConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2FleetLaunchTemplateConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLaunchTemplateSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.Ec2FleetLaunchTemplateConfigLaunchTemplateSpecification\"}}]")]
        public virtual void PutLaunchTemplateSpecification(aws.Ec2.IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetOverride")]
        public virtual void ResetOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetLaunchTemplateConfigLaunchTemplateSpecificationOutputReference\"}")]
        public virtual aws.Ec2.Ec2FleetLaunchTemplateConfigLaunchTemplateSpecificationOutputReference LaunchTemplateSpecification
        {
            get => GetInstanceProperty<aws.Ec2.Ec2FleetLaunchTemplateConfigLaunchTemplateSpecificationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateSpecificationInput", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetLaunchTemplateConfigLaunchTemplateSpecification\"}", isOptional: true)]
        public virtual aws.Ec2.IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification? LaunchTemplateSpecificationInput
        {
            get => GetInstanceProperty<aws.Ec2.IEc2FleetLaunchTemplateConfigLaunchTemplateSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "overrideInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.Ec2FleetLaunchTemplateConfigOverride\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ec2.IEc2FleetLaunchTemplateConfigOverride[]? OverrideInput
        {
            get => GetInstanceProperty<aws.Ec2.IEc2FleetLaunchTemplateConfigOverride[]?>();
        }

        [JsiiProperty(name: "override", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.Ec2FleetLaunchTemplateConfigOverride\"},\"kind\":\"array\"}}")]
        public virtual aws.Ec2.IEc2FleetLaunchTemplateConfigOverride[] Override
        {
            get => GetInstanceProperty<aws.Ec2.IEc2FleetLaunchTemplateConfigOverride[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetLaunchTemplateConfig\"}", isOptional: true)]
        public virtual aws.Ec2.IEc2FleetLaunchTemplateConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2.IEc2FleetLaunchTemplateConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
