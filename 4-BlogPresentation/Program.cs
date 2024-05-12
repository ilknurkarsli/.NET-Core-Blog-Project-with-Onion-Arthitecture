using _1_BlogCore.DomainModels.Models;
using _2_BlogApplication.IRepositories;
using _2_BlogApplication.Mappers;
using _2_BlogApplication.Utilities.ILoggings;
using _2_BlogApplication.Utilities.IUnitOfWorks;
using _3_BlogInfrasracture.Contexts;
using _3_BlogInfrasracture.Repositories;
using _3_BlogInfrasracture.Utilities.Loggings;
using _3_BlogInfrasracture.Utilities.UnitOfWorks;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();


//Mapper ı ayaga kaldırma
builder.Services.AddAutoMapper(typeof(Mapping));
//Contexti ayaga kaldırma
builder.Services.AddDbContext<AppDbContext>();
//İdentity ı ayaga kaldırma 
builder.Services.AddIdentity<AppUser, IdentityRole>(
    options=>
    {
        options.Password.RequiredLength = 3;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireDigit = false;

        options.User.RequireUniqueEmail = true;
    }
).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
//Logger ı ayaga kaldırma
builder.Services.AddScoped<ILogging, Logging>();
//Unit of work ayaga kaldırma (unitofwork un içinde nesneleri tek tek ayaga kaldırmasaydık bu yontemi kullancaktık. orada bu işlemi yaptıgımız için burada tekrar ayaga kaldırmamaıza gerek kalmadı)

// builder.Services.AddScoped<IAppUserRepo, AppUserRepo>();
// builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
// builder.Services.AddScoped<ICommentRepo, CommentRepo>();
// builder.Services.AddScoped<IArticleRepo, ArticleRepo>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IUnitOfWorkService, UnitOfWorkService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
//app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
