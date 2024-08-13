using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CatalystsdwanConfigGroup.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCatalystsdwanConfigGroup")]
    public class InitializeIntersightCatalystsdwanConfigGroup : PSCmdlet
    {
        public InitializeIntersightCatalystsdwanConfigGroup()
        {
            ClassId = CatalystsdwanConfigGroup.ClassIdEnum.CatalystsdwanConfigGroup;
            ObjectType = CatalystsdwanConfigGroup.ObjectTypeEnum.CatalystsdwanConfigGroup;

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

        public CatalystsdwanConfigGroup.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UUID for the Catalyst SDWAN config group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ConfigGroupId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Devices
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
        /// <para type="description">"The Catalyst SDWAN config group name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Catalyst SDWAN config group number of devices."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumberOfDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CatalystsdwanConfigGroup.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Catalyst SDWAN config group solution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Solution
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
            Intersight.Model.CatalystsdwanConfigGroup initObject = new Intersight.Model.CatalystsdwanConfigGroup();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigGroupId"))
            {
                initObject.ConfigGroupId = this.ConfigGroupId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Devices"))
            {
                initObject.Devices = this.Devices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfDevices"))
            {
                initObject.NumberOfDevices = this.NumberOfDevices;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Solution"))
            {
                initObject.Solution = this.Solution;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CatalystsdwanPolicyGroup.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCatalystsdwanPolicyGroup")]
    public class InitializeIntersightCatalystsdwanPolicyGroup : PSCmdlet
    {
        public InitializeIntersightCatalystsdwanPolicyGroup()
        {
            ClassId = CatalystsdwanPolicyGroup.ClassIdEnum.CatalystsdwanPolicyGroup;
            ObjectType = CatalystsdwanPolicyGroup.ObjectTypeEnum.CatalystsdwanPolicyGroup;

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

        public CatalystsdwanPolicyGroup.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Devices
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
        /// <para type="description">"The Catalyst SDWAN policy group name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Catalyst SDWAN policy group number of devices."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumberOfDevices
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Catalyst SDWAN policy group number of devices up to date."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumberOfDevicesUpToDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CatalystsdwanPolicyGroup.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UUID for the Catalyst SDWAN policy group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PolicyGroupId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Catalyst SDWAN policy group solution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Solution
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
        /// <para type="description">"The Catalyst SDWAN policy group version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CatalystsdwanPolicyGroup initObject = new Intersight.Model.CatalystsdwanPolicyGroup();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Devices"))
            {
                initObject.Devices = this.Devices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfDevices"))
            {
                initObject.NumberOfDevices = this.NumberOfDevices;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfDevicesUpToDate"))
            {
                initObject.NumberOfDevicesUpToDate = this.NumberOfDevicesUpToDate;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PolicyGroupId"))
            {
                initObject.PolicyGroupId = this.PolicyGroupId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Solution"))
            {
                initObject.Solution = this.Solution;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CatalystsdwanVedgeDevice.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCatalystsdwanVedgeDevice")]
    public class InitializeIntersightCatalystsdwanVedgeDevice : PSCmdlet
    {
        public InitializeIntersightCatalystsdwanVedgeDevice()
        {
            ClassId = CatalystsdwanVedgeDevice.ClassIdEnum.CatalystsdwanVedgeDevice;
            ObjectType = CatalystsdwanVedgeDevice.ObjectTypeEnum.CatalystsdwanVedgeDevice;

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

        public CatalystsdwanVedgeDevice.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Catalyst SDWAN device config status message."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ConfigStatusMessage
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Catalyst SDWAN device state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DeviceState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Catalyst SDWAN device host name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HostName
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

        public CatalystsdwanVedgeDevice.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Catalyst SDWAN device platform family."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PlatformFamily
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Catalyst SDWAN device reachability."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Reachability
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Catalyst SDWAN device site id."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SiteId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Catalyst SDWAN device site name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SiteName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Catalyst SDWAN device sp organization name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SpOrganizationName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Catalyst SDWAN device system IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SystemIp
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
        /// <para type="description">"The Catalyst SDWAN device template status."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TemplateStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Catalyst SDWAN device validity."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Validity
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CatalystsdwanVedgeDevice initObject = new Intersight.Model.CatalystsdwanVedgeDevice();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigStatusMessage"))
            {
                initObject.ConfigStatusMessage = this.ConfigStatusMessage;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceState"))
            {
                initObject.DeviceState = this.DeviceState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HostName"))
            {
                initObject.HostName = this.HostName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PlatformFamily"))
            {
                initObject.PlatformFamily = this.PlatformFamily;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Reachability"))
            {
                initObject.Reachability = this.Reachability;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteId"))
            {
                initObject.SiteId = this.SiteId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SiteName"))
            {
                initObject.SiteName = this.SiteName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SpOrganizationName"))
            {
                initObject.SpOrganizationName = this.SpOrganizationName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SystemIp"))
            {
                initObject.SystemIp = this.SystemIp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TemplateStatus"))
            {
                initObject.TemplateStatus = this.TemplateStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Validity"))
            {
                initObject.Validity = this.Validity;
            }
            WriteObject(initObject);
        }

    }
}