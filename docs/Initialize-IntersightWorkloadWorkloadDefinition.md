---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightWorkloadWorkloadDefinition

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightWorkloadWorkloadDefinition [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Blueprints< System.Collections.Generic.List`1[Model.WorkloadBlueprintReference]>][-ClassId< WorkloadWorkloadDefinition.ClassIdEnum>][-Description< string>][-Moid< string>][-Name< string>][-ObjectType< WorkloadWorkloadDefinition.ObjectTypeEnum>][-Organization< Model.OrganizationOrganizationRelationship>][-PlatformType< System.Collections.Generic.List`1[WorkloadWorkloadDefinition.PlatformTypeEnum]>][-PreferredVersion< bool>][-PreferredVersionRolloutStrategy< Model.WorkloadRolloutStrategy>][-Status< WorkloadWorkloadDefinition.StatusEnum>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-Version< long>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

## PARAMETERS

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

### -Blueprints


Note :- Use Initialize-IntersightWorkloadBlueprintReference to create the object of complex type WorkloadBlueprintReference

```yaml
Type: System.Collections.Generic.List`1[Model.WorkloadBlueprintReference]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: WorkloadWorkloadDefinition.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
The description for this workload definition.

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

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
The name for this Workload. You can have multiple versions of the Workload with the same name. Name can only contain letters (a-z, A-Z), numbers (0-9), space, hyphen (-), or an underscore (_). A refName is generated from the given name, and that along with the version must be unique within an Organization.

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

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: WorkloadWorkloadDefinition.ObjectTypeEnum
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
Type: Model.OrganizationOrganizationRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PlatformType


```yaml
Type: System.Collections.Generic.List`1[WorkloadWorkloadDefinition.PlatformTypeEnum]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PreferredVersion
The flag to indicate that this is the preferred (default) version of the workload.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PreferredVersionRolloutStrategy
The strategy used for rolling out deployment changes when this workload version is marked as the preferred version.

Note :- Use Initialize-IntersightWorkloadRolloutStrategy to create the object of complex type WorkloadRolloutStrategy

```yaml
Type: Model.WorkloadRolloutStrategy
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Status
The status of the definition.\n* `Inactive` - The definition is in an inactive state and there are no workload instances associated with this workload. Changes to input parameters within the workload are allowed in this state.\n* `Active` - The definition is active and associated with one or more workload instances.

```yaml
Type: WorkloadWorkloadDefinition.StatusEnum
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
Type: System.Collections.Generic.List`1[Model.MoTag]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Version
The version of the workload to support multiple versions.

```yaml
Type: long
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
PS C:\> Initialize-IntersightWorkloadWorkloadDefinition
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)

[Initialize-IntersightWorkloadBlueprintReference](./Initialize-IntersightWorkloadBlueprintReference.md)

[Initialize-IntersightWorkloadRolloutStrategy](./Initialize-IntersightWorkloadRolloutStrategy.md)
