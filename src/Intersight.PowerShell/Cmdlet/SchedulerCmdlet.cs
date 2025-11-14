using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SchedulerSchedulePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSchedulerSchedulePolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSchedulerSchedulePolicy : GetCmdletBase
    {
        public GetIntersightSchedulerSchedulePolicy()
        {
            ApiInstance = new SchedulerApi(Config);
            MethodName = "GetSchedulerSchedulePolicyListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Enable or disable block dates. If set to true, the schedule will not run during the block date interval."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool EnableBlockDates
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The number of profiles, templates and deployments that are using this policy. \nThis is used to determine if the policy can be deleted.\nIf the usageCount is greater than 0, the policy cannot be deleted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long UsageCount
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "QueryParam")]
        [ValidateSet("allpages", "none")]
        public String Inlinecount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">The 'tags' parameter is used to request a summary of the Tag utilization for this resource. When the 'tags' parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "QueryParam")]

        public String Tags
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SchedulerTaskResult.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSchedulerTaskResult", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSchedulerTaskResult : GetCmdletBase
    {
        public GetIntersightSchedulerTaskResult()
        {
            ApiInstance = new SchedulerApi(Config);
            MethodName = "GetSchedulerTaskResultListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship AssociatedObject
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"End time for the scheduled task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime EndTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Start time for the scheduled task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime StartTime
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"A reference to a schedulerTaskSchedule resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public SchedulerTaskScheduleRelationship TaskSchedule
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The timezone for the startTime specified.\n* `Pacific/Niue` - \n* `Africa/Abidjan` - \n* `Africa/Accra` - \n* `Africa/Addis_Ababa` - \n* `Africa/Algiers` - \n* `Africa/Asmara` - \n* `Africa/Bamako` - \n* `Africa/Bangui` - \n* `Africa/Banjul` - \n* `Africa/Bissau` - \n* `Africa/Blantyre` - \n* `Africa/Brazzaville` - \n* `Africa/Bujumbura` - \n* `Africa/Cairo` - \n* `Africa/Casablanca` - \n* `Africa/Ceuta` - \n* `Africa/Conakry` - \n* `Africa/Dakar` - \n* `Africa/Dar_es_Salaam` - \n* `Africa/Djibouti` - \n* `Africa/Douala` - \n* `Africa/El_Aaiun` - \n* `Africa/Freetown` - \n* `Africa/Gaborone` - \n* `Africa/Harare` - \n* `Africa/Johannesburg` - \n* `Africa/Juba` - \n* `Africa/Kampala` - \n* `Africa/Khartoum` - \n* `Africa/Kigali` - \n* `Africa/Kinshasa` - \n* `Africa/Lagos` - \n* `Africa/Libreville` - \n* `Africa/Lome` - \n* `Africa/Luanda` - \n* `Africa/Lubumbashi` - \n* `Africa/Lusaka` - \n* `Africa/Malabo` - \n* `Africa/Maputo` - \n* `Africa/Maseru` - \n* `Africa/Mbabane` - \n* `Africa/Mogadishu` - \n* `Africa/Monrovia` - \n* `Africa/Nairobi` - \n* `Africa/Ndjamena` - \n* `Africa/Niamey` - \n* `Africa/Nouakchott` - \n* `Africa/Ouagadougou` - \n* `Africa/Porto-Novo` - \n* `Africa/Sao_Tome` - \n* `Africa/Tripoli` - \n* `Africa/Tunis` - \n* `Africa/Windhoek` - \n* `America/Adak` - \n* `America/Anchorage` - \n* `America/Anguilla` - \n* `America/Antigua` - \n* `America/Araguaina` - \n* `America/Argentina/Buenos_Aires` - \n* `America/Argentina/Catamarca` - \n* `America/Argentina/Cordoba` - \n* `America/Argentina/Jujuy` - \n* `America/Argentina/La_Rioja` - \n* `America/Argentina/Mendoza` - \n* `America/Argentina/Rio_Gallegos` - \n* `America/Argentina/Salta` - \n* `America/Argentina/San_Juan` - \n* `America/Argentina/San_Luis` - \n* `America/Argentina/Tucuman` - \n* `America/Argentina/Ushuaia` - \n* `America/Aruba` - \n* `America/Asuncion` - \n* `America/Atikokan` - \n* `America/Bahia` - \n* `America/Bahia_Banderas` - \n* `America/Barbados` - \n* `America/Belem` - \n* `America/Belize` - \n* `America/Blanc-Sablon` - \n* `America/Boa_Vista` - \n* `America/Bogota` - \n* `America/Boise` - \n* `America/Cambridge_Bay` - \n* `America/Campo_Grande` - \n* `America/Cancun` - \n* `America/Caracas` - \n* `America/Cayenne` - \n* `America/Cayman` - \n* `America/Chicago` - \n* `America/Chihuahua` - \n* `America/Costa_Rica` - \n* `America/Creston` - \n* `America/Cuiaba` - \n* `America/Curacao` - \n* `America/Danmarkshavn` - \n* `America/Dawson` - \n* `America/Dawson_Creek` - \n* `America/Denver` - \n* `America/Detroit` - \n* `America/Dominica` - \n* `America/Edmonton` - \n* `America/Eirunepe` - \n* `America/El_Salvador` - \n* `America/Fortaleza` - \n* `America/Glace_Bay` - \n* `America/Godthab` - \n* `America/Goose_Bay` - \n* `America/Grand_Turk` - \n* `America/Grenada` - \n* `America/Guadeloupe` - \n* `America/Guatemala` - \n* `America/Guayaquil` - \n* `America/Guyana` - \n* `America/Halifax` - \n* `America/Havana` - \n* `America/Hermosillo` - \n* `America/Indiana/Indianapolis` - \n* `America/Indiana/Knox` - \n* `America/Indiana/Marengo` - \n* `America/Indiana/Petersburg` - \n* `America/Indiana/Tell_City` - \n* `America/Indiana/Vevay` - \n* `America/Indiana/Vincennes` - \n* `America/Indiana/Winamac` - \n* `America/Inuvik` - \n* `America/Iqaluit` - \n* `America/Jamaica` - \n* `America/Juneau` - \n* `America/Kentucky/Louisville` - \n* `America/Kentucky/Monticello` - \n* `America/Kralendijk` - \n* `America/La_Paz` - \n* `America/Lima` - \n* `America/Los_Angeles` - \n* `America/Lower_Princes` - \n* `America/Maceio` - \n* `America/Managua` - \n* `America/Manaus` - \n* `America/Marigot` - \n* `America/Martinique` - \n* `America/Matamoros` - \n* `America/Mazatlan` - \n* `America/Menominee` - \n* `America/Merida` - \n* `America/Metlakatla` - \n* `America/Mexico_City` - \n* `America/Miquelon` - \n* `America/Moncton` - \n* `America/Monterrey` - \n* `America/Montevideo` - \n* `America/Montreal` - \n* `America/Montserrat` - \n* `America/Nassau` - \n* `America/New_York` - \n* `America/Nipigon` - \n* `America/Nome` - \n* `America/Noronha` - \n* `America/North_Dakota/Beulah` - \n* `America/North_Dakota/Center` - \n* `America/North_Dakota/New_Salem` - \n* `America/Ojinaga` - \n* `America/Panama` - \n* `America/Pangnirtung` - \n* `America/Paramaribo` - \n* `America/Phoenix` - \n* `America/Port-au-Prince` - \n* `America/Port_of_Spain` - \n* `America/Porto_Velho` - \n* `America/Puerto_Rico` - \n* `America/Rainy_River` - \n* `America/Rankin_Inlet` - \n* `America/Recife` - \n* `America/Regina` - \n* `America/Resolute` - \n* `America/Rio_Branco` - \n* `America/Santa_Isabel` - \n* `America/Santarem` - \n* `America/Santiago` - \n* `America/Santo_Domingo` - \n* `America/Sao_Paulo` - \n* `America/Scoresbysund` - \n* `America/Shiprock` - \n* `America/Sitka` - \n* `America/St_Barthelemy` - \n* `America/St_Johns` - \n* `America/St_Kitts` - \n* `America/St_Lucia` - \n* `America/St_Thomas` - \n* `America/St_Vincent` - \n* `America/Swift_Current` - \n* `America/Tegucigalpa` - \n* `America/Thule` - \n* `America/Thunder_Bay` - \n* `America/Tijuana` - \n* `America/Toronto` - \n* `America/Tortola` - \n* `America/Vancouver` - \n* `America/Whitehorse` - \n* `America/Winnipeg` - \n* `America/Yakutat` - \n* `America/Yellowknife` - \n* `Antarctica/Casey` - \n* `Antarctica/Davis` - \n* `Antarctica/DumontDUrville` - \n* `Antarctica/Macquarie` - \n* `Antarctica/Mawson` - \n* `Antarctica/McMurdo` - \n* `Antarctica/Palmer` - \n* `Antarctica/Rothera` - \n* `Antarctica/South_Pole` - \n* `Antarctica/Syowa` - \n* `Antarctica/Troll` - \n* `Antarctica/Vostok` - \n* `Arctic/Longyearbyen` - \n* `Asia/Aden` - \n* `Asia/Almaty` - \n* `Asia/Amman` - \n* `Asia/Anadyr` - \n* `Asia/Aqtau` - \n* `Asia/Aqtobe` - \n* `Asia/Ashgabat` - \n* `Asia/Baghdad` - \n* `Asia/Bahrain` - \n* `Asia/Baku` - \n* `Asia/Bangkok` - \n* `Asia/Beirut` - \n* `Asia/Bishkek` - \n* `Asia/Brunei` - \n* `Asia/Calcutta` - \n* `Asia/Choibalsan` - \n* `Asia/Chongqing` - \n* `Asia/Colombo` - \n* `Asia/Damascus` - \n* `Asia/Dhaka` - \n* `Asia/Dili` - \n* `Asia/Dubai` - \n* `Asia/Dushanbe` - \n* `Asia/Gaza` - \n* `Asia/Harbin` - \n* `Asia/Hebron` - \n* `Asia/Ho_Chi_Minh` - \n* `Asia/Hong_Kong` - \n* `Asia/Hovd` - \n* `Asia/Irkutsk` - \n* `Asia/Jakarta` - \n* `Asia/Jayapura` - \n* `Asia/Jerusalem` - \n* `Asia/Kabul` - \n* `Asia/Kamchatka` - \n* `Asia/Karachi` - \n* `Asia/Kashgar` - \n* `Asia/Kathmandu` - \n* `Asia/Katmandu` - \n* `Asia/Khandyga` - \n* `Asia/Kolkata` - \n* `Asia/Krasnoyarsk` - \n* `Asia/Kuala_Lumpur` - \n* `Asia/Kuching` - \n* `Asia/Kuwait` - \n* `Asia/Macau` - \n* `Asia/Magadan` - \n* `Asia/Makassar` - \n* `Asia/Manila` - \n* `Asia/Muscat` - \n* `Asia/Nicosia` - \n* `Asia/Novokuznetsk` - \n* `Asia/Novosibirsk` - \n* `Asia/Omsk` - \n* `Asia/Oral` - \n* `Asia/Phnom_Penh` - \n* `Asia/Pontianak` - \n* `Asia/Pyongyang` - \n* `Asia/Qatar` - \n* `Asia/Qyzylorda` - \n* `Asia/Rangoon` - \n* `Asia/Riyadh` - \n* `Asia/Saigon` - \n* `Asia/Sakhalin` - \n* `Asia/Samarkand` - \n* `Asia/Seoul` - \n* `Asia/Shanghai` - \n* `Asia/Singapore` - \n* `Asia/Taipei` - \n* `Asia/Tashkent` - \n* `Asia/Tbilisi` - \n* `Asia/Tehran` - \n* `Asia/Thimphu` - \n* `Asia/Tokyo` - \n* `Asia/Ulaanbaatar` - \n* `Asia/Urumqi` - \n* `Asia/Ust-Nera` - \n* `Asia/Vientiane` - \n* `Asia/Vladivostok` - \n* `Asia/Yakutsk` - \n* `Asia/Yekaterinburg` - \n* `Asia/Yerevan` - \n* `Atlantic/Azores` - \n* `Atlantic/Bermuda` - \n* `Atlantic/Canary` - \n* `Atlantic/Cape_Verde` - \n* `Atlantic/Faroe` - \n* `Atlantic/Madeira` - \n* `Atlantic/Reykjavik` - \n* `Atlantic/South_Georgia` - \n* `Atlantic/St_Helena` - \n* `Atlantic/Stanley` - \n* `Australia/Adelaide` - \n* `Australia/Brisbane` - \n* `Australia/Broken_Hill` - \n* `Australia/Currie` - \n* `Australia/Darwin` - \n* `Australia/Eucla` - \n* `Australia/Hobart` - \n* `Australia/Lindeman` - \n* `Australia/Lord_Howe` - \n* `Australia/Melbourne` - \n* `Australia/Perth` - \n* `Australia/Sydney` - \n* `Etc/GMT` - \n* `Europe/Amsterdam` - \n* `Europe/Andorra` - \n* `Europe/Athens` - \n* `Europe/Belgrade` - \n* `Europe/Berlin` - \n* `Europe/Bratislava` - \n* `Europe/Brussels` - \n* `Europe/Bucharest` - \n* `Europe/Budapest` - \n* `Europe/Busingen` - \n* `Europe/Chisinau` - \n* `Europe/Copenhagen` - \n* `Europe/Dublin` - \n* `Europe/Gibraltar` - \n* `Europe/Guernsey` - \n* `Europe/Helsinki` - \n* `Europe/Isle_of_Man` - \n* `Europe/Istanbul` - \n* `Europe/Jersey` - \n* `Europe/Kaliningrad` - \n* `Europe/Kiev` - \n* `Europe/Lisbon` - \n* `Europe/Ljubljana` - \n* `Europe/London` - \n* `Europe/Luxembourg` - \n* `Europe/Madrid` - \n* `Europe/Malta` - \n* `Europe/Mariehamn` - \n* `Europe/Minsk` - \n* `Europe/Monaco` - \n* `Europe/Moscow` - \n* `Europe/Oslo` - \n* `Europe/Paris` - \n* `Europe/Podgorica` - \n* `Europe/Prague` - \n* `Europe/Riga` - \n* `Europe/Rome` - \n* `Europe/Samara` - \n* `Europe/San_Marino` - \n* `Europe/Sarajevo` - \n* `Europe/Simferopol` - \n* `Europe/Skopje` - \n* `Europe/Sofia` - \n* `Europe/Stockholm` - \n* `Europe/Tallinn` - \n* `Europe/Tirane` - \n* `Europe/Uzhgorod` - \n* `Europe/Vaduz` - \n* `Europe/Vatican` - \n* `Europe/Vienna` - \n* `Europe/Vilnius` - \n* `Europe/Volgograd` - \n* `Europe/Warsaw` - \n* `Europe/Zagreb` - \n* `Europe/Zaporozhye` - \n* `Europe/Zurich` - \n* `Indian/Antananarivo` - \n* `Indian/Chagos` - \n* `Indian/Christmas` - \n* `Indian/Cocos` - \n* `Indian/Comoro` - \n* `Indian/Kerguelen` - \n* `Indian/Mahe` - \n* `Indian/Maldives` - \n* `Indian/Mauritius` - \n* `Indian/Mayotte` - \n* `Indian/Reunion` - \n* `Pacific/Apia` - \n* `Pacific/Auckland` - \n* `Pacific/Chatham` - \n* `Pacific/Chuuk` - \n* `Pacific/Easter` - \n* `Pacific/Efate` - \n* `Pacific/Enderbury` - \n* `Pacific/Fakaofo` - \n* `Pacific/Fiji` - \n* `Pacific/Funafuti` - \n* `Pacific/Galapagos` - \n* `Pacific/Gambier` - \n* `Pacific/Guadalcanal` - \n* `Pacific/Guam` - \n* `Pacific/Honolulu` - \n* `Pacific/Johnston` - \n* `Pacific/Kiritimati` - \n* `Pacific/Kosrae` - \n* `Pacific/Kwajalein` - \n* `Pacific/Majuro` - \n* `Pacific/Marquesas` - \n* `Pacific/Midway` - \n* `Pacific/Nauru` - \n* `Pacific/Norfolk` - \n* `Pacific/Noumea` - \n* `Pacific/Pago_Pago` - \n* `Pacific/Palau` - \n* `Pacific/Pitcairn` - \n* `Pacific/Pohnpei` - \n* `Pacific/Port_Moresby` - \n* `Pacific/Rarotonga` - \n* `Pacific/Saipan` - \n* `Pacific/Tahiti` - \n* `Pacific/Tarawa` - \n* `Pacific/Tongatapu` - \n* `Pacific/Wake` - \n* `Pacific/Wallis` - \n* `UTC` -"</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public SchedulerTaskResult.VarTimeZoneEnum TimeZone
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "QueryParam")]
        [ValidateSet("allpages", "none")]
        public String Inlinecount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">The 'tags' parameter is used to request a summary of the Tag utilization for this resource. When the 'tags' parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "QueryParam")]

        public String Tags
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SchedulerTaskSchedule.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSchedulerTaskSchedule", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSchedulerTaskSchedule : GetCmdletBase
    {
        public GetIntersightSchedulerTaskSchedule()
        {
            ApiInstance = new SchedulerApi(Config);
            MethodName = "GetSchedulerTaskScheduleListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The action of the scheduled task such as suspend or resume.\n* `None` - No action is set (default).\n* `Suspend` - Suspend a scheduled task indefinitely.\n* `Resume` - Resume a suspended scheduled task.\n* `SuspendTill` - Suspend the scheduled task until a specified end-date. Not supported in this release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public SchedulerTaskSchedule.ActionEnum Action
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship AssociatedObject
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A description to describe the schedule for easier identification."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Description
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The last action for the scheduled task is saved in this field. Set to none if there was no action.\n* `None` - No action is set (default).\n* `Suspend` - Suspend a scheduled task indefinitely.\n* `Resume` - Resume a suspended scheduled task.\n* `SuspendTill` - Suspend the scheduled task until a specified end-date. Not supported in this release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public SchedulerTaskSchedule.LastActionEnum LastAction
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A schedule name for easier identification (not required to be unique)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a schedulerSchedulePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public SchedulerSchedulePolicyRelationship Policy
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Suspend a task until an end date. this applies only to the action suspendTill."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime SuspendEndTime
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"An Enum describing the type of scheduler to use.\n* `None` - No value was set for the schedule type (Enum value None).\n* `OneTime` - Define a one-time task execution time that will not automatically repeat.\n* `Recurring` - Specify a recurring task cadence based on a predefined pattern, such as daily, weekly, monthly, or every <interval> pattern."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public SchedulerTaskSchedule.TypeEnum Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates if the schedule is policy based or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool UsePolicy
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a workflowWorkflowDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public WorkflowWorkflowDefinitionRelationship WorkflowDefinition
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "QueryParam")]
        [ValidateSet("allpages", "none")]
        public String Inlinecount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">The 'tags' parameter is used to request a summary of the Tag utilization for this resource. When the 'tags' parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "QueryParam")]

        public String Tags
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New SchedulerSchedulePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightSchedulerSchedulePolicy")]
    public class NewIntersightSchedulerSchedulePolicy : NewCmdletBase
    {
        public NewIntersightSchedulerSchedulePolicy()
        {
            ApiInstance = new SchedulerApi(Config);
            ModelObject = new SchedulerSchedulePolicy();
            MethodName = "CreateSchedulerSchedulePolicyWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<SchedulerBlockDate> BlockDates
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Enable or disable block dates. If set to true, the schedule will not run during the block date interval."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableBlockDates
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<SchedulerBaseScheduleParams> ScheduleParams
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
    /// <para type="synopsis">This is the cmdlet to New SchedulerTaskSchedule.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightSchedulerTaskSchedule")]
    public class NewIntersightSchedulerTaskSchedule : NewCmdletBase
    {
        public NewIntersightSchedulerTaskSchedule()
        {
            ApiInstance = new SchedulerApi(Config);
            ModelObject = new SchedulerTaskSchedule();
            MethodName = "CreateSchedulerTaskScheduleWithHttpInfo";
        }


        // <summary>
        /// <para type="description">"The action of the scheduled task such as suspend or resume.\n* `None` - No action is set (default).\n* `Suspend` - Suspend a scheduled task indefinitely.\n* `Resume` - Resume a suspended scheduled task.\n* `SuspendTill` - Suspend the scheduled task until a specified end-date. Not supported in this release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SchedulerTaskSchedule.ActionEnum Action
        {
            get;
            set;
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
        /// <para type="description">"A description to describe the schedule for easier identification."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
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
        /// <para type="description">"A schedule name for easier identification (not required to be unique)."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a schedulerSchedulePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SchedulerSchedulePolicyRelationship Policy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"According to the schedule type this property is evaluated. If the property Type is set to OneTime, then the ObjectType must be scheduler.OneTimeScheduleParams. If the Type is Recurring, then the ObjectType must be scheduler.RecurringScheduleParams."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SchedulerBaseScheduleParams ScheduleParams
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Suspend a task until an end date. this applies only to the action suspendTill."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime SuspendEndTime
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
        /// <para type="description">"According to the schedule type the recurring params are populated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SchedulerRestStimTaskRequest TaskRequest
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An Enum describing the type of scheduler to use.\n* `None` - No value was set for the schedule type (Enum value None).\n* `OneTime` - Define a one-time task execution time that will not automatically repeat.\n* `Recurring` - Specify a recurring task cadence based on a predefined pattern, such as daily, weekly, monthly, or every <interval> pattern."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SchedulerTaskSchedule.TypeEnum Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates if the schedule is policy based or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool UsePolicy
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
    /// <para type="synopsis">This is the cmdlet to Remove SchedulerSchedulePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightSchedulerSchedulePolicy")]
    public class RemoveIntersightSchedulerSchedulePolicy : RemoveCmdletBase
    {
        public RemoveIntersightSchedulerSchedulePolicy()
        {
            ApiInstance = new SchedulerApi(Config);
            MethodName = "DeleteSchedulerSchedulePolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove SchedulerTaskResult.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightSchedulerTaskResult")]
    public class RemoveIntersightSchedulerTaskResult : RemoveCmdletBase
    {
        public RemoveIntersightSchedulerTaskResult()
        {
            ApiInstance = new SchedulerApi(Config);
            MethodName = "DeleteSchedulerTaskResultWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove SchedulerTaskSchedule.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightSchedulerTaskSchedule")]
    public class RemoveIntersightSchedulerTaskSchedule : RemoveCmdletBase
    {
        public RemoveIntersightSchedulerTaskSchedule()
        {
            ApiInstance = new SchedulerApi(Config);
            MethodName = "DeleteSchedulerTaskScheduleWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set SchedulerSchedulePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightSchedulerSchedulePolicy")]
    public class SetIntersightSchedulerSchedulePolicy : SetCmdletBase
    {
        public SetIntersightSchedulerSchedulePolicy()
        {
            ApiInstance = new SchedulerApi(Config);
            ModelObject = new SchedulerSchedulePolicy();
            MethodName = "UpdateSchedulerSchedulePolicyWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<SchedulerBlockDate> BlockDates
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Enable or disable block dates. If set to true, the schedule will not run during the block date interval."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableBlockDates
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<SchedulerBaseScheduleParams> ScheduleParams
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
        /// <para type="description">For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public String IfMatch
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set SchedulerTaskSchedule.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightSchedulerTaskSchedule")]
    public class SetIntersightSchedulerTaskSchedule : SetCmdletBase
    {
        public SetIntersightSchedulerTaskSchedule()
        {
            ApiInstance = new SchedulerApi(Config);
            ModelObject = new SchedulerTaskSchedule();
            MethodName = "UpdateSchedulerTaskScheduleWithHttpInfo";
        }


        // <summary>
        /// <para type="description">"The action of the scheduled task such as suspend or resume.\n* `None` - No action is set (default).\n* `Suspend` - Suspend a scheduled task indefinitely.\n* `Resume` - Resume a suspended scheduled task.\n* `SuspendTill` - Suspend the scheduled task until a specified end-date. Not supported in this release."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SchedulerTaskSchedule.ActionEnum Action
        {
            get;
            set;
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
        /// <para type="description">"A description to describe the schedule for easier identification."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A schedule name for easier identification (not required to be unique)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a schedulerSchedulePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SchedulerSchedulePolicyRelationship Policy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"According to the schedule type this property is evaluated. If the property Type is set to OneTime, then the ObjectType must be scheduler.OneTimeScheduleParams. If the Type is Recurring, then the ObjectType must be scheduler.RecurringScheduleParams."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SchedulerBaseScheduleParams ScheduleParams
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Suspend a task until an end date. this applies only to the action suspendTill."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime SuspendEndTime
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
        /// <para type="description">"According to the schedule type the recurring params are populated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SchedulerRestStimTaskRequest TaskRequest
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An Enum describing the type of scheduler to use.\n* `None` - No value was set for the schedule type (Enum value None).\n* `OneTime` - Define a one-time task execution time that will not automatically repeat.\n* `Recurring` - Specify a recurring task cadence based on a predefined pattern, such as daily, weekly, monthly, or every <interval> pattern."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SchedulerTaskSchedule.TypeEnum Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates if the schedule is policy based or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool UsePolicy
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
    }
}