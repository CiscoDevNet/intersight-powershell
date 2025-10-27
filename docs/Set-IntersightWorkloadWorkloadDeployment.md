---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightWorkloadWorkloadDeployment

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightWorkloadWorkloadDeployment [-Action< WorkloadWorkloadDeployment.ActionEnum>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Blueprints< System.Collections.Generic.List`1[WorkloadBlueprintInputReference]>][-Description< string>][-DigitCount< long>][[-Moid]< string>][-Name< string>][-Organization< OrganizationOrganizationRelationship>][-Qualifiers< System.Collections.Generic.List`1[ResourceResourceQualifier]>][-RolloutStrategy< WorkloadRolloutStrategy>][-SchedulePolicy< SchedulerSchedulePolicyRelationship>][-StartIndexForSuffix< long>][-Tags< System.Collections.Generic.List`1[MoTag]>][-WorkloadDefinitionReference< WorkloadDefinitionMapper>][-WorkloadInstancePrefix< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;WorkloadWorkloadDeployment&apos; resource.

## PARAMETERS

### -Action
The action is performed on the deployment.\n* `None` - No changes have been made.\n* `PrepareToDeploy` - Marks the deployment as ready once the user has completed all changes and the deployment is in a valid state. Once the deployment is marked as PrepareToDeploy, workload instances will be created, but the actual deployment will occur as part of the deploy action.\n* `Deploy` - Initiates the process of pushing workload configuration to the instances based on the configured schedule. Once deployed, the deployment cannot be reverted to draft status.\n* `Suspend` - Suspends the deployment, preventing any further actions until it is resumed. Making changes to deployment configuration will not be pushed out. The deployment will not take any changes from the attached Workload when it is suspended.\n* `Retry` - Retries the deployment for all instances that previously failed.\n* `Resume` - Resumes a suspended deployment. Any changes made to the deployment when it was suspended or any changes made to the attached Workload will now be pushed out based on configured schedules.

```yaml
Type: WorkloadWorkloadDeployment.ActionEnum
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

### -Blueprints


Note :- Use Initialize-IntersightWorkloadBlueprintInputReference to create the object of complex type WorkloadBlueprintInputReference

```yaml
Type: System.Collections.Generic.List`1[WorkloadBlueprintInputReference]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
A brief description of the deployment.

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

### -DigitCount
The minimum digit count to format the instance index with leading zeros,  for example if the digit count is 4 and the start index is 1, then the  first instance will have a suffix 0001. If the number of instances created for the deployment exceeds the 9999, then the suffix will become a 5 digit number.

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
The name for this Deployment. Name can only contain letters (a-z, A-Z), numbers (0-9), space, hyphen (-), or an underscore (_). The name must be unique within the organization.

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

### -Qualifiers


Note :- Use Initialize-IntersightResourceResourceQualifier to create the object of complex type ResourceResourceQualifier

```yaml
Type: System.Collections.Generic.List`1[ResourceResourceQualifier]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RolloutStrategy
The strategy used for rolling out deployment changes.

Note :- Use Initialize-IntersightWorkloadRolloutStrategy to create the object of complex type WorkloadRolloutStrategy

```yaml
Type: WorkloadRolloutStrategy
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SchedulePolicy
A reference to a schedulerSchedulePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: SchedulerSchedulePolicyRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -StartIndexForSuffix
The starting index used to generate the suffix for the workload instance name.

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

### -WorkloadDefinitionReference
The workload definition associated with this deployment.

Note :- Use Initialize-IntersightWorkloadDefinitionMapper to create the object of complex type WorkloadDefinitionMapper

```yaml
Type: WorkloadDefinitionMapper
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -WorkloadInstancePrefix
The prefix to be used for naming workload instances created by this deployment. Prefix can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), or an underscore (_). This prefix must be unique within the organization.

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
PS C:\> Set-IntersightWorkloadWorkloadDeployment
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightWorkloadWorkloadDeployment](./Get-IntersightWorkloadWorkloadDeployment.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightResourceResourceQualifier](./Initialize-IntersightResourceResourceQualifier.md)

[Initialize-IntersightWorkflowValidationInformation](./Initialize-IntersightWorkflowValidationInformation.md)

[Initialize-IntersightWorkloadBlueprintInputReference](./Initialize-IntersightWorkloadBlueprintInputReference.md)

[Initialize-IntersightWorkloadDefinitionMapper](./Initialize-IntersightWorkloadDefinitionMapper.md)

[Initialize-IntersightWorkloadDeploymentChangeDetail](./Initialize-IntersightWorkloadDeploymentChangeDetail.md)

[Initialize-IntersightWorkloadRolloutStrategy](./Initialize-IntersightWorkloadRolloutStrategy.md)

[Initialize-IntersightWorkloadStateAggregation](./Initialize-IntersightWorkloadStateAggregation.md)

[New-IntersightWorkloadWorkloadDeployment](./New-IntersightWorkloadWorkloadDeployment.md)

[Remove-IntersightWorkloadWorkloadDeployment](./Remove-IntersightWorkloadWorkloadDeployment.md)
