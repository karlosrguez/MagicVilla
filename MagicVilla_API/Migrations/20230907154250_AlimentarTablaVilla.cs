using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "detalle", "tarifa" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 9, 7, 9, 42, 50, 9, DateTimeKind.Local).AddTicks(4292), new DateTime(2023, 9, 7, 9, 42, 50, 9, DateTimeKind.Local).AddTicks(4279), "", 50, "Villa Real", 5, "Detalle de la Villa", 200.0 },
                    { 2, "", new DateTime(2023, 9, 7, 9, 42, 50, 9, DateTimeKind.Local).AddTicks(4295), new DateTime(2023, 9, 7, 9, 42, 50, 9, DateTimeKind.Local).AddTicks(4295), "", 40, "Premium Vista a la piscina", 4, "Detalle de la Villa", 150.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
