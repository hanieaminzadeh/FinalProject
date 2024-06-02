using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeService.Infrastructure.DataBase.Sql.Ef.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAccept = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ProfileImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    ApplicationUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true),
                    CreatAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    BirthDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    CreatAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Experts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BirthDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    ShebaNumber = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    ApplicationUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Experts_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    DateOfRegisteration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfImplemention = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ServiceId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Requests_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ExpertId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExpertService",
                columns: table => new
                {
                    ExpertsId = table.Column<int>(type: "int", nullable: false),
                    ServicesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertService", x => new { x.ExpertsId, x.ServicesId });
                    table.ForeignKey(
                        name: "FK_ExpertService_Experts_ExpertsId",
                        column: x => x.ExpertsId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpertService_Services_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bids",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestId = table.Column<int>(type: "int", nullable: true),
                    ExpertId = table.Column<int>(type: "int", nullable: true),
                    DateOfRegisteration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfWork = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProposedPrice = table.Column<int>(type: "int", nullable: true),
                    IsWinner = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bids", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bids_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bids_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Admin", "ADMIN" },
                    { 2, null, "Expert", "EXPERT" },
                    { 3, null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsAccept", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "5981c0be-7e96-42a3-ad5f-ff3ddf4f013f", "Admin@gmail.com", false, null, false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEJ/fttCKvi2Ah8kRK+KtLXuG2vPxlrOo0Sv5rRv14TVieYgwZceUe3TEO3eVA3Mkmg==", "09377507920", false, "0cec284c-7e20-4974-bc96-81b049469aa9", false, "Admin@gmail.com" },
                    { 2, 0, "f10d9a9a-4e17-4248-ac95-13be685f8a8c", "Ali@gmail.com", false, null, false, false, null, "ALI@GMAIL.COM", "ALI@GMAIL.COM", "AQAAAAIAAYagAAAAEOcTq3Tsg3Z/bko6Ra+wLLZyXmwQ7Ho+LyXk0ggd0OfGVhYlvuDrtMywMzvDSCIbZA==", "09377507920", false, "7fae6e6a-e2ab-46bc-95d1-48baf09b7736", false, "Ali@gmail.com" },
                    { 3, 0, "a0d1d0b9-1384-4712-80d6-cd465171b69a", "Sahar@gmail.com", false, null, false, false, null, "SAHAR@GMAIL.COM", "SAHAR@GMAIL.COM", "AQAAAAIAAYagAAAAEC5ei+rjy3xCZzHTQLeXy6KhjLXq6cgXMgEz01bfj8yihKrnBce54PBfeOqP0leQCw==", "09377507920", false, "32f97933-00db-4ef7-b1b7-fa84e61cb2a0", false, "Sahar@gmail.com" },
                    { 4, 0, "66896fc7-7a2d-4b37-973c-e3ddefbab8c0", "Maryam@gmail.com", false, null, false, false, null, "MARYAM@GMAIL.COM", "MARYAM@GMAIL.COM", "AQAAAAIAAYagAAAAEACvzSUZKikySslZeg+4mpn0k9NAohbqv5xCFtCzTfzptFUpyfJXkZ/jN4JLjxYVXA==", "09377507920", false, "de6ba509-8e8c-40dc-904f-faaac4d31d47", false, "Maryam@gmail.com" },
                    { 5, 0, "7e57095a-08df-42d4-a356-07a61f8b4d5e", "Sara@gmail.com", false, null, false, false, null, "SARA@GMAIL.COM", "SARA@GMAIL.COM", "AQAAAAIAAYagAAAAEJLS9zCAHR6vhBtbKutfH4mCCj6jfy/n1r91MFGXeGCiYSfUqBhBzht5Peslah8sbw==", "09987507920", false, "2821e323-e6fb-4cc7-84ea-2468649965c7", false, "Sara@gmail.com" },
                    { 6, 0, "3e652bfe-a34a-4855-bc87-7c363171f651", "Milad@gmail.com", false, null, false, false, null, "MILAD@GMAIL.COM", "MILAD@GMAIL.COM", "AQAAAAIAAYagAAAAEDFDqPBzcPiEkhk4q1x1/H2ydskV6NI3OuIH/4D4SiTCrujFnawrlkGwn4aHSfq8mQ==", "09377907920", false, "fe9bb944-072e-4225-90f8-8b0175e9284b", false, "Milad@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Active", "CreateAt", "ImgUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(1293), "assets/img/b-1.jpg", false, "آموزش" },
                    { 2, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(1302), "assets/img/car/c-2.jpg", false, "حمل و نقل" },
                    { 3, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(1304), "assets/img/listing/l-3.jpg", false, "خدمات منزل " },
                    { 4, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(1305), "assets/img/c-4.jpg", false, "تاسیسات" },
                    { 5, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(1306), "assets/img/real/r-8.jpg", false, "بنایی و ساخت و ساز" },
                    { 6, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(1307), "assets/img/listing/1-5.jpg", false, "خدمات زیبایی" },
                    { 7, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(1308), "assets/img/med/4.jpg", false, "سلامت و بهداشت" },
                    { 8, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(1310), "assets/img/med/8.jpg", false, "حیوانات" },
                    { 9, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(1311), "assets/img/b-5.jpg", false, "کسب و کار" },
                    { 10, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(1312), "assets/img/b-4.jpg", false, "دیجیتال" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Active", "CreateAt", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7286), false, "تهران" },
                    { 2, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7295), false, "اردبیل" },
                    { 3, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7296), false, "فارس" },
                    { 4, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7297), false, "اصفهان" },
                    { 5, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7298), false, "زنجان" },
                    { 6, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7299), false, "آذربایجان شرقی" },
                    { 7, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7301), false, "آذربایجان غربی" },
                    { 8, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7302), false, "خوزستان" },
                    { 9, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7303), false, "مازندران" },
                    { 10, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7304), false, "کرمان" },
                    { 11, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7305), false, "سیستان و بلوچستان" },
                    { 12, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7306), false, "البرز" },
                    { 13, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7307), false, "گیلان" },
                    { 14, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7308), false, "کرمانشاه" },
                    { 15, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7309), false, "گلستان" },
                    { 16, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7318), false, "لرستان" },
                    { 17, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7426), false, "هرمزگان" },
                    { 18, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7428), false, "همدان" },
                    { 19, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7438), false, "کردستان" },
                    { 20, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7457), false, "قم" },
                    { 21, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7458), false, "مرکزی" },
                    { 22, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7459), false, "قزوین" },
                    { 23, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7460), false, "خراسان رضوی" },
                    { 24, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7461), false, "یزد" },
                    { 25, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7462), false, "بوشهر" },
                    { 26, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7464), false, "چهارمحال بختیاری" },
                    { 27, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7465), false, "خراسان شمالی" },
                    { 28, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7466), false, "خراسان جنوبی" },
                    { 29, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7467), false, "سمنان" },
                    { 30, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7468), false, "ایلام" },
                    { 31, false, new DateTime(2024, 6, 2, 10, 29, 18, 833, DateTimeKind.Local).AddTicks(7469), false, "کهکیلویه و بویر احمد" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Active", "ApplicationUserId", "CreateAt", "FirstName", "IsDeleted", "LastName", "PhoneNumber", "ProfileImgUrl" },
                values: new object[] { 1, false, 1, new DateTime(2024, 6, 2, 10, 29, 18, 832, DateTimeKind.Local).AddTicks(4278), "حانیه", false, "امین زاده", "0910000000", "/assets/img/admins/1.jpg" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 2, 5 },
                    { 2, 6 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Active", "Address", "ApplicationUserId", "BirthDate", "CardNumber", "CityId", "CreatAt", "Description", "FirstName", "IsDeleted", "LastName", "PhoneNumber", "ProfileImgUrl" },
                values: new object[,]
                {
                    { 1, false, "تهران، زمزم", 2, null, "6062731158189235", 1, new DateTime(2024, 6, 2, 10, 29, 18, 834, DateTimeKind.Local).AddTicks(8474), null, "سحر", false, "کرامت", "091234567", "/assets/img/customers/1.jpg" },
                    { 2, false, "اصفهان", 3, null, "2232789665980654", 4, new DateTime(2024, 6, 2, 10, 29, 18, 834, DateTimeKind.Local).AddTicks(8508), null, "علی", false, "کریمی", "0919048876", "/assets/img/customers/2.jpg" },
                    { 3, false, "قم", 4, null, "2345654367587790", 20, new DateTime(2024, 6, 2, 10, 29, 18, 834, DateTimeKind.Local).AddTicks(8512), null, "رضا", false, "رضائی", "099076483", "/assets/img/customers/3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Experts",
                columns: new[] { "Id", "Active", "Address", "ApplicationUserId", "BirthDate", "CardNumber", "CityId", "CreateAt", "Description", "FirstName", "IsDeleted", "LastName", "PhoneNumber", "ProfileImgUrl", "Score", "ShebaNumber" },
                values: new object[,]
                {
                    { 1, false, "تهران، اکباتان", 5, null, null, 1, new DateTime(2024, 6, 2, 10, 29, 18, 835, DateTimeKind.Local).AddTicks(9804), null, "سارا", false, "امینی", "09377907920", null, null, null },
                    { 2, false, "تهران", 6, null, null, 1, new DateTime(2024, 6, 2, 10, 29, 18, 835, DateTimeKind.Local).AddTicks(9824), null, "میلاد", false, "امیری", "09377907920", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Active", "CategoryId", "CreatAt", "Description", "ImgUrl", "IsDeleted", "Price", "Title" },
                values: new object[,]
                {
                    { 1, false, 1, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9732), null, "", false, 200000, "آموزش موسیقی ویولن" },
                    { 2, false, 1, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9749), null, null, false, 400000, "آموزش تار" },
                    { 3, false, 1, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9751), null, null, false, 300000, "آموزش هنگ درام" },
                    { 4, false, 1, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9753), null, null, false, 500000, "آموزش زبان انگلیسی" },
                    { 5, false, 1, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9754), null, null, false, 700000, "آموزش نقاشی و طراحی" },
                    { 6, false, 1, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9756), null, null, false, 60000, "آموزش عکاسی" },
                    { 7, false, 1, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9758), null, null, false, 55000, "آموزش آشپزی" },
                    { 8, false, 1, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9760), null, null, false, 70000, "آموزش خیاطی" },
                    { 9, false, 1, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9761), null, null, false, 390000, "آموزش پیانو" },
                    { 10, false, 1, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9763), null, null, false, 450000, "آموزش رباتیک" },
                    { 11, false, 2, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9765), null, null, false, 500000, "کارگر اسباب کشی" },
                    { 12, false, 2, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9766), null, null, false, 1000000, "سرویس و تعمیر خودرو" },
                    { 13, false, 2, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9769), null, null, false, 100000, "کارواش ماشین" },
                    { 14, false, 2, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9770), null, null, false, 350000, "سرویس و تعمیر موتور سیکلت" },
                    { 15, false, 2, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9772), null, null, false, 500000, "باربری و اتوبار" },
                    { 16, false, 2, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9774), null, null, false, 2000000, "صافکاری و نقاشی" },
                    { 17, false, 2, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9775), null, null, false, 1000000, "اجار خودرو" },
                    { 18, false, 2, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9777), null, null, false, 600000, "بسته بندی و اسباب اثاثیه" },
                    { 19, false, 3, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9778), null, null, false, 200000, "نظافت منزل" },
                    { 20, false, 3, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9780), null, null, false, 80000, "نظافت راه پله و فضای مشاع" },
                    { 21, false, 3, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9782), null, null, false, 80000, "نظافت سوله و انبار" },
                    { 22, false, 3, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9783), null, null, false, 100000, "نظافت استخیر" },
                    { 23, false, 3, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9785), null, null, false, 500000, "سرایداری و نگهبانی" },
                    { 24, false, 3, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9786), null, null, false, 750000, "ضدعفونی منزل و محل کار" },
                    { 25, false, 3, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9788), null, null, false, 1000000, "قالیشویی" },
                    { 26, false, 3, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9790), null, null, false, 1000000, "مبلشویی" },
                    { 27, false, 3, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9791), null, null, false, 800000, "فیشینگ ساختمان" },
                    { 28, false, 4, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9794), null, null, false, 200000, "نصب ماشین ظرفشویی" },
                    { 29, false, 4, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9795), null, null, false, 200000, "نصب ماشین لباسشویی" },
                    { 30, false, 4, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9797), null, null, false, 800000, "نصب و تعمیر شیرآلات" },
                    { 31, false, 4, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9798), null, null, false, 350000, "نصب و تعمیر دوربین مداربسته" },
                    { 32, false, 4, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9800), null, null, false, 100000, "نصب و تعمیر آیفون تصویری و صوتی" },
                    { 33, false, 4, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9802), null, null, false, 3000000, "سیم کشی ساختمان" },
                    { 34, false, 4, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9803), null, null, false, 550000, "نصب و تعمیر موتور برق" },
                    { 35, false, 4, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9805), null, null, false, 700000, "نصب و تعمیر لوستر و برق" },
                    { 36, false, 4, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9806), null, null, false, 750000, "نصب و تعمیر دزدگیر ساختمان" },
                    { 37, false, 4, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9808), null, null, false, 200000, "تعمیر تلفن" },
                    { 38, false, 4, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9810), null, null, false, 200000, "نصب و تعمیر دستگاه پوز و کارتخوان" },
                    { 39, false, 4, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9811), null, null, false, 1000000, "نصب و تعمیر پکیج سرمایشی و گرمایشی" },
                    { 40, false, 4, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9813), null, null, false, 1500000, "خدمات برق صنعتی" },
                    { 41, false, 5, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9815), null, null, false, 5000000, "ساخت و نصب و تعمیر سوله و کانکس" },
                    { 42, false, 5, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9816), null, null, false, 900000, "کارگر ساده" },
                    { 43, false, 5, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9884), null, null, false, 1000000, "بنایی" },
                    { 44, false, 5, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9886), null, null, false, 10000000, "بازسازی خانه" },
                    { 45, false, 5, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9888), null, null, false, 5000000, "سیمان کاری" },
                    { 46, false, 5, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9889), null, null, false, 550000, "نصب کاشی و سرامیک" },
                    { 47, false, 5, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9891), null, null, false, 45000, "سنگ کاری" },
                    { 48, false, 5, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9893), null, null, false, 20000000, "گچ کاری و گچبری" },
                    { 49, false, 5, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9895), null, null, false, 30000000, "ساخت و تعمیر استخر و سونا و جکوزی" },
                    { 50, false, 5, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9897), null, null, false, 20000000, "تخریب ساختمان" },
                    { 51, false, 5, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9899), null, null, false, 1500000, "رفع نم و رطوبت" },
                    { 52, false, 5, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9900), null, null, false, 1000000, "رابیس کاری" },
                    { 53, false, 6, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9902), null, null, false, 4000000, "رنگ مو" },
                    { 54, false, 6, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9903), null, null, false, 1000000, "شینیون مو" },
                    { 55, false, 6, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9905), null, null, false, 3000000, "تتو" },
                    { 56, false, 6, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9907), null, null, false, 300000, "اصلاح سر و صورت" },
                    { 57, false, 6, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9908), null, null, false, 500000, "خدمات ناخن" },
                    { 58, false, 6, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9910), null, null, false, 350000, "پاکسازی صورت" },
                    { 59, false, 6, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9911), null, null, false, 1500000, "میکاپ صورت" },
                    { 60, false, 6, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9913), null, null, false, 3000000, "کراتینه مو" },
                    { 61, false, 6, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9915), null, null, false, 550000, "ویتامینه و ماسک مو" },
                    { 62, false, 6, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9916), null, null, false, 3000000, "میکرو بیلدینگ ابرو" },
                    { 63, false, 6, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9918), null, null, false, 1000000, "لیفت مژه و آبرو" },
                    { 64, false, 7, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9919), null, null, false, 2500000, "تست و آزمایش" },
                    { 65, false, 7, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9921), null, null, false, 200000, "ویزیت پزشکی" },
                    { 66, false, 7, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9922), null, null, false, 500000, "نوار قلب" },
                    { 67, false, 7, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9924), null, null, false, 1000000, "سونوگرافی و فیزیوتراپی" },
                    { 68, false, 8, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9926), null, null, false, 200000, "حمل و نقل حیوانات" },
                    { 69, false, 8, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9928), null, null, false, 200000, "نگهداری حیوانات خانگی" },
                    { 70, false, 8, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9930), null, null, false, 100000, "تربیت گربه" },
                    { 71, false, 8, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9931), null, null, false, 100000, "تربیت سگ" },
                    { 72, false, 8, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9933), null, null, false, 200000, "تربین اسب" },
                    { 73, false, 8, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9934), null, null, false, 200000, "خدمات آزمایشگاهی حیوانات" },
                    { 74, false, 8, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9936), null, null, false, 350000, "صدور شناسنامه حیوانات" },
                    { 75, false, 8, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9937), null, null, false, 150000, "واکسن حیوانات" },
                    { 76, false, 8, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9939), null, null, false, 100000, "معاینه و درمان حیوانات" },
                    { 77, false, 8, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9941), null, null, false, 400000, "رادیولوژی و سونوگرافی حیوانات" },
                    { 78, false, 9, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9942), null, null, false, 100000, "مدلسازی کامپیوتری" },
                    { 79, false, 9, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9944), null, null, false, 100000, "مشاوره مالیاتی" },
                    { 80, false, 9, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9945), null, null, false, 100000, "مشاوره سرمایه گذاری" },
                    { 81, false, 9, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9947), null, null, false, 100000, "مشاوره حقوقی" },
                    { 82, false, 9, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9948), null, null, false, 100000, "طراحی کاتالوگ و بوروشور" },
                    { 83, false, 9, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9950), null, null, false, 100000, "طراحی گرافیک وب" },
                    { 84, false, 9, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9952), null, null, false, 100000, "طراحی Ui-Ux" },
                    { 85, false, 9, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9953), null, null, false, 100000, "طراحی سابت" },
                    { 86, false, 9, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9955), null, null, false, 100000, "ساخت اپلیکیشن" },
                    { 87, false, 9, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9957), null, null, false, 100000, "تولید محتوای سایت" },
                    { 88, false, 9, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9958), null, null, false, 100000, "زیرنویس فیلم" },
                    { 89, false, 9, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9960), null, null, false, 100000, "طراحی پوستر" },
                    { 90, false, 9, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9961), null, null, false, 100000, "طراحی لوگو" },
                    { 91, false, 9, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9963), null, null, false, 100000, "قفسه بنوی فروشگاه و انبار" },
                    { 92, false, 10, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9964), null, null, false, 350000, "تعمیر کامپیووتر" },
                    { 93, false, 10, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9966), null, null, false, 350000, "تعمیر لپ تاپ" },
                    { 94, false, 10, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9968), null, null, false, 250000, "تعمیر دستگاه پرینتر" },
                    { 95, false, 10, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9969), null, null, false, 500000, "سرویس و تعمیر برد هوشمند" },
                    { 96, false, 10, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9971), null, null, false, 250000, "تعمیر ویندوز و نرم افزار" },
                    { 99, false, 10, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9972), null, null, false, 400000, "مجازی سازی سرور" },
                    { 100, false, 10, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9974), null, null, false, 300000, "خدمات امنیت شبکه" },
                    { 101, false, 10, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9975), null, null, false, 1000000, "تعمیرات موبایل و تبلت" },
                    { 102, false, 10, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9977), null, null, false, 250000, "تعمیر و نصب اسکنر" },
                    { 103, false, 10, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9979), null, null, false, 850000, "سرویس و تعمیر دستگاه تست اسکناس" },
                    { 104, false, 10, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9980), null, null, false, 850000, "سرویس و تعمیر دستگاه پول شمار" },
                    { 105, false, 10, new DateTime(2024, 6, 2, 10, 29, 18, 836, DateTimeKind.Local).AddTicks(9982), null, null, false, 550000, "سرویس و تعمیر دستگاه اثر اگشت" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_ApplicationUserId",
                table: "Admins",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_ExpertId",
                table: "Bids",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_RequestId",
                table: "Bids",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CustomerId",
                table: "Comments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ExpertId",
                table: "Comments",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ApplicationUserId",
                table: "Customers",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CityId",
                table: "Customers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Experts_ApplicationUserId",
                table: "Experts",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Experts_CityId",
                table: "Experts",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertService_ServicesId",
                table: "ExpertService",
                column: "ServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CustomerId",
                table: "Requests",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ServiceId",
                table: "Requests",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_CategoryId",
                table: "Services",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bids");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ExpertService");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Experts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
