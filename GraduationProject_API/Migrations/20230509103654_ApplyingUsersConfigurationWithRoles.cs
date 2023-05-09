using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProject_API.Migrations
{
    public partial class ApplyingUsersConfigurationWithRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64F2143D-B896-4355-90D2-AFD22424B234", "815c59c6-a77b-4a81-b550-9a8b97083861", "Department Admin", "DEPARTMENT ADMIN" },
                    { "A2523A70-57E3-4B69-A405-F9752517ED62", "842cf6c0-7aea-4928-8dc0-b82be83c4b2a", "Faculty Admin", "FACULTY ADMIN" },
                    { "BEA713C7-93D2-4F39-8DC8-18F2F3070779", "ca0afefd-5267-4c34-9e09-91098a819eaa", "University Admin", "UNIVERSITY ADMIN" },
                    { "E26639C4-7023-4878-A497-FC4B12CFA272", "16298b0f-ed80-4411-8571-ca7125ce0489", "Student", "STUDENT" },
                    { "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7", "1d519fd7-cb9d-4684-ae03-2715f55b1f30", "Professor", "PROFESSOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4093fa25-ed6b-11ed-a6df-105badc84798", 0, "2c0f9342-223b-4c18-943e-8f2f4a8bd82e", "Hamza.Najmb32d@example.com", true, "Hamza", "Najmb32d", false, null, "HAMZA.NAJMB32D@EXAMPLE.COM", "HAMZA.NAJMB32D@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBVERGxt/csZZO6qVJ8odjU/EMrCP6Z1XrEciEj/aOB/YEw61HI7reotVblPScil/g==", "01232988337", false, "4198fcab-c2ad-4db5-95e7-ed923edf4fdc", false, "Hamza.Najmb32d@example.com" },
                    { "4093fa27-ed6b-11ed-8922-105badc84798", 0, "4d560610-1862-4bc4-b3ec-97132413dfac", "Malek.Sheikh9cd6@example.com", true, "Malek", "Sheikh9cd6", false, null, "MALEK.SHEIKH9CD6@EXAMPLE.COM", "MALEK.SHEIKH9CD6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDDeOVPFOabLo9Ga8fgS3Qik1VIvWwU9WzN8cqHCpPHcvXllt9UghqfoxadCvuyCig==", "01220871240", false, "98b01a7d-2a57-4692-a847-28c3d8ff622b", false, "Malek.Sheikh9cd6@example.com" },
                    { "4093fa29-ed6b-11ed-85ba-105badc84798", 0, "b82ff8d6-2626-4668-a982-eb5ff7467ff9", "Zachariah.Hishamiaac8@example.com", true, "Zachariah", "Hishamiaac8", false, null, "ZACHARIAH.HISHAMIAAC8@EXAMPLE.COM", "ZACHARIAH.HISHAMIAAC8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEh+0EdZDrPzWQwFPMb3hnc3XXW/pcPfLwAAEsshAdVMB+kYO7BFZoY0Przd40Oalw==", "01269689816", false, "2fa8b03b-016a-476e-9b18-ffc2d225925f", false, "Zachariah.Hishamiaac8@example.com" },
                    { "4093fa2b-ed6b-11ed-9be9-105badc84798", 0, "24ef4d2a-179d-490f-b1cd-fac01d74b75f", "Bassam.Barra9103@example.com", true, "Bassam", "Barra9103", false, null, "BASSAM.BARRA9103@EXAMPLE.COM", "BASSAM.BARRA9103@EXAMPLE.COM", "AQAAAAEAACcQAAAAEB6cbhHexc5l5BNV5V67eXCbs/MxGFrmY7nKdc4VKjfk1Ml1sBf+YkNGQeXFn2f0Jg==", "01287718443", false, "99d1b00b-5e70-4ac9-8e10-566beeabfafd", false, "Bassam.Barra9103@example.com" },
                    { "4093fa2d-ed6b-11ed-a65f-105badc84798", 0, "8e732f1e-abef-401c-a969-d2b48b7b7267", "​​Karim.Ahmed9826@example.com", true, "​​Karim", "Ahmed9826", false, null, "​​KARIM.AHMED9826@EXAMPLE.COM", "​​KARIM.AHMED9826@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFVWy+xnuVm8bypFJcNZ6U8vTP3Ge1rTHnxm+Cz34geLDV21jeUzBMM4OjtPMIpGaA==", "01229669039", false, "321cb74c-7341-4aaf-a3c9-3ac49f5e7c9e", false, "​​Karim.Ahmed9826@example.com" },
                    { "409676b0-ed6b-11ed-9fd6-105badc84798", 0, "d26de307-4840-48b0-a890-4cba10b1b881", "Russell.Jawada950@example.com", true, "Russell", "Jawada950", false, null, "RUSSELL.JAWADA950@EXAMPLE.COM", "RUSSELL.JAWADA950@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEUOj6UtJ+ovSqDd8t+TdbTz5h/gPrvrm4wpFAwDBFr8gSelUSmQa9C5aHR7h8ImNw==", "01258890451", false, "62756d44-c551-4268-a5b1-5a657a776267", false, "Russell.Jawada950@example.com" },
                    { "409676b2-ed6b-11ed-b62e-105badc84798", 0, "6106aa1d-7d5f-495a-8dd2-53e60bf79737", "Helsey.Bahiabb8@example.com", true, "Helsey", "Bahiabb8", false, null, "HELSEY.BAHIABB8@EXAMPLE.COM", "HELSEY.BAHIABB8@EXAMPLE.COM", "AQAAAAEAACcQAAAAECPuBykqh9I6jU37g3nKFt4yhNQiXbLU4/3Kukv+ZqsRG+DfNNgbXtC/39djz4nPJA==", "01271822961", false, "8d4fe571-ebd4-40ab-ba48-b3e7a8602658", false, "Helsey.Bahiabb8@example.com" },
                    { "409676b4-ed6b-11ed-b886-105badc84798", 0, "ff17f01a-ef5d-43f6-93e2-4ae65246cffd", "Adel.Fidaa8283@example.com", true, "Adel", "Fidaa8283", false, null, "ADEL.FIDAA8283@EXAMPLE.COM", "ADEL.FIDAA8283@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIce5yLwTOzKtp8eajlt1p1kxyP+59dOqd1uZxVTLRSDiSOjOVRFEG+4X6iUUxw6Dw==", "01252839445", false, "9858bcb7-b92d-4cfb-942d-bc19cdbabd2d", false, "Adel.Fidaa8283@example.com" },
                    { "409676b6-ed6b-11ed-b477-105badc84798", 0, "8dcc0a06-d2dc-41d8-af40-b3f2c20b1d3d", "Haor.Medhatbb1e@example.com", true, "Haor", "Medhatbb1e", false, null, "HAOR.MEDHATBB1E@EXAMPLE.COM", "HAOR.MEDHATBB1E@EXAMPLE.COM", "AQAAAAEAACcQAAAAEN+IwZwDbHmhrH39uspF3IsgZysSjGXu5wtdX7sQE8SLwH/HWq7l3JADZKTPhQc/zQ==", "01249787781", false, "cc687653-0846-4cda-84bf-a6b4068fa090", false, "Haor.Medhatbb1e@example.com" },
                    { "409676b8-ed6b-11ed-9c16-105badc84798", 0, "9bcdf220-dd5f-47f5-b03c-da91b76959d1", "Hassan.Haor9c0d@example.com", true, "Hassan", "Haor9c0d", false, null, "HASSAN.HAOR9C0D@EXAMPLE.COM", "HASSAN.HAOR9C0D@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKTmD1Xf2JFartYHD1spIDZYC3THfUOSGLqJ5tTuSK9wSbA0syzENB02lUJdAeGADw==", "01252429834", false, "62e84688-6e67-4536-a4fe-e929a28a9144", false, "Hassan.Haor9c0d@example.com" },
                    { "409676ba-ed6b-11ed-adbf-105badc84798", 0, "59066990-baae-4295-bc36-ef12d914686a", "Sameh.Hilalb0d8@example.com", true, "Sameh", "Hilalb0d8", false, null, "SAMEH.HILALB0D8@EXAMPLE.COM", "SAMEH.HILALB0D8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKGgnEC5exSKtFLGE1oNk8cXMYiKdD2VTaN0nc9NxCTVLN+sezhC/oFY+Jp+Oo6oQg==", "01212885239", false, "5868cdec-d6e0-4918-8877-30e8de8b5d49", false, "Sameh.Hilalb0d8@example.com" },
                    { "409676bc-ed6b-11ed-9b21-105badc84798", 0, "c3ca0560-6763-4830-b2bf-5d72763439c8", "Ghaith.Asim9678@example.com", true, "Ghaith", "Asim9678", false, null, "GHAITH.ASIM9678@EXAMPLE.COM", "GHAITH.ASIM9678@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOYL4NblXNgDw7sgL+etDkVQu5NcsZRmHdRBnGfKE8+jadFG1gm2ydqzNmPM/sqgCQ==", "01286981596", false, "a8a7fc90-e327-4499-be35-30b0f5f98161", false, "Ghaith.Asim9678@example.com" },
                    { "409676be-ed6b-11ed-902b-105badc84798", 0, "eb8b5e60-f39a-450e-8e66-8e11cc6ad2cb", "Waseem.Ghanem9305@example.com", true, "Waseem", "Ghanem9305", false, null, "WASEEM.GHANEM9305@EXAMPLE.COM", "WASEEM.GHANEM9305@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJUGgkj9XVtezqEgXS1cQDUW73nstnSrHrsJLoPr4UcTmh29BO/QaqBWdg/y8D4F4Q==", "01267352439", false, "df35cced-680c-4c1a-ab97-7dfc4964dbeb", false, "Waseem.Ghanem9305@example.com" },
                    { "409676c0-ed6b-11ed-a990-105badc84798", 0, "69beadad-0b12-4f3a-ab2c-47df8bd9ca17", "Badri.Basemacbd@example.com", true, "Badri", "Basemacbd", false, null, "BADRI.BASEMACBD@EXAMPLE.COM", "BADRI.BASEMACBD@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFRVIBeiH9KwmMDm2KIkTNunw/3jAlfTpSnpVCkGD+lgxIiD3jCEhXSncv4A4slfuw==", "01297327850", false, "18cf457f-7373-4181-b862-6b861ef9b159", false, "Badri.Basemacbd@example.com" },
                    { "409676c2-ed6b-11ed-a696-105badc84798", 0, "395a8c60-f846-4212-a909-e92663ae9475", "Bacari.Sharmb5af@example.com", true, "Bacari", "Sharmb5af", false, null, "BACARI.SHARMB5AF@EXAMPLE.COM", "BACARI.SHARMB5AF@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPmR1CCgZZulAVo+o5sLWlDd9ZRYWCaiVOLCbZRYWSkPScPjUy3X0Il6Ny7WmddmQA==", "01282353516", false, "b4791b03-b915-462d-ac35-a42f86b9af55", false, "Bacari.Sharmb5af@example.com" },
                    { "409676c4-ed6b-11ed-a637-105badc84798", 0, "e37d95d1-56ba-45c6-b028-43ebb78a40eb", "Yakon.Sharm9d1a@example.com", true, "Yakon", "Sharm9d1a", false, null, "YAKON.SHARM9D1A@EXAMPLE.COM", "YAKON.SHARM9D1A@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJsCWwgLFXVI6RwCArGfRY+mi7LHcKHMkv+w/jOj5oxHDFUgydwgXR++imT8+2yFkg==", "01216786378", false, "35cc8317-b789-415c-9fca-5c7abcfad860", false, "Yakon.Sharm9d1a@example.com" },
                    { "40977647-ed6b-11ed-aad8-105badc84798", 0, "87d04470-cd56-44a4-ab32-41c2404c3a63", "Fidaa.Adham9867@example.com", true, "Fidaa", "Adham9867", false, null, "FIDAA.ADHAM9867@EXAMPLE.COM", "FIDAA.ADHAM9867@EXAMPLE.COM", "AQAAAAEAACcQAAAAECfvPIgG4kOMj9G2a1QYFCfYuw4ndWIPdrAkpVJFt5nBtjJNuM3UdFVb6Pi5mgHwhw==", "01218203642", false, "1c6c0fe8-4dba-4113-acc9-8847fd90e265", false, "Fidaa.Adham9867@example.com" },
                    { "40977649-ed6b-11ed-973e-105badc84798", 0, "d66c7fcd-c714-4e21-95a6-378fbb09fa45", "Firas.Bassel82fd@example.com", true, "Firas", "Bassel82fd", false, null, "FIRAS.BASSEL82FD@EXAMPLE.COM", "FIRAS.BASSEL82FD@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFhbioXhU2UdZ0W9RoBq1gv50zPwWLf/I8+HgP9M8uKaaWpOel1JwHGZBa57W1Zp7w==", "01217707960", false, "651dfb29-acf6-476c-b976-5ecc557b8a61", false, "Firas.Bassel82fd@example.com" },
                    { "4097764b-ed6b-11ed-b259-105badc84798", 0, "148d3921-96fe-498e-982d-3b5c79cb94e1", "Sameh.Hishami8757@example.com", true, "Sameh", "Hishami8757", false, null, "SAMEH.HISHAMI8757@EXAMPLE.COM", "SAMEH.HISHAMI8757@EXAMPLE.COM", "AQAAAAEAACcQAAAAEE8lnKA7/L35JTO9ZYRqxWYMyUh4ZW1D6L/VvXqdY/wzXy65TGCofJJYS5xarKrxUA==", "01272041260", false, "70d22e71-c0ef-4f5a-bec0-c9082dc1db59", false, "Sameh.Hishami8757@example.com" },
                    { "4097973c-ed6b-11ed-9913-105badc84798", 0, "186f50cc-a06d-4ba5-8f7b-9fb012b0acdc", "Noah.Nahar9371@example.com", true, "Noah", "Nahar9371", false, null, "NOAH.NAHAR9371@EXAMPLE.COM", "NOAH.NAHAR9371@EXAMPLE.COM", "AQAAAAEAACcQAAAAEC21x9PWYOTJ1PmBDvrB/3vHVevt8aSaX1vRQBq3dXZx/5A5iwaSEbH4sk875A3cOA==", "01244828073", false, "0bd94f01-5076-4d0e-956a-a73ba91b530f", false, "Noah.Nahar9371@example.com" },
                    { "4097973e-ed6b-11ed-929c-105badc84798", 0, "7d33cd20-6547-4d0b-bfd6-2a0d80678958", "Saden.Ali8050@example.com", true, "Saden", "Ali8050", false, null, "SADEN.ALI8050@EXAMPLE.COM", "SADEN.ALI8050@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEKhilfp9IuIS2IJA/wCB93ovfihoRaGbTjZsTmm4uUBwg8ep8Lj4Fhx7Mj2lOrVBw==", "01243048322", false, "6f3a3a4b-be78-4a29-bd71-9bea046915f4", false, "Saden.Ali8050@example.com" },
                    { "40979740-ed6b-11ed-8c11-105badc84798", 0, "90214501-5f47-420b-b666-f07f84bcf85b", "Ghaith.Basselb8db@example.com", true, "Ghaith", "Basselb8db", false, null, "GHAITH.BASSELB8DB@EXAMPLE.COM", "GHAITH.BASSELB8DB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDeVoVw/ToHSJLw1RrdSNqJSHK84xNTnA8rb9v7XlKACVbmIB+eH7Wl18cETuSd0/A==", "01288105916", false, "e87a30e2-405d-4d2f-9507-83a178c148c3", false, "Ghaith.Basselb8db@example.com" },
                    { "40979742-ed6b-11ed-b3de-105badc84798", 0, "d9bc6fd6-abfb-4492-80ac-07990ab11a65", "​​Karim.Basem9bee@example.com", true, "​​Karim", "Basem9bee", false, null, "​​KARIM.BASEM9BEE@EXAMPLE.COM", "​​KARIM.BASEM9BEE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHzhRkh1tNPQLuAivdblaQcGiiF5Bfe9w94mKmOHQdAgh3GET6yjJSlvpbd6tUjaGw==", "01273133463", false, "dbffbe9e-af06-4dc2-b1e0-833ebb274fe1", false, "​​Karim.Basem9bee@example.com" },
                    { "40979744-ed6b-11ed-8abc-105badc84798", 0, "5600301d-726e-473a-b955-048f259e7f6b", "Minali.Medhat86ba@example.com", true, "Minali", "Medhat86ba", false, null, "MINALI.MEDHAT86BA@EXAMPLE.COM", "MINALI.MEDHAT86BA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHI3dNnG4yOKtUNeqq3W54Ic7WLZq+NYXpux/xZAmEOqfTpDRUSsrHPBUlzn+aGcSA==", "01279049557", false, "e45f8286-a8e4-4977-91cd-97b9b81b36b7", false, "Minali.Medhat86ba@example.com" },
                    { "4097c4fc-ed6b-11ed-84e8-105badc84798", 0, "a7094105-ea4f-434f-834b-b0cfa370ea21", "Bilal.Zachariah83af@example.com", true, "Bilal", "Zachariah83af", false, null, "BILAL.ZACHARIAH83AF@EXAMPLE.COM", "BILAL.ZACHARIAH83AF@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKNGD8nn+TeGYWv0BTp8Rotjs4t9Y+qXjDB/6npUjaPxTWoszkNY7xfMg7+3tb2jhA==", "01293395937", false, "91a9d481-3483-432c-8f47-523a499d2fec", false, "Bilal.Zachariah83af@example.com" },
                    { "4097c4fe-ed6b-11ed-b56a-105badc84798", 0, "85697e70-4e59-4524-baee-ec1f0f4531c5", "Abi.Radwana902@example.com", true, "Abi", "Radwana902", false, null, "ABI.RADWANA902@EXAMPLE.COM", "ABI.RADWANA902@EXAMPLE.COM", "AQAAAAEAACcQAAAAEA86cxi1jLfXblIp5YalLZPpz0s88Aj9i11BK1eRHeN0zdEh8WzRxzkjJqdkPR1YeQ==", "01269899834", false, "98ba0c10-3b22-41ce-bb94-cc442bb94535", false, "Abi.Radwana902@example.com" },
                    { "4097c500-ed6b-11ed-b1ae-105badc84798", 0, "4fd1ef49-26c8-4326-ba95-1374b05dd972", "Russell.Hosni9590@example.com", true, "Russell", "Hosni9590", false, null, "RUSSELL.HOSNI9590@EXAMPLE.COM", "RUSSELL.HOSNI9590@EXAMPLE.COM", "AQAAAAEAACcQAAAAEI/MP0CC//wSeXbGHSvZaeKkKKHa461JZrHcBWooSAjvPddSG4LpSzpwQDpGtdbJJw==", "01219006694", false, "2bfa321d-5e44-4156-8ea4-48a7766705e7", false, "Russell.Hosni9590@example.com" },
                    { "4097d8e5-ed6b-11ed-8a0f-105badc84798", 0, "5989914d-3410-473f-a2c6-38fd3211d8fd", "Samhi.Baqibff9@example.com", true, "Samhi", "Baqibff9", false, null, "SAMHI.BAQIBFF9@EXAMPLE.COM", "SAMHI.BAQIBFF9@EXAMPLE.COM", "AQAAAAEAACcQAAAAEH+NQTi27DKRsLjV2mbu7Jl7mv/F4UKMV3h0o4LR8k8J8HfWpQCsw6ijbS99OqEYSg==", "01254158559", false, "2d3f9951-b626-4c0b-91ee-b1f6c9de7090", false, "Samhi.Baqibff9@example.com" },
                    { "4097d8e7-ed6b-11ed-b377-105badc84798", 0, "d54aebc5-b9b3-418a-8ea6-3090a3d2e2ab", "Ghanem.Adham8b37@example.com", true, "Ghanem", "Adham8b37", false, null, "GHANEM.ADHAM8B37@EXAMPLE.COM", "GHANEM.ADHAM8B37@EXAMPLE.COM", "AQAAAAEAACcQAAAAECmTnnfzhA3se9TnhXRewGrEOEU+SWLt4HHOXYKZ3o+rznRQnkhA6tIO1+8EmvA+gw==", "01217050688", false, "04396622-eead-4e8f-8f14-60b90f7c2dce", false, "Ghanem.Adham8b37@example.com" },
                    { "4097d8e9-ed6b-11ed-83d1-105badc84798", 0, "7163b222-3d88-4d8e-8193-605fa3710fcf", "Dagher.Hilali951a@example.com", true, "Dagher", "Hilali951a", false, null, "DAGHER.HILALI951A@EXAMPLE.COM", "DAGHER.HILALI951A@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJFxm5Td0c9Pgf17CJrpTg6q0MLmf9geYXxx+zFegL7ysT3cslfk/mO9oarpLxNZ7Q==", "01268897899", false, "2864ed70-a1ba-4910-a1bb-00790847a560", false, "Dagher.Hilali951a@example.com" },
                    { "4097d8eb-ed6b-11ed-8f98-105badc84798", 0, "8d571849-72cf-4fe2-9964-2ca620d05573", "Hussein.Sameha5e1@example.com", true, "Hussein", "Sameha5e1", false, null, "HUSSEIN.SAMEHA5E1@EXAMPLE.COM", "HUSSEIN.SAMEHA5E1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBNDFpu7YABFBL3ZNywS2X5u6LBaqeoHtJbBlHg3F4RrWLvjaza4tF8r/ofML9Am7g==", "01242105816", false, "e7bcf3f7-1923-4ae2-aadd-05d6312a1537", false, "Hussein.Sameha5e1@example.com" },
                    { "4097d8ed-ed6b-11ed-9f99-105badc84798", 0, "4d380054-fe21-4448-8b7c-79528e13de36", "Hamaqy.Saber9b17@example.com", true, "Hamaqy", "Saber9b17", false, null, "HAMAQY.SABER9B17@EXAMPLE.COM", "HAMAQY.SABER9B17@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJ9QFiMttKpL1onEoxHKPDqnPNEKMGFrZqSuEj8tCgyZpx11sPxYnf11toUZKeaG1w==", "01273898120", false, "ad3f63bb-5e22-4857-97c7-0fc137717e83", false, "Hamaqy.Saber9b17@example.com" },
                    { "4097d8ef-ed6b-11ed-8cd4-105badc84798", 0, "0bfa3aab-b565-4b94-abbc-5739081e1930", "Sheila.Sheilaa655@example.com", true, "Sheila", "Sheilaa655", false, null, "SHEILA.SHEILAA655@EXAMPLE.COM", "SHEILA.SHEILAA655@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIjAlggUzOyaM6xmXUvkLgxL6HjzuN9BMS/bf26BdoZhAnXhnBOe1Ox5wdZMkrLWgg==", "01267569088", false, "63fb00e2-5861-4785-90b4-7341a274029a", false, "Sheila.Sheilaa655@example.com" },
                    { "4097d8f1-ed6b-11ed-aa86-105badc84798", 0, "58fb6ce4-d343-4448-94d6-76d86700fce2", "Daniel.Bahib5ad@example.com", true, "Daniel", "Bahib5ad", false, null, "DANIEL.BAHIB5AD@EXAMPLE.COM", "DANIEL.BAHIB5AD@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEp65/38A/7bhPvFi/pQkA/6qBmBf/M3LqjwXK/EZuor9P829DPHYTddV5fzAOeEFg==", "01262123625", false, "edbfb4fa-819b-46ea-8080-76deedf6eca9", false, "Daniel.Bahib5ad@example.com" },
                    { "4097d8f3-ed6b-11ed-9479-105badc84798", 0, "5d73022c-e2ea-4373-9ede-200b4808be4f", "Halsi.Kolthouma5c7@example.com", true, "Halsi", "Kolthouma5c7", false, null, "HALSI.KOLTHOUMA5C7@EXAMPLE.COM", "HALSI.KOLTHOUMA5C7@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOpeoSukkPgCy6btS3on3lqm4pVAtFlGD2n96GaRUQjuTMrtzj+hrNvZ7AMLhTmwEg==", "01262132489", false, "2b396240-4ec6-4756-99ca-4b8c4d5c9e69", false, "Halsi.Kolthouma5c7@example.com" },
                    { "4097d8f5-ed6b-11ed-aca2-105badc84798", 0, "dcac94c8-4943-47af-ae56-2841187cba02", "Mahmoud.Wael9d18@example.com", true, "Mahmoud", "Wael9d18", false, null, "MAHMOUD.WAEL9D18@EXAMPLE.COM", "MAHMOUD.WAEL9D18@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDNxgs+R+8ly5fkCta7U3ZvV6Gqfg40XQcWGEVkywyIQgLzo9hXq9VbXWbo8hOG5QQ==", "01231638303", false, "92bd2992-aa89-4539-bc1e-de5a9deab489", false, "Mahmoud.Wael9d18@example.com" },
                    { "4097d8f7-ed6b-11ed-98e4-105badc84798", 0, "9440d17d-0b60-40bc-9d1e-06166e5ba5b4", "Osama.Basem92cb@example.com", true, "Osama", "Basem92cb", false, null, "OSAMA.BASEM92CB@EXAMPLE.COM", "OSAMA.BASEM92CB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEG00pbBu4UrVCJ6N5w+rL6+abSon56+lgxQitO+UN6BTM6N4xCUnE7KcZmYLR+EvCA==", "01218566576", false, "9a403797-e89d-40dd-8bbe-5b4327a4ab42", false, "Osama.Basem92cb@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4097d8f9-ed6b-11ed-8f23-105badc84798", 0, "55673e9d-32d6-4f85-b692-178ae103201a", "Nahar.Shehabiac20@example.com", true, "Nahar", "Shehabiac20", false, null, "NAHAR.SHEHABIAC20@EXAMPLE.COM", "NAHAR.SHEHABIAC20@EXAMPLE.COM", "AQAAAAEAACcQAAAAENKWau1tO/Ph0tdCn0EvkRhmsRmrQieNR4YiullIEOP83zsJi004PnUUvO/H8Stx7w==", "01241146819", false, "a541048d-3e21-4036-aafc-b795411813f1", false, "Nahar.Shehabiac20@example.com" },
                    { "4097d8fb-ed6b-11ed-b285-105badc84798", 0, "11bea618-1cb0-4a07-91f5-810e27971e2d", "Marawan.Zachariah8daa@example.com", true, "Marawan", "Zachariah8daa", false, null, "MARAWAN.ZACHARIAH8DAA@EXAMPLE.COM", "MARAWAN.ZACHARIAH8DAA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEKX+1OR8g0zuJL1p0NPMVC7aO5rCQ16uU++1z2CgJi2/rbm8tzAjN+f3VltnFiViA==", "01292596275", false, "b0ea4511-529f-47ef-a311-62be3bb2c8ec", false, "Marawan.Zachariah8daa@example.com" },
                    { "4097d8fd-ed6b-11ed-b6a3-105badc84798", 0, "331b73a5-9b7f-4a90-89c6-4a34032860d9", "Adham.Dagherb00d@example.com", true, "Adham", "Dagherb00d", false, null, "ADHAM.DAGHERB00D@EXAMPLE.COM", "ADHAM.DAGHERB00D@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBfWpnMPz+njGqdGYN43WZ/nF4SciOuVlD+ZoPCl/DV6pSh/sN1e5LRXfrbONEX0rQ==", "01264741807", false, "ad4abc28-fd46-4d8c-b329-72448a0e8a69", false, "Adham.Dagherb00d@example.com" },
                    { "4097d8ff-ed6b-11ed-85f9-105badc84798", 0, "cb5804db-24c3-4287-aec5-4d110b417f88", "Majid.Asami943b@example.com", true, "Majid", "Asami943b", false, null, "MAJID.ASAMI943B@EXAMPLE.COM", "MAJID.ASAMI943B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKG+ZxDr0kM6OlKqeW18NzVUyUm8QSvNuYO72dCNTi5LO7Qk+giw1jFYgQY2aEwsWw==", "01258015535", false, "2b911eba-7a43-4b16-8aae-2f9d933720b4", false, "Majid.Asami943b@example.com" },
                    { "4097d901-ed6b-11ed-9297-105badc84798", 0, "c06f3af0-50ec-47d1-beb3-92d3587a63e0", "Ghaith.Bahiracf6@example.com", true, "Ghaith", "Bahiracf6", false, null, "GHAITH.BAHIRACF6@EXAMPLE.COM", "GHAITH.BAHIRACF6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEII4hXI3jNUnguMZPbXa6Hc0gGCTFlUQ8JMl6qjMnajpXAqeNaQ/Nr9Uvt7zlZz4CQ==", "01232394458", false, "d3e34799-6d86-4c4a-9658-9e6cbc28b191", false, "Ghaith.Bahiracf6@example.com" },
                    { "4097d903-ed6b-11ed-855f-105badc84798", 0, "029c560c-959c-4e91-a594-5a7788a0bf9f", "Yunus.Zachariah8945@example.com", true, "Yunus", "Zachariah8945", false, null, "YUNUS.ZACHARIAH8945@EXAMPLE.COM", "YUNUS.ZACHARIAH8945@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGGosvAWMKwnC2VGV3wZxfI9OwtgW8wOBBhwJjq7Makd4gKKbIP2GmOOH8Fngu07AA==", "01288556434", false, "4aa29325-ea5c-4029-b2eb-20754bb51955", false, "Yunus.Zachariah8945@example.com" },
                    { "4097d905-ed6b-11ed-b302-105badc84798", 0, "c2c0b88d-4513-4aff-a65c-cc6985c5f9e9", "Ramzy.Osamaafb5@example.com", true, "Ramzy", "Osamaafb5", false, null, "RAMZY.OSAMAAFB5@EXAMPLE.COM", "RAMZY.OSAMAAFB5@EXAMPLE.COM", "AQAAAAEAACcQAAAAECsDqtaIBmVyhHRqTl/IrOXjwl9m3uuv6lkhmIPdbYq1JfW7Hwwo/ufpUlIsfhhCow==", "01272846023", false, "9a11d6b7-881a-417c-944a-bc571483c26a", false, "Ramzy.Osamaafb5@example.com" },
                    { "4097d907-ed6b-11ed-b6b6-105badc84798", 0, "cb2457c7-0fba-4a04-8b29-b6789b6e325e", "Bahi.Yisrib844@example.com", true, "Bahi", "Yisrib844", false, null, "BAHI.YISRIB844@EXAMPLE.COM", "BAHI.YISRIB844@EXAMPLE.COM", "AQAAAAEAACcQAAAAEM+MGK/AdwYhV9/vX1hipcMRGLh43G5ZJCQygd7zDXclXqUV3UI/AYSBYI9PRJGaRw==", "01289220737", false, "9894afec-59fd-4e6d-9919-12910c78982e", false, "Bahi.Yisrib844@example.com" },
                    { "4097d909-ed6b-11ed-93d8-105badc84798", 0, "6a3a1ea0-d925-4db9-84da-80b2e05414b9", "Sheikh.Kafar97f1@example.com", true, "Sheikh", "Kafar97f1", false, null, "SHEIKH.KAFAR97F1@EXAMPLE.COM", "SHEIKH.KAFAR97F1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAQpRbGm0irnPVrZyXmWDgjnVIHF81gJztEs48TGVN1A17pWS2mmqsBVZADB8mffOQ==", "01228387515", false, "cdaaca8e-0909-4cad-9098-46dbb3b86f5c", false, "Sheikh.Kafar97f1@example.com" },
                    { "4097d90b-ed6b-11ed-a99b-105badc84798", 0, "738be749-9605-4013-8df4-4ec70a608e6a", "Fares.Hassanbdf6@example.com", true, "Fares", "Hassanbdf6", false, null, "FARES.HASSANBDF6@EXAMPLE.COM", "FARES.HASSANBDF6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEG5neBYxUgGiL+f+gBc8OcP24RWY6H7O5o3kDxLEpyO1AETwhocvRkD70pXKaSk22A==", "01278694578", false, "6ac276a5-f29c-4cfd-bc43-6a2103a4e21f", false, "Fares.Hassanbdf6@example.com" },
                    { "4097d90d-ed6b-11ed-956f-105badc84798", 0, "71b42d4f-3a05-4110-b412-c2d189199535", "Samir.Sheila8b49@example.com", true, "Samir", "Sheila8b49", false, null, "SAMIR.SHEILA8B49@EXAMPLE.COM", "SAMIR.SHEILA8B49@EXAMPLE.COM", "AQAAAAEAACcQAAAAEP42ZnNaQ6T/WU9guCbgLuP9e/a9KGQkjhHO5WCjqckl4xL3fx9uDWKXtfMwMzsQAQ==", "01214800867", false, "9ae3e86f-0554-4e4d-a769-400e957eb9a9", false, "Samir.Sheila8b49@example.com" },
                    { "4097d90f-ed6b-11ed-a0cc-105badc84798", 0, "e3db7e41-e544-4f05-bf6e-362f2c072303", "Yakon.Adhamaaa9@example.com", true, "Yakon", "Adhamaaa9", false, null, "YAKON.ADHAMAAA9@EXAMPLE.COM", "YAKON.ADHAMAAA9@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKFKPwMjnqlJfx2+Tkk4O36mljW5vcsbwLe/JwFbHSpJCaXGTJZ1Wm+YkKAwfsz77Q==", "01299862932", false, "3f9c7f6b-a63c-4745-bbc3-fab4a00a0f7d", false, "Yakon.Adhamaaa9@example.com" },
                    { "4097d911-ed6b-11ed-b614-105badc84798", 0, "dea1e6ad-6ec1-4559-8838-027e395efd1b", "Fidaa.Sameha430@example.com", true, "Fidaa", "Sameha430", false, null, "FIDAA.SAMEHA430@EXAMPLE.COM", "FIDAA.SAMEHA430@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFVHfOV7L3NDhQcGRFQFzCLfR/EPNgAwj1FGF0Vd3ICzAIw2gOwx5YOWFNUkIjZNeQ==", "01283485131", false, "bd8cfda3-4899-4ce0-af17-a13a751aecc3", false, "Fidaa.Sameha430@example.com" },
                    { "4097d913-ed6b-11ed-816e-105badc84798", 0, "040426d5-465b-4c34-862f-93012e937df7", "Yusuf.Baqi8945@example.com", true, "Yusuf", "Baqi8945", false, null, "YUSUF.BAQI8945@EXAMPLE.COM", "YUSUF.BAQI8945@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBYGqrYEh6B28H/sJXR++VZs6Ur7xPWTSKoJ3Dt7+wjFZDWpWVApOGU75YxkBkTpQQ==", "01235586777", false, "a3be4a09-0fb0-490e-a504-985dd76611f0", false, "Yusuf.Baqi8945@example.com" },
                    { "4097d915-ed6b-11ed-a890-105badc84798", 0, "e3234ac1-ab69-4dd3-99a8-d206e0482100", "Kahter.Minali8e83@example.com", true, "Kahter", "Minali8e83", false, null, "KAHTER.MINALI8E83@EXAMPLE.COM", "KAHTER.MINALI8E83@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEWPyVeOXd3xpTPKlZQmoocVSmvL0QQTZUTFQsCzsKvwO/hJsADKx+Gs6aUbQXByoQ==", "01237394610", false, "7a3b1130-2975-44ec-afa1-6a5a202ea1cc", false, "Kahter.Minali8e83@example.com" },
                    { "4098b15b-ed6b-11ed-9dc2-105badc84798", 0, "eac7f2c4-a245-4d50-a0ab-0bd0e78c1a54", "Hamaki.Waela1d0@example.com", true, "Hamaki", "Waela1d0", false, null, "HAMAKI.WAELA1D0@EXAMPLE.COM", "HAMAKI.WAELA1D0@EXAMPLE.COM", "AQAAAAEAACcQAAAAECa+vM5YSdzw1nF/bHv0jMSEDS4TItqIpi+vGFoyM27hvmOo2L4Z8mvH2zxV0jYRWw==", "01216731361", false, "2e30469a-710d-49ec-a793-34cf44f73de6", false, "Hamaki.Waela1d0@example.com" },
                    { "4098b15d-ed6b-11ed-8903-105badc84798", 0, "8559bf2d-b682-45b3-96ce-e8970ac1ff0e", "Samhi.Ahmed8548@example.com", true, "Samhi", "Ahmed8548", false, null, "SAMHI.AHMED8548@EXAMPLE.COM", "SAMHI.AHMED8548@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGQXYLZrrrWjraYoVN8NrE7dy2B+udF3OVs4vXKzPspxSoCnOmEWa1KDRZn/64DAog==", "01295806415", false, "78ac7617-408d-4127-af76-54d68c07e257", false, "Samhi.Ahmed8548@example.com" },
                    { "4098b15f-ed6b-11ed-a7e2-105badc84798", 0, "aea05681-3220-4b6e-a5b2-2a23b9749363", "Hishami.Dagherbd70@example.com", true, "Hishami", "Dagherbd70", false, null, "HISHAMI.DAGHERBD70@EXAMPLE.COM", "HISHAMI.DAGHERBD70@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPmi+uQ2yezl8afC1SZ5EcziOn83DrWUN2adva49htBUSP267aHS01+Gr8KzDTDTgg==", "01216081772", false, "b0e1bc6a-8fe2-4dc4-bf89-47962426cb40", false, "Hishami.Dagherbd70@example.com" },
                    { "4098b161-ed6b-11ed-b0d0-105badc84798", 0, "5f538a7b-7074-4460-b466-afe965e55d81", "Minali.Haor85f2@example.com", true, "Minali", "Haor85f2", false, null, "MINALI.HAOR85F2@EXAMPLE.COM", "MINALI.HAOR85F2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMFRqFKTydx+Q507NdWrFL/h8kvb5zTX+IbGn5a5n5VLHeWJ69xR+BQjaT6tYnm8gg==", "01264213362", false, "dacd333e-023c-481b-af48-61d80a838af9", false, "Minali.Haor85f2@example.com" },
                    { "4098b163-ed6b-11ed-b901-105badc84798", 0, "cb8797fe-7f09-4e72-b7cf-c8b04dfcda2b", "Bilal.Asimac85@example.com", true, "Bilal", "Asimac85", false, null, "BILAL.ASIMAC85@EXAMPLE.COM", "BILAL.ASIMAC85@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFY6d8VLiA+wUR5Cxow8kR061eG3ByJsvcng4uNdwFMCuVUf3GoznrAPxIj+W14IHA==", "01236247368", false, "e796a6e8-3d55-45b5-b3e2-08cbb1575bc3", false, "Bilal.Asimac85@example.com" },
                    { "4098b165-ed6b-11ed-a2fd-105badc84798", 0, "8ac3de36-7af1-4877-88c7-4bfa3d17d30b", "Kamel.Waseemb3f8@example.com", true, "Kamel", "Waseemb3f8", false, null, "KAMEL.WASEEMB3F8@EXAMPLE.COM", "KAMEL.WASEEMB3F8@EXAMPLE.COM", "AQAAAAEAACcQAAAAENVFmsO4cz64Olxt/39hpuUqKsgpVvBHHgrrfEaXq9rIUOfF1vEJUZohghg7D8Cr0g==", "01227742375", false, "c8400e18-ecc2-4de8-88d3-f770bbfdba43", false, "Kamel.Waseemb3f8@example.com" },
                    { "4098b167-ed6b-11ed-9dcf-105badc84798", 0, "08e8d96e-63bc-4333-89d1-25967efb9750", "Yamen.Hilalia185@example.com", true, "Yamen", "Hilalia185", false, null, "YAMEN.HILALIA185@EXAMPLE.COM", "YAMEN.HILALIA185@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMxTkcQfEEYRWCgpB35ZuoDrQ8O3zGCv6BEUpYAopQCHO59wY1LxQgllHVPV5XXV7Q==", "01226708337", false, "e70fdcfa-6000-4ecc-9eb2-7dde0f094cff", false, "Yamen.Hilalia185@example.com" },
                    { "4098b169-ed6b-11ed-9b69-105badc84798", 0, "e7a40487-a8fb-4a21-ba91-8ad76f6bc9c3", "Sheila.Badri806c@example.com", true, "Sheila", "Badri806c", false, null, "SHEILA.BADRI806C@EXAMPLE.COM", "SHEILA.BADRI806C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBh5OCO0uEt1xGzyGMVOqgHmBFV478aHOadTXmBmtfqsUe9lQXykcpJ/SG9ZJ3wv/A==", "01250629461", false, "ab42c1eb-afc5-4c67-bd85-0746d4babd63", false, "Sheila.Badri806c@example.com" },
                    { "4098b16b-ed6b-11ed-bc54-105badc84798", 0, "2615166f-808e-4f32-9230-69d5c7e17e4a", "Bahi.Sharma930@example.com", true, "Bahi", "Sharma930", false, null, "BAHI.SHARMA930@EXAMPLE.COM", "BAHI.SHARMA930@EXAMPLE.COM", "AQAAAAEAACcQAAAAEL6WQ1Kcx6etKfbLUwvc6aOUvOeMpEfE0qBGMKpOsLwTOp7RpLQXIAsQYON0PQUwjw==", "01264225474", false, "9f86c133-fcd6-4081-b96e-28228383e65d", false, "Bahi.Sharma930@example.com" },
                    { "4098b16d-ed6b-11ed-abd9-105badc84798", 0, "e1af5e52-666f-45b6-afbc-1defddaa0975", "Hilal.Hilal9e6a@example.com", true, "Hilal", "Hilal9e6a", false, null, "HILAL.HILAL9E6A@EXAMPLE.COM", "HILAL.HILAL9E6A@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEjE9bPn7Kw7freTL64B7btgCp6YmWQg2rKgRHWaPNNCIlUKC9biDw3oMvF4uQZYvA==", "01280080449", false, "5c29ff6f-409e-4d72-8553-1e8d8cfc8086", false, "Hilal.Hilal9e6a@example.com" },
                    { "4098b16f-ed6b-11ed-ae81-105badc84798", 0, "fd62951e-e5c5-4d91-a828-50e9a8930c6a", "Yisri.Saden9224@example.com", true, "Yisri", "Saden9224", false, null, "YISRI.SADEN9224@EXAMPLE.COM", "YISRI.SADEN9224@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIKUMZJ9/79thfsQEsIM7ICUbEU/QsDDrHjO1Hl/2VxzxW4dg5ldZ0ZN2YHYCdYH7Q==", "01266306998", false, "6045d3a3-0eec-4c49-ba57-5cd1e58d1dc0", false, "Yisri.Saden9224@example.com" },
                    { "4098b171-ed6b-11ed-bd08-105badc84798", 0, "35fea3f2-0b22-4e26-9c3c-f24310bdfd68", "Helsey.Samiraa00@example.com", true, "Helsey", "Samiraa00", false, null, "HELSEY.SAMIRAA00@EXAMPLE.COM", "HELSEY.SAMIRAA00@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDz308axfl71lwJlqoG2/5QoJAgnrElEoPZgEUOlJV6QQUPEWfAa5i25lMh7mMXYaw==", "01217458085", false, "000f33e4-ebbc-4d2b-8a93-6904cafa1235", false, "Helsey.Samiraa00@example.com" },
                    { "4098b173-ed6b-11ed-9e0c-105badc84798", 0, "1fd36721-648f-4c2e-a931-50e14b18ceee", "Wael.Waseembb41@example.com", true, "Wael", "Waseembb41", false, null, "WAEL.WASEEMBB41@EXAMPLE.COM", "WAEL.WASEEMBB41@EXAMPLE.COM", "AQAAAAEAACcQAAAAEG8r9ftmOZDNIVsK0z3YDNy/uub69cl6yjvK+dNqPjaPh5gZqlTGXY/wG5UnsXoOug==", "01284333280", false, "aa33cb31-0f8d-4061-ad4b-fceda8ebff91", false, "Wael.Waseembb41@example.com" },
                    { "4098b175-ed6b-11ed-a3d4-105badc84798", 0, "ac036b6b-fbe4-4146-b9fd-7089f9f7488e", "Najm.Bahirbab8@example.com", true, "Najm", "Bahirbab8", false, null, "NAJM.BAHIRBAB8@EXAMPLE.COM", "NAJM.BAHIRBAB8@EXAMPLE.COM", "AQAAAAEAACcQAAAAELIoWLBtZyreekr0SGTnpiJEMTYC+bL68uXa4XvfKJzULuMru3GRBkhN5ZYQQf0cQQ==", "01287732484", false, "7604d221-5991-490e-9222-58e22b679cde", false, "Najm.Bahirbab8@example.com" },
                    { "4098b177-ed6b-11ed-b8db-105badc84798", 0, "b941a08a-1063-422b-bceb-4404a0575e8c", "Dahi.Adelbabc@example.com", true, "Dahi", "Adelbabc", false, null, "DAHI.ADELBABC@EXAMPLE.COM", "DAHI.ADELBABC@EXAMPLE.COM", "AQAAAAEAACcQAAAAEF+PRTCu3EXwngygDBbNPStY7KMqdYHvwg+U6fQIvrnEt68xh5yHSQkSRR9CUNsUPQ==", "01214965124", false, "8cf9439c-9834-4a23-9f19-da0332b324aa", false, "Dahi.Adelbabc@example.com" },
                    { "4098b179-ed6b-11ed-acd6-105badc84798", 0, "552a2683-bedc-4975-9902-f899a20cb00f", "Sajid.Majdibec5@example.com", true, "Sajid", "Majdibec5", false, null, "SAJID.MAJDIBEC5@EXAMPLE.COM", "SAJID.MAJDIBEC5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEI5Y7sjsb55UIkSuQY0hqJ++oBnVqofGdcYv8VaOyIjWa69kkMpEdWiUDakfmylTIw==", "01226566171", false, "49a95a26-cdf7-4bae-b7cd-10debbb562eb", false, "Sajid.Majdibec5@example.com" },
                    { "4098b17b-ed6b-11ed-bfb2-105badc84798", 0, "272b40db-0b84-46bf-9d97-4e59d0a97d3d", "Salim.Waseem9d1b@example.com", true, "Salim", "Waseem9d1b", false, null, "SALIM.WASEEM9D1B@EXAMPLE.COM", "SALIM.WASEEM9D1B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEN3MSVRcjHPO6htA0B2UeDlbU7nStaXz70n5m1T5QWKRSZPr8bXZGHRfgABG3sd2cg==", "01223503517", false, "05fe8f86-a232-43a7-8272-8998edc0d55e", false, "Salim.Waseem9d1b@example.com" },
                    { "4098b17d-ed6b-11ed-a36b-105badc84798", 0, "1cf2328e-adc9-48a9-b53f-4537d80b9498", "Baqi.Zaki9e26@example.com", true, "Baqi", "Zaki9e26", false, null, "BAQI.ZAKI9E26@EXAMPLE.COM", "BAQI.ZAKI9E26@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJ1NoqIpEo772ZwQlXlRT8xo+zmYt031zcSvTDNzsMp1crOYsrbutvA7DENfDp909A==", "01295728341", false, "5b67d2ef-4ff1-44e4-b78b-e84e592964bb", false, "Baqi.Zaki9e26@example.com" },
                    { "4098b17f-ed6b-11ed-9639-105badc84798", 0, "8d218f78-8077-49dc-b7ce-4cfda3cbe6ac", "Sahami.Sheikhy80fb@example.com", true, "Sahami", "Sheikhy80fb", false, null, "SAHAMI.SHEIKHY80FB@EXAMPLE.COM", "SAHAMI.SHEIKHY80FB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOanGqhvsGC8qlTX0jp3XR0IhqV62nM2QWfrMq3YjQ5HHctjtG7Kn8XHssaLxxCLPQ==", "01269675036", false, "387ae70a-5304-4a17-9b8f-ea56157f0c50", false, "Sahami.Sheikhy80fb@example.com" },
                    { "4098b181-ed6b-11ed-84ef-105badc84798", 0, "f7b6bae2-6c14-46db-a307-d95f32a4fe34", "Badri.Sareea3a3@example.com", true, "Badri", "Sareea3a3", false, null, "BADRI.SAREEA3A3@EXAMPLE.COM", "BADRI.SAREEA3A3@EXAMPLE.COM", "AQAAAAEAACcQAAAAECdfWZXvPPD3d0CeAiYxWjczna41xjQBaqbmhCNrTEaxRAuTCCtGztGm0eBcjhjhFA==", "01260728699", false, "a4a81bad-57b0-4a45-b9be-0420740d2ca4", false, "Badri.Sareea3a3@example.com" },
                    { "4098b183-ed6b-11ed-91ba-105badc84798", 0, "b02928fa-fa09-4d32-820f-9a090dcc596b", "Faisal.Ryan93db@example.com", true, "Faisal", "Ryan93db", false, null, "FAISAL.RYAN93DB@EXAMPLE.COM", "FAISAL.RYAN93DB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMmnrBGbewNyn+zPwwCnVNn1noLtLOjUkWMKQLLoxA6vXACE+v9790bZefUSeQh84g==", "01215094196", false, "e59ef72a-9387-4990-9445-d80a72cc8c35", false, "Faisal.Ryan93db@example.com" },
                    { "4098b185-ed6b-11ed-a00a-105badc84798", 0, "2c91ea11-1e7a-48d8-ae1f-c32a9dfcf825", "Omar.Sahami9f51@example.com", true, "Omar", "Sahami9f51", false, null, "OMAR.SAHAMI9F51@EXAMPLE.COM", "OMAR.SAHAMI9F51@EXAMPLE.COM", "AQAAAAEAACcQAAAAENVwRRq3NijroZY31TWi39DB5yLmCqV18721P/mcyztC+v7NQqnaIS4/6ILbTZPmXg==", "01271704961", false, "7856d5c9-fc71-412e-8c03-fbe5141f9285", false, "Omar.Sahami9f51@example.com" },
                    { "4098b187-ed6b-11ed-911e-105badc84798", 0, "0a1f3c5d-ddfe-48ae-bd61-e9e4dd2876b5", "Loay.Basem8ee7@example.com", true, "Loay", "Basem8ee7", false, null, "LOAY.BASEM8EE7@EXAMPLE.COM", "LOAY.BASEM8EE7@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBtqm94WDEuYU9LEEVxAZSMVrPSOlPrm9qy0iYBHraid3qKTL9INC2VlZm7gZC7m1A==", "01253444230", false, "6a7f2de0-21df-47a3-906d-3ee2ea7fdeed", false, "Loay.Basem8ee7@example.com" },
                    { "4098b189-ed6b-11ed-97ff-105badc84798", 0, "d92bb93e-c45f-422e-b5e5-996cd26b6ac9", "Halsi.Ryana491@example.com", true, "Halsi", "Ryana491", false, null, "HALSI.RYANA491@EXAMPLE.COM", "HALSI.RYANA491@EXAMPLE.COM", "AQAAAAEAACcQAAAAEE8cWTtf7C2zFnZm8Mn6vxw8HT2JypXiC/rSJ5lWty1OEVazPO1E1Nf29jaXjh+3XA==", "01243084731", false, "2539b0e7-e73d-48f6-a598-379fae4eb3fc", false, "Halsi.Ryana491@example.com" },
                    { "4098b18b-ed6b-11ed-9c96-105badc84798", 0, "14f22821-7d5a-4bf8-9324-ae398be39f59", "Noah.Waela26a@example.com", true, "Noah", "Waela26a", false, null, "NOAH.WAELA26A@EXAMPLE.COM", "NOAH.WAELA26A@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPGRPiNDy+oANbhGeo+x3AYcSn+xitJGAVnolmVQxAnNz4t7tFDMrg7IAPaHslY5vQ==", "01265189792", false, "3b3fd4d4-5da1-44fe-897f-c5869c32f28f", false, "Noah.Waela26a@example.com" },
                    { "4098b18d-ed6b-11ed-86a0-105badc84798", 0, "8152fb66-e225-40a3-b90e-045363599968", "Malek.Minalia6b0@example.com", true, "Malek", "Minalia6b0", false, null, "MALEK.MINALIA6B0@EXAMPLE.COM", "MALEK.MINALIA6B0@EXAMPLE.COM", "AQAAAAEAACcQAAAAEE20f+61PAdS3MyGjhCJ0fm1fZziZHfgSQ7An5gPzHysbuWxPJ+HkG90KH+aFgfK0A==", "01272439716", false, "0f6bee7b-f8fb-4217-845d-5e38a0969baa", false, "Malek.Minalia6b0@example.com" },
                    { "4098b18f-ed6b-11ed-9b38-105badc84798", 0, "745e135d-c7ca-494c-b076-8e7217d136bb", "Kahter.Sharmaf90@example.com", true, "Kahter", "Sharmaf90", false, null, "KAHTER.SHARMAF90@EXAMPLE.COM", "KAHTER.SHARMAF90@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMXTWLKko6MB5Ksv6fswhTQQkOMSzzV7wFIH6Lj7fgFf5EIYAcR5el0ZyLhRuzOGWQ==", "01297951939", false, "a6f4543c-a456-44d1-a78e-5b1b1525fea2", false, "Kahter.Sharmaf90@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4098b191-ed6b-11ed-87ba-105badc84798", 0, "c8400978-2e78-4acb-87c9-ed58da3a2af2", "Sajid.Zachariah82c1@example.com", true, "Sajid", "Zachariah82c1", false, null, "SAJID.ZACHARIAH82C1@EXAMPLE.COM", "SAJID.ZACHARIAH82C1@EXAMPLE.COM", "AQAAAAEAACcQAAAAECtkxRBafSrBzKVr5V19mbeLxYFIWAmNyJkeDMtRjjooNOqhX0C7DoQKlrtxmgqWPg==", "01218467982", false, "37ed2620-7227-42b7-9455-99fe43a862fc", false, "Sajid.Zachariah82c1@example.com" },
                    { "4098b193-ed6b-11ed-b6af-105badc84798", 0, "4aa23734-982c-42f3-8e89-7973c5c14bb4", "Dahi.Danielad4c@example.com", true, "Dahi", "Danielad4c", false, null, "DAHI.DANIELAD4C@EXAMPLE.COM", "DAHI.DANIELAD4C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEITxKXfNdRYPn/MFVq5Kka0hjC0a2O869v3lVQv00UUodW/XR904pCgpUZDSns9KCQ==", "01214991654", false, "bc3c1cbf-d38a-4739-8e61-04c1ed0a4e1f", false, "Dahi.Danielad4c@example.com" },
                    { "4098b195-ed6b-11ed-a317-105badc84798", 0, "97d73299-3a7a-4458-81a2-e9b89ecc09f6", "Ahmed.Samehbda8@example.com", true, "Ahmed", "Samehbda8", false, null, "AHMED.SAMEHBDA8@EXAMPLE.COM", "AHMED.SAMEHBDA8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEN/KjpdfzyfDmyUaOQP1ts8lr+JuMmVc6Qj5LZCXwTeOeoz+MaD93+NSNmSLkmNTFQ==", "01214023531", false, "a18a73f9-16cd-49c6-bbaa-1ef5948dcb88", false, "Ahmed.Samehbda8@example.com" },
                    { "4098b197-ed6b-11ed-a380-105badc84798", 0, "11d36afc-ecf9-4e93-b832-a4977106a054", "Hamaki.Salimb1fa@example.com", true, "Hamaki", "Salimb1fa", false, null, "HAMAKI.SALIMB1FA@EXAMPLE.COM", "HAMAKI.SALIMB1FA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOuceEHe6pFL5emIfO3AShI98ReUKAlrnmFddMnAaHyM+vaFsx2bbrdLiAjpfwWkdw==", "01237177143", false, "a8b426f5-2ba0-4f50-9265-5608241e2871", false, "Hamaki.Salimb1fa@example.com" },
                    { "4098b199-ed6b-11ed-bf11-105badc84798", 0, "32a72564-f090-43c5-9ee2-19a7f84f99f4", "Latfi.Latfi8c51@example.com", true, "Latfi", "Latfi8c51", false, null, "LATFI.LATFI8C51@EXAMPLE.COM", "LATFI.LATFI8C51@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJ2bHpnfV3WAc6lURw7d474XuAemwnCiJxPYiRkmVZPp0DiNri6d3+6bxM+kgC/Xnw==", "01287157511", false, "6a781b45-8b40-4ac7-8cf4-cb479984c23f", false, "Latfi.Latfi8c51@example.com" },
                    { "4098b19b-ed6b-11ed-9acc-105badc84798", 0, "0638c58a-7b5b-4330-82fe-4d8d13a5f2f5", "Fadi.Medhatbc78@example.com", true, "Fadi", "Medhatbc78", false, null, "FADI.MEDHATBC78@EXAMPLE.COM", "FADI.MEDHATBC78@EXAMPLE.COM", "AQAAAAEAACcQAAAAED3vg5mq6+xDBBGoquty/vnXrmP+1dd7+8/A0QLoI8ghhtgV8tzhxFR/HlyC3J+1hQ==", "01231139763", false, "89706330-2b47-4ca3-b493-88bc6c6b6418", false, "Fadi.Medhatbc78@example.com" },
                    { "4098b19d-ed6b-11ed-9edb-105badc84798", 0, "e8ea912f-00c4-4d69-8469-c0177be3a658", "Fahed.Minali85eb@example.com", true, "Fahed", "Minali85eb", false, null, "FAHED.MINALI85EB@EXAMPLE.COM", "FAHED.MINALI85EB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEI72cmOMMWExgEXUXHTHRLy4f/n10XKuxMFJkobYUVMkP7r5BRzctap2VbJY29DQiA==", "01256275160", false, "83ef9c5c-0110-4201-8641-cc693d3ef89b", false, "Fahed.Minali85eb@example.com" },
                    { "4098b19f-ed6b-11ed-8419-105badc84798", 0, "04ad89df-6377-48a9-bf47-4629683107f9", "Wael.Zachariahb0c2@example.com", true, "Wael", "Zachariahb0c2", false, null, "WAEL.ZACHARIAHB0C2@EXAMPLE.COM", "WAEL.ZACHARIAHB0C2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPPBP9E6z5TMo2uup47/OXneExYKMp71Ii7/Ztqs/rhgVlibAmJpfxB8cuKgVxGcvw==", "01218944525", false, "e33e0ba5-56c6-433b-8e68-080d1ab79461", false, "Wael.Zachariahb0c2@example.com" },
                    { "4098b1a1-ed6b-11ed-abac-105badc84798", 0, "49f8877f-7968-4f72-9157-30cac37fffc8", "Zarif.Bahi9d47@example.com", true, "Zarif", "Bahi9d47", false, null, "ZARIF.BAHI9D47@EXAMPLE.COM", "ZARIF.BAHI9D47@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMgbhhBL1tMNpeO16Y/fvMsIUU1mwGq+xDR+dUKpoukH4ETGUVowErPwMi8zx1QFTQ==", "01283196507", false, "b9579fe6-f131-46ed-b1d4-47bc12bd3973", false, "Zarif.Bahi9d47@example.com" },
                    { "4098b1a3-ed6b-11ed-a583-105badc84798", 0, "4dc3228a-138e-44a3-bc81-8fff3b11ccca", "Bara.Bahia873@example.com", true, "Bara", "Bahia873", false, null, "BARA.BAHIA873@EXAMPLE.COM", "BARA.BAHIA873@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHlxU3akBMqy7lqq8dgcpcnA+e7uqoPH7KLV2zu8sRK9GvhbVOGV2CUOyz6jqgAj9w==", "01234054165", false, "14d5fe96-31cd-4770-81b5-c33795b75e40", false, "Bara.Bahia873@example.com" },
                    { "4098b1a5-ed6b-11ed-bf0d-105badc84798", 0, "e85e8efa-4773-4b4a-906b-2069599a6044", "Hamaqy.Noorad52@example.com", true, "Hamaqy", "Noorad52", false, null, "HAMAQY.NOORAD52@EXAMPLE.COM", "HAMAQY.NOORAD52@EXAMPLE.COM", "AQAAAAEAACcQAAAAEP7MrG7pmUCHs9fij++HvAPRzq72C0HQTJthmnVnxbjH5nzfn2FVk5UTnDCCNlEiEg==", "01249013827", false, "eaa65248-e6d4-459c-897d-2c0100a4ff67", false, "Hamaqy.Noorad52@example.com" },
                    { "4098b1a7-ed6b-11ed-bd68-105badc84798", 0, "5437994e-2e4a-4576-8b4d-ede7e2725ff5", "Fares.Bahirb03c@example.com", true, "Fares", "Bahirb03c", false, null, "FARES.BAHIRB03C@EXAMPLE.COM", "FARES.BAHIRB03C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEH5zyHqDc+mniy9btViNt35sVyMzxiSM+IQjSlxmsJpLenvucS6yw6MdCC9YS+X4jA==", "01245035379", false, "0ca7d6b6-f7c1-4d46-bc8f-5a2f03420c76", false, "Fares.Bahirb03c@example.com" },
                    { "4099e9d3-ed6b-11ed-b4e8-105badc84798", 0, "f142bfde-6347-4a18-a289-7b30eecb5f89", "Jalal.Majid82af@example.com", true, "Jalal", "Majid82af", false, null, "JALAL.MAJID82AF@EXAMPLE.COM", "JALAL.MAJID82AF@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPKaW1XQgjH8eSUEBqSW3K10QFTPfq4VLCEXheLV+5UzEY6ErI1rMXzS6QS4FcbsxA==", "01292058402", false, "d195975c-be50-47bf-82a5-1d31c8f67b9d", false, "Jalal.Majid82af@example.com" },
                    { "4099e9d5-ed6b-11ed-8061-105badc84798", 0, "b8531289-fc03-4140-b7d1-ad23be119121", "Saden.Waelb102@example.com", true, "Saden", "Waelb102", false, null, "SADEN.WAELB102@EXAMPLE.COM", "SADEN.WAELB102@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIUCilyMNek93j4DQ05ap2YdJI2uEX755tB1bAy85rVl7rNU51usGnIt69Lp63Fxvw==", "01227228988", false, "77dcde9d-b728-43e7-9f6e-40b35159aa04", false, "Saden.Waelb102@example.com" },
                    { "4099e9d7-ed6b-11ed-976d-105badc84798", 0, "41254659-8971-43e3-85d4-28e6a003ad3a", "Dahi.Sajid849e@example.com", true, "Dahi", "Sajid849e", false, null, "DAHI.SAJID849E@EXAMPLE.COM", "DAHI.SAJID849E@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPhBNOOjmb9bOvZAWNUpWy2qiCo4huivPRjnzVaiWx28AnjoExXsQduAMHNF5p250g==", "01263561273", false, "cee274c3-8874-47d9-ba87-d7f5f307e43e", false, "Dahi.Sajid849e@example.com" },
                    { "4099e9d9-ed6b-11ed-bca8-105badc84798", 0, "fad57cf0-3e70-48f6-bc94-8447ee18f8ec", "Adel.Hilalab94@example.com", true, "Adel", "Hilalab94", false, null, "ADEL.HILALAB94@EXAMPLE.COM", "ADEL.HILALAB94@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKi9JpQIW3bDZUULEwVNtGtc4dmLkjDDLCTBaWNf2zAsXk+8jax7lkpuGNv5h6kUmA==", "01275990302", false, "72af3cda-d782-4337-8e68-2774677821c6", false, "Adel.Hilalab94@example.com" },
                    { "4099e9db-ed6b-11ed-9009-105badc84798", 0, "378982d6-a917-4bb1-89b0-94e9f4fc9428", "Samir.Bassam897e@example.com", true, "Samir", "Bassam897e", false, null, "SAMIR.BASSAM897E@EXAMPLE.COM", "SAMIR.BASSAM897E@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJrL3dD1peUNACLw3/1jI1PlUClWKDliExAQz3/PyLtjC3eYa0c8yUHH1kbRjzjFzQ==", "01234422680", false, "329e0c4f-f770-45e5-90d6-a9a0961c3f72", false, "Samir.Bassam897e@example.com" },
                    { "4099e9dd-ed6b-11ed-8e81-105badc84798", 0, "df784451-d7c2-415a-9b8c-709c5d6b020a", "Sajid.Sheikha8b1@example.com", true, "Sajid", "Sheikha8b1", false, null, "SAJID.SHEIKHA8B1@EXAMPLE.COM", "SAJID.SHEIKHA8B1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJnPeda8s5Ff9FJaLdyte+KAW61LDISNugG6Y2IkPVRG1nn5aZWhzcBmXRhoEUctdg==", "01210144261", false, "1a964512-2de0-4184-845c-de029f0f7975", false, "Sajid.Sheikha8b1@example.com" },
                    { "4099e9df-ed6b-11ed-bb40-105badc84798", 0, "f6de70af-2ac8-476c-b512-076448daa508", "Russell.Ghanem9478@example.com", true, "Russell", "Ghanem9478", false, null, "RUSSELL.GHANEM9478@EXAMPLE.COM", "RUSSELL.GHANEM9478@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOr+XaO/dBcbATxxAbju+n+CJIHYA3qN0pJd4LY0kSYmohK055XNW3SyMDGqfGV4Qg==", "01290670217", false, "7f61ae4c-e1dc-4a25-98c2-c7e5a7979a73", false, "Russell.Ghanem9478@example.com" },
                    { "4099e9e1-ed6b-11ed-b492-105badc84798", 0, "8279ab34-2e1e-4eae-9157-0aeff490cdbd", "Haor.Wael82ce@example.com", true, "Haor", "Wael82ce", false, null, "HAOR.WAEL82CE@EXAMPLE.COM", "HAOR.WAEL82CE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAXX2ngHziGzQ1FldV1Zl2WSjKiLflg4je56Lo/tQsFeVHrC5V9/V17KUALjnE5zKQ==", "01255444010", false, "f0b0eef5-78c2-4b4c-b732-56f060c50fc3", false, "Haor.Wael82ce@example.com" },
                    { "4099e9e3-ed6b-11ed-92d1-105badc84798", 0, "997f7227-1f1a-492d-a6cd-d51e2d32f3ff", "Dagher.Zachariahb6b1@example.com", true, "Dagher", "Zachariahb6b1", false, null, "DAGHER.ZACHARIAHB6B1@EXAMPLE.COM", "DAGHER.ZACHARIAHB6B1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFxWULP6UjD/ILK4VvTHimqxGs5uLwqCzMx1DYbenSmHRgtdcyEXlA8ZsMAyftWw5Q==", "01224788521", false, "b8a9249f-ef8d-4eda-8f17-e485f61d0ae7", false, "Dagher.Zachariahb6b1@example.com" },
                    { "4099e9e5-ed6b-11ed-b38a-105badc84798", 0, "55356b13-77c5-4cd6-a0f7-7f81ff517580", "Hishami.Halsib62b@example.com", true, "Hishami", "Halsib62b", false, null, "HISHAMI.HALSIB62B@EXAMPLE.COM", "HISHAMI.HALSIB62B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBYdxuWWsC6eX56MgU9fzIuR/N/c4PdUCpIu7x8M7ysjTw09TN1JHoV9Mjd+K909Lw==", "01237896983", false, "89fc7e3f-97fb-4848-beca-2ff16ab88d28", false, "Hishami.Halsib62b@example.com" },
                    { "4099e9e7-ed6b-11ed-9432-105badc84798", 0, "4adba18f-3a09-4217-822b-fc807e085b9e", "Marawan.Shahib1ef@example.com", true, "Marawan", "Shahib1ef", false, null, "MARAWAN.SHAHIB1EF@EXAMPLE.COM", "MARAWAN.SHAHIB1EF@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGVIwE96/DQP3jTRXBrRJi1KHBJdhCScXM07vxaDbZVg30KJ/C7JZc9wLbIB/qMXdw==", "01271273824", false, "7e0b1138-16b4-4111-94bd-f8cf6ceb12f0", false, "Marawan.Shahib1ef@example.com" },
                    { "4099e9e9-ed6b-11ed-af1e-105badc84798", 0, "5d96744c-8e3e-4a44-9628-e1f8c123dc0a", "Fidaa.Baqia533@example.com", true, "Fidaa", "Baqia533", false, null, "FIDAA.BAQIA533@EXAMPLE.COM", "FIDAA.BAQIA533@EXAMPLE.COM", "AQAAAAEAACcQAAAAEABLVpOZOyyDAFx27m5ZntobTTk0eW4JPyijcIhh8jav5jvEJq07hd/BJ2/a1DdPNQ==", "01218117934", false, "e4ac18a9-7581-40e7-890b-3ab72eb247ae", false, "Fidaa.Baqia533@example.com" },
                    { "4099e9eb-ed6b-11ed-8d45-105badc84798", 0, "b6eefae5-74b9-4ec6-b515-2447a114a3ff", "Radwan.Kamel90c3@example.com", true, "Radwan", "Kamel90c3", false, null, "RADWAN.KAMEL90C3@EXAMPLE.COM", "RADWAN.KAMEL90C3@EXAMPLE.COM", "AQAAAAEAACcQAAAAECoK6dAIQABJHlfnDa2I5qmyecvljRDjTO1glYeorgg57TFJKSQe5eWiz8a3J10/jw==", "01262457869", false, "823cadc9-d9d9-4431-b1cd-b92a15482c1d", false, "Radwan.Kamel90c3@example.com" },
                    { "4099e9ed-ed6b-11ed-8755-105badc84798", 0, "42a83fd8-2447-49dd-a548-79e7e3c990b5", "Loay.Bahi9d3c@example.com", true, "Loay", "Bahi9d3c", false, null, "LOAY.BAHI9D3C@EXAMPLE.COM", "LOAY.BAHI9D3C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDHiGppdP2D9kfZLdsFU54HbFxEdi73a7xmKWBTtbfOfbHP/ZFO1AGgGU0X08bhgxQ==", "01298984959", false, "c9234564-fa94-429b-84df-804751ebb145", false, "Loay.Bahi9d3c@example.com" },
                    { "4099e9ef-ed6b-11ed-a4a1-105badc84798", 0, "73ed537b-d8cd-460f-9dde-9e2eea1519bc", "Ryan.Moses82e6@example.com", true, "Ryan", "Moses82e6", false, null, "RYAN.MOSES82E6@EXAMPLE.COM", "RYAN.MOSES82E6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMdAc/7+avE8RvMn2lwNMZsC/rcv2Pm89jYEARtuaa/IYjiOzIyuGtode2ZDFw/Osw==", "01287007236", false, "3af17fb0-c78f-4d9d-a22c-aa443d82e81d", false, "Ryan.Moses82e6@example.com" },
                    { "4099e9f1-ed6b-11ed-b017-105badc84798", 0, "eacc513c-44ad-4d51-b8e4-cc94a529b5e0", "Fahed.Hishamia1b1@example.com", true, "Fahed", "Hishamia1b1", false, null, "FAHED.HISHAMIA1B1@EXAMPLE.COM", "FAHED.HISHAMIA1B1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAQfOSevYFz5Bpfsigqa+BFslqIT4ko+qL34J8ZUsZrY2wdOiQO6LILeEY8xks70mg==", "01295741865", false, "03de67ff-960d-4b01-9f3a-7b4b85abb2ee", false, "Fahed.Hishamia1b1@example.com" },
                    { "4099e9f3-ed6b-11ed-92c8-105badc84798", 0, "3dbbb4cb-6ce3-4329-86db-6dea602c390d", "Horr.Basselb860@example.com", true, "Horr", "Basselb860", false, null, "HORR.BASSELB860@EXAMPLE.COM", "HORR.BASSELB860@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAfmVbyfOG5XdF6+2ytPkVBpGjnaRN2WPqVFnqQRRtHcXJV7oQafeL0DGsN/nArpww==", "01231479095", false, "a39efd38-5927-4f81-b994-47a3f8ebfbe6", false, "Horr.Basselb860@example.com" },
                    { "4099e9f5-ed6b-11ed-9bbb-105badc84798", 0, "76ea9dfa-e939-4ae5-862b-9570561aa8d8", "Asim.Bahia196@example.com", true, "Asim", "Bahia196", false, null, "ASIM.BAHIA196@EXAMPLE.COM", "ASIM.BAHIA196@EXAMPLE.COM", "AQAAAAEAACcQAAAAEI1X6FMC0ZAF0tepQhQhFXzDkJTw33ANf102mBHB4iuqMPfs2BZVi8hh/7cRPSIUSw==", "01293315685", false, "5c9f61fc-079c-4dc8-8733-c3842d0d0150", false, "Asim.Bahia196@example.com" },
                    { "4099e9f7-ed6b-11ed-aa9d-105badc84798", 0, "82d74b52-bb87-4a83-910c-2554ef26f634", "Bara.Shahib692@example.com", true, "Bara", "Shahib692", false, null, "BARA.SHAHIB692@EXAMPLE.COM", "BARA.SHAHIB692@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFEyn3wXz3ua3bztdxtQapXOgT2fIJRJGOuSW5KIYrBZkUIoBm5a11Fz+vttkcTkww==", "01240292772", false, "518292b8-fd03-495f-8bea-38eb4117ee93", false, "Bara.Shahib692@example.com" },
                    { "4099e9f9-ed6b-11ed-8af4-105badc84798", 0, "5c624043-0752-44d0-ab90-0c62d60a9899", "Fadi.Adhama536@example.com", true, "Fadi", "Adhama536", false, null, "FADI.ADHAMA536@EXAMPLE.COM", "FADI.ADHAMA536@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJfy2Ex7hiReJ04p4XvotWmpcaeZWZdHONJm9ZtA9rhPQVkcgVxN159DaYU9OZIajg==", "01239956926", false, "315b85f6-ba1e-4d5a-b1a2-36bebf57b1e6", false, "Fadi.Adhama536@example.com" },
                    { "4099e9fb-ed6b-11ed-88c6-105badc84798", 0, "325e56e3-53dc-4aa8-bacc-44396c06e01f", "Medhat.Hammadbdb5@example.com", true, "Medhat", "Hammadbdb5", false, null, "MEDHAT.HAMMADBDB5@EXAMPLE.COM", "MEDHAT.HAMMADBDB5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJedxzjMawQpfTMO0XNEPaX47kuScku+dOzGXdveYThW6P3PrsesxqZ3QIcCecmMvg==", "01224361401", false, "5ae5428b-27a6-48e4-8f76-f20bbd10b256", false, "Medhat.Hammadbdb5@example.com" },
                    { "4099e9fd-ed6b-11ed-a891-105badc84798", 0, "0d4ad6c8-9a1e-4bea-920d-747080f65022", "Najm.Shehabia8de@example.com", true, "Najm", "Shehabia8de", false, null, "NAJM.SHEHABIA8DE@EXAMPLE.COM", "NAJM.SHEHABIA8DE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFk1H2OLWh+a3+3QeLW+kiWzpIR7PDLcYNG8XiD+R4tIuutIwlIeuLe66zm8iu2jOA==", "01264500973", false, "9d5b19c3-2f20-4aa9-8945-4ef9d2b07f31", false, "Najm.Shehabia8de@example.com" },
                    { "4099e9ff-ed6b-11ed-a802-105badc84798", 0, "3e5d3ee1-2759-4710-bf20-a1cd9599dd26", "Hussein.Jalal89d8@example.com", true, "Hussein", "Jalal89d8", false, null, "HUSSEIN.JALAL89D8@EXAMPLE.COM", "HUSSEIN.JALAL89D8@EXAMPLE.COM", "AQAAAAEAACcQAAAAENzVRzWDXrLQwXh+Ng8yHup6hT0JK/ebSXCxOBubs1XLKcEYssam152L8LK6F6mxgg==", "01243463663", false, "7e65e0ac-b3f6-45a3-8179-ecafe4162754", false, "Hussein.Jalal89d8@example.com" },
                    { "4099ea01-ed6b-11ed-a7d5-105badc84798", 0, "be0cc2bb-0c04-4731-ab8e-d21ef7b24f8b", "Saden.Fares8d49@example.com", true, "Saden", "Fares8d49", false, null, "SADEN.FARES8D49@EXAMPLE.COM", "SADEN.FARES8D49@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIhzn/gM3qido85AQkW6h9ST/+/I8knGWgH2LvT5xEdpg72+d8d/GtvCsdN+D32t/A==", "01231665315", false, "a683e0a7-1f33-4546-99d6-91127ea66404", false, "Saden.Fares8d49@example.com" },
                    { "4099ea03-ed6b-11ed-9ac8-105badc84798", 0, "af01c558-ec74-4f33-a4ec-e8b097701639", "Bahir.Najma6fb@example.com", true, "Bahir", "Najma6fb", false, null, "BAHIR.NAJMA6FB@EXAMPLE.COM", "BAHIR.NAJMA6FB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEObSCHZ7BZcIySymKlIMak+tdAIxlVBV8QofcBaigu/aSkHz7j4rNmU4HNwou43AfA==", "01257564173", false, "66ad2867-3d02-4868-b9fa-c2fda909ab99", false, "Bahir.Najma6fb@example.com" },
                    { "4099ea05-ed6b-11ed-b96b-105badc84798", 0, "7e80bd1b-1ad1-47a8-8dfc-463523064d06", "Bahi.Fidaa88f9@example.com", true, "Bahi", "Fidaa88f9", false, null, "BAHI.FIDAA88F9@EXAMPLE.COM", "BAHI.FIDAA88F9@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIdxPffARNwAFuUwG3UKP83gueHYq3Ukp9JT+jgW+R3kPeW0jrcu6Mepy+0bqWWYeQ==", "01244926851", false, "e66cbac3-e849-4c74-b829-302c742462d1", false, "Bahi.Fidaa88f9@example.com" },
                    { "4099ea07-ed6b-11ed-9c9b-105badc84798", 0, "d2840f24-8f96-4027-85d1-870f6e83d855", "Dahi.Waseembc12@example.com", true, "Dahi", "Waseembc12", false, null, "DAHI.WASEEMBC12@EXAMPLE.COM", "DAHI.WASEEMBC12@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEu7pSg3F9B3S9B7Ecej64349SVyiwCQObPnTOJpaGGZRtQ39nFKWxDte+7DPDTuRw==", "01237376445", false, "b90f820a-805a-4bde-9e00-b3fb2cfe13d6", false, "Dahi.Waseembc12@example.com" },
                    { "4099ea09-ed6b-11ed-9690-105badc84798", 0, "f34ffb70-0dc1-487c-8e2b-5726c5f5079a", "Osama.Hilal82e1@example.com", true, "Osama", "Hilal82e1", false, null, "OSAMA.HILAL82E1@EXAMPLE.COM", "OSAMA.HILAL82E1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEH70qPkLkuHFSC+5swgMaxlnPo2AHAIN2sSEIqP9GhHuP/Euz2CbW3KxaCmm5JMajQ==", "01248547700", false, "4dbd3ab0-c2f5-44e4-b5aa-503f199bf851", false, "Osama.Hilal82e1@example.com" },
                    { "4099ea0b-ed6b-11ed-b0ef-105badc84798", 0, "abc2337c-69c8-4017-b243-d014287e7c55", "Moses.Hilaliaa93@example.com", true, "Moses", "Hilaliaa93", false, null, "MOSES.HILALIAA93@EXAMPLE.COM", "MOSES.HILALIAA93@EXAMPLE.COM", "AQAAAAEAACcQAAAAECr5NRwNAfGXOnMk0XV0DQpQkJ1AUtBjvdZzGzVnMcIUQizpMCSG0A5A+hVlC9hg1A==", "01298932026", false, "0d073099-02b1-4b0b-91c4-4e59d24fdbbe", false, "Moses.Hilaliaa93@example.com" },
                    { "4099ea0d-ed6b-11ed-aa2b-105badc84798", 0, "3040219d-e00e-41ac-a49e-9b1026d0c5c9", "Omar.Kahterb214@example.com", true, "Omar", "Kahterb214", false, null, "OMAR.KAHTERB214@EXAMPLE.COM", "OMAR.KAHTERB214@EXAMPLE.COM", "AQAAAAEAACcQAAAAENUSDHkKSZvShexDyJvIGZ0+ojVW3bLpM3NxYX18YNr0ZUntbtb1ppfZOuRAhfAFJg==", "01280480167", false, "5f399fe7-3af6-44d0-872c-b3881a9b7a25", false, "Omar.Kahterb214@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4099ea0f-ed6b-11ed-9d4e-105badc84798", 0, "2496aa16-e2d1-41a4-bf4d-204ee72dfacd", "Dahi.Basselaed6@example.com", true, "Dahi", "Basselaed6", false, null, "DAHI.BASSELAED6@EXAMPLE.COM", "DAHI.BASSELAED6@EXAMPLE.COM", "AQAAAAEAACcQAAAAELX8NvCV70YUJy9OMLFUk4A5t617sqqxfecIOStyeD7vOXI5ZUBV0d99AtY82aLzxw==", "01243086819", false, "0937a298-197a-47ef-9691-87568ca5f3d6", false, "Dahi.Basselaed6@example.com" },
                    { "4099ea11-ed6b-11ed-8a4f-105badc84798", 0, "86522d69-4dee-41b5-9d58-51a56019b8a5", "Fidaa.Yusuf9983@example.com", true, "Fidaa", "Yusuf9983", false, null, "FIDAA.YUSUF9983@EXAMPLE.COM", "FIDAA.YUSUF9983@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOWa0vpmiRD7Yn/3mkqgQZYkL0fCb5ckRWiDX3TdLCVsiRxPDN96LuxaOp2am4O2wQ==", "01230841385", false, "9d633644-1cf1-4ea7-b240-129f690244fb", false, "Fidaa.Yusuf9983@example.com" },
                    { "4099ea13-ed6b-11ed-839a-105badc84798", 0, "f4d29de0-4b02-437f-b76a-31fa500414fe", "Kamel.Danielb073@example.com", true, "Kamel", "Danielb073", false, null, "KAMEL.DANIELB073@EXAMPLE.COM", "KAMEL.DANIELB073@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJJwHU2y1R2Q8wqBgIiPEvPJlXEu8QscMPPQ2zEeSRhwJpDLtc9IQbNJIHH/4HiyeQ==", "01241136225", false, "aba13f26-71cd-43d3-93ed-2131d3b8206f", false, "Kamel.Danielb073@example.com" },
                    { "4099ea15-ed6b-11ed-8dbe-105badc84798", 0, "acf37e66-b6f2-47e2-9064-d7352f9ab1a7", "Ghanem.Maleka044@example.com", true, "Ghanem", "Maleka044", false, null, "GHANEM.MALEKA044@EXAMPLE.COM", "GHANEM.MALEKA044@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMlWSawmHdG0DquCWhONsHwWrgSPy5tfNqQEr4nG2GE6JcWB+SHTS4KHf9P31qafOw==", "01251094640", false, "cf5edaf1-f8eb-49e3-9227-5759b1be40db", false, "Ghanem.Maleka044@example.com" },
                    { "4099ea17-ed6b-11ed-bb52-105badc84798", 0, "617cf46e-9843-498e-93c8-2bc98656e69c", "Jawad.Mahmoudb443@example.com", true, "Jawad", "Mahmoudb443", false, null, "JAWAD.MAHMOUDB443@EXAMPLE.COM", "JAWAD.MAHMOUDB443@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMCOOKV1svh+TdUYgk9j1d0Wo0+CjxFOSw0OxIF6Se+XWfsYevja9vAX5yDdnPs62w==", "01278247237", false, "2cdb63c1-71f9-4a4d-adb9-f7258cb3fb06", false, "Jawad.Mahmoudb443@example.com" },
                    { "4099ea19-ed6b-11ed-85c8-105badc84798", 0, "3ee4bed0-ad71-4377-8151-6056e903355d", "Kamel.Danielaa21@example.com", true, "Kamel", "Danielaa21", false, null, "KAMEL.DANIELAA21@EXAMPLE.COM", "KAMEL.DANIELAA21@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKvUoG/tRGMQJCVUwneXnHotDPU4Q93iww+XtU8sYNGRkE/OxFEKN4qqCTGuX1c7Gg==", "01234246942", false, "7c201a2e-f7e7-4d30-a38e-76a56416b160", false, "Kamel.Danielaa21@example.com" },
                    { "4099ea1b-ed6b-11ed-b4c0-105badc84798", 0, "5ff3e9c0-9ff5-4774-be16-0e498ff7e091", "Kahter.Danielab00@example.com", true, "Kahter", "Danielab00", false, null, "KAHTER.DANIELAB00@EXAMPLE.COM", "KAHTER.DANIELAB00@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJf/ijE5Ceu0qJDbQpC3R321rc6kZ+HFQ0JahwDNhodoUnQcK4v3VURnET+wHxY2kg==", "01214469178", false, "a4c60e95-2304-48c8-977a-63fab5af489d", false, "Kahter.Danielab00@example.com" },
                    { "4099ea1d-ed6b-11ed-a4c6-105badc84798", 0, "6a3fd390-2119-4532-917f-5a83133a9c43", "Idris.Goodbaab@example.com", true, "Idris", "Goodbaab", false, null, "IDRIS.GOODBAAB@EXAMPLE.COM", "IDRIS.GOODBAAB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKCM73NfxuKOHvwBrQVghHL2b8q6/tnsFPGv2p04FuYgyRfa9VoOYu0U5MK/8mCT2Q==", "01275050210", false, "c43573b4-55c0-4823-9cd1-626f02e659af", false, "Idris.Goodbaab@example.com" },
                    { "4099ea1f-ed6b-11ed-9f62-105badc84798", 0, "33da716c-bf85-4e20-889f-1162b4461ca3", "Badri.Turki86e8@example.com", true, "Badri", "Turki86e8", false, null, "BADRI.TURKI86E8@EXAMPLE.COM", "BADRI.TURKI86E8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEARytZtIDwr8rpYv/s7bNCuxpRVLTuW7sTGH076gr/TIQFJ4ZrDVUP295S0WFHRKGg==", "01296658918", false, "c59f7993-05c7-44b2-a4a3-693fe2360371", false, "Badri.Turki86e8@example.com" },
                    { "409b2251-ed6b-11ed-9a82-105badc84798", 0, "27f784f4-286b-4f34-9540-5f13dca79deb", "Hilal.Sajidab3b@example.com", true, "Hilal", "Sajidab3b", false, null, "HILAL.SAJIDAB3B@EXAMPLE.COM", "HILAL.SAJIDAB3B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJlr97lEIouJVHJL1toGpq7a+bRaUNPOqFKCvY4O+nYd7oJtm+LOacFkXsKYD25qow==", "01269184301", false, "b1ec760d-633f-4466-b315-5b85e2e13e5a", false, "Hilal.Sajidab3b@example.com" },
                    { "409b2253-ed6b-11ed-b650-105badc84798", 0, "2598557e-1391-4d87-9834-839964562a55", "Nahar.Kahterb7e4@example.com", true, "Nahar", "Kahterb7e4", false, null, "NAHAR.KAHTERB7E4@EXAMPLE.COM", "NAHAR.KAHTERB7E4@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMyTE2ftGCi98mU0wGXpJmyYVOA3p4M4xkTo9jZTCC3xl2j/Gk8CeDFQsVaoukB94A==", "01299448511", false, "115967e4-8267-471e-a68c-eb42ed3fa838", false, "Nahar.Kahterb7e4@example.com" },
                    { "409b2255-ed6b-11ed-87ce-105badc84798", 0, "2aa4cf1e-0186-420b-b425-db46008a42d8", "Badri.​​Karim8bc1@example.com", true, "Badri", "​​Karim8bc1", false, null, "BADRI.​​KARIM8BC1@EXAMPLE.COM", "BADRI.​​KARIM8BC1@EXAMPLE.COM", "AQAAAAEAACcQAAAAELEPvARarRxJw9H7j7KQW8OTCb2NKRrlLsyxuS4hj5mnWBefk6ILqRBeNuE8M0j9mA==", "01258445075", false, "c172e3a3-b424-46e9-98ac-6b410ccd6a02", false, "Badri.​​Karim8bc1@example.com" },
                    { "409b2257-ed6b-11ed-8f44-105badc84798", 0, "a0c79e3a-556c-4d11-b4df-0fc683dfaece", "Noor.Mahmoudaee2@example.com", true, "Noor", "Mahmoudaee2", false, null, "NOOR.MAHMOUDAEE2@EXAMPLE.COM", "NOOR.MAHMOUDAEE2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPZ55TWr2CXZNNyMAyfoKNqVADwqSUxYsRublnVb7PDntdN/tj8u2aXEzlnmBMUUDA==", "01224192049", false, "21166bb7-d85f-4e34-b418-186ab74fbd6b", false, "Noor.Mahmoudaee2@example.com" },
                    { "409b2259-ed6b-11ed-ac78-105badc84798", 0, "77038238-10e0-458f-8d92-7ebe5d6a8e46", "Zarif.Asamib250@example.com", true, "Zarif", "Asamib250", false, null, "ZARIF.ASAMIB250@EXAMPLE.COM", "ZARIF.ASAMIB250@EXAMPLE.COM", "AQAAAAEAACcQAAAAEG+oBNTsTBF/qnRiLSDvDvaadhyzZvCc900kK3c/XO/HObb4IJ+I5+0AsiJbwo7Oqg==", "01279796291", false, "3d8bc33c-8a20-4e3b-aa2e-a9bd5c41a254", false, "Zarif.Asamib250@example.com" },
                    { "409b225b-ed6b-11ed-bf67-105badc84798", 0, "fe4a531e-e786-488e-843a-a29937d4d90d", "Barra.Osamaa94c@example.com", true, "Barra", "Osamaa94c", false, null, "BARRA.OSAMAA94C@EXAMPLE.COM", "BARRA.OSAMAA94C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOZqafKJsr9eF2hxMWwm4eLVgbJpB/mVUQeaWSHpeZSn/4cyoRDlKjLAhaWz6CibNA==", "01265372285", false, "fa41cec4-c833-4c53-a3b0-c0e8377c4f1f", false, "Barra.Osamaa94c@example.com" },
                    { "409b225d-ed6b-11ed-8369-105badc84798", 0, "66b930d6-f48c-47c5-8a2e-9353eed92b5c", "Jika.Sameh99c4@example.com", true, "Jika", "Sameh99c4", false, null, "JIKA.SAMEH99C4@EXAMPLE.COM", "JIKA.SAMEH99C4@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJZcdEp0ghrvZsEO7siUBZA6bAB5CT8GfhXDNswH0mcsPmRW4cBqZQ0uXRTh/4hPMw==", "01224100592", false, "ffdea0a8-be90-4992-9713-df05b511083e", false, "Jika.Sameh99c4@example.com" },
                    { "409b225f-ed6b-11ed-8d6a-105badc84798", 0, "6be933be-ce36-457d-b23c-c8bf638e1983", "Wael.​​Karim9585@example.com", true, "Wael", "​​Karim9585", false, null, "WAEL.​​KARIM9585@EXAMPLE.COM", "WAEL.​​KARIM9585@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOsOJXf+LdypmERhCP+d7TtnC8WGBE/OPTlyZ6T7Y/HzF4IAq1yN8r0A7HHDNqLizw==", "01270034864", false, "3ed17036-b00b-45b3-a45e-31b1a5f6beda", false, "Wael.​​Karim9585@example.com" },
                    { "409b2261-ed6b-11ed-b7f8-105badc84798", 0, "ed6b727b-bd50-46a0-a0fd-1b913efe142d", "Hilal.Faisal9236@example.com", true, "Hilal", "Faisal9236", false, null, "HILAL.FAISAL9236@EXAMPLE.COM", "HILAL.FAISAL9236@EXAMPLE.COM", "AQAAAAEAACcQAAAAELu2JDV6HdyR2Vv/UASPdroT1PXobbuPGcJQ0+JwboDOMV226a0Tq98aL/cj8MtCcw==", "01221565927", false, "432fdf8b-dd27-40a1-bd59-9f6bfd554934", false, "Hilal.Faisal9236@example.com" },
                    { "409b2263-ed6b-11ed-93b0-105badc84798", 0, "bc498daf-d4c6-4bf3-8896-b06d301f4037", "Adel.Bahir82d6@example.com", true, "Adel", "Bahir82d6", false, null, "ADEL.BAHIR82D6@EXAMPLE.COM", "ADEL.BAHIR82D6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKTgcNjMMfyEPBdF2N63354mdmC1fNu0AmSIGUHg/pzsZUWN5KrqGV5g3FwHXIZNkw==", "01276197853", false, "350dad64-d12c-4a7c-bb9b-e67f3d8193d5", false, "Adel.Bahir82d6@example.com" },
                    { "409b2265-ed6b-11ed-8a51-105badc84798", 0, "06cd0528-7803-427f-9d1a-da17852c29e2", "Mahmoud.Daniel964c@example.com", true, "Mahmoud", "Daniel964c", false, null, "MAHMOUD.DANIEL964C@EXAMPLE.COM", "MAHMOUD.DANIEL964C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFYLSS3v6KpAPOkuWIqchQy1OwzPlfC14bXlOF1V6QEioCsRGwEv3uiz4+OPmHnrkw==", "01244504780", false, "9de92377-e44f-478d-806b-7f95880b95eb", false, "Mahmoud.Daniel964c@example.com" },
                    { "409b2267-ed6b-11ed-9ed8-105badc84798", 0, "d0124443-f99a-4416-ba63-88b97ab00712", "Adel.Hamaki94da@example.com", true, "Adel", "Hamaki94da", false, null, "ADEL.HAMAKI94DA@EXAMPLE.COM", "ADEL.HAMAKI94DA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEM+lk0p1tIwLcTS9RQsXmAEWRhr+vLzOBHsEEGwAYf7Nqf98bNCGbwTyXWKDfOp59Q==", "01227940951", false, "627cfedd-50dd-4696-85bc-fb73cb48e7fc", false, "Adel.Hamaki94da@example.com" },
                    { "409b2269-ed6b-11ed-96a1-105badc84798", 0, "c878efa7-856a-4e6a-bd96-5a3b52cc1dd4", "Adham.Basembae6@example.com", true, "Adham", "Basembae6", false, null, "ADHAM.BASEMBAE6@EXAMPLE.COM", "ADHAM.BASEMBAE6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKvc5IhbZPesxa/06j+2R/on/rQF4DIVpemzVmbOHYBczGEu1OuJxIsisCl1JvNZ7Q==", "01295804031", false, "a15b165e-3088-4c14-95b8-6168f5f5439c", false, "Adham.Basembae6@example.com" },
                    { "409b226b-ed6b-11ed-b5d0-105badc84798", 0, "1a8f26bf-b81e-4dfe-8bb1-ad3d8bf999ec", "Lail.Bilalbdd5@example.com", true, "Lail", "Bilalbdd5", false, null, "LAIL.BILALBDD5@EXAMPLE.COM", "LAIL.BILALBDD5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJQaPtx1sVD9EWnAvqbQIYX3OKPZ0Lykjq6RTHTQ6mJxexE+DrSOiB2HakEHLjh8Qw==", "01264886434", false, "c743d993-f504-4473-8706-f39bdd438c0e", false, "Lail.Bilalbdd5@example.com" },
                    { "409b226d-ed6b-11ed-9578-105badc84798", 0, "5794c684-9ea8-46e5-9a8b-0d0ae638b80f", "Bara.Badri8be3@example.com", true, "Bara", "Badri8be3", false, null, "BARA.BADRI8BE3@EXAMPLE.COM", "BARA.BADRI8BE3@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFgMs1X5MkvQOATSnh1HF2vsyIfzDanwxvywpmUv4BWoixPfBHpdBWhg3A+uYvzBVA==", "01232443399", false, "c536f806-b6a6-4843-85dc-dac7ea3c5939", false, "Bara.Badri8be3@example.com" },
                    { "409b226f-ed6b-11ed-af75-105badc84798", 0, "e9a17ed0-2797-445c-b217-0a86590770a5", "Sheikh.Sheikha7a4@example.com", true, "Sheikh", "Sheikha7a4", false, null, "SHEIKH.SHEIKHA7A4@EXAMPLE.COM", "SHEIKH.SHEIKHA7A4@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHvh0IYcp0Gi1wptzpeOnkmDwgIvTUMcDm4Q+ZD5F5BUE3pIQnusu5KoVuBWwdva6g==", "01245074460", false, "072cb270-7df2-4697-8b34-d0ec6a18e11e", false, "Sheikh.Sheikha7a4@example.com" },
                    { "409b2271-ed6b-11ed-b13a-105badc84798", 0, "e104c8a7-faf8-47d7-a2f5-56cad77f66fe", "Loay.Hamaqyaf12@example.com", true, "Loay", "Hamaqyaf12", false, null, "LOAY.HAMAQYAF12@EXAMPLE.COM", "LOAY.HAMAQYAF12@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKIcXpnRWKx07q4840n3gLM8E1iA8PtLklvD62R/AEpz6GmtGBHaLVaVGlW0cwFdCw==", "01295630957", false, "adea02ea-5b7c-46b4-9e56-4488f48900ad", false, "Loay.Hamaqyaf12@example.com" },
                    { "409b2273-ed6b-11ed-984c-105badc84798", 0, "30521ea4-d2ff-4d62-b143-9f5ab54c83e5", "Maher.Good90c5@example.com", true, "Maher", "Good90c5", false, null, "MAHER.GOOD90C5@EXAMPLE.COM", "MAHER.GOOD90C5@EXAMPLE.COM", "AQAAAAEAACcQAAAAENd/YGZq4tL7ENLqAInfGedT1vJVF4PBRYyCn0hieR/cuLh88/RTmRX1Y9gRjMRBgA==", "01211245634", false, "7e8bcb86-3cff-48bc-a9d1-0b8a669f2974", false, "Maher.Good90c5@example.com" },
                    { "409b2275-ed6b-11ed-8ea0-105badc84798", 0, "ca878937-a6be-48af-87e4-956b9d3fae53", "Bassam.Russella913@example.com", true, "Bassam", "Russella913", false, null, "BASSAM.RUSSELLA913@EXAMPLE.COM", "BASSAM.RUSSELLA913@EXAMPLE.COM", "AQAAAAEAACcQAAAAEC0qisSI8kmbZQtfVPd5a2k1BKTQNzkxXZE2y2oQyiVpRC51dPajB3QIbQ4dzeWw3w==", "01277681415", false, "a5c02b82-b95c-4d2c-b602-c1bcb66a9192", false, "Bassam.Russella913@example.com" },
                    { "409b2277-ed6b-11ed-a519-105badc84798", 0, "d049e9ec-e1e7-45ac-9232-5f9539d08ab8", "Sheikhy.Jawada4e1@example.com", true, "Sheikhy", "Jawada4e1", false, null, "SHEIKHY.JAWADA4E1@EXAMPLE.COM", "SHEIKHY.JAWADA4E1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOSIMV+g93TnSVAnIcDO7Kq/ewA1icr1HO8mFleesxyaNMMW6uVXPSi2jZTpVQSR/A==", "01249047718", false, "5654be67-7e2a-4338-beee-5dbe118f6121", false, "Sheikhy.Jawada4e1@example.com" },
                    { "409b2279-ed6b-11ed-a66d-105badc84798", 0, "ff16961d-bd80-4a13-ba86-c4766fdad323", "Hassan.Hosni80b2@example.com", true, "Hassan", "Hosni80b2", false, null, "HASSAN.HOSNI80B2@EXAMPLE.COM", "HASSAN.HOSNI80B2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHeTN+Popd0CDrtdUMHxZXOVE9qXGNoPJDEgDZN+iY05KqrDvP1o1cZ4ENVpTp97eg==", "01247655370", false, "e7383f21-825a-4f32-a23d-bcc4ba51423a", false, "Hassan.Hosni80b2@example.com" },
                    { "409b227b-ed6b-11ed-a6a6-105badc84798", 0, "c5a7a064-7fc1-4042-9d05-76c0fc3b13c0", "Minali.Yamen9b11@example.com", true, "Minali", "Yamen9b11", false, null, "MINALI.YAMEN9B11@EXAMPLE.COM", "MINALI.YAMEN9B11@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHVVLH1lJlJNgkcXTnCdkL93nntWGZN3/COZj8Zs8Ku+vBYe/Aenp32CtW4J8XNfGQ==", "01244701551", false, "98245375-34f0-4b1b-b6db-bd2956f5c2e2", false, "Minali.Yamen9b11@example.com" },
                    { "409b227d-ed6b-11ed-b8fd-105badc84798", 0, "7efad39d-2fb8-4b1d-bb5c-db363ff0e043", "Battari.Ghanema3e1@example.com", true, "Battari", "Ghanema3e1", false, null, "BATTARI.GHANEMA3E1@EXAMPLE.COM", "BATTARI.GHANEMA3E1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKQ7yWW6U5G+8aRNqwuu8vPBLnl4WiRxSmn9WZaQDeAh+ytFIAGPfCfdzIYw+c7BcA==", "01261605249", false, "1998c381-b754-4318-b574-cc1d07828c69", false, "Battari.Ghanema3e1@example.com" },
                    { "409b227f-ed6b-11ed-9609-105badc84798", 0, "3b284ac1-d7cf-45b6-8b80-d9a9411e905d", "Yusuf.Maherac9c@example.com", true, "Yusuf", "Maherac9c", false, null, "YUSUF.MAHERAC9C@EXAMPLE.COM", "YUSUF.MAHERAC9C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEO6ONgNQn+tjvce2uZLpn2RJ893gPBNqhtqdDp08NClmtHUag5pYFgzfAY/D10Q50A==", "01293092536", false, "aac6ce0f-d6df-44f9-bd93-ea8f7254428b", false, "Yusuf.Maherac9c@example.com" },
                    { "409b2281-ed6b-11ed-968e-105badc84798", 0, "059dfebe-5659-4795-ae66-772653340b29", "Saree.Idrisb0ef@example.com", true, "Saree", "Idrisb0ef", false, null, "SAREE.IDRISB0EF@EXAMPLE.COM", "SAREE.IDRISB0EF@EXAMPLE.COM", "AQAAAAEAACcQAAAAELAvE2CbrTBezMFZV1GIAqunYmOeDv6TM7sZI5fydtVqVrtDekhqhv7nKI1HPrjcQg==", "01220329770", false, "bc58d655-fe36-4786-be44-00dd71c68a20", false, "Saree.Idrisb0ef@example.com" },
                    { "409b2283-ed6b-11ed-90f7-105badc84798", 0, "bc7eff87-a426-4344-866c-f2d4423f009d", "Adham.Bahiraf53@example.com", true, "Adham", "Bahiraf53", false, null, "ADHAM.BAHIRAF53@EXAMPLE.COM", "ADHAM.BAHIRAF53@EXAMPLE.COM", "AQAAAAEAACcQAAAAEC9dp8rHcoqJDQhDBQuujp5jQBSgagpnn/Z05/i/J/LtqZUI1raXX67yfDX80TBo7A==", "01259225260", false, "acd0a97c-d127-46d9-ba02-916b29f0883c", false, "Adham.Bahiraf53@example.com" },
                    { "409b2285-ed6b-11ed-945d-105badc84798", 0, "04c60682-ad5f-43a0-8146-7d565ea83d86", "Saden.Salim9973@example.com", true, "Saden", "Salim9973", false, null, "SADEN.SALIM9973@EXAMPLE.COM", "SADEN.SALIM9973@EXAMPLE.COM", "AQAAAAEAACcQAAAAEM2f3yJ62IszAGf1f63jxGcPtMEjfOqbKmKMiHIo/ZPA9vZLcc6cJ58mo0yfpnn70g==", "01251768428", false, "4c9b502e-d853-4f85-b95a-57944cf64906", false, "Saden.Salim9973@example.com" },
                    { "409b2287-ed6b-11ed-bdd8-105badc84798", 0, "fc658b47-ff8a-461c-b574-1828e9382532", "Sameh.Hassana203@example.com", true, "Sameh", "Hassana203", false, null, "SAMEH.HASSANA203@EXAMPLE.COM", "SAMEH.HASSANA203@EXAMPLE.COM", "AQAAAAEAACcQAAAAEC5GH6GGPlq+9+Iik4jE0kDYItqM0kKerpIQQrhY+6L3GP7y4nDLPKP/Zv3dtKhhRw==", "01212703009", false, "c40f0c0c-fb03-4fc3-b24b-03d78db9b916", false, "Sameh.Hassana203@example.com" },
                    { "409b2289-ed6b-11ed-8a33-105badc84798", 0, "bf03108c-c211-415e-825d-7c505769f8a3", "Yusuf.Fidaa92d2@example.com", true, "Yusuf", "Fidaa92d2", false, null, "YUSUF.FIDAA92D2@EXAMPLE.COM", "YUSUF.FIDAA92D2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEK5UG2r7yQGzVIo0V8DoaeqbSl+1TPffd+c900ZyRjaQr501nGYAPEGRQnCmhbwGuw==", "01216037425", false, "d2d22f5b-3221-4b73-a5a6-8bc2c72d48a9", false, "Yusuf.Fidaa92d2@example.com" },
                    { "409b228b-ed6b-11ed-82cb-105badc84798", 0, "0d74eb07-f0db-488b-8b8b-04b8d52e88ad", "Dagher.Baraa698@example.com", true, "Dagher", "Baraa698", false, null, "DAGHER.BARAA698@EXAMPLE.COM", "DAGHER.BARAA698@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAFMScMINmLO/sLEC/LRulf9dgQS9iWGBFt3atC3IvWFT+WtOXmPbMPfaFNc3QtPqg==", "01228632027", false, "a6086150-7179-4349-8b6c-9794271ad327", false, "Dagher.Baraa698@example.com" },
                    { "409b228d-ed6b-11ed-9862-105badc84798", 0, "2dfd0afc-17e2-4144-8940-ae36c8cfabaf", "Bassel.Ibrahima080@example.com", true, "Bassel", "Ibrahima080", false, null, "BASSEL.IBRAHIMA080@EXAMPLE.COM", "BASSEL.IBRAHIMA080@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBg2F/N4Y5yF+CUa6P6n5MaJC8bf6ZT06myINNMFXEGoBSr7ra39hYYj78bUpZt+ig==", "01299705532", false, "567665d1-e83b-4313-b630-fc3497263930", false, "Bassel.Ibrahima080@example.com" },
                    { "409b228f-ed6b-11ed-bba0-105badc84798", 0, "66d5e37b-53fe-47a4-87ba-3ddfe80086e3", "Kamel.Samhi885f@example.com", true, "Kamel", "Samhi885f", false, null, "KAMEL.SAMHI885F@EXAMPLE.COM", "KAMEL.SAMHI885F@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDiTKsidx1Uoq3pEwt9dJghNQvyvUvqd6/SStC2bZTRMhF96lr2oYzRhMPtJ+oGCdQ==", "01280062716", false, "6a0d7437-6f6c-40ac-a2e9-1e0a547e13a5", false, "Kamel.Samhi885f@example.com" },
                    { "409b2291-ed6b-11ed-82b0-105badc84798", 0, "b2e529d7-1c52-40ba-b50c-52400fbc7950", "Bara.Fahedb92d@example.com", true, "Bara", "Fahedb92d", false, null, "BARA.FAHEDB92D@EXAMPLE.COM", "BARA.FAHEDB92D@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIp+MXsU6ShteIWJwINtzQ/cfEM8KN0e67T/fK9dx4s2+zbnQmcinKTTTyYCT0Pfrw==", "01272696536", false, "595d8bf1-fcb3-4d6c-ad4b-bad4b108a2ee", false, "Bara.Fahedb92d@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "409b2293-ed6b-11ed-a281-105badc84798", 0, "a93f7b00-0b0a-4cf7-8d87-b749cb996294", "Samhi.Hilal8bd1@example.com", true, "Samhi", "Hilal8bd1", false, null, "SAMHI.HILAL8BD1@EXAMPLE.COM", "SAMHI.HILAL8BD1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGQ352zhZGaUUXOnvMgNH0tUIU7xcABPvUu/VCKgCOyTe2REYqB58NvHMcTNs80lNg==", "01278276213", false, "5fd617ad-f2dc-4f04-86bd-07e13abdc3cc", false, "Samhi.Hilal8bd1@example.com" },
                    { "409b2295-ed6b-11ed-a03f-105badc84798", 0, "5543ab75-fcbb-4deb-bf15-2bf274affb64", "Faisal.Samirbd6b@example.com", true, "Faisal", "Samirbd6b", false, null, "FAISAL.SAMIRBD6B@EXAMPLE.COM", "FAISAL.SAMIRBD6B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBgUNS143pPxNMcrFxDO+qoIAT+qazTG3qvTujQF5ZJZJ5rPWdHoKPS+PykeKcsQ1A==", "01296553303", false, "f5816d3c-97f9-4ebd-90a8-73aa1933f7be", false, "Faisal.Samirbd6b@example.com" },
                    { "409b2297-ed6b-11ed-9620-105badc84798", 0, "8fb43a12-fcc1-42c6-8334-9f753d11851f", "Wael.Sahami86d0@example.com", true, "Wael", "Sahami86d0", false, null, "WAEL.SAHAMI86D0@EXAMPLE.COM", "WAEL.SAHAMI86D0@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDZUws+jvsd9fchi2GyCaQzK9EuyUq6sr564WdvoG6Z86VNHyENILFW9+MDEhuCiWw==", "01283688266", false, "2d2d462b-cf2a-4f68-b6ad-b2d4c8e83a2d", false, "Wael.Sahami86d0@example.com" },
                    { "409b2299-ed6b-11ed-8cd7-105badc84798", 0, "06ec3997-a842-4505-ac6b-094de865c0bc", "Muhammad.Yad826b@example.com", true, "Muhammad", "Yad826b", false, null, "MUHAMMAD.YAD826B@EXAMPLE.COM", "MUHAMMAD.YAD826B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFfhQWuA3ngsX4EHw95sjUPoAyXg/zcby9Iwpg4gNARJBNhmEqGsyO8tJk3Y7SyIBw==", "01241209071", false, "b62c9ea0-6a27-4902-b06e-bf67d3c436a7", false, "Muhammad.Yad826b@example.com" },
                    { "409b229b-ed6b-11ed-b5e4-105badc84798", 0, "6702e095-7382-4975-b0a6-5f19a307f790", "Wael.Bahi97f5@example.com", true, "Wael", "Bahi97f5", false, null, "WAEL.BAHI97F5@EXAMPLE.COM", "WAEL.BAHI97F5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHODTi+uFq0GF966gdpNuh/PP0blNdDmqFZev5qOJdEmUsUtlSGP7qMpHnCZW60lpQ==", "01280616076", false, "df761369-d620-4f10-812c-f91466aa41c2", false, "Wael.Bahi97f5@example.com" },
                    { "409c5ba9-ed6b-11ed-a9f0-105badc84798", 0, "65418af6-dc43-46e5-ab58-d330a0dd7981", "Sameh.Osama98c7@example.com", true, "Sameh", "Osama98c7", false, null, "SAMEH.OSAMA98C7@EXAMPLE.COM", "SAMEH.OSAMA98C7@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBu8rehDzTyuHfPWz+4oFoLWznes0WfvTL2+ixWntlGum9hZIjwz/l5gF+d3DOt12A==", "01242267999", false, "d38ca99a-8ae6-462c-b19b-0c2e4ecd7c3a", false, "Sameh.Osama98c7@example.com" },
                    { "409c5bab-ed6b-11ed-9ebb-105badc84798", 0, "b36abb17-7307-49c5-a9f4-9a6581eef84c", "Dagher.Sareead13@example.com", true, "Dagher", "Sareead13", false, null, "DAGHER.SAREEAD13@EXAMPLE.COM", "DAGHER.SAREEAD13@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEOB1YzSvMCnPfaLL2BnKv96oUqI9N6LlyFVPmSYSp1NnV9IwOOP4KRTTrFlhflK4g==", "01280522970", false, "e513700c-c0e5-43b7-aefc-bfe51ace4880", false, "Dagher.Sareead13@example.com" },
                    { "409c5bad-ed6b-11ed-b06e-105badc84798", 0, "703e444d-e922-4f33-8800-2a88ad6e247c", "Yad.Hamaqy909a@example.com", true, "Yad", "Hamaqy909a", false, null, "YAD.HAMAQY909A@EXAMPLE.COM", "YAD.HAMAQY909A@EXAMPLE.COM", "AQAAAAEAACcQAAAAEA89pq4sNei3cEM0PwyO3JfwW5VDJDB425b7ZowafQmUIVjU3c21SX2b4RqbEM9pRA==", "01268125360", false, "ee7304ad-0684-4413-a1e0-e588c2c10801", false, "Yad.Hamaqy909a@example.com" },
                    { "409c5baf-ed6b-11ed-b43f-105badc84798", 0, "95454562-c1a9-4fe7-bc8d-372b9e24068a", "Bassel.Kamelaef1@example.com", true, "Bassel", "Kamelaef1", false, null, "BASSEL.KAMELAEF1@EXAMPLE.COM", "BASSEL.KAMELAEF1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBPfvQei71ufEnLeCAyCwe8Upu5SZv0wXfAVLebkhptiFfkXzN5oXIgQjYciFQHTHw==", "01281713510", false, "74264f1e-a09e-4223-b9c9-842f68b60c8a", false, "Bassel.Kamelaef1@example.com" },
                    { "409c5bb1-ed6b-11ed-b22e-105badc84798", 0, "af98fea1-b326-445b-bf05-6c0262844716", "Lail.Minali8f58@example.com", true, "Lail", "Minali8f58", false, null, "LAIL.MINALI8F58@EXAMPLE.COM", "LAIL.MINALI8F58@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMRFgRY+SfJV86YLVg0DwrzAPp/hcbkNLizMHzwCYd0w3+wX3h/ahKcKLbD86Jx6dg==", "01211017057", false, "a6964045-d8df-4b69-8bab-bcd78742fb1d", false, "Lail.Minali8f58@example.com" },
                    { "409c5bb3-ed6b-11ed-8aea-105badc84798", 0, "63e72b89-8e14-4e93-8a7e-ea4501ba237b", "Majid.Adlia9c6@example.com", true, "Majid", "Adlia9c6", false, null, "MAJID.ADLIA9C6@EXAMPLE.COM", "MAJID.ADLIA9C6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIyA6z3EZF2celEZMXd6z+vwS702ufSG4xp3feogoOQG3P/spOlL4eFJJAR1tGSjAg==", "01276042209", false, "41b7753b-536f-4b4f-9455-f2add725e346", false, "Majid.Adlia9c6@example.com" },
                    { "409c5bb5-ed6b-11ed-81ec-105badc84798", 0, "ca2840f8-beba-4e88-8276-0c9ba4c9e50e", "Firas.Yakonaf22@example.com", true, "Firas", "Yakonaf22", false, null, "FIRAS.YAKONAF22@EXAMPLE.COM", "FIRAS.YAKONAF22@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIT6v+IVADnGUkJTuFqgI8v6D+Wy0QlPU0lTkRJQW/3xWITAIMd4pIjTFI3LoRY3rg==", "01248361000", false, "2ac40a9f-9202-490b-96a6-645f9a6b772e", false, "Firas.Yakonaf22@example.com" },
                    { "409c5bb7-ed6b-11ed-a54a-105badc84798", 0, "b4589358-ebf2-4426-a2d4-f6151b89cd5b", "Saden.Hassanaf93@example.com", true, "Saden", "Hassanaf93", false, null, "SADEN.HASSANAF93@EXAMPLE.COM", "SADEN.HASSANAF93@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPM3xYq9ugspYI3DkfphrCbxGivzCxjJFRrtladUqaZ3Sc+GHFYx+T5CYr2M3NYYGw==", "01252473730", false, "fd9e32dd-fc91-45bf-b124-4048713fd463", false, "Saden.Hassanaf93@example.com" },
                    { "409c5bb9-ed6b-11ed-a374-105badc84798", 0, "b895c93e-1a64-42b6-b1a1-5975fc47c406", "Helsey.Noor82e8@example.com", true, "Helsey", "Noor82e8", false, null, "HELSEY.NOOR82E8@EXAMPLE.COM", "HELSEY.NOOR82E8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFOVWY0H63AFBgdTggCeL59rEKhHrihFdKeeHrkc7e3hqfVpwvpGlsCPrnkJrinpfA==", "01293212396", false, "d734bc48-0e67-411a-b804-1193c22a1511", false, "Helsey.Noor82e8@example.com" },
                    { "409c5bbb-ed6b-11ed-a145-105badc84798", 0, "189173b3-0680-461c-b8aa-d63fe4461af6", "Ali.Ryan921d@example.com", true, "Ali", "Ryan921d", false, null, "ALI.RYAN921D@EXAMPLE.COM", "ALI.RYAN921D@EXAMPLE.COM", "AQAAAAEAACcQAAAAELOhF+3mZftbGOWVOfVL3JYDh/goLeOrkJcosTaPav6BCz1r0mrECAYwrIVztgipTg==", "01240558815", false, "5266790c-9acf-4163-819e-1b33fed4eed5", false, "Ali.Ryan921d@example.com" },
                    { "409c5bbd-ed6b-11ed-a7f3-105badc84798", 0, "5f9e2798-c816-46bb-a268-85bf1be46667", "Yad.Najm91d8@example.com", true, "Yad", "Najm91d8", false, null, "YAD.NAJM91D8@EXAMPLE.COM", "YAD.NAJM91D8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEF2+hR1UDLQ11xWQikq7Gq+Hr7fGFpOxNcDDEPytzkXAP2TSeA+OiORPm7cBe5744Q==", "01256088190", false, "85d42166-9c9f-4800-98bb-002b7ed9839d", false, "Yad.Najm91d8@example.com" },
                    { "409c5bbf-ed6b-11ed-afcf-105badc84798", 0, "912a9639-68fe-48ee-ba8e-257064fed1d8", "Good.Hilal8ebc@example.com", true, "Good", "Hilal8ebc", false, null, "GOOD.HILAL8EBC@EXAMPLE.COM", "GOOD.HILAL8EBC@EXAMPLE.COM", "AQAAAAEAACcQAAAAEE7+ry3cwDZTdc3pC+X7xtjnWDKXouC0EC57APfIE5QagPL2Rbpe0vyh5TU6YFBjrg==", "01233135538", false, "bea6d472-f25f-4654-88a5-6c994584852e", false, "Good.Hilal8ebc@example.com" },
                    { "409c5bc1-ed6b-11ed-880d-105badc84798", 0, "c00fd3a3-3550-4527-a564-b923911402cc", "Bara.Omar96e5@example.com", true, "Bara", "Omar96e5", false, null, "BARA.OMAR96E5@EXAMPLE.COM", "BARA.OMAR96E5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOiWExYKQGZx7/dXV/UYqGLIBv7kTwvM91SAzI30j8IL6DVqBqH/Kn7t628lgMt1zQ==", "01253668931", false, "4c5177c8-3653-4c37-af5d-4f2fbc4b6b26", false, "Bara.Omar96e5@example.com" },
                    { "409c5bc3-ed6b-11ed-b2b0-105badc84798", 0, "bd53aa2c-144b-447a-ae6f-6892f3fdb0af", "Jika.Faisal9ca6@example.com", true, "Jika", "Faisal9ca6", false, null, "JIKA.FAISAL9CA6@EXAMPLE.COM", "JIKA.FAISAL9CA6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEE1m5tiPS5rYzhrMPjivujhFi7gqhhOLEoek26sXyRF4y0967HOnqw2S4CDCra+AIg==", "01270653239", false, "c4c0bef7-09ed-4acb-b790-0f93de3b17df", false, "Jika.Faisal9ca6@example.com" },
                    { "409c5bc5-ed6b-11ed-9c33-105badc84798", 0, "d52bd70c-48be-4d89-94cd-f3c87cf1d9bf", "Fares.Turkib5c8@example.com", true, "Fares", "Turkib5c8", false, null, "FARES.TURKIB5C8@EXAMPLE.COM", "FARES.TURKIB5C8@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEasRoTOcMeXCsAAHkK0L4hrCj7eixidTAJ4GcFaeGR3dAFdvrJpO7FaI04fmnZktA==", "01298016974", false, "58a98ba1-4070-41f4-b0d5-83531fac09d8", false, "Fares.Turkib5c8@example.com" },
                    { "409c5bc7-ed6b-11ed-a584-105badc84798", 0, "d1785f00-0355-4770-869d-f734bbb91f2f", "Waseem.Zachariah8b80@example.com", true, "Waseem", "Zachariah8b80", false, null, "WASEEM.ZACHARIAH8B80@EXAMPLE.COM", "WASEEM.ZACHARIAH8B80@EXAMPLE.COM", "AQAAAAEAACcQAAAAEH5H4cuz9BIPIsBHgOEm2awsZq6Btyy89xY06tmtSe1eg8hGU5rnmtLCIPskqiLokw==", "01233473594", false, "badc2604-2f3e-48b3-b298-641dc3c3efd3", false, "Waseem.Zachariah8b80@example.com" },
                    { "409c5bc9-ed6b-11ed-94df-105badc84798", 0, "56672706-b0bf-415e-99eb-0ff83e628be0", "Basem.Zaki9209@example.com", true, "Basem", "Zaki9209", false, null, "BASEM.ZAKI9209@EXAMPLE.COM", "BASEM.ZAKI9209@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPjz88FTK0pN2r0NP6mPG1MsDqvVOFkaQ7DcEzyfnVC+OmR28IaC1gxOt5h8Iw5sLw==", "01247188081", false, "10fa507d-64e7-4a1c-a78f-58be172161b7", false, "Basem.Zaki9209@example.com" },
                    { "409c5bcb-ed6b-11ed-ae48-105badc84798", 0, "3fcbcf55-9053-4ecb-8c34-f65a83850f76", "Firas.Fahedb115@example.com", true, "Firas", "Fahedb115", false, null, "FIRAS.FAHEDB115@EXAMPLE.COM", "FIRAS.FAHEDB115@EXAMPLE.COM", "AQAAAAEAACcQAAAAEL/1PJMOAYOUJDdZFmwehPGeUPheinDTGCV8TVAWKeAyhSBV7CzKwBj13qUEV0JFNw==", "01238482001", false, "d4499ce2-574d-46d6-8741-bb28d49b79a8", false, "Firas.Fahedb115@example.com" },
                    { "409c5bcd-ed6b-11ed-82bc-105badc84798", 0, "f2b88b06-1c71-4f61-9546-90db137a540a", "Hilal.Asim8263@example.com", true, "Hilal", "Asim8263", false, null, "HILAL.ASIM8263@EXAMPLE.COM", "HILAL.ASIM8263@EXAMPLE.COM", "AQAAAAEAACcQAAAAEB/c6S+n9FjSrEjd0PER7DThLbyyQtOHyyk7kunbCqhzxxAua9/BHLCCYvGZ4e9TZw==", "01225838899", false, "17c35b8d-7e29-4a1d-b92e-1f8ebc70a50e", false, "Hilal.Asim8263@example.com" },
                    { "409c5bcf-ed6b-11ed-a53b-105badc84798", 0, "1d42e6e6-fa34-4aaf-9902-2d1fddfdb649", "Kamel.Ghanema74f@example.com", true, "Kamel", "Ghanema74f", false, null, "KAMEL.GHANEMA74F@EXAMPLE.COM", "KAMEL.GHANEMA74F@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJO6i64orvrxwVIu5QcbMv94B26pIYPoW04Vz9y61fMSy75xPGN0R2Oni+hFbuAvlA==", "01267168944", false, "f31ab5b3-302e-4138-b878-e5373c0d831e", false, "Kamel.Ghanema74f@example.com" },
                    { "409c5bd1-ed6b-11ed-8709-105badc84798", 0, "cc7a0e50-d217-43a4-bb73-2a4134cd6bd5", "Firas.Adelac4e@example.com", true, "Firas", "Adelac4e", false, null, "FIRAS.ADELAC4E@EXAMPLE.COM", "FIRAS.ADELAC4E@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEz2wnHIrj7p1n+tGh4sAA4mx6pP8QdUWgORCfDUZrrEw8afioXqeOIYhIXnoJJ+9Q==", "01274387720", false, "93a39e78-894f-41ad-a7eb-a6c769444bee", false, "Firas.Adelac4e@example.com" },
                    { "409c5bd3-ed6b-11ed-b60d-105badc84798", 0, "47394810-a1d4-4c37-8d8c-50ddb5b55c2e", "Shehabi.Asamib745@example.com", true, "Shehabi", "Asamib745", false, null, "SHEHABI.ASAMIB745@EXAMPLE.COM", "SHEHABI.ASAMIB745@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAjgmMe6QyErFxOr6VDq2mY7ZOiGU9Efn3PUtmNqOS71AWRJ3ezAo7vOX2Ax8bCieQ==", "01265107277", false, "3848d0d0-2f61-4e98-bf7e-dce24d0b1781", false, "Shehabi.Asamib745@example.com" },
                    { "409c5bd5-ed6b-11ed-92ef-105badc84798", 0, "ad1843aa-1c0e-4a8e-bac3-76a85e021175", "Adam.Ryanbb23@example.com", true, "Adam", "Ryanbb23", false, null, "ADAM.RYANBB23@EXAMPLE.COM", "ADAM.RYANBB23@EXAMPLE.COM", "AQAAAAEAACcQAAAAEK93mkzIfv5mKrlWgdJ1XsZfQqnKypXgfa5AaDYoCWkdowgsTNxy0uxBp1DCuJOHTg==", "01230210003", false, "b7891ffc-3cff-4534-bc45-611d6837d270", false, "Adam.Ryanbb23@example.com" },
                    { "409c5bd7-ed6b-11ed-8e67-105badc84798", 0, "0a82a81b-7863-48a0-88e4-3fcf3c30e340", "Yunus.Ahmed90cb@example.com", true, "Yunus", "Ahmed90cb", false, null, "YUNUS.AHMED90CB@EXAMPLE.COM", "YUNUS.AHMED90CB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEA6cuWh+uds/sT9HU5INssCH/W5M2Ahiuq0PuieKsSb3a21qzKUkIjpkJbAgIdDcHw==", "01235122474", false, "d5ba6879-e347-46f9-9272-69630021447d", false, "Yunus.Ahmed90cb@example.com" },
                    { "409c5bd9-ed6b-11ed-aac6-105badc84798", 0, "4626f386-97ef-4c7b-9cef-f19ad5ebc29b", "Kamel.Hassan8f33@example.com", true, "Kamel", "Hassan8f33", false, null, "KAMEL.HASSAN8F33@EXAMPLE.COM", "KAMEL.HASSAN8F33@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHx8Mw4SFcc9juDM5wl51axXR74D3L6suprb/aAwxj0DkdfDnX5U0K8DIoKptXqHPg==", "01243061369", false, "07904ea5-5199-4b5a-b74a-0fa0e114e311", false, "Kamel.Hassan8f33@example.com" },
                    { "409c5bdb-ed6b-11ed-9c54-105badc84798", 0, "b561eca4-6091-4ba9-8acb-00dc65c89084", "Sharm.Haor9abe@example.com", true, "Sharm", "Haor9abe", false, null, "SHARM.HAOR9ABE@EXAMPLE.COM", "SHARM.HAOR9ABE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOEQy7zX/w3mmKqKmGMwnjzoBhDusdH6lqsAbAIf2HOrenARQ1S0F71uAunYCzee6g==", "01256605664", false, "6b3629ba-2733-4d04-9bec-de8bfa736bb3", false, "Sharm.Haor9abe@example.com" },
                    { "409c5bdd-ed6b-11ed-9d5b-105badc84798", 0, "535e0330-1082-4422-a0bf-43da203bce27", "Shehabi.Radwanaea9@example.com", true, "Shehabi", "Radwanaea9", false, null, "SHEHABI.RADWANAEA9@EXAMPLE.COM", "SHEHABI.RADWANAEA9@EXAMPLE.COM", "AQAAAAEAACcQAAAAEN4qZmmrNeS786/yFE/S2IVFPpW/LV1L4QNZFeX+NIcR9j/KDkKUYVRBa9Dxtw9UXw==", "01247779098", false, "3661a0c9-e7a9-46e8-87ac-5cfb9e92ba9d", false, "Shehabi.Radwanaea9@example.com" },
                    { "409c5bdf-ed6b-11ed-8964-105badc84798", 0, "1263f647-508f-456a-9c9f-84728435ad8f", "Sandsi.Sareea2bb@example.com", true, "Sandsi", "Sareea2bb", false, null, "SANDSI.SAREEA2BB@EXAMPLE.COM", "SANDSI.SAREEA2BB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMbaWhXT6HJmvbmXhrQ8dZJq/ymiwCJAVHtVj+zqm99qLqinbrNxGCWiVSbz7OIEpw==", "01295119441", false, "7911be72-8b36-470f-855c-c96ca40337c7", false, "Sandsi.Sareea2bb@example.com" },
                    { "409c5be1-ed6b-11ed-858f-105badc84798", 0, "d33a8e2b-a4e4-4615-a1d8-a0ff87f9467d", "Ryan.Ahmed92cc@example.com", true, "Ryan", "Ahmed92cc", false, null, "RYAN.AHMED92CC@EXAMPLE.COM", "RYAN.AHMED92CC@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDrekRihND0SsEggTl/x9b4bjw68f1NPYtchtWLvCGo35VyWTkP/2yIFZDE8uL/wFA==", "01280497409", false, "96123d6e-1cd9-4c47-9699-e9b98c27c95f", false, "Ryan.Ahmed92cc@example.com" },
                    { "409c5be3-ed6b-11ed-a6f1-105badc84798", 0, "2e8e2aed-9c8b-4d8b-90ef-7e54b55448c6", "Jika.Yakon99b9@example.com", true, "Jika", "Yakon99b9", false, null, "JIKA.YAKON99B9@EXAMPLE.COM", "JIKA.YAKON99B9@EXAMPLE.COM", "AQAAAAEAACcQAAAAENPduh2IpFeukGF0V325QDYnPsSBIhQ1BaG2EgRcFiqqDKiUEodLNaisWGZ5Xlu+Zg==", "01264045710", false, "afad1725-2357-4a32-9ba0-c136ee6c6389", false, "Jika.Yakon99b9@example.com" },
                    { "409c5be5-ed6b-11ed-b9bc-105badc84798", 0, "610cd358-3cc1-43a4-a787-b6ec9ddc8ec9", "Salim.Barrab361@example.com", true, "Salim", "Barrab361", false, null, "SALIM.BARRAB361@EXAMPLE.COM", "SALIM.BARRAB361@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPYeuDS2ns1VBpAzeQ4YPh5y/gaHTED1D29hWJpcUfriYqKJkNvOxQoiC1dVn51/PQ==", "01249320959", false, "1ce5dd91-9795-43e6-993f-a95718190f44", false, "Salim.Barrab361@example.com" },
                    { "409c5be7-ed6b-11ed-a4c2-105badc84798", 0, "77447fc0-4bb2-4130-a377-a2254d587446", "Sajid.Ghanemb2c7@example.com", true, "Sajid", "Ghanemb2c7", false, null, "SAJID.GHANEMB2C7@EXAMPLE.COM", "SAJID.GHANEMB2C7@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBVas/kM5MLli8BV0AwFdRIbxZGMk+sXR4WJPw64MA76NZD4sAK7fD9g+o+MQYmkPQ==", "01277246579", false, "f7fb18fa-739e-47ed-b9d2-37ad25009d09", false, "Sajid.Ghanemb2c7@example.com" },
                    { "409c5be9-ed6b-11ed-84f0-105badc84798", 0, "215ac782-e228-4e94-ac00-ec73a5600c86", "Abi.Naharbab5@example.com", true, "Abi", "Naharbab5", false, null, "ABI.NAHARBAB5@EXAMPLE.COM", "ABI.NAHARBAB5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEN+zmdQZeqs/ZR1Frk39VoKc8CNhlzlT7gEe2w0j1ExtdkrDhKNCgDi+jSCGZXn5tA==", "01229234023", false, "54cbddb6-3b1b-4807-bb49-436ed7837225", false, "Abi.Naharbab5@example.com" },
                    { "409c5beb-ed6b-11ed-9119-105badc84798", 0, "d77b2ba6-a602-41e0-9844-f3cb3c0625ff", "Sheikhy.Bahib9c1@example.com", true, "Sheikhy", "Bahib9c1", false, null, "SHEIKHY.BAHIB9C1@EXAMPLE.COM", "SHEIKHY.BAHIB9C1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMDKyOEuGTxpFvyRq7Tg3rlDOlnvFrpa+9IrEVoPcPEsDK7C9G0lYpK487HhftUTWA==", "01253380211", false, "d9a8df13-af65-4aba-93e7-5ce55e112739", false, "Sheikhy.Bahib9c1@example.com" },
                    { "409c5bed-ed6b-11ed-b13d-105badc84798", 0, "facf2e82-9fe8-47aa-b272-2e225147ca4b", "Russell.Noor98e2@example.com", true, "Russell", "Noor98e2", false, null, "RUSSELL.NOOR98E2@EXAMPLE.COM", "RUSSELL.NOOR98E2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAZEPFkfU7Kcq/BSl+rq2odQcHDmsFtua93Ir+jTGCkUZGKmi+OwrhMWy7jUk15nww==", "01270799028", false, "e763a15c-4151-44f7-a2ba-83ceb6c06d3c", false, "Russell.Noor98e2@example.com" },
                    { "409c5bef-ed6b-11ed-a904-105badc84798", 0, "d2f9da37-1ffd-4b94-b57d-8f4155a5ee1d", "Kamel.Turkiac4a@example.com", true, "Kamel", "Turkiac4a", false, null, "KAMEL.TURKIAC4A@EXAMPLE.COM", "KAMEL.TURKIAC4A@EXAMPLE.COM", "AQAAAAEAACcQAAAAELWakcpHCBW0Mp6vIyqD/RrgwACB6TJpzC5bzTnM39M5++XNA9bFjV8D/mZMs5nwDw==", "01241657516", false, "2a11208f-d460-4057-b895-a83a4d9b520e", false, "Kamel.Turkiac4a@example.com" },
                    { "409c5bf1-ed6b-11ed-88f4-105badc84798", 0, "ecd623f9-7b96-43df-9a59-9cc4fd0a4595", "Nahar.Ghanemae00@example.com", true, "Nahar", "Ghanemae00", false, null, "NAHAR.GHANEMAE00@EXAMPLE.COM", "NAHAR.GHANEMAE00@EXAMPLE.COM", "AQAAAAEAACcQAAAAEE9QhHCPRqtlAID9VhQDfsc8qZbOML3oB3AnJrJylmi27VkQcy0zuAZu1pgCNTajOw==", "01298809343", false, "42737489-7202-4d0e-9b7b-2977a0145257", false, "Nahar.Ghanemae00@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "409c5bf3-ed6b-11ed-b6f9-105badc84798", 0, "52eb549a-cab2-4d47-ad15-bc2f5c09f4f4", "Jawad.Hosni8716@example.com", true, "Jawad", "Hosni8716", false, null, "JAWAD.HOSNI8716@EXAMPLE.COM", "JAWAD.HOSNI8716@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJMa7fQNcHeR4zS8S0kImAa8WaxljExEMjwQlOxPMXD2fCnHiWkbs5Q9VEkWSdRnwA==", "01234781463", false, "e3a2a62d-1d16-4ff3-af79-6297e731fafb", false, "Jawad.Hosni8716@example.com" },
                    { "409c5bf5-ed6b-11ed-b0e0-105badc84798", 0, "83f8b8e2-f044-47ef-baaf-1b3a3f27a7b8", "Zaki.Maher89ed@example.com", true, "Zaki", "Maher89ed", false, null, "ZAKI.MAHER89ED@EXAMPLE.COM", "ZAKI.MAHER89ED@EXAMPLE.COM", "AQAAAAEAACcQAAAAENSxmC1LHwkuhX1jzuB9uTI5fbNTQ0jHZblBQ0r2fVKLndDi61OdlPeyRwNy4+mEGw==", "01218202776", false, "4a33a620-d37a-4ac1-9041-82b7761866ef", false, "Zaki.Maher89ed@example.com" },
                    { "409d97e6-ed6b-11ed-8b4d-105badc84798", 0, "034f04b5-d7b3-4525-9864-fa0e0edf3fd8", "Ramzy.Sadenb6a1@example.com", true, "Ramzy", "Sadenb6a1", false, null, "RAMZY.SADENB6A1@EXAMPLE.COM", "RAMZY.SADENB6A1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFPmAZ9elu3oGkm+qNWSZPd+n5Iu8M0V9uUuvoCs1XSrY/iKMCTIhbF65gnsgt0Ffw==", "01241175282", false, "a541c628-aa89-4549-8277-2badc864b87d", false, "Ramzy.Sadenb6a1@example.com" },
                    { "409d97e8-ed6b-11ed-94e7-105badc84798", 0, "36e55692-f8a1-430e-9173-34f52544432e", "Basem.Ryan8fc1@example.com", true, "Basem", "Ryan8fc1", false, null, "BASEM.RYAN8FC1@EXAMPLE.COM", "BASEM.RYAN8FC1@EXAMPLE.COM", "AQAAAAEAACcQAAAAELo+gbWMxdUoDcAcTz5m9DF7mvyCAI2cN/DQJ++r4Pf9Y2fw92OQCxMA2kLuGHQs7g==", "01250561427", false, "f0f4c8a3-e837-4d13-8604-6e49fd530e73", false, "Basem.Ryan8fc1@example.com" },
                    { "409d97ea-ed6b-11ed-8bcf-105badc84798", 0, "3bdb5f8e-d9f7-4812-ab19-2c1fb113fe67", "Yunus.Latfi8cca@example.com", true, "Yunus", "Latfi8cca", false, null, "YUNUS.LATFI8CCA@EXAMPLE.COM", "YUNUS.LATFI8CCA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEI7/p3G3YFbjiE+QFJVB9KAT2aR5/DEcB+MGhuX/SFcR+gMeUlKVJKcstMbbFkzGKw==", "01249864317", false, "b647415f-e1d7-47a5-a1a9-2e3e9518cead", false, "Yunus.Latfi8cca@example.com" },
                    { "409d97ec-ed6b-11ed-b463-105badc84798", 0, "10c6f68b-663d-4174-8840-719b48dc84f5", "Moses.Idrisb202@example.com", true, "Moses", "Idrisb202", false, null, "MOSES.IDRISB202@EXAMPLE.COM", "MOSES.IDRISB202@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHLabDaVX9v4VGV3LsfC7soEqeVHkQPbr67zXkDcwjdJnmHUi1JLkqIHH2W1L5Nc9A==", "01230711192", false, "fa3da2ad-c914-49dd-88e0-3b187e9c3e34", false, "Moses.Idrisb202@example.com" },
                    { "409d97ee-ed6b-11ed-bbdf-105badc84798", 0, "67b62711-776c-4dec-839d-5a5e02d681ed", "Sheikhy.Ahmedb0a5@example.com", true, "Sheikhy", "Ahmedb0a5", false, null, "SHEIKHY.AHMEDB0A5@EXAMPLE.COM", "SHEIKHY.AHMEDB0A5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFPzBiDs5j7ddElT0xZyuAbGo9c0Vsk+2pr5Q9mI+zCS/FF4KMt0mDnqes8NBIksYQ==", "01231051799", false, "e1b6e459-1f3c-4071-8cfd-89b4e6af4fc3", false, "Sheikhy.Ahmedb0a5@example.com" },
                    { "409d97f0-ed6b-11ed-90bb-105badc84798", 0, "088037c5-eb20-448a-b8aa-aef4d657e904", "Kafar.Barra8ef2@example.com", true, "Kafar", "Barra8ef2", false, null, "KAFAR.BARRA8EF2@EXAMPLE.COM", "KAFAR.BARRA8EF2@EXAMPLE.COM", "AQAAAAEAACcQAAAAECOGKGGpn/Yn34UJAKHUoCruv7yaOfHXOVm8PYpWV6uDYXZ5W9WAVzAJnXhUPRGBSg==", "01239050976", false, "3693e73b-e10e-4af4-9895-e0386ed0b59d", false, "Kafar.Barra8ef2@example.com" },
                    { "409d97f2-ed6b-11ed-a6cf-105badc84798", 0, "80b37982-46e4-4875-9fa3-7bc7c7e7adbf", "Hamaki.Fahedadad@example.com", true, "Hamaki", "Fahedadad", false, null, "HAMAKI.FAHEDADAD@EXAMPLE.COM", "HAMAKI.FAHEDADAD@EXAMPLE.COM", "AQAAAAEAACcQAAAAEH6SRkJZP3fazBjJfuDMPA0lZwnkP+yhQaOtJC/SU6Lx06fIcJSw+ty6TsdEXkf/bw==", "01259193188", false, "8afe264e-a42c-4b3b-bafc-4db1f0846d7c", false, "Hamaki.Fahedadad@example.com" },
                    { "409d97f4-ed6b-11ed-bb0c-105badc84798", 0, "89280ddb-5e40-46a2-a54d-ee12462ca770", "Hilal.Yamen95c6@example.com", true, "Hilal", "Yamen95c6", false, null, "HILAL.YAMEN95C6@EXAMPLE.COM", "HILAL.YAMEN95C6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFSPEvRUPnFEZa/bsHDJ5T2G3ViRgBg4LXzENPxYsj/skgs+nxsQvOndjrigh3TS5Q==", "01242866984", false, "3ac80c55-42b9-4577-8c70-6dc4eb1dbd3f", false, "Hilal.Yamen95c6@example.com" },
                    { "409d97f6-ed6b-11ed-a3b6-105badc84798", 0, "669a0aff-75db-4b8d-9f6a-52bf348fd362", "Hilali.Saree8dd1@example.com", true, "Hilali", "Saree8dd1", false, null, "HILALI.SAREE8DD1@EXAMPLE.COM", "HILALI.SAREE8DD1@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPBkZzwUIA/ev5ZCPjwTOksnz22jFG4VhblkTvf/mT7TeHSZS6hxKMM+EYG6RAtpVw==", "01223988031", false, "19b34617-8d0e-40d4-9869-09f177331218", false, "Hilali.Saree8dd1@example.com" },
                    { "409d97f8-ed6b-11ed-9814-105badc84798", 0, "c275a06c-19f7-447b-bc99-6fd2ee71e02b", "Idris.Radwan8d0d@example.com", true, "Idris", "Radwan8d0d", false, null, "IDRIS.RADWAN8D0D@EXAMPLE.COM", "IDRIS.RADWAN8D0D@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOepSfQQ8+ckMIbD2yOwkxHORKDLfIOsLL04yf+xrt4MXL3gct2twJx6Le/sGgoh5A==", "01271365326", false, "91dc2d8a-bf93-4abf-9b39-1e2307c030f0", false, "Idris.Radwan8d0d@example.com" },
                    { "409d97fa-ed6b-11ed-962d-105badc84798", 0, "6c9fe521-ab69-44e7-8f82-7b7937c12b54", "Shehabi.Saden97b5@example.com", true, "Shehabi", "Saden97b5", false, null, "SHEHABI.SADEN97B5@EXAMPLE.COM", "SHEHABI.SADEN97B5@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIVD0G3jBX1QiTWxFjGid8ph1Vm7zxYEQwLtPfN7Y/OT+LKpIgmjbu3RAPmPiAW5hg==", "01273988971", false, "d5468a1c-6f4e-48a9-8458-a8c27faba4ae", false, "Shehabi.Saden97b5@example.com" },
                    { "409d97fc-ed6b-11ed-aad6-105badc84798", 0, "a7a69518-f162-4750-baa5-b604caaa72fd", "Wael.Hilal86a3@example.com", true, "Wael", "Hilal86a3", false, null, "WAEL.HILAL86A3@EXAMPLE.COM", "WAEL.HILAL86A3@EXAMPLE.COM", "AQAAAAEAACcQAAAAENpqurG4E2AOAHk8xavAcmi6YSDWs8+xXIF/+3kygPj6WYz4S2UN7nDlFg6pzL1XUg==", "01251588288", false, "b12f4c29-526d-4fc1-86f0-29dd01898bf7", false, "Wael.Hilal86a3@example.com" },
                    { "409d97fe-ed6b-11ed-9246-105badc84798", 0, "d5c03fcc-823d-4096-97e5-634f67f4c3ea", "Baqi.Medhatbcea@example.com", true, "Baqi", "Medhatbcea", false, null, "BAQI.MEDHATBCEA@EXAMPLE.COM", "BAQI.MEDHATBCEA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIBcrp5HrgJxyvJJTsAYVdl/7NHedloBgtu/mg0YC9vFnzGzRG6PLnmeK83WBJbeyg==", "01257768133", false, "571e1dac-3e9e-49d7-b5a3-fdee29e3cc97", false, "Baqi.Medhatbcea@example.com" },
                    { "409d9800-ed6b-11ed-a52b-105badc84798", 0, "74b4f01c-34f9-471a-81ae-7b91f7ef6d73", "Adli.Mahmoud846c@example.com", true, "Adli", "Mahmoud846c", false, null, "ADLI.MAHMOUD846C@EXAMPLE.COM", "ADLI.MAHMOUD846C@EXAMPLE.COM", "AQAAAAEAACcQAAAAENln1vqQkTtLgIWX4VBi1N91ljYBRdDk2VxVTfaXv/QipVK93aS6NDCLhy7qDL/K+A==", "01217209345", false, "2c1ffe08-5daa-4171-9a9a-9cc271894473", false, "Adli.Mahmoud846c@example.com" },
                    { "409d9802-ed6b-11ed-bc09-105badc84798", 0, "f65f502c-10cc-4c37-b16d-08935f827ed6", "Yusuf.Asima639@example.com", true, "Yusuf", "Asima639", false, null, "YUSUF.ASIMA639@EXAMPLE.COM", "YUSUF.ASIMA639@EXAMPLE.COM", "AQAAAAEAACcQAAAAEI4YP1T3at6xJQuWlnxhIkxcR+pva6udYeO71SrHCiTbJsKsSh4MM5pAxrNrIocwhA==", "01296814946", false, "ba86047b-40f9-4199-bcb9-cb4eb58a625b", false, "Yusuf.Asima639@example.com" },
                    { "409d9804-ed6b-11ed-acac-105badc84798", 0, "8a577f40-57d8-4da8-864e-8b619afc05ef", "Sheila.Horr81d8@example.com", true, "Sheila", "Horr81d8", false, null, "SHEILA.HORR81D8@EXAMPLE.COM", "SHEILA.HORR81D8@EXAMPLE.COM", "AQAAAAEAACcQAAAAECsOxm1mMd6WMhjHsvhbrldCkjv3UgUhRIO+LBmyZ1Jx+0baVigrpJikwmgtbdYfKg==", "01292085322", false, "312e5126-103e-45f9-af2f-8692fa1ee5da", false, "Sheila.Horr81d8@example.com" },
                    { "409d9806-ed6b-11ed-bd30-105badc84798", 0, "bbb495be-1c7b-456d-a3e6-1e9d812d28b8", "Hamza.Horr8273@example.com", true, "Hamza", "Horr8273", false, null, "HAMZA.HORR8273@EXAMPLE.COM", "HAMZA.HORR8273@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIbLrdW4ShVlh63X2q4uRKDUS/dmuN0zjD2KTG7IqJu08dtqQa9iAoTX3aBPsZ5HSg==", "01228938716", false, "4b639487-f667-4456-8be4-db5f3117cf45", false, "Hamza.Horr8273@example.com" },
                    { "409d9808-ed6b-11ed-ad60-105badc84798", 0, "893163a9-ff54-4d89-9248-00f9c20af23a", "Hamaqy.Kamel9d6c@example.com", true, "Hamaqy", "Kamel9d6c", false, null, "HAMAQY.KAMEL9D6C@EXAMPLE.COM", "HAMAQY.KAMEL9D6C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFO14Ga1dU3yM3w+fqXEe++Yjj3rtDgZDDBMjEBLC7V1QdND/y2jTcOXdg9cJVwFJw==", "01299940571", false, "d5207f8f-2279-4fd7-b1b2-45db440fa532", false, "Hamaqy.Kamel9d6c@example.com" },
                    { "409d980a-ed6b-11ed-8f53-105badc84798", 0, "5544c927-388d-4d60-9c31-814cc9a3ee0b", "Sameh.Bacari9f4c@example.com", true, "Sameh", "Bacari9f4c", false, null, "SAMEH.BACARI9F4C@EXAMPLE.COM", "SAMEH.BACARI9F4C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBQk08pRG3FbIsPYWb4wjB+Iu6sqxnCu5gfBS7WH6m+ZEKkUyzS+J1yt3T82MyD/pg==", "01236833834", false, "8ac3c74e-6da3-448e-b9bd-c800ee767aff", false, "Sameh.Bacari9f4c@example.com" },
                    { "409d980c-ed6b-11ed-ab6a-105badc84798", 0, "9a8616ed-3002-41dd-b82b-9c2e50f32489", "Zachariah.Yusufbeab@example.com", true, "Zachariah", "Yusufbeab", false, null, "ZACHARIAH.YUSUFBEAB@EXAMPLE.COM", "ZACHARIAH.YUSUFBEAB@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBkZxl17cxtwCHPUGmsZ9SbfL6BUnucPZWxMYEVlvkbFLWQOO6kZoWLcS0D9yEqybA==", "01229346313", false, "c394868a-7625-491d-a0d9-f122fc83fa53", false, "Zachariah.Yusufbeab@example.com" },
                    { "409d980e-ed6b-11ed-a002-105badc84798", 0, "149291a5-5ede-43f6-afc5-a3814f13a2b3", "Russell.Fadiba6b@example.com", true, "Russell", "Fadiba6b", false, null, "RUSSELL.FADIBA6B@EXAMPLE.COM", "RUSSELL.FADIBA6B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPm8QzOU9B5wOJn9IhiT9K+52S9pn6FSptKphQhqgVWLv6msHPANykcQii3qq5tBgg==", "01258205230", false, "55d70165-8d5b-40b9-9990-6226a5aa07b8", false, "Russell.Fadiba6b@example.com" },
                    { "409d9810-ed6b-11ed-8ef2-105badc84798", 0, "b45333e8-063e-456d-8cc2-eca5b03affce", "Marawan.Hamaki922c@example.com", true, "Marawan", "Hamaki922c", false, null, "MARAWAN.HAMAKI922C@EXAMPLE.COM", "MARAWAN.HAMAKI922C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEqyRLzFzpASM1/XVHGUe381c0mPawYbGJ8wYDEwY/L56jKvacgnOIHzLIPGCjDWaw==", "01226919350", false, "01f53221-73ec-490a-9f3a-f38c7fefbbbe", false, "Marawan.Hamaki922c@example.com" },
                    { "409d9812-ed6b-11ed-9c48-105badc84798", 0, "cc01a869-4bc2-4cf9-b20b-198f60bea672", "Halsi.Yisria65f@example.com", true, "Halsi", "Yisria65f", false, null, "HALSI.YISRIA65F@EXAMPLE.COM", "HALSI.YISRIA65F@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBnxiXtWIejFsrx5m8Gi/x3NvP7YSotzaxIgw8K+Qowuh+qEu3PUzHkRTF+kakYJYQ==", "01270619764", false, "70457e29-e246-4013-95f9-34ece29d1a08", false, "Halsi.Yisria65f@example.com" },
                    { "409d9814-ed6b-11ed-b1a5-105badc84798", 0, "0fc0a210-4f3f-493d-b244-27e40df88c80", "Ghaith.Saber952b@example.com", true, "Ghaith", "Saber952b", false, null, "GHAITH.SABER952B@EXAMPLE.COM", "GHAITH.SABER952B@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFlwTSwSCpg26D1Sb3aZG/X2SHQ3FDg87j+MLLggu1Jxzu3eKorku7IZj9OrBMhbjg==", "01252978322", false, "1fb04d41-6b51-47a6-acd4-e5c332ebc6bc", false, "Ghaith.Saber952b@example.com" },
                    { "409d9816-ed6b-11ed-a024-105badc84798", 0, "dfde6f4e-fa67-485a-b166-1e043ab08916", "Ramzy.Sheikhy9b83@example.com", true, "Ramzy", "Sheikhy9b83", false, null, "RAMZY.SHEIKHY9B83@EXAMPLE.COM", "RAMZY.SHEIKHY9B83@EXAMPLE.COM", "AQAAAAEAACcQAAAAELf9o3ymFTGVZhKLJyYtYbk/UEIZfetNqJCuFEtoDsOdh3AOxhjKpWPlIRyojfyjtA==", "01214168755", false, "90c6f011-fd88-4261-a84d-9c8d98eb97ae", false, "Ramzy.Sheikhy9b83@example.com" },
                    { "409d9818-ed6b-11ed-a744-105badc84798", 0, "f8440b3c-c7a6-4ce5-8be4-2dd30742554e", "Loay.Zaki8b60@example.com", true, "Loay", "Zaki8b60", false, null, "LOAY.ZAKI8B60@EXAMPLE.COM", "LOAY.ZAKI8B60@EXAMPLE.COM", "AQAAAAEAACcQAAAAELGLsYlpxrrZ6ySiUOJVjHi2puINb8llvLWc74P8B5OfPOuY1QHBaLW0Z640tBIkHg==", "01235082209", false, "6b5fba97-0016-42b7-ac51-4c034cabe51b", false, "Loay.Zaki8b60@example.com" },
                    { "409d981a-ed6b-11ed-8cc2-105badc84798", 0, "c8ec8354-0354-4e57-94f8-f0d084d0beab", "Sharm.Saber98d6@example.com", true, "Sharm", "Saber98d6", false, null, "SHARM.SABER98D6@EXAMPLE.COM", "SHARM.SABER98D6@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMN8iurtzMXflR8VCf0lJp0jIY5t30ncOkYKirgEYrvhMhVEv76yAbXhf7R/w5MWUQ==", "01286278436", false, "35ba4b23-ad3b-4e0d-a7ce-eba68cb170cf", false, "Sharm.Saber98d6@example.com" },
                    { "409d981c-ed6b-11ed-a136-105badc84798", 0, "e9eb9b82-e03f-45b6-ba9a-3380620ed9b4", "Faisal.Hilal8943@example.com", true, "Faisal", "Hilal8943", false, null, "FAISAL.HILAL8943@EXAMPLE.COM", "FAISAL.HILAL8943@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJlCUsSrDJlWqexf6Nx4AXCrddQXgNBqdNaOHK6pucWzZI7+9MXyr0592Z/ktfcRGw==", "01240227176", false, "c2d8cf11-d7ec-4b1b-b749-678b9dc2388d", false, "Faisal.Hilal8943@example.com" },
                    { "409d981e-ed6b-11ed-b364-105badc84798", 0, "d6b9339d-f3e3-44a4-b1c3-bd76497162a5", "Dagher.Dagher9fe6@example.com", true, "Dagher", "Dagher9fe6", false, null, "DAGHER.DAGHER9FE6@EXAMPLE.COM", "DAGHER.DAGHER9FE6@EXAMPLE.COM", "AQAAAAEAACcQAAAAECO4oPSnvzGAd5tLU1lGi5VSoxgLYzn708Vh5la3Hn9z4SMAwn6WzbAdzJfA+9ZaCw==", "01217001819", false, "da580018-e8ea-4ec8-bba0-474e7968565b", false, "Dagher.Dagher9fe6@example.com" },
                    { "409d9820-ed6b-11ed-b8a4-105badc84798", 0, "d0440594-3c0f-4ab7-ae14-fca8baaee6c8", "Kahter.Kafarb2a1@example.com", true, "Kahter", "Kafarb2a1", false, null, "KAHTER.KAFARB2A1@EXAMPLE.COM", "KAHTER.KAFARB2A1@EXAMPLE.COM", "AQAAAAEAACcQAAAAELEag200J6hBGjecTf33sQMf25Z1LoxtpxG5FxaQ/3XzLD+HVHUOHftYfON39NbMcQ==", "01271704772", false, "3e628523-ed94-4759-b14b-896067dc0d02", false, "Kahter.Kafarb2a1@example.com" },
                    { "409d9822-ed6b-11ed-b007-105badc84798", 0, "69abe71e-4768-4749-9ded-557c5b44425a", "Russell.Barra8660@example.com", true, "Russell", "Barra8660", false, null, "RUSSELL.BARRA8660@EXAMPLE.COM", "RUSSELL.BARRA8660@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFcJrWjHJrpTvJ7oTp0RN4uGUrBY8xcZsHkEV2i3j0UMXDSE0iSbo8+72VDtL+an9w==", "01278117140", false, "3a375441-3941-4cc2-952e-02d0ba1b7448", false, "Russell.Barra8660@example.com" },
                    { "409d9824-ed6b-11ed-b245-105badc84798", 0, "8efdb2de-265c-489b-9b9a-766b797df8d8", "Samher.Sharmb774@example.com", true, "Samher", "Sharmb774", false, null, "SAMHER.SHARMB774@EXAMPLE.COM", "SAMHER.SHARMB774@EXAMPLE.COM", "AQAAAAEAACcQAAAAEC8JqZPmzaLCc8w2isMRM9+LNTvQZg8H6/9WyPFzmURD2wYAzNvUA2/uHVhwLwI6GQ==", "01253529119", false, "23fc40b7-af04-4620-84a1-fe4dfedb1ccc", false, "Samher.Sharmb774@example.com" },
                    { "409d9826-ed6b-11ed-903e-105badc84798", 0, "d88cf082-b7e7-4c17-a288-a2a48851a2c1", "Asim.Sadenb632@example.com", true, "Asim", "Sadenb632", false, null, "ASIM.SADENB632@EXAMPLE.COM", "ASIM.SADENB632@EXAMPLE.COM", "AQAAAAEAACcQAAAAEK8jaLPh8Zid9LBKB61V3wDnd3k9ZGW3/wDnghW7g2rbNrCMcYl+dwLCGpFSvysXCA==", "01214486306", false, "f2af4561-efcb-4490-b238-161be43cd488", false, "Asim.Sadenb632@example.com" },
                    { "409d9828-ed6b-11ed-8629-105badc84798", 0, "09e49fee-6bc8-4085-ba19-1fc6823dea4b", "Halsi.Maherbb85@example.com", true, "Halsi", "Maherbb85", false, null, "HALSI.MAHERBB85@EXAMPLE.COM", "HALSI.MAHERBB85@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFOEYkuD/0FWwqTkHLaYJBnsP5Es2RDeXR0Rd2o2i965VPXNgJANkwyXMrIhJN3sgg==", "01287150961", false, "1687c539-cbb2-47be-a5fa-2f95240fd516", false, "Halsi.Maherbb85@example.com" },
                    { "409d982a-ed6b-11ed-b3f7-105badc84798", 0, "0fb19f40-ee28-4207-98bc-aa5d3bd7f090", "Jawad.Fahedb924@example.com", true, "Jawad", "Fahedb924", false, null, "JAWAD.FAHEDB924@EXAMPLE.COM", "JAWAD.FAHEDB924@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFtibFC8BozG8xueSZfofnBU1PqTlYgLb/EfGF75JUeT6FTxJpOPdbnceQcTO1ti8A==", "01287718327", false, "dee99cce-2ec2-41f1-a6df-12cf08e38871", false, "Jawad.Fahedb924@example.com" },
                    { "409d982c-ed6b-11ed-9084-105badc84798", 0, "5b52c644-68ce-46b2-ac34-4e8e273f7ed7", "Dagher.Sameh899e@example.com", true, "Dagher", "Sameh899e", false, null, "DAGHER.SAMEH899E@EXAMPLE.COM", "DAGHER.SAMEH899E@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHiQQpOP1LFREDZ8IUGCpf+Z0ag6alVSGnIH9nv7/vtQgkI/5Pu8l6o8eE7ifukJ/A==", "01229621962", false, "b2d6d3ac-ca6b-4aa2-abb0-9a1e3fe3223d", false, "Dagher.Sameh899e@example.com" },
                    { "409d982e-ed6b-11ed-8e42-105badc84798", 0, "1e7363e9-25bc-45ea-918b-6c9009d2655f", "Fidaa.Faisalaef2@example.com", true, "Fidaa", "Faisalaef2", false, null, "FIDAA.FAISALAEF2@EXAMPLE.COM", "FIDAA.FAISALAEF2@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIkVfMugrHGBtKEZ8unPT2ROFw+/tXHdQxZFJGM+PgpQLQVqm1jqU5Abpp+rLu9/UQ==", "01239399918", false, "f74cff08-61d6-4d95-bfdb-7c48a4bdade9", false, "Fidaa.Faisalaef2@example.com" },
                    { "409d9830-ed6b-11ed-abc8-105badc84798", 0, "96fbbc51-c335-4f5c-b9fc-8a9288a57f8b", "Yad.Jika853c@example.com", true, "Yad", "Jika853c", false, null, "YAD.JIKA853C@EXAMPLE.COM", "YAD.JIKA853C@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEiNTY34dKypNYXVPCuL1L/+XQiArkNixb37ubeSsA6G6+Iyy6H5nRs6PJIkoVwaxw==", "01273014929", false, "300a6471-f16e-4238-a3f4-7eb4b3c510df", false, "Yad.Jika853c@example.com" },
                    { "409d9832-ed6b-11ed-8176-105badc84798", 0, "0b52a22f-8c00-43aa-8716-7623d1e6c8dd", "Dagher.Sheilaaa3b@example.com", true, "Dagher", "Sheilaaa3b", false, null, "DAGHER.SHEILAAA3B@EXAMPLE.COM", "DAGHER.SHEILAAA3B@EXAMPLE.COM", "AQAAAAEAACcQAAAAECa9lLY6mxxbrNtgW52XJgjrIL48GK+uDyJbgXbrigYIn1S63Ke4YOYhJn8XvmpDAA==", "01271168271", false, "bdcd887e-1621-4bfe-aedb-4873f751cc57", false, "Dagher.Sheilaaa3b@example.com" },
                    { "409d9834-ed6b-11ed-883a-105badc84798", 0, "97af0b6d-8f6f-4748-b738-008b20de394d", "Ghaith.Adela089@example.com", true, "Ghaith", "Adela089", false, null, "GHAITH.ADELA089@EXAMPLE.COM", "GHAITH.ADELA089@EXAMPLE.COM", "AQAAAAEAACcQAAAAEO6/FzJ/gwvaBHuBVy8Pm66dzt4kl8C5GNAZe0dqrTO0s+RkAV/IjEkThc372H/FzQ==", "01240257375", false, "85ac3681-779c-4318-8cf7-156438a2dad3", false, "Ghaith.Adela089@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "409d9836-ed6b-11ed-8979-105badc84798", 0, "76fcf121-4714-43e4-9293-ad880ed12445", "Ryan.Ramzybdbf@example.com", true, "Ryan", "Ramzybdbf", false, null, "RYAN.RAMZYBDBF@EXAMPLE.COM", "RYAN.RAMZYBDBF@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGgVfsNdQEO8dQMU/G0NlVijFWU4ROubOg4xvGrbZQT0YQdO8tQyVStzscJwEOyWzg==", "01282509863", false, "60b8d60c-3bb2-49de-a22d-f782ae12900c", false, "Ryan.Ramzybdbf@example.com" },
                    { "409d9838-ed6b-11ed-ac79-105badc84798", 0, "593d85a6-1e7b-4eb7-bb54-b27a10bd7ebf", "Bacari.Firasa5e7@example.com", true, "Bacari", "Firasa5e7", false, null, "BACARI.FIRASA5E7@EXAMPLE.COM", "BACARI.FIRASA5E7@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEvgJXDN3vYGFyQZoO1k5SK6QeEdL+TUhtuk+tZbYRFDjeX0Evy8wLfgeeXut9SMPw==", "01265289814", false, "c29d6d48-3f56-49e9-b857-37122fc62d90", false, "Bacari.Firasa5e7@example.com" },
                    { "409d983a-ed6b-11ed-890c-105badc84798", 0, "e0553ab4-55b5-42a6-9a3e-18ce74c01c75", "Fares.Radwana0b0@example.com", true, "Fares", "Radwana0b0", false, null, "FARES.RADWANA0B0@EXAMPLE.COM", "FARES.RADWANA0B0@EXAMPLE.COM", "AQAAAAEAACcQAAAAEB01eLQQX2V5LL2F9WCKHExdNAIDNYKpeHAxGtiJyMzzB0mdlFR81/vQeH+mSjp52Q==", "01231166131", false, "deec57bf-d081-4a57-b15f-3df42c78f815", false, "Fares.Radwana0b0@example.com" },
                    { "4A8CA884-C093-43C4-A019-EE6D804BF85E", 0, "3f84935f-195d-4497-853e-7890fc07c93e", "mosad53@gmail.com", true, "Mossad", "Gomaa", false, null, "MOSAD53@GMAIL.COM", "MOSAD53@GMAIL.COM", "AQAAAAEAACcQAAAAELGL7ibNzivYr+L3ET2LtQu9AxkvPqEN7SXjsxUoL5qGKUFy33C6jHL0tJrCz+TDAw==", "+201211820083", false, "705268f4-b4d7-4171-a28e-51f5a91f3737", false, "mosad53@gmail.com" },
                    { "5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5", 0, "3369be2f-5ceb-4b2b-97e8-2012c9e0d15d", "mosad5@gmail.com", true, "Mossad", "Ahmed", false, null, "MOSAD5@GMAIL.COM", "MOSAD5@GMAIL.COM", "AQAAAAEAACcQAAAAEMCidMU1gD+srExWw4JFiBuXd3QGNqFixHVbeH8X/7ETWl+yLGO+51BGfLSrJlk4bA==", "+201211820083", false, "0bb56069-3123-4089-8c4b-d79f46ae2aa4", false, "mosad5@gmail.com" },
                    { "69E0E900-6DE2-45E8-85CA-583B32C5C5AA", 0, "f92bc73f-a3ff-4e50-8f61-f84ae0c68120", "jane.doe@example.com", true, "Jane", "Doe", false, null, "JANE.DOE@EXAMPLE.COM", "JANE.DOE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGSwc4XL0EJd+kAjmcNzVnM43/eMbLdtj0rjz0U6JfDtuCz3nqqexR9ya1MfGGvk3g==", "01203993009", false, "8d86267a-bb67-46a2-851e-2875f199b4ee", false, "jane.doe@example.com" },
                    { "706870e9-e373-11ed-b719-105badc84798", 0, "e5845bbe-1912-42fa-954d-a878ee7cae72", "Mo.Zi@example.com", true, "Mo", "Zi", false, null, "MO.ZI@EXAMPLE.COM", "MO.ZI@EXAMPLE.COM", "AQAAAAEAACcQAAAAECbJutCqUblgdVxAZYtenOcDCnrliQz0OY5RFtbfxYs1SGCOAhH1ECSyUKzMu3j/bw==", "01279426209", false, "29f32e51-f9a9-497b-9858-9da0977367f3", false, "Mo.Zi@example.com" },
                    { "706b3236-e373-11ed-a003-105badc84798", 0, "e9156897-457b-4ce7-8f67-5e1bb57ec150", "Majdi.Fares@example.com", true, "Majdi", "Fares", false, null, "MAJDI.FARES@EXAMPLE.COM", "MAJDI.FARES@EXAMPLE.COM", "AQAAAAEAACcQAAAAECQ01Oi9urs/8szdhZ0EskcJJkRt0nTHTqnU6UpWuC5SiBysHwuw/y+TfLG2eq7Dcg==", "01270867190", false, "915e50f0-2f89-465e-8d55-3e08fea790fd", false, "Majdi.Fares@example.com" },
                    { "706b3237-e373-11ed-988f-105badc84798", 0, "8ce6d7ff-709b-4121-bcc5-d044794a4aad", "Hamza.Yisri@example.com", true, "Hamza", "Yisri", false, null, "HAMZA.YISRI@EXAMPLE.COM", "HAMZA.YISRI@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBS7DyxJoe9ICnsOJgtHBF4A1c3DgjVXYh41f9RXOBt8etuR+ws7SG3jLRid0Xcx7w==", "01256543256", false, "5db30c11-e6a1-479c-b094-d1775d90412d", false, "Hamza.Yisri@example.com" },
                    { "7A369173-1E2F-491F-874F-7B324C034BC2", 0, "b7bfe59d-069a-4f84-9192-73ffb020f91a", "bob.smith@example.com", true, "Bob", "Smith", false, null, "BOB.SMITH@EXAMPLE.COM", "BOB.SMITH@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDPcK4cy6Kn5JpDZjzIuepaWnVaXS90rsZjPtMf1qGp7pGhkNlsdYdimv5eZJ2icCQ==", "011234356789", false, "cdfaa7cc-739b-47e8-9449-fb4f116f7297", false, "bob.smith@example.com" },
                    { "99328045-8ECF-40A1-9F0B-0DEA6398F09A", 0, "57d8956b-c23e-4dfd-8339-786f397585fc", "john.doe@example.com", true, "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEDfNCy3sm+hUGY1gJV7DscDljr2Hq4cZSSi4c85Bm+W/9qwhM48S0ETLa+Rth1QhqA==", "01239931230", false, "87220bbc-ba9f-4b4d-a35b-65a8a989b4bf", false, "john.doe@example.com" },
                    { "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2", 0, "e3809dea-a9d8-4e97-89fe-54215a095c44", "sara.jones@example.com", true, "Sara", "Jones", false, null, "SARA.JONES@EXAMPLE.COM", "SARA.JONES@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEwwYNv6hjvh038zoHIrhx8yiZR3Dti0l74/UqSpJRId58dktUtMPd1pwGGM9A6vaA==", "010765432231", false, "97230c6c-26f3-41d1-acc8-c0fb76606001", false, "sara.jones@example.com" }
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
