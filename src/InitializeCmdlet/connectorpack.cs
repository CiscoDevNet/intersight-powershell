using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorpackUpgradeImpact.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorpackUpgradeImpact")]
    public class InitializeIntersightConnectorpackUpgradeImpact : PSCmdlet
    {
        public InitializeIntersightConnectorpackUpgradeImpact()
        {
            ClassId = ConnectorpackUpgradeImpact.ClassIdEnum.ConnectorpackUpgradeImpact;
            ObjectType = ConnectorpackUpgradeImpact.ObjectTypeEnum.ConnectorpackUpgradeImpact;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorpackUpgradeImpact.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorpackUpgradeImpact.ObjectTypeEnum ObjectType
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
        // <summary>
        /// <para type="description">"A reference to a iaasUcsdInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IaasUcsdInfoRelationship UcsdInfo
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorpackUpgradeImpact initObject = new Intersight.Model.ConnectorpackUpgradeImpact();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UcsdInfo"))
            {
                initObject.UcsdInfo = this.UcsdInfo;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorpackConnectorPackUpdate.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorpackConnectorPackUpdate")]
    public class InitializeIntersightConnectorpackConnectorPackUpdate : PSCmdlet
    {
        public InitializeIntersightConnectorpackConnectorPackUpdate()
        {
            ClassId = ConnectorpackConnectorPackUpdate.ClassIdEnum.ConnectorpackConnectorPackUpdate;
            ObjectType = ConnectorpackConnectorPackUpdate.ObjectTypeEnum.ConnectorpackConnectorPackUpdate;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorpackConnectorPackUpdate.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorpackConnectorPackUpdate.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorpackConnectorPackUpdate initObject = new Intersight.Model.ConnectorpackConnectorPackUpdate();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ConnectorpackConnectorPackUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightConnectorpackConnectorPackUpgrade")]
    public class InitializeIntersightConnectorpackConnectorPackUpgrade : PSCmdlet
    {
        public InitializeIntersightConnectorpackConnectorPackUpgrade()
        {
            ClassId = ConnectorpackConnectorPackUpgrade.ClassIdEnum.ConnectorpackConnectorPackUpgrade;
            ConnectorPackOpType = ConnectorpackConnectorPackUpgrade.ConnectorPackOpTypeEnum.Install;
            ObjectType = ConnectorpackConnectorPackUpgrade.ObjectTypeEnum.ConnectorpackConnectorPackUpgrade;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorpackConnectorPackUpgrade.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of operation to be performed on UCS Director.\n* `Install` - Installs the requisite connector packs on UCS Director.\n* `Push` - Pushes the requisite connector packs to UCS Director."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorpackConnectorPackUpgrade.ConnectorPackOpTypeEnum ConnectorPackOpType
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ConnectorpackConnectorPackUpgrade.ObjectTypeEnum ObjectType
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
        // <summary>
        /// <para type="description">"A reference to a iaasUcsdInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IaasUcsdInfoRelationship UcsdInfo
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.ConnectorpackConnectorPackUpgrade initObject = new Intersight.Model.ConnectorpackConnectorPackUpgrade();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConnectorPackOpType"))
            {
                initObject.ConnectorPackOpType = this.ConnectorPackOpType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UcsdInfo"))
            {
                initObject.UcsdInfo = this.UcsdInfo;
            }
            WriteObject(initObject);
        }

    }
}