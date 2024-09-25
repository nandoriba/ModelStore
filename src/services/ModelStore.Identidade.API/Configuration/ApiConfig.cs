namespace ModelStore.Identidade.API.Configuration
{
    public static class ApiConfig
    {
        public static WebApplication UseApiConfiguration(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UserSwaggerConfiguration();
            }

            app.UseHttpsRedirection();
            app.UseIdentityConfiguration();
            app.UseRouting();
            app.MapControllers();

            return app;
        }
    }
}
