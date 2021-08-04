---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightTamAdvisoryDefinition

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightTamAdvisoryDefinition [-Actions< List<TamAction>>][-AdditionalProperties< Dictionary<string,object>>][-AdvisoryDetails< TamBaseAdvisoryDetails>][-AdvisoryId< string>][-ApiDataSources< List<TamApiDataSource>>][-DatePublished< DateTime>][-DateUpdated< DateTime>][-Description< string>][-ExternalUrl< string>][[-Moid]< string>][-Name< string>][-Organization< OrganizationOrganizationRelationship>][-Recommendation< string>][-S3DataSources< List<TamS3DataSource>>][-Severity< TamSeverity>][-State< TamAdvisoryDefinition.StateEnum>][-Tags< List<MoTag>>][-Type< TamAdvisoryDefinition.TypeEnum>][-Version< string>][-Workaround< string>]

```

## DESCRIPTION
Update a &apos;TamAdvisoryDefinition&apos; resource.

## PARAMETERS

### -Actions


Note :- Use Initialize-IntersightTamAction to create the object of complex type TamAction

```yaml
Type: System.Collections.Generic.List`1[TamAction]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AdditionalProperties


```yaml
Type: System.Collections.Generic.Dictionary`2[string,object]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AdvisoryDetails
Additional details for the advisory definition. For e.g. if the definition corresponds to a security advisory, the details\nregarding CVE ids and CVSS score would be available here.

Note :- Use Initialize-IntersightTamBaseAdvisoryDetails to create the object of complex type TamBaseAdvisoryDetails

```yaml
Type: TamBaseAdvisoryDetails
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AdvisoryId
Cisco generated identifier for the published security advisory.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ApiDataSources


Note :- Use Initialize-IntersightTamApiDataSource to create the object of complex type TamApiDataSource

```yaml
Type: System.Collections.Generic.List`1[TamApiDataSource]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DatePublished
Date when the security advisory was first published by Cisco.

```yaml
Type: DateTime
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DateUpdated
Date when the security advisory was last updated by Cisco.

```yaml
Type: DateTime
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
Brief description of the advisory details.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ExternalUrl
A link to an external URL describing security Advisory in more details.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Moid
The unique identifier of this Managed Object instance.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: true
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
A user defined name for the Intersight Advisory.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Organization
A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: OrganizationOrganizationRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Recommendation
Recommended action to resolve the security advisory.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -S3DataSources


Note :- Use Initialize-IntersightTamS3DataSource to create the object of complex type TamS3DataSource

```yaml
Type: System.Collections.Generic.List`1[TamS3DataSource]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Severity
Severity level of the Intersight Advisory.

Note :- Use Initialize-IntersightTamSeverity to create the object of complex type TamSeverity

```yaml
Type: TamSeverity
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -State
Current state of the advisory.\n* `ready` - Advisory has been evaluated. The affected devices would be analyzed and corresponding advisory instances would be created.\n* `evaluating` - Advisory is currently under evaluation. The affected devices would be analyzed but no advisory instances wouldbe created. The results of the analysis would be made available to Intersight engineering for evaluation and validation.

```yaml
Type: TamAdvisoryDefinition.StateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Tags


Note :- Use Initialize-IntersightMoTag to create the object of complex type MoTag

```yaml
Type: System.Collections.Generic.List`1[MoTag]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Type
The type (field notice, security advisory etc.) of Intersight advisory.\n* `securityAdvisory` - Respresents the psirt alert type (https://tools.cisco.com/security/center/publicationListing.x).\n* `fieldNotice` - Respresents the field notice alert type (https://www.cisco.com/c/en/us/support/web/tsd-products-field-notice-summary.html).

```yaml
Type: TamAdvisoryDefinition.TypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Version
Cisco assigned advisory version after latest revision.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Workaround
Workarounds available for the advisory.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> Set-IntersightTamAdvisoryDefinition
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightTamAdvisoryDefinition](./Get-IntersightTamAdvisoryDefinition.md)

[New-IntersightTamAdvisoryDefinition](./New-IntersightTamAdvisoryDefinition.md)

[Remove-IntersightTamAdvisoryDefinition](./Remove-IntersightTamAdvisoryDefinition.md)

[Initialize-IntersightTamAction](./Initialize-IntersightTamAction.md)

[Initialize-IntersightTamBaseAdvisoryDetails](./Initialize-IntersightTamBaseAdvisoryDetails.md)

[Initialize-IntersightTamApiDataSource](./Initialize-IntersightTamApiDataSource.md)

[Initialize-IntersightDateTime](./Initialize-IntersightDateTime.md)

[Initialize-IntersightTamS3DataSource](./Initialize-IntersightTamS3DataSource.md)

[Initialize-IntersightTamSeverity](./Initialize-IntersightTamSeverity.md)
