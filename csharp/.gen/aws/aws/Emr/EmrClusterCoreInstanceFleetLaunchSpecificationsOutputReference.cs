using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiClass(nativeType: typeof(aws.Emr.EmrClusterCoreInstanceFleetLaunchSpecificationsOutputReference), fullyQualifiedName: "aws.emr.EmrClusterCoreInstanceFleetLaunchSpecificationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EmrClusterCoreInstanceFleetLaunchSpecificationsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public EmrClusterCoreInstanceFleetLaunchSpecificationsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrClusterCoreInstanceFleetLaunchSpecificationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrClusterCoreInstanceFleetLaunchSpecificationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetOnDemandSpecification")]
        public virtual void ResetOnDemandSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotSpecification")]
        public virtual void ResetSpotSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "onDemandSpecificationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification[]? OnDemandSpecificationInput
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotSpecificationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification[]? SpotSpecificationInput
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification[]?>();
        }

        [JsiiProperty(name: "onDemandSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification\"},\"kind\":\"array\"}}")]
        public virtual aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification[] OnDemandSpecification
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spotSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification\"},\"kind\":\"array\"}}")]
        public virtual aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification[] SpotSpecification
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetLaunchSpecifications\"}", isOptional: true)]
        public virtual aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecifications? InternalValue
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecifications?>();
            set => SetInstanceProperty(value);
        }
    }
}
