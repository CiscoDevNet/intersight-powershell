$docker_http_proxy1 = Initialize-IntersightKubernetesProxyconfig -Hostname '10.1.1.10' -Password 'ChangeMe' -Port 3001 -Protocol 'http' -Username 'admin1'

$docker_https_proxy1 = Initialize-IntersightKubernetesProxyconfig -Hostname '10.1.1.10' -Password 'ChangeMe' -Port 3001 -Protocol 'https' -Username 'admin1'

$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$kubernetes_container_runtime_policy1 = New-IntersightKubernetesContainerRuntimePolicy -DockerHttpProxy $docker_http_proxy1 -DockerHttpsProxy $docker_https_proxy1 -Organization $organization1 -Description 'kubernetes container runtime policy' -Name 'kubernetes_container_runtime_policy1' -DockerNoProxy @('test.example.com', '.example2.com', '127.0.0.0/8')