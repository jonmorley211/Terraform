using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Servicecatalog
{
    [JsiiClass(nativeType: typeof(aws.Servicecatalog.DataAwsServicecatalogLaunchPathsSummaries), fullyQualifiedName: "aws.servicecatalog.DataAwsServicecatalogLaunchPathsSummaries", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsServicecatalogLaunchPathsSummaries : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsServicecatalogLaunchPathsSummaries(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsServicecatalogLaunchPathsSummaries(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsServicecatalogLaunchPathsSummaries(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "constraintSummaries", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ConstraintSummaries
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pathId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PathId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Tags
        {
            get => GetInstanceProperty<object>()!;
        }
    }
}
