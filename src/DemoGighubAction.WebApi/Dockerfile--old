#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DemoGighubAction.WebApi/DemoGighubAction.WebApi.csproj", "DemoGighubAction.WebApi/"]
RUN dotnet restore "DemoGighubAction.WebApi/DemoGighubAction.WebApi.csproj"
COPY . .
WORKDIR "/src/DemoGighubAction.WebApi"
RUN dotnet build "DemoGighubAction.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DemoGighubAction.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DemoGighubAction.WebApi.dll"]