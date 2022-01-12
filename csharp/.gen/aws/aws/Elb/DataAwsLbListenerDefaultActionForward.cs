using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiClass(nativeType: typeof(aws.Elb.DataAwsLbListenerDefaultActionForward), fullyQualifiedName: "aws.elb.DataAwsLbListenerDefaultActionForward", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsLbListenerDefaultActionForward : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsLbListenerDefaultActionForward(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLbListenerDefaultActionForward(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLbListenerDefaultActionForward(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "stickiness", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Stickiness
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "targetGroup", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object TargetGroup
        {
            get => GetInstanceProperty<object>()!;
        }
    }
}
