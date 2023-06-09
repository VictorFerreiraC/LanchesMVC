﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lanchesMVC.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(IdCategoria, DescricaoCurta, DescricaoDetalhada, EmEstoque,ImagemThumbnailUrl, ImagemUrl, LanchePrerido, Nome, Preco) VALUES(1,'Pão, hambúrger, ovo, presunto, queijo e batata palha','Delicioso pão de hambúrger com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha',1, 'cheesesalada1.jpg','cheesesalada1.jpg', 0, 'Cheese Salada', 12.50);");
            migrationBuilder.Sql("INSERT INTO Lanches(IdCategoria, DescricaoCurta, DescricaoDetalhada, EmEstoque,ImagemThumbnailUrl, ImagemUrl, LanchePrerido, Nome, Preco) VALUES(1,'Pão, hambúrger, ovo, presunto, queijo e batata palha','Delicioso pão de hambúrger com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha',1, 'cheesesalada1.jpg','cheesesalada1.jpg', 0, 'Cheese Salada', 12.50);");
            migrationBuilder.Sql("INSERT INTO Lanches(IdCategoria, DescricaoCurta, DescricaoDetalhada, EmEstoque,ImagemThumbnailUrl, ImagemUrl, LanchePrerido, Nome, Preco) VALUES(1,'Pão, hambúrger, ovo, presunto, queijo e batata palha','Delicioso pão de hambúrger com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha',1, 'cheesesalada1.jpg','cheesesalada1.jpg', 0, 'Cheese Salada', 12.50);");
            migrationBuilder.Sql("INSERT INTO Lanches(IdCategoria, DescricaoCurta, DescricaoDetalhada, EmEstoque,ImagemThumbnailUrl, ImagemUrl, LanchePrerido, Nome, Preco) VALUES(1,'Pão, hambúrger, ovo, presunto, queijo e batata palha','Delicioso pão de hambúrger com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha',1, 'cheesesalada1.jpg','cheesesalada1.jpg', 0, 'Cheese Salada', 12.50);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches;");
        }
    }
}
