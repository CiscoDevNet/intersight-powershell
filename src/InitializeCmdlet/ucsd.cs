using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize UcsdUcsdRestoreParameters.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightUcsdUcsdRestoreParameters")]
    public class InitializeIntersightUcsdUcsdRestoreParameters:PSCmdlet
	{
		public InitializeIntersightUcsdUcsdRestoreParameters()
		{
            ClassId = UcsdUcsdRestoreParameters.ClassIdEnum.UcsdUcsdRestoreParameters;
            ObjectType = UcsdUcsdRestoreParameters.ObjectTypeEnum.UcsdUcsdRestoreParameters;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public UcsdUcsdRestoreParameters.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The complete location of the path on the server. The location should be specified in the following format- hostname-or-ipv4address<:port>/absolute-file-path."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Location {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public UcsdUcsdRestoreParameters.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The password of the target backup server. Only required if the target server is accessed using SFTP or SCP protocol."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The protocol used to backup the UCS Director."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Protocol {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Decides whether UCS Director property files should also be restored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool RestoreConfigurationFiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Decides whether license should also be restored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool RestoreLicense {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The username of the target backup server. Only required if the target server is accessed using SFTP or SCP protocol."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Username {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.UcsdUcsdRestoreParameters initObject = new Intersight.Model.UcsdUcsdRestoreParameters();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Location"))
            {
                initObject.Location = this.Location;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Protocol"))
            {
                initObject.Protocol = this.Protocol;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RestoreConfigurationFiles"))
            {
                initObject.RestoreConfigurationFiles = this.RestoreConfigurationFiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RestoreLicense"))
            {
                initObject.RestoreLicense = this.RestoreLicense;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Username"))
            {
                initObject.Username = this.Username;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize UcsdConnectorPack.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightUcsdConnectorPack")]
    public class InitializeIntersightUcsdConnectorPack:PSCmdlet
	{
		public InitializeIntersightUcsdConnectorPack()
		{
            ClassId = UcsdConnectorPack.ClassIdEnum.UcsdConnectorPack;
            ObjectType = UcsdConnectorPack.ObjectTypeEnum.UcsdConnectorPack;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public UcsdConnectorPack.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> DependencyNames {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public UcsdConnectorPack.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Services {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.UcsdConnectorPack initObject = new Intersight.Model.UcsdConnectorPack();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DependencyNames"))
            {
                initObject.DependencyNames = this.DependencyNames;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Services"))
            {
                initObject.Services = this.Services;
            }
            WriteObject(initObject);
        }

    }
}