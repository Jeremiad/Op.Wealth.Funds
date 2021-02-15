FROM mcr.microsoft.com/dotnet/runtime:5.0-alpine AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS build
WORKDIR /src
COPY ["src/Op.Wealth.Funds/Op.Wealth.Funds.csproj", "Op.Wealth.Funds/"]
RUN dotnet restore "Op.Wealth.Funds/Op.Wealth.Funds.csproj"
COPY . .
WORKDIR "/src/Op.Wealth.Funds"
RUN dotnet build "Op.Wealth.Funds.csproj" -c Release -o /app/build