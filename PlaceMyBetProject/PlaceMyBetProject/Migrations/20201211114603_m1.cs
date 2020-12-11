﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlaceMyBetProject.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuenta",
                columns: table => new
                {
                    cuentaId = table.Column<string>(nullable: false),
                    nombreBanco = table.Column<string>(nullable: true),
                    saldo = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuenta", x => x.cuentaId);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    eventoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    local = table.Column<string>(nullable: true),
                    visitante = table.Column<string>(nullable: true),
                    fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.eventoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    usuarioId = table.Column<string>(nullable: false),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    edad = table.Column<int>(nullable: false),
                    cuentaId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.usuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_Cuenta_cuentaId",
                        column: x => x.cuentaId,
                        principalTable: "Cuenta",
                        principalColumn: "cuentaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mercado",
                columns: table => new
                {
                    mercadoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    overUnder = table.Column<double>(nullable: false),
                    dineroOver = table.Column<double>(nullable: false),
                    dineroUnder = table.Column<double>(nullable: false),
                    cuotaOver = table.Column<double>(nullable: false),
                    cuotaUnder = table.Column<double>(nullable: false),
                    eventoId = table.Column<int>(nullable: false),
                    apuestaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mercado", x => x.mercadoId);
                    table.ForeignKey(
                        name: "FK_Mercado_Evento_eventoId",
                        column: x => x.eventoId,
                        principalTable: "Evento",
                        principalColumn: "eventoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Apuesta",
                columns: table => new
                {
                    apuestaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipoMercado = table.Column<double>(nullable: false),
                    tipoApuesta = table.Column<double>(nullable: false),
                    cuota = table.Column<double>(nullable: false),
                    dineroApuesta = table.Column<double>(nullable: false),
                    fecha = table.Column<DateTime>(nullable: false),
                    eventoId = table.Column<int>(nullable: false),
                    mercadoId = table.Column<int>(nullable: false),
                    usuarioId = table.Column<int>(nullable: false),
                    usuarioId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apuesta", x => x.apuestaId);
                    table.ForeignKey(
                        name: "FK_Apuesta_Evento_eventoId",
                        column: x => x.eventoId,
                        principalTable: "Evento",
                        principalColumn: "eventoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Apuesta_Mercado_mercadoId",
                        column: x => x.mercadoId,
                        principalTable: "Mercado",
                        principalColumn: "mercadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Apuesta_Usuario_usuarioId1",
                        column: x => x.usuarioId1,
                        principalTable: "Usuario",
                        principalColumn: "usuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apuesta_eventoId",
                table: "Apuesta",
                column: "eventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Apuesta_mercadoId",
                table: "Apuesta",
                column: "mercadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Apuesta_usuarioId1",
                table: "Apuesta",
                column: "usuarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_Mercado_eventoId",
                table: "Mercado",
                column: "eventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_cuentaId",
                table: "Usuario",
                column: "cuentaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apuesta");

            migrationBuilder.DropTable(
                name: "Mercado");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "Cuenta");
        }
    }
}
