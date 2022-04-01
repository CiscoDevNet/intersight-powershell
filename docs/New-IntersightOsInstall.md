---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightOsInstall

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightOsInstall [-AdditionalParameters< System.Collections.Generic.List`1[OsPlaceHolder]>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Answers< OsAnswers>][-ConfigurationFile< OsConfigurationFileRelationship>][-Description< string>][-Image< SoftwarerepositoryOperatingSystemFileRelationship>][-InstallMethod< OsInstall.InstallMethodEnum>][-InstallTarget< OsInstallTarget>][-Moid< string>][[-Name]< string>][-OperatingSystemParameters< OsOperatingSystemParameters>][-Organization< OrganizationOrganizationRelationship>][-OsduImage< FirmwareServerConfigurationUtilityDistributableRelationship>][-Server< ComputePhysicalRelationship>][-Tags< System.Collections.Generic.List`1[MoTag]>][-WorkflowInfo< WorkflowWorkflowInfoRelationship>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;OsInstall&apos; resource.

## PARAMETERS

### -AdditionalParameters


Note :- Use Initialize-IntersightOsPlaceHolder to create the object of complex type OsPlaceHolder

```yaml
Type: System.Collections.Generic.List`1[OsPlaceHolder]
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

### -Answers
Answers provided by user for the unattended OS installation.

Note :- Use Initialize-IntersightOsAnswers to create the object of complex type OsAnswers

```yaml
Type: OsAnswers
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ConfigurationFile
A reference to a osConfigurationFile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: OsConfigurationFileRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
User provided description about the OS install configuration.

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

### -Image
A reference to a softwarerepositoryOperatingSystemFile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: SoftwarerepositoryOperatingSystemFileRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -InstallMethod
The install method to be used for OS installation - vMedia, iPXE. \nOnly vMedia is supported as of now.\n* `vMedia` - OS image is mounted as vMedia in target server for OS installation.

```yaml
Type: OsInstall.InstallMethodEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -InstallTarget
Install Target on which Operating system is installed.

Note :- Use Initialize-IntersightOsInstallTarget to create the object of complex type OsInstallTarget

```yaml
Type: OsInstallTarget
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

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
The name of the OS install configuration.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: true
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```

### -OperatingSystemParameters
Parameters specific to selected OS.

Note :- Use Initialize-IntersightOsOperatingSystemParameters to create the object of complex type OsOperatingSystemParameters

```yaml
Type: OsOperatingSystemParameters
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

### -OsduImage
A reference to a firmwareServerConfigurationUtilityDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: FirmwareServerConfigurationUtilityDistributableRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Server
A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: ComputePhysicalRelationship
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

### -WorkflowInfo
A reference to a workflowWorkflowInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: WorkflowWorkflowInfoRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Json
Returns the json payload received in response.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```

### -WithHttpInfo
Returns the HTTP response with headers and content.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> New-IntersightOsInstall
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightOsInstall](./Get-IntersightOsInstall.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightOsAnswers](./Initialize-IntersightOsAnswers.md)

[Initialize-IntersightOsInstallTarget](./Initialize-IntersightOsInstallTarget.md)

[Initialize-IntersightOsOperatingSystemParameters](./Initialize-IntersightOsOperatingSystemParameters.md)

[Initialize-IntersightOsPlaceHolder](./Initialize-IntersightOsPlaceHolder.md)
