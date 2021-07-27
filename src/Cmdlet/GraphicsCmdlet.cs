using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get GraphicsCard.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightGraphicsCard", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightGraphicsCard:GetCmdletBase
	{
		public GetIntersightGraphicsCard()
		{
			ApiInstance = new GraphicsApi(Config);
            MethodName = "GetGraphicsCardList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set GraphicsCard.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightGraphicsCard")]
    public class SetIntersightGraphicsCard:SetCmdletBase
	{
		public SetIntersightGraphicsCard()
		{
			ApiInstance = new GraphicsApi(Config);
            ModelObject = new GraphicsCard();
            MethodName = "UpdateGraphicsCard";
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
        /// <para type="description">"A reference to a computeBlade resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeBladeRelationship ComputeBlade {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computeRackUnit resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeRackUnitRelationship ComputeRackUnit {
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
        /// <para type="description">"The number of controllers under each card."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NumGpus {
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
    /// <para type="synopsis">This is the cmdlet to Get GraphicsController.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightGraphicsController", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightGraphicsController:GetCmdletBase
	{
		public GetIntersightGraphicsController()
		{
			ApiInstance = new GraphicsApi(Config);
            MethodName = "GetGraphicsControllerList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set GraphicsController.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightGraphicsController")]
    public class SetIntersightGraphicsController:SetCmdletBase
	{
		public SetIntersightGraphicsController()
		{
			ApiInstance = new GraphicsApi(Config);
            ModelObject = new GraphicsController();
            MethodName = "UpdateGraphicsController";
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