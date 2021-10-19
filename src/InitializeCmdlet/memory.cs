using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize MemoryPersistentMemoryLogicalNamespace.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMemoryPersistentMemoryLogicalNamespace")]
    public class InitializeIntersightMemoryPersistentMemoryLogicalNamespace:PSCmdlet
	{
		public InitializeIntersightMemoryPersistentMemoryLogicalNamespace()
		{
            ClassId = MemoryPersistentMemoryLogicalNamespace.ClassIdEnum.MemoryPersistentMemoryLogicalNamespace;
            Mode = MemoryPersistentMemoryLogicalNamespace.ModeEnum.Raw;
            ObjectType = MemoryPersistentMemoryLogicalNamespace.ObjectTypeEnum.MemoryPersistentMemoryLogicalNamespace;
            SocketId = MemoryPersistentMemoryLogicalNamespace.SocketIdEnum.NUMBER_1;
            SocketMemoryId = MemoryPersistentMemoryLogicalNamespace.SocketMemoryIdEnum.NotApplicable;
            
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
        /// <para type="description">"Capacity of this Namespace that is created or modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 9.223372036854776e+18)]
        public long Capacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryLogicalNamespace.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mode of this Namespace that is created or modified.\n* `raw` - The raw mode of Persistent Memory Namespace.\n* `block` - The block mode of Persistent Memory Namespace."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryLogicalNamespace.ModeEnum Mode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of this Namespace to be created on the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9#_-][a-zA-Z0-9#_ -]*$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryLogicalNamespace.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Socket ID of the region on which this Namespace has to be created or modified.\n* `1` - The first CPU socket in a server.\n* `2` - The second CPU socket in a server.\n* `3` - The third CPU socket in a server.\n* `4` - The fourth CPU socket in a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryLogicalNamespace.SocketIdEnum SocketId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Socket Memory ID of the region on which this Namespace has to be created or modified.\n* `Not Applicable` - The socket memory ID is not applicable if app-direct persistent memory type is selected in the goal.\n* `2` - The second socket memory ID within a socket in a server.\n* `4` - The fourth socket memory ID within a socket in a server.\n* `6` - The sixth socket memory ID within a socket in a server.\n* `8` - The eighth socket memory ID within a socket in a server.\n* `10` - The tenth socket memory ID within a socket in a server.\n* `12` - The twelfth socket memory ID within a socket in a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryLogicalNamespace.SocketMemoryIdEnum SocketMemoryId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MemoryPersistentMemoryLogicalNamespace initObject = new Intersight.Model.MemoryPersistentMemoryLogicalNamespace();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capacity"))
            {
                initObject.Capacity = this.Capacity;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Mode"))
            {
                initObject.Mode = this.Mode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SocketId"))
            {
                initObject.SocketId = this.SocketId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SocketMemoryId"))
            {
                initObject.SocketMemoryId = this.SocketMemoryId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize MemoryPersistentMemoryGoal.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMemoryPersistentMemoryGoal")]
    public class InitializeIntersightMemoryPersistentMemoryGoal:PSCmdlet
	{
		public InitializeIntersightMemoryPersistentMemoryGoal()
		{
            ClassId = MemoryPersistentMemoryGoal.ClassIdEnum.MemoryPersistentMemoryGoal;
            ObjectType = MemoryPersistentMemoryGoal.ObjectTypeEnum.MemoryPersistentMemoryGoal;
            PersistentMemoryType = MemoryPersistentMemoryGoal.PersistentMemoryTypeEnum.AppDirect;
            SocketId = MemoryPersistentMemoryGoal.SocketIdEnum.AllSockets;
            
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
        
        public MemoryPersistentMemoryGoal.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Volatile memory percentage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MemoryModePercentage {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryGoal.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the Persistent Memory configuration where the Persistent Memory Modules are combined in an interleaved set or not.\n* `app-direct` - The App Direct interleaved Persistent Memory type.\n* `app-direct-non-interleaved` - The App Direct non-interleaved Persistent Memory type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryGoal.PersistentMemoryTypeEnum PersistentMemoryType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CPU Socket ID to which this goal will be applied.\n* `All Sockets` - All the CPU socket IDs in a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryGoal.SocketIdEnum SocketId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MemoryPersistentMemoryGoal initObject = new Intersight.Model.MemoryPersistentMemoryGoal();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryModePercentage"))
            {
                initObject.MemoryModePercentage = this.MemoryModePercentage;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PersistentMemoryType"))
            {
                initObject.PersistentMemoryType = this.PersistentMemoryType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SocketId"))
            {
                initObject.SocketId = this.SocketId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize MemoryPersistentMemoryLocalSecurity.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMemoryPersistentMemoryLocalSecurity")]
    public class InitializeIntersightMemoryPersistentMemoryLocalSecurity:PSCmdlet
	{
		public InitializeIntersightMemoryPersistentMemoryLocalSecurity()
		{
            ClassId = MemoryPersistentMemoryLocalSecurity.ClassIdEnum.MemoryPersistentMemoryLocalSecurity;
            ObjectType = MemoryPersistentMemoryLocalSecurity.ObjectTypeEnum.MemoryPersistentMemoryLocalSecurity;
            
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
        
        public MemoryPersistentMemoryLocalSecurity.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Persistent Memory Security state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MemoryPersistentMemoryLocalSecurity.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Secure passphrase to be applied on the Persistent Memory Modules on the server. The allowed characters are a-z, A to Z, 0-9, and special characters =, \\u0021, &, \\#, $, %, +, ^, @, _, *, -."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9=!&#$%+^@_*-]+$")]
        public string SecurePassphrase {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MemoryPersistentMemoryLocalSecurity initObject = new Intersight.Model.MemoryPersistentMemoryLocalSecurity();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SecurePassphrase"))
            {
                initObject.SecurePassphrase = this.SecurePassphrase;
            }
            WriteObject(initObject);
        }

    }
}