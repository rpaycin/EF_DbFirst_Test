// ****DB First ü  kullanmak için Microsoft.EntityFrameworkCore.SqlServer u yükle

//1. package managerda(PM) de db yi olduğu gibi context oluşturup almak istersen önce Microsoft.EntityFrameworkCore.Tools yükle. ardından PM aşağıdaki gibi komut olcak.
//=> Scaffold-DbContext 'ConnectionString' Microsoft.EntityFrameworkCore.[Provider] neyse
//Scaffold-DbContext 'Data Source=194.61.118.220; Initial Catalog= DISSELLING; Persist Security Info=True;User ID= disusr;Password=Dis%022;TrustServerCertificate=True' Microsoft.EntityFrameworkCore.SqlServer

// istenilen tabloları almak için -Tables Table1,Table2 vb
//Scaffold-DbContext 'Data Source=194.61.118.220; Initial Catalog= DISSELLING; Persist Security Info=True;User ID= disusr;Password=Dis%022;TrustServerCertificate=True' Microsoft.EntityFrameworkCore.SqlServer -Tables OfferModel

// Context adını değiştirmek istersen -Context ContextName
//Scaffold-DbContext 'Data Source=194.61.118.220; Initial Catalog= DISSELLING; Persist Security Info=True;User ID= disusr;Password=Dis%022;TrustServerCertificate=True' Microsoft.EntityFrameworkCore.SqlServer -Context AyazContext -Tables OfferModel

//belirli path te contex ve entity ler oluşmasını istiyorsan -ContextDir ve -OutputDir
//Scaffold-DbContext 'Data Source=194.61.118.220; Initial Catalog= DISSELLING; Persist Security Info=True;User ID= disusr;Password=Dis%022;TrustServerCertificate=True' Microsoft.EntityFrameworkCore.SqlServer -ContextDir Contexts -OutputDir Entities -Tables OfferModel

//2.dotnet CLI(CommandLine Interface) yani cmd den kullanabilmek için önce Microsoft.EntityFrameworkCore.Design aşağıdaki gibi komut yeterli => dotnet ef dbcontext scaffold 'ConnectionString' Microsoft.EntityFrameworkCore.[Provider] neyse
//dotnet ef dbcontext scaffold 'Data Source=194.61.118.220; Initial Catalog= DISSELLING; Persist Security Info=True;User ID= disusr;Password=Dis%022;TrustServerCertificate=True' Microsoft.EntityFrameworkCore.SqlServer
//dotnet ef komutu çalışmıyorsa global olarak cmd de kur => dotnet tool install --global dotnet-ef

Console.WriteLine("Hello, World!");
