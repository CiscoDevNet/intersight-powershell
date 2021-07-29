using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get VrfVrf.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVrfVrf", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVrfVrf:GetCmdletBase
	{
		public GetIntersightVrfVrf()
		{
			ApiInstance = new VrfApi(Config);
            MethodName = "GetVrfVrfList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New VrfVrf.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightVrfVrf")]
    public class NewIntersightVrfVrf:NewCmdletBase
	{
		public NewIntersightVrfVrf()
		{
			ApiInstance = new VrfApi(Config);
            ModelObject = new VrfVrf();
            MethodName = "CreateVrfVrf";
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
        /// <para type="description">"Description to help identify or describe this VRF."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
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
        /// <para type="description">"Name of the Virtual Routing and Forwarding Instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
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
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set VrfVrf.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVrfVrf")]
    public class SetIntersightVrfVrf:SetCmdletBase
	{
		public SetIntersightVrfVrf()
		{
			ApiInstance = new VrfApi(Config);
            ModelObject = new VrfVrf();
            MethodName = "UpdateVrfVrf";
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
        /// <para type="description">"Description to help identify or describe this VRF."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
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
        /// <para type="description">"Name of the Virtual Routing and Forwarding Instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
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
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove VrfVrf.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightVrfVrf")]
    public class RemoveIntersightVrfVrf:RemoveCmdletBase
	{
		public RemoveIntersightVrfVrf()
		{
			ApiInstance = new VrfApi(Config);
            MethodName = "DeleteVrfVrf";
		}
    }
}