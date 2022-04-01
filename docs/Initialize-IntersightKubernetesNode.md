---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightKubernetesNode

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightKubernetesNode [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Annotations< object>][-ClassId< KubernetesNode.ClassIdEnum>][-Labels< object>][-Metadata< Model.KubernetesObjectMeta>][-Moid< string>][-Name< string>][-NodeAddresses< System.Collections.Generic.List`1[Model.KubernetesNodeAddress]>][-NodeInfo< Model.KubernetesNodeInfo>][-NodeSpec< Model.KubernetesNodeSpec>][-NodeStatuses< System.Collections.Generic.List`1[Model.KubernetesNodeStatus]>][-ObjectType< KubernetesNode.ObjectTypeEnum>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-Taints< System.Collections.Generic.List`1[Model.KubernetesTaint]>][-Uuid< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -Annotations
Kubernetes metadata annotations for a Node.

Note :- Use Initialize-Intersightobject to create the object of complex type object

```yaml
Type: object
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
Type: KubernetesNode.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Labels
Kubernetes metadata labels for a Node.

Note :- Use Initialize-Intersightobject to create the object of complex type object

```yaml
Type: object
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Metadata
Meta data of the kubernetes resource.

Note :- Use Initialize-IntersightKubernetesObjectMeta to create the object of complex type KubernetesObjectMeta

```yaml
Type: Model.KubernetesObjectMeta
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
Name of the referenced kubernetes resource.

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

### -NodeAddresses


Note :- Use Initialize-IntersightKubernetesNodeAddress to create the object of complex type KubernetesNodeAddress

```yaml
Type: System.Collections.Generic.List`1[Model.KubernetesNodeAddress]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NodeInfo
Describes general information about the node, such as kernel version, Kubernetes version (kubelet and kube-proxy version), Docker version (if used), and OS name.

Note :- Use Initialize-IntersightKubernetesNodeInfo to create the object of complex type KubernetesNodeInfo

```yaml
Type: Model.KubernetesNodeInfo
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NodeSpec
Represent the specification of a Kubernetes node.

Note :- Use Initialize-IntersightKubernetesNodeSpec to create the object of complex type KubernetesNodeSpec

```yaml
Type: Model.KubernetesNodeSpec
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NodeStatuses


Note :- Use Initialize-IntersightKubernetesNodeStatus to create the object of complex type KubernetesNodeStatus

```yaml
Type: System.Collections.Generic.List`1[Model.KubernetesNodeStatus]
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
Type: KubernetesNode.ObjectTypeEnum
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

### -Taints


Note :- Use Initialize-IntersightKubernetesTaint to create the object of complex type KubernetesTaint

```yaml
Type: System.Collections.Generic.List`1[Model.KubernetesTaint]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Uuid
UUID of the referenced kubernetes resource. It is generated by the kubernetes cluster itself.

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
PS C:\> Initialize-IntersightKubernetesNode
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightKubernetesNodeAddress](./Initialize-IntersightKubernetesNodeAddress.md)

[Initialize-IntersightKubernetesNodeInfo](./Initialize-IntersightKubernetesNodeInfo.md)

[Initialize-IntersightKubernetesNodeSpec](./Initialize-IntersightKubernetesNodeSpec.md)

[Initialize-IntersightKubernetesNodeStatus](./Initialize-IntersightKubernetesNodeStatus.md)

[Initialize-IntersightKubernetesObjectMeta](./Initialize-IntersightKubernetesObjectMeta.md)

[Initialize-IntersightKubernetesTaint](./Initialize-IntersightKubernetesTaint.md)

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)

[Initialize-Intersightobject](./Initialize-Intersightobject.md)
