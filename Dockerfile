FROM mcr.microsoft.com/dotnet/sdk:6.0 

EXPOSE 80
EXPOSE 443

WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DemoGighubAction.WebApi.dll"]