using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get CrdCustomResource.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightCrdCustomResource", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightCrdCustomResource:GetCmdletBase
	{
		public GetIntersightCrdCustomResource()
		{
			ApiInstance = new CrdApi(Config);
            MethodName = "GetCrdCustomResourceList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New CrdCustomResource.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightCrdCustomResource")]
    public class NewIntersightCrdCustomResource:NewCmdletBase
	{
		public NewIntersightCrdCustomResource()
		{
			ApiInstance = new CrdApi(Config);
            ModelObject = new CrdCustomResource();
            MethodName = "CreateCrdCustomResource";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
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
        /// <para type="description">"Type of custom resource or 'kind' in K8s."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DcLauncher {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Docker image URL for public cloud DC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Image {
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
        /// <para type="description">"A string property called name which is used as part of a uniqueness constraint. See 'identity' specification in this MO definition."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Namespace to launch the deployment associated with the custom resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Namespace {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port used for public cloud DC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Port {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CrdCustomResourceConfigProperty> Properties {
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
        /// <para type="description">"Target ID for public cloud DC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TargetId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Target Moid for public cloud DC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TargetMoid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Target type for public cloud DC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TargetType {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set CrdCustomResource.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightCrdCustomResource")]
    public class SetIntersightCrdCustomResource:SetCmdletBase
	{
		public SetIntersightCrdCustomResource()
		{
			ApiInstance = new CrdApi(Config);
            ModelObject = new CrdCustomResource();
            MethodName = "PatchCrdCustomResource";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
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
        /// <para type="description">"Type of custom resource or 'kind' in K8s."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DcLauncher {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Docker image URL for public cloud DC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Image {
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
        /// <para type="description">"A string property called name which is used as part of a uniqueness constraint. See 'identity' specification in this MO definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Namespace to launch the deployment associated with the custom resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Namespace {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port used for public cloud DC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Port {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CrdCustomResourceConfigProperty> Properties {
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
        /// <para type="description">"Target ID for public cloud DC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TargetId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Target Moid for public cloud DC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TargetMoid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Target type for public cloud DC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TargetType {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove CrdCustomResource.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightCrdCustomResource")]
    public class RemoveIntersightCrdCustomResource:RemoveCmdletBase
	{
		public RemoveIntersightCrdCustomResource()
		{
			ApiInstance = new CrdApi(Config);
            MethodName = "DeleteCrdCustomResource";
		}
    }
}