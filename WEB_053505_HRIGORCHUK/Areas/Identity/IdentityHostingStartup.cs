using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WEB_053505_HRIGORCHUK.Data;
using WEB_053505_HRIGORCHUK.Entities;

[assembly: HostingStartup(typeof(WEB_053505_HRIGORCHUK.Areas.Identity.IdentityHostingStartup))]
namespace WEB_053505_HRIGORCHUK.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}