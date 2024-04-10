using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Draft_Demo.Migrations
{
    public partial class name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgentType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Image = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MaterialType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    DefectedPercent = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    DefectedPercent = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    INN = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    QualityRating = table.Column<int>(nullable: true),
                    SupplierType = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Agent",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    AgentTypeID = table.Column<int>(nullable: false),
                    Address = table.Column<string>(maxLength: 300, nullable: false),
                    INN = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    KPP = table.Column<string>(unicode: false, maxLength: 9, nullable: false),
                    DirectorName = table.Column<string>(maxLength: 100, nullable: false),
                    Phone = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    Logo = table.Column<string>(maxLength: 100, nullable: false),
                    Priority = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agent", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Agent_AgentType",
                        column: x => x.AgentTypeID,
                        principalTable: "AgentType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    CountInPack = table.Column<int>(nullable: true),
                    Unit = table.Column<string>(maxLength: 10, nullable: false),
                    CountInStock = table.Column<double>(nullable: true),
                    MinCount = table.Column<double>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    Image = table.Column<byte[]>(maxLength: 50, nullable: true),
                    MaterialTypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Material_MaterialType",
                        column: x => x.MaterialTypeID,
                        principalTable: "MaterialType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    ProductTypeID = table.Column<int>(nullable: true),
                    ArticleNumber = table.Column<string>(maxLength: 10, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Image = table.Column<byte[]>(maxLength: 50, nullable: false),
                    ProductionPersonCount = table.Column<int>(nullable: true),
                    ProductionWorkshopNumber = table.Column<int>(nullable: true),
                    MinCostForAgent = table.Column<decimal>(type: "decimal(10, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_ProductType",
                        column: x => x.ProductTypeID,
                        principalTable: "ProductType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AgentPriorityHistory",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentID = table.Column<int>(nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PriorityValue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentPriorityHistory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AgentPriorityHistory_Agent",
                        column: x => x.AgentID,
                        principalTable: "Agent",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Address = table.Column<string>(maxLength: 300, nullable: false),
                    AgentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shop_Agent",
                        column: x => x.AgentID,
                        principalTable: "Agent",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialCountHistory",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialID = table.Column<int>(nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CountValue = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialCountHistory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MaterialCountHistory_Material",
                        column: x => x.MaterialID,
                        principalTable: "Material",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialSupplier",
                columns: table => new
                {
                    MaterialID = table.Column<int>(nullable: false),
                    SupplierID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSupplier", x => new { x.MaterialID, x.SupplierID });
                    table.ForeignKey(
                        name: "FK_MaterialSupplier_Material",
                        column: x => x.MaterialID,
                        principalTable: "Material",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialSupplier_Supplier",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCostHistory",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CostValue = table.Column<decimal>(type: "decimal(10, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCostHistory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductCostHistory_Product",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductMaterial",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false),
                    MaterialID = table.Column<int>(nullable: false),
                    Count = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMaterial", x => new { x.ProductID, x.MaterialID });
                    table.ForeignKey(
                        name: "FK_ProductMaterial_Material",
                        column: x => x.MaterialID,
                        principalTable: "Material",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductMaterial_Product",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSale",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    SaleDate = table.Column<DateTime>(type: "date", nullable: false),
                    ProductCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSale", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductSale_Agent",
                        column: x => x.AgentID,
                        principalTable: "Agent",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSale_Product",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agent_AgentTypeID",
                table: "Agent",
                column: "AgentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_AgentPriorityHistory_AgentID",
                table: "AgentPriorityHistory",
                column: "AgentID");

            migrationBuilder.CreateIndex(
                name: "IX_Material_MaterialTypeID",
                table: "Material",
                column: "MaterialTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialCountHistory_MaterialID",
                table: "MaterialCountHistory",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSupplier_SupplierID",
                table: "MaterialSupplier",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductTypeID",
                table: "Product",
                column: "ProductTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCostHistory_ProductID",
                table: "ProductCostHistory",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaterial_MaterialID",
                table: "ProductMaterial",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSale_AgentID",
                table: "ProductSale",
                column: "AgentID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSale_ProductID",
                table: "ProductSale",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_AgentID",
                table: "Shop",
                column: "AgentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgentPriorityHistory");

            migrationBuilder.DropTable(
                name: "MaterialCountHistory");

            migrationBuilder.DropTable(
                name: "MaterialSupplier");

            migrationBuilder.DropTable(
                name: "ProductCostHistory");

            migrationBuilder.DropTable(
                name: "ProductMaterial");

            migrationBuilder.DropTable(
                name: "ProductSale");

            migrationBuilder.DropTable(
                name: "Shop");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Agent");

            migrationBuilder.DropTable(
                name: "MaterialType");

            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropTable(
                name: "AgentType");
        }
    }
}
