using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get PciDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightPciDevice", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightPciDevice:GetCmdletBase
	{
		public GetIntersightPciDevice()
		{
			ApiInstance = new PciApi(Config);
            MethodName = "GetPciDeviceList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set PciDevice.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightPciDevice")]
    public class SetIntersightPciDevice:SetCmdletBase
	{
		public SetIntersightPciDevice()
		{
			ApiInstance = new PciApi(Config);
            ModelObject = new PciDevice();
            MethodName = "UpdatePciDevice";
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
        /// <para type="description">"The running firmware version of the PCI device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FirmwareVersion {
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
        /// <para type="description">"The product identifier of the PCI device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Pid {
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
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set PciLink.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightPciLink")]
    public class SetIntersightPciLink:SetCmdletBase
	{
		public SetIntersightPciLink()
		{
			ApiInstance = new PciApi(Config);
            ModelObject = new PciLink();
            MethodName = "UpdatePciLink";
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
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set PciSwitch.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightPciSwitch")]
    public class SetIntersightPciSwitch:SetCmdletBase
	{
		public SetIntersightPciSwitch()
		{
			ApiInstance = new PciApi(Config);
            ModelObject = new PciSwitch();
            MethodName = "UpdatePciSwitch";
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
        // <summary>
        /// <para type="description">"The type information of the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get PciCoprocessorCard.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightPciCoprocessorCard", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightPciCoprocessorCard:GetCmdletBase
	{
		public GetIntersightPciCoprocessorCard()
		{
			ApiInstance = new PciApi(Config);
            MethodName = "GetPciCoprocessorCardList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get PciLink.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightPciLink", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightPciLink:GetCmdletBase
	{
		public GetIntersightPciLink()
		{
			ApiInstance = new PciApi(Config);
            MethodName = "GetPciLinkList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get PciSwitch.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightPciSwitch", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightPciSwitch:GetCmdletBase
	{
		public GetIntersightPciSwitch()
		{
			ApiInstance = new PciApi(Config);
            MethodName = "GetPciSwitchList";
		}
    }
}