using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Должности",
                columns: table => new
                {
                    Код_должноти = table.Column<int>(type: "INT", nullable: false),
                    Наименование = table.Column<int>(type: "INT", nullable: false),
                    Оклад = table.Column<int>(type: "INT", nullable: false),
                    Обязанности = table.Column<int>(type: "INT", nullable: false),
                    Требования = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Должности", x => x.Код_должноти);
                });

            migrationBuilder.CreateTable(
                name: "Номера",
                columns: table => new
                {
                    Код_номера = table.Column<int>(type: "INT", nullable: false),
                    Наименование = table.Column<int>(type: "INT", nullable: false),
                    Вместимость_ = table.Column<int>(type: "INT", nullable: false),
                    Описание = table.Column<int>(type: "INT", nullable: false),
                    Стоимость = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Номера", x => x.Код_номера);
                });

            migrationBuilder.CreateTable(
                name: "Услуги",
                columns: table => new
                {
                    Код_услуги = table.Column<int>(type: "INT", nullable: false),
                    Наименование_ = table.Column<int>(type: "INT", nullable: false),
                    Описание = table.Column<int>(type: "INT", nullable: false),
                    Стоимость = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Услуги", x => x.Код_услуги);
                });

            migrationBuilder.CreateTable(
                name: "Сотрудники",
                columns: table => new
                {
                    Код_сотрудника = table.Column<int>(type: "INT", nullable: false),
                    ФИО = table.Column<int>(type: "INT", nullable: false),
                    Возраст = table.Column<int>(type: "INT", nullable: false),
                    Пол = table.Column<int>(type: "INT", nullable: false),
                    Адрес = table.Column<int>(type: "INT", nullable: false),
                    Паспортные_данные = table.Column<int>(type: "INT", nullable: false),
                    Код_должноти = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Сотрудники", x => x.Код_сотрудника);
                    table.ForeignKey(
                        name: "FK_Сотрудники_Должности_Код_должноти",
                        column: x => x.Код_должноти,
                        principalTable: "Должности",
                        principalColumn: "Код_должноти",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Клиенты",
                columns: table => new
                {
                    Паспортные_данные = table.Column<int>(type: "INT", nullable: false),
                    ФИО = table.Column<int>(type: "INT", nullable: false),
                    Дата_заселения_ = table.Column<int>(type: "INT", nullable: false),
                    Дата_выезда = table.Column<int>(type: "INT", nullable: false),
                    Код_номера = table.Column<int>(type: "INT", nullable: false),
                    Стоимость_ = table.Column<int>(type: "INT", nullable: false),
                    Код_сотрудника = table.Column<int>(type: "INT", nullable: false),
                    Код_услуги_1 = table.Column<int>(type: "INT", nullable: false),
                    Код_услуги_2 = table.Column<int>(type: "INT", nullable: false),
                    Код_услуги_3 = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Клиенты", x => x.Паспортные_данные);
                    table.ForeignKey(
                        name: "FK_Клиенты_Номера_Код_номера",
                        column: x => x.Код_номера,
                        principalTable: "Номера",
                        principalColumn: "Код_номера",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Клиенты_Сотрудники_Код_сотрудника",
                        column: x => x.Код_сотрудника,
                        principalTable: "Сотрудники",
                        principalColumn: "Код_сотрудника",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Клиенты_Услуги_Код_услуги_1",
                        column: x => x.Код_услуги_1,
                        principalTable: "Услуги",
                        principalColumn: "Код_услуги",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Клиенты_Услуги_Код_услуги_2",
                        column: x => x.Код_услуги_2,
                        principalTable: "Услуги",
                        principalColumn: "Код_услуги",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Клиенты_Услуги_Код_услуги_3",
                        column: x => x.Код_услуги_3,
                        principalTable: "Услуги",
                        principalColumn: "Код_услуги",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Клиенты_Код_номера",
                table: "Клиенты",
                column: "Код_номера",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Клиенты_Код_сотрудника",
                table: "Клиенты",
                column: "Код_сотрудника");

            migrationBuilder.CreateIndex(
                name: "IX_Клиенты_Код_услуги_1",
                table: "Клиенты",
                column: "Код_услуги_1");

            migrationBuilder.CreateIndex(
                name: "IX_Клиенты_Код_услуги_2",
                table: "Клиенты",
                column: "Код_услуги_2");

            migrationBuilder.CreateIndex(
                name: "IX_Клиенты_Код_услуги_3",
                table: "Клиенты",
                column: "Код_услуги_3");

            migrationBuilder.CreateIndex(
                name: "IX_Сотрудники_Код_должноти",
                table: "Сотрудники",
                column: "Код_должноти");

            migrationBuilder.CreateIndex(
                name: "IX_Сотрудники_Паспортные_данные",
                table: "Сотрудники",
                column: "Паспортные_данные",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Клиенты");

            migrationBuilder.DropTable(
                name: "Номера");

            migrationBuilder.DropTable(
                name: "Сотрудники");

            migrationBuilder.DropTable(
                name: "Услуги");

            migrationBuilder.DropTable(
                name: "Должности");
        }
    }
}
