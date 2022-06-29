using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Coins> Coins { get; set; } = default!;

    public Contexto (DbContextOptions<Contexto> options): base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<Coins>().HasData(
            new Coins (){
                MonedaId = 1,
                Descripcion = "Bitcoin",
                Valor = 20282.10,
                ImageUrl = "https://cdn.icon-icons.com/icons2/674/PNG/512/bitcoin_icon-icons.com_60538.png"
            },

            new Coins (){
                MonedaId = 2,
                Descripcion = "Dogecoin",
                Valor = 0.069361,
                ImageUrl = "https://cdn.icon-icons.com/icons2/3376/PNG/512/dogecoin_currency_icon_211986.png"
            },

                new Coins (){
                MonedaId = 3,
                Descripcion = "BNB",
                Valor = 231.70,
                ImageUrl = "https://cdn.icon-icons.com/icons2/1386/PNG/512/bnb-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95846.png"
            },


            new Coins (){
                MonedaId = 4,
                Descripcion = "XRP",
                Valor = 0.34235,
                ImageUrl = "https://cdn.icon-icons.com/icons2/2130/PNG/512/xrp_cryptocurrency_logo_icon_131379.png"
            },


             new Coins (){
                MonedaId = 5,
                Descripcion = "Ethereum",
                Valor = 1.174,
                ImageUrl = "https://cdn.icon-icons.com/icons2/3369/PNG/512/ethereum_coin_money_cryptocurrency_icon_210995.png"
            }


        );
    }

}