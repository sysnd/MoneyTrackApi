using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MoneyTrack.Data.Repositories;
using MoneyTrack.Data.Repositories.AlertsRepository;
using MoneyTrack.Data.Repositories.BaseRepository;
using MoneyTrack.Data.Repositories.BudgetRepository;
using MoneyTrack.Data.Repositories.CategoriesRepository;
using MoneyTrack.Data.Repositories.ExpensesRepository;
using MoneyTrack.Data.Repositories.IncomeRepository;
using MoneyTrack.Data.Repositories.TypesRepository;
using MoneyTrack.Data.Repositories.UsersRepository;
using MoneyTrack.Services.AlertsService;
using MoneyTrack.Services.BudgetService;
using MoneyTrack.Services.CategoryService;
using MoneyTrack.Services.ExpenseService;
using MoneyTrack.Services.IncomeService;
using MoneyTrack.Services.IncomeServices;
using MoneyTrack.Services.TypeService;
using MoneyTrack.Services.UserService;
using MoneyTrackShared.Configuration;

namespace MoneyTrackApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.Configure<MoneyTrackDbConfig>(Configuration.GetSection(nameof(MoneyTrackDbConfig)));

            services.AddSingleton<IMoneyTrackDbConfig>(sp =>
                sp.GetRequiredService<IOptions<MoneyTrackDbConfig>>().Value);

            services.AddSingleton(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddSingleton(typeof(IAlertRepository), typeof(AlertRepository));
            services.AddSingleton(typeof(IBudgetRepository), typeof(BudgetRepository));
            services.AddSingleton(typeof(ICategoryRepository), typeof(CategoryRepository));
            services.AddSingleton(typeof(IExpenseRepository), typeof(ExpenseRepository));
            services.AddSingleton(typeof(IIncomeRepository), typeof(IncomeRepository));
            services.AddSingleton(typeof(ITypeRepository), typeof(TypesRepository));
            services.AddSingleton(typeof(IUserRepository), typeof(UsersRepository));
            services.AddSingleton(typeof(IAlertService), typeof(AlertService));
            services.AddSingleton(typeof(IBudgetService), typeof(BudgetService));
            services.AddSingleton(typeof(ICategoryService), typeof(CategoryService));
            services.AddSingleton(typeof(IExpenseService), typeof(ExpenseService));
            services.AddSingleton(typeof(IIncomeService), typeof(IncomeService));
            services.AddSingleton(typeof(ITypeService), typeof(TypeService));
            services.AddSingleton(typeof(IUserService), typeof(UserService));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
