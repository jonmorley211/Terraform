using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    [JsiiClass(nativeType: typeof(aws.Macie2.Macie2ClassificationJobUserPausedDetails), fullyQualifiedName: "aws.macie2.Macie2ClassificationJobUserPausedDetails", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Macie2ClassificationJobUserPausedDetails : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public Macie2ClassificationJobUserPausedDetails(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2ClassificationJobUserPausedDetails(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2ClassificationJobUserPausedDetails(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "jobExpiresAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobExpiresAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobImminentExpirationHealthEventArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobImminentExpirationHealthEventArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobPausedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobPausedAt
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
