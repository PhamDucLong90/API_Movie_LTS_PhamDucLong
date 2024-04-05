using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Project_XemPhim.DataContext;
using Project_XemPhim.Helper.HelperEmail;
using Project_XemPhim.Helper.Validation;
using Project_XemPhim.PayLoad.Converters;
using Project_XemPhim.PayLoad.DataResponse;
using Project_XemPhim.PayLoad.Responses;
using Project_XemPhim.Services.Implement;
using Project_XemPhim.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IEmailServices, EmailServices>();
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<UserConverters>();

builder.Services.AddScoped<ResponseObject<Response_Login>>();

builder.Services.AddScoped<ResponseObject<string>>();
builder.Services.AddScoped<EmailConfig>();

builder.Services.AddScoped<ValidateInput>();

builder.Services.AddScoped<ResponseObject<Response_UserInfomation>>();
builder.Services.AddScoped<AppDbContext>();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        ValidateAudience = false,
        ValidateIssuer = false,
        IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(builder.Configuration.GetSection("AppSettings:SecretKey").Value))


    };
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
