using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ConnectorpackUpgradeImpact.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightConnectorpackUpgradeImpact", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightConnectorpackUpgradeImpact:GetCmdletBase
	{
		public GetIntersightConnectorpackUpgradeImpact()
		{
			ApiInstance = new ConnectorpackApi(Config);
            MethodName = "GetConnectorpackUpgradeImpactListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove ConnectorpackConnectorPackUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightConnectorpackConnectorPackUpgrade")]
    public class RemoveIntersightConnectorpackConnectorPackUpgrade:RemoveCmdletBase
	{
		public RemoveIntersightConnectorpackConnectorPackUpgrade()
		{
			ApiInstance = new ConnectorpackApi(Config);
            MethodName = "DeleteConnectorpackConnectorPackUpgradeWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ConnectorpackConnectorPackUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightConnectorpackConnectorPackUpgrade", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightConnectorpackConnectorPackUpgrade:GetCmdletBase
	{
		public GetIntersightConnectorpackConnectorPackUpgrade()
		{
			ApiInstance = new ConnectorpackApi(Config);
            MethodName = "GetConnectorpackConnectorPackUpgradeListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New ConnectorpackConnectorPackUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightConnectorpackConnectorPackUpgrade")]
    public class NewIntersightConnectorpackConnectorPackUpgrade:NewCmdletBase
	{
		public NewIntersightConnectorpackConnectorPackUpgrade()
		{
			ApiInstance = new ConnectorpackApi(Config);
            ModelObject = new ConnectorpackConnectorPackUpgrade();
            MethodName = "CreateConnectorpackConnectorPackUpgradeWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of operation to be performed on UCS Director.\n* `Install` - Installs the requisite connector packs on UCS Director.\n* `Push` - Pushes the requisite connector packs to UCS Director."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ConnectorpackConnectorPackUpgrade.ConnectorPackOpTypeEnum ConnectorPackOpType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iaasUcsdInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IaasUcsdInfoRelationship UcsdInfo {
            get;
            set;
        }
    }
}