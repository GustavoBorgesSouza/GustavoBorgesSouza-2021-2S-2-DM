using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Filmes.webAPI",
                });
        });

            services
                //Define a forma de autenticação
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = "JwtBearer";
                    options.DefaultChallengeScheme = "JwtBearer";
                })

                //Define os parâmentros de validação do token
                .AddJwtBearer("JwtBearer", options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        //Será validado o emissor do token
                        ValidateIssuer = true,
                        //Será validado o destinatário do token
                        ValidateAudience = true,
                        //Será validado o tempo de vida do token
                        ValidateLifetime = true,

                        //Define a chave de segurança
                        IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("Autenticacao_ChaveFilmes")),

                        //Tempo de expiração do token
                        ClockSkew = TimeSpan.FromMinutes(30),

                        //Nome do Issuer, ou seja, quem deveria gerar o token
                        ValidIssuer = "Filmes.webAPI",

                        //Nome do audience, paa quem se destina a validação do token
                        ValidAudience = "Filmes.webAPI"
                    };
                });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Filmes.webAPI");
                c.RoutePrefix = string.Empty;
            });



            //primeiro faz autenticação e dps autorização

            //Habilita a autenticação
            app.UseAuthentication();    //401

            //Habilita a autorização
            app.UseAuthorization();     //403

            app.UseEndpoints(endpoints =>
            {
                //Define o mapeamento dos controllers
                endpoints.MapControllers();
            });
        }
    }
}
