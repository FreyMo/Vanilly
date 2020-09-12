FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS dev
WORKDIR /src

COPY "Vanilly.Server.csproj" .

RUN dotnet restore

COPY . .

RUN dotnet build

CMD dotnet watch run

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Vanilly.Server.dll"]
