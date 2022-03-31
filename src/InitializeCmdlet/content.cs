using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ContentTextParameter.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightContentTextParameter")]
    public class InitializeIntersightContentTextParameter:PSCmdlet
	{
		public InitializeIntersightContentTextParameter()
		{
            ClassId = ContentTextParameter.ClassIdEnum.ContentTextParameter;
            ItemType = ContentTextParameter.ItemTypeEnum.Simple;
            ObjectType = ContentTextParameter.ObjectTypeEnum.ContentTextParameter;
            Type = ContentTextParameter.TypeEnum.Simple;
            
		}
        // <summary>
        /// <para type="description">"The flag that allows single values in content to be extracted as a\nsingle element collection in case the parameter is of Collection type.\nThis flag is applicable for parameters of type Collection only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool AcceptSingleValue {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ContentTextParameter.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the complex type definition in case this is a complex\nparameter. The content.Grammar object must have a complex type, content.ComplexType,\ndefined with the specified name in types collection property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ComplexType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Data to be extracted from text content can be simple type or complex type or collection of\nsimple/complex types. Complex types are group of simple or complex type.\nDelimiter is required to stop parsing list and complex data types.\nisDelimiter specifies whether given TextParameter is a delimiter or regular rule to capture\nthe text data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsDelimiter {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set to true of the next value to capture resides on the same text line of current match.\nBy default textFSM engine gets the next text line on finding the first match."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsNextCaptureOnSameLine {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the collection item in case this is a collection parameter.\n* `simple` - The parameter value to be extracted is of the type simple. All the common scalar typessuch as int, bool, string, etc are represented by the simple enum.\n* `string` - The parameter value to be extracted is of the string type.\n* `integer` - The parameter value to be extracted is of the number type.\n* `float` - The parameter value to be extracted is of the float number type.\n* `boolean` - The parameter value to be extracted is of the boolean type.\n* `json` - The parameter values to be extracted is of the generic JSON literal. JSON type is applicable only if the content to be parsed is of JSON type.\n* `complex` - The parameter value to be extracted is a complex parameter that itself isanother collection of simple/complex parameters.\n* `collection` - The parameter value to be extracted is a collection parameter whose item typeshall be either simple type or complex type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ContentTextParameter.ItemTypeEnum ItemType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the parameter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ContentTextParameter.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The content specific path information that identifies the parameter\nvalue within the content. The value is usually a XPath or JSONPath or a\nregular expression in case of text content."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Path {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Regular expression of the line containing the data to be extracted from text content."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RegexLine {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The flag indicates if the extracted value is secure.\nThis flag is applicable for parameters of type String only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Secure {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the parameter. Accepted values are simple, complex,\ncollection.\n* `simple` - The parameter value to be extracted is of the type simple. All the common scalar typessuch as int, bool, string, etc are represented by the simple enum.\n* `string` - The parameter value to be extracted is of the string type.\n* `integer` - The parameter value to be extracted is of the number type.\n* `float` - The parameter value to be extracted is of the float number type.\n* `boolean` - The parameter value to be extracted is of the boolean type.\n* `json` - The parameter values to be extracted is of the generic JSON literal. JSON type is applicable only if the content to be parsed is of JSON type.\n* `complex` - The parameter value to be extracted is a complex parameter that itself isanother collection of simple/complex parameters.\n* `collection` - The parameter value to be extracted is a collection parameter whose item typeshall be either simple type or complex type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ContentTextParameter.TypeEnum Type {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.ContentTextParameter initObject = new Intersight.Model.ContentTextParameter();
            if (this.MyInvocation.BoundParameters.ContainsKey("AcceptSingleValue"))
            {
                initObject.AcceptSingleValue = this.AcceptSingleValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ComplexType"))
            {
                initObject.ComplexType = this.ComplexType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsDelimiter"))
            {
                initObject.IsDelimiter = this.IsDelimiter;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsNextCaptureOnSameLine"))
            {
                initObject.IsNextCaptureOnSameLine = this.IsNextCaptureOnSameLine;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ItemType"))
            {
                initObject.ItemType = this.ItemType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Path"))
            {
                initObject.Path = this.Path;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegexLine"))
            {
                initObject.RegexLine = this.RegexLine;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Secure"))
            {
                initObject.Secure = this.Secure;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ContentParameter.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightContentParameter")]
    public class InitializeIntersightContentParameter:PSCmdlet
	{
		public InitializeIntersightContentParameter()
		{
            ItemType = ContentParameter.ItemTypeEnum.Simple;
            Type = ContentParameter.TypeEnum.Simple;
            
		}
        // <summary>
        /// <para type="description">"The flag that allows single values in content to be extracted as a\nsingle element collection in case the parameter is of Collection type.\nThis flag is applicable for parameters of type Collection only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool AcceptSingleValue {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ContentParameter.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the complex type definition in case this is a complex\nparameter. The content.Grammar object must have a complex type, content.ComplexType,\ndefined with the specified name in types collection property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ComplexType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the collection item in case this is a collection parameter.\n* `simple` - The parameter value to be extracted is of the type simple. All the common scalar typessuch as int, bool, string, etc are represented by the simple enum.\n* `string` - The parameter value to be extracted is of the string type.\n* `integer` - The parameter value to be extracted is of the number type.\n* `float` - The parameter value to be extracted is of the float number type.\n* `boolean` - The parameter value to be extracted is of the boolean type.\n* `json` - The parameter values to be extracted is of the generic JSON literal. JSON type is applicable only if the content to be parsed is of JSON type.\n* `complex` - The parameter value to be extracted is a complex parameter that itself isanother collection of simple/complex parameters.\n* `collection` - The parameter value to be extracted is a collection parameter whose item typeshall be either simple type or complex type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ContentParameter.ItemTypeEnum ItemType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the parameter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ContentParameter.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The content specific path information that identifies the parameter\nvalue within the content. The value is usually a XPath or JSONPath or a\nregular expression in case of text content."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Path {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The flag indicates if the extracted value is secure.\nThis flag is applicable for parameters of type String only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Secure {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the parameter. Accepted values are simple, complex,\ncollection.\n* `simple` - The parameter value to be extracted is of the type simple. All the common scalar typessuch as int, bool, string, etc are represented by the simple enum.\n* `string` - The parameter value to be extracted is of the string type.\n* `integer` - The parameter value to be extracted is of the number type.\n* `float` - The parameter value to be extracted is of the float number type.\n* `boolean` - The parameter value to be extracted is of the boolean type.\n* `json` - The parameter values to be extracted is of the generic JSON literal. JSON type is applicable only if the content to be parsed is of JSON type.\n* `complex` - The parameter value to be extracted is a complex parameter that itself isanother collection of simple/complex parameters.\n* `collection` - The parameter value to be extracted is a collection parameter whose item typeshall be either simple type or complex type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ContentParameter.TypeEnum Type {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.ContentParameter initObject = new Intersight.Model.ContentParameter();
            if (this.MyInvocation.BoundParameters.ContainsKey("AcceptSingleValue"))
            {
                initObject.AcceptSingleValue = this.AcceptSingleValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ComplexType"))
            {
                initObject.ComplexType = this.ComplexType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ItemType"))
            {
                initObject.ItemType = this.ItemType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Path"))
            {
                initObject.Path = this.Path;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Secure"))
            {
                initObject.Secure = this.Secure;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ContentBaseParameter.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightContentBaseParameter")]
    public class InitializeIntersightContentBaseParameter:PSCmdlet
	{
		public InitializeIntersightContentBaseParameter()
		{
            ItemType = ContentBaseParameter.ItemTypeEnum.Simple;
            Type = ContentBaseParameter.TypeEnum.Simple;
            
		}
        // <summary>
        /// <para type="description">"The flag that allows single values in content to be extracted as a\nsingle element collection in case the parameter is of Collection type.\nThis flag is applicable for parameters of type Collection only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool AcceptSingleValue {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ContentBaseParameter.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the complex type definition in case this is a complex\nparameter. The content.Grammar object must have a complex type, content.ComplexType,\ndefined with the specified name in types collection property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ComplexType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the collection item in case this is a collection parameter.\n* `simple` - The parameter value to be extracted is of the type simple. All the common scalar typessuch as int, bool, string, etc are represented by the simple enum.\n* `string` - The parameter value to be extracted is of the string type.\n* `integer` - The parameter value to be extracted is of the number type.\n* `float` - The parameter value to be extracted is of the float number type.\n* `boolean` - The parameter value to be extracted is of the boolean type.\n* `json` - The parameter values to be extracted is of the generic JSON literal. JSON type is applicable only if the content to be parsed is of JSON type.\n* `complex` - The parameter value to be extracted is a complex parameter that itself isanother collection of simple/complex parameters.\n* `collection` - The parameter value to be extracted is a collection parameter whose item typeshall be either simple type or complex type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ContentBaseParameter.ItemTypeEnum ItemType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the parameter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ContentBaseParameter.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The content specific path information that identifies the parameter\nvalue within the content. The value is usually a XPath or JSONPath or a\nregular expression in case of text content."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Path {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The flag indicates if the extracted value is secure.\nThis flag is applicable for parameters of type String only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Secure {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the parameter. Accepted values are simple, complex,\ncollection.\n* `simple` - The parameter value to be extracted is of the type simple. All the common scalar typessuch as int, bool, string, etc are represented by the simple enum.\n* `string` - The parameter value to be extracted is of the string type.\n* `integer` - The parameter value to be extracted is of the number type.\n* `float` - The parameter value to be extracted is of the float number type.\n* `boolean` - The parameter value to be extracted is of the boolean type.\n* `json` - The parameter values to be extracted is of the generic JSON literal. JSON type is applicable only if the content to be parsed is of JSON type.\n* `complex` - The parameter value to be extracted is a complex parameter that itself isanother collection of simple/complex parameters.\n* `collection` - The parameter value to be extracted is a collection parameter whose item typeshall be either simple type or complex type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ContentBaseParameter.TypeEnum Type {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.ContentBaseParameter initObject = new Intersight.Model.ContentBaseParameter();
            if (this.MyInvocation.BoundParameters.ContainsKey("AcceptSingleValue"))
            {
                initObject.AcceptSingleValue = this.AcceptSingleValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ComplexType"))
            {
                initObject.ComplexType = this.ComplexType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ItemType"))
            {
                initObject.ItemType = this.ItemType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Path"))
            {
                initObject.Path = this.Path;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Secure"))
            {
                initObject.Secure = this.Secure;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ContentComplexType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightContentComplexType")]
    public class InitializeIntersightContentComplexType:PSCmdlet
	{
		public InitializeIntersightContentComplexType()
		{
            ClassId = ContentComplexType.ClassIdEnum.ContentComplexType;
            ObjectType = ContentComplexType.ObjectTypeEnum.ContentComplexType;
            
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
        
        public ContentComplexType.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique name of this complex type within the grammar specification."</para>
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
        
        public ContentComplexType.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.ContentBaseParameter> Parameters {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.ContentComplexType initObject = new Intersight.Model.ContentComplexType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Parameters"))
            {
                initObject.Parameters = this.Parameters;
            }
            WriteObject(initObject);
        }

    }
}