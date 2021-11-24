using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesNodeStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesNodeStatus")]
    public class InitializeIntersightKubernetesNodeStatus:PSCmdlet
	{
		public InitializeIntersightKubernetesNodeStatus()
		{
            ClassId = KubernetesNodeStatus.ClassIdEnum.KubernetesNodeStatus;
            ObjectType = KubernetesNodeStatus.ObjectTypeEnum.KubernetesNodeStatus;
            
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
        
        public KubernetesNodeStatus.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesNodeStatus.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Statue of the node. Indicate if the node is kubernetes ready or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Status {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the node. It can be either Master or Worker."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesNodeStatus initObject = new Intersight.Model.KubernetesNodeStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesBaseVirtualMachineInfraConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesBaseVirtualMachineInfraConfig")]
    public class InitializeIntersightKubernetesBaseVirtualMachineInfraConfig:PSCmdlet
	{
		public InitializeIntersightKubernetesBaseVirtualMachineInfraConfig()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesBaseVirtualMachineInfraConfig.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Interfaces {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesBaseVirtualMachineInfraConfig.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesBaseVirtualMachineInfraConfig initObject = new Intersight.Model.KubernetesBaseVirtualMachineInfraConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Interfaces"))
            {
                initObject.Interfaces = this.Interfaces;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesEssentialAddon.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesEssentialAddon")]
    public class InitializeIntersightKubernetesEssentialAddon:PSCmdlet
	{
		public InitializeIntersightKubernetesEssentialAddon()
		{
            ClassId = KubernetesEssentialAddon.ClassIdEnum.KubernetesEssentialAddon;
            ObjectType = KubernetesEssentialAddon.ObjectTypeEnum.KubernetesEssentialAddon;
            
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
        /// <para type="description">"Addon configuration settings that are specific to a single cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.KubernetesAddonConfiguration AddonConfiguration {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Addon definition associated with the addon."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.MoMoRef AddonDefinition {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesEssentialAddon.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of addon to be installed on a Kubernetes cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesEssentialAddon.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesEssentialAddon initObject = new Intersight.Model.KubernetesEssentialAddon();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AddonConfiguration"))
            {
                initObject.AddonConfiguration = this.AddonConfiguration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AddonDefinition"))
            {
                initObject.AddonDefinition = this.AddonDefinition;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesBaremetalNetworkInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesBaremetalNetworkInfo")]
    public class InitializeIntersightKubernetesBaremetalNetworkInfo:PSCmdlet
	{
		public InitializeIntersightKubernetesBaremetalNetworkInfo()
		{
            ClassId = KubernetesBaremetalNetworkInfo.ClassIdEnum.KubernetesBaremetalNetworkInfo;
            ObjectType = KubernetesBaremetalNetworkInfo.ObjectTypeEnum.KubernetesBaremetalNetworkInfo;
            
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
        
        public KubernetesBaremetalNetworkInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.KubernetesEthernet> Ethernets {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesBaremetalNetworkInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.KubernetesOvsBond> Ovsbonds {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesBaremetalNetworkInfo initObject = new Intersight.Model.KubernetesBaremetalNetworkInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Ethernets"))
            {
                initObject.Ethernets = this.Ethernets;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Ovsbonds"))
            {
                initObject.Ovsbonds = this.Ovsbonds;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesDeploymentStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesDeploymentStatus")]
    public class InitializeIntersightKubernetesDeploymentStatus:PSCmdlet
	{
		public InitializeIntersightKubernetesDeploymentStatus()
		{
            ClassId = KubernetesDeploymentStatus.ClassIdEnum.KubernetesDeploymentStatus;
            ObjectType = KubernetesDeploymentStatus.ObjectTypeEnum.KubernetesDeploymentStatus;
            
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
        /// <para type="description">"Total number of available pods (ready for at least minReadySeconds) targeted by this deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long AvailableReplicas {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesDeploymentStatus.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesDeploymentStatus.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The generation observed by the deployment controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ObservedGeneration {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Total number of ready pods targeted by this deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ReadyReplicas {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Total number of non-terminated pods targeted by this deployment (their labels match the selector)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Replicas {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Total number of non-terminated pods targeted by this deployment that have the desired template spec."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long UpdatedReplicas {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesDeploymentStatus initObject = new Intersight.Model.KubernetesDeploymentStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AvailableReplicas"))
            {
                initObject.AvailableReplicas = this.AvailableReplicas;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ObservedGeneration"))
            {
                initObject.ObservedGeneration = this.ObservedGeneration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReadyReplicas"))
            {
                initObject.ReadyReplicas = this.ReadyReplicas;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Replicas"))
            {
                initObject.Replicas = this.Replicas;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpdatedReplicas"))
            {
                initObject.UpdatedReplicas = this.UpdatedReplicas;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesServiceStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesServiceStatus")]
    public class InitializeIntersightKubernetesServiceStatus:PSCmdlet
	{
		public InitializeIntersightKubernetesServiceStatus()
		{
            ClassId = KubernetesServiceStatus.ClassIdEnum.KubernetesServiceStatus;
            ObjectType = KubernetesServiceStatus.ObjectTypeEnum.KubernetesServiceStatus;
            
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
        
        public KubernetesServiceStatus.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"It reflects the Kubernetes Load Balancer Type (Cluster IP, NodePort and LoadBalancer). If the service is a LoadBalancer type of service, it will also report the LoadBalancer IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.KubernetesLoadBalancer LoadBalancer {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesServiceStatus.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesServiceStatus initObject = new Intersight.Model.KubernetesServiceStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LoadBalancer"))
            {
                initObject.LoadBalancer = this.LoadBalancer;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesEthernet.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesEthernet")]
    public class InitializeIntersightKubernetesEthernet:PSCmdlet
	{
		public InitializeIntersightKubernetesEthernet()
		{
            ClassId = KubernetesEthernet.ClassIdEnum.KubernetesEthernet;
            ObjectType = KubernetesEthernet.ObjectTypeEnum.KubernetesEthernet;
            
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Addresses {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesEthernet.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Network Gateway for the Network Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Gateway {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The matcher to be used to find the physical network interface represented by this ethernet device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.KubernetesEthernetMatcher Matcher {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MTU to assign to this Network Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Mtu {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name for this network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesEthernet.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesEthernet initObject = new Intersight.Model.KubernetesEthernet();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Addresses"))
            {
                initObject.Addresses = this.Addresses;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Gateway"))
            {
                initObject.Gateway = this.Gateway;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Matcher"))
            {
                initObject.Matcher = this.Matcher;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mtu"))
            {
                initObject.Mtu = this.Mtu;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesClusterManagementConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesClusterManagementConfig")]
    public class InitializeIntersightKubernetesClusterManagementConfig:PSCmdlet
	{
		public InitializeIntersightKubernetesClusterManagementConfig()
		{
            ClassId = KubernetesClusterManagementConfig.ClassIdEnum.KubernetesClusterManagementConfig;
            ObjectType = KubernetesClusterManagementConfig.ObjectTypeEnum.KubernetesClusterManagementConfig;
            
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
        
        public KubernetesClusterManagementConfig.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of IP addresses to reserve for load balancer services."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long LoadBalancerCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> LoadBalancers {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VIP for the cluster Kubernetes API server. If this is empty and a cluster IP pool is specified, it will be allocated from the IP pool."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MasterVip {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesClusterManagementConfig.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> SshKeys {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hashed password of the TAC user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TacPasswd {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesClusterManagementConfig initObject = new Intersight.Model.KubernetesClusterManagementConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LoadBalancerCount"))
            {
                initObject.LoadBalancerCount = this.LoadBalancerCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LoadBalancers"))
            {
                initObject.LoadBalancers = this.LoadBalancers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MasterVip"))
            {
                initObject.MasterVip = this.MasterVip;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SshKeys"))
            {
                initObject.SshKeys = this.SshKeys;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TacPasswd"))
            {
                initObject.TacPasswd = this.TacPasswd;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesEsxiVirtualMachineInfraConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesEsxiVirtualMachineInfraConfig")]
    public class InitializeIntersightKubernetesEsxiVirtualMachineInfraConfig:PSCmdlet
	{
		public InitializeIntersightKubernetesEsxiVirtualMachineInfraConfig()
		{
            ClassId = KubernetesEsxiVirtualMachineInfraConfig.ClassIdEnum.KubernetesEsxiVirtualMachineInfraConfig;
            ObjectType = KubernetesEsxiVirtualMachineInfraConfig.ObjectTypeEnum.KubernetesEsxiVirtualMachineInfraConfig;
            
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
        
        public KubernetesEsxiVirtualMachineInfraConfig.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the vSphere cluster on which the virtual machines are created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Cluster {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the datasore on which the virtual machine disks are created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Datastore {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Interfaces {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesEsxiVirtualMachineInfraConfig.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Passphrase for the vcenter user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Passphrase {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the vSphere resource pool on which the virtual machines are created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ResourcePool {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesEsxiVirtualMachineInfraConfig initObject = new Intersight.Model.KubernetesEsxiVirtualMachineInfraConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Cluster"))
            {
                initObject.Cluster = this.Cluster;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Datastore"))
            {
                initObject.Datastore = this.Datastore;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Interfaces"))
            {
                initObject.Interfaces = this.Interfaces;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Passphrase"))
            {
                initObject.Passphrase = this.Passphrase;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourcePool"))
            {
                initObject.ResourcePool = this.ResourcePool;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesConfiguration")]
    public class InitializeIntersightKubernetesConfiguration:PSCmdlet
	{
		public InitializeIntersightKubernetesConfiguration()
		{
            ClassId = KubernetesConfiguration.ClassIdEnum.KubernetesConfiguration;
            ObjectType = KubernetesConfiguration.ObjectTypeEnum.KubernetesConfiguration;
            
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
        
        public KubernetesConfiguration.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesConfiguration.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesConfiguration initObject = new Intersight.Model.KubernetesConfiguration();
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
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesStatefulSetStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesStatefulSetStatus")]
    public class InitializeIntersightKubernetesStatefulSetStatus:PSCmdlet
	{
		public InitializeIntersightKubernetesStatefulSetStatus()
		{
            ClassId = KubernetesStatefulSetStatus.ClassIdEnum.KubernetesStatefulSetStatus;
            ObjectType = KubernetesStatefulSetStatus.ObjectTypeEnum.KubernetesStatefulSetStatus;
            
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
        /// <para type="description">"AvailableReplicas indicates the current avaliable replicas running."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long AvailableReplicas {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesStatefulSetStatus.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CollisionCount is the count of hash collisions for the StatefulSet. The StatefulSet controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ControllerRevision."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CollisionCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CurrentRevision, if not empty, indicates the version of the StatefulSet used to generate Pods."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CurrentRevision {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesStatefulSetStatus.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ObservedGeneration is the most recent generation observed for this StatefulSet. It corresponds to the StatefulSet's generation, which is updated on mutation by the API Server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ObservedGeneration {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ReadyReplicas is the number of Pods created by the StatefulSet controller that have a Ready Condition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ReadyReplicas {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of replicas the statefulset desired to have."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Replicas {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UpdateRevision, if not empty, indicates the version of the StatefulSet used to generate the pods that have yet to be updated, i.e. pod number <replicas> - <updatedReplicas>, until pod number <replicas>."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UpdateRevision {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UpdatedReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by updateRevision."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long UpdatedReplicas {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesStatefulSetStatus initObject = new Intersight.Model.KubernetesStatefulSetStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AvailableReplicas"))
            {
                initObject.AvailableReplicas = this.AvailableReplicas;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CollisionCount"))
            {
                initObject.CollisionCount = this.CollisionCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CurrentRevision"))
            {
                initObject.CurrentRevision = this.CurrentRevision;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ObservedGeneration"))
            {
                initObject.ObservedGeneration = this.ObservedGeneration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReadyReplicas"))
            {
                initObject.ReadyReplicas = this.ReadyReplicas;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Replicas"))
            {
                initObject.Replicas = this.Replicas;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpdateRevision"))
            {
                initObject.UpdateRevision = this.UpdateRevision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpdatedReplicas"))
            {
                initObject.UpdatedReplicas = this.UpdatedReplicas;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesActionInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesActionInfo")]
    public class InitializeIntersightKubernetesActionInfo:PSCmdlet
	{
		public InitializeIntersightKubernetesActionInfo()
		{
            ClassId = KubernetesActionInfo.ClassIdEnum.KubernetesActionInfo;
            ObjectType = KubernetesActionInfo.ObjectTypeEnum.KubernetesActionInfo;
            Status = KubernetesActionInfo.StatusEnum.None;
            
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
        
        public KubernetesActionInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesActionInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"No longer maintained and will be removed soon.\n* `None` - A place holder for the default value.\n* `InProgress` - Action triggered on the resource is still running.\n* `Success` - Action triggered on the resource is completed successfully.\n* `Failure` - Action triggered on the resource is failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesActionInfo.StatusEnum Status {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesActionInfo initObject = new Intersight.Model.KubernetesActionInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesNodeInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesNodeInfo")]
    public class InitializeIntersightKubernetesNodeInfo:PSCmdlet
	{
		public InitializeIntersightKubernetesNodeInfo()
		{
            ClassId = KubernetesNodeInfo.ClassIdEnum.KubernetesNodeInfo;
            ObjectType = KubernetesNodeInfo.ObjectTypeEnum.KubernetesNodeInfo;
            
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
        /// <para type="description">"Node Operating System architecture (amd64, arm64)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Architecture {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A Boot ID is an Identifier generated by the host everytimes it gets reboot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BootId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesNodeInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"To run containers in Pods, Kubernetes uses a container runtime. This field describes Container Runtime Version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ContainerRuntimeVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Node Operating System kernel version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string KernelVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Kubernetes network proxy runs on each node. This reflects services as defined in the Kubernetes API on each node and can do simple TCP, UDP, and SCTP stream forwarding or round robin TCP, UDP, and SCTP forwarding across a set of backends. This field describes the kube-proxy version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string KubeProxyVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The kubelet is the primary \"node agent\" that runs on each node. It can register the node with the apiserver using one of such as the hostname; a flag to override the hostname; or specific logic for a cloud provider. This field describes the kubelet version the node currently using."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string KubeletVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"It is a node identifier in Kubernetes. When the node joins a kubernetes cluster, Kubernetes will assign a machine ID to that node. Learn more from man machine-id from http://man7.org/linux/man-pages/man5/machine-id.5.html."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MachineId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesNodeInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Operating System installed on this Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OperatingSystem {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Node current Operating System image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OsImage {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SystemUUID reported by the node. For unique machine identification MachineID is preferred. This field is specific to Red Hat hosts https://access.redhat.com/documentation/en-US/Red_Hat_Subscription_Management/1/html/RHSM/getting-system-uuid.html."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SystemUuid {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesNodeInfo initObject = new Intersight.Model.KubernetesNodeInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Architecture"))
            {
                initObject.Architecture = this.Architecture;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BootId"))
            {
                initObject.BootId = this.BootId;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ContainerRuntimeVersion"))
            {
                initObject.ContainerRuntimeVersion = this.ContainerRuntimeVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KernelVersion"))
            {
                initObject.KernelVersion = this.KernelVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KubeProxyVersion"))
            {
                initObject.KubeProxyVersion = this.KubeProxyVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KubeletVersion"))
            {
                initObject.KubeletVersion = this.KubeletVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MachineId"))
            {
                initObject.MachineId = this.MachineId;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OperatingSystem"))
            {
                initObject.OperatingSystem = this.OperatingSystem;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OsImage"))
            {
                initObject.OsImage = this.OsImage;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SystemUuid"))
            {
                initObject.SystemUuid = this.SystemUuid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesOvsBond.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesOvsBond")]
    public class InitializeIntersightKubernetesOvsBond:PSCmdlet
	{
		public InitializeIntersightKubernetesOvsBond()
		{
            ClassId = KubernetesOvsBond.ClassIdEnum.KubernetesOvsBond;
            ObjectType = KubernetesOvsBond.ObjectTypeEnum.KubernetesOvsBond;
            
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Addresses {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesOvsBond.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Network Gateway for the Network Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Gateway {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Interfaces {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MTU to assign to this Network Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Mtu {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name for this network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesOvsBond.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Native VLAN for to use for the bond."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Vlan {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesOvsBond initObject = new Intersight.Model.KubernetesOvsBond();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Addresses"))
            {
                initObject.Addresses = this.Addresses;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Gateway"))
            {
                initObject.Gateway = this.Gateway;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Interfaces"))
            {
                initObject.Interfaces = this.Interfaces;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mtu"))
            {
                initObject.Mtu = this.Mtu;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Vlan"))
            {
                initObject.Vlan = this.Vlan;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesDaemonSetStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesDaemonSetStatus")]
    public class InitializeIntersightKubernetesDaemonSetStatus:PSCmdlet
	{
		public InitializeIntersightKubernetesDaemonSetStatus()
		{
            ClassId = KubernetesDaemonSetStatus.ClassIdEnum.KubernetesDaemonSetStatus;
            ObjectType = KubernetesDaemonSetStatus.ObjectTypeEnum.KubernetesDaemonSetStatus;
            
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
        
        public KubernetesDaemonSetStatus.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of nodes that are running at least 1 daemon pod and are supposed to run the daemon pod."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CurrentNumberScheduled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The total number of nodes that should be running the daemon pod (including nodes correctly running the daemon pod)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long DesiredNumberScheduled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and available (ready for at least spec.minReadySeconds)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NumberAvailable {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of nodes that are running the daemon pod, but are not supposed to run the daemon pod."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberMisscheduled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and ready."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberReady {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesDaemonSetStatus.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The most recent generation observed by the daemon set controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ObservedGeneration {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The total number of nodes that are running updated daemon pod."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UpdatedNumberScheduled {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesDaemonSetStatus initObject = new Intersight.Model.KubernetesDaemonSetStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CurrentNumberScheduled"))
            {
                initObject.CurrentNumberScheduled = this.CurrentNumberScheduled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DesiredNumberScheduled"))
            {
                initObject.DesiredNumberScheduled = this.DesiredNumberScheduled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberAvailable"))
            {
                initObject.NumberAvailable = this.NumberAvailable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberMisscheduled"))
            {
                initObject.NumberMisscheduled = this.NumberMisscheduled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberReady"))
            {
                initObject.NumberReady = this.NumberReady;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ObservedGeneration"))
            {
                initObject.ObservedGeneration = this.ObservedGeneration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpdatedNumberScheduled"))
            {
                initObject.UpdatedNumberScheduled = this.UpdatedNumberScheduled;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesTaint.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesTaint")]
    public class InitializeIntersightKubernetesTaint:PSCmdlet
	{
		public InitializeIntersightKubernetesTaint()
		{
            ClassId = KubernetesTaint.ClassIdEnum.KubernetesTaint;
            ObjectType = KubernetesTaint.ObjectTypeEnum.KubernetesTaint;
            
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
        
        public KubernetesTaint.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Effect of the taint is one of the following NoSchedule,\nPreferNoSchedule, NoExecute."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Effect {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The key is any string, up to 253 characters. The key must begin\nwith a letter or number, and may contain letters, numbers,\nhyphens, dots, and underscores."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Key {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesTaint.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The value is any string, up to 63 characters. The value must\nbegin with a letter or number, and may contain letters,\nnumbers, hyphens, dots, and underscores."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Value {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesTaint initObject = new Intersight.Model.KubernetesTaint();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Effect"))
            {
                initObject.Effect = this.Effect;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Key"))
            {
                initObject.Key = this.Key;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesHyperFlexApVirtualMachineInfraConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesHyperFlexApVirtualMachineInfraConfig")]
    public class InitializeIntersightKubernetesHyperFlexApVirtualMachineInfraConfig:PSCmdlet
	{
		public InitializeIntersightKubernetesHyperFlexApVirtualMachineInfraConfig()
		{
            ClassId = KubernetesHyperFlexApVirtualMachineInfraConfig.ClassIdEnum.KubernetesHyperFlexApVirtualMachineInfraConfig;
            DiskMode = KubernetesHyperFlexApVirtualMachineInfraConfig.DiskModeEnum.Block;
            ObjectType = KubernetesHyperFlexApVirtualMachineInfraConfig.ObjectTypeEnum.KubernetesHyperFlexApVirtualMachineInfraConfig;
            
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
        
        public KubernetesHyperFlexApVirtualMachineInfraConfig.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Disk mode to use for volumes.\n* `Block` - It is a Block virtual disk.\n* `Filesystem` - It is a File system virtual disk.\n* `` - Disk mode is either unknown or not supported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesHyperFlexApVirtualMachineInfraConfig.DiskModeEnum DiskMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Interfaces {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesHyperFlexApVirtualMachineInfraConfig.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesHyperFlexApVirtualMachineInfraConfig initObject = new Intersight.Model.KubernetesHyperFlexApVirtualMachineInfraConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DiskMode"))
            {
                initObject.DiskMode = this.DiskMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Interfaces"))
            {
                initObject.Interfaces = this.Interfaces;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesCalicoConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesCalicoConfig")]
    public class InitializeIntersightKubernetesCalicoConfig:PSCmdlet
	{
		public InitializeIntersightKubernetesCalicoConfig()
		{
            ClassId = KubernetesCalicoConfig.ClassIdEnum.KubernetesCalicoConfig;
            IpVersion = KubernetesCalicoConfig.IpVersionEnum.V4;
            ObjectType = KubernetesCalicoConfig.ObjectTypeEnum.KubernetesCalicoConfig;
            
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
        
        public KubernetesCalicoConfig.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP version that can take on values v4 or v6.\n* `v4` - This refers to the IPv4 address.\n* `v6` - This refers to the IPv6 address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesCalicoConfig.IpVersionEnum IpVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Workload interface maximum transmission unit (MTU)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Mtu {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesCalicoConfig.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CNI Image registry location."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Registry {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Container newtork interface plugin configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesCalicoConfig initObject = new Intersight.Model.KubernetesCalicoConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("IpVersion"))
            {
                initObject.IpVersion = this.IpVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mtu"))
            {
                initObject.Mtu = this.Mtu;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Registry"))
            {
                initObject.Registry = this.Registry;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesPodStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesPodStatus")]
    public class InitializeIntersightKubernetesPodStatus:PSCmdlet
	{
		public InitializeIntersightKubernetesPodStatus()
		{
            ClassId = KubernetesPodStatus.ClassIdEnum.KubernetesPodStatus;
            ObjectType = KubernetesPodStatus.ObjectTypeEnum.KubernetesPodStatus;
            
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
        
        public KubernetesPodStatus.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The IP of the host that the pod is running on."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HostIp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesPodStatus.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The phase of a Pod is a simple, high-level summary of where the Pod is in its lifecycle."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Phase {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The IP of the pod. The IP is allocated by the Pod CIDR from the kubernetes cluster itself."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PodIp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Quality of Service (QOS) classification assigned to the pod based on resource requirements."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string QosClass {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The time that the pod was started."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string StartTime {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesPodStatus initObject = new Intersight.Model.KubernetesPodStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("HostIp"))
            {
                initObject.HostIp = this.HostIp;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Phase"))
            {
                initObject.Phase = this.Phase;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PodIp"))
            {
                initObject.PodIp = this.PodIp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("QosClass"))
            {
                initObject.QosClass = this.QosClass;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StartTime"))
            {
                initObject.StartTime = this.StartTime;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesAddonConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesAddonConfiguration")]
    public class InitializeIntersightKubernetesAddonConfiguration:PSCmdlet
	{
		public InitializeIntersightKubernetesAddonConfiguration()
		{
            ClassId = KubernetesAddonConfiguration.ClassIdEnum.KubernetesAddonConfiguration;
            InstallStrategy = KubernetesAddonConfiguration.InstallStrategyEnum.None;
            ObjectType = KubernetesAddonConfiguration.ObjectTypeEnum.KubernetesAddonConfiguration;
            UpgradeStrategy = KubernetesAddonConfiguration.UpgradeStrategyEnum.None;
            
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
        
        public KubernetesAddonConfiguration.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Addon install strategy to determine whether an addon is installed if not present.\n* `None` - Unspecified install strategy.\n* `NoAction` - No install action performed.\n* `InstallOnly` - Only install in green field. No action in case of failure or removal.\n* `Always` - Attempt install if chart is not already installed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesAddonConfiguration.InstallStrategyEnum InstallStrategy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesAddonConfiguration.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.KubernetesKeyValue> OverrideSets {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Properties that can be overridden for an addon."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Overrides {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name for the helm release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ReleaseName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Namespace for the helm release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ReleaseNamespace {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Addon upgrade strategy to determine whether an addon configuration is overwritten on upgrade.\n* `None` - Unspecified upgrade strategy.\n* `NoAction` - This choice enables No upgrades to be performed.\n* `UpgradeOnly` - Attempt upgrade if chart or overrides options change, no action on upgrade failure.\n* `ReinstallOnFailure` - Attempt upgrade first. Remove and install on upgrade failure.\n* `AlwaysReinstall` - Always remove older release and reinstall."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesAddonConfiguration.UpgradeStrategyEnum UpgradeStrategy {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesAddonConfiguration initObject = new Intersight.Model.KubernetesAddonConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("InstallStrategy"))
            {
                initObject.InstallStrategy = this.InstallStrategy;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OverrideSets"))
            {
                initObject.OverrideSets = this.OverrideSets;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Overrides"))
            {
                initObject.Overrides = this.Overrides;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReleaseName"))
            {
                initObject.ReleaseName = this.ReleaseName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReleaseNamespace"))
            {
                initObject.ReleaseNamespace = this.ReleaseNamespace;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UpgradeStrategy"))
            {
                initObject.UpgradeStrategy = this.UpgradeStrategy;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesClusterCertificateConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesClusterCertificateConfiguration")]
    public class InitializeIntersightKubernetesClusterCertificateConfiguration:PSCmdlet
	{
		public InitializeIntersightKubernetesClusterCertificateConfiguration()
		{
            ClassId = KubernetesClusterCertificateConfiguration.ClassIdEnum.KubernetesClusterCertificateConfiguration;
            ObjectType = KubernetesClusterCertificateConfiguration.ObjectTypeEnum.KubernetesClusterCertificateConfiguration;
            
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
        /// <para type="description">"Certificate for the Kubernetes API server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CaCert {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Private Key for the Kubernetes API server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CaKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesClusterCertificateConfiguration.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Certificate for the etcd cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EtcdCert {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> EtcdEncryptionKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Private key for the etcd cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EtcdKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Certificate for the front proxy to support Kubernetes API aggregators."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FrontProxyCert {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Private key for the front proxy to support Kubernetes API aggregators."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FrontProxyKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesClusterCertificateConfiguration.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Service account private key used by Kubernetes Token Controller to sign generated service account tokens."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SaPrivateKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Service account public key used by Kubernetes API Server to validate service account tokens generated by the Token Controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SaPublicKey {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesClusterCertificateConfiguration initObject = new Intersight.Model.KubernetesClusterCertificateConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CaCert"))
            {
                initObject.CaCert = this.CaCert;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CaKey"))
            {
                initObject.CaKey = this.CaKey;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EtcdCert"))
            {
                initObject.EtcdCert = this.EtcdCert;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EtcdEncryptionKey"))
            {
                initObject.EtcdEncryptionKey = this.EtcdEncryptionKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EtcdKey"))
            {
                initObject.EtcdKey = this.EtcdKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FrontProxyCert"))
            {
                initObject.FrontProxyCert = this.FrontProxyCert;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FrontProxyKey"))
            {
                initObject.FrontProxyKey = this.FrontProxyKey;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SaPrivateKey"))
            {
                initObject.SaPrivateKey = this.SaPrivateKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SaPublicKey"))
            {
                initObject.SaPublicKey = this.SaPublicKey;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesIngressStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesIngressStatus")]
    public class InitializeIntersightKubernetesIngressStatus:PSCmdlet
	{
		public InitializeIntersightKubernetesIngressStatus()
		{
            ClassId = KubernetesIngressStatus.ClassIdEnum.KubernetesIngressStatus;
            ObjectType = KubernetesIngressStatus.ObjectTypeEnum.KubernetesIngressStatus;
            
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
        
        public KubernetesIngressStatus.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"LoadBalancer contains the current status of the load-balancer."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.KubernetesLoadBalancer LoadBalancer {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesIngressStatus.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesIngressStatus initObject = new Intersight.Model.KubernetesIngressStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LoadBalancer"))
            {
                initObject.LoadBalancer = this.LoadBalancer;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesNodeGroupLabel.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesNodeGroupLabel")]
    public class InitializeIntersightKubernetesNodeGroupLabel:PSCmdlet
	{
		public InitializeIntersightKubernetesNodeGroupLabel()
		{
            ClassId = KubernetesNodeGroupLabel.ClassIdEnum.KubernetesNodeGroupLabel;
            ObjectType = KubernetesNodeGroupLabel.ObjectTypeEnum.KubernetesNodeGroupLabel;
            
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
        
        public KubernetesNodeGroupLabel.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The key for a Kubernetes label for a node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Key {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesNodeGroupLabel.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The value for a Kubernetes label for a node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Value {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesNodeGroupLabel initObject = new Intersight.Model.KubernetesNodeGroupLabel();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Key"))
            {
                initObject.Key = this.Key;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesCniConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesCniConfig")]
    public class InitializeIntersightKubernetesCniConfig:PSCmdlet
	{
		public InitializeIntersightKubernetesCniConfig()
		{
            ClassId = KubernetesCniConfig.ClassIdEnum.KubernetesCalicoConfig;
            ObjectType = KubernetesCniConfig.ObjectTypeEnum.KubernetesCalicoConfig;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesCniConfig.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesCniConfig.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CNI Image registry location."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Registry {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Container newtork interface plugin configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesCniConfig initObject = new Intersight.Model.KubernetesCniConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Registry"))
            {
                initObject.Registry = this.Registry;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesNodeAddress.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesNodeAddress")]
    public class InitializeIntersightKubernetesNodeAddress:PSCmdlet
	{
		public InitializeIntersightKubernetesNodeAddress()
		{
            ClassId = KubernetesNodeAddress.ClassIdEnum.KubernetesNodeAddress;
            ObjectType = KubernetesNodeAddress.ObjectTypeEnum.KubernetesNodeAddress;
            
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
        /// <para type="description">"The address of type specified by the type field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Address {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesNodeAddress.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesNodeAddress.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The address type of the Node. The usage of the IP address depending on the cloud provider or bare metal configuration. HostName - The hostname as reported by the node's kernel. ExternalIP - Typically the IP address of the node that is externally routable (available from outside the cluster) InternalIP - Typically the IP address of the node that is routable only within the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesNodeAddress initObject = new Intersight.Model.KubernetesNodeAddress();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Address"))
            {
                initObject.Address = this.Address;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesNodeGroupTaint.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesNodeGroupTaint")]
    public class InitializeIntersightKubernetesNodeGroupTaint:PSCmdlet
	{
		public InitializeIntersightKubernetesNodeGroupTaint()
		{
            ClassId = KubernetesNodeGroupTaint.ClassIdEnum.KubernetesNodeGroupTaint;
            ObjectType = KubernetesNodeGroupTaint.ObjectTypeEnum.KubernetesNodeGroupTaint;
            
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
        
        public KubernetesNodeGroupTaint.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The effect to enforce when the key does not match the value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Effect {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The key for a Kubernetes taint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Key {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesNodeGroupTaint.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If the key does not match this value, the specified effect is enforced."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Value {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesNodeGroupTaint initObject = new Intersight.Model.KubernetesNodeGroupTaint();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Effect"))
            {
                initObject.Effect = this.Effect;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Key"))
            {
                initObject.Key = this.Key;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesNodeSpec.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesNodeSpec")]
    public class InitializeIntersightKubernetesNodeSpec:PSCmdlet
	{
		public InitializeIntersightKubernetesNodeSpec()
		{
            ClassId = KubernetesNodeSpec.ClassIdEnum.KubernetesNodeSpec;
            ObjectType = KubernetesNodeSpec.ObjectTypeEnum.KubernetesNodeSpec;
            
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
        
        public KubernetesNodeSpec.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesNodeSpec.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Node Pod CIDR. In Kubernetes, the workload (Pod) is allocated to an IP address by Kubernetes. The IP address is from a Pod CIDR of the cluster. Each node will (mostly) evenly be distributed the Pod CIDR."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PodCidr {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Kubernetes can be running on a specific cloud provider such as Openstack, Amazon Web Services, vCenter etc. Each cloud provider will have a specific cloud provider ID. This field is to represent that ID for the corresponding Kubernetes cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ProviderId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesNodeSpec initObject = new Intersight.Model.KubernetesNodeSpec();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PodCidr"))
            {
                initObject.PodCidr = this.PodCidr;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProviderId"))
            {
                initObject.ProviderId = this.ProviderId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesProxyConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesProxyConfig")]
    public class InitializeIntersightKubernetesProxyConfig:PSCmdlet
	{
		public InitializeIntersightKubernetesProxyConfig()
		{
            ClassId = KubernetesProxyConfig.ClassIdEnum.KubernetesProxyConfig;
            ObjectType = KubernetesProxyConfig.ObjectTypeEnum.KubernetesProxyConfig;
            
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
        
        public KubernetesProxyConfig.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HTTP/HTTPS Proxy server FQDN or IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?$|^[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?(\\.[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?)*(\\.[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?)$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Hostname {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesProxyConfig.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The password for the HTTP/HTTPS Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HTTP Proxy port number.\nThe port number of the HTTP/HTTPS proxy must be between 1 and 65535, inclusive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long Port {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Protocol to use for the HTTP/HTTPS Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Protocol {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The username for the HTTP/HTTPS Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Username {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesProxyConfig initObject = new Intersight.Model.KubernetesProxyConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Hostname"))
            {
                initObject.Hostname = this.Hostname;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Port"))
            {
                initObject.Port = this.Port;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Protocol"))
            {
                initObject.Protocol = this.Protocol;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Username"))
            {
                initObject.Username = this.Username;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesObjectMeta.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesObjectMeta")]
    public class InitializeIntersightKubernetesObjectMeta:PSCmdlet
	{
		public InitializeIntersightKubernetesObjectMeta()
		{
            ClassId = KubernetesObjectMeta.ClassIdEnum.KubernetesObjectMeta;
            ObjectType = KubernetesObjectMeta.ObjectTypeEnum.KubernetesObjectMeta;
            
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
        
        public KubernetesObjectMeta.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesObjectMeta.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specific resourceVersion to which this reference is made, if any."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ResourceVersion {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesObjectMeta initObject = new Intersight.Model.KubernetesObjectMeta();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceVersion"))
            {
                initObject.ResourceVersion = this.ResourceVersion;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesLoadBalancer.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesLoadBalancer")]
    public class InitializeIntersightKubernetesLoadBalancer:PSCmdlet
	{
		public InitializeIntersightKubernetesLoadBalancer()
		{
            ClassId = KubernetesLoadBalancer.ClassIdEnum.KubernetesLoadBalancer;
            ObjectType = KubernetesLoadBalancer.ObjectTypeEnum.KubernetesLoadBalancer;
            
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
        
        public KubernetesLoadBalancer.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> IpAddresses {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesLoadBalancer.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesLoadBalancer initObject = new Intersight.Model.KubernetesLoadBalancer();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("IpAddresses"))
            {
                initObject.IpAddresses = this.IpAddresses;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesKeyValue.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesKeyValue")]
    public class InitializeIntersightKubernetesKeyValue:PSCmdlet
	{
		public InitializeIntersightKubernetesKeyValue()
		{
            ClassId = KubernetesKeyValue.ClassIdEnum.KubernetesKeyValue;
            ObjectType = KubernetesKeyValue.ObjectTypeEnum.KubernetesKeyValue;
            
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
        
        public KubernetesKeyValue.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Key or property name in a key/value pair."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Key {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesKeyValue.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Property value in a key/value pair."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Value {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesKeyValue initObject = new Intersight.Model.KubernetesKeyValue();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Key"))
            {
                initObject.Key = this.Key;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesEthernetMatcher.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesEthernetMatcher")]
    public class InitializeIntersightKubernetesEthernetMatcher:PSCmdlet
	{
		public InitializeIntersightKubernetesEthernetMatcher()
		{
            ClassId = KubernetesEthernetMatcher.ClassIdEnum.KubernetesEthernetMatcher;
            ObjectType = KubernetesEthernetMatcher.ObjectTypeEnum.KubernetesEthernetMatcher;
            Type = KubernetesEthernetMatcher.TypeEnum.Name;
            
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
        
        public KubernetesEthernetMatcher.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesEthernetMatcher.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Which property we should use to find the ethernet interface.\n* `Name` - A network interface name, e.g. eth0, eno9.\n* `MacAddress` - A network interface Mac Address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesEthernetMatcher.TypeEnum Type {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The value to match for the property specified by type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Value {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesEthernetMatcher initObject = new Intersight.Model.KubernetesEthernetMatcher();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize KubernetesAddon.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightKubernetesAddon")]
    public class InitializeIntersightKubernetesAddon:PSCmdlet
	{
		public InitializeIntersightKubernetesAddon()
		{
            ClassId = KubernetesAddon.ClassIdEnum.KubernetesAddon;
            ObjectType = KubernetesAddon.ObjectTypeEnum.KubernetesAddon;
            
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
        /// <para type="description">"Addon configuration settings that are specific to a single cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.KubernetesAddonConfiguration AddonConfiguration {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Addon policy associated with the addon."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.MoMoRef AddonPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesAddon.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of addon to be installed on a Kubernetes cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public KubernetesAddon.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.KubernetesAddon initObject = new Intersight.Model.KubernetesAddon();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AddonConfiguration"))
            {
                initObject.AddonConfiguration = this.AddonConfiguration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AddonPolicy"))
            {
                initObject.AddonPolicy = this.AddonPolicy;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}