namespace Leashar.WebApi.Extensions
{
    public static class PipelineConfiguration
    {
        public static WebApplication ConfigurePipelines(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseRouting()
            .UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            return app;
        }
    }
}
