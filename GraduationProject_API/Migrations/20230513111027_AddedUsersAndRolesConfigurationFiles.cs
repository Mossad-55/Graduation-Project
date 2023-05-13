using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class AddedUsersAndRolesConfigurationFiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64F2143D-B896-4355-90D2-AFD22424B234", "115bf414-9809-4fc5-a1a9-418e882fe423", "Department Admin", "DEPARTMENT ADMIN" },
                    { "A2523A70-57E3-4B69-A405-F9752517ED62", "908e1f74-fea9-49a0-b938-7f2ce9155eef", "Faculty Admin", "FACULTY ADMIN" },
                    { "BEA713C7-93D2-4F39-8DC8-18F2F3070779", "df408cb7-8b1d-4e75-b356-0a8d0cd9d857", "University Admin", "UNIVERSITY ADMIN" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "7faf8be4-9850-4208-9441-892d15531c3c", "Student", "STUDENT" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "487c96fd-d562-411c-bda1-25c84ecfce3c", "Professor", "PROFESSOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4093fa25-ed6b-11ed-a6df-105badc84798", 0, "98fa35d1-4226-4e48-8021-182f6e505869", "Hamza.Najmb32d@example.com", true, "Hamza", "Najmb32d", false, null, "HAMZA.NAJMB32D@EXAMPLE.COM", "HAMZA.NAJMB32D@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHea8VfFXyFLSZS2NpetBC7XhQ4/Q4rbnPnRTTwA1SWff91V1r4MpKoMG/+C44W03A==", "01232988337", false, "6e3f1b5b-7de3-4b8a-89bb-d7c256b87c73", false, "Hamza.Najmb32d@example.com" },
                    { "4093fa27-ed6b-11ed-8922-105badc84798", 0, "34a1e284-206e-48ad-8921-98832dc7f464", "Malek.Sheikh9cd6@example.com", true, "Malek", "Sheikh9cd6", false, null, "MALEK.SHEIKH9CD6@EXAMPLE.COM", "MALEK.SHEIKH9CD6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHLqCDa5/EEFW0eqp63WeoWuU3EQPM7250R8XgquFb9I2TizWGFQP+Xy1Skqtom2dQ==", "01220871240", false, "10e5ecf7-9d23-4045-9c20-2d255859c570", false, "Malek.Sheikh9cd6@example.com" },
                    { "4093fa29-ed6b-11ed-85ba-105badc84798", 0, "cc3e6ede-a8f3-4d4e-bc23-a2c68ade8d0b", "Zachariah.Hishamiaac8@example.com", true, "Zachariah", "Hishamiaac8", false, null, "ZACHARIAH.HISHAMIAAC8@EXAMPLE.COM", "ZACHARIAH.HISHAMIAAC8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFF7gKbTIcV1GiBIpFC+eytMnZmPhCNVS8HPmHJr/TSsx67fQOZY3t7mDJcj0TmNjw==", "01269689816", false, "1d738832-c21e-464a-a819-aeec78856e53", false, "Zachariah.Hishamiaac8@example.com" },
                    { "4093fa2b-ed6b-11ed-9be9-105badc84798", 0, "d4af0eb0-3a99-42ac-b0ab-787af0a75c8a", "Bassam.Barra9103@example.com", true, "Bassam", "Barra9103", false, null, "BASSAM.BARRA9103@EXAMPLE.COM", "BASSAM.BARRA9103@EXAMPLE.COM", "AQAAAAEAACcQAAAAEK/OQROR/6qCaESvK99ntvatownwYaTAW/FklVvox0AwttW6cnUUCtiviyxwOb4D9Q==", "01287718443", false, "097cd744-a684-4a2e-86df-cc45630ffbb5", false, "Bassam.Barra9103@example.com" },
                    { "4093fa2d-ed6b-11ed-a65f-105badc84798", 0, "637b7ca9-0c65-439b-8131-6c8b73129c03", "​​Karim.Ahmed9826@example.com", true, "​​Karim", "Ahmed9826", false, null, "​​KARIM.AHMED9826@EXAMPLE.COM", "​​KARIM.AHMED9826@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHXvSnir3b3El3nO5ArTxH0Y+7CgudjeyQukI70hfqLO93sE/0ryEVZOf1CiAn7Esw==", "01229669039", false, "2266b173-5af2-4ce2-bd9c-518fd9115073", false, "​​Karim.Ahmed9826@example.com" },
                    { "409676b0-ed6b-11ed-9fd6-105badc84798", 0, "1c000f15-8fe8-4d30-ad88-a872e28be313", "Russell.Jawada950@example.com", true, "Russell", "Jawada950", false, null, "RUSSELL.JAWADA950@EXAMPLE.COM", "RUSSELL.JAWADA950@EXAMPLE.COM", "AQAAAAEAACcQAAAAEExZBn0X1/PnZ+zMnPykUd0erDg/zoPzydNzSd7HrvGXsjHVPZHM9VFBmRWZN8P7Sg==", "01258890451", false, "43eff80a-7566-45e6-8f63-56fd67287cda", false, "Russell.Jawada950@example.com" },
                    { "409676b2-ed6b-11ed-b62e-105badc84798", 0, "6fcfc5ad-967c-42b2-ba65-39384934d7d5", "Helsey.Bahiabb8@example.com", true, "Helsey", "Bahiabb8", false, null, "HELSEY.BAHIABB8@EXAMPLE.COM", "HELSEY.BAHIABB8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDclBlEBxMUnKfmd8MWB8OpnWFPq2w/SJ8l7yKgzcK12Ebg5UNuxuHv1VWW6UkBlxQ==", "01271822961", false, "a865a628-ef67-41b7-b9ed-f28f4be1c391", false, "Helsey.Bahiabb8@example.com" },
                    { "409676b4-ed6b-11ed-b886-105badc84798", 0, "975f1704-ebb5-4cc9-9984-f43b90f20fd1", "Adel.Fidaa8283@example.com", true, "Adel", "Fidaa8283", false, null, "ADEL.FIDAA8283@EXAMPLE.COM", "ADEL.FIDAA8283@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBz2q9bWvkOG0Dq5BpNmA216S8lSjA5du6P1d+gnf62kGpk07+U7GGq+8E9fiEZF8w==", "01252839445", false, "528ca2f0-fc3e-4355-b347-6bd64573dc61", false, "Adel.Fidaa8283@example.com" },
                    { "409676b6-ed6b-11ed-b477-105badc84798", 0, "1a997a19-6a28-4103-be1c-d87713d8de68", "Haor.Medhatbb1e@example.com", true, "Haor", "Medhatbb1e", false, null, "HAOR.MEDHATBB1E@EXAMPLE.COM", "HAOR.MEDHATBB1E@EXAMPLE.COM", "AQAAAAEAACcQAAAAEP/HeVm6kBBL47T50lYVgBXBMv1Sh+CW9cYAMURj/xQS2ea9+kPoP9PuK2lkI3YZxA==", "01249787781", false, "634b7cb2-8bff-4631-b9a6-7c369f0ca1a7", false, "Haor.Medhatbb1e@example.com" },
                    { "409676b8-ed6b-11ed-9c16-105badc84798", 0, "3a5549ed-8449-428a-8fd4-7b49784020cf", "Hassan.Haor9c0d@example.com", true, "Hassan", "Haor9c0d", false, null, "HASSAN.HAOR9C0D@EXAMPLE.COM", "HASSAN.HAOR9C0D@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIMqvUJlodJPYbTfCAbukC7DD03zG+KIHWNtsaieUSo5sa7Ykx3pAXcG8eE4FiYsQg==", "01252429834", false, "faf0da48-af8a-4791-9d60-3f9c4c73dd87", false, "Hassan.Haor9c0d@example.com" },
                    { "409676ba-ed6b-11ed-adbf-105badc84798", 0, "b57d50f2-ffd0-41b3-a59e-78b09babf77a", "Sameh.Hilalb0d8@example.com", true, "Sameh", "Hilalb0d8", false, null, "SAMEH.HILALB0D8@EXAMPLE.COM", "SAMEH.HILALB0D8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBNG3Kk/sVqa9U4Yebemo+7xU3/GnCmPxnDlpqkutbCbQsodFxeY9A+KPmG19hQLNg==", "01212885239", false, "702b0461-f690-42bf-a93e-3d5afdb434cd", false, "Sameh.Hilalb0d8@example.com" },
                    { "409676bc-ed6b-11ed-9b21-105badc84798", 0, "0d6505a2-5b4a-4965-a05a-83c851331a18", "Ghaith.Asim9678@example.com", true, "Ghaith", "Asim9678", false, null, "GHAITH.ASIM9678@EXAMPLE.COM", "GHAITH.ASIM9678@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGV3f/7f3gW17+dXFZVvcYfkFhFlshAYYKXW6YN3LEg8bCHQLVV4VEgRLfE+6vH7HQ==", "01286981596", false, "13076e5a-76c7-4c2b-9be0-5f05f61fd030", false, "Ghaith.Asim9678@example.com" },
                    { "409676be-ed6b-11ed-902b-105badc84798", 0, "6b46193a-9174-4534-abf9-942a69ec80c5", "Waseem.Ghanem9305@example.com", true, "Waseem", "Ghanem9305", false, null, "WASEEM.GHANEM9305@EXAMPLE.COM", "WASEEM.GHANEM9305@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPz09XfrPr0TD7BSgRqcH5iBm+oSaB34jbDgE9HRwG923vaFNZG+39IfWHO/a40EUQ==", "01267352439", false, "4d757fd3-6ef2-43ee-bf95-3d1caf105dff", false, "Waseem.Ghanem9305@example.com" },
                    { "409676c0-ed6b-11ed-a990-105badc84798", 0, "8cb71658-270b-4778-8c71-f53674e16586", "Badri.Basemacbd@example.com", true, "Badri", "Basemacbd", false, null, "BADRI.BASEMACBD@EXAMPLE.COM", "BADRI.BASEMACBD@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFdxiTrqr8Y1sTTXD1L00Mo07+EveeUf6pLlFjAJJDdeljpel5N67TroyKgdLMIGbw==", "01297327850", false, "e73abb7f-1d56-4794-9fe2-ea0a61bdd79f", false, "Badri.Basemacbd@example.com" },
                    { "409676c2-ed6b-11ed-a696-105badc84798", 0, "4b44b8f1-3d18-4e23-9e08-6204d5ba2311", "Bacari.Sharmb5af@example.com", true, "Bacari", "Sharmb5af", false, null, "BACARI.SHARMB5AF@EXAMPLE.COM", "BACARI.SHARMB5AF@EXAMPLE.COM", "AQAAAAEAACcQAAAAEE/R4QoiuyQNNtOtA7o1iv49oegZhZEayJaMBTgwOOqhdm6WHfo1Nkb7GtxUEcKT7Q==", "01282353516", false, "629a72f2-d0b9-4b27-8df6-84337270e806", false, "Bacari.Sharmb5af@example.com" },
                    { "409676c4-ed6b-11ed-a637-105badc84798", 0, "258514ca-e372-41f1-8265-3cfefb7d9c2e", "Yakon.Sharm9d1a@example.com", true, "Yakon", "Sharm9d1a", false, null, "YAKON.SHARM9D1A@EXAMPLE.COM", "YAKON.SHARM9D1A@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMS+hWy6F++ebeMbGx1HF0zOZoekB9EeUuZlfC9xTbVBdL2gv7uI9PM0dD+b7QQ3bQ==", "01216786378", false, "f370ae3e-8c49-43f2-9456-3de27721db45", false, "Yakon.Sharm9d1a@example.com" },
                    { "40977647-ed6b-11ed-aad8-105badc84798", 0, "96f19678-a7c0-4b26-90a2-18db015583bd", "Fidaa.Adham9867@example.com", true, "Fidaa", "Adham9867", false, null, "FIDAA.ADHAM9867@EXAMPLE.COM", "FIDAA.ADHAM9867@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGyzRC9rsNO0Q43Opz7PrncRbs5U8Ne3EiAWU8iK7ORXKJdJbH7ysdXLUNf+OivX0A==", "01218203642", false, "f8232558-5458-453e-9889-2c61cd674969", false, "Fidaa.Adham9867@example.com" },
                    { "40977649-ed6b-11ed-973e-105badc84798", 0, "b0e13d42-9929-41ba-a7b8-b663b3a5b39c", "Firas.Bassel82fd@example.com", true, "Firas", "Bassel82fd", false, null, "FIRAS.BASSEL82FD@EXAMPLE.COM", "FIRAS.BASSEL82FD@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGoUeGq+iB/FcLYgC1+0uwkgm/P7ZkynShPUhlfcq9CjUpr8rEUJYUP+X0I1Vk1URQ==", "01217707960", false, "2a1198e9-a514-4cf0-a157-7c070481ce0b", false, "Firas.Bassel82fd@example.com" },
                    { "4097764b-ed6b-11ed-b259-105badc84798", 0, "e09cca23-4eaa-4da8-87d6-bd5eb6105e46", "Sameh.Hishami8757@example.com", true, "Sameh", "Hishami8757", false, null, "SAMEH.HISHAMI8757@EXAMPLE.COM", "SAMEH.HISHAMI8757@EXAMPLE.COM", "AQAAAAEAACcQAAAAEE5+doeLXlUkI2/fs3ze84AoUR9oBQ70RAkIVTvNSx9BOn2P/3UHotqMmC5bkiqXeg==", "01272041260", false, "1b37d2e6-3ee0-470a-bfa1-a2a53af45d44", false, "Sameh.Hishami8757@example.com" },
                    { "4097973c-ed6b-11ed-9913-105badc84798", 0, "76e037ab-bdde-4517-ac7d-5927cfdb6ed1", "Noah.Nahar9371@example.com", true, "Noah", "Nahar9371", false, null, "NOAH.NAHAR9371@EXAMPLE.COM", "NOAH.NAHAR9371@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPOCMP+s3zuyHUaHwBQyTevA4Ir/WursWjwF6KDgKl1IwWMAlDoGepH9U5b207GL0A==", "01244828073", false, "8d62e673-0b18-4af2-a7e4-c2aa2dbc1659", false, "Noah.Nahar9371@example.com" },
                    { "4097973e-ed6b-11ed-929c-105badc84798", 0, "705d82e0-f5c3-4af9-a67d-8d93c7eadb4e", "Saden.Ali8050@example.com", true, "Saden", "Ali8050", false, null, "SADEN.ALI8050@EXAMPLE.COM", "SADEN.ALI8050@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGI4H0V71rjz+PEt9K59oPPOLQxGFhn2Y0QevZmP9uTz4YPMjylVopHGi8qwoVdneg==", "01243048322", false, "f50e0544-8e75-4d0e-b877-ecd0eef057e6", false, "Saden.Ali8050@example.com" },
                    { "40979740-ed6b-11ed-8c11-105badc84798", 0, "5e91e10e-4204-44f0-8e8e-1f9a55dbcc35", "Ghaith.Basselb8db@example.com", true, "Ghaith", "Basselb8db", false, null, "GHAITH.BASSELB8DB@EXAMPLE.COM", "GHAITH.BASSELB8DB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBKezBmXlB7DxWHj7QPUCzjK7/roUp0/q2HoLJ/3IZsl3B+v8T9dtgr9l+KMpOfCuA==", "01288105916", false, "00274259-8ee6-423b-b281-f3bfb9bc6cb1", false, "Ghaith.Basselb8db@example.com" },
                    { "40979742-ed6b-11ed-b3de-105badc84798", 0, "29d831aa-b1e1-41f2-b920-3d76c4724d47", "​​Karim.Basem9bee@example.com", true, "​​Karim", "Basem9bee", false, null, "​​KARIM.BASEM9BEE@EXAMPLE.COM", "​​KARIM.BASEM9BEE@EXAMPLE.COM", "AQAAAAEAACcQAAAAENStoECCsGBLFu30nFYxU6w+ZT4b8M4YDRK/ahYobE1R1DXLjghhWqBZ8mqP8Iu0BA==", "01273133463", false, "3906f0d2-69e8-426b-acce-9e7b1c25778a", false, "​​Karim.Basem9bee@example.com" },
                    { "40979744-ed6b-11ed-8abc-105badc84798", 0, "295efcb6-d253-429c-a075-4ad41b639f7d", "Minali.Medhat86ba@example.com", true, "Minali", "Medhat86ba", false, null, "MINALI.MEDHAT86BA@EXAMPLE.COM", "MINALI.MEDHAT86BA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEL4XE8amJB9QphCSI936I7KhU+OrgRnaP6qVGn16KicoETM1/9ho4zdrXFgDLyw+7w==", "01279049557", false, "5864450f-2cc2-4234-b2f5-5039c2f3e388", false, "Minali.Medhat86ba@example.com" },
                    { "4097c4fc-ed6b-11ed-84e8-105badc84798", 0, "6139ee34-6b9a-4f80-82ef-ffd5390a92e5", "Bilal.Zachariah83af@example.com", true, "Bilal", "Zachariah83af", false, null, "BILAL.ZACHARIAH83AF@EXAMPLE.COM", "BILAL.ZACHARIAH83AF@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPxCYXyAutLvQ52NrWSVxiPWE6yRKteAxY/8utrtxr+LvkFscKInK30h8bIkTYNqoA==", "01293395937", false, "66e9296b-8229-45e8-899b-5b2db01f9bd3", false, "Bilal.Zachariah83af@example.com" },
                    { "4097c4fe-ed6b-11ed-b56a-105badc84798", 0, "74c84a7a-ba3b-4d56-aec9-cc847b7f037d", "Abi.Radwana902@example.com", true, "Abi", "Radwana902", false, null, "ABI.RADWANA902@EXAMPLE.COM", "ABI.RADWANA902@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFQHdDqVXgGZZbmBOWhr2ubxBbUfN1Yd66iEJRljX49xuEr/870i8FNfYjRoxqeH8w==", "01269899834", false, "d3207cfa-5314-49f5-8d2d-a931a8a47e49", false, "Abi.Radwana902@example.com" },
                    { "4097c500-ed6b-11ed-b1ae-105badc84798", 0, "ae8833d2-276f-42ea-91bc-e1b73421b06e", "Russell.Hosni9590@example.com", true, "Russell", "Hosni9590", false, null, "RUSSELL.HOSNI9590@EXAMPLE.COM", "RUSSELL.HOSNI9590@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOwuqzCukN/M1JYgE7GLL4a+hXZMmJQ5E1JbytHPK6TjEqElLQSlv88OWUNWioMi/A==", "01219006694", false, "c3c008e4-d14f-4437-9554-c0e463ece464", false, "Russell.Hosni9590@example.com" },
                    { "4097d8e5-ed6b-11ed-8a0f-105badc84798", 0, "93f64f34-8e57-4c69-b40a-ce88ea3efbcd", "Samhi.Baqibff9@example.com", true, "Samhi", "Baqibff9", false, null, "SAMHI.BAQIBFF9@EXAMPLE.COM", "SAMHI.BAQIBFF9@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAfai/M/n48Wa1Z3/DQxPdCQGKdAqZyt1PIHNRHgmv5gXGM3IKEL9N8olRjJ7IP6/w==", "01254158559", false, "2e522076-43eb-4d0e-b271-808a81507c9b", false, "Samhi.Baqibff9@example.com" },
                    { "4097d8e7-ed6b-11ed-b377-105badc84798", 0, "628b93dd-3b4d-4677-9719-612b0f2d7cb3", "Ghanem.Adham8b37@example.com", true, "Ghanem", "Adham8b37", false, null, "GHANEM.ADHAM8B37@EXAMPLE.COM", "GHANEM.ADHAM8B37@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFkTK6BjUrbLMHPsCTovqEMyPucvt1Kjn1Qijerbow0aP8LBPRaaqvIlKcCy4jdmmQ==", "01217050688", false, "8fa98c05-c5f0-47b0-847d-d5241e44cd92", false, "Ghanem.Adham8b37@example.com" },
                    { "4097d8e9-ed6b-11ed-83d1-105badc84798", 0, "4f07c2ec-846d-440e-9d68-bf12a48fc56f", "Dagher.Hilali951a@example.com", true, "Dagher", "Hilali951a", false, null, "DAGHER.HILALI951A@EXAMPLE.COM", "DAGHER.HILALI951A@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFI8TTQPMEeqg3rZmdbrU9EAb7ZyJSKuS64rNl6RoJUtI417ez7Csv5j0iYuUmiQpQ==", "01268897899", false, "5f258f60-c68f-4a1f-922d-60a8e4a7e328", false, "Dagher.Hilali951a@example.com" },
                    { "4097d8eb-ed6b-11ed-8f98-105badc84798", 0, "424bd0eb-b639-4709-a8df-f21e55d8ec61", "Hussein.Sameha5e1@example.com", true, "Hussein", "Sameha5e1", false, null, "HUSSEIN.SAMEHA5E1@EXAMPLE.COM", "HUSSEIN.SAMEHA5E1@EXAMPLE.COM", "AQAAAAEAACcQAAAAECYYaoyEaemnDMMXLTPBAgjMd+l438+Ayc6gWykVa4eIT0/03YkuXy10+EIAQP7Rog==", "01242105816", false, "22f81371-a46b-49c6-8e83-47a6c3b97dd5", false, "Hussein.Sameha5e1@example.com" },
                    { "4097d8ed-ed6b-11ed-9f99-105badc84798", 0, "2ab9afd1-980d-404c-a6a1-082f84d38035", "Hamaqy.Saber9b17@example.com", true, "Hamaqy", "Saber9b17", false, null, "HAMAQY.SABER9B17@EXAMPLE.COM", "HAMAQY.SABER9B17@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJC0UTIkFQEQSHaN1F/3DFYC/aPguiwGHebCHogUHqP/PGG6CIGeKz6d4jt48j5iIQ==", "01273898120", false, "ac638ba7-917d-46b8-a1b5-892b0cba93a6", false, "Hamaqy.Saber9b17@example.com" },
                    { "4097d8ef-ed6b-11ed-8cd4-105badc84798", 0, "073569b1-2d41-4fbb-95e2-222e6f9b5ea0", "Sheila.Sheilaa655@example.com", true, "Sheila", "Sheilaa655", false, null, "SHEILA.SHEILAA655@EXAMPLE.COM", "SHEILA.SHEILAA655@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGxU7c2juGXbgLhre7/wnQo9yJRXKdrzluo2GpjDRZQN0hFKFuwkw2fs/+UCegS1kQ==", "01267569088", false, "be2581d4-44db-42a7-93a9-487f1aa03d12", false, "Sheila.Sheilaa655@example.com" },
                    { "4097d8f1-ed6b-11ed-aa86-105badc84798", 0, "578e791a-97a0-4909-8a61-ff41de1b4662", "Daniel.Bahib5ad@example.com", true, "Daniel", "Bahib5ad", false, null, "DANIEL.BAHIB5AD@EXAMPLE.COM", "DANIEL.BAHIB5AD@EXAMPLE.COM", "AQAAAAEAACcQAAAAEN00cj5ia96tbcNmONBcYN7RcgR4lcQ94vC2HEixkKXBbGbSD61lZeCKRvroTtklfA==", "01262123625", false, "2a60f0ef-ed83-4303-9786-cc58c841cf1d", false, "Daniel.Bahib5ad@example.com" },
                    { "4097d8f3-ed6b-11ed-9479-105badc84798", 0, "b9941da9-cf89-4b45-b03f-92705daa7e64", "Halsi.Kolthouma5c7@example.com", true, "Halsi", "Kolthouma5c7", false, null, "HALSI.KOLTHOUMA5C7@EXAMPLE.COM", "HALSI.KOLTHOUMA5C7@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPIBnAZAeJ2ospjFepYEwPfj1x1Pi7zAK7oN5/4gQOjPkaDGFZknn+SuuE+VMon+/Q==", "01262132489", false, "06518c8e-0bac-4c67-8499-8d42678df44d", false, "Halsi.Kolthouma5c7@example.com" },
                    { "4097d8f5-ed6b-11ed-aca2-105badc84798", 0, "b498d86f-39fa-4d41-b057-8b5ba21fbd19", "Mahmoud.Wael9d18@example.com", true, "Mahmoud", "Wael9d18", false, null, "MAHMOUD.WAEL9D18@EXAMPLE.COM", "MAHMOUD.WAEL9D18@EXAMPLE.COM", "AQAAAAEAACcQAAAAED/mx9X+OP6iuTwX9AeP4OfcoP4CJdw5dlJNvdBCqnuP4dIjjOekp8UI2OaO77QF2Q==", "01231638303", false, "5882e3b3-9177-4785-aa28-d4cf1bd4a661", false, "Mahmoud.Wael9d18@example.com" },
                    { "4097d8f7-ed6b-11ed-98e4-105badc84798", 0, "5cb24017-c782-4aea-a9c1-2309dedfc951", "Osama.Basem92cb@example.com", true, "Osama", "Basem92cb", false, null, "OSAMA.BASEM92CB@EXAMPLE.COM", "OSAMA.BASEM92CB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFDO0QeDxef238vlde8up3Ym1uxzNd8NoRrJ33K+PaKJLmVJtVVFC4ejAoxqZS7AJQ==", "01218566576", false, "a1ad3647-5a6e-4f5c-893e-366cf2162dd2", false, "Osama.Basem92cb@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4097d8f9-ed6b-11ed-8f23-105badc84798", 0, "c4307450-7658-4c17-8049-dc9da0bd6805", "Nahar.Shehabiac20@example.com", true, "Nahar", "Shehabiac20", false, null, "NAHAR.SHEHABIAC20@EXAMPLE.COM", "NAHAR.SHEHABIAC20@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBnYRBjI1PgGRF+TD39ZvPcB6TE1iPK/0Km4qSXNsqxcJYWw8QxTluoBiUWV9cJZTA==", "01241146819", false, "5d132ee9-ed28-488c-9cd5-60bbccf4a775", false, "Nahar.Shehabiac20@example.com" },
                    { "4097d8fb-ed6b-11ed-b285-105badc84798", 0, "2569e5c3-c3cc-41eb-a37b-74e7ab1bb24a", "Marawan.Zachariah8daa@example.com", true, "Marawan", "Zachariah8daa", false, null, "MARAWAN.ZACHARIAH8DAA@EXAMPLE.COM", "MARAWAN.ZACHARIAH8DAA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIP5NxYrE7OoY95nNXVvTUrsN+pXMY4Nyr3QmMZFKVYTuQUHeA3xuGKJkqKHIoVX9A==", "01292596275", false, "92b20332-5cca-4de3-89e3-6cae073938a1", false, "Marawan.Zachariah8daa@example.com" },
                    { "4097d8fd-ed6b-11ed-b6a3-105badc84798", 0, "f1f8b6f2-11bd-4d9b-b8e2-c3623d95085b", "Adham.Dagherb00d@example.com", true, "Adham", "Dagherb00d", false, null, "ADHAM.DAGHERB00D@EXAMPLE.COM", "ADHAM.DAGHERB00D@EXAMPLE.COM", "AQAAAAEAACcQAAAAENqM0auL1CLHpmNwwCkOmzvL7O97DVwS6IZuouYrqKB1xPlcRo/lB2m68/KhJFbLDw==", "01264741807", false, "be2dc283-6060-4dfc-8cd4-eb1536ba0215", false, "Adham.Dagherb00d@example.com" },
                    { "4097d8ff-ed6b-11ed-85f9-105badc84798", 0, "cf864ed9-2047-4144-aa6b-0e438062e52e", "Majid.Asami943b@example.com", true, "Majid", "Asami943b", false, null, "MAJID.ASAMI943B@EXAMPLE.COM", "MAJID.ASAMI943B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDsUexns6nSmAHLeN70NGj7daXNZ87Aw2fjGjGuBQPP6fOE688SjfmkiVPJFPCf5fw==", "01258015535", false, "9149952a-46a7-4704-938e-e698e0a9c28d", false, "Majid.Asami943b@example.com" },
                    { "4097d901-ed6b-11ed-9297-105badc84798", 0, "51a9b539-2872-4049-a90c-f0dd41b0061c", "Ghaith.Bahiracf6@example.com", true, "Ghaith", "Bahiracf6", false, null, "GHAITH.BAHIRACF6@EXAMPLE.COM", "GHAITH.BAHIRACF6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAscVh6DXJbFmn3ql9of4jBjl80nz4FD9xve2BXA+7wslz+WwOkl5yHSFZeUB4mfMQ==", "01232394458", false, "3592e2ee-bfaf-42d9-bf1a-77797ecdcdae", false, "Ghaith.Bahiracf6@example.com" },
                    { "4097d903-ed6b-11ed-855f-105badc84798", 0, "eeb344cc-766e-439a-b05d-d670bd554d4c", "Yunus.Zachariah8945@example.com", true, "Yunus", "Zachariah8945", false, null, "YUNUS.ZACHARIAH8945@EXAMPLE.COM", "YUNUS.ZACHARIAH8945@EXAMPLE.COM", "AQAAAAEAACcQAAAAEK13r+If+sS1547fGYyLLBXQk56NFFGYrXmRUC+sIKFEDTUemPEGlqmTMIK6bgMsvg==", "01288556434", false, "b4658f5d-e898-43e0-afca-b9262bf6d0be", false, "Yunus.Zachariah8945@example.com" },
                    { "4097d905-ed6b-11ed-b302-105badc84798", 0, "b84b4c54-f6c2-4ab0-b606-65bfbbc835e2", "Ramzy.Osamaafb5@example.com", true, "Ramzy", "Osamaafb5", false, null, "RAMZY.OSAMAAFB5@EXAMPLE.COM", "RAMZY.OSAMAAFB5@EXAMPLE.COM", "AQAAAAEAACcQAAAAENPYTGwCJqZLpEj20hkUA3MvWbT0PZweRhxI5bysA1n5k4CFt5zNboh9pC2/weVKNg==", "01272846023", false, "0e6e69ac-1d86-4da3-8789-3a892f0ee0da", false, "Ramzy.Osamaafb5@example.com" },
                    { "4097d907-ed6b-11ed-b6b6-105badc84798", 0, "30329792-1ac2-4ed4-86ab-9b53d894c069", "Bahi.Yisrib844@example.com", true, "Bahi", "Yisrib844", false, null, "BAHI.YISRIB844@EXAMPLE.COM", "BAHI.YISRIB844@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKhmeS5Gh2QKZA2ouI7nbzPRCSxn31LKQVysX9wYOu4Pn7lV5L1ZlS/55JEAsxV9JQ==", "01289220737", false, "43d10a5f-62ff-4f04-9040-88d8f3156f06", false, "Bahi.Yisrib844@example.com" },
                    { "4097d909-ed6b-11ed-93d8-105badc84798", 0, "a4744d2d-3370-4d3b-9fd2-2afe4bda05cf", "Sheikh.Kafar97f1@example.com", true, "Sheikh", "Kafar97f1", false, null, "SHEIKH.KAFAR97F1@EXAMPLE.COM", "SHEIKH.KAFAR97F1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPDU6fHEuEw9ZXUV6rHo7TO4spM7f4dHWw1sYS3/aJF6JDVHCJTqWWf+R8QeoZSpEA==", "01228387515", false, "cc50bff4-17dd-45f2-a2af-085b78de7f28", false, "Sheikh.Kafar97f1@example.com" },
                    { "4097d90b-ed6b-11ed-a99b-105badc84798", 0, "6c8ca6c4-c1b6-400b-b943-62cd229673d0", "Fares.Hassanbdf6@example.com", true, "Fares", "Hassanbdf6", false, null, "FARES.HASSANBDF6@EXAMPLE.COM", "FARES.HASSANBDF6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEO+fkqSfT+aa3oZHYhtbzjvdCb+Y2qDl566jaMFXA8ZOhA7no4cwpkt/21xAH/H2fA==", "01278694578", false, "a07c4eb4-aa8a-49f8-9092-5121ccafbf1c", false, "Fares.Hassanbdf6@example.com" },
                    { "4097d90d-ed6b-11ed-956f-105badc84798", 0, "35620e1f-0fa8-43d6-beaa-e2401d0c1b93", "Samir.Sheila8b49@example.com", true, "Samir", "Sheila8b49", false, null, "SAMIR.SHEILA8B49@EXAMPLE.COM", "SAMIR.SHEILA8B49@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJLodKFUds1Pz/l1dmpj/y2MWKs5L63ERE906RgoAxdBbPRqytUosLBuqrEBI2ttjA==", "01214800867", false, "745a7f79-69ee-49b3-a31b-e4d2df4e2b6b", false, "Samir.Sheila8b49@example.com" },
                    { "4097d90f-ed6b-11ed-a0cc-105badc84798", 0, "4c480f32-eb4b-4c2d-bab5-2104bc3efa94", "Yakon.Adhamaaa9@example.com", true, "Yakon", "Adhamaaa9", false, null, "YAKON.ADHAMAAA9@EXAMPLE.COM", "YAKON.ADHAMAAA9@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMrrNzg3RiZvdgO5rBZ1tvF85GFmoDSSwI2s9MZhdrALoZcIJX5RYb7ssBGzOgtXsQ==", "01299862932", false, "6147d0b6-3289-471c-a36d-4e011026d94d", false, "Yakon.Adhamaaa9@example.com" },
                    { "4097d911-ed6b-11ed-b614-105badc84798", 0, "fdea8664-8409-4515-9634-cd0f8c1da187", "Fidaa.Sameha430@example.com", true, "Fidaa", "Sameha430", false, null, "FIDAA.SAMEHA430@EXAMPLE.COM", "FIDAA.SAMEHA430@EXAMPLE.COM", "AQAAAAEAACcQAAAAEC5YaTCYfjYegYpslturFqD8Pc8HIn+0WDt29JFlkAtev2MQ7ud3Hb5sMcf0LGyyKA==", "01283485131", false, "c31eead7-1f89-40e6-a935-e5c14d25a9bd", false, "Fidaa.Sameha430@example.com" },
                    { "4097d913-ed6b-11ed-816e-105badc84798", 0, "37c5ed0d-8166-4e34-b386-217a584b3668", "Yusuf.Baqi8945@example.com", true, "Yusuf", "Baqi8945", false, null, "YUSUF.BAQI8945@EXAMPLE.COM", "YUSUF.BAQI8945@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAg4YlqbM860cvmuaj5CuA67aENaCJD7rm7Asddmhnet/UlX38mUZvCSvYzLiJrGOw==", "01235586777", false, "75389797-5b9a-4f68-8ddb-2220fa5fd8a6", false, "Yusuf.Baqi8945@example.com" },
                    { "4097d915-ed6b-11ed-a890-105badc84798", 0, "71f5189b-955f-44f7-94fd-4024bfb7b229", "Kahter.Minali8e83@example.com", true, "Kahter", "Minali8e83", false, null, "KAHTER.MINALI8E83@EXAMPLE.COM", "KAHTER.MINALI8E83@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIgvJ/N5qEHUVPB/IEtbYN4tHjw4F08hwtw3HUcH9YhmY7ycJGFuoULk12CesEF4FA==", "01237394610", false, "ea79bb2a-fe41-4af0-996d-a4ce33cf8c97", false, "Kahter.Minali8e83@example.com" },
                    { "4098b15b-ed6b-11ed-9dc2-105badc84798", 0, "63bec4f2-43df-4936-8cac-3d9113404dab", "Hamaki.Waela1d0@example.com", true, "Hamaki", "Waela1d0", false, null, "HAMAKI.WAELA1D0@EXAMPLE.COM", "HAMAKI.WAELA1D0@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGuCUXzoMJ+R5WrkX14dTuFUp5ur3x0UWktrIxLmYPBlS6yua40qD8qAGcQglqMMXw==", "01216731361", false, "7aa71244-4d8d-4ac2-b128-dcc74484242d", false, "Hamaki.Waela1d0@example.com" },
                    { "4098b15d-ed6b-11ed-8903-105badc84798", 0, "07947433-515e-4641-838c-fe977c13fd18", "Samhi.Ahmed8548@example.com", true, "Samhi", "Ahmed8548", false, null, "SAMHI.AHMED8548@EXAMPLE.COM", "SAMHI.AHMED8548@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHvWI/zCVRgZMpA4Wfgju6WoJTDPmgEoOSsDawfTnEgjTdxkALVMoKyHFR8hUqooUw==", "01295806415", false, "c5628089-6bbe-409c-96a0-2c5c61a6721b", false, "Samhi.Ahmed8548@example.com" },
                    { "4098b15f-ed6b-11ed-a7e2-105badc84798", 0, "05c01bcd-c6bd-427e-a0f2-cc4b7e8dcaa5", "Hishami.Dagherbd70@example.com", true, "Hishami", "Dagherbd70", false, null, "HISHAMI.DAGHERBD70@EXAMPLE.COM", "HISHAMI.DAGHERBD70@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPjq+eFU4Cf0yoHcDmCf0E7Nyd9ykoIuoEFgUhguHsbf1XZRVcRCdzYdukNTfmFYEw==", "01216081772", false, "e9d0614c-1b30-4089-92e7-ddafafb61992", false, "Hishami.Dagherbd70@example.com" },
                    { "4098b161-ed6b-11ed-b0d0-105badc84798", 0, "05a3c1d8-d802-4d66-af4d-b1460ddbfaa6", "Minali.Haor85f2@example.com", true, "Minali", "Haor85f2", false, null, "MINALI.HAOR85F2@EXAMPLE.COM", "MINALI.HAOR85F2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEj60e6bPQKyo27p7YjWKzZv17eO+hc9d1gmgTZXDLevcxXphulcCDeOmKmo/I4NTg==", "01264213362", false, "f568415d-bca0-4794-b609-54f7c2a85ce2", false, "Minali.Haor85f2@example.com" },
                    { "4098b163-ed6b-11ed-b901-105badc84798", 0, "9843435c-383c-4f30-9bc1-490414793297", "Bilal.Asimac85@example.com", true, "Bilal", "Asimac85", false, null, "BILAL.ASIMAC85@EXAMPLE.COM", "BILAL.ASIMAC85@EXAMPLE.COM", "AQAAAAEAACcQAAAAECwGqHVXcG7M8OjQTtiWzyT672KEcC1S5QrhNm81rzmNh2TLIj4rxsznVw7e7sjBeQ==", "01236247368", false, "c293368f-4707-4eee-a408-d8e820288daa", false, "Bilal.Asimac85@example.com" },
                    { "4098b165-ed6b-11ed-a2fd-105badc84798", 0, "6d71ec3f-b520-4fbd-aaf1-55cb7ef84a3b", "Kamel.Waseemb3f8@example.com", true, "Kamel", "Waseemb3f8", false, null, "KAMEL.WASEEMB3F8@EXAMPLE.COM", "KAMEL.WASEEMB3F8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKEikl5Mt9LrdpTgs03rAwI1xP7m1tLO4Z5Wv/LSgLmqJ4hg1wz/zr39JD4pX3nzYA==", "01227742375", false, "a15a42a3-ac4d-44ca-a02f-7cf1c2b232fb", false, "Kamel.Waseemb3f8@example.com" },
                    { "4098b167-ed6b-11ed-9dcf-105badc84798", 0, "d4159e8e-03f7-4e56-b79a-e9f54df034f3", "Yamen.Hilalia185@example.com", true, "Yamen", "Hilalia185", false, null, "YAMEN.HILALIA185@EXAMPLE.COM", "YAMEN.HILALIA185@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFKxvSZdSm46qTHH/snHM1DBH+dX3x1Pg1ORvnLWCRt94Z4/D1PWNtn8rSzq6FHBfQ==", "01226708337", false, "cd8e65f2-1a21-4157-9ff2-63592cb318e2", false, "Yamen.Hilalia185@example.com" },
                    { "4098b169-ed6b-11ed-9b69-105badc84798", 0, "af4b9535-ed57-4609-9c7e-f147cc7ce379", "Sheila.Badri806c@example.com", true, "Sheila", "Badri806c", false, null, "SHEILA.BADRI806C@EXAMPLE.COM", "SHEILA.BADRI806C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJUp/MOtgjNgzabyZdoqMgSTFxlz8375gtdbIchPXsDfE4BpU4vgyukoYWU+XBPOkA==", "01250629461", false, "64f43811-2d06-4f23-9bbd-8c614c4eb1e0", false, "Sheila.Badri806c@example.com" },
                    { "4098b16b-ed6b-11ed-bc54-105badc84798", 0, "8bf2dde8-1d99-4ab2-8682-de49564be45b", "Bahi.Sharma930@example.com", true, "Bahi", "Sharma930", false, null, "BAHI.SHARMA930@EXAMPLE.COM", "BAHI.SHARMA930@EXAMPLE.COM", "AQAAAAEAACcQAAAAEL2gCDv6q+CW1HZtN91EhDBMw5FApcYk8/1PotM5ps8pqnVs5RDeEnhaGDRTGOigDw==", "01264225474", false, "7233ef6e-6a96-4ada-96e6-1db622622827", false, "Bahi.Sharma930@example.com" },
                    { "4098b16d-ed6b-11ed-abd9-105badc84798", 0, "cfca3c6b-2c5c-431c-b274-f39f2629ec06", "Hilal.Hilal9e6a@example.com", true, "Hilal", "Hilal9e6a", false, null, "HILAL.HILAL9E6A@EXAMPLE.COM", "HILAL.HILAL9E6A@EXAMPLE.COM", "AQAAAAEAACcQAAAAEP7b/Yo3nyuAqG5eN+klKOpFtCCLsWmQysMLOOv7KpSNHS/+jNe7EGzqql9mMMtCBQ==", "01280080449", false, "07a13232-5c41-4409-80d8-3861823547f0", false, "Hilal.Hilal9e6a@example.com" },
                    { "4098b16f-ed6b-11ed-ae81-105badc84798", 0, "6c1e563e-9191-4130-a009-e9a58a1e0c33", "Yisri.Saden9224@example.com", true, "Yisri", "Saden9224", false, null, "YISRI.SADEN9224@EXAMPLE.COM", "YISRI.SADEN9224@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPcfwGcZ5UaIl9D6EiAtl339aSjMYV8ZiM8H81i6X+9pcAP7GbUSRwX+gKoFz2Nm8Q==", "01266306998", false, "399f1d1b-f8a2-4f7d-b742-dcc991311a58", false, "Yisri.Saden9224@example.com" },
                    { "4098b171-ed6b-11ed-bd08-105badc84798", 0, "111b905c-4ab6-4b9d-9458-c23ff416679b", "Helsey.Samiraa00@example.com", true, "Helsey", "Samiraa00", false, null, "HELSEY.SAMIRAA00@EXAMPLE.COM", "HELSEY.SAMIRAA00@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHL5LzGGIjoQ6IBzrVsnrszbtGS1F0osMFczRjmYfYUbBfPVvIuiwu1bFJ2uFlYIdQ==", "01217458085", false, "d5fd9751-1445-4ecf-841a-2c9cf4f019fb", false, "Helsey.Samiraa00@example.com" },
                    { "4098b173-ed6b-11ed-9e0c-105badc84798", 0, "99211f29-a4ad-4a85-8abe-5c7e2b806dd3", "Wael.Waseembb41@example.com", true, "Wael", "Waseembb41", false, null, "WAEL.WASEEMBB41@EXAMPLE.COM", "WAEL.WASEEMBB41@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEW63dwD91OALsVhddul08aNrFwryygZFDKd2yNkBWv0T04i0Vz7W53aWJnOGr5//Q==", "01284333280", false, "ff678a14-3ca1-4a83-bb6a-e273a5c0f578", false, "Wael.Waseembb41@example.com" },
                    { "4098b175-ed6b-11ed-a3d4-105badc84798", 0, "f25bf38c-ec27-4e78-94b1-e352959849bf", "Najm.Bahirbab8@example.com", true, "Najm", "Bahirbab8", false, null, "NAJM.BAHIRBAB8@EXAMPLE.COM", "NAJM.BAHIRBAB8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEG2zC6fsCyTtVaSgbMCDklNpSjrH4UkqlTiglJ7yCuKhwta8M9UL12mzoJHNx0zz/A==", "01287732484", false, "f05dee80-e22c-487b-9196-2daec488a65d", false, "Najm.Bahirbab8@example.com" },
                    { "4098b177-ed6b-11ed-b8db-105badc84798", 0, "1df11228-d1d9-49f7-b0c3-fb5cf8f4247b", "Dahi.Adelbabc@example.com", true, "Dahi", "Adelbabc", false, null, "DAHI.ADELBABC@EXAMPLE.COM", "DAHI.ADELBABC@EXAMPLE.COM", "AQAAAAEAACcQAAAAEK+dktv3C/zjF/m9cGANqAqB/doB9GbL2Rz27rwlRzSh4rLIKz0p4b7iOPOt7IQGoQ==", "01214965124", false, "9ec9b0af-1647-40b9-b58d-76c11641fe13", false, "Dahi.Adelbabc@example.com" },
                    { "4098b179-ed6b-11ed-acd6-105badc84798", 0, "d714388b-1a8c-49ea-a307-50c22d1d66ee", "Sajid.Majdibec5@example.com", true, "Sajid", "Majdibec5", false, null, "SAJID.MAJDIBEC5@EXAMPLE.COM", "SAJID.MAJDIBEC5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFlLCwOXER11ievTqoH5p89xLMGDb1aWCHzCRBGIomdRizvZ56T8As1nKQWsoZQgYA==", "01226566171", false, "c797101f-e5c5-4ea6-95bc-11f73c031ad5", false, "Sajid.Majdibec5@example.com" },
                    { "4098b17b-ed6b-11ed-bfb2-105badc84798", 0, "4e131d72-e48c-4b4e-9df7-114bec01c0e4", "Salim.Waseem9d1b@example.com", true, "Salim", "Waseem9d1b", false, null, "SALIM.WASEEM9D1B@EXAMPLE.COM", "SALIM.WASEEM9D1B@EXAMPLE.COM", "AQAAAAEAACcQAAAAELm4ygT2HfvmQaoNKWTsKNZJJouDQS3pAQm0nsbIwSYoRVr6kerqae6jqiasNnWpwg==", "01223503517", false, "e490fbe0-fb08-4ad4-834d-03b4970bde3f", false, "Salim.Waseem9d1b@example.com" },
                    { "4098b17d-ed6b-11ed-a36b-105badc84798", 0, "47fd619b-d8ac-40d6-a633-1f83170a46f8", "Baqi.Zaki9e26@example.com", true, "Baqi", "Zaki9e26", false, null, "BAQI.ZAKI9E26@EXAMPLE.COM", "BAQI.ZAKI9E26@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOggzRMve82QyOllR6m7rNCZM7ed8cp8RlDuvU5Wf76P+VgSjW+X5BBueICOJaUG+w==", "01295728341", false, "abf02272-8efc-4a37-937a-975ba4e9ac61", false, "Baqi.Zaki9e26@example.com" },
                    { "4098b17f-ed6b-11ed-9639-105badc84798", 0, "0e083e6f-4c02-4656-b495-d0a8f189d41a", "Sahami.Sheikhy80fb@example.com", true, "Sahami", "Sheikhy80fb", false, null, "SAHAMI.SHEIKHY80FB@EXAMPLE.COM", "SAHAMI.SHEIKHY80FB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKGJhduLv3++H6TsoNhtzk6dXynzm2Z0p7VcdOdkB8rIkNbA2Sgjxrm/gqSFL11LKA==", "01269675036", false, "175cb3b7-6a03-4a20-8f70-a08c953acb53", false, "Sahami.Sheikhy80fb@example.com" },
                    { "4098b181-ed6b-11ed-84ef-105badc84798", 0, "fc46d592-e140-44f4-9cd7-94789def86ad", "Badri.Sareea3a3@example.com", true, "Badri", "Sareea3a3", false, null, "BADRI.SAREEA3A3@EXAMPLE.COM", "BADRI.SAREEA3A3@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFMWARX2dAcysPMnuL8OS2Ao46jLai6BMQNgWPwMDKek4olYXeq3TaBHMsATFWoX9w==", "01260728699", false, "582d44cc-1ccc-4201-96e3-dc199c32e68f", false, "Badri.Sareea3a3@example.com" },
                    { "4098b183-ed6b-11ed-91ba-105badc84798", 0, "d31bd2e3-9677-44c5-a3e8-e4f673123479", "Faisal.Ryan93db@example.com", true, "Faisal", "Ryan93db", false, null, "FAISAL.RYAN93DB@EXAMPLE.COM", "FAISAL.RYAN93DB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEc0Y3erB08mAznM7RsWzyJpWjVUWLemODu65B4BBfQAUZI4AB592aURKT7fnMPQyQ==", "01215094196", false, "259a964f-b247-47e2-b43a-6e35e4646b83", false, "Faisal.Ryan93db@example.com" },
                    { "4098b185-ed6b-11ed-a00a-105badc84798", 0, "72e91c38-5596-4dd0-98ca-e9d4365f49b6", "Omar.Sahami9f51@example.com", true, "Omar", "Sahami9f51", false, null, "OMAR.SAHAMI9F51@EXAMPLE.COM", "OMAR.SAHAMI9F51@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHjjXHia5KyFScxJ4+vkwJH6dyv6O7qDlxoCTPBFWNz1JWafx10VDaYe0+Dcwqa/gQ==", "01271704961", false, "48361a60-f15b-4bbc-b96f-2b1f657d5fd7", false, "Omar.Sahami9f51@example.com" },
                    { "4098b187-ed6b-11ed-911e-105badc84798", 0, "80ddbb3c-5354-4476-b13c-5a34fd6c3843", "Loay.Basem8ee7@example.com", true, "Loay", "Basem8ee7", false, null, "LOAY.BASEM8EE7@EXAMPLE.COM", "LOAY.BASEM8EE7@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPxoKe1LZnyAvGQcr3oGwaPsQNmQ2otVd/zXpkXU/zPgltfzmsdJv2C15iQNMisOTQ==", "01253444230", false, "4dd12280-4733-47d2-b0b8-2821cb676d21", false, "Loay.Basem8ee7@example.com" },
                    { "4098b189-ed6b-11ed-97ff-105badc84798", 0, "e9ad1769-ce85-4843-88d8-612dc5a31808", "Halsi.Ryana491@example.com", true, "Halsi", "Ryana491", false, null, "HALSI.RYANA491@EXAMPLE.COM", "HALSI.RYANA491@EXAMPLE.COM", "AQAAAAEAACcQAAAAENssz/qh3WtFCFIy4JiLuUEAvkSGzxiEmc1VHaaADSFEZFzMNswt++ozPR+A9q1MHg==", "01243084731", false, "76776fb6-9446-42b9-860d-ceb5625e9d0a", false, "Halsi.Ryana491@example.com" },
                    { "4098b18b-ed6b-11ed-9c96-105badc84798", 0, "1a94e59c-01b2-4c6c-a795-4a2e2232edc9", "Noah.Waela26a@example.com", true, "Noah", "Waela26a", false, null, "NOAH.WAELA26A@EXAMPLE.COM", "NOAH.WAELA26A@EXAMPLE.COM", "AQAAAAEAACcQAAAAEO4USdpG3NBi4YlJ0GdbtTyBs/O1cJZLVHEsO9Hx4MMACuiZtGaZ37c3S9OAs949SQ==", "01265189792", false, "5c0d2b82-0451-4327-aee1-b971d20053e1", false, "Noah.Waela26a@example.com" },
                    { "4098b18d-ed6b-11ed-86a0-105badc84798", 0, "bd5e8931-ac6f-4a98-8855-118faaa156a4", "Malek.Minalia6b0@example.com", true, "Malek", "Minalia6b0", false, null, "MALEK.MINALIA6B0@EXAMPLE.COM", "MALEK.MINALIA6B0@EXAMPLE.COM", "AQAAAAEAACcQAAAAEALmsamDEyUohslO0eVSQli8LtVkv/aC7SqndUslRqNywkPpnplb8COW6t4KLkn2UA==", "01272439716", false, "8bcb2328-3a5c-42d7-8508-7c751b91e6f1", false, "Malek.Minalia6b0@example.com" },
                    { "4098b18f-ed6b-11ed-9b38-105badc84798", 0, "0786fde6-7d3e-4d26-84bc-5aed39d258a0", "Kahter.Sharmaf90@example.com", true, "Kahter", "Sharmaf90", false, null, "KAHTER.SHARMAF90@EXAMPLE.COM", "KAHTER.SHARMAF90@EXAMPLE.COM", "AQAAAAEAACcQAAAAENNSsuM/JEadDo2OaypxYSZ3GRvcL2M9WP0W26TbHxIO28ts30XNo91WL3IBoJnRaQ==", "01297951939", false, "c8872989-0ed4-482d-8c7e-9d9cab01b8d7", false, "Kahter.Sharmaf90@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4098b191-ed6b-11ed-87ba-105badc84798", 0, "307bf23d-33fb-4ca7-8355-6e54540f18ed", "Sajid.Zachariah82c1@example.com", true, "Sajid", "Zachariah82c1", false, null, "SAJID.ZACHARIAH82C1@EXAMPLE.COM", "SAJID.ZACHARIAH82C1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEL9DSC98Wyj5gnNruIAiIhSGoWXoyNVki+9tyB+Kf33Qb6fJkpp+xv8mKxCUxV7ctg==", "01218467982", false, "5a187a40-fe2c-464d-81d0-315565795a69", false, "Sajid.Zachariah82c1@example.com" },
                    { "4098b193-ed6b-11ed-b6af-105badc84798", 0, "567612e1-1f37-41e6-b180-70ce34c1b607", "Dahi.Danielad4c@example.com", true, "Dahi", "Danielad4c", false, null, "DAHI.DANIELAD4C@EXAMPLE.COM", "DAHI.DANIELAD4C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEASfGRexumAdGUAZpRmReZ8ULpDWD39Uyuhq0J85W2jdIGCz5owaG6vXVVO5wkWbfg==", "01214991654", false, "a03dfaea-de95-48a4-aaa2-07744175ed13", false, "Dahi.Danielad4c@example.com" },
                    { "4098b195-ed6b-11ed-a317-105badc84798", 0, "cc00d7b2-a271-4401-b994-4fbe7759d5e8", "Ahmed.Samehbda8@example.com", true, "Ahmed", "Samehbda8", false, null, "AHMED.SAMEHBDA8@EXAMPLE.COM", "AHMED.SAMEHBDA8@EXAMPLE.COM", "AQAAAAEAACcQAAAAENIDiU9xbVUEwW6ZaFzH9bLkJr4feGd2/4qVx4WYqCwP0mY1XQsGjM5RtV3abcubMg==", "01214023531", false, "c3bbf1ef-373a-40b7-98b1-178603e10050", false, "Ahmed.Samehbda8@example.com" },
                    { "4098b197-ed6b-11ed-a380-105badc84798", 0, "32cfbab1-41d5-4fc2-89b0-76b20f532952", "Hamaki.Salimb1fa@example.com", true, "Hamaki", "Salimb1fa", false, null, "HAMAKI.SALIMB1FA@EXAMPLE.COM", "HAMAKI.SALIMB1FA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFT/rp9GQTdlHGXV+HI6hZMNUBEzi0lAmTNrSa5+2N3lq3ahjeb2HFZwPC1HpW8qPA==", "01237177143", false, "9a9a32ba-b72b-4f19-8c17-ac420b0aa789", false, "Hamaki.Salimb1fa@example.com" },
                    { "4098b199-ed6b-11ed-bf11-105badc84798", 0, "bc06379d-0ca1-48e9-8afa-d9f5dcae2e2b", "Latfi.Latfi8c51@example.com", true, "Latfi", "Latfi8c51", false, null, "LATFI.LATFI8C51@EXAMPLE.COM", "LATFI.LATFI8C51@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFdHy2di3hznZjAJXiQJ1qo1U9a6hatRJm7YmGGPzvf8pYNPl9CFx+rrTNgtJIAz9Q==", "01287157511", false, "e07340f8-abd5-4ce9-9c52-9988bf1c3830", false, "Latfi.Latfi8c51@example.com" },
                    { "4098b19b-ed6b-11ed-9acc-105badc84798", 0, "15801998-b8ce-445c-91f8-3f1d7ab588b4", "Fadi.Medhatbc78@example.com", true, "Fadi", "Medhatbc78", false, null, "FADI.MEDHATBC78@EXAMPLE.COM", "FADI.MEDHATBC78@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIP9xX/vG2TQSkRWcuyv3wJ40OFoIc4IRiB3sYf7NQqCUH69Ci80VrnnPPDyU7HjDg==", "01231139763", false, "c02cac9e-63a0-42fa-9fb7-87de8da284dd", false, "Fadi.Medhatbc78@example.com" },
                    { "4098b19d-ed6b-11ed-9edb-105badc84798", 0, "21ad0300-bb3a-4e14-9cd9-14df5ae5d21d", "Fahed.Minali85eb@example.com", true, "Fahed", "Minali85eb", false, null, "FAHED.MINALI85EB@EXAMPLE.COM", "FAHED.MINALI85EB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEITtcasnYdL2+9Xc/aP3+VvaGh8gQ3rIihRdK60641L4DKyXU2uBOhwjbdzUEqWSAA==", "01256275160", false, "2a9b2631-2533-4474-be50-5a3fcc6861b1", false, "Fahed.Minali85eb@example.com" },
                    { "4098b19f-ed6b-11ed-8419-105badc84798", 0, "ea563e13-8c13-4bd0-95ef-f1d93a03f612", "Wael.Zachariahb0c2@example.com", true, "Wael", "Zachariahb0c2", false, null, "WAEL.ZACHARIAHB0C2@EXAMPLE.COM", "WAEL.ZACHARIAHB0C2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBdtdiB/uAg+q007TEkg9MWJLT5rKelvu8qvN4/f6hCWer3aexbZqCSauyCVJAmObQ==", "01218944525", false, "2030f828-9de3-4003-9b59-289effbbda0f", false, "Wael.Zachariahb0c2@example.com" },
                    { "4098b1a1-ed6b-11ed-abac-105badc84798", 0, "75f6e4f9-db86-4585-803b-cdd736fc2ae6", "Zarif.Bahi9d47@example.com", true, "Zarif", "Bahi9d47", false, null, "ZARIF.BAHI9D47@EXAMPLE.COM", "ZARIF.BAHI9D47@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFWNt5KSvlJX7w/uEAgoflxJzkuNy+t9W7rCDWd2adGnsDYxLkLrVXzxkUHbBSQ3EQ==", "01283196507", false, "41cb44d7-8811-4b02-a6a0-f7fbac3132cf", false, "Zarif.Bahi9d47@example.com" },
                    { "4098b1a3-ed6b-11ed-a583-105badc84798", 0, "88a4d076-9ae5-4c5a-a20b-b2725b1a315a", "Bara.Bahia873@example.com", true, "Bara", "Bahia873", false, null, "BARA.BAHIA873@EXAMPLE.COM", "BARA.BAHIA873@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBwH/HaJCdfERoVr6P/XxeLCzYtAsV4UHnoc6ASFpTiXxvJ9lt52lbe13htUOb1mzA==", "01234054165", false, "9b34dde2-104d-46d3-8d0d-24a73d71fa45", false, "Bara.Bahia873@example.com" },
                    { "4098b1a5-ed6b-11ed-bf0d-105badc84798", 0, "307bf572-bc48-4e01-9cc5-9539a120958f", "Hamaqy.Noorad52@example.com", true, "Hamaqy", "Noorad52", false, null, "HAMAQY.NOORAD52@EXAMPLE.COM", "HAMAQY.NOORAD52@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOWvFt1GWcMNy3EdjJLuxgORlhRNVdGvVOzEtx0c+prk0rBvyMbpUVozD9Uzhh3Kpw==", "01249013827", false, "1307c895-fbdd-4592-a5f6-8ab3f440c09a", false, "Hamaqy.Noorad52@example.com" },
                    { "4098b1a7-ed6b-11ed-bd68-105badc84798", 0, "4d5a0310-00a1-4cd7-9bf2-8eb27a050a67", "Fares.Bahirb03c@example.com", true, "Fares", "Bahirb03c", false, null, "FARES.BAHIRB03C@EXAMPLE.COM", "FARES.BAHIRB03C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHZqOZnoV/geoSJ4Uoq8gdGgBJLPbsBFQ6WjgOeNbA5c/Y3d3JOChPm472fsIvYf0A==", "01245035379", false, "16ad75c9-a0cd-42d2-abd0-7d7494dd1c0f", false, "Fares.Bahirb03c@example.com" },
                    { "4099e9d3-ed6b-11ed-b4e8-105badc84798", 0, "8d33ab10-7939-41b3-94fb-b4b15129fbbe", "Jalal.Majid82af@example.com", true, "Jalal", "Majid82af", false, null, "JALAL.MAJID82AF@EXAMPLE.COM", "JALAL.MAJID82AF@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKmpLQzBN7/1z7CiLdXRGnsQ8hr/gcfruuJHvuOYJ3y16RDgpWsfH4V2bcycKYgLew==", "01292058402", false, "d1cd82a4-f5cf-472d-907b-2f696e8a75da", false, "Jalal.Majid82af@example.com" },
                    { "4099e9d5-ed6b-11ed-8061-105badc84798", 0, "e31c544b-7c97-4f8d-9443-eca4ffefdfcd", "Saden.Waelb102@example.com", true, "Saden", "Waelb102", false, null, "SADEN.WAELB102@EXAMPLE.COM", "SADEN.WAELB102@EXAMPLE.COM", "AQAAAAEAACcQAAAAEC6m8dkjK0zRY1wNVqpwE5kvOLjFGo5oTEh2M4Qz8F9i4j2/wnJ+qLXJoS1/CGLmxQ==", "01227228988", false, "eb8c6a6c-1b6f-4ae5-8607-10bc26a12fe0", false, "Saden.Waelb102@example.com" },
                    { "4099e9d7-ed6b-11ed-976d-105badc84798", 0, "44f0b3b6-a590-4eae-bded-c82e6a08ef87", "Dahi.Sajid849e@example.com", true, "Dahi", "Sajid849e", false, null, "DAHI.SAJID849E@EXAMPLE.COM", "DAHI.SAJID849E@EXAMPLE.COM", "AQAAAAEAACcQAAAAEB0tcsh7WqXTliOt9ZOlWOCfEM2sTXpZg6Xd/84IErUT/vF/j5MbZNlRvB5Magtu3g==", "01263561273", false, "0933f67c-05ac-41bc-9199-78ce17e79885", false, "Dahi.Sajid849e@example.com" },
                    { "4099e9d9-ed6b-11ed-bca8-105badc84798", 0, "da1141a0-f029-45f0-ab1b-5a9f569b8a5c", "Adel.Hilalab94@example.com", true, "Adel", "Hilalab94", false, null, "ADEL.HILALAB94@EXAMPLE.COM", "ADEL.HILALAB94@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAHpyW4Ck/+WjaG6mz2FeCJiolzKv0M8LG7Rd56eNpGKZCeVUDa5vrgOhWeOOpcDjg==", "01275990302", false, "74cdec5d-b927-45d0-a30b-769323888c7a", false, "Adel.Hilalab94@example.com" },
                    { "4099e9db-ed6b-11ed-9009-105badc84798", 0, "faa357d0-e1a7-43ba-8b79-d4b0269a54e2", "Samir.Bassam897e@example.com", true, "Samir", "Bassam897e", false, null, "SAMIR.BASSAM897E@EXAMPLE.COM", "SAMIR.BASSAM897E@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPvq5b03WavOl24MsFSN9TimEJCDZrFBi+HB4Gsyj8AO4zdVXngTSvZJtGqiRg/1aA==", "01234422680", false, "d756b49c-0a2e-4168-8e61-f170d5edb289", false, "Samir.Bassam897e@example.com" },
                    { "4099e9dd-ed6b-11ed-8e81-105badc84798", 0, "0850b132-06a7-4b8d-9e24-97609b619723", "Sajid.Sheikha8b1@example.com", true, "Sajid", "Sheikha8b1", false, null, "SAJID.SHEIKHA8B1@EXAMPLE.COM", "SAJID.SHEIKHA8B1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEK6tax5JBubMNvqNAIuX7GMyc+McDyAWr+k2II4VvVwcYXxeBr+ieGoF3zWVXeTW/Q==", "01210144261", false, "5d4cfb75-5246-4e34-a5e8-6c952bca3e14", false, "Sajid.Sheikha8b1@example.com" },
                    { "4099e9df-ed6b-11ed-bb40-105badc84798", 0, "d5261035-f157-49e8-a315-8d8c0a48b7e1", "Russell.Ghanem9478@example.com", true, "Russell", "Ghanem9478", false, null, "RUSSELL.GHANEM9478@EXAMPLE.COM", "RUSSELL.GHANEM9478@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIiWa8YCWDbgei1ynhZgY6MS9ks4ByBCYkY6It1qkrEn8yQXGzIPsl95bdiREyuFyA==", "01290670217", false, "bdb02421-631e-4e1e-81b9-df81229266d4", false, "Russell.Ghanem9478@example.com" },
                    { "4099e9e1-ed6b-11ed-b492-105badc84798", 0, "aaa9f875-ba17-40ae-9966-07a4359f1e90", "Haor.Wael82ce@example.com", true, "Haor", "Wael82ce", false, null, "HAOR.WAEL82CE@EXAMPLE.COM", "HAOR.WAEL82CE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGyG9z+yLX2+c8vjDhJawUEt3amjM8b7bQhM/RMrDvrqVMco+DkeHvCaUiHdzXwisw==", "01255444010", false, "5bd68897-2488-467a-9d43-809e1a25c069", false, "Haor.Wael82ce@example.com" },
                    { "4099e9e3-ed6b-11ed-92d1-105badc84798", 0, "5aa41123-25e8-4247-97e6-e9b1148e477e", "Dagher.Zachariahb6b1@example.com", true, "Dagher", "Zachariahb6b1", false, null, "DAGHER.ZACHARIAHB6B1@EXAMPLE.COM", "DAGHER.ZACHARIAHB6B1@EXAMPLE.COM", "AQAAAAEAACcQAAAAECrYvi/2/VF6UU9DfEL8i8cbzJgEz9eB07SlUSiNY2MLbfsDSlBM4/MyY9qNmGoqXA==", "01224788521", false, "12a8673c-00e2-4db6-810a-5be0f9b473ee", false, "Dagher.Zachariahb6b1@example.com" },
                    { "4099e9e5-ed6b-11ed-b38a-105badc84798", 0, "82598ceb-0c18-4b87-ba48-1fda618325a4", "Hishami.Halsib62b@example.com", true, "Hishami", "Halsib62b", false, null, "HISHAMI.HALSIB62B@EXAMPLE.COM", "HISHAMI.HALSIB62B@EXAMPLE.COM", "AQAAAAEAACcQAAAAENDDrqszeIagxTh9zN7QiE7RHnWpZVakl8hMqQ4p9MenDHUH4k0nQE/riWWskyC9FQ==", "01237896983", false, "62057961-1648-4e60-a8d7-47b24af8dffc", false, "Hishami.Halsib62b@example.com" },
                    { "4099e9e7-ed6b-11ed-9432-105badc84798", 0, "a25f5375-1b4e-471d-9822-15b031ac48e8", "Marawan.Shahib1ef@example.com", true, "Marawan", "Shahib1ef", false, null, "MARAWAN.SHAHIB1EF@EXAMPLE.COM", "MARAWAN.SHAHIB1EF@EXAMPLE.COM", "AQAAAAEAACcQAAAAEE5Z7ttPnKhtCyYa+IznawUUNcISreD0vFtbufR/ANHP/wAOxZBn6sDijjZxbL+NFQ==", "01271273824", false, "54039706-736e-40ff-b8f9-607a9abb0d20", false, "Marawan.Shahib1ef@example.com" },
                    { "4099e9e9-ed6b-11ed-af1e-105badc84798", 0, "414e3f53-0c45-4997-a184-a8d2e41d02ec", "Fidaa.Baqia533@example.com", true, "Fidaa", "Baqia533", false, null, "FIDAA.BAQIA533@EXAMPLE.COM", "FIDAA.BAQIA533@EXAMPLE.COM", "AQAAAAEAACcQAAAAEORUE+3yJYVij8JP87PdMLgYEQgGsOudaSdNFXoGgXhtT3FjH36+O5BingB4pw7iJQ==", "01218117934", false, "e1e3a5d2-f1bf-41c9-87e1-8ceba31bc63a", false, "Fidaa.Baqia533@example.com" },
                    { "4099e9eb-ed6b-11ed-8d45-105badc84798", 0, "3e610a29-24cf-4bc7-88dc-f6e42ee2ea16", "Radwan.Kamel90c3@example.com", true, "Radwan", "Kamel90c3", false, null, "RADWAN.KAMEL90C3@EXAMPLE.COM", "RADWAN.KAMEL90C3@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKj2x8RxU4x3onU4jD+4Pm5u4Z2jtEZ3ulqrrS0Uyfu4/8wpnb1giNB9++ZKoOI3HA==", "01262457869", false, "22281b67-82eb-4b2b-b3dd-2285d569f022", false, "Radwan.Kamel90c3@example.com" },
                    { "4099e9ed-ed6b-11ed-8755-105badc84798", 0, "a8406771-b1db-4bb6-9653-aa6d04d5eb54", "Loay.Bahi9d3c@example.com", true, "Loay", "Bahi9d3c", false, null, "LOAY.BAHI9D3C@EXAMPLE.COM", "LOAY.BAHI9D3C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHKdUvTlR6fM1H2sP1pTZwAIfYArvphpbTSNK/vDFsCQ7Rt3CPbo9zm1JX9yYbPuKg==", "01298984959", false, "818bf188-0b55-43af-83de-91c9a1d834e8", false, "Loay.Bahi9d3c@example.com" },
                    { "4099e9ef-ed6b-11ed-a4a1-105badc84798", 0, "567c30b7-d100-4450-8038-aa1f09ab3d80", "Ryan.Moses82e6@example.com", true, "Ryan", "Moses82e6", false, null, "RYAN.MOSES82E6@EXAMPLE.COM", "RYAN.MOSES82E6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHdLdEWfT0MAn+brsHvnbm6UlZWFlrVTHOzi0+FTpfEAAUsGpCBdHhFXIVPjs34LsA==", "01287007236", false, "c946943c-0290-4b01-9a51-028cb74d8d12", false, "Ryan.Moses82e6@example.com" },
                    { "4099e9f1-ed6b-11ed-b017-105badc84798", 0, "37088a6c-fbf2-44a5-abbc-0881d1de25bf", "Fahed.Hishamia1b1@example.com", true, "Fahed", "Hishamia1b1", false, null, "FAHED.HISHAMIA1B1@EXAMPLE.COM", "FAHED.HISHAMIA1B1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOx7X67s9qOBh0wWBOIf24Vwybb7gQkCyGuhHXHCwqYenMIaimzdwvUPvpewFPJFQQ==", "01295741865", false, "1ed48171-e28d-4181-b784-74a00a7d795d", false, "Fahed.Hishamia1b1@example.com" },
                    { "4099e9f3-ed6b-11ed-92c8-105badc84798", 0, "3ee917bb-9331-41ef-9eb3-3f7285ae1f9f", "Horr.Basselb860@example.com", true, "Horr", "Basselb860", false, null, "HORR.BASSELB860@EXAMPLE.COM", "HORR.BASSELB860@EXAMPLE.COM", "AQAAAAEAACcQAAAAED2H5qfYVnW4bUCwxHgCkipdR737ic/rBQUDMbaRnfJOxB2GKvOSca3VaM6/clplaA==", "01231479095", false, "401f3bf4-1005-406c-80fb-4206d133206d", false, "Horr.Basselb860@example.com" },
                    { "4099e9f5-ed6b-11ed-9bbb-105badc84798", 0, "4bfc7730-9c9d-4bb6-bde8-7bc17a361a79", "Asim.Bahia196@example.com", true, "Asim", "Bahia196", false, null, "ASIM.BAHIA196@EXAMPLE.COM", "ASIM.BAHIA196@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEwBgDTsWH99TtC0jA4MauSkMt+oW1THgwDJvHBrY5glxcOeoRzubRn0tToBfbL/eA==", "01293315685", false, "4bc15b9e-5394-4079-ab82-ddb6e78db16d", false, "Asim.Bahia196@example.com" },
                    { "4099e9f7-ed6b-11ed-aa9d-105badc84798", 0, "178f27ae-62d7-48fa-a06b-8026e679c1e3", "Bara.Shahib692@example.com", true, "Bara", "Shahib692", false, null, "BARA.SHAHIB692@EXAMPLE.COM", "BARA.SHAHIB692@EXAMPLE.COM", "AQAAAAEAACcQAAAAEA+Idt7gSii5o4KJycyNpBIWVVGO+APDDUScIKA431DAiKHWBuM1/0GUp1isyYH1Xw==", "01240292772", false, "c5ca0e0c-21eb-4a3b-8ba1-57164282f3e0", false, "Bara.Shahib692@example.com" },
                    { "4099e9f9-ed6b-11ed-8af4-105badc84798", 0, "f360227c-08fe-4abb-bf3b-07c7b8067d62", "Fadi.Adhama536@example.com", true, "Fadi", "Adhama536", false, null, "FADI.ADHAMA536@EXAMPLE.COM", "FADI.ADHAMA536@EXAMPLE.COM", "AQAAAAEAACcQAAAAECqRRDunyFYJk9HPa+FhDWU10RboIhTTLfibtSyQFm2Vp7ziZFzra9yPa8TFeU203A==", "01239956926", false, "0cfd4467-28ae-4fe3-afe9-241cfebcfcf4", false, "Fadi.Adhama536@example.com" },
                    { "4099e9fb-ed6b-11ed-88c6-105badc84798", 0, "ef22ef2e-8fda-44f6-aac0-046f32e8f903", "Medhat.Hammadbdb5@example.com", true, "Medhat", "Hammadbdb5", false, null, "MEDHAT.HAMMADBDB5@EXAMPLE.COM", "MEDHAT.HAMMADBDB5@EXAMPLE.COM", "AQAAAAEAACcQAAAAENJ1BQt8OrDs5jYfYCUpaauke73QJ4SnTIDgVlU7eiI4OGbWLQAY0FOedJ3igg4ToQ==", "01224361401", false, "2ca99f95-89ca-4b79-8ad4-9ed91efb0bb2", false, "Medhat.Hammadbdb5@example.com" },
                    { "4099e9fd-ed6b-11ed-a891-105badc84798", 0, "d7a25929-ef7d-4e37-8cdb-dfe6bdd141cf", "Najm.Shehabia8de@example.com", true, "Najm", "Shehabia8de", false, null, "NAJM.SHEHABIA8DE@EXAMPLE.COM", "NAJM.SHEHABIA8DE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDja6D2JgKx1w4e03NG3eVXqxITTEzvMKkvXeR/PrP2507pJZL2lQAeqEDNpjgOfnA==", "01264500973", false, "c0e7b223-05dc-419e-87d9-f4741bb2b330", false, "Najm.Shehabia8de@example.com" },
                    { "4099e9ff-ed6b-11ed-a802-105badc84798", 0, "0573e8e9-3e15-45c6-83d2-96c08999395a", "Hussein.Jalal89d8@example.com", true, "Hussein", "Jalal89d8", false, null, "HUSSEIN.JALAL89D8@EXAMPLE.COM", "HUSSEIN.JALAL89D8@EXAMPLE.COM", "AQAAAAEAACcQAAAAELVQJE60w5nxTkcvuQTMcHfuhOKZJ4ErrBSDrcj5c0z4TaWhfdvw8sbOYViwVHT75g==", "01243463663", false, "2125d35f-f2e8-4e3f-8e7a-2a2e7c70b78c", false, "Hussein.Jalal89d8@example.com" },
                    { "4099ea01-ed6b-11ed-a7d5-105badc84798", 0, "a1d83dde-51b1-4744-a9e3-ed91c45f389d", "Saden.Fares8d49@example.com", true, "Saden", "Fares8d49", false, null, "SADEN.FARES8D49@EXAMPLE.COM", "SADEN.FARES8D49@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPsj6tPD9aOMXHkpYEE3JUPlnKTY326rfM1c8Yb8y/Q6Shjn8UCIAsfIv0ihVl45SQ==", "01231665315", false, "b6467cd2-70b0-4fa5-ae2b-1976cf1fb6c3", false, "Saden.Fares8d49@example.com" },
                    { "4099ea03-ed6b-11ed-9ac8-105badc84798", 0, "dd77da69-1b8a-460a-9528-06b9e3e1ecd9", "Bahir.Najma6fb@example.com", true, "Bahir", "Najma6fb", false, null, "BAHIR.NAJMA6FB@EXAMPLE.COM", "BAHIR.NAJMA6FB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJf2P9B9F8jBTWbOuqfFOhFxffEl709XD4tDrOC4AauUWXH6v0vQewp0VdvogUYBcQ==", "01257564173", false, "b20fb582-03a2-4351-bf14-de0c5df9ca1c", false, "Bahir.Najma6fb@example.com" },
                    { "4099ea05-ed6b-11ed-b96b-105badc84798", 0, "1c44d9d0-a02a-4edc-8d59-23bdebc9d9c5", "Bahi.Fidaa88f9@example.com", true, "Bahi", "Fidaa88f9", false, null, "BAHI.FIDAA88F9@EXAMPLE.COM", "BAHI.FIDAA88F9@EXAMPLE.COM", "AQAAAAEAACcQAAAAEN1p0DFpG3z9pKeRE7M21mEOse0N8U/xBIySYYUf/VQJprRA9qmfYl7LNeQBGVJgUA==", "01244926851", false, "0103be9c-5418-4154-b471-6b796ecfe3ce", false, "Bahi.Fidaa88f9@example.com" },
                    { "4099ea07-ed6b-11ed-9c9b-105badc84798", 0, "a650b959-c241-43ed-aba5-7d90f638a66f", "Dahi.Waseembc12@example.com", true, "Dahi", "Waseembc12", false, null, "DAHI.WASEEMBC12@EXAMPLE.COM", "DAHI.WASEEMBC12@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFmYDutVixef7D6TFUiJBiKc/ZEJiOLzoxJhpBEtUUUXpKTC8fhO0HMPXClqgxoKoA==", "01237376445", false, "e5d96a29-482b-4866-b4eb-36bea616cfe7", false, "Dahi.Waseembc12@example.com" },
                    { "4099ea09-ed6b-11ed-9690-105badc84798", 0, "77d4575d-86f8-46a7-aa13-3ee726b0a556", "Osama.Hilal82e1@example.com", true, "Osama", "Hilal82e1", false, null, "OSAMA.HILAL82E1@EXAMPLE.COM", "OSAMA.HILAL82E1@EXAMPLE.COM", "AQAAAAEAACcQAAAAECwOFSNXluS4CDKvZAFRSU61nozUgjK8D6rOfsFTeanDhJSR67TPHUmEjcgfHV9w4A==", "01248547700", false, "37b3efa5-47e7-4d27-94d6-3001bf0f2a99", false, "Osama.Hilal82e1@example.com" },
                    { "4099ea0b-ed6b-11ed-b0ef-105badc84798", 0, "5fccc66f-343b-43c6-8243-b38b563ce3bf", "Moses.Hilaliaa93@example.com", true, "Moses", "Hilaliaa93", false, null, "MOSES.HILALIAA93@EXAMPLE.COM", "MOSES.HILALIAA93@EXAMPLE.COM", "AQAAAAEAACcQAAAAENfR3rYR8kPW7F39HR5lzPo21tPvbvfBnNUo1i3OuQfRNRavxxdFSFJ6zrwzeH9Y0g==", "01298932026", false, "516d0650-d9f9-49be-8e34-0be3788a45dd", false, "Moses.Hilaliaa93@example.com" },
                    { "4099ea0d-ed6b-11ed-aa2b-105badc84798", 0, "07ec8588-7078-4dae-9bf6-a276385c0cc5", "Omar.Kahterb214@example.com", true, "Omar", "Kahterb214", false, null, "OMAR.KAHTERB214@EXAMPLE.COM", "OMAR.KAHTERB214@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKU1fypCzkdrEDzChcA51sxl0fZpeBx1tMQoXULYgYStF9MHbGCCdUtgEcj1ueoqhg==", "01280480167", false, "a4689b6c-b894-4dbd-92b1-9984e3ea536e", false, "Omar.Kahterb214@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4099ea0f-ed6b-11ed-9d4e-105badc84798", 0, "862a095f-213e-422e-a24e-7362a0b9915d", "Dahi.Basselaed6@example.com", true, "Dahi", "Basselaed6", false, null, "DAHI.BASSELAED6@EXAMPLE.COM", "DAHI.BASSELAED6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBpIzsRdhIdS0D4kKnA32k1R4vN3nIrYN/qxbctpM6eef3Mv3xIxLuzf9aBn7ewWvQ==", "01243086819", false, "51fecfc1-9243-4541-b0a3-422bb648d006", false, "Dahi.Basselaed6@example.com" },
                    { "4099ea11-ed6b-11ed-8a4f-105badc84798", 0, "aa90d5aa-4809-4d5e-890e-24221b99f7f2", "Fidaa.Yusuf9983@example.com", true, "Fidaa", "Yusuf9983", false, null, "FIDAA.YUSUF9983@EXAMPLE.COM", "FIDAA.YUSUF9983@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDn5soT91W6orWxpLhCPfi68ftAYTWtuyGdXa2s0UpJvHVEgHJuERYwG63RaGA+b/w==", "01230841385", false, "f99a9b4a-4974-4200-9ef0-540ab20b2bd4", false, "Fidaa.Yusuf9983@example.com" },
                    { "4099ea13-ed6b-11ed-839a-105badc84798", 0, "3f8f20ca-5bc8-4ecb-a83f-3f8e5494fdfc", "Kamel.Danielb073@example.com", true, "Kamel", "Danielb073", false, null, "KAMEL.DANIELB073@EXAMPLE.COM", "KAMEL.DANIELB073@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMQHHX/kVxFG0grPyGAYXP84Vd1e0YjvUlJMUvYqaTVT25Z3zz37vfx5cRTdZ/QI+Q==", "01241136225", false, "71f9edfe-446f-4658-b4fb-7e6af5f37876", false, "Kamel.Danielb073@example.com" },
                    { "4099ea15-ed6b-11ed-8dbe-105badc84798", 0, "bb8d16a7-aec6-4022-b238-31c5b7c36e95", "Ghanem.Maleka044@example.com", true, "Ghanem", "Maleka044", false, null, "GHANEM.MALEKA044@EXAMPLE.COM", "GHANEM.MALEKA044@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBMQ5L7GY9oNvhlr6W2+ea9VLrbw1AqaEL99955qFkaudCEzhN04JioFqlAxIUG7Kg==", "01251094640", false, "fb031152-2b4f-48a2-ab39-0e03a0de206a", false, "Ghanem.Maleka044@example.com" },
                    { "4099ea17-ed6b-11ed-bb52-105badc84798", 0, "ac1bea31-ae6f-4f7c-9f27-8fd97890ce66", "Jawad.Mahmoudb443@example.com", true, "Jawad", "Mahmoudb443", false, null, "JAWAD.MAHMOUDB443@EXAMPLE.COM", "JAWAD.MAHMOUDB443@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEyAh0QMsF/HByyY8P+zkphgZyqRg+fUsGNbrbGOzgTFTIZPmjvgOVb1hFU3X3F/6Q==", "01278247237", false, "c8889a38-5ea0-4a80-afa0-2239c40c0e77", false, "Jawad.Mahmoudb443@example.com" },
                    { "4099ea19-ed6b-11ed-85c8-105badc84798", 0, "1531a316-89fa-451c-b43f-07279a93cf50", "Kamel.Danielaa21@example.com", true, "Kamel", "Danielaa21", false, null, "KAMEL.DANIELAA21@EXAMPLE.COM", "KAMEL.DANIELAA21@EXAMPLE.COM", "AQAAAAEAACcQAAAAEL+rMqWmVCBLHLRrREwBsaTKCT2+lSaysYIJYqIZJ2XnVdulZIgxCwcxbNtdWmH8LQ==", "01234246942", false, "a8e5f7b8-d299-4396-84c0-fe25e87a79fa", false, "Kamel.Danielaa21@example.com" },
                    { "4099ea1b-ed6b-11ed-b4c0-105badc84798", 0, "97d011ed-403a-43d6-8854-bc0ec7da8ade", "Kahter.Danielab00@example.com", true, "Kahter", "Danielab00", false, null, "KAHTER.DANIELAB00@EXAMPLE.COM", "KAHTER.DANIELAB00@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGdpNCLQwsFeJ3dWZb95SG4HXcUrk6dlgDdfH9oUDADIcixoQZy0/BNP6ic6v781IA==", "01214469178", false, "16d386d2-f006-482f-ab73-60ef7d0a3264", false, "Kahter.Danielab00@example.com" },
                    { "4099ea1d-ed6b-11ed-a4c6-105badc84798", 0, "574dee19-6e78-480e-82c4-d00575747515", "Idris.Goodbaab@example.com", true, "Idris", "Goodbaab", false, null, "IDRIS.GOODBAAB@EXAMPLE.COM", "IDRIS.GOODBAAB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEC2y7nDRnDJfNalnX9vo8Lx0i4J9OdHYyU+hwPONhF8s5NcyCH8Fn6xXhF3i7QUlbA==", "01275050210", false, "1c0f8025-7568-41f9-87e7-47e4ad2416dc", false, "Idris.Goodbaab@example.com" },
                    { "4099ea1f-ed6b-11ed-9f62-105badc84798", 0, "7d60e843-0388-40f8-a1c1-ebbe752c6b5d", "Badri.Turki86e8@example.com", true, "Badri", "Turki86e8", false, null, "BADRI.TURKI86E8@EXAMPLE.COM", "BADRI.TURKI86E8@EXAMPLE.COM", "AQAAAAEAACcQAAAAELIPhi9n9obYbc+LXLDBPpGfhnlornExzbDILsOBD7AUlBPom/3rR+MnEPPMo9WzgA==", "01296658918", false, "8ce1eb78-ed87-409e-9522-3692591e39af", false, "Badri.Turki86e8@example.com" },
                    { "409b2251-ed6b-11ed-9a82-105badc84798", 0, "bfdc2099-8678-40c8-a387-bbf1d9b49090", "Hilal.Sajidab3b@example.com", true, "Hilal", "Sajidab3b", false, null, "HILAL.SAJIDAB3B@EXAMPLE.COM", "HILAL.SAJIDAB3B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEC7UgvAriRH144gTqiIns8Pkw9j0kkIJM7jTuzEQckgtMavVREPaYehMbCcvRgF6lA==", "01269184301", false, "b2b64d09-e9c8-4c0b-b93a-6592e26e13af", false, "Hilal.Sajidab3b@example.com" },
                    { "409b2253-ed6b-11ed-b650-105badc84798", 0, "0188d32e-295a-479b-8385-653ed523d352", "Nahar.Kahterb7e4@example.com", true, "Nahar", "Kahterb7e4", false, null, "NAHAR.KAHTERB7E4@EXAMPLE.COM", "NAHAR.KAHTERB7E4@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMxZNh1cYzuXKbWYnddO7BmCFbOkWJhfACg7ub6o4+RskR+FY/T0PdNluOY0RrAoiA==", "01299448511", false, "51d4dcaa-f3e8-4b50-8eb2-a6cbb3dfe8af", false, "Nahar.Kahterb7e4@example.com" },
                    { "409b2255-ed6b-11ed-87ce-105badc84798", 0, "c12bcfdc-c7ad-4470-8661-a52846886a99", "Badri.​​Karim8bc1@example.com", true, "Badri", "​​Karim8bc1", false, null, "BADRI.​​KARIM8BC1@EXAMPLE.COM", "BADRI.​​KARIM8BC1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEL/DLztVuA0uDxOxv2PE2B+OkadzZgTztj9dGGDBUgkd1v/zE2t8yPQyOIizgUveag==", "01258445075", false, "6c0fbed0-f808-4d36-82e8-abb77d815ba4", false, "Badri.​​Karim8bc1@example.com" },
                    { "409b2257-ed6b-11ed-8f44-105badc84798", 0, "e6401d94-ec75-4196-9c5a-2dfd2367306d", "Noor.Mahmoudaee2@example.com", true, "Noor", "Mahmoudaee2", false, null, "NOOR.MAHMOUDAEE2@EXAMPLE.COM", "NOOR.MAHMOUDAEE2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBDkF36ZlMc7EgDz5HMDbWGDLi2uQwLwD50SIU7hkmYwNtmUsQZlAbuyURr9gA+0IQ==", "01224192049", false, "919cfd47-dae1-4af3-9559-2c834f7ee356", false, "Noor.Mahmoudaee2@example.com" },
                    { "409b2259-ed6b-11ed-ac78-105badc84798", 0, "8df4cddf-eaf1-4464-905b-ebeea9e0ef07", "Zarif.Asamib250@example.com", true, "Zarif", "Asamib250", false, null, "ZARIF.ASAMIB250@EXAMPLE.COM", "ZARIF.ASAMIB250@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMAUv5fP4puXkMR2JVc9bbMHVoQDzjEDmlOZWuPLLS+uGJykV5NrbiPcOsNJTyUytw==", "01279796291", false, "6c48a0c0-9d9e-4dc8-9526-d8c3cd753760", false, "Zarif.Asamib250@example.com" },
                    { "409b225b-ed6b-11ed-bf67-105badc84798", 0, "674563a0-b962-4a70-946c-9d7864aff2c6", "Barra.Osamaa94c@example.com", true, "Barra", "Osamaa94c", false, null, "BARRA.OSAMAA94C@EXAMPLE.COM", "BARRA.OSAMAA94C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPL58iiZD1UPBgtudbJdzhiXAGljFck+IKxSPEi7aeStcq0TAStZf6tN2cLHypivlQ==", "01265372285", false, "c0d77aac-514d-4a3c-80da-33ff57981a6a", false, "Barra.Osamaa94c@example.com" },
                    { "409b225d-ed6b-11ed-8369-105badc84798", 0, "722137c1-8735-46db-8bed-183a4d640384", "Jika.Sameh99c4@example.com", true, "Jika", "Sameh99c4", false, null, "JIKA.SAMEH99C4@EXAMPLE.COM", "JIKA.SAMEH99C4@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAd5uEG82h6ouQhNnUBsB0jg8BFenLvCP7wmrkLEB+cZugY7LaOE4KJYqB3hBfUyzw==", "01224100592", false, "2adc6e70-9e38-494d-9b2d-d71ec7f07253", false, "Jika.Sameh99c4@example.com" },
                    { "409b225f-ed6b-11ed-8d6a-105badc84798", 0, "d40b5444-b2e0-49db-a7fc-16401eaf967c", "Wael.​​Karim9585@example.com", true, "Wael", "​​Karim9585", false, null, "WAEL.​​KARIM9585@EXAMPLE.COM", "WAEL.​​KARIM9585@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPqa/HtZkIwTkMi9mIXmOx6EqPBP9rc4YckxMlFKQsh54XFjTeuekFDPYEnbmbSWLA==", "01270034864", false, "d882e65c-65c1-465a-86d0-8ae284517598", false, "Wael.​​Karim9585@example.com" },
                    { "409b2261-ed6b-11ed-b7f8-105badc84798", 0, "4d321cbe-639f-4f0e-b77f-2b41bae5b6b6", "Hilal.Faisal9236@example.com", true, "Hilal", "Faisal9236", false, null, "HILAL.FAISAL9236@EXAMPLE.COM", "HILAL.FAISAL9236@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAIlYaAHh83zQ0xtj8YF8PJTp6dfxW0KPJcxsFJPU+YNfrCzwcX1Os/jwSBE+jRtpQ==", "01221565927", false, "712b03f0-c8f9-4992-b6ab-4b38b00c7820", false, "Hilal.Faisal9236@example.com" },
                    { "409b2263-ed6b-11ed-93b0-105badc84798", 0, "b9c5a530-5359-4298-99d8-c55a3576b9d4", "Adel.Bahir82d6@example.com", true, "Adel", "Bahir82d6", false, null, "ADEL.BAHIR82D6@EXAMPLE.COM", "ADEL.BAHIR82D6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFRpyUCMXt8c5xOFCdMeoutuPtV3KDt8entVvYAk5zegeZPJPAPSXPUgN6CUje5V1A==", "01276197853", false, "d4a3779a-5f75-4279-bf74-2a7dbd518f5c", false, "Adel.Bahir82d6@example.com" },
                    { "409b2265-ed6b-11ed-8a51-105badc84798", 0, "39345167-ae02-46ab-8dd3-7e8aa3db8870", "Mahmoud.Daniel964c@example.com", true, "Mahmoud", "Daniel964c", false, null, "MAHMOUD.DANIEL964C@EXAMPLE.COM", "MAHMOUD.DANIEL964C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIS2voKloAVrtShTx2nSk1AE9FoNM1Wcw0LdBQTtgoBSCO1RAI++3N8cq4m9s+H05Q==", "01244504780", false, "4c88a103-280f-4fb1-b26a-712797a6c5f3", false, "Mahmoud.Daniel964c@example.com" },
                    { "409b2267-ed6b-11ed-9ed8-105badc84798", 0, "d20d8b1b-fe9a-4553-ab63-dcad9ade8e26", "Adel.Hamaki94da@example.com", true, "Adel", "Hamaki94da", false, null, "ADEL.HAMAKI94DA@EXAMPLE.COM", "ADEL.HAMAKI94DA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEC2z4I9tbyRm3F+U61r5epcofbSmaRoeQRtZ14vSjXmXL9SohgKTpasVPGr7eTLOJQ==", "01227940951", false, "57688555-75dd-495a-9cec-f8fcf881364c", false, "Adel.Hamaki94da@example.com" },
                    { "409b2269-ed6b-11ed-96a1-105badc84798", 0, "7d9dda95-d806-48b5-8287-cb9c7c29b318", "Adham.Basembae6@example.com", true, "Adham", "Basembae6", false, null, "ADHAM.BASEMBAE6@EXAMPLE.COM", "ADHAM.BASEMBAE6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJQsnbOUJPjwI/ukgzPjTkhQkcm33ITyBYEWmKKgfGjts7AxTLWdv6pvEyr7fFoYxw==", "01295804031", false, "59e7c323-ebbf-445a-abee-64957966ab72", false, "Adham.Basembae6@example.com" },
                    { "409b226b-ed6b-11ed-b5d0-105badc84798", 0, "05c214d1-8081-421e-b248-2eaabc884e39", "Lail.Bilalbdd5@example.com", true, "Lail", "Bilalbdd5", false, null, "LAIL.BILALBDD5@EXAMPLE.COM", "LAIL.BILALBDD5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIHwOGBuii4jcIVUT4XewvLTTrO6NaAcpBZxUnOkI1nSlgxg2kCpDKtnkWcfshdkRw==", "01264886434", false, "691faff5-456b-491c-989d-1b3601883865", false, "Lail.Bilalbdd5@example.com" },
                    { "409b226d-ed6b-11ed-9578-105badc84798", 0, "102b047f-4a32-4ee5-a43f-95ae7f252344", "Bara.Badri8be3@example.com", true, "Bara", "Badri8be3", false, null, "BARA.BADRI8BE3@EXAMPLE.COM", "BARA.BADRI8BE3@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBt07MZpJPdoqKfZoihwKfCvbMY8VJcZFeTkQkS+MFl+kpoX0PvxMzP1ScLr5h5gXg==", "01232443399", false, "744a1c22-c6a6-4aed-ac18-f60b86735872", false, "Bara.Badri8be3@example.com" },
                    { "409b226f-ed6b-11ed-af75-105badc84798", 0, "499161fe-5b20-4886-8105-92f91155e2cf", "Sheikh.Sheikha7a4@example.com", true, "Sheikh", "Sheikha7a4", false, null, "SHEIKH.SHEIKHA7A4@EXAMPLE.COM", "SHEIKH.SHEIKHA7A4@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDIvXuA2uR2KH3ci+pl7j1gcyukU/r/6DYi7zdrlWvz5RHbC68Ek42jwQ+sA21F/LA==", "01245074460", false, "812f90c8-62e0-4512-a1a2-6868ae1aac0c", false, "Sheikh.Sheikha7a4@example.com" },
                    { "409b2271-ed6b-11ed-b13a-105badc84798", 0, "3c562062-8e06-47c4-9d0e-a41d871bcb38", "Loay.Hamaqyaf12@example.com", true, "Loay", "Hamaqyaf12", false, null, "LOAY.HAMAQYAF12@EXAMPLE.COM", "LOAY.HAMAQYAF12@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBxN535Qfe/eXaJjBVDE/6A6Gx8UCPiATLgJLBK0ZejxOKnNvnwUPN7MwbkIqqemgg==", "01295630957", false, "78439bb2-7053-4afd-9406-b7c6cd53e587", false, "Loay.Hamaqyaf12@example.com" },
                    { "409b2273-ed6b-11ed-984c-105badc84798", 0, "7c6ba178-57f7-4654-86b7-63c45162c21b", "Maher.Good90c5@example.com", true, "Maher", "Good90c5", false, null, "MAHER.GOOD90C5@EXAMPLE.COM", "MAHER.GOOD90C5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFEejUoezvaMVOChzV9CXiSLfXBYBNNWEUqVD0dAQj95VOM+c8tFXTh5Yr7BD54cKw==", "01211245634", false, "58d96f93-3d20-4abf-874c-2bfa10e0e046", false, "Maher.Good90c5@example.com" },
                    { "409b2275-ed6b-11ed-8ea0-105badc84798", 0, "769b39b7-44ad-490e-bdca-eb6903376713", "Bassam.Russella913@example.com", true, "Bassam", "Russella913", false, null, "BASSAM.RUSSELLA913@EXAMPLE.COM", "BASSAM.RUSSELLA913@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPNZwfzfojzzLr07UUTT8MqF8M6fu8KDmanMU6aaehHyYO8HOyJoSAzYQdfq2t7T3w==", "01277681415", false, "040153dd-4f84-4def-9284-9d39b06be0d5", false, "Bassam.Russella913@example.com" },
                    { "409b2277-ed6b-11ed-a519-105badc84798", 0, "f27d768a-e6f1-4f3b-a1bf-9203f8c4272f", "Sheikhy.Jawada4e1@example.com", true, "Sheikhy", "Jawada4e1", false, null, "SHEIKHY.JAWADA4E1@EXAMPLE.COM", "SHEIKHY.JAWADA4E1@EXAMPLE.COM", "AQAAAAEAACcQAAAAENU5KOTb0gv+nOn4Mryx3jM304vf7b+35+GVhGyZ0uyWMI+28QMo2o2rVNFboprkcw==", "01249047718", false, "05637b29-ecfe-463a-81d0-88a1a31bd70d", false, "Sheikhy.Jawada4e1@example.com" },
                    { "409b2279-ed6b-11ed-a66d-105badc84798", 0, "458737d3-9678-432a-ba00-d4f7e3db108d", "Hassan.Hosni80b2@example.com", true, "Hassan", "Hosni80b2", false, null, "HASSAN.HOSNI80B2@EXAMPLE.COM", "HASSAN.HOSNI80B2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOCPpO/ZXf1xHBUU3/iNtGRazUpksptbgCMtIOTZ98r8XNGANAAimBWI3nts48Jceg==", "01247655370", false, "4a45f4aa-de74-4690-8472-fda5dee751b3", false, "Hassan.Hosni80b2@example.com" },
                    { "409b227b-ed6b-11ed-a6a6-105badc84798", 0, "3126bbd4-e40b-4455-ae56-9ed98bf1a268", "Minali.Yamen9b11@example.com", true, "Minali", "Yamen9b11", false, null, "MINALI.YAMEN9B11@EXAMPLE.COM", "MINALI.YAMEN9B11@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPZX8CaFqDJzmUD6li0HklxI3/gUmacv9JLvFJhUzUiDRsBxB2y7dNWwbqffnGY1JA==", "01244701551", false, "6e35e82f-1290-4a48-81c0-4c6bc7e01c34", false, "Minali.Yamen9b11@example.com" },
                    { "409b227d-ed6b-11ed-b8fd-105badc84798", 0, "d751177e-a66e-4def-bdfa-27bd65a2a713", "Battari.Ghanema3e1@example.com", true, "Battari", "Ghanema3e1", false, null, "BATTARI.GHANEMA3E1@EXAMPLE.COM", "BATTARI.GHANEMA3E1@EXAMPLE.COM", "AQAAAAEAACcQAAAAENaO0yOh+X15KGOvQyuzKu2jS/RrbSJeTTdAAbyAv2FMJp1OUySdTlr0zHOKUb/X7Q==", "01261605249", false, "e9e02867-a453-499a-b764-777a3b7f3f3e", false, "Battari.Ghanema3e1@example.com" },
                    { "409b227f-ed6b-11ed-9609-105badc84798", 0, "af4e47e3-12da-4c04-b5da-2c66c64874b4", "Yusuf.Maherac9c@example.com", true, "Yusuf", "Maherac9c", false, null, "YUSUF.MAHERAC9C@EXAMPLE.COM", "YUSUF.MAHERAC9C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEO7j46gB0yEzLsMx4kPPQ6yPgaKpFkrGS7NcfNtLvhF5kIOw4LCRTMpV86YOyDV81w==", "01293092536", false, "a7918ea8-f000-49fd-9b97-c6de2afe0d32", false, "Yusuf.Maherac9c@example.com" },
                    { "409b2281-ed6b-11ed-968e-105badc84798", 0, "5ad91b39-5d91-473c-b05e-1a4c54247780", "Saree.Idrisb0ef@example.com", true, "Saree", "Idrisb0ef", false, null, "SAREE.IDRISB0EF@EXAMPLE.COM", "SAREE.IDRISB0EF@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGi7xflwhstF7ZseNzbZCjuNdiREcprHji9RcqwujF6A2mHx7JWvJ1ZPpiBl9+5mbA==", "01220329770", false, "fe7cce31-68ba-4f7b-8261-75117aeb7121", false, "Saree.Idrisb0ef@example.com" },
                    { "409b2283-ed6b-11ed-90f7-105badc84798", 0, "99ca8818-d5c7-4551-b1b1-15f42eef2e6c", "Adham.Bahiraf53@example.com", true, "Adham", "Bahiraf53", false, null, "ADHAM.BAHIRAF53@EXAMPLE.COM", "ADHAM.BAHIRAF53@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOM5qhQ7SBIAF7x/Z1oBe6Wid/2F6ed7Vhdt/owuYzQP3VySH9Yk0LPYjRAUQxnpnw==", "01259225260", false, "4746ede1-2cdb-4e99-b213-66e93f9a63fb", false, "Adham.Bahiraf53@example.com" },
                    { "409b2285-ed6b-11ed-945d-105badc84798", 0, "33c26a82-a09f-4078-91a1-c8a3c4c6e3bf", "Saden.Salim9973@example.com", true, "Saden", "Salim9973", false, null, "SADEN.SALIM9973@EXAMPLE.COM", "SADEN.SALIM9973@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAr9NISOODSf/YmpezoL0PYTghUqxCYdApjBrQNNkORKGizLKol2Yu18CEaXZAWpfg==", "01251768428", false, "d3d7954a-8762-4279-9ce9-6512b9e0f006", false, "Saden.Salim9973@example.com" },
                    { "409b2287-ed6b-11ed-bdd8-105badc84798", 0, "f5214be1-9447-41b2-8ea4-03f9645c47b9", "Sameh.Hassana203@example.com", true, "Sameh", "Hassana203", false, null, "SAMEH.HASSANA203@EXAMPLE.COM", "SAMEH.HASSANA203@EXAMPLE.COM", "AQAAAAEAACcQAAAAENHfyMJOuWXDlrRoW0KUpR+6rYateC2WW7Vfp2sNXYLRJ2sQ3I2l2CnXkY9LBJhrWg==", "01212703009", false, "3af5f793-4297-4b03-b53d-0ddf1f3b1c87", false, "Sameh.Hassana203@example.com" },
                    { "409b2289-ed6b-11ed-8a33-105badc84798", 0, "ab6bc80b-0498-4b51-9c66-7bf875cf51d7", "Yusuf.Fidaa92d2@example.com", true, "Yusuf", "Fidaa92d2", false, null, "YUSUF.FIDAA92D2@EXAMPLE.COM", "YUSUF.FIDAA92D2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGOSiXVKxXRbOEttdbnlj3CqLXTWZuaohE6Qj1YuxGhUSKkQQP6irSCFv7qRdumESw==", "01216037425", false, "24fd3cb0-5125-4695-b016-0f6582dd5f14", false, "Yusuf.Fidaa92d2@example.com" },
                    { "409b228b-ed6b-11ed-82cb-105badc84798", 0, "6799d553-c868-4412-bf55-b2fb31b3bb4a", "Dagher.Baraa698@example.com", true, "Dagher", "Baraa698", false, null, "DAGHER.BARAA698@EXAMPLE.COM", "DAGHER.BARAA698@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOTqCM/u+K4T9JfxV4N2Hk2ADKX4UuILT5G/ojZlXWQrQ9GWFludaIhclfSNInwRkQ==", "01228632027", false, "53e06bc8-1fc9-4ad6-8e4b-199b7e0d7743", false, "Dagher.Baraa698@example.com" },
                    { "409b228d-ed6b-11ed-9862-105badc84798", 0, "129815b7-e08e-45cf-b19c-d651b0abb6c1", "Bassel.Ibrahima080@example.com", true, "Bassel", "Ibrahima080", false, null, "BASSEL.IBRAHIMA080@EXAMPLE.COM", "BASSEL.IBRAHIMA080@EXAMPLE.COM", "AQAAAAEAACcQAAAAEH01nu7e7OnQR/EjEYgL556hHuNTO17+9aW5vAqr6pMTV5ySBHgDNaBYFmBp6fLkAg==", "01299705532", false, "702d34d5-10ed-40ae-b365-70bf9cfc7f52", false, "Bassel.Ibrahima080@example.com" },
                    { "409b228f-ed6b-11ed-bba0-105badc84798", 0, "985b559c-8ae0-4f19-bda2-0ab1bbdd1f23", "Kamel.Samhi885f@example.com", true, "Kamel", "Samhi885f", false, null, "KAMEL.SAMHI885F@EXAMPLE.COM", "KAMEL.SAMHI885F@EXAMPLE.COM", "AQAAAAEAACcQAAAAEF7qFA7ZveIQsZy5AhSUIL58JvGOGWcD2miPzG/lUCrsw4A8SRtaiJdYp6ldtFiQmg==", "01280062716", false, "a7fc7b4d-9ca2-4bbe-b43e-557a790b3722", false, "Kamel.Samhi885f@example.com" },
                    { "409b2291-ed6b-11ed-82b0-105badc84798", 0, "6a33bd29-5469-46b0-812f-f8c6b38cb34a", "Bara.Fahedb92d@example.com", true, "Bara", "Fahedb92d", false, null, "BARA.FAHEDB92D@EXAMPLE.COM", "BARA.FAHEDB92D@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAtx4DM48SIIOYFqlc2++b250hCgEZq1vzx0M/ZKZO8CPi7GI/KClCI1Z3e4WJ6QSA==", "01272696536", false, "61182fd7-0f93-4b8e-98d5-322f83139049", false, "Bara.Fahedb92d@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "409b2293-ed6b-11ed-a281-105badc84798", 0, "c99c8185-80a1-40d4-bd58-f080b5f7f84c", "Samhi.Hilal8bd1@example.com", true, "Samhi", "Hilal8bd1", false, null, "SAMHI.HILAL8BD1@EXAMPLE.COM", "SAMHI.HILAL8BD1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFvLukTVaL7KQMYXQHOFSAIv8V2fIKtzf1Uy3Ix0bjRB+qwt630yjRvdvc178+KGpg==", "01278276213", false, "3395c35c-408b-4fa3-9728-4f8a1ee9d694", false, "Samhi.Hilal8bd1@example.com" },
                    { "409b2295-ed6b-11ed-a03f-105badc84798", 0, "e4871a83-334b-4baf-96d5-8040d9c96e82", "Faisal.Samirbd6b@example.com", true, "Faisal", "Samirbd6b", false, null, "FAISAL.SAMIRBD6B@EXAMPLE.COM", "FAISAL.SAMIRBD6B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHqROvkyr/1H+9NaqAIaGY5iYn7CWYYtPdTXw74giq2ltUb9yHQsrillEJpK79fTyA==", "01296553303", false, "66813d86-f12a-4504-9aab-e3912327f119", false, "Faisal.Samirbd6b@example.com" },
                    { "409b2297-ed6b-11ed-9620-105badc84798", 0, "c1e34a44-197b-462a-89e6-6768f2bcf7d3", "Wael.Sahami86d0@example.com", true, "Wael", "Sahami86d0", false, null, "WAEL.SAHAMI86D0@EXAMPLE.COM", "WAEL.SAHAMI86D0@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGeEcE8ZtYT7kPZkHZrIgcFQzH6LXBh2CKSXDVM8VTGTGlUjsadc+AhhlT2/vT1fvw==", "01283688266", false, "b8db3100-09cd-4da0-9994-04dc4dfd9feb", false, "Wael.Sahami86d0@example.com" },
                    { "409b2299-ed6b-11ed-8cd7-105badc84798", 0, "8c78fd82-5962-4e48-8db6-06cf964c7f5c", "Muhammad.Yad826b@example.com", true, "Muhammad", "Yad826b", false, null, "MUHAMMAD.YAD826B@EXAMPLE.COM", "MUHAMMAD.YAD826B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHZ/keHiCePX2sfn92w0uohwTtPwZnmoSKW2xO/m1xBduBOdKdkzFT53gs4PQ6FqBA==", "01241209071", false, "7ebeeff7-310e-46e1-8fdf-f21df635d41f", false, "Muhammad.Yad826b@example.com" },
                    { "409b229b-ed6b-11ed-b5e4-105badc84798", 0, "c8ebec8e-f4d5-4317-a1f2-5957551b2fa1", "Wael.Bahi97f5@example.com", true, "Wael", "Bahi97f5", false, null, "WAEL.BAHI97F5@EXAMPLE.COM", "WAEL.BAHI97F5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJRAgDSIxq/rGHm8LEoCC4L0QSzCBgboXCNjoxjB9oCVj45RWBWGjB4Am5uQAxjpeA==", "01280616076", false, "6a13fe76-0d53-489e-bdb5-c8e24e3e2035", false, "Wael.Bahi97f5@example.com" },
                    { "409c5ba9-ed6b-11ed-a9f0-105badc84798", 0, "257560fa-1838-469d-9cd5-2be30b98e81b", "Sameh.Osama98c7@example.com", true, "Sameh", "Osama98c7", false, null, "SAMEH.OSAMA98C7@EXAMPLE.COM", "SAMEH.OSAMA98C7@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIBlQ1ytnA8Qt7y66fO/me1Y4/eD3xi6qk0SIbVlHvkhjga/ReWlOaiascLbSj+12A==", "01242267999", false, "bf8becbd-fa5d-4871-91b5-1958502e0403", false, "Sameh.Osama98c7@example.com" },
                    { "409c5bab-ed6b-11ed-9ebb-105badc84798", 0, "007ecb87-686e-4e5f-80f1-7fb62ecfa102", "Dagher.Sareead13@example.com", true, "Dagher", "Sareead13", false, null, "DAGHER.SAREEAD13@EXAMPLE.COM", "DAGHER.SAREEAD13@EXAMPLE.COM", "AQAAAAEAACcQAAAAEO4rvBI+2mHl90UsgJwkWAKZL1s5p56YQeki8UbazBfHPi27OVTIWyFYKj/vZqjY4w==", "01280522970", false, "81a09536-e66b-43e2-9878-ac1f6d1c2975", false, "Dagher.Sareead13@example.com" },
                    { "409c5bad-ed6b-11ed-b06e-105badc84798", 0, "9cd60d45-98bd-465f-847f-c21a7bcede62", "Yad.Hamaqy909a@example.com", true, "Yad", "Hamaqy909a", false, null, "YAD.HAMAQY909A@EXAMPLE.COM", "YAD.HAMAQY909A@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMZazl8/LFAGG0j//UAI5WFMJb3E1qo02ntjUH6fYRuDko4nKHrj7zTNIYdRq/CC/Q==", "01268125360", false, "3ad6896a-e37e-42d7-942a-8700314f1f0d", false, "Yad.Hamaqy909a@example.com" },
                    { "409c5baf-ed6b-11ed-b43f-105badc84798", 0, "5fdf6d73-c9c9-422e-a391-567e0b9980a8", "Bassel.Kamelaef1@example.com", true, "Bassel", "Kamelaef1", false, null, "BASSEL.KAMELAEF1@EXAMPLE.COM", "BASSEL.KAMELAEF1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEmtwrJCzkqjygssOFjPjYRc0RMwdWgTt0JQK5PyxDVEqgvMXd7/1aq6S2jvZ7LVRw==", "01281713510", false, "cd5ae49b-8e25-4d25-a5b2-7386fd308872", false, "Bassel.Kamelaef1@example.com" },
                    { "409c5bb1-ed6b-11ed-b22e-105badc84798", 0, "35e1dafe-8af2-40b4-9820-c4ac825b9e9b", "Lail.Minali8f58@example.com", true, "Lail", "Minali8f58", false, null, "LAIL.MINALI8F58@EXAMPLE.COM", "LAIL.MINALI8F58@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOpuQ2xah2ExnSimwblo0/tZHjHeP32US+aOX0gAXDHJYQ4k1fNc77vpz/H3ovdktA==", "01211017057", false, "a175b0be-f427-4e16-859c-d834bf92db79", false, "Lail.Minali8f58@example.com" },
                    { "409c5bb3-ed6b-11ed-8aea-105badc84798", 0, "8b3e2081-b9c0-4db0-b8d7-6c974823fbfd", "Majid.Adlia9c6@example.com", true, "Majid", "Adlia9c6", false, null, "MAJID.ADLIA9C6@EXAMPLE.COM", "MAJID.ADLIA9C6@EXAMPLE.COM", "AQAAAAEAACcQAAAAENOcylkS52sYVSOBsaGYP3mo6KZJrKjoBCF25NJkOiTz72CvsofhPmSwsu2lVmUIwQ==", "01276042209", false, "858ebf80-7415-47d1-abee-148d39784b61", false, "Majid.Adlia9c6@example.com" },
                    { "409c5bb5-ed6b-11ed-81ec-105badc84798", 0, "16727f53-4903-41fb-a9bb-59e2bca4a12e", "Firas.Yakonaf22@example.com", true, "Firas", "Yakonaf22", false, null, "FIRAS.YAKONAF22@EXAMPLE.COM", "FIRAS.YAKONAF22@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMdj2vAJ8xc5tffmLg+k23TgtbBms2ZJCai1rTlhH9VYHoSCFcrnCM1bHvEoE9H5TQ==", "01248361000", false, "604a3858-fd6a-4ed7-943b-81653ab40d5d", false, "Firas.Yakonaf22@example.com" },
                    { "409c5bb7-ed6b-11ed-a54a-105badc84798", 0, "48b60053-2816-432e-8e05-be0e7e1e4dad", "Saden.Hassanaf93@example.com", true, "Saden", "Hassanaf93", false, null, "SADEN.HASSANAF93@EXAMPLE.COM", "SADEN.HASSANAF93@EXAMPLE.COM", "AQAAAAEAACcQAAAAEN+2JTJQd6++HgwI+XzxL+vuSCMe0tU0X0Fy6lFezrKTLfqH3vMq8sZIsBKxkL4lfA==", "01252473730", false, "c0c766b1-2c41-4469-9c6e-7e6ae1a3c277", false, "Saden.Hassanaf93@example.com" },
                    { "409c5bb9-ed6b-11ed-a374-105badc84798", 0, "fa2aaa8f-05b2-44a3-8af5-7623b491b828", "Helsey.Noor82e8@example.com", true, "Helsey", "Noor82e8", false, null, "HELSEY.NOOR82E8@EXAMPLE.COM", "HELSEY.NOOR82E8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHVCD5CKh0RwW2f2nmktdzss2kVueuAer8d0LtbXlXOInOU3a6pmo3xvreWFVV2k1w==", "01293212396", false, "121d78d1-db16-4b54-a9b4-bbcd798bb019", false, "Helsey.Noor82e8@example.com" },
                    { "409c5bbb-ed6b-11ed-a145-105badc84798", 0, "a417baf1-08ee-41a6-bc6e-9a6a00334542", "Ali.Ryan921d@example.com", true, "Ali", "Ryan921d", false, null, "ALI.RYAN921D@EXAMPLE.COM", "ALI.RYAN921D@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJRCIKUF8ptosZmKTstRfUwTfaGhU50yBweMK1gy01jWo2TETDjxEctflXi7cffIqw==", "01240558815", false, "7c7a6add-91bd-4d79-ab03-16d3909ab44c", false, "Ali.Ryan921d@example.com" },
                    { "409c5bbd-ed6b-11ed-a7f3-105badc84798", 0, "2799bc8a-1afa-495a-bd1e-938c4a40438e", "Yad.Najm91d8@example.com", true, "Yad", "Najm91d8", false, null, "YAD.NAJM91D8@EXAMPLE.COM", "YAD.NAJM91D8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPLeJG81bAHLAC1KshGJgy5fXpp12kpCMk+GLkz39YB3f6qoOCM5Nv/m2CMn19SSyA==", "01256088190", false, "dd767e00-0643-40f7-8082-4e58cf71d7eb", false, "Yad.Najm91d8@example.com" },
                    { "409c5bbf-ed6b-11ed-afcf-105badc84798", 0, "2a7fab17-ed4b-46c4-8b38-1ad31b4d4731", "Good.Hilal8ebc@example.com", true, "Good", "Hilal8ebc", false, null, "GOOD.HILAL8EBC@EXAMPLE.COM", "GOOD.HILAL8EBC@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJyzhHAd3CaOLhGq2XmplNTAU9QBtnCd8WQaxGmKXxnWzu7HWLpCuEQfI1jAfub1XA==", "01233135538", false, "47cc311d-0220-4b8e-8435-c14f4bd078c3", false, "Good.Hilal8ebc@example.com" },
                    { "409c5bc1-ed6b-11ed-880d-105badc84798", 0, "a2d03b58-fe59-4cee-97e7-23e20730b3ae", "Bara.Omar96e5@example.com", true, "Bara", "Omar96e5", false, null, "BARA.OMAR96E5@EXAMPLE.COM", "BARA.OMAR96E5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPyvKVddkKHwebqmzKl3B9D36rJZiCdglpl9u0Xu0L7siyQ6qMml96Yxak0io/o3fg==", "01253668931", false, "edb820f0-756a-4aa3-9326-e1e8f886d229", false, "Bara.Omar96e5@example.com" },
                    { "409c5bc3-ed6b-11ed-b2b0-105badc84798", 0, "f288a5cd-e1ad-49a5-84d2-c2de6ef9a7d8", "Jika.Faisal9ca6@example.com", true, "Jika", "Faisal9ca6", false, null, "JIKA.FAISAL9CA6@EXAMPLE.COM", "JIKA.FAISAL9CA6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAk9sXEVDsE9k+dtFZTdppWzUD6QVUgCvgQ61S7tDsvftOmQQiA4JZpSmpQcJBp6sA==", "01270653239", false, "611a7505-fade-4876-b253-8841c8fc3833", false, "Jika.Faisal9ca6@example.com" },
                    { "409c5bc5-ed6b-11ed-9c33-105badc84798", 0, "574f6ea5-858e-473c-a8aa-5d1255c19a45", "Fares.Turkib5c8@example.com", true, "Fares", "Turkib5c8", false, null, "FARES.TURKIB5C8@EXAMPLE.COM", "FARES.TURKIB5C8@EXAMPLE.COM", "AQAAAAEAACcQAAAAECI7TMNAV94AYqmhuJTZ/g420x/oqAm1USrxVJvDJfQBw3xAr8OMqWgYvYHBg6FG1Q==", "01298016974", false, "d90720b6-4590-402b-b997-5b6af36f19d1", false, "Fares.Turkib5c8@example.com" },
                    { "409c5bc7-ed6b-11ed-a584-105badc84798", 0, "44a4a756-1cf0-4f2a-8328-af768de78b12", "Waseem.Zachariah8b80@example.com", true, "Waseem", "Zachariah8b80", false, null, "WASEEM.ZACHARIAH8B80@EXAMPLE.COM", "WASEEM.ZACHARIAH8B80@EXAMPLE.COM", "AQAAAAEAACcQAAAAEH+hkCsG56f3OTdjhBpPjwyLo5xCi4bAYCIXKQ23XQlL3OFdTMt1GS983rWn7GGmgQ==", "01233473594", false, "16ab0272-ef5b-42fd-9223-128f623bed72", false, "Waseem.Zachariah8b80@example.com" },
                    { "409c5bc9-ed6b-11ed-94df-105badc84798", 0, "ab57775f-3bb5-4991-9192-9b15a5c6e2d4", "Basem.Zaki9209@example.com", true, "Basem", "Zaki9209", false, null, "BASEM.ZAKI9209@EXAMPLE.COM", "BASEM.ZAKI9209@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAqnqgaHY25f5ErNenY6t5kBSSefuH8PgAMkbdvcerfezNKbmoFgkjkTGIjeiwF9Cw==", "01247188081", false, "b4227919-7a6c-43ad-b02b-d626911e91b1", false, "Basem.Zaki9209@example.com" },
                    { "409c5bcb-ed6b-11ed-ae48-105badc84798", 0, "4cec825a-4a46-438d-9cdc-c56ba384fa87", "Firas.Fahedb115@example.com", true, "Firas", "Fahedb115", false, null, "FIRAS.FAHEDB115@EXAMPLE.COM", "FIRAS.FAHEDB115@EXAMPLE.COM", "AQAAAAEAACcQAAAAEL2K6017GeqDLkNovKwvSSGYygTM4CwmAVS6b4N8fvEXHV0HS8GoYjzoZ603WdsmFA==", "01238482001", false, "cb25d3ea-1acf-4be7-a99a-c01646ce8fd1", false, "Firas.Fahedb115@example.com" },
                    { "409c5bcd-ed6b-11ed-82bc-105badc84798", 0, "d63083e8-b63a-40f9-99f1-fdfd3ad6d3c6", "Hilal.Asim8263@example.com", true, "Hilal", "Asim8263", false, null, "HILAL.ASIM8263@EXAMPLE.COM", "HILAL.ASIM8263@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEgAsPxMJAaNbke7+nzGXkbfFahJsJTPMGC+NGkv7uUF6R6VScpqQmxnfkF/G/R6Ew==", "01225838899", false, "a0e2e333-3c83-4e3d-be37-ca82ce7f3322", false, "Hilal.Asim8263@example.com" },
                    { "409c5bcf-ed6b-11ed-a53b-105badc84798", 0, "406b10b6-ba9a-41e5-908d-1edcd2ac6c17", "Kamel.Ghanema74f@example.com", true, "Kamel", "Ghanema74f", false, null, "KAMEL.GHANEMA74F@EXAMPLE.COM", "KAMEL.GHANEMA74F@EXAMPLE.COM", "AQAAAAEAACcQAAAAEE25d9+beOPjBlDBjjo9UT5LHLrgP1szfRHKiSI0mywqf74Km0J1cbfCr0IyUEqREA==", "01267168944", false, "cc51d970-e442-471a-868e-5ac9387e5cb3", false, "Kamel.Ghanema74f@example.com" },
                    { "409c5bd1-ed6b-11ed-8709-105badc84798", 0, "97327d27-b89b-4f39-836f-383df7b67fb7", "Firas.Adelac4e@example.com", true, "Firas", "Adelac4e", false, null, "FIRAS.ADELAC4E@EXAMPLE.COM", "FIRAS.ADELAC4E@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMLWxstbpjFGHYobipt85WD3R1qQBIdL6GxZt80gYjsv4JcEc8zu5Et4gvzxyxrJVg==", "01274387720", false, "bd116f03-11e3-42e7-a3df-708b15f8e399", false, "Firas.Adelac4e@example.com" },
                    { "409c5bd3-ed6b-11ed-b60d-105badc84798", 0, "e6d88c47-d79e-437f-bf52-d5f908afeacf", "Shehabi.Asamib745@example.com", true, "Shehabi", "Asamib745", false, null, "SHEHABI.ASAMIB745@EXAMPLE.COM", "SHEHABI.ASAMIB745@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMj3Zd3wDBxMWaUoGURZrIe2rcV4Dx6+/c3/6NJ6AGwH8EQIo98TSptz1s757t6ZHQ==", "01265107277", false, "bad36497-611c-4781-932a-fbb9031acd26", false, "Shehabi.Asamib745@example.com" },
                    { "409c5bd5-ed6b-11ed-92ef-105badc84798", 0, "f1864830-95d5-42b5-acc5-13daeb48ce59", "Adam.Ryanbb23@example.com", true, "Adam", "Ryanbb23", false, null, "ADAM.RYANBB23@EXAMPLE.COM", "ADAM.RYANBB23@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJdEkWUiEuOqbebRxMT7UiDl9qgVh8USGRR9vnRVCBqo1sI75yt1s9HGxvYGsqQYXw==", "01230210003", false, "5c7ab2f5-4837-4917-8f21-c26843912735", false, "Adam.Ryanbb23@example.com" },
                    { "409c5bd7-ed6b-11ed-8e67-105badc84798", 0, "5fd290ce-7336-43c0-b3ae-7be52dcaad99", "Yunus.Ahmed90cb@example.com", true, "Yunus", "Ahmed90cb", false, null, "YUNUS.AHMED90CB@EXAMPLE.COM", "YUNUS.AHMED90CB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEP/Ng72Ej/fk1eSoIBbhaiqFWeTxiY812NYsJSfC49ZEdyXfUHoPz89M2LU9cMvBMA==", "01235122474", false, "16d213a3-5812-4be7-9772-251cb2cbf987", false, "Yunus.Ahmed90cb@example.com" },
                    { "409c5bd9-ed6b-11ed-aac6-105badc84798", 0, "d77f0ec4-3775-4666-b199-7ce56e443e68", "Kamel.Hassan8f33@example.com", true, "Kamel", "Hassan8f33", false, null, "KAMEL.HASSAN8F33@EXAMPLE.COM", "KAMEL.HASSAN8F33@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDcA8M5YsGsC3M5zuy7+rTfVfB1dfAAnDPZvdgwp/4OATzT0WCUYgsP0OiUf+nSDnA==", "01243061369", false, "a0701bf2-9a17-4885-b09c-0376930b3299", false, "Kamel.Hassan8f33@example.com" },
                    { "409c5bdb-ed6b-11ed-9c54-105badc84798", 0, "59e12eb0-33f6-4561-890a-6a07b5868815", "Sharm.Haor9abe@example.com", true, "Sharm", "Haor9abe", false, null, "SHARM.HAOR9ABE@EXAMPLE.COM", "SHARM.HAOR9ABE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBbvJ/59IOYzBNn8tDW3mvkebZystP4xg+v8MafFOUQF6MwZe9s+ZcSboUqYPjzrJw==", "01256605664", false, "727ae0b4-042b-42d2-9135-6ee5c57faa1a", false, "Sharm.Haor9abe@example.com" },
                    { "409c5bdd-ed6b-11ed-9d5b-105badc84798", 0, "6a7d6c26-d9a2-4109-b2f3-6aade66b95fd", "Shehabi.Radwanaea9@example.com", true, "Shehabi", "Radwanaea9", false, null, "SHEHABI.RADWANAEA9@EXAMPLE.COM", "SHEHABI.RADWANAEA9@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHSO17+NGyMaChUE2DiJEHhB9TVMUsZdVc8YQYBqo62NKnnkBGOpktTGHl39EjFTGQ==", "01247779098", false, "d517422b-5b3c-4418-898a-d66ab4250402", false, "Shehabi.Radwanaea9@example.com" },
                    { "409c5bdf-ed6b-11ed-8964-105badc84798", 0, "9f5ea8cf-a181-4f20-a45e-47dada14412b", "Sandsi.Sareea2bb@example.com", true, "Sandsi", "Sareea2bb", false, null, "SANDSI.SAREEA2BB@EXAMPLE.COM", "SANDSI.SAREEA2BB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEF1PyQiG69q5HQ4fGBV9hwbjc8S7ZZy34yas5C6KNn+avU6zPHFs3kx8pgD8OV6+Tw==", "01295119441", false, "992c1783-c8e9-48b0-9528-ec80a3968918", false, "Sandsi.Sareea2bb@example.com" },
                    { "409c5be1-ed6b-11ed-858f-105badc84798", 0, "6a82ab43-a78b-485a-884f-5d48986d96ae", "Ryan.Ahmed92cc@example.com", true, "Ryan", "Ahmed92cc", false, null, "RYAN.AHMED92CC@EXAMPLE.COM", "RYAN.AHMED92CC@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGJbuADrT18xtCDnmQmffHd+iifUJyK3VUKprqexNKIqDG8YYCpUex62T+IzW3n2NQ==", "01280497409", false, "e00e74de-0a3b-4d1a-8e70-0cf07feecaa5", false, "Ryan.Ahmed92cc@example.com" },
                    { "409c5be3-ed6b-11ed-a6f1-105badc84798", 0, "a7c0ee55-6039-4850-b09f-f1f4fbf59316", "Jika.Yakon99b9@example.com", true, "Jika", "Yakon99b9", false, null, "JIKA.YAKON99B9@EXAMPLE.COM", "JIKA.YAKON99B9@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHKWHIF5ZNDQP7SQdj1sQPbvNRjyIUWVR89DGwpA9U12oduvzd8mQUw8RSnh8sgmHQ==", "01264045710", false, "f52077fb-00d7-48c4-ad1c-c995c9f3500a", false, "Jika.Yakon99b9@example.com" },
                    { "409c5be5-ed6b-11ed-b9bc-105badc84798", 0, "4ff22fda-4670-4ed8-a867-1cc1e6c56501", "Salim.Barrab361@example.com", true, "Salim", "Barrab361", false, null, "SALIM.BARRAB361@EXAMPLE.COM", "SALIM.BARRAB361@EXAMPLE.COM", "AQAAAAEAACcQAAAAEA+3TUyPqg+A0eMJE0vU4v2ABYfF5QvxcRkfLnyeT1rDVXBIvd7N9TpZ4+K97+nL5Q==", "01249320959", false, "8aa6b978-7f16-482f-8785-26b487026980", false, "Salim.Barrab361@example.com" },
                    { "409c5be7-ed6b-11ed-a4c2-105badc84798", 0, "307b0e15-229a-4c0a-ba91-69e2949fcf4e", "Sajid.Ghanemb2c7@example.com", true, "Sajid", "Ghanemb2c7", false, null, "SAJID.GHANEMB2C7@EXAMPLE.COM", "SAJID.GHANEMB2C7@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPcHnLCpxKeuMv2jkHFrsLZHDvSauob4F8sh53zLZQjvGi4cAju8QUHi4Tb06sG+qw==", "01277246579", false, "5f6c9799-0b69-4ce8-95ac-5ce925ec92da", false, "Sajid.Ghanemb2c7@example.com" },
                    { "409c5be9-ed6b-11ed-84f0-105badc84798", 0, "634bafd2-2b84-4c97-be49-8e2c17e3dd87", "Abi.Naharbab5@example.com", true, "Abi", "Naharbab5", false, null, "ABI.NAHARBAB5@EXAMPLE.COM", "ABI.NAHARBAB5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIQ6aignLzYpkjcp/tYOp2DLZF0+2u/xOb7GKU6TqOQfCZxg1U+KxDQSpsE8tdVP5g==", "01229234023", false, "69117728-cfc4-4adf-beb2-e7d499392b5d", false, "Abi.Naharbab5@example.com" },
                    { "409c5beb-ed6b-11ed-9119-105badc84798", 0, "848c7d16-bc84-4619-86d5-41e5aaf84fef", "Sheikhy.Bahib9c1@example.com", true, "Sheikhy", "Bahib9c1", false, null, "SHEIKHY.BAHIB9C1@EXAMPLE.COM", "SHEIKHY.BAHIB9C1@EXAMPLE.COM", "AQAAAAEAACcQAAAAED5ozSaxQ3VX2AX5NwSvC/EevB35wlcSr8mQLdr+ylAtEvZihHoa6Tgz+0qw5jCBog==", "01253380211", false, "52932446-aa38-47de-bffd-a103d1af9e0e", false, "Sheikhy.Bahib9c1@example.com" },
                    { "409c5bed-ed6b-11ed-b13d-105badc84798", 0, "1c828751-3d0a-4ec2-84df-42d68d459833", "Russell.Noor98e2@example.com", true, "Russell", "Noor98e2", false, null, "RUSSELL.NOOR98E2@EXAMPLE.COM", "RUSSELL.NOOR98E2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAprZNRulCeJdr4ESYsSnMrSnhzhFMYgpefEM86HFAgYYNq9gQy/575uk+UbvqYafA==", "01270799028", false, "f832563d-1710-44f6-bc8d-ff0dd35a7251", false, "Russell.Noor98e2@example.com" },
                    { "409c5bef-ed6b-11ed-a904-105badc84798", 0, "c8ced7eb-f1a9-463d-8d47-55db392284ef", "Kamel.Turkiac4a@example.com", true, "Kamel", "Turkiac4a", false, null, "KAMEL.TURKIAC4A@EXAMPLE.COM", "KAMEL.TURKIAC4A@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOuey4XAz9KizyxjKFzb5c5G2wTydsNBfFFU3btarTlPcOsnZlWX1Dw0jCQJp7Vthg==", "01241657516", false, "c93cd6be-f1cf-493b-a464-182bd63da076", false, "Kamel.Turkiac4a@example.com" },
                    { "409c5bf1-ed6b-11ed-88f4-105badc84798", 0, "049459fd-adaa-4ccd-8c83-fdc270f9e7f9", "Nahar.Ghanemae00@example.com", true, "Nahar", "Ghanemae00", false, null, "NAHAR.GHANEMAE00@EXAMPLE.COM", "NAHAR.GHANEMAE00@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIcVT/+X7meNTHZieMKGDESJfhftCuDRtgDqD8SitJ2g6LkgSXJSrwF7gGbWvgJpJg==", "01298809343", false, "97e5bd8c-83b5-40e8-88e4-7c132b1b2aad", false, "Nahar.Ghanemae00@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "409c5bf3-ed6b-11ed-b6f9-105badc84798", 0, "7a34b64b-98ca-49a1-8123-1c909ebec392", "Jawad.Hosni8716@example.com", true, "Jawad", "Hosni8716", false, null, "JAWAD.HOSNI8716@EXAMPLE.COM", "JAWAD.HOSNI8716@EXAMPLE.COM", "AQAAAAEAACcQAAAAEApxCGkSDtg1oKy2RmTY5VasjGiAHSWnG3n60UKjtMw/I5oG5zWbGGnt0xMW+5YRDw==", "01234781463", false, "26f42851-919b-48c6-bfdf-b979107ade2e", false, "Jawad.Hosni8716@example.com" },
                    { "409c5bf5-ed6b-11ed-b0e0-105badc84798", 0, "fcfecd08-eeea-4c61-8cf6-402ae51c1a34", "Zaki.Maher89ed@example.com", true, "Zaki", "Maher89ed", false, null, "ZAKI.MAHER89ED@EXAMPLE.COM", "ZAKI.MAHER89ED@EXAMPLE.COM", "AQAAAAEAACcQAAAAELiDjxY9C8LADao7IlvN7EglVy5BUh2W+ICsb6gRUo5TJ/JKsIxuSU1F1a3IhTlPhg==", "01218202776", false, "6d9fa076-cff1-422c-98cf-327f21978eb5", false, "Zaki.Maher89ed@example.com" },
                    { "409d97e6-ed6b-11ed-8b4d-105badc84798", 0, "dfd25f2f-3d08-4e2b-b1a5-8288b0eaf5de", "Ramzy.Sadenb6a1@example.com", true, "Ramzy", "Sadenb6a1", false, null, "RAMZY.SADENB6A1@EXAMPLE.COM", "RAMZY.SADENB6A1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEId4tFxeAs+goekhBghK4v1fPIuISQydoHcqvsBXi7GZhKNAB9r0FFihSr7HVZzXjA==", "01241175282", false, "1e41f1a8-9f24-459f-b720-04b54d1c373a", false, "Ramzy.Sadenb6a1@example.com" },
                    { "409d97e8-ed6b-11ed-94e7-105badc84798", 0, "e51c024c-3f1d-4d0e-866a-09f3e63985fe", "Basem.Ryan8fc1@example.com", true, "Basem", "Ryan8fc1", false, null, "BASEM.RYAN8FC1@EXAMPLE.COM", "BASEM.RYAN8FC1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGF6wNplRNqgLwXMFzsqSNTxh811qZiXGcatckac9GH9I5jzcFaVBr2m3qaZWtrlFw==", "01250561427", false, "0c60456b-21ac-4823-a4dd-001f26d9ffcc", false, "Basem.Ryan8fc1@example.com" },
                    { "409d97ea-ed6b-11ed-8bcf-105badc84798", 0, "b17b68f4-209b-4a99-a159-a4947c19b4ad", "Yunus.Latfi8cca@example.com", true, "Yunus", "Latfi8cca", false, null, "YUNUS.LATFI8CCA@EXAMPLE.COM", "YUNUS.LATFI8CCA@EXAMPLE.COM", "AQAAAAEAACcQAAAAELwHU8meWy2NB8OtHiCqI/+h5RQRo3f9B/d892Xirzj4EDtJyDJieUHuD9cIwf/gvw==", "01249864317", false, "8126c367-063e-4d92-9ddf-3636f1c5d3e4", false, "Yunus.Latfi8cca@example.com" },
                    { "409d97ec-ed6b-11ed-b463-105badc84798", 0, "544dd6d7-d3f1-4eb7-8c8d-a2700f47b5fb", "Moses.Idrisb202@example.com", true, "Moses", "Idrisb202", false, null, "MOSES.IDRISB202@EXAMPLE.COM", "MOSES.IDRISB202@EXAMPLE.COM", "AQAAAAEAACcQAAAAEInDS6cEBUJgBA8JPRDhMCXbiI6P7BzNjyD6YQN+9SK9v2OarGFgvglKU/oOOgC3sQ==", "01230711192", false, "c7d96c11-c185-4ca4-99de-4e823b933936", false, "Moses.Idrisb202@example.com" },
                    { "409d97ee-ed6b-11ed-bbdf-105badc84798", 0, "511cb285-1f5f-469f-9713-f90dccfd0584", "Sheikhy.Ahmedb0a5@example.com", true, "Sheikhy", "Ahmedb0a5", false, null, "SHEIKHY.AHMEDB0A5@EXAMPLE.COM", "SHEIKHY.AHMEDB0A5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMgSXgn+a5PlIHL62B4sIJIYZwszdOvoPSx7UYM+gWXI25BhCbLESALbd6dlnyfbZg==", "01231051799", false, "7193ef87-d306-4475-a73a-993d08353ac4", false, "Sheikhy.Ahmedb0a5@example.com" },
                    { "409d97f0-ed6b-11ed-90bb-105badc84798", 0, "a003f2a5-b987-4417-8cbb-8ce263773f78", "Kafar.Barra8ef2@example.com", true, "Kafar", "Barra8ef2", false, null, "KAFAR.BARRA8EF2@EXAMPLE.COM", "KAFAR.BARRA8EF2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOaoYe4AAacR/GajT6CLss6GkHWCKEPRmm6RMbValLcwccfWEq8rr2tjdG1yCm7pBQ==", "01239050976", false, "3f773a2b-d033-4d1c-b029-754911f0cd8b", false, "Kafar.Barra8ef2@example.com" },
                    { "409d97f2-ed6b-11ed-a6cf-105badc84798", 0, "68bf69e6-a700-44f9-b4b9-9f1821c1a0c6", "Hamaki.Fahedadad@example.com", true, "Hamaki", "Fahedadad", false, null, "HAMAKI.FAHEDADAD@EXAMPLE.COM", "HAMAKI.FAHEDADAD@EXAMPLE.COM", "AQAAAAEAACcQAAAAEN4JQsrB/kEeeCdGlBi1lxe4Qy9FDZQQdg1m4t54DimSlSfa7DiS7LA645O1MsE80w==", "01259193188", false, "1212172c-31a4-42fe-8ce6-1b6e5328dcd4", false, "Hamaki.Fahedadad@example.com" },
                    { "409d97f4-ed6b-11ed-bb0c-105badc84798", 0, "e402228f-c157-4668-89e6-752fa6cae8ae", "Hilal.Yamen95c6@example.com", true, "Hilal", "Yamen95c6", false, null, "HILAL.YAMEN95C6@EXAMPLE.COM", "HILAL.YAMEN95C6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJNR6oj3BvXqnR91qxJf6o6FHtYvy0PazEa1TJEO0eZ7fde/R98Z0YPtbwQ7af+o/g==", "01242866984", false, "7360c397-5b60-4bd2-8b7c-4bca6f144ba9", false, "Hilal.Yamen95c6@example.com" },
                    { "409d97f6-ed6b-11ed-a3b6-105badc84798", 0, "fa437701-02c8-4ca7-b1dd-ceb9607196e1", "Hilali.Saree8dd1@example.com", true, "Hilali", "Saree8dd1", false, null, "HILALI.SAREE8DD1@EXAMPLE.COM", "HILALI.SAREE8DD1@EXAMPLE.COM", "AQAAAAEAACcQAAAAENLHW9aOmi7uFSenGvUrIl9s+CRr57KNlEntNF134JjDb7N2DS9tA57ty5O9bbnGEQ==", "01223988031", false, "3fd8771b-a4a5-406f-9314-80d4b8498f52", false, "Hilali.Saree8dd1@example.com" },
                    { "409d97f8-ed6b-11ed-9814-105badc84798", 0, "35b67b10-548b-4c6e-a7b0-67975cd8ec83", "Idris.Radwan8d0d@example.com", true, "Idris", "Radwan8d0d", false, null, "IDRIS.RADWAN8D0D@EXAMPLE.COM", "IDRIS.RADWAN8D0D@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHzmLkrn9sXK+V5wxEkeDjr1Kd5zdkIuf5NRBKrkVL6K2N1mdKbd8r861TAflKPBFA==", "01271365326", false, "e16edafd-c81c-4453-8afc-fefa0c7ac555", false, "Idris.Radwan8d0d@example.com" },
                    { "409d97fa-ed6b-11ed-962d-105badc84798", 0, "cb44a586-90d1-4b16-b519-ee03a0ddb27c", "Shehabi.Saden97b5@example.com", true, "Shehabi", "Saden97b5", false, null, "SHEHABI.SADEN97B5@EXAMPLE.COM", "SHEHABI.SADEN97B5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEN2IThArESBXqaWROYF/uTgt+1wqhjH20V4Yk3zOK0ODGd0Wo9SWQUQsFEQbkQDMww==", "01273988971", false, "a2833b91-ee2c-47c7-859a-99a879b07fa9", false, "Shehabi.Saden97b5@example.com" },
                    { "409d97fc-ed6b-11ed-aad6-105badc84798", 0, "165fca54-32b2-4c05-9a6c-c964cb18ddb9", "Wael.Hilal86a3@example.com", true, "Wael", "Hilal86a3", false, null, "WAEL.HILAL86A3@EXAMPLE.COM", "WAEL.HILAL86A3@EXAMPLE.COM", "AQAAAAEAACcQAAAAENMYz9FdE9CS9/UMdpYZ1QtDkBXj67cpP7Wppn6cl1YMFmC8e/sWC0r7f3EAu30T1g==", "01251588288", false, "99cbfe1e-5007-41d8-94a8-db70a582e00b", false, "Wael.Hilal86a3@example.com" },
                    { "409d97fe-ed6b-11ed-9246-105badc84798", 0, "1816f5be-5989-47b2-be52-c2224a90c753", "Baqi.Medhatbcea@example.com", true, "Baqi", "Medhatbcea", false, null, "BAQI.MEDHATBCEA@EXAMPLE.COM", "BAQI.MEDHATBCEA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBF5WyU4v9NcFLFktJd4GJGqg5QeKUViFw0BFpSoMwpT8mRcuip4y0uvtgxdliaqog==", "01257768133", false, "2d6963b7-cc38-4448-9cb5-a7f7a0f8c948", false, "Baqi.Medhatbcea@example.com" },
                    { "409d9800-ed6b-11ed-a52b-105badc84798", 0, "a1246137-8bc1-4045-9175-65992a459163", "Adli.Mahmoud846c@example.com", true, "Adli", "Mahmoud846c", false, null, "ADLI.MAHMOUD846C@EXAMPLE.COM", "ADLI.MAHMOUD846C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIOYTAK7dZLweQsCBxHfG3/tMhhJ19B8p57JVm17OBovkBd4bSIXY7WdKEizfihl7A==", "01217209345", false, "9e2b2ac6-2b7b-4b4c-a3c4-fc41fc5dbf57", false, "Adli.Mahmoud846c@example.com" },
                    { "409d9802-ed6b-11ed-bc09-105badc84798", 0, "82cb7a19-2369-4f24-8b20-b034589dfeb8", "Yusuf.Asima639@example.com", true, "Yusuf", "Asima639", false, null, "YUSUF.ASIMA639@EXAMPLE.COM", "YUSUF.ASIMA639@EXAMPLE.COM", "AQAAAAEAACcQAAAAEALQ1Iv6xodKrQ+Lncc/6DrGRFpB7UJhyuSd1tAQ8qCU5uMd/E+8mHkeKt8bG2omdA==", "01296814946", false, "0cd53a91-cee9-4426-942a-ef2c31961aaf", false, "Yusuf.Asima639@example.com" },
                    { "409d9804-ed6b-11ed-acac-105badc84798", 0, "5b67db3c-c155-4f4f-8162-a8ada91b3e73", "Sheila.Horr81d8@example.com", true, "Sheila", "Horr81d8", false, null, "SHEILA.HORR81D8@EXAMPLE.COM", "SHEILA.HORR81D8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIvzJSS/PovAsmDCfWqppIcouwnB4zSS0r9+uLn5apK/m9351FXvvdPsCVGB6wZ83w==", "01292085322", false, "f8b74964-a426-4a2e-aecc-33185ca610a8", false, "Sheila.Horr81d8@example.com" },
                    { "409d9806-ed6b-11ed-bd30-105badc84798", 0, "ca7406a8-f2bc-4436-879e-0e472b076173", "Hamza.Horr8273@example.com", true, "Hamza", "Horr8273", false, null, "HAMZA.HORR8273@EXAMPLE.COM", "HAMZA.HORR8273@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFvPecy/+zw9Z+/tidgC3dOGDQjWRr86QCDiHqHS0+QbKerAnGuyCcqDeGF/k4et1A==", "01228938716", false, "314a4f54-bb44-4e05-ace9-7e9b6a518418", false, "Hamza.Horr8273@example.com" },
                    { "409d9808-ed6b-11ed-ad60-105badc84798", 0, "06ba2f7e-060c-4cf2-8792-cfa81fc7599c", "Hamaqy.Kamel9d6c@example.com", true, "Hamaqy", "Kamel9d6c", false, null, "HAMAQY.KAMEL9D6C@EXAMPLE.COM", "HAMAQY.KAMEL9D6C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBqeKNhHMUwFQDXB4UODFXwYlcqph+iGGdoqCjJasexky2U3/Qm7kVqyKD/ZrK4oVQ==", "01299940571", false, "47b968ee-f41e-4f0a-bb8c-1fd007001df0", false, "Hamaqy.Kamel9d6c@example.com" },
                    { "409d980a-ed6b-11ed-8f53-105badc84798", 0, "fa6f1753-fe99-4098-9d1f-27efe87daa5c", "Sameh.Bacari9f4c@example.com", true, "Sameh", "Bacari9f4c", false, null, "SAMEH.BACARI9F4C@EXAMPLE.COM", "SAMEH.BACARI9F4C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMqrJgGy05WqHcn8flQa3MICK6KHS1IVVQx+sTr4nSkngA8OLYhZCUay2kRaCRSpZA==", "01236833834", false, "cd5f0b98-9ae7-4e34-ae9d-0d42d4b5f5ab", false, "Sameh.Bacari9f4c@example.com" },
                    { "409d980c-ed6b-11ed-ab6a-105badc84798", 0, "fc35aebb-e0bd-4dce-8c97-7c6f977d1b7c", "Zachariah.Yusufbeab@example.com", true, "Zachariah", "Yusufbeab", false, null, "ZACHARIAH.YUSUFBEAB@EXAMPLE.COM", "ZACHARIAH.YUSUFBEAB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGilYyY8OEM7oRCCm7rNUFl7fvnpS4JV/uPJ6KIaqOpElWXolZlfU876PQZjOU0OBA==", "01229346313", false, "11d10fab-1108-4074-a4ad-de6d0d08fa5a", false, "Zachariah.Yusufbeab@example.com" },
                    { "409d980e-ed6b-11ed-a002-105badc84798", 0, "9ba3b2d5-dbfb-4b6e-b050-314fc10039be", "Russell.Fadiba6b@example.com", true, "Russell", "Fadiba6b", false, null, "RUSSELL.FADIBA6B@EXAMPLE.COM", "RUSSELL.FADIBA6B@EXAMPLE.COM", "AQAAAAEAACcQAAAAELleSvqUYWcAuOU3LyNLDbbe9Nh7DfmIyYCtiPi8iIL9TqyGeEZGxAs/9puo2QlnxA==", "01258205230", false, "56494424-3cf9-4795-8a65-8afbe66cbd6b", false, "Russell.Fadiba6b@example.com" },
                    { "409d9810-ed6b-11ed-8ef2-105badc84798", 0, "31ff65a8-d387-44d3-8d4c-18cc4f3158fe", "Marawan.Hamaki922c@example.com", true, "Marawan", "Hamaki922c", false, null, "MARAWAN.HAMAKI922C@EXAMPLE.COM", "MARAWAN.HAMAKI922C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHjfsVh2QLgkjOCHt8p4f8zkFg+4PemKfj2Dmwr5rwZjiLCGDXMqWWDOcq1k6NGyLw==", "01226919350", false, "0529f032-6cd7-4540-bbce-73aeb057d253", false, "Marawan.Hamaki922c@example.com" },
                    { "409d9812-ed6b-11ed-9c48-105badc84798", 0, "a9d45465-c25b-45e0-a8a1-047a448dcd23", "Halsi.Yisria65f@example.com", true, "Halsi", "Yisria65f", false, null, "HALSI.YISRIA65F@EXAMPLE.COM", "HALSI.YISRIA65F@EXAMPLE.COM", "AQAAAAEAACcQAAAAENyuEWliSHo6FUob5e8E77BKk7va82jX1Ld5ECUQIrejvAhItD3xPCNmQjAmLKlYGA==", "01270619764", false, "900b89c5-7216-49ad-99ab-3144bbc84481", false, "Halsi.Yisria65f@example.com" },
                    { "409d9814-ed6b-11ed-b1a5-105badc84798", 0, "1d4f823b-2806-4051-87d0-626ff7884efe", "Ghaith.Saber952b@example.com", true, "Ghaith", "Saber952b", false, null, "GHAITH.SABER952B@EXAMPLE.COM", "GHAITH.SABER952B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBNK0GtZP8KPW6U1hjLx/tDrEeSKQR+e2X1h/4zcYfDk9BAKG429mUDUp0+ZJfQWbw==", "01252978322", false, "bb501a3d-4097-4b08-8f0e-5726d4465dd7", false, "Ghaith.Saber952b@example.com" },
                    { "409d9816-ed6b-11ed-a024-105badc84798", 0, "50af0e42-3ab2-4d57-a006-7d754d6363ad", "Ramzy.Sheikhy9b83@example.com", true, "Ramzy", "Sheikhy9b83", false, null, "RAMZY.SHEIKHY9B83@EXAMPLE.COM", "RAMZY.SHEIKHY9B83@EXAMPLE.COM", "AQAAAAEAACcQAAAAEO+wrRm20p8ambi8G5RAfKzazcfh22XGaqfTS+XcogG1rN0viyzFN05ZHB/O+9K4pQ==", "01214168755", false, "2493c522-02d9-4523-80f0-c75c37b8643f", false, "Ramzy.Sheikhy9b83@example.com" },
                    { "409d9818-ed6b-11ed-a744-105badc84798", 0, "5f295bf3-9415-43d6-a23c-90d627d6689a", "Loay.Zaki8b60@example.com", true, "Loay", "Zaki8b60", false, null, "LOAY.ZAKI8B60@EXAMPLE.COM", "LOAY.ZAKI8B60@EXAMPLE.COM", "AQAAAAEAACcQAAAAECeBcywOdXeLeSNP8VSI1w20QboVan/iCgt95M6IYzK5G5hradsS8FhaGqqCtBtKVQ==", "01235082209", false, "b6a55c7a-cdbb-4741-b32d-ae2569faadda", false, "Loay.Zaki8b60@example.com" },
                    { "409d981a-ed6b-11ed-8cc2-105badc84798", 0, "c0032172-b725-4276-b659-a5627efc7d38", "Sharm.Saber98d6@example.com", true, "Sharm", "Saber98d6", false, null, "SHARM.SABER98D6@EXAMPLE.COM", "SHARM.SABER98D6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAZb6XoZDVypNxUrPViwu2XfF+vvjYWsQFozQSbi1p3dfnojzjBfYWetMR2qWkmG1w==", "01286278436", false, "9fb8dc07-88d5-422d-90d0-dd75a89e01d6", false, "Sharm.Saber98d6@example.com" },
                    { "409d981c-ed6b-11ed-a136-105badc84798", 0, "4b005904-b105-44c2-adfd-401bd2c90880", "Faisal.Hilal8943@example.com", true, "Faisal", "Hilal8943", false, null, "FAISAL.HILAL8943@EXAMPLE.COM", "FAISAL.HILAL8943@EXAMPLE.COM", "AQAAAAEAACcQAAAAECtSViL+zP7DKOU1P4B3haa/5DuqkLxrgO8p1So8wnYBqoXQF0k+1cKe76dmJLn8EA==", "01240227176", false, "d4eabc44-6e14-4636-99da-0c36b474e2dc", false, "Faisal.Hilal8943@example.com" },
                    { "409d981e-ed6b-11ed-b364-105badc84798", 0, "1c9c7559-821e-4489-bec1-3c9ef72a8821", "Dagher.Dagher9fe6@example.com", true, "Dagher", "Dagher9fe6", false, null, "DAGHER.DAGHER9FE6@EXAMPLE.COM", "DAGHER.DAGHER9FE6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBPzNPXJMbWpwf3+JqFtD0Y+A1CtOyPvWbmbbE8siLoJRqSmNsXwjgWW4piCMAKVYg==", "01217001819", false, "6e0eeaae-9e18-4d0b-89d8-1e17d05c330f", false, "Dagher.Dagher9fe6@example.com" },
                    { "409d9820-ed6b-11ed-b8a4-105badc84798", 0, "eefab201-bbe1-4e7f-8ea4-4942ae52367e", "Kahter.Kafarb2a1@example.com", true, "Kahter", "Kafarb2a1", false, null, "KAHTER.KAFARB2A1@EXAMPLE.COM", "KAHTER.KAFARB2A1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBa0A6vcOhpxDKICX5Cfv8eKxTPfi2Z3nY/9smZofGfLLPu0KC96EgS/uRI6iykxpw==", "01271704772", false, "11adf757-1f3f-4d86-afe7-04ce0c0753ab", false, "Kahter.Kafarb2a1@example.com" },
                    { "409d9822-ed6b-11ed-b007-105badc84798", 0, "9ee476c0-61ea-47c0-8a4b-3c918200851e", "Russell.Barra8660@example.com", true, "Russell", "Barra8660", false, null, "RUSSELL.BARRA8660@EXAMPLE.COM", "RUSSELL.BARRA8660@EXAMPLE.COM", "AQAAAAEAACcQAAAAELy7gpySAnVL/Wz1GWmj58ZCyyC7Qc1B1VG/7pqzWGa9BkC4jV05OCT5wSdtWc63xw==", "01278117140", false, "ae490915-19ff-4ac6-bb80-176176916d3c", false, "Russell.Barra8660@example.com" },
                    { "409d9824-ed6b-11ed-b245-105badc84798", 0, "fd33e7c2-ea07-47d9-938a-4818e95d9e16", "Samher.Sharmb774@example.com", true, "Samher", "Sharmb774", false, null, "SAMHER.SHARMB774@EXAMPLE.COM", "SAMHER.SHARMB774@EXAMPLE.COM", "AQAAAAEAACcQAAAAEE9F+QwxLGoozm8Jku4YmwsCH2EwjDch2Wio03Q/xSdWI2skJYJqprB9DaI3YXsH8A==", "01253529119", false, "24391f0d-56fb-41d2-a4fc-8d5f2c6f3378", false, "Samher.Sharmb774@example.com" },
                    { "409d9826-ed6b-11ed-903e-105badc84798", 0, "2bd171c4-52e8-4d79-9318-12d85b1e921e", "Asim.Sadenb632@example.com", true, "Asim", "Sadenb632", false, null, "ASIM.SADENB632@EXAMPLE.COM", "ASIM.SADENB632@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDFdvZ3O7Qh7/uvHi5Ni6m5iw6Ug+OqA0aeNhHvEt87NLI4zZAosYDL5Tovt/PatLw==", "01214486306", false, "387f49dd-1dfb-45fd-bbfb-f83cd0addec4", false, "Asim.Sadenb632@example.com" },
                    { "409d9828-ed6b-11ed-8629-105badc84798", 0, "d07c8480-10ae-4876-b48a-1c39cfff653f", "Halsi.Maherbb85@example.com", true, "Halsi", "Maherbb85", false, null, "HALSI.MAHERBB85@EXAMPLE.COM", "HALSI.MAHERBB85@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJrnEVgvydg93kB0PQw8SsssRb3gwR4dT5bwVsI25bq6ZqJKrHuGHgBrdvypiPKt5w==", "01287150961", false, "a2605d56-cd41-4770-a4cb-9dd15dd3ab10", false, "Halsi.Maherbb85@example.com" },
                    { "409d982a-ed6b-11ed-b3f7-105badc84798", 0, "b7c20c7d-bb87-4c09-ae46-101ea381ee35", "Jawad.Fahedb924@example.com", true, "Jawad", "Fahedb924", false, null, "JAWAD.FAHEDB924@EXAMPLE.COM", "JAWAD.FAHEDB924@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJ6n6mPqogUwU1sDHJ8YGeEnPoXXKJ+c84A//FtMcT2RtyWXLXY5NruL0x3PeFx8cw==", "01287718327", false, "5ef00917-a530-4369-b426-866ef0f3cfab", false, "Jawad.Fahedb924@example.com" },
                    { "409d982c-ed6b-11ed-9084-105badc84798", 0, "65438aa8-eb54-491c-b0c5-b5d857e00356", "Dagher.Sameh899e@example.com", true, "Dagher", "Sameh899e", false, null, "DAGHER.SAMEH899E@EXAMPLE.COM", "DAGHER.SAMEH899E@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKDrfse+xb+1AsFPkRoUIA5DqIUOJW8mDxmrTJU7Al/XQfdPbJQPd1tEuD+6P4NBow==", "01229621962", false, "598c7794-f4ab-4cff-a3e4-2560f021904f", false, "Dagher.Sameh899e@example.com" },
                    { "409d982e-ed6b-11ed-8e42-105badc84798", 0, "79f50fba-65dc-4e34-bbc1-03380ebd1267", "Fidaa.Faisalaef2@example.com", true, "Fidaa", "Faisalaef2", false, null, "FIDAA.FAISALAEF2@EXAMPLE.COM", "FIDAA.FAISALAEF2@EXAMPLE.COM", "AQAAAAEAACcQAAAAENshrhri6ICivmGR5vYnYj/tWuTeaLPi9ApRPFLy+Z/nfr0Os7rUIiHBwabVstpdlQ==", "01239399918", false, "5a1a0557-0134-4278-a24f-503cab524665", false, "Fidaa.Faisalaef2@example.com" },
                    { "409d9830-ed6b-11ed-abc8-105badc84798", 0, "738317e2-dfd3-4b1b-a435-9641b82e159a", "Yad.Jika853c@example.com", true, "Yad", "Jika853c", false, null, "YAD.JIKA853C@EXAMPLE.COM", "YAD.JIKA853C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGeLrZZSRfzpwelQz6uLdU67fq6RCAHUYQY/cSNVLayHH0lNe9xJGoUo9ZW/850KfA==", "01273014929", false, "029ee6e1-5082-4ac6-8f3d-a24ba46067c7", false, "Yad.Jika853c@example.com" },
                    { "409d9832-ed6b-11ed-8176-105badc84798", 0, "5d0a2dc4-b7ed-40a4-bdb9-a74934490381", "Dagher.Sheilaaa3b@example.com", true, "Dagher", "Sheilaaa3b", false, null, "DAGHER.SHEILAAA3B@EXAMPLE.COM", "DAGHER.SHEILAAA3B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGdrmQv4ubuGha9QZWubWNozm32ucc+A+OwuMLc6zYLUNlBsukOoH/HZdMamGPPhGA==", "01271168271", false, "98a1151b-8663-4152-9142-381cbf529a8b", false, "Dagher.Sheilaaa3b@example.com" },
                    { "409d9834-ed6b-11ed-883a-105badc84798", 0, "b42ac911-c733-4b63-b52c-ae3103b03dc2", "Ghaith.Adela089@example.com", true, "Ghaith", "Adela089", false, null, "GHAITH.ADELA089@EXAMPLE.COM", "GHAITH.ADELA089@EXAMPLE.COM", "AQAAAAEAACcQAAAAECDCXURXO/o8CMzECXeMc9e26QBYZfUEgyZOy7WnTHsg6FAgS6ug79XfQ1ouBFS0vQ==", "01240257375", false, "12d6f038-58a9-4f44-aa06-d982984afd51", false, "Ghaith.Adela089@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "409d9836-ed6b-11ed-8979-105badc84798", 0, "3850e729-5988-4fa5-823d-ee2089564bf6", "Ryan.Ramzybdbf@example.com", true, "Ryan", "Ramzybdbf", false, null, "RYAN.RAMZYBDBF@EXAMPLE.COM", "RYAN.RAMZYBDBF@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPa0ZJKwv3R4R+YA9JuVGzvuc8B1tNMCe3CaWkUI8DUhJNi7eQMtBFnnCIvhNSNkNw==", "01282509863", false, "4d2e73a7-384a-4453-9438-efd365f287cb", false, "Ryan.Ramzybdbf@example.com" },
                    { "409d9838-ed6b-11ed-ac79-105badc84798", 0, "0988981d-e243-4606-b2b3-94405d78c6a3", "Bacari.Firasa5e7@example.com", true, "Bacari", "Firasa5e7", false, null, "BACARI.FIRASA5E7@EXAMPLE.COM", "BACARI.FIRASA5E7@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGOMH7awLNHPC0zWx0e7fx8JxCMIjBUdDfKQHWh9LoXtBOkkjlerocq7tO+ldlOU1w==", "01265289814", false, "91ce6980-2d3d-428d-8d86-dfee36e1e625", false, "Bacari.Firasa5e7@example.com" },
                    { "409d983a-ed6b-11ed-890c-105badc84798", 0, "773c518a-8af4-4aa3-91a1-b6165627a2a5", "Fares.Radwana0b0@example.com", true, "Fares", "Radwana0b0", false, null, "FARES.RADWANA0B0@EXAMPLE.COM", "FARES.RADWANA0B0@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAneeOy7BXVaZq5n23An/WCeFmDXulQl4XmLY3wYdX/V/LcGpZ4gwHO88+qV2/qM0A==", "01231166131", false, "ef6bf2d6-ef19-4b22-9c62-da2a8d880fae", false, "Fares.Radwana0b0@example.com" },
                    { "4A8CA884-C093-43C4-A019-EE6D804BF85E", 0, "564cf79f-2dff-419e-86c4-b4a922efa6b4", "mosad53@gmail.com", true, "Mossad", "Gomaa", false, null, "MOSAD53@GMAIL.COM", "MOSAD53@GMAIL.COM", "AQAAAAEAACcQAAAAEC8cKVhiXQpGAeWFj/TE6WSEcnd6jY8VPJBGEzMcBOrmQA/pB2XojSFF2uTSZ8j2lA==", "+201211820083", false, "7ecab8bc-7c27-4224-980b-f67da3bd256b", false, "mosad53@gmail.com" },
                    { "5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5", 0, "e34cdd5d-b648-4093-af98-87d078265877", "mosad5@gmail.com", true, "Mossad", "Ahmed", false, null, "MOSAD5@GMAIL.COM", "MOSAD5@GMAIL.COM", "AQAAAAEAACcQAAAAEDhRaz1PN1KGLDCifG12J5moNinPd/Hd6CbC4BGiPLKWrCqUNrJ2c9uo103nSOvSHg==", "+201211820083", false, "fbccd10a-6d12-40a3-a553-3977a41e767b", false, "mosad5@gmail.com" },
                    { "69E0E900-6DE2-45E8-85CA-583B32C5C5AA", 0, "1559b041-bf8b-4e54-b54e-35ae6304bf84", "jane.doe@example.com", true, "Jane", "Doe", false, null, "JANE.DOE@EXAMPLE.COM", "JANE.DOE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMgNSOoK5BJ8u0gyZijOYjt7BTh89x0WA2Ffm4JiVpqcxBssnBlQ5o0OedGaUJ+1Qw==", "01203993009", false, "eeb28f2b-1b0b-4f48-b330-0b83424ac8e0", false, "jane.doe@example.com" },
                    { "706870e9-e373-11ed-b719-105badc84798", 0, "9f1375cc-12ac-45f5-90aa-82a7d2e95672", "Mo.Zi@example.com", true, "Mo", "Zi", false, null, "MO.ZI@EXAMPLE.COM", "MO.ZI@EXAMPLE.COM", "AQAAAAEAACcQAAAAEM/QuYMYUiffqjvJA7M/U0j/ZXUYigv6o2mQkJpsxWn6e4Iqb9m3XSa6FjAgFF4bLw==", "01279426209", false, "71ab429d-9c15-4f98-be80-662260253459", false, "Mo.Zi@example.com" },
                    { "706b3236-e373-11ed-a003-105badc84798", 0, "8bc60e4e-6769-4dde-9d75-aecbc8c3b24e", "Majdi.Fares@example.com", true, "Majdi", "Fares", false, null, "MAJDI.FARES@EXAMPLE.COM", "MAJDI.FARES@EXAMPLE.COM", "AQAAAAEAACcQAAAAELmKrxpUbyg9GMjwWMfFR8MEk2EcNfxS5xWDFVqCZ5mQhHtccM9r6wrU7uQ5jOOPsQ==", "01270867190", false, "bc0a91e3-d21c-4476-bd84-f304ac90e8ed", false, "Majdi.Fares@example.com" },
                    { "706b3237-e373-11ed-988f-105badc84798", 0, "8c8cc9d9-f172-473d-9b4a-d546da0029db", "Hamza.Yisri@example.com", true, "Hamza", "Yisri", false, null, "HAMZA.YISRI@EXAMPLE.COM", "HAMZA.YISRI@EXAMPLE.COM", "AQAAAAEAACcQAAAAEL8U8mVx8jx/1kM6shCTmLCYW9eMkQNX2sL8eSxTpHKAbZzYn91reqT7iJjKdqkg7g==", "01256543256", false, "661a2118-9382-4a78-8761-6b68acbf3e83", false, "Hamza.Yisri@example.com" },
                    { "7A369173-1E2F-491F-874F-7B324C034BC2", 0, "47007ebb-a926-46f2-974c-3f641a18e947", "bob.smith@example.com", true, "Bob", "Smith", false, null, "BOB.SMITH@EXAMPLE.COM", "BOB.SMITH@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHiza2Kc0phCiX+DAe/shFWmZGXu00hcvQnn+zNGtvZEJ+qp6sWeLWQOFuUIkLL+ow==", "011234356789", false, "61698448-073b-4f9b-a504-767638fb2901", false, "bob.smith@example.com" },
                    { "99328045-8ECF-40A1-9F0B-0DEA6398F09A", 0, "6386721e-fb6f-495c-90ce-9d87e8f1476a", "john.doe@example.com", true, "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHx4KqwIEswDAOozZ/PuX+ZVgefQx/fhzc7XDAbSll2YhHCWOXymsjGl92l4UDPLBQ==", "01239931230", false, "e964155d-1f28-46c5-86d4-d361bf8a6de3", false, "john.doe@example.com" },
                    { "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2", 0, "61c1ffbf-33cc-429e-a5a5-f0e801705eeb", "sara.jones@example.com", true, "Sara", "Jones", false, null, "SARA.JONES@EXAMPLE.COM", "SARA.JONES@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOT4AHMMHOpQmeO6HDgry8E0WeHoU7xzMkDNf3n9ng18mjw6G12fVB6sXQBGO50lrQ==", "010765432231", false, "392b7b48-fdb8-454c-9a07-43920af6edd9", false, "sara.jones@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4093fa25-ed6b-11ed-a6df-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4093fa27-ed6b-11ed-8922-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4093fa29-ed6b-11ed-85ba-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4093fa2b-ed6b-11ed-9be9-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4093fa2d-ed6b-11ed-a65f-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676b0-ed6b-11ed-9fd6-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676b2-ed6b-11ed-b62e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676b4-ed6b-11ed-b886-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676b6-ed6b-11ed-b477-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676b8-ed6b-11ed-9c16-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676ba-ed6b-11ed-adbf-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676bc-ed6b-11ed-9b21-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676be-ed6b-11ed-902b-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676c0-ed6b-11ed-a990-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676c2-ed6b-11ed-a696-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676c4-ed6b-11ed-a637-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "40977647-ed6b-11ed-aad8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "40977649-ed6b-11ed-973e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097764b-ed6b-11ed-b259-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097973c-ed6b-11ed-9913-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097973e-ed6b-11ed-929c-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "40979740-ed6b-11ed-8c11-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "40979742-ed6b-11ed-b3de-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "40979744-ed6b-11ed-8abc-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097c4fc-ed6b-11ed-84e8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097c4fe-ed6b-11ed-b56a-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097c500-ed6b-11ed-b1ae-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8e5-ed6b-11ed-8a0f-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8e7-ed6b-11ed-b377-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8e9-ed6b-11ed-83d1-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8eb-ed6b-11ed-8f98-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8ed-ed6b-11ed-9f99-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8ef-ed6b-11ed-8cd4-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8f1-ed6b-11ed-aa86-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8f3-ed6b-11ed-9479-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8f5-ed6b-11ed-aca2-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8f7-ed6b-11ed-98e4-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8f9-ed6b-11ed-8f23-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8fb-ed6b-11ed-b285-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8fd-ed6b-11ed-b6a3-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8ff-ed6b-11ed-85f9-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d901-ed6b-11ed-9297-105badc84798" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d903-ed6b-11ed-855f-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d905-ed6b-11ed-b302-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d907-ed6b-11ed-b6b6-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d909-ed6b-11ed-93d8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d90b-ed6b-11ed-a99b-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d90d-ed6b-11ed-956f-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d90f-ed6b-11ed-a0cc-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d911-ed6b-11ed-b614-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d913-ed6b-11ed-816e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d915-ed6b-11ed-a890-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b15b-ed6b-11ed-9dc2-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b15d-ed6b-11ed-8903-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b15f-ed6b-11ed-a7e2-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b161-ed6b-11ed-b0d0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b163-ed6b-11ed-b901-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b165-ed6b-11ed-a2fd-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b167-ed6b-11ed-9dcf-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b169-ed6b-11ed-9b69-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b16b-ed6b-11ed-bc54-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b16d-ed6b-11ed-abd9-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b16f-ed6b-11ed-ae81-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b171-ed6b-11ed-bd08-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b173-ed6b-11ed-9e0c-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b175-ed6b-11ed-a3d4-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b177-ed6b-11ed-b8db-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b179-ed6b-11ed-acd6-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b17b-ed6b-11ed-bfb2-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b17d-ed6b-11ed-a36b-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b17f-ed6b-11ed-9639-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b181-ed6b-11ed-84ef-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b183-ed6b-11ed-91ba-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b185-ed6b-11ed-a00a-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b187-ed6b-11ed-911e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b189-ed6b-11ed-97ff-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b18b-ed6b-11ed-9c96-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b18d-ed6b-11ed-86a0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b18f-ed6b-11ed-9b38-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b191-ed6b-11ed-87ba-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b193-ed6b-11ed-b6af-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b195-ed6b-11ed-a317-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b197-ed6b-11ed-a380-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b199-ed6b-11ed-bf11-105badc84798" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b19b-ed6b-11ed-9acc-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b19d-ed6b-11ed-9edb-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b19f-ed6b-11ed-8419-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b1a1-ed6b-11ed-abac-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b1a3-ed6b-11ed-a583-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b1a5-ed6b-11ed-bf0d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b1a7-ed6b-11ed-bd68-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9d3-ed6b-11ed-b4e8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9d5-ed6b-11ed-8061-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9d7-ed6b-11ed-976d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9d9-ed6b-11ed-bca8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9db-ed6b-11ed-9009-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9dd-ed6b-11ed-8e81-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9df-ed6b-11ed-bb40-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9e1-ed6b-11ed-b492-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9e3-ed6b-11ed-92d1-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9e5-ed6b-11ed-b38a-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9e7-ed6b-11ed-9432-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9e9-ed6b-11ed-af1e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9eb-ed6b-11ed-8d45-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9ed-ed6b-11ed-8755-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9ef-ed6b-11ed-a4a1-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9f1-ed6b-11ed-b017-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9f3-ed6b-11ed-92c8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9f5-ed6b-11ed-9bbb-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9f7-ed6b-11ed-aa9d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9f9-ed6b-11ed-8af4-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9fb-ed6b-11ed-88c6-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9fd-ed6b-11ed-a891-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9ff-ed6b-11ed-a802-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea01-ed6b-11ed-a7d5-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea03-ed6b-11ed-9ac8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea05-ed6b-11ed-b96b-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea07-ed6b-11ed-9c9b-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea09-ed6b-11ed-9690-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea0b-ed6b-11ed-b0ef-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea0d-ed6b-11ed-aa2b-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea0f-ed6b-11ed-9d4e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea11-ed6b-11ed-8a4f-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea13-ed6b-11ed-839a-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea15-ed6b-11ed-8dbe-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea17-ed6b-11ed-bb52-105badc84798" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea19-ed6b-11ed-85c8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea1b-ed6b-11ed-b4c0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea1d-ed6b-11ed-a4c6-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea1f-ed6b-11ed-9f62-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2251-ed6b-11ed-9a82-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2253-ed6b-11ed-b650-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2255-ed6b-11ed-87ce-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2257-ed6b-11ed-8f44-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2259-ed6b-11ed-ac78-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b225b-ed6b-11ed-bf67-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b225d-ed6b-11ed-8369-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b225f-ed6b-11ed-8d6a-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2261-ed6b-11ed-b7f8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2263-ed6b-11ed-93b0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2265-ed6b-11ed-8a51-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2267-ed6b-11ed-9ed8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2269-ed6b-11ed-96a1-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b226b-ed6b-11ed-b5d0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b226d-ed6b-11ed-9578-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b226f-ed6b-11ed-af75-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2271-ed6b-11ed-b13a-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2273-ed6b-11ed-984c-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2275-ed6b-11ed-8ea0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2277-ed6b-11ed-a519-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2279-ed6b-11ed-a66d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b227b-ed6b-11ed-a6a6-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b227d-ed6b-11ed-b8fd-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b227f-ed6b-11ed-9609-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2281-ed6b-11ed-968e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2283-ed6b-11ed-90f7-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2285-ed6b-11ed-945d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2287-ed6b-11ed-bdd8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2289-ed6b-11ed-8a33-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b228b-ed6b-11ed-82cb-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b228d-ed6b-11ed-9862-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b228f-ed6b-11ed-bba0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2291-ed6b-11ed-82b0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2293-ed6b-11ed-a281-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2295-ed6b-11ed-a03f-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2297-ed6b-11ed-9620-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2299-ed6b-11ed-8cd7-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b229b-ed6b-11ed-b5e4-105badc84798" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5ba9-ed6b-11ed-a9f0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bab-ed6b-11ed-9ebb-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bad-ed6b-11ed-b06e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5baf-ed6b-11ed-b43f-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bb1-ed6b-11ed-b22e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bb3-ed6b-11ed-8aea-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bb5-ed6b-11ed-81ec-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bb7-ed6b-11ed-a54a-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bb9-ed6b-11ed-a374-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bbb-ed6b-11ed-a145-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bbd-ed6b-11ed-a7f3-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bbf-ed6b-11ed-afcf-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bc1-ed6b-11ed-880d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bc3-ed6b-11ed-b2b0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bc5-ed6b-11ed-9c33-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bc7-ed6b-11ed-a584-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bc9-ed6b-11ed-94df-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bcb-ed6b-11ed-ae48-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bcd-ed6b-11ed-82bc-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bcf-ed6b-11ed-a53b-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bd1-ed6b-11ed-8709-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bd3-ed6b-11ed-b60d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bd5-ed6b-11ed-92ef-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bd7-ed6b-11ed-8e67-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bd9-ed6b-11ed-aac6-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bdb-ed6b-11ed-9c54-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bdd-ed6b-11ed-9d5b-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bdf-ed6b-11ed-8964-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5be1-ed6b-11ed-858f-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5be3-ed6b-11ed-a6f1-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5be5-ed6b-11ed-b9bc-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5be7-ed6b-11ed-a4c2-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5be9-ed6b-11ed-84f0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5beb-ed6b-11ed-9119-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bed-ed6b-11ed-b13d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bef-ed6b-11ed-a904-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bf1-ed6b-11ed-88f4-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bf3-ed6b-11ed-b6f9-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bf5-ed6b-11ed-b0e0-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97e6-ed6b-11ed-8b4d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97e8-ed6b-11ed-94e7-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97ea-ed6b-11ed-8bcf-105badc84798" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97ec-ed6b-11ed-b463-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97ee-ed6b-11ed-bbdf-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97f0-ed6b-11ed-90bb-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97f2-ed6b-11ed-a6cf-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97f4-ed6b-11ed-bb0c-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97f6-ed6b-11ed-a3b6-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97f8-ed6b-11ed-9814-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97fa-ed6b-11ed-962d-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97fc-ed6b-11ed-aad6-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97fe-ed6b-11ed-9246-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9800-ed6b-11ed-a52b-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9802-ed6b-11ed-bc09-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9804-ed6b-11ed-acac-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9806-ed6b-11ed-bd30-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9808-ed6b-11ed-ad60-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d980a-ed6b-11ed-8f53-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d980c-ed6b-11ed-ab6a-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d980e-ed6b-11ed-a002-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9810-ed6b-11ed-8ef2-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9812-ed6b-11ed-9c48-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9814-ed6b-11ed-b1a5-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9816-ed6b-11ed-a024-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9818-ed6b-11ed-a744-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d981a-ed6b-11ed-8cc2-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d981c-ed6b-11ed-a136-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d981e-ed6b-11ed-b364-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9820-ed6b-11ed-b8a4-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9822-ed6b-11ed-b007-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9824-ed6b-11ed-b245-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9826-ed6b-11ed-903e-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9828-ed6b-11ed-8629-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d982a-ed6b-11ed-b3f7-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d982c-ed6b-11ed-9084-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d982e-ed6b-11ed-8e42-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9830-ed6b-11ed-abc8-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9832-ed6b-11ed-8176-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9834-ed6b-11ed-883a-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9836-ed6b-11ed-8979-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9838-ed6b-11ed-ac79-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d983a-ed6b-11ed-890c-105badc84798" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "4A8CA884-C093-43C4-A019-EE6D804BF85E" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "A2523A70-57E3-4B69-A405-F9752517ED62", "69E0E900-6DE2-45E8-85CA-583B32C5C5AA" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706870e9-e373-11ed-b719-105badc84798" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706b3236-e373-11ed-a003-105badc84798" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706b3237-e373-11ed-988f-105badc84798" },
                    { "64F2143D-B896-4355-90D2-AFD22424B234", "7A369173-1E2F-491F-874F-7B324C034BC2" },
                    { "BEA713C7-93D2-4F39-8DC8-18F2F3070779", "99328045-8ECF-40A1-9F0B-0DEA6398F09A" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4093fa25-ed6b-11ed-a6df-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4093fa27-ed6b-11ed-8922-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4093fa29-ed6b-11ed-85ba-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4093fa2b-ed6b-11ed-9be9-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4093fa2d-ed6b-11ed-a65f-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676b0-ed6b-11ed-9fd6-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676b2-ed6b-11ed-b62e-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676b4-ed6b-11ed-b886-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676b6-ed6b-11ed-b477-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676b8-ed6b-11ed-9c16-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676ba-ed6b-11ed-adbf-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676bc-ed6b-11ed-9b21-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676be-ed6b-11ed-902b-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676c0-ed6b-11ed-a990-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676c2-ed6b-11ed-a696-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409676c4-ed6b-11ed-a637-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "40977647-ed6b-11ed-aad8-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "40977649-ed6b-11ed-973e-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097764b-ed6b-11ed-b259-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097973c-ed6b-11ed-9913-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097973e-ed6b-11ed-929c-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "40979740-ed6b-11ed-8c11-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "40979742-ed6b-11ed-b3de-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "40979744-ed6b-11ed-8abc-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097c4fc-ed6b-11ed-84e8-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097c4fe-ed6b-11ed-b56a-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097c500-ed6b-11ed-b1ae-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8e5-ed6b-11ed-8a0f-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8e7-ed6b-11ed-b377-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8e9-ed6b-11ed-83d1-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8eb-ed6b-11ed-8f98-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8ed-ed6b-11ed-9f99-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8ef-ed6b-11ed-8cd4-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8f1-ed6b-11ed-aa86-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8f3-ed6b-11ed-9479-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8f5-ed6b-11ed-aca2-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8f7-ed6b-11ed-98e4-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8f9-ed6b-11ed-8f23-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8fb-ed6b-11ed-b285-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8fd-ed6b-11ed-b6a3-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d8ff-ed6b-11ed-85f9-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d901-ed6b-11ed-9297-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d903-ed6b-11ed-855f-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d905-ed6b-11ed-b302-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d907-ed6b-11ed-b6b6-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d909-ed6b-11ed-93d8-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d90b-ed6b-11ed-a99b-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d90d-ed6b-11ed-956f-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d90f-ed6b-11ed-a0cc-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d911-ed6b-11ed-b614-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d913-ed6b-11ed-816e-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4097d915-ed6b-11ed-a890-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b15b-ed6b-11ed-9dc2-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b15d-ed6b-11ed-8903-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b15f-ed6b-11ed-a7e2-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b161-ed6b-11ed-b0d0-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b163-ed6b-11ed-b901-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b165-ed6b-11ed-a2fd-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b167-ed6b-11ed-9dcf-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b169-ed6b-11ed-9b69-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b16b-ed6b-11ed-bc54-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b16d-ed6b-11ed-abd9-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b16f-ed6b-11ed-ae81-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b171-ed6b-11ed-bd08-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b173-ed6b-11ed-9e0c-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b175-ed6b-11ed-a3d4-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b177-ed6b-11ed-b8db-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b179-ed6b-11ed-acd6-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b17b-ed6b-11ed-bfb2-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b17d-ed6b-11ed-a36b-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b17f-ed6b-11ed-9639-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b181-ed6b-11ed-84ef-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b183-ed6b-11ed-91ba-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b185-ed6b-11ed-a00a-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b187-ed6b-11ed-911e-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b189-ed6b-11ed-97ff-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b18b-ed6b-11ed-9c96-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b18d-ed6b-11ed-86a0-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b18f-ed6b-11ed-9b38-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b191-ed6b-11ed-87ba-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b193-ed6b-11ed-b6af-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b195-ed6b-11ed-a317-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b197-ed6b-11ed-a380-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b199-ed6b-11ed-bf11-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b19b-ed6b-11ed-9acc-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b19d-ed6b-11ed-9edb-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b19f-ed6b-11ed-8419-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b1a1-ed6b-11ed-abac-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b1a3-ed6b-11ed-a583-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b1a5-ed6b-11ed-bf0d-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4098b1a7-ed6b-11ed-bd68-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9d3-ed6b-11ed-b4e8-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9d5-ed6b-11ed-8061-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9d7-ed6b-11ed-976d-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9d9-ed6b-11ed-bca8-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9db-ed6b-11ed-9009-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9dd-ed6b-11ed-8e81-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9df-ed6b-11ed-bb40-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9e1-ed6b-11ed-b492-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9e3-ed6b-11ed-92d1-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9e5-ed6b-11ed-b38a-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9e7-ed6b-11ed-9432-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9e9-ed6b-11ed-af1e-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9eb-ed6b-11ed-8d45-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9ed-ed6b-11ed-8755-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9ef-ed6b-11ed-a4a1-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9f1-ed6b-11ed-b017-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9f3-ed6b-11ed-92c8-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9f5-ed6b-11ed-9bbb-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9f7-ed6b-11ed-aa9d-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9f9-ed6b-11ed-8af4-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9fb-ed6b-11ed-88c6-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9fd-ed6b-11ed-a891-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099e9ff-ed6b-11ed-a802-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea01-ed6b-11ed-a7d5-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea03-ed6b-11ed-9ac8-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea05-ed6b-11ed-b96b-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea07-ed6b-11ed-9c9b-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea09-ed6b-11ed-9690-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea0b-ed6b-11ed-b0ef-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea0d-ed6b-11ed-aa2b-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea0f-ed6b-11ed-9d4e-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea11-ed6b-11ed-8a4f-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea13-ed6b-11ed-839a-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea15-ed6b-11ed-8dbe-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea17-ed6b-11ed-bb52-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea19-ed6b-11ed-85c8-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea1b-ed6b-11ed-b4c0-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea1d-ed6b-11ed-a4c6-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4099ea1f-ed6b-11ed-9f62-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2251-ed6b-11ed-9a82-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2253-ed6b-11ed-b650-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2255-ed6b-11ed-87ce-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2257-ed6b-11ed-8f44-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2259-ed6b-11ed-ac78-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b225b-ed6b-11ed-bf67-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b225d-ed6b-11ed-8369-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b225f-ed6b-11ed-8d6a-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2261-ed6b-11ed-b7f8-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2263-ed6b-11ed-93b0-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2265-ed6b-11ed-8a51-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2267-ed6b-11ed-9ed8-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2269-ed6b-11ed-96a1-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b226b-ed6b-11ed-b5d0-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b226d-ed6b-11ed-9578-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b226f-ed6b-11ed-af75-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2271-ed6b-11ed-b13a-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2273-ed6b-11ed-984c-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2275-ed6b-11ed-8ea0-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2277-ed6b-11ed-a519-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2279-ed6b-11ed-a66d-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b227b-ed6b-11ed-a6a6-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b227d-ed6b-11ed-b8fd-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b227f-ed6b-11ed-9609-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2281-ed6b-11ed-968e-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2283-ed6b-11ed-90f7-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2285-ed6b-11ed-945d-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2287-ed6b-11ed-bdd8-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2289-ed6b-11ed-8a33-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b228b-ed6b-11ed-82cb-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b228d-ed6b-11ed-9862-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b228f-ed6b-11ed-bba0-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2291-ed6b-11ed-82b0-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2293-ed6b-11ed-a281-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2295-ed6b-11ed-a03f-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2297-ed6b-11ed-9620-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b2299-ed6b-11ed-8cd7-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409b229b-ed6b-11ed-b5e4-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5ba9-ed6b-11ed-a9f0-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bab-ed6b-11ed-9ebb-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bad-ed6b-11ed-b06e-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5baf-ed6b-11ed-b43f-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bb1-ed6b-11ed-b22e-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bb3-ed6b-11ed-8aea-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bb5-ed6b-11ed-81ec-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bb7-ed6b-11ed-a54a-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bb9-ed6b-11ed-a374-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bbb-ed6b-11ed-a145-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bbd-ed6b-11ed-a7f3-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bbf-ed6b-11ed-afcf-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bc1-ed6b-11ed-880d-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bc3-ed6b-11ed-b2b0-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bc5-ed6b-11ed-9c33-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bc7-ed6b-11ed-a584-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bc9-ed6b-11ed-94df-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bcb-ed6b-11ed-ae48-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bcd-ed6b-11ed-82bc-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bcf-ed6b-11ed-a53b-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bd1-ed6b-11ed-8709-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bd3-ed6b-11ed-b60d-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bd5-ed6b-11ed-92ef-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bd7-ed6b-11ed-8e67-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bd9-ed6b-11ed-aac6-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bdb-ed6b-11ed-9c54-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bdd-ed6b-11ed-9d5b-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bdf-ed6b-11ed-8964-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5be1-ed6b-11ed-858f-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5be3-ed6b-11ed-a6f1-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5be5-ed6b-11ed-b9bc-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5be7-ed6b-11ed-a4c2-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5be9-ed6b-11ed-84f0-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5beb-ed6b-11ed-9119-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bed-ed6b-11ed-b13d-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bef-ed6b-11ed-a904-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bf1-ed6b-11ed-88f4-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bf3-ed6b-11ed-b6f9-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409c5bf5-ed6b-11ed-b0e0-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97e6-ed6b-11ed-8b4d-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97e8-ed6b-11ed-94e7-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97ea-ed6b-11ed-8bcf-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97ec-ed6b-11ed-b463-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97ee-ed6b-11ed-bbdf-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97f0-ed6b-11ed-90bb-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97f2-ed6b-11ed-a6cf-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97f4-ed6b-11ed-bb0c-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97f6-ed6b-11ed-a3b6-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97f8-ed6b-11ed-9814-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97fa-ed6b-11ed-962d-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97fc-ed6b-11ed-aad6-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d97fe-ed6b-11ed-9246-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9800-ed6b-11ed-a52b-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9802-ed6b-11ed-bc09-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9804-ed6b-11ed-acac-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9806-ed6b-11ed-bd30-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9808-ed6b-11ed-ad60-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d980a-ed6b-11ed-8f53-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d980c-ed6b-11ed-ab6a-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d980e-ed6b-11ed-a002-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9810-ed6b-11ed-8ef2-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9812-ed6b-11ed-9c48-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9814-ed6b-11ed-b1a5-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9816-ed6b-11ed-a024-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9818-ed6b-11ed-a744-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d981a-ed6b-11ed-8cc2-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d981c-ed6b-11ed-a136-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d981e-ed6b-11ed-b364-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9820-ed6b-11ed-b8a4-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9822-ed6b-11ed-b007-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9824-ed6b-11ed-b245-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9826-ed6b-11ed-903e-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9828-ed6b-11ed-8629-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d982a-ed6b-11ed-b3f7-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d982c-ed6b-11ed-9084-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d982e-ed6b-11ed-8e42-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9830-ed6b-11ed-abc8-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9832-ed6b-11ed-8176-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9834-ed6b-11ed-883a-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9836-ed6b-11ed-8979-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d9838-ed6b-11ed-ac79-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "409d983a-ed6b-11ed-890c-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "4A8CA884-C093-43C4-A019-EE6D804BF85E" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E26639C4-7023-4878-A497-FC4B12CFA272", "5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "A2523A70-57E3-4B69-A405-F9752517ED62", "69E0E900-6DE2-45E8-85CA-583B32C5C5AA" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706870e9-e373-11ed-b719-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706b3236-e373-11ed-a003-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "706b3237-e373-11ed-988f-105badc84798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "64F2143D-B896-4355-90D2-AFD22424B234", "7A369173-1E2F-491F-874F-7B324C034BC2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "BEA713C7-93D2-4F39-8DC8-18F2F3070779", "99328045-8ECF-40A1-9F0B-0DEA6398F09A" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64F2143D-B896-4355-90D2-AFD22424B234");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A2523A70-57E3-4B69-A405-F9752517ED62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "BEA713C7-93D2-4F39-8DC8-18F2F3070779");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E26639C4-7023-4878-A497-FC4B12CFA272");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4093fa25-ed6b-11ed-a6df-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4093fa27-ed6b-11ed-8922-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4093fa29-ed6b-11ed-85ba-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4093fa2b-ed6b-11ed-9be9-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4093fa2d-ed6b-11ed-a65f-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409676b0-ed6b-11ed-9fd6-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409676b2-ed6b-11ed-b62e-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409676b4-ed6b-11ed-b886-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409676b6-ed6b-11ed-b477-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409676b8-ed6b-11ed-9c16-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409676ba-ed6b-11ed-adbf-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409676bc-ed6b-11ed-9b21-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409676be-ed6b-11ed-902b-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409676c0-ed6b-11ed-a990-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409676c2-ed6b-11ed-a696-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409676c4-ed6b-11ed-a637-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40977647-ed6b-11ed-aad8-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40977649-ed6b-11ed-973e-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097764b-ed6b-11ed-b259-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097973c-ed6b-11ed-9913-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097973e-ed6b-11ed-929c-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40979740-ed6b-11ed-8c11-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40979742-ed6b-11ed-b3de-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40979744-ed6b-11ed-8abc-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097c4fc-ed6b-11ed-84e8-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097c4fe-ed6b-11ed-b56a-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097c500-ed6b-11ed-b1ae-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d8e5-ed6b-11ed-8a0f-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d8e7-ed6b-11ed-b377-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d8e9-ed6b-11ed-83d1-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d8eb-ed6b-11ed-8f98-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d8ed-ed6b-11ed-9f99-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d8ef-ed6b-11ed-8cd4-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d8f1-ed6b-11ed-aa86-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d8f3-ed6b-11ed-9479-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d8f5-ed6b-11ed-aca2-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d8f7-ed6b-11ed-98e4-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d8f9-ed6b-11ed-8f23-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d8fb-ed6b-11ed-b285-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d8fd-ed6b-11ed-b6a3-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d8ff-ed6b-11ed-85f9-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d901-ed6b-11ed-9297-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d903-ed6b-11ed-855f-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d905-ed6b-11ed-b302-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d907-ed6b-11ed-b6b6-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d909-ed6b-11ed-93d8-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d90b-ed6b-11ed-a99b-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d90d-ed6b-11ed-956f-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d90f-ed6b-11ed-a0cc-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d911-ed6b-11ed-b614-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d913-ed6b-11ed-816e-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4097d915-ed6b-11ed-a890-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b15b-ed6b-11ed-9dc2-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b15d-ed6b-11ed-8903-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b15f-ed6b-11ed-a7e2-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b161-ed6b-11ed-b0d0-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b163-ed6b-11ed-b901-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b165-ed6b-11ed-a2fd-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b167-ed6b-11ed-9dcf-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b169-ed6b-11ed-9b69-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b16b-ed6b-11ed-bc54-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b16d-ed6b-11ed-abd9-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b16f-ed6b-11ed-ae81-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b171-ed6b-11ed-bd08-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b173-ed6b-11ed-9e0c-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b175-ed6b-11ed-a3d4-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b177-ed6b-11ed-b8db-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b179-ed6b-11ed-acd6-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b17b-ed6b-11ed-bfb2-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b17d-ed6b-11ed-a36b-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b17f-ed6b-11ed-9639-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b181-ed6b-11ed-84ef-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b183-ed6b-11ed-91ba-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b185-ed6b-11ed-a00a-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b187-ed6b-11ed-911e-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b189-ed6b-11ed-97ff-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b18b-ed6b-11ed-9c96-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b18d-ed6b-11ed-86a0-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b18f-ed6b-11ed-9b38-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b191-ed6b-11ed-87ba-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b193-ed6b-11ed-b6af-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b195-ed6b-11ed-a317-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b197-ed6b-11ed-a380-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b199-ed6b-11ed-bf11-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b19b-ed6b-11ed-9acc-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b19d-ed6b-11ed-9edb-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b19f-ed6b-11ed-8419-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b1a1-ed6b-11ed-abac-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b1a3-ed6b-11ed-a583-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b1a5-ed6b-11ed-bf0d-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4098b1a7-ed6b-11ed-bd68-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9d3-ed6b-11ed-b4e8-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9d5-ed6b-11ed-8061-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9d7-ed6b-11ed-976d-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9d9-ed6b-11ed-bca8-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9db-ed6b-11ed-9009-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9dd-ed6b-11ed-8e81-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9df-ed6b-11ed-bb40-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9e1-ed6b-11ed-b492-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9e3-ed6b-11ed-92d1-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9e5-ed6b-11ed-b38a-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9e7-ed6b-11ed-9432-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9e9-ed6b-11ed-af1e-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9eb-ed6b-11ed-8d45-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9ed-ed6b-11ed-8755-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9ef-ed6b-11ed-a4a1-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9f1-ed6b-11ed-b017-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9f3-ed6b-11ed-92c8-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9f5-ed6b-11ed-9bbb-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9f7-ed6b-11ed-aa9d-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9f9-ed6b-11ed-8af4-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9fb-ed6b-11ed-88c6-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9fd-ed6b-11ed-a891-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e9ff-ed6b-11ed-a802-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099ea01-ed6b-11ed-a7d5-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099ea03-ed6b-11ed-9ac8-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099ea05-ed6b-11ed-b96b-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099ea07-ed6b-11ed-9c9b-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099ea09-ed6b-11ed-9690-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099ea0b-ed6b-11ed-b0ef-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099ea0d-ed6b-11ed-aa2b-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099ea0f-ed6b-11ed-9d4e-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099ea11-ed6b-11ed-8a4f-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099ea13-ed6b-11ed-839a-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099ea15-ed6b-11ed-8dbe-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099ea17-ed6b-11ed-bb52-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099ea19-ed6b-11ed-85c8-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099ea1b-ed6b-11ed-b4c0-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099ea1d-ed6b-11ed-a4c6-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099ea1f-ed6b-11ed-9f62-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2251-ed6b-11ed-9a82-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2253-ed6b-11ed-b650-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2255-ed6b-11ed-87ce-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2257-ed6b-11ed-8f44-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2259-ed6b-11ed-ac78-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b225b-ed6b-11ed-bf67-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b225d-ed6b-11ed-8369-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b225f-ed6b-11ed-8d6a-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2261-ed6b-11ed-b7f8-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2263-ed6b-11ed-93b0-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2265-ed6b-11ed-8a51-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2267-ed6b-11ed-9ed8-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2269-ed6b-11ed-96a1-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b226b-ed6b-11ed-b5d0-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b226d-ed6b-11ed-9578-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b226f-ed6b-11ed-af75-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2271-ed6b-11ed-b13a-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2273-ed6b-11ed-984c-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2275-ed6b-11ed-8ea0-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2277-ed6b-11ed-a519-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2279-ed6b-11ed-a66d-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b227b-ed6b-11ed-a6a6-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b227d-ed6b-11ed-b8fd-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b227f-ed6b-11ed-9609-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2281-ed6b-11ed-968e-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2283-ed6b-11ed-90f7-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2285-ed6b-11ed-945d-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2287-ed6b-11ed-bdd8-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2289-ed6b-11ed-8a33-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b228b-ed6b-11ed-82cb-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b228d-ed6b-11ed-9862-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b228f-ed6b-11ed-bba0-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2291-ed6b-11ed-82b0-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2293-ed6b-11ed-a281-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2295-ed6b-11ed-a03f-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2297-ed6b-11ed-9620-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b2299-ed6b-11ed-8cd7-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409b229b-ed6b-11ed-b5e4-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5ba9-ed6b-11ed-a9f0-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bab-ed6b-11ed-9ebb-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bad-ed6b-11ed-b06e-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5baf-ed6b-11ed-b43f-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bb1-ed6b-11ed-b22e-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bb3-ed6b-11ed-8aea-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bb5-ed6b-11ed-81ec-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bb7-ed6b-11ed-a54a-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bb9-ed6b-11ed-a374-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bbb-ed6b-11ed-a145-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bbd-ed6b-11ed-a7f3-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bbf-ed6b-11ed-afcf-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bc1-ed6b-11ed-880d-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bc3-ed6b-11ed-b2b0-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bc5-ed6b-11ed-9c33-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bc7-ed6b-11ed-a584-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bc9-ed6b-11ed-94df-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bcb-ed6b-11ed-ae48-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bcd-ed6b-11ed-82bc-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bcf-ed6b-11ed-a53b-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bd1-ed6b-11ed-8709-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bd3-ed6b-11ed-b60d-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bd5-ed6b-11ed-92ef-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bd7-ed6b-11ed-8e67-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bd9-ed6b-11ed-aac6-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bdb-ed6b-11ed-9c54-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bdd-ed6b-11ed-9d5b-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bdf-ed6b-11ed-8964-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5be1-ed6b-11ed-858f-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5be3-ed6b-11ed-a6f1-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5be5-ed6b-11ed-b9bc-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5be7-ed6b-11ed-a4c2-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5be9-ed6b-11ed-84f0-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5beb-ed6b-11ed-9119-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bed-ed6b-11ed-b13d-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bef-ed6b-11ed-a904-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bf1-ed6b-11ed-88f4-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bf3-ed6b-11ed-b6f9-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409c5bf5-ed6b-11ed-b0e0-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d97e6-ed6b-11ed-8b4d-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d97e8-ed6b-11ed-94e7-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d97ea-ed6b-11ed-8bcf-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d97ec-ed6b-11ed-b463-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d97ee-ed6b-11ed-bbdf-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d97f0-ed6b-11ed-90bb-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d97f2-ed6b-11ed-a6cf-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d97f4-ed6b-11ed-bb0c-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d97f6-ed6b-11ed-a3b6-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d97f8-ed6b-11ed-9814-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d97fa-ed6b-11ed-962d-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d97fc-ed6b-11ed-aad6-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d97fe-ed6b-11ed-9246-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9800-ed6b-11ed-a52b-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9802-ed6b-11ed-bc09-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9804-ed6b-11ed-acac-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9806-ed6b-11ed-bd30-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9808-ed6b-11ed-ad60-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d980a-ed6b-11ed-8f53-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d980c-ed6b-11ed-ab6a-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d980e-ed6b-11ed-a002-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9810-ed6b-11ed-8ef2-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9812-ed6b-11ed-9c48-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9814-ed6b-11ed-b1a5-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9816-ed6b-11ed-a024-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9818-ed6b-11ed-a744-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d981a-ed6b-11ed-8cc2-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d981c-ed6b-11ed-a136-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d981e-ed6b-11ed-b364-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9820-ed6b-11ed-b8a4-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9822-ed6b-11ed-b007-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9824-ed6b-11ed-b245-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9826-ed6b-11ed-903e-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9828-ed6b-11ed-8629-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d982a-ed6b-11ed-b3f7-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d982c-ed6b-11ed-9084-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d982e-ed6b-11ed-8e42-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9830-ed6b-11ed-abc8-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9832-ed6b-11ed-8176-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9834-ed6b-11ed-883a-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9836-ed6b-11ed-8979-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d9838-ed6b-11ed-ac79-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409d983a-ed6b-11ed-890c-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4A8CA884-C093-43C4-A019-EE6D804BF85E");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69E0E900-6DE2-45E8-85CA-583B32C5C5AA");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706870e9-e373-11ed-b719-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706b3236-e373-11ed-a003-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "706b3237-e373-11ed-988f-105badc84798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7A369173-1E2F-491F-874F-7B324C034BC2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99328045-8ECF-40A1-9F0B-0DEA6398F09A");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2");
        }
    }
}
