# Resolución parcial Solicitud Adopción
# Repaso semana 9
## Guardar en memoria 


En el terminal

1:   dotnet add package Microsoft.EntityFrameworkCore

dotnet add package Microsoft.EntityFrameworkCore.Design

2:  dotnet add package microsoft.entityframeworkcore.inmemory

dotnet add package Pomelo.EntityFrameworkCore.MySql 

## PARA MIGRACIONES
1: Verificar que esté instalador esto
dotnet tool install --global dotnet-ef


2: Genera una migración
dotnet ef migrations add nombreDeLaMigración

3: Actualizar la bd con la ultima migración 
dotnet ef database update