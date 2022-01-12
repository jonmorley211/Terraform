using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiClass(nativeType: typeof(aws.Ec2.SpotInstanceRequestCapacityReservationSpecificationOutputReference), fullyQualifiedName: "aws.ec2.SpotInstanceRequestCapacityReservationSpecificationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SpotInstanceRequestCapacityReservationSpecificationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SpotInstanceRequestCapacityReservationSpecificationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpotInstanceRequestCapacityReservationSpecificationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpotInstanceRequestCapacityReservationSpecificationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCapacityReservationTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.SpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget\"}}]")]
        public virtual void PutCapacityReservationTarget(aws.Ec2.ISpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.ISpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCapacityReservationPreference")]
        public virtual void ResetCapacityReservationPreference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapacityReservationTarget")]
        public virtual void ResetCapacityReservationTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "capacityReservationTarget", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestCapacityReservationSpecificationCapacityReservationTargetOutputReference\"}")]
        public virtual aws.Ec2.SpotInstanceRequestCapacityReservationSpecificationCapacityReservationTargetOutputReference CapacityReservationTarget
        {
            get => GetInstanceProperty<aws.Ec2.SpotInstanceRequestCapacityReservationSpecificationCapacityReservationTargetOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationPreferenceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityReservationPreferenceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationTargetInput", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget\"}", isOptional: true)]
        public virtual aws.Ec2.ISpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTargetInput
        {
            get => GetInstanceProperty<aws.Ec2.ISpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget?>();
        }

        [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityReservationPreference
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestCapacityReservationSpecification\"}", isOptional: true)]
        public virtual aws.Ec2.ISpotInstanceRequestCapacityReservationSpecification? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2.ISpotInstanceRequestCapacityReservationSpecification?>();
            set => SetInstanceProperty(value);
        }
    }
}
