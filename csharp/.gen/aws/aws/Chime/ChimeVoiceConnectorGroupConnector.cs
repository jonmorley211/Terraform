using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Chime
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.chime.ChimeVoiceConnectorGroupConnector")]
    public class ChimeVoiceConnectorGroupConnector : aws.Chime.IChimeVoiceConnectorGroupConnector
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/chime_voice_connector_group#priority ChimeVoiceConnectorGroup#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Priority
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/chime_voice_connector_group#voice_connector_id ChimeVoiceConnectorGroup#voice_connector_id}.</summary>
        [JsiiProperty(name: "voiceConnectorId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string VoiceConnectorId
        {
            get;
            set;
        }
    }
}
