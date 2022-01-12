using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Signer
{
    [JsiiClass(nativeType: typeof(aws.Signer.SignerSigningProfileRevocationRecord), fullyQualifiedName: "aws.signer.SignerSigningProfileRevocationRecord", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SignerSigningProfileRevocationRecord : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public SignerSigningProfileRevocationRecord(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SignerSigningProfileRevocationRecord(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SignerSigningProfileRevocationRecord(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "revocationEffectiveFrom", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RevocationEffectiveFrom
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "revokedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RevokedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "revokedBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RevokedBy
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
