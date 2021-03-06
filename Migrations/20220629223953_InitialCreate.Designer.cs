// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CryptoApi.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220629223953_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Coins", b =>
                {
                    b.Property<int>("MonedaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("MonedaId");

                    b.ToTable("Coins");

                    b.HasData(
                        new
                        {
                            MonedaId = 1,
                            Descripcion = "Bitcoin",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/674/PNG/512/bitcoin_icon-icons.com_60538.png",
                            Valor = 20282.099999999999
                        },
                        new
                        {
                            MonedaId = 2,
                            Descripcion = "Dogecoin",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/3376/PNG/512/dogecoin_currency_icon_211986.png",
                            Valor = 0.069361000000000006
                        },
                        new
                        {
                            MonedaId = 3,
                            Descripcion = "BNB",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/1386/PNG/512/bnb-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95846.png",
                            Valor = 231.69999999999999
                        },
                        new
                        {
                            MonedaId = 4,
                            Descripcion = "XRP",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/2130/PNG/512/xrp_cryptocurrency_logo_icon_131379.png",
                            Valor = 0.34234999999999999
                        },
                        new
                        {
                            MonedaId = 5,
                            Descripcion = "Ethereum",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/3369/PNG/512/ethereum_coin_money_cryptocurrency_icon_210995.png",
                            Valor = 1.1739999999999999
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
