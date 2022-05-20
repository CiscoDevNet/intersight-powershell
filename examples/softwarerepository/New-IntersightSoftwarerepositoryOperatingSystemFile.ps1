$source1 = Initialize-IntersightSoftwarerepositoryCifsserver -FileLocation '10.10.10.1/Public/iso/esx67u2.iso' -MountOption 'sec=ntlm' -Password 'ChangeMe' -Username 'user'

$catalog1 = Get-IntersightSoftwarerepositoryCatalog -Moid '<Replace with Moid>'

$osf11 = New-IntersightSoftwarerepositoryOperatingSystemFile -Source $source1 -Catalog $catalog1 -Version 'ESXi 6.7 U2' -Description 'ESXi6.7U2 without answers' -Name 'ESXi6.7 w/o cifs 21' -Vendor 'VMware'