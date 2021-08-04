using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ExternalsiteAuthorization.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightExternalsiteAuthorization", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightExternalsiteAuthorization:GetCmdletBase
	{
		public GetIntersightExternalsiteAuthorization()
		{
			ApiInstance = new ExternalsiteApi(Config);
            MethodName = "GetExternalsiteAuthorizationListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New ExternalsiteAuthorization.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightExternalsiteAuthorization")]
    public class NewIntersightExternalsiteAuthorization:NewCmdletBase
	{
		public NewIntersightExternalsiteAuthorization()
		{
			ApiInstance = new ExternalsiteApi(Config);
            ModelObject = new ExternalsiteAuthorization();
            MethodName = "CreateExternalsiteAuthorizationWithHttpInfo";
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The password of the given username to download the image from external repository like cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The repository type to which this authorization will be requested. Cisco is the only available repository today.\n* `cisco` - Cisco as an external site from where the resources like image will be downloaded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ExternalsiteAuthorization.RepositoryTypeEnum RepositoryType {
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
        /// <para type="description">"The username that has permission to download the image from external repository like cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UserId {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ExternalsiteAuthorization.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightExternalsiteAuthorization")]
    public class SetIntersightExternalsiteAuthorization:SetCmdletBase
	{
		public SetIntersightExternalsiteAuthorization()
		{
			ApiInstance = new ExternalsiteApi(Config);
            ModelObject = new ExternalsiteAuthorization();
            MethodName = "UpdateExternalsiteAuthorizationWithHttpInfo";
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
        /// <para type="description">"The password of the given username to download the image from external repository like cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The repository type to which this authorization will be requested. Cisco is the only available repository today.\n* `cisco` - Cisco as an external site from where the resources like image will be downloaded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ExternalsiteAuthorization.RepositoryTypeEnum RepositoryType {
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
        /// <para type="description">"The username that has permission to download the image from external repository like cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UserId {
            get;
            set;
        }
    }
}