param(
[Parameter(Mandatory=$true)]
[string]$ResourceGroupName,
[string[]]$ResourceTypes =  @('Microsoft.Web/sites', 'Microsoft.Sql/servers')
) 
Connect-AzureRmAccount
Write-Host "List of resources to remove" -ForegroundColor red
$resources = Get-AzureRmResource | Where-Object { $_.ResourceGroupName -eq $ResourceGroupName } | Where-Object { $ResourceTypes.Contains($_.Type) };
$resources | % {$_.Name};

$confirmation = Read-Host -Prompt "Do you want to remove it? [y/n]" 
if ($confirmation -eq 'y')
{
  $resources | Remove-AzureRmResource -Force
}