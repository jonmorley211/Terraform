using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiClass(nativeType: typeof(aws.Ec2.Ec2FleetSpotOptionsMaintenanceStrategiesOutputReference), fullyQualifiedName: "aws.ec2.Ec2FleetSpotOptionsMaintenanceStrategiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Ec2FleetSpotOptionsMaintenanceStrategiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Ec2FleetSpotOptionsMaintenanceStrategiesOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2FleetSpotOptionsMaintenanceStrategiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2FleetSpotOptionsMaintenanceStrategiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCapacityRebalance", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance\"}}]")]
        public virtual void PutCapacityRebalance(aws.Ec2.IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCapacityRebalance")]
        public virtual void ResetCapacityRebalance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "capacityRebalance", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalanceOutputReference\"}")]
        public virtual aws.Ec2.Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalanceOutputReference CapacityRebalance
        {
            get => GetInstanceProperty<aws.Ec2.Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalanceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityRebalanceInput", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance\"}", isOptional: true)]
        public virtual aws.Ec2.IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance? CapacityRebalanceInput
        {
            get => GetInstanceProperty<aws.Ec2.IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetSpotOptionsMaintenanceStrategies\"}", isOptional: true)]
        public virtual aws.Ec2.IEc2FleetSpotOptionsMaintenanceStrategies? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2.IEc2FleetSpotOptionsMaintenanceStrategies?>();
            set => SetInstanceProperty(value);
        }
    }
}
