using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    [JsiiClass(nativeType: typeof(aws.Fsx.FsxOntapFileSystemEndpoints), fullyQualifiedName: "aws.fsx.FsxOntapFileSystemEndpoints", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FsxOntapFileSystemEndpoints : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public FsxOntapFileSystemEndpoints(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOntapFileSystemEndpoints(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOntapFileSystemEndpoints(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "intercluster", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Intercluster
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "management", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Management
        {
            get => GetInstanceProperty<object>()!;
        }
    }
}
