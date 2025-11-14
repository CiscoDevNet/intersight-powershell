---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightKubernetesVirtualMachineNodeProfile

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightKubernetesVirtualMachineNodeProfile [-Action< string>][-ActionParams< System.Collections.Generic.List`1[PolicyActionParam]>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-CloudProvider< KubernetesVirtualMachineNodeProfile.CloudProviderEnum>][-ConfigContext< PolicyConfigContext>][-Description< string>][-Interfaces< System.Collections.Generic.List`1[KubernetesEthernet]>][-IpAddresses< System.Collections.Generic.List`1[IppoolIpLeaseRelationship]>][-Moid< string>][[-Name]< string>][-NodeGroup< KubernetesNodeGroupProfileRelationship>][-PolicyBucket< System.Collections.Generic.List`1[PolicyAbstractPolicyRelationship]>][-ScheduledActions< System.Collections.Generic.List`1[PolicyScheduledAction]>][-SrcTemplate< PolicyAbstractProfileRelationship>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Target< AssetDeviceRegistrationRelationship>][-Type< KubernetesVirtualMachineNodeProfile.TypeEnum>][-VirtualMachine< VirtualizationVirtualMachineRelationship>][-IfMatch< String>][-IfNoneMatch< String>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;KubernetesVirtualMachineNodeProfile&apos; resource.

## PARAMETERS

### -Action
User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign.

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

### -ActionParams


Note :- Use Initialize-IntersightPolicyActionParam to create the object of complex type PolicyActionParam

```yaml
Type: System.Collections.Generic.List`1[PolicyActionParam]
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

### -CloudProvider
Cloud provider for this node profile.\n* `noProvider` - Enables the use of no cloud provider.\n* `external` - Out of tree cloud provider, e.g. CPI for vsphere.

```yaml
Type: KubernetesVirtualMachineNodeProfile.CloudProviderEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ConfigContext
The configuration state and results of the last configuration operation.

Note :- Use Initialize-IntersightPolicyConfigContext to create the object of complex type PolicyConfigContext

```yaml
Type: PolicyConfigContext
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
Description of the profile.

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

### -Interfaces


Note :- Use Initialize-IntersightKubernetesEthernet to create the object of complex type KubernetesEthernet

```yaml
Type: System.Collections.Generic.List`1[KubernetesEthernet]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IpAddresses
An array of relationships to ippoolIpLease resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[IppoolIpLeaseRelationship]
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
Name of the profile instance or profile template.

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

### -NodeGroup
A reference to a kubernetesNodeGroupProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: KubernetesNodeGroupProfileRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PolicyBucket
An array of relationships to policyAbstractPolicy resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[PolicyAbstractPolicyRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ScheduledActions


Note :- Use Initialize-IntersightPolicyScheduledAction to create the object of complex type PolicyScheduledAction

```yaml
Type: System.Collections.Generic.List`1[PolicyScheduledAction]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SrcTemplate
A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: PolicyAbstractProfileRelationship
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

### -Target
A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: AssetDeviceRegistrationRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Type
Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target.

```yaml
Type: KubernetesVirtualMachineNodeProfile.TypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VirtualMachine
A reference to a virtualizationVirtualMachine resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: VirtualizationVirtualMachineRelationship
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

### -IfNoneMatch
For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn&apos;t happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource&apos;s ETag doesn&apos;t match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don&apos;t have to be identical byte for byte.

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
PS C:\> New-IntersightKubernetesVirtualMachineNodeProfile
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightKubernetesVirtualMachineNodeProfile](./Get-IntersightKubernetesVirtualMachineNodeProfile.md)

[Initialize-IntersightKubernetesEthernet](./Initialize-IntersightKubernetesEthernet.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightPolicyActionParam](./Initialize-IntersightPolicyActionParam.md)

[Initialize-IntersightPolicyConfigContext](./Initialize-IntersightPolicyConfigContext.md)

[Initialize-IntersightPolicyScheduledAction](./Initialize-IntersightPolicyScheduledAction.md)

[Remove-IntersightKubernetesVirtualMachineNodeProfile](./Remove-IntersightKubernetesVirtualMachineNodeProfile.md)

[Set-IntersightKubernetesVirtualMachineNodeProfile](./Set-IntersightKubernetesVirtualMachineNodeProfile.md)
