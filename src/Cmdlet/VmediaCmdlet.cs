using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set VmediaPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVmediaPolicy")]
    public class SetIntersightVmediaPolicy:SetCmdletBase
	{
		public SetIntersightVmediaPolicy()
		{
			ApiInstance = new VmediaApi(Config);
            ModelObject = new VmediaPolicy();
            MethodName = "UpdateVmediaPolicy";
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
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"State of the Virtual Media service on the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, allows encryption of all Virtual Media communications."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Encryption {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, the virtual drives appear on the boot selection menu after mapping the image and rebooting the host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool LowPowerUsb {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<VmediaMapping> Mappings {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractConfigProfileRelationship> Profiles {
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
    /// <para type="synopsis">This is the cmdlet to Remove VmediaPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightVmediaPolicy")]
    public class RemoveIntersightVmediaPolicy:RemoveCmdletBase
	{
		public RemoveIntersightVmediaPolicy()
		{
			ApiInstance = new VmediaApi(Config);
            MethodName = "DeleteVmediaPolicy";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New VmediaPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightVmediaPolicy")]
    public class NewIntersightVmediaPolicy:NewCmdletBase
	{
		public NewIntersightVmediaPolicy()
		{
			ApiInstance = new VmediaApi(Config);
            ModelObject = new VmediaPolicy();
            MethodName = "CreateVmediaPolicy";
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
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"State of the Virtual Media service on the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, allows encryption of all Virtual Media communications."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Encryption {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, the virtual drives appear on the boot selection menu after mapping the image and rebooting the host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool LowPowerUsb {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<VmediaMapping> Mappings {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractConfigProfileRelationship> Profiles {
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
    /// <para type="synopsis">This is the cmdlet to Get VmediaPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVmediaPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVmediaPolicy:GetCmdletBase
	{
		public GetIntersightVmediaPolicy()
		{
			ApiInstance = new VmediaApi(Config);
            MethodName = "GetVmediaPolicyList";
		}
    }
}