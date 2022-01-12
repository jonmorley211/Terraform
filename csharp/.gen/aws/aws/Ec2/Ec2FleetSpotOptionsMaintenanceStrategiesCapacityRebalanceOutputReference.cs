using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiClass(nativeType: typeof(aws.Ec2.Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalanceOutputReference), fullyQualifiedName: "aws.ec2.Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalanceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalanceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalanceOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalanceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalanceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetReplacementStrategy")]
        public virtual void ResetReplacementStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "replacementStrategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplacementStrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "replacementStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplacementStrategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance\"}", isOptional: true)]
        public virtual aws.Ec2.IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2.IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance?>();
            set => SetInstanceProperty(value);
        }
    }
}
