using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportClub.Migrations
{
    /// <inheritdoc />
    public partial class name1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "SeasonTicket",
                table: "Users",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Registration",
                table: "Users",
                newName: "RegistrationTime");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "SeasonTicketID",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TicketStatus",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    HallID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HallNumber = table.Column<int>(type: "int", nullable: false),
                    Equipment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Avalaibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.HallID);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_Payments_Users_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeasonTickets",
                columns: table => new
                {
                    SeasonTicketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DurationD = table.Column<int>(type: "int", nullable: false),
                    Services = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeasonTickets", x => x.SeasonTicketID);
                });

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    TrainerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.TrainerID);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    TrainingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    TrainerID = table.Column<int>(type: "int", nullable: false),
                    HallID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    Participants = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.TrainingID);
                    table.ForeignKey(
                        name: "FK_Trainings_Halls_HallID",
                        column: x => x.HallID,
                        principalTable: "Halls",
                        principalColumn: "HallID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trainings_Trainers_TrainerID",
                        column: x => x.TrainerID,
                        principalTable: "Trainers",
                        principalColumn: "TrainerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    RegistrationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    TrainingID = table.Column<int>(type: "int", nullable: false),
                    RegistrationStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.RegistrationID);
                    table.ForeignKey(
                        name: "FK_Registrations_Trainings_TrainingID",
                        column: x => x.TrainingID,
                        principalTable: "Trainings",
                        principalColumn: "TrainingID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registrations_Users_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ScheduleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false),
                    TrainingID = table.Column<int>(type: "int", nullable: false),
                    TrainerID = table.Column<int>(type: "int", nullable: false),
                    HallID = table.Column<int>(type: "int", nullable: false),
                    AvailableSpots = table.Column<int>(type: "int", nullable: false),
                    TrainerID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ScheduleID);
                    table.ForeignKey(
                        name: "FK_Schedules_Halls_HallID",
                        column: x => x.HallID,
                        principalTable: "Halls",
                        principalColumn: "HallID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedules_Trainers_TrainerID",
                        column: x => x.TrainerID,
                        principalTable: "Trainers",
                        principalColumn: "TrainerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedules_Trainers_TrainerID1",
                        column: x => x.TrainerID1,
                        principalTable: "Trainers",
                        principalColumn: "TrainerID");
                    table.ForeignKey(
                        name: "FK_Schedules_Trainings_TrainingID",
                        column: x => x.TrainingID,
                        principalTable: "Trainings",
                        principalColumn: "TrainingID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_SeasonTicketID",
                table: "Users",
                column: "SeasonTicketID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ClientID",
                table: "Payments",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_ClientID",
                table: "Registrations",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_TrainingID",
                table: "Registrations",
                column: "TrainingID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_HallID",
                table: "Schedules",
                column: "HallID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_TrainerID",
                table: "Schedules",
                column: "TrainerID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_TrainerID1",
                table: "Schedules",
                column: "TrainerID1",
                unique: true,
                filter: "[TrainerID1] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_TrainingID",
                table: "Schedules",
                column: "TrainingID");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_HallID",
                table: "Trainings",
                column: "HallID");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_TrainerID",
                table: "Trainings",
                column: "TrainerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_SeasonTickets_SeasonTicketID",
                table: "Users",
                column: "SeasonTicketID",
                principalTable: "SeasonTickets",
                principalColumn: "SeasonTicketID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_SeasonTickets_SeasonTicketID",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "SeasonTickets");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.DropIndex(
                name: "IX_Users_SeasonTicketID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SeasonTicketID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TicketStatus",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "RegistrationTime",
                table: "Users",
                newName: "Registration");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Users",
                newName: "SeasonTicket");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<long>(
                name: "Number",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
