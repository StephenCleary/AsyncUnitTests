$ErrorActionPreference = "Stop"

# Build VS2013 solution
Write-Output "Building VS2013 Solution..."
$project = Get-Project
$build = $project.DTE.Solution.SolutionBuild
$oldConfiguration = $build.ActiveConfiguration
$build.SolutionConfigurations.Item("Release").Activate()
$build.Build($true)
$oldConfiguration.Activate()
Write-Output "... done building VS2013 Solution."

nuget pack -Symbols "Nito.AsyncEx.UnitTests.MSFakes.nuspec"
