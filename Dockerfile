FROM mcr.microsoft.com/dotnet/sdk:6.0 

EXPOSE 80
EXPOSE 443

#WORKDIR /home/runner/work/DemoGithubAction/DemoGithubAction/
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "DemoGighubAction.WebApi.dll"]