using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiClass(nativeType: typeof(aws.Ec2.Ec2TrafficMirrorFilterRuleSourcePortRangeOutputReference), fullyQualifiedName: "aws.ec2.Ec2TrafficMirrorFilterRuleSourcePortRangeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Ec2TrafficMirrorFilterRuleSourcePortRangeOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Ec2TrafficMirrorFilterRuleSourcePortRangeOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2TrafficMirrorFilterRuleSourcePortRangeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2TrafficMirrorFilterRuleSourcePortRangeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFromPort")]
        public virtual void ResetFromPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetToPort")]
        public virtual void ResetToPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "fromPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FromPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "toPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ToPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FromPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ToPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2.Ec2TrafficMirrorFilterRuleSourcePortRange\"}", isOptional: true)]
        public virtual aws.Ec2.IEc2TrafficMirrorFilterRuleSourcePortRange? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2.IEc2TrafficMirrorFilterRuleSourcePortRange?>();
            set => SetInstanceProperty(value);
        }
    }
}
