---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightWorkloadWorkloadInstance

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightWorkloadWorkloadInstance [-Action< WorkloadWorkloadInstance.ActionEnum>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-DeploymentInput< WorkloadDeploymentInputRelationship>][-LastDeploymentInput< WorkloadDeploymentInputRelationship>][[-Moid]< string>][-Organization< OrganizationOrganizationRelationship>][-Tags< System.Collections.Generic.List`1[MoTag]>][-WorkloadDeployment< WorkloadWorkloadDeploymentRelationship>][-IfMatch< String>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;WorkloadWorkloadInstance&apos; resource.

## PARAMETERS

### -Action
The action to be performed on the workload instance.\n* `None` - Absence of any action on the workload instance.\n* `Suspend` - Pauses the execution of the workload instance, temporarily stopping its operations without permanently removing it.\n* `Resume` - Restarts a suspended workload instance, allowing it to continue operations from where it left off.\n* `Deploy` - Initiates the deployment of the workload instance, provisioning the necessary resources and starting its execution.\n* `Retry` - Attempts to re-deploy the workload instance, either due to a previous failure or to apply changes made to the instance.\n* `RetryAll` - Attempts to re-deploy all workload instances associated with the same deployment, either due to a previous failure or to apply changes made to the instances.\n* `Attach` - Associates the workload instance with its assigned resources, allowing it to utilize the resources for its operations.\n* `Detach` - Disassociates the workload instance from its assigned resources, preventing it from using the resources for its operations.\n* `UnAssign` - Detaches assigned resources from the workload instance while keeping the instance active.

```yaml
Type: WorkloadWorkloadInstance.ActionEnum
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

### -DeploymentInput
A reference to a workloadDeploymentInput resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: WorkloadDeploymentInputRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LastDeploymentInput
A reference to a workloadDeploymentInput resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: WorkloadDeploymentInputRelationship
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

### -WorkloadDeployment
A reference to a workloadWorkloadDeployment resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: WorkloadWorkloadDeploymentRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IfMatch
For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
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
PS C:\> Set-IntersightWorkloadWorkloadInstance
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightWorkloadWorkloadInstance](./Get-IntersightWorkloadWorkloadInstance.md)

[Initialize-IntersightCommGeoLocationDetails](./Initialize-IntersightCommGeoLocationDetails.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightWorkloadAssignedResource](./Initialize-IntersightWorkloadAssignedResource.md)

[Initialize-IntersightWorkloadWorkloadInstance.ChangeTypesEnum](./Initialize-IntersightWorkloadWorkloadInstance.ChangeTypesEnum.md)

[Remove-IntersightWorkloadWorkloadInstance](./Remove-IntersightWorkloadWorkloadInstance.md)
