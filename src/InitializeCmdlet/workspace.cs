using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkspaceFolder.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkspaceFolder")]
    public class InitializeIntersightWorkspaceFolder : PSCmdlet
    {
        public InitializeIntersightWorkspaceFolder()
        {
            ClassId = WorkspaceFolder.ClassIdEnum.WorkspaceFolder;
            ObjectType = WorkspaceFolder.ObjectTypeEnum.WorkspaceFolder;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"It is to define if folder is archived or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Archived
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to moBaseMo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoBaseMoRelationship> Assets
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkspaceFolder.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name for this folder. You can have multiple versions of the folder with the same name. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]{1}[\\sa-zA-Z0-9_./:-]{0,91}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkspaceFolder.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workspaceFolder resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkspaceFolderRelationship ParentFolder
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to workspaceFolder resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkspaceFolderRelationship> SubFolders
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.WorkspaceFolder initObject = new Intersight.Model.WorkspaceFolder();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Archived"))
            {
                initObject.Archived = this.Archived;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Assets"))
            {
                initObject.Assets = this.Assets;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ParentFolder"))
            {
                initObject.ParentFolder = this.ParentFolder;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SubFolders"))
            {
                initObject.SubFolders = this.SubFolders;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
}