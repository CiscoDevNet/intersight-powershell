#
# Cisco Intersight
# Cisco Intersight is a management platform delivered as a service with embedded analytics for your Cisco and 3rd party IT infrastructure. This platform offers an intelligent level of management that enables IT organizations to analyze, simplify, and automate their environments in more advanced ways than the prior generations of tools. Cisco Intersight provides an integrated and intuitive management experience for resources in the traditional data center as well as at the edge. With flexible deployment options to address complex security needs, getting started with Intersight is quick and easy. Cisco Intersight has deep integration with Cisco UCS and HyperFlex systems allowing for remote deployment, configuration, and ongoing maintenance. The model-based deployment works for a single system in a remote location or hundreds of systems in a data center and enables rapid, standardized configuration and deployment. It also streamlines maintaining those systems whether you are working with small or very large configurations. The Intersight OpenAPI document defines the complete set of properties that are returned in the HTTP response. From that perspective, a client can expect that no additional properties are returned, unless these properties are explicitly defined in the OpenAPI document. However, when a client uses an older version of the Intersight OpenAPI document, the server may send additional properties because the software is more recent than the client. In that case, the client may receive properties that it does not know about. Some generated SDKs perform a strict validation of the HTTP response body against the OpenAPI document. This document was created on 2021-02-05T15:05:56Z.
# Version: 1.0.9-3562
# Contact: intersight@cisco.com
# Generated by OpenAPI Generator: https://openapi-generator.tech
#

<#
.SYNOPSIS

No summary available.

.DESCRIPTION

Feedback data that collected on the UI from user.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER AccountName
Account name of the feedback sender. Copied in order to be persisted in case of account removal.
.PARAMETER AlternativeFollowUpEmails
No description available.
.PARAMETER Comment
Text of the feedback as provided by the user, if it is a bug or a comment.
.PARAMETER Email
User's email address details.
.PARAMETER Evaluation
Evalation rating as provided by the user to capture user sentiment regarding the issue. * `Excellent` - Option that specifies user's excelent evaluation. * `Poor` - Option that specifies user's poor evaluation. * `Fair` - Option that specifies user's fair evaluation. * `Good` - Option that specifies user's good evaluation.
.PARAMETER FollowUp
If a user is open for follow-up or not.
.PARAMETER TraceIds
Bunch of last traceId for reproducing user last activity.
.PARAMETER Type
Type of the feedback from user. * `Evaluation` - User's feedback classified as an evaluation. * `Bug` - User's feedback classified as a bug.
.OUTPUTS

FeedbackFeedbackData<PSCustomObject>
#>

function Initialize-IntersightFeedbackFeedbackData {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("feedback.FeedbackData")]
        [String]
        ${ClassId} = "feedback.FeedbackData",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("feedback.FeedbackData")]
        [String]
        ${ObjectType} = "feedback.FeedbackData",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AccountName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${AlternativeFollowUpEmails},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Comment},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Email},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("Excellent", "Poor", "Fair", "Good")]
        [String]
        ${Evaluation} = "Excellent",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${FollowUp},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TraceIds},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("Evaluation", "Bug")]
        [String]
        ${Type} = "Evaluation"
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightFeedbackFeedbackData' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$ClassId) {
            throw "invalid value for 'ClassId', 'ClassId' cannot be null."
        }

        if (!$ObjectType) {
            throw "invalid value for 'ObjectType', 'ObjectType' cannot be null."
        }

        if (!$AlternativeFollowUpEmails -and $AlternativeFollowUpEmails.length -gt 5) {
            throw "invalid value for 'AlternativeFollowUpEmails', number of items must be less than or equal to 5."
        }

        if (!$Comment -and $Comment.length -gt 1500) {
            throw "invalid value for 'Comment', the character length must be smaller than or equal to 1500."
        }

        
        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "AccountName" = ${AccountName}
            "AlternativeFollowUpEmails" = ${AlternativeFollowUpEmails}
            "Comment" = ${Comment}
            "Email" = ${Email}
            "Evaluation" = ${Evaluation}
            "FollowUp" = ${FollowUp}
            "TraceIds" = ${TraceIds}
            "Type" = ${Type}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to FeedbackFeedbackData<PSCustomObject>

.DESCRIPTION

Convert from JSON to FeedbackFeedbackData<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

FeedbackFeedbackData<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToFeedbackFeedbackData {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightFeedbackFeedbackData' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightFeedbackFeedbackData
        $AllProperties = ("ClassId", "ObjectType", "AccountName", "AlternativeFollowUpEmails", "Comment", "Email", "Evaluation", "FollowUp", "TraceIds", "Type")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        If ([string]::IsNullOrEmpty($Json) -or $Json -eq "{}") { # empty json
            throw "Error! Empty JSON cannot be serialized due to the required property 'ClassId' missing."
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ClassId"))) {
            throw "Error! JSON cannot be serialized due to the required property 'ClassId' missing."
        } else {
            $ClassId = $JsonParameters.PSobject.Properties["ClassId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectType"))) {
            throw "Error! JSON cannot be serialized due to the required property 'ObjectType' missing."
        } else {
            $ObjectType = $JsonParameters.PSobject.Properties["ObjectType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AccountName"))) { #optional property not found
            $AccountName = $null
        } else {
            $AccountName = $JsonParameters.PSobject.Properties["AccountName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AlternativeFollowUpEmails"))) { #optional property not found
            $AlternativeFollowUpEmails = $null
        } else {
            $AlternativeFollowUpEmails = $JsonParameters.PSobject.Properties["AlternativeFollowUpEmails"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Comment"))) { #optional property not found
            $Comment = $null
        } else {
            $Comment = $JsonParameters.PSobject.Properties["Comment"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Email"))) { #optional property not found
            $Email = $null
        } else {
            $Email = $JsonParameters.PSobject.Properties["Email"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Evaluation"))) { #optional property not found
            $Evaluation = $null
        } else {
            $Evaluation = $JsonParameters.PSobject.Properties["Evaluation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FollowUp"))) { #optional property not found
            $FollowUp = $null
        } else {
            $FollowUp = $JsonParameters.PSobject.Properties["FollowUp"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TraceIds"))) { #optional property not found
            $TraceIds = $null
        } else {
            $TraceIds = $JsonParameters.PSobject.Properties["TraceIds"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "AccountName" = ${AccountName}
            "AlternativeFollowUpEmails" = ${AlternativeFollowUpEmails}
            "Comment" = ${Comment}
            "Email" = ${Email}
            "Evaluation" = ${Evaluation}
            "FollowUp" = ${FollowUp}
            "TraceIds" = ${TraceIds}
            "Type" = ${Type}
        }

        return $PSO
    }

}

