using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductManagementApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDescritionOnProductSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Stay connected with the latest technology in your hands. Our smartphone offers top-of-the-line features and sleek design.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Boost your productivity with our high-performance laptop. Perfect for work, entertainment, and everything in between.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Stay active and organized with our smartwatch. Track your fitness goals, receive notifications, and more, all from your wrist.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Experience true freedom with our wireless earbuds. Enjoy crystal-clear sound and hands-free convenience on the go.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Capture life's moments in stunning detail with our digital camera. Whether you're a beginner or a professional, our camera has you covered.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Immerse yourself in a world of entertainment with our 4K TV. Experience vibrant colors, sharp contrast, and lifelike images from the comfort of your home.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Take your gaming experience to the next level with our gaming console. Play the latest titles, stream your favorite content, and connect with friends online.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Achieve your fitness goals with our fitness tracker. Monitor your activity, track your workouts, and stay motivated on your journey to a healthier lifestyle.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Experience versatility and portability with our tablet. Whether you're working, browsing, or streaming, our tablet adapts to your needs.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Immerse yourself in music with our headphones. Enjoy crisp, clear sound and comfortable listening for hours on end.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Transform your home into a smart home with our smart home hub. Control your devices, automate your routines, and enhance your living space with ease.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Simplify your cleaning routine with our robot vacuum. Sit back, relax, and let our vacuum do the work for you, leaving your floors spotless.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "Start your day off right with our coffee maker. Brew your favorite blend to perfection and enjoy a delicious cup of coffee every time.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Enhance your listening experience with our Bluetooth speaker. Whether you're at home or on the go, enjoy rich, immersive sound wherever you are.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Simplify charging with our wireless charger. Say goodbye to tangled cords and enjoy effortless charging for your compatible devices.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Explore the skies and capture stunning aerial footage with our drone. Whether you're a hobbyist or a professional, our drone delivers unparalleled performance and versatility.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "Immerse yourself in a world of books with our e-book reader. Enjoy thousands of titles at your fingertips, anytime, anywhere.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Stay powered up on the go with our portable power bank. Never worry about running out of battery again, whether you're traveling, commuting, or exploring.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "Keep your files safe and secure with our external hard drive. Whether you're storing documents, photos, or videos, our hard drive has ample storage for all your needs.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "Capture life's adventures in stunning detail with our action camera. Whether you're hiking, biking, or snorkeling, our camera is built to withstand the elements and capture every moment.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");
        }
    }
}
