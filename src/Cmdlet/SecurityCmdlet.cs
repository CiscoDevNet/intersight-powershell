using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SecurityUnit.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSecurityUnit", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSecurityUnit:GetCmdletBase
	{
		public GetIntersightSecurityUnit()
		{
			ApiInstance = new SecurityApi(Config);
            MethodName = "GetSecurityUnitList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set SecurityUnit.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightSecurityUnit")]
    public class SetIntersightSecurityUnit:SetCmdletBase
	{
		public SetIntersightSecurityUnit()
		{
			ApiInstance = new SecurityApi(Config);
            ModelObject = new SecurityUnit();
            MethodName = "UpdateSecurityUnit";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFruRelationship PreviousFru {
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
    }
}