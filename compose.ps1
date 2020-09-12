param (
    [switch]$prod = $false
)

if ($prod) {
    Write-Host "Compose for production is not yet configured... sorry"
} else {
    Write-Host "Composing for Development"
    docker-compose build --parallel
    docker-compose up --remove-orphans
}