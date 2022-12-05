using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using GiftDeliveryAPI.Models;
using System.Collections.Generic;

namespace GiftDeliveryAPI.Models
{
	public class GiftDeliveryDBContext : DbContext
	{
		protected readonly IConfiguration Configuration;

		public GiftDeliveryDBContext(DbContextOptions<GiftDeliveryDBContext> options,IConfiguration configuration)
			: base(options)
		{
			Configuration = configuration;
		}
		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			var connectionString = Configuration.GetConnectionString("GiftDeliveryService");
			options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
		}
		public DbSet<Gift> Gifts { get; set; } = null!;
        public DbSet<Sender> Senders { get; set; } = null!;

    }
}

