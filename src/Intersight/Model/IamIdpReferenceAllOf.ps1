#
# Cisco Intersight
# Cisco Intersight is a management platform delivered as a service with embedded analytics for your Cisco and 3rd party IT infrastructure. This platform offers an intelligent level of management that enables IT organizations to analyze, simplify, and automate their environments in more advanced ways than the prior generations of tools. Cisco Intersight provides an integrated and intuitive management experience for resources in the traditional data center as well as at the edge. With flexible deployment options to address complex security needs, getting started with Intersight is quick and easy. Cisco Intersight has deep integration with Cisco UCS and HyperFlex systems allowing for remote deployment, configuration, and ongoing maintenance. The model-based deployment works for a single system in a remote location or hundreds of systems in a data center and enables rapid, standardized configuration and deployment. It also streamlines maintaining those systems whether you are working with small or very large configurations. The Intersight OpenAPI document defines the complete set of properties that are returned in the HTTP response. From that perspective, a client can expect that no additional properties are returned, unless these properties are explicitly defined in the OpenAPI document. However, when a client uses an older version of the Intersight OpenAPI document, the server may send additional properties because the software is more recent than the client. In that case, the client may receive properties that it does not know about. Some generated SDKs perform a strict validation of the HTTP response body against the OpenAPI document. This document was created on 2020-07-16T08:45:19Z.
# Version: 1.0.9-2020
# Contact: intersight@cisco.com
# Generated by OpenAPI Generator: https://openapi-generator.tech
#

<#
.SYNOPSIS

No summary available.

.DESCRIPTION

Definition of the list of properties defined in 'iam.IdpReference', excluding properties defined in parent classes.

.PARAMETER MultiFactorAuthentication
The flag represents if the second factor of authentication is required for Cisco IdP users.
.PARAMETER Account
No description available.
.PARAMETER Idp
No description available.
.PARAMETER Usergroups
An array of relationships to iamUserGroup resources.
.PARAMETER Users
An array of relationships to iamUser resources.
.OUTPUTS

IamIdpReferenceAllOf<PSCustomObject>
#>

function Initialize-IntersightIamIdpReferenceAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${MultiFactorAuthentication},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Account},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Idp},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Usergroups},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Users}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightIamIdpReferenceAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "MultiFactorAuthentication" = ${MultiFactorAuthentication}
            "Account" = ${Account}
            "Idp" = ${Idp}
            "Usergroups" = ${Usergroups}
            "Users" = ${Users}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to IamIdpReferenceAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to IamIdpReferenceAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

IamIdpReferenceAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToIamIdpReferenceAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightIamIdpReferenceAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightIamIdpReferenceAllOf
        $AllProperties = ("DomainName", "IdpEntityId", "MultiFactorAuthentication", "Name", "Account", "Idp", "UserPreferences", "Usergroups", "Users")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DomainName"))) { #optional property not found
            $DomainName = $null
        } else {
            $DomainName = $JsonParameters.PSobject.Properties["DomainName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IdpEntityId"))) { #optional property not found
            $IdpEntityId = $null
        } else {
            $IdpEntityId = $JsonParameters.PSobject.Properties["IdpEntityId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MultiFactorAuthentication"))) { #optional property not found
            $MultiFactorAuthentication = $null
        } else {
            $MultiFactorAuthentication = $JsonParameters.PSobject.Properties["MultiFactorAuthentication"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Account"))) { #optional property not found
            $Account = $null
        } else {
            $Account = $JsonParameters.PSobject.Properties["Account"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Idp"))) { #optional property not found
            $Idp = $null
        } else {
            $Idp = $JsonParameters.PSobject.Properties["Idp"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserPreferences"))) { #optional property not found
            $UserPreferences = $null
        } else {
            $UserPreferences = $JsonParameters.PSobject.Properties["UserPreferences"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Usergroups"))) { #optional property not found
            $Usergroups = $null
        } else {
            $Usergroups = $JsonParameters.PSobject.Properties["Usergroups"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Users"))) { #optional property not found
            $Users = $null
        } else {
            $Users = $JsonParameters.PSobject.Properties["Users"].value
        }

        $PSO = [PSCustomObject]@{
            "DomainName" = ${DomainName}
            "IdpEntityId" = ${IdpEntityId}
            "MultiFactorAuthentication" = ${MultiFactorAuthentication}
            "Name" = ${Name}
            "Account" = ${Account}
            "Idp" = ${Idp}
            "UserPreferences" = ${UserPreferences}
            "Usergroups" = ${Usergroups}
            "Users" = ${Users}
        }

        return $PSO
    }

}
