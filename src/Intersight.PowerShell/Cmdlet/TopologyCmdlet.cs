using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TopologyEventDetails.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTopologyEventDetails", SupportsShouldProcess = true)]
    public class NewIntersightTopologyEventDetails : NewCmdletBase
    {
        public NewIntersightTopologyEventDetails()
        {
            ApiInstance = new TopologyApi(Config);
            ModelObject = new TopologyEventDetails();
            MethodName = "CreateTopologyEventDetailsWithHttpInfo";
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
        /// <para type="description">"Category of details to return.\n* `Unknown` - Unknown or unspecified category.\n* `Alarms` - Alarm detail records for the selected topology interval.\n* `Requests` - Workflow request detail records for the selected topology interval."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TopologyEventDetails.CategoryEnum Category
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Exclusive historical window end."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndTime
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Used only for current topology request overlays."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Granularity
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"When true, include all scoped records contributing to the selected value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IncludeAll
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
        /// <para type="description">"Inclusive historical window start."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime StartTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Moid of the root topology object the request is scoped to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TopologyMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"ObjectType of the root topology object the request is scoped to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TopologyObjectType
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Root topology view type selected by the UI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ViewType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public String IfMatch
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn't happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource's ETag doesn't match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don't have to be identical byte for byte.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public String IfNoneMatch
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TopologyTimelineEvent.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTopologyTimelineEvent", SupportsShouldProcess = true)]
    public class NewIntersightTopologyTimelineEvent : NewCmdletBase
    {
        public NewIntersightTopologyTimelineEvent()
        {
            ApiInstance = new TopologyApi(Config);
            ModelObject = new TopologyTimelineEvent();
            MethodName = "CreateTopologyTimelineEventWithHttpInfo";
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
        /// <para type="description">"Exclusive historical window end."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndTime
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Used only for current topology request overlays."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Granularity
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
        /// <para type="description">"Inclusive historical window start."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime StartTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Moid of the root topology object the request is scoped to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TopologyMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"ObjectType of the root topology object the request is scoped to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TopologyObjectType
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Root topology view type selected by the UI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ViewType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public String IfMatch
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn't happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource's ETag doesn't match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don't have to be identical byte for byte.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public String IfNoneMatch
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TopologyView.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTopologyView", SupportsShouldProcess = true)]
    public class NewIntersightTopologyView : NewCmdletBase
    {
        public NewIntersightTopologyView()
        {
            ApiInstance = new TopologyApi(Config);
            ModelObject = new TopologyView();
            MethodName = "CreateTopologyViewWithHttpInfo";
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
        /// <para type="description">"Exclusive historical window end."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime EndTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Used only for current topology request overlays."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Granularity
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
        /// <para type="description">"Inclusive historical window start."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime StartTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Moid of the root topology object the request is scoped to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TopologyMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"ObjectType of the root topology object the request is scoped to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TopologyObjectType
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Root topology view type selected by the UI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ViewType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public String IfMatch
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn't happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource's ETag doesn't match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don't have to be identical byte for byte.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public String IfNoneMatch
        {
            get;
            set;
        }
    }
}