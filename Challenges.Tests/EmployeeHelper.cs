namespace Challenges.Tests;

using System.Text;

public static class EmployeeHelper
{
    public static readonly List<Employee> AllEmployees = new()
    {
        new()
        {
            Id = 10370,
            Name = "Paul Davies",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 57415,
            YearsOfService = 5,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 10405,
            Name = "Mark Jackson",
            Age = 45,
            JobTitle = "Delivery Lead",
            Department = "Consulting",
            ManagerId = 23975,
            YearsOfService = 9,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 10415,
            Name = "Tabby Franklin",
            Age = 39,
            JobTitle = "Delivery Lead",
            Department = "Support",
            ManagerId = 32376,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 10788,
            Name = "Benoit Durant",
            Age = 29,
            JobTitle = "Marketing Director",
            Department = "Marketing",
            ManagerId = null,
            YearsOfService = 9,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 10838,
            Name = "Carla Weber",
            Age = 25,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 42203,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 10883,
            Name = "Andras Lewerenz",
            Age = 39,
            JobTitle = "Business Analyst",
            Department = "Consulting",
            ManagerId = 85098,
            YearsOfService = 8,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 11024,
            Name = "Garwood Attridge",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 66133,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 12095,
            Name = "Helia Rivera",
            Age = 44,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 65470,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 12291,
            Name = "Garrett Mersh",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 43487,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 12442,
            Name = "Paige Bloomfield",
            Age = 37,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 47174,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 12445,
            Name = "Vania Yates",
            Age = 49,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 6,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 12459,
            Name = "Maddie Simons",
            Age = 25,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 59591,
            YearsOfService = 6,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 12610,
            Name = "Ruth Craig",
            Age = 53,
            JobTitle = "Director",
            Department = "Support",
            ManagerId = 51708,
            YearsOfService = 9,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 12712,
            Name = "Monisola Ojo",
            Age = 32,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 87095,
            YearsOfService = 3,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 13798,
            Name = "Eloise Beeson",
            Age = 28,
            JobTitle = "Accounts Assistant",
            Department = "Finance",
            ManagerId = 86362,
            YearsOfService = 4,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 13829,
            Name = "Amala Sachs",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 94389,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 13989,
            Name = "Monah Scarisbrick",
            Age = 39,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 68418,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 14007,
            Name = "Yilma Loharani",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 12712,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 14158,
            Name = "Alisha Srivastava",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 18114,
            YearsOfService = 3,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 15228,
            Name = "Eustace Wanell",
            Age = 29,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 87299,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 15328,
            Name = "Camille Craighall",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 20453,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 15367,
            Name = "Lei Shirong",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 47174,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 15421,
            Name = "Ryo Igarashi",
            Age = 54,
            JobTitle = "Senior Technical Lead",
            Department = "Support",
            ManagerId = 65178,
            YearsOfService = 8,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 15519,
            Name = "Sunita Patel",
            Age = 44,
            JobTitle = "HR Director",
            Department = "HR",
            ManagerId = null,
            YearsOfService = 5,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 15543,
            Name = "Gareth Newton",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 36752,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 15584,
            Name = "Junpei Takayama",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 23300,
            YearsOfService = 5,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 15711,
            Name = "Devonne Luckhurst",
            Age = 38,
            JobTitle = "Technical Lead",
            Department = "Support",
            ManagerId = 65178,
            YearsOfService = 10,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 16111,
            Name = "Rebecca Joron",
            Age = 29,
            JobTitle = "Technical Lead",
            Department = "Support",
            ManagerId = 27225,
            YearsOfService = 6,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 16215,
            Name = "Veda Cartledge",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 94901,
            YearsOfService = 0,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 16490,
            Name = "Sumit Ghosh",
            Age = 32,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 30934,
            YearsOfService = 4,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 17018,
            Name = "Fabien Vials",
            Age = 43,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 33330,
            YearsOfService = 6,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 17551,
            Name = "Brana Josefs",
            Age = 28,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 88600,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 17625,
            Name = "Rubin Petroff",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 86424,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 18114,
            Name = "Artan Sayyid",
            Age = 44,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 65470,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 18682,
            Name = "Ned Farmer",
            Age = 27,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 84782,
            YearsOfService = 4,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 18810,
            Name = "Jackson Wilkinson",
            Age = 40,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 59591,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 19348,
            Name = "Jade Harding",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 83752,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 20453,
            Name = "Pan Mirae",
            Age = 50,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 54184,
            YearsOfService = 3,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 20630,
            Name = "Thomas Edwards",
            Age = 37,
            JobTitle = "Senior Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 8,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 21447,
            Name = "Eveline Blanchar",
            Age = 46,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 53555,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 21639,
            Name = "Maryann Bresner",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 35920,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 21656,
            Name = "Olufemi Ikande",
            Age = 24,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 20453,
            YearsOfService = 6,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 21687,
            Name = "Christelle Charron",
            Age = 42,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 43169,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 21872,
            Name = "Eba Strand",
            Age = 39,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 93035,
            YearsOfService = 4,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 22143,
            Name = "Daphne Bishop",
            Age = 21,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 68615,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 22514,
            Name = "Dalton Cleft",
            Age = 27,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 61328,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 22544,
            Name = "Tan Jia",
            Age = 46,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 15421,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 22570,
            Name = "Macey Christie",
            Age = 31,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 25852,
            YearsOfService = 6,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 23300,
            Name = "Valini Srinivas",
            Age = 28,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 27225,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 23326,
            Name = "Stefa Padrick",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 21687,
            YearsOfService = 4,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 23451,
            Name = "Christabel Parnell",
            Age = 40,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 47967,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 23736,
            Name = "Kristi Pattillo",
            Age = 22,
            JobTitle = "HR Administrator",
            Department = "HR",
            ManagerId = 73580,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 23776,
            Name = "Lucian Hamshar",
            Age = 48,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 45663,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 23975,
            Name = "Rani Prabhu",
            Age = 42,
            JobTitle = "Delivery Principal",
            Department = "Consulting",
            ManagerId = 91855,
            YearsOfService = 9,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 24194,
            Name = "Dan Chiu",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 57415,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 24314,
            Name = "Mosiya Okonjo",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 69969,
            YearsOfService = 0,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 24406,
            Name = "Huan Hu",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 71609,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 24519,
            Name = "Robert Clarke",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 72146,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 24592,
            Name = "Inessa Williamson",
            Age = 33,
            JobTitle = "Senior Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 5,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 25088,
            Name = "Devin Shurey",
            Age = 43,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 90874,
            YearsOfService = 4,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 25852,
            Name = "Shireen Chachar",
            Age = 37,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 9,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 26241,
            Name = "Raquela Fryman",
            Age = 20,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 17018,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 26451,
            Name = "Teresita Evans",
            Age = 27,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 12712,
            YearsOfService = 4,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 26534,
            Name = "Habibah Amari",
            Age = 29,
            JobTitle = "HR Advisor",
            Department = "HR",
            ManagerId = 73580,
            YearsOfService = 9,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 26543,
            Name = "Ida Pachmann",
            Age = 38,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 18114,
            YearsOfService = 6,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 26637,
            Name = "Sarah Evans",
            Age = 25,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 81316,
            YearsOfService = 3,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 26670,
            Name = "Manolo Wheelan",
            Age = 37,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 62874,
            YearsOfService = 5,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 26771,
            Name = "Conrad McGill",
            Age = 29,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 85571,
            YearsOfService = 5,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 27117,
            Name = "Sally Nash",
            Age = 46,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 85571,
            YearsOfService = 10,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 27225,
            Name = "Hanna Wozniak",
            Age = 43,
            JobTitle = "Senior Technical Lead",
            Department = "Support",
            ManagerId = 65178,
            YearsOfService = 9,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 27466,
            Name = "Michael Wilson",
            Age = 36,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 80470,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 27555,
            Name = "Heidi Jennings",
            Age = 37,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 37773,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 28373,
            Name = "Adrienne Villeneuve",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 20453,
            YearsOfService = 5,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 28478,
            Name = "Tariq Qadiri",
            Age = 34,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 94901,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 28515,
            Name = "Maysa Haq",
            Age = 28,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 66133,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 29648,
            Name = "Hildy Warricker",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 54178,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 30004,
            Name = "James Hall",
            Age = 24,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 57415,
            YearsOfService = 5,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 30040,
            Name = "Adala Stauss",
            Age = 39,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 46850,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 30713,
            Name = "Marian Augustin",
            Age = 29,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 55608,
            YearsOfService = 7,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 30834,
            Name = "Alex Fletcher",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 71168,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 30918,
            Name = "Jobina Badrick",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 87299,
            YearsOfService = 3,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 30934,
            Name = "Karen Romero",
            Age = 53,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 54184,
            YearsOfService = 9,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 31138,
            Name = "Hsin Sun",
            Age = 36,
            JobTitle = "Technical Lead",
            Department = "Support",
            ManagerId = 65178,
            YearsOfService = 9,
            PayBand = 8,
            OnLeave = 1
        },
        new()
        {
            Id = 32185,
            Name = "Susan Harris",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 12459,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 32225,
            Name = "Edric Ocalan",
            Age = 20,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 21687,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 1
        },
        new()
        {
            Id = 32376,
            Name = "Patricia Cooper",
            Age = 47,
            JobTitle = "Delivery Principal",
            Department = "Support",
            ManagerId = 12610,
            YearsOfService = 6,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 32835,
            Name = "Audie Osborne",
            Age = 39,
            JobTitle = "Technical Consultant",
            Department = "Delivery",
            ManagerId = 88390,
            YearsOfService = 6,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 33330,
            Name = "Hadrienne Labelle",
            Age = 36,
            JobTitle = "Technical Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 7,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 33337,
            Name = "Sheila Rubertis",
            Age = 30,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 89037,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 33676,
            Name = "Jun Hou",
            Age = 40,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 53555,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 33797,
            Name = "Olayinka Isiaka",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 84782,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 33873,
            Name = "Arthur Olatunji",
            Age = 35,
            JobTitle = "Business Development Manager",
            Department = "Sales",
            ManagerId = 85548,
            YearsOfService = 8,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 34534,
            Name = "Trista Redolfi",
            Age = 26,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 41824,
            YearsOfService = 8,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 34751,
            Name = "Zahidah Said",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 26771,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 35118,
            Name = "Peri Adanir",
            Age = 27,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 54184,
            YearsOfService = 5,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 35432,
            Name = "Victoria Brown",
            Age = 29,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 42203,
            YearsOfService = 3,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 35605,
            Name = "Estefania Orozco",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 10405,
            YearsOfService = 0,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 35776,
            Name = "Marya Holcroft",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 64989,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 35800,
            Name = "Bernardita Pedrosa",
            Age = 36,
            JobTitle = "Director",
            Department = "IT",
            ManagerId = null,
            YearsOfService = 8,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 35811,
            Name = "Klara Nowak",
            Age = 25,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 47967,
            YearsOfService = 5,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 35920,
            Name = "Isaiah Little",
            Age = 32,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 60124,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 36198,
            Name = "Hamood Machi",
            Age = 41,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 20630,
            YearsOfService = 5,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 36752,
            Name = "Alistair Thompson",
            Age = 37,
            JobTitle = "Technical Lead",
            Department = "Support",
            ManagerId = 15421,
            YearsOfService = 5,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 37360,
            Name = "Chiebuka Nebechi",
            Age = 21,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 27555,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 37585,
            Name = "Zhen Wei",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 42769,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 37599,
            Name = "Ulric Josskovitz",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 46850,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 37773,
            Name = "Nadya Thridgould",
            Age = 43,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 33330,
            YearsOfService = 9,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 38174,
            Name = "Conan Sinclair",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 68615,
            YearsOfService = 3,
            PayBand = 1,
            OnLeave = 1
        },
        new()
        {
            Id = 38179,
            Name = "Hamisi Akunyili",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 17018,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 38481,
            Name = "Glynnis McGahern",
            Age = 36,
            JobTitle = "Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 38537,
            Name = "Hillary Walster",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 85098,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 38567,
            Name = "Karimah Atiyeh",
            Age = 37,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 71666,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 38634,
            Name = "Felix Varah",
            Age = 33,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 27555,
            YearsOfService = 8,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 38678,
            Name = "Pashan Ghazali",
            Age = 30,
            JobTitle = "Legal Administrator",
            Department = "Legal",
            ManagerId = 61062,
            YearsOfService = 8,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 39362,
            Name = "Nadia Gordon",
            Age = 41,
            JobTitle = "Finance Manager",
            Department = "Finance",
            ManagerId = 43518,
            YearsOfService = 7,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 39363,
            Name = "Barbette Cutridge",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 91620,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 39570,
            Name = "Carol Berrisford",
            Age = 20,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 36752,
            YearsOfService = 2,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 39741,
            Name = "Sawyer Thowes",
            Age = 32,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 65176,
            YearsOfService = 8,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 40035,
            Name = "Ella Cooper",
            Age = 23,
            JobTitle = "Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 2,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 40293,
            Name = "Hortense Martel",
            Age = 21,
            JobTitle = "Business Analyst",
            Department = "Delivery",
            ManagerId = 22570,
            YearsOfService = 1,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 40899,
            Name = "Aoife Allington",
            Age = 26,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 47174,
            YearsOfService = 4,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 40908,
            Name = "Alain Fanthome",
            Age = 32,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 66133,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 40978,
            Name = "Varsha Tak",
            Age = 27,
            JobTitle = "Delivery Lead",
            Department = "Support",
            ManagerId = 66994,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 41342,
            Name = "Karim Brumfitt",
            Age = 42,
            JobTitle = "Senior Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 41375,
            Name = "Ritu Thakur",
            Age = 32,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 86772,
            YearsOfService = 7,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 41548,
            Name = "Anastasia Cocozza",
            Age = 39,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 82068,
            YearsOfService = 3,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 41685,
            Name = "Eniola Micheal",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 31138,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 41701,
            Name = "Adebola Oyinlola",
            Age = 39,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 37773,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 41767,
            Name = "Alex Ambrogetti",
            Age = 45,
            JobTitle = "Lead Technical Consultant",
            Department = "Consulting",
            ManagerId = 91855,
            YearsOfService = 10,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 41824,
            Name = "Haiya Mohan",
            Age = 41,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 30934,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 42203,
            Name = "Kasia Lennon",
            Age = 43,
            JobTitle = "Senior Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 9,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 42464,
            Name = "Audrie Rosgen",
            Age = 27,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 56390,
            YearsOfService = 5,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 42769,
            Name = "Miguel Lodwig",
            Age = 38,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 60124,
            YearsOfService = 3,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 42775,
            Name = "Celestina Schober",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 86665,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 43169,
            Name = "Sidney Paoli",
            Age = 40,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 82068,
            YearsOfService = 10,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 43228,
            Name = "Braith Llewelyn",
            Age = 45,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 10,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 43487,
            Name = "Waseema Mirza",
            Age = 42,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 81316,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 43518,
            Name = "Leroy Lamb",
            Age = 44,
            JobTitle = "Finance Director",
            Department = "Finance",
            ManagerId = null,
            YearsOfService = 10,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 44210,
            Name = "Zahra Ahmed",
            Age = 55,
            JobTitle = "Sales Director",
            Department = "Sales",
            ManagerId = null,
            YearsOfService = 5,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 44287,
            Name = "Charis Petracchi",
            Age = 35,
            JobTitle = "Technical Principal",
            Department = "Consulting",
            ManagerId = 91855,
            YearsOfService = 10,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 44455,
            Name = "Manish Tara",
            Age = 21,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 68418,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 44697,
            Name = "Lidya Nasih",
            Age = 35,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 54178,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 45519,
            Name = "Glaw Davies",
            Age = 36,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 88600,
            YearsOfService = 1,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 45521,
            Name = "Kayin Owayale",
            Age = 50,
            JobTitle = "Director",
            Department = "Delivery",
            ManagerId = 51708,
            YearsOfService = 8,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 45663,
            Name = "Zou Ruolan",
            Age = 50,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 82068,
            YearsOfService = 10,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 45726,
            Name = "Kris Conachie",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 41548,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 46072,
            Name = "Lonnie Sumnall",
            Age = 50,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 45663,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 46141,
            Name = "Zakiya Godina",
            Age = 38,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 35118,
            YearsOfService = 3,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 46357,
            Name = "Rajesh Pai",
            Age = 30,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 35118,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 46827,
            Name = "Miranda Mullins",
            Age = 30,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 7,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 46850,
            Name = "Gustaw Zawadski",
            Age = 29,
            JobTitle = "Technical Lead",
            Department = "Support",
            ManagerId = 61328,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 46973,
            Name = "Anushka Dmitrieva",
            Age = 35,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 12445,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 47174,
            Name = "Abioye Emmanuel",
            Age = 44,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 85571,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 47323,
            Name = "Nina Kenny",
            Age = 29,
            JobTitle = "Technology Architect",
            Department = "Delivery",
            ManagerId = 94389,
            YearsOfService = 4,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 47808,
            Name = "Raghav Merchant",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 77224,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 47967,
            Name = "Oscar Holmes",
            Age = 49,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 33330,
            YearsOfService = 7,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 48107,
            Name = "Melanie Frankton",
            Age = 37,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 81316,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 48434,
            Name = "Devina Linwood",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 41548,
            YearsOfService = 5,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 48545,
            Name = "Mariele Monnelly",
            Age = 35,
            JobTitle = "Director",
            Department = "Design",
            ManagerId = 51708,
            YearsOfService = 7,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 48747,
            Name = "Usman Shah",
            Age = 33,
            JobTitle = "Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 6,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 48950,
            Name = "Iheoma Belonwu",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 25088,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 49009,
            Name = "Justin Fairbank",
            Age = 26,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 41824,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 49034,
            Name = "Guanyin Liang",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 16111,
            YearsOfService = 0,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 49100,
            Name = "Iva Parkin",
            Age = 40,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 59009,
            YearsOfService = 8,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 49239,
            Name = "Hong Yao",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 89037,
            YearsOfService = 4,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 49333,
            Name = "David Taylor",
            Age = 47,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 87095,
            YearsOfService = 4,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 49418,
            Name = "Larissa Larson",
            Age = 39,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 87299,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 49508,
            Name = "Patrick French",
            Age = 24,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 26637,
            YearsOfService = 6,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 49856,
            Name = "Edeline Petrina",
            Age = 31,
            JobTitle = "Performance Analyst",
            Department = "Delivery",
            ManagerId = 69969,
            YearsOfService = 4,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 50053,
            Name = "Herrick Hazel",
            Age = 38,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 43169,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 1
        },
        new()
        {
            Id = 50683,
            Name = "Kamala Sagar",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 98817,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 51168,
            Name = "Joe Smith",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 53479,
            YearsOfService = 4,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 51708,
            Name = "Jasmine Harding",
            Age = 51,
            JobTitle = "Managing Director",
            Department = null,
            ManagerId = null,
            YearsOfService = 1,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 51983,
            Name = "Davar Rahmanzai",
            Age = 30,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 31138,
            YearsOfService = 8,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 52006,
            Name = "Joshua Tuddall",
            Age = 21,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 71666,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 53479,
            Name = "Julita Kucharska",
            Age = 41,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 67176,
            YearsOfService = 5,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 53555,
            Name = "Ursula Klemmt",
            Age = 38,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 54184,
            YearsOfService = 9,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 54178,
            Name = "Nona O'Neill",
            Age = 49,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 10,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 54184,
            Name = "Cindra Murrells",
            Age = 42,
            JobTitle = "Technical Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 10,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 54805,
            Name = "Yvonne O'Donovan",
            Age = 37,
            JobTitle = "Office Administrator",
            Department = "Office Management",
            ManagerId = 56808,
            YearsOfService = 9,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 54956,
            Name = "Isandro Danon",
            Age = 25,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 54178,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 55608,
            Name = "Mauricio Aslet",
            Age = 36,
            JobTitle = "Design Principal",
            Department = "Design",
            ManagerId = 48545,
            YearsOfService = 9,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 56141,
            Name = "Namrata Kumer",
            Age = 27,
            JobTitle = "Legal Administrator",
            Department = "Legal",
            ManagerId = 61062,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 56282,
            Name = "Florry Sandle",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 46072,
            YearsOfService = 5,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 56390,
            Name = "Victor Nicholson",
            Age = 31,
            JobTitle = "Senior UX Designer",
            Department = "Design",
            ManagerId = 90767,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 56808,
            Name = "Leon Voronov",
            Age = 41,
            JobTitle = "Office Manager",
            Department = "Office Management",
            ManagerId = 51708,
            YearsOfService = 10,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 57197,
            Name = "Surya Sandhu",
            Age = 28,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 73444,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 57415,
            Name = "Rayan Malik",
            Age = 48,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 73444,
            YearsOfService = 3,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 57659,
            Name = "Lok Tsai",
            Age = 24,
            JobTitle = "Technology Architect",
            Department = "Delivery",
            ManagerId = 69601,
            YearsOfService = 3,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 57666,
            Name = "Shaun Braun",
            Age = 34,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 94901,
            YearsOfService = 4,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 57699,
            Name = "Greta Biasini",
            Age = 27,
            JobTitle = "Senior UX Designer",
            Department = "Design",
            ManagerId = 90767,
            YearsOfService = 3,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 57793,
            Name = "Li Meng",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 41701,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 58721,
            Name = "Kingsley Pateman",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 26637,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 58784,
            Name = "Raafida Panhwar",
            Age = 34,
            JobTitle = "Office Administrator",
            Department = "Office Management",
            ManagerId = 56808,
            YearsOfService = 4,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 59009,
            Name = "Niko Acory",
            Age = 30,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 47967,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 59591,
            Name = "Jenete Ibekwe",
            Age = 49,
            JobTitle = "Senior Technical Lead",
            Department = "Support",
            ManagerId = 65178,
            YearsOfService = 7,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 60100,
            Name = "Devlin Nicholls",
            Age = 34,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 57699,
            YearsOfService = 8,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 60124,
            Name = "Kerri Perryman",
            Age = 53,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 82068,
            YearsOfService = 6,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 60208,
            Name = "Alex Harris",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 27466,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 60487,
            Name = "Gilberta Donohue",
            Age = 39,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 84782,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 61021,
            Name = "Sushila Sabharwal",
            Age = 31,
            JobTitle = "IT Administrator",
            Department = "IT",
            ManagerId = 62085,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 61062,
            Name = "Solomon Goldstein",
            Age = 33,
            JobTitle = "Legal Advisor",
            Department = "Legal",
            ManagerId = 62564,
            YearsOfService = 2,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 61098,
            Name = "Bryn Cecil",
            Age = 42,
            JobTitle = "Senior Designer",
            Department = "Design",
            ManagerId = 55608,
            YearsOfService = 8,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 61242,
            Name = "Massawa Mustafa",
            Age = 37,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 93035,
            YearsOfService = 9,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 61328,
            Name = "Ricca Dewdeny",
            Age = 54,
            JobTitle = "Senior Technical Lead",
            Department = "Support",
            ManagerId = 65178,
            YearsOfService = 9,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 61575,
            Name = "Mangjeol Haru",
            Age = 36,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 27225,
            YearsOfService = 10,
            PayBand = 6,
            OnLeave = 1
        },
        new()
        {
            Id = 61948,
            Name = "Emera Harker",
            Age = 23,
            JobTitle = "Content Designer",
            Department = "Marketing",
            ManagerId = 84047,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 62085,
            Name = "Gim Mishil",
            Age = 34,
            JobTitle = "IT Manager",
            Department = "IT",
            ManagerId = 35800,
            YearsOfService = 10,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 62442,
            Name = "Tae Kyung",
            Age = 25,
            JobTitle = "IT Administrator",
            Department = "IT",
            ManagerId = 62085,
            YearsOfService = 6,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 62470,
            Name = "Andrew Robinson",
            Age = 30,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 40978,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 62564,
            Name = "Celestine Pennetta",
            Age = 32,
            JobTitle = "Legal Director",
            Department = "Legal",
            ManagerId = null,
            YearsOfService = 9,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 62660,
            Name = "Jie Tsao",
            Age = 28,
            JobTitle = "Senior Delivery Lead",
            Department = "Delivery",
            ManagerId = 46827,
            YearsOfService = 7,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 62874,
            Name = "Shazia Rashid",
            Age = 31,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 45663,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 63064,
            Name = "Chigozie Dilibe",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 16111,
            YearsOfService = 5,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 63680,
            Name = "Margot Booth",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 10415,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 63854,
            Name = "Alexander Crowcombe",
            Age = 22,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 12712,
            YearsOfService = 4,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 64989,
            Name = "Hassan Rosado",
            Age = 47,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 20630,
            YearsOfService = 5,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 65176,
            Name = "Emmi Vanhalla",
            Age = 36,
            JobTitle = "Senior Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 6,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 65178,
            Name = "Masako Takahashi",
            Age = 42,
            JobTitle = "Technical Principal",
            Department = "Support",
            ManagerId = 12610,
            YearsOfService = 9,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 65470,
            Name = "Esme Simon",
            Age = 48,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 82068,
            YearsOfService = 8,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 65502,
            Name = "Adria Gascard",
            Age = 30,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 41824,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 65603,
            Name = "Indira Toor",
            Age = 21,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 35920,
            YearsOfService = 3,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 66133,
            Name = "Amit Seshadri",
            Age = 28,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 53555,
            YearsOfService = 6,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 66478,
            Name = "Oluwasola Akintola",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 46973,
            YearsOfService = 5,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 66826,
            Name = "Alberto Felix",
            Age = 30,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 67176,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 66994,
            Name = "Huberto Arondel",
            Age = 54,
            JobTitle = "Delivery Principal",
            Department = "Support",
            ManagerId = 12610,
            YearsOfService = 8,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 67176,
            Name = "Duke Gudgen",
            Age = 49,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 4,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 67933,
            Name = "Kirstin Cliff",
            Age = 49,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 43169,
            YearsOfService = 9,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 68162,
            Name = "Idowu Adebayo",
            Age = 37,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 68615,
            YearsOfService = 1,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 68291,
            Name = "Raoul Restorick",
            Age = 27,
            JobTitle = "HR Partner",
            Department = "HR",
            ManagerId = 15519,
            YearsOfService = 8,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 68418,
            Name = "Elena Adams",
            Age = 36,
            JobTitle = "Senior UX Designer",
            Department = "Design",
            ManagerId = 90767,
            YearsOfService = 6,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 68615,
            Name = "Sona Sachdeva",
            Age = 45,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 93035,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 68697,
            Name = "Samantha Liao",
            Age = 32,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 65176,
            YearsOfService = 6,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 69601,
            Name = "Fen Chao",
            Age = 35,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 43228,
            YearsOfService = 9,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 69712,
            Name = "Karolina Dudek",
            Age = 27,
            JobTitle = "Content Designer",
            Department = "Marketing",
            ManagerId = 84047,
            YearsOfService = 5,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 69790,
            Name = "Viola Shelton",
            Age = 25,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 18114,
            YearsOfService = 6,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 69969,
            Name = "Grace Di Nisco",
            Age = 31,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 46827,
            YearsOfService = 7,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 70188,
            Name = "Meike Krantz",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 23776,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 71045,
            Name = "Maki Okada",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 86772,
            YearsOfService = 4,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 71168,
            Name = "Margaret Woolford",
            Age = 45,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 90874,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 71441,
            Name = "Delshad Turabi",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 22570,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 71609,
            Name = "Hugh Runnett",
            Age = 40,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 46827,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 71666,
            Name = "Antonia Rosgen",
            Age = 38,
            JobTitle = "Design Principal",
            Department = "Design",
            ManagerId = 48545,
            YearsOfService = 8,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 72137,
            Name = "Audrey Alessandrini",
            Age = 31,
            JobTitle = "Senior Delivery Lead",
            Department = "Delivery",
            ManagerId = 80470,
            YearsOfService = 8,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 72146,
            Name = "Kamila Aslakhanov",
            Age = 37,
            JobTitle = "Delivery Lead",
            Department = "Support",
            ManagerId = 32376,
            YearsOfService = 5,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 72223,
            Name = "Julie Lee",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 72606,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 72606,
            Name = "Lawrence Kao",
            Age = 47,
            JobTitle = "Technical Lead",
            Department = "Support",
            ManagerId = 59591,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 72686,
            Name = "Enrica Widdowfield",
            Age = 34,
            JobTitle = "Senior Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 6,
            PayBand = 7,
            OnLeave = 1
        },
        new()
        {
            Id = 73079,
            Name = "Advik Chadha",
            Age = 35,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 87095,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 73126,
            Name = "Joelle Donaghy",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 23451,
            YearsOfService = 4,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 73444,
            Name = "Carl Russell",
            Age = 41,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 33330,
            YearsOfService = 10,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 73580,
            Name = "Penny Walker",
            Age = 35,
            JobTitle = "HR Partner",
            Department = "HR",
            ManagerId = 15519,
            YearsOfService = 11,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 73778,
            Name = "Barbara Cresswell",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 15711,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 74047,
            Name = "Ginevra Burless",
            Age = 38,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 73444,
            YearsOfService = 3,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 74567,
            Name = "Courtenay Potten",
            Age = 33,
            JobTitle = "Office Administrator",
            Department = "Office Management",
            ManagerId = 56808,
            YearsOfService = 4,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 74745,
            Name = "Selim Uyanik",
            Age = 28,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 16111,
            YearsOfService = 6,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 75083,
            Name = "Leonard Whitewood",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 48107,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 75187,
            Name = "Marinna Wodeland",
            Age = 28,
            JobTitle = "Receptionist",
            Department = "Office Management",
            ManagerId = 56808,
            YearsOfService = 5,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 76576,
            Name = "Tadao Asai",
            Age = 31,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 72606,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 77224,
            Name = "Georgina McKenzie",
            Age = 37,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 80470,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 79790,
            Name = "Caitrin Bartolomeu",
            Age = 20,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 55608,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 79919,
            Name = "Peter Green",
            Age = 28,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 37773,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 80470,
            Name = "Teddy Ivankovic",
            Age = 49,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 8,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 81086,
            Name = "Sareema Salehi",
            Age = 33,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 86772,
            YearsOfService = 8,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 81316,
            Name = "Similoluwa Esuola",
            Age = 30,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 54184,
            YearsOfService = 5,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 81496,
            Name = "Ceri Bellis",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 89037,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 81816,
            Name = "Yuan Wu",
            Age = 29,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 46850,
            YearsOfService = 5,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 82068,
            Name = "Feng Mai",
            Age = 37,
            JobTitle = "Technical Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 9,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 82329,
            Name = "Goldina Timpany",
            Age = 38,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 21687,
            YearsOfService = 2,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 82445,
            Name = "Basheera Kouri",
            Age = 23,
            JobTitle = "HR Advisor",
            Department = "HR",
            ManagerId = 68291,
            YearsOfService = 2,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 83752,
            Name = "Jawed Dar",
            Age = 31,
            JobTitle = "Delivery Lead",
            Department = "Support",
            ManagerId = 66994,
            YearsOfService = 6,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 84023,
            Name = "Barton Varren",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 15711,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 84047,
            Name = "Yewande Okoro",
            Age = 35,
            JobTitle = "Content Manager",
            Department = "Marketing",
            ManagerId = 10788,
            YearsOfService = 7,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 84379,
            Name = "Awni Ashkani",
            Age = 22,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 35920,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 84599,
            Name = "Kendall Becker",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 96663,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 84782,
            Name = "Belinda Feldt",
            Age = 29,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 20630,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 84981,
            Name = "Karlie Bartelli",
            Age = 25,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 62874,
            YearsOfService = 7,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 85010,
            Name = "Elsie Hartley",
            Age = 40,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 41548,
            YearsOfService = 8,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 85098,
            Name = "Dorry Filipic",
            Age = 37,
            JobTitle = "Delivery Lead",
            Department = "Consulting",
            ManagerId = 23975,
            YearsOfService = 4,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 85548,
            Name = "Priscilla Townsend",
            Age = 29,
            JobTitle = "Sales Manager",
            Department = "Sales",
            ManagerId = 44210,
            YearsOfService = 3,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 85571,
            Name = "Hideki Saito",
            Age = 44,
            JobTitle = "Senior Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 6,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 86208,
            Name = "Elizabeth Malone",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 62874,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 86299,
            Name = "Carlo Doherty",
            Age = 24,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 26637,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 86362,
            Name = "Jemmie Edmonds",
            Age = 34,
            JobTitle = "Management Accountant",
            Department = "Finance",
            ManagerId = 43518,
            YearsOfService = 4,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 86424,
            Name = "Rose Hallahan",
            Age = 38,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 65470,
            YearsOfService = 6,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 86665,
            Name = "Matthew Peterson",
            Age = 49,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 30934,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 86772,
            Name = "Mariele Pegram",
            Age = 37,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 33330,
            YearsOfService = 9,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 86955,
            Name = "Jamba Adeoye",
            Age = 27,
            JobTitle = "Receptionist",
            Department = "Office Management",
            ManagerId = 56808,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 87031,
            Name = "Heida Dowthwaite",
            Age = 27,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 59009,
            YearsOfService = 5,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 87095,
            Name = "Isaiah Madron",
            Age = 42,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 33330,
            YearsOfService = 10,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 87299,
            Name = "Layla Snowding",
            Age = 28,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 42203,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 87597,
            Name = "Dean Blumson",
            Age = 34,
            JobTitle = "Business Development Manager",
            Department = "Sales",
            ManagerId = 85548,
            YearsOfService = 6,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 87815,
            Name = "Daryle Bhatia",
            Age = 35,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 61328,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 88152,
            Name = "Nile Giles",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 12095,
            YearsOfService = 0,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 88390,
            Name = "Angelle Joyce",
            Age = 42,
            JobTitle = "Lead Technical Consultant",
            Department = "Consulting",
            ManagerId = 91855,
            YearsOfService = 8,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 88600,
            Name = "Roksana Kaczmarek",
            Age = 42,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 65176,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 89000,
            Name = "Corine Fay",
            Age = 36,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 72606,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 89037,
            Name = "Aishwarya Mukherjee",
            Age = 46,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 82068,
            YearsOfService = 10,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 89317,
            Name = "Lottie Hargrave",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 33676,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 89333,
            Name = "Sid Murtagh",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 57197,
            YearsOfService = 5,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 89407,
            Name = "Kearney Weippert",
            Age = 27,
            JobTitle = "Finance Assistant",
            Department = "Finance",
            ManagerId = 39362,
            YearsOfService = 6,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 89954,
            Name = "Carly Lei",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 69601,
            YearsOfService = 3,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 90548,
            Name = "Nile Awate",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 87815,
            YearsOfService = 3,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 90767,
            Name = "Adena Aitchinson",
            Age = 44,
            JobTitle = "Lead UX Designer",
            Department = "Design",
            ManagerId = 48545,
            YearsOfService = 10,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 90874,
            Name = "Haze Vanyukov",
            Age = 31,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 10,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 90939,
            Name = "Rosita Ortiz",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 88600,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 91237,
            Name = "Astor Blau",
            Age = 21,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 56390,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 91468,
            Name = "Alvinia Whannel",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 50053,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 91620,
            Name = "Ravi Parsa",
            Age = 48,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 60124,
            YearsOfService = 5,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 91810,
            Name = "Rosalina Lozada",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 66826,
            YearsOfService = 4,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 91855,
            Name = "Elfreda Burt",
            Age = 41,
            JobTitle = "Director",
            Department = "Consulting",
            ManagerId = 51708,
            YearsOfService = 6,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 92963,
            Name = "Loretta McDowell",
            Age = 28,
            JobTitle = "Technology Architect",
            Department = "Consulting",
            ManagerId = 10405,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 93027,
            Name = "Sam Owolabi",
            Age = 38,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 35118,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 93035,
            Name = "Wylie Jarrelt",
            Age = 55,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 54184,
            YearsOfService = 7,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 93142,
            Name = "Magdalena Jakubovics",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 79919,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 93402,
            Name = "Bobby Vize",
            Age = 30,
            JobTitle = "Finance Assistant",
            Department = "Finance",
            ManagerId = 39362,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 93424,
            Name = "Vimal Sundaram",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 27555,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 93679,
            Name = "Kyler Luther",
            Age = 40,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 71666,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 1
        },
        new()
        {
            Id = 94015,
            Name = "April Scay",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 59009,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 94389,
            Name = "Annie Jones",
            Age = 31,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 43228,
            YearsOfService = 10,
            PayBand = 8,
            OnLeave = 1
        },
        new()
        {
            Id = 94901,
            Name = "Devika Thaman",
            Age = 40,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 5,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 95287,
            Name = "Sibyl Durber",
            Age = 27,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 31138,
            YearsOfService = 7,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 95290,
            Name = "Teniola Adeyemi",
            Age = 24,
            JobTitle = "Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 96005,
            Name = "Mitra Ramachandran",
            Age = 37,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 36752,
            YearsOfService = 6,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 96663,
            Name = "Temidayo Joseph",
            Age = 41,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 25852,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 97382,
            Name = "Tito Hargrove",
            Age = 25,
            JobTitle = "UI Designer",
            Department = "Design",
            ManagerId = 57699,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 98817,
            Name = "Hamlin Camilletti",
            Age = 38,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 12445,
            YearsOfService = 5,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 99018,
            Name = "Cherilynn Watkins",
            Age = 36,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 15421,
            YearsOfService = 5,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 99069,
            Name = "Maksim Gusev",
            Age = 25,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 15711,
            YearsOfService = 3,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 99521,
            Name = "Gwan Min Ki",
            Age = 29,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 17018,
            YearsOfService = 8,
            PayBand = 4,
            OnLeave = 0
        }
    };
    
    public static readonly Employee EmployeeWithId51708 = new()
    {
        Id = 51708,
        Name = "Jasmine Harding",
        Age = 51,
        JobTitle = "Managing Director",
        Department = null,
        ManagerId = null,
        YearsOfService = 1,
        PayBand = 12,
        OnLeave = 0
    };
    
    public static readonly List<Employee> First10Employees = new()
    {
        new()
        {
            Id = 10370,
            Name = "Paul Davies",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 57415,
            YearsOfService = 5,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 10405,
            Name = "Mark Jackson",
            Age = 45,
            JobTitle = "Delivery Lead",
            Department = "Consulting",
            ManagerId = 23975,
            YearsOfService = 9,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 10415,
            Name = "Tabby Franklin",
            Age = 39,
            JobTitle = "Delivery Lead",
            Department = "Support",
            ManagerId = 32376,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 10788,
            Name = "Benoit Durant",
            Age = 29,
            JobTitle = "Marketing Director",
            Department = "Marketing",
            ManagerId = null,
            YearsOfService = 9,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 10838,
            Name = "Carla Weber",
            Age = 25,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 42203,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 10883,
            Name = "Andras Lewerenz",
            Age = 39,
            JobTitle = "Business Analyst",
            Department = "Consulting",
            ManagerId = 85098,
            YearsOfService = 8,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 11024,
            Name = "Garwood Attridge",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 66133,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 12095,
            Name = "Helia Rivera",
            Age = 44,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 65470,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 12291,
            Name = "Garrett Mersh",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 43487,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 12442,
            Name = "Paige Bloomfield",
            Age = 37,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 47174,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        }
    };
    
    public static readonly List<Employee> AllEmployeesInAscendingNameOrder = new()
    {
        new()
        {
            Id = 47174,
            Name = "Abioye Emmanuel",
            Age = 44,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 85571,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 30040,
            Name = "Adala Stauss",
            Age = 39,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 46850,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 41701,
            Name = "Adebola Oyinlola",
            Age = 39,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 37773,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 90767,
            Name = "Adena Aitchinson",
            Age = 44,
            JobTitle = "Lead UX Designer",
            Department = "Design",
            ManagerId = 48545,
            YearsOfService = 10,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 65502,
            Name = "Adria Gascard",
            Age = 30,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 41824,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 28373,
            Name = "Adrienne Villeneuve",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 20453,
            YearsOfService = 5,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 73079,
            Name = "Advik Chadha",
            Age = 35,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 87095,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 89037,
            Name = "Aishwarya Mukherjee",
            Age = 46,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 82068,
            YearsOfService = 10,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 40908,
            Name = "Alain Fanthome",
            Age = 32,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 66133,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 66826,
            Name = "Alberto Felix",
            Age = 30,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 67176,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 41767,
            Name = "Alex Ambrogetti",
            Age = 45,
            JobTitle = "Lead Technical Consultant",
            Department = "Consulting",
            ManagerId = 91855,
            YearsOfService = 10,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 30834,
            Name = "Alex Fletcher",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 71168,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 60208,
            Name = "Alex Harris",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 27466,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 63854,
            Name = "Alexander Crowcombe",
            Age = 22,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 12712,
            YearsOfService = 4,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 14158,
            Name = "Alisha Srivastava",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 18114,
            YearsOfService = 3,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 36752,
            Name = "Alistair Thompson",
            Age = 37,
            JobTitle = "Technical Lead",
            Department = "Support",
            ManagerId = 15421,
            YearsOfService = 5,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 91468,
            Name = "Alvinia Whannel",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 50053,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 13829,
            Name = "Amala Sachs",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 94389,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 66133,
            Name = "Amit Seshadri",
            Age = 28,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 53555,
            YearsOfService = 6,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 41548,
            Name = "Anastasia Cocozza",
            Age = 39,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 82068,
            YearsOfService = 3,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 10883,
            Name = "Andras Lewerenz",
            Age = 39,
            JobTitle = "Business Analyst",
            Department = "Consulting",
            ManagerId = 85098,
            YearsOfService = 8,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 62470,
            Name = "Andrew Robinson",
            Age = 30,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 40978,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 88390,
            Name = "Angelle Joyce",
            Age = 42,
            JobTitle = "Lead Technical Consultant",
            Department = "Consulting",
            ManagerId = 91855,
            YearsOfService = 8,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 94389,
            Name = "Annie Jones",
            Age = 31,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 43228,
            YearsOfService = 10,
            PayBand = 8,
            OnLeave = 1
        },
        new()
        {
            Id = 71666,
            Name = "Antonia Rosgen",
            Age = 38,
            JobTitle = "Design Principal",
            Department = "Design",
            ManagerId = 48545,
            YearsOfService = 8,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 46973,
            Name = "Anushka Dmitrieva",
            Age = 35,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 12445,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 40899,
            Name = "Aoife Allington",
            Age = 26,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 47174,
            YearsOfService = 4,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 94015,
            Name = "April Scay",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 59009,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 18114,
            Name = "Artan Sayyid",
            Age = 44,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 65470,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 33873,
            Name = "Arthur Olatunji",
            Age = 35,
            JobTitle = "Business Development Manager",
            Department = "Sales",
            ManagerId = 85548,
            YearsOfService = 8,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 91237,
            Name = "Astor Blau",
            Age = 21,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 56390,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 32835,
            Name = "Audie Osborne",
            Age = 39,
            JobTitle = "Technical Consultant",
            Department = "Delivery",
            ManagerId = 88390,
            YearsOfService = 6,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 72137,
            Name = "Audrey Alessandrini",
            Age = 31,
            JobTitle = "Senior Delivery Lead",
            Department = "Delivery",
            ManagerId = 80470,
            YearsOfService = 8,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 42464,
            Name = "Audrie Rosgen",
            Age = 27,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 56390,
            YearsOfService = 5,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 84379,
            Name = "Awni Ashkani",
            Age = 22,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 35920,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 73778,
            Name = "Barbara Cresswell",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 15711,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 39363,
            Name = "Barbette Cutridge",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 91620,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 84023,
            Name = "Barton Varren",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 15711,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 82445,
            Name = "Basheera Kouri",
            Age = 23,
            JobTitle = "HR Advisor",
            Department = "HR",
            ManagerId = 68291,
            YearsOfService = 2,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 84782,
            Name = "Belinda Feldt",
            Age = 29,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 20630,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 10788,
            Name = "Benoit Durant",
            Age = 29,
            JobTitle = "Marketing Director",
            Department = "Marketing",
            ManagerId = null,
            YearsOfService = 9,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 35800,
            Name = "Bernardita Pedrosa",
            Age = 36,
            JobTitle = "Director",
            Department = "IT",
            ManagerId = null,
            YearsOfService = 8,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 93402,
            Name = "Bobby Vize",
            Age = 30,
            JobTitle = "Finance Assistant",
            Department = "Finance",
            ManagerId = 39362,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 43228,
            Name = "Braith Llewelyn",
            Age = 45,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 10,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 17551,
            Name = "Brana Josefs",
            Age = 28,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 88600,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 61098,
            Name = "Bryn Cecil",
            Age = 42,
            JobTitle = "Senior Designer",
            Department = "Design",
            ManagerId = 55608,
            YearsOfService = 8,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 79790,
            Name = "Caitrin Bartolomeu",
            Age = 20,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 55608,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 15328,
            Name = "Camille Craighall",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 20453,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 73444,
            Name = "Carl Russell",
            Age = 41,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 33330,
            YearsOfService = 10,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 10838,
            Name = "Carla Weber",
            Age = 25,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 42203,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 86299,
            Name = "Carlo Doherty",
            Age = 24,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 26637,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 89954,
            Name = "Carly Lei",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 69601,
            YearsOfService = 3,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 39570,
            Name = "Carol Berrisford",
            Age = 20,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 36752,
            YearsOfService = 2,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 42775,
            Name = "Celestina Schober",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 86665,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 62564,
            Name = "Celestine Pennetta",
            Age = 32,
            JobTitle = "Legal Director",
            Department = "Legal",
            ManagerId = null,
            YearsOfService = 9,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 81496,
            Name = "Ceri Bellis",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 89037,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 44287,
            Name = "Charis Petracchi",
            Age = 35,
            JobTitle = "Technical Principal",
            Department = "Consulting",
            ManagerId = 91855,
            YearsOfService = 10,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 99018,
            Name = "Cherilynn Watkins",
            Age = 36,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 15421,
            YearsOfService = 5,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 37360,
            Name = "Chiebuka Nebechi",
            Age = 21,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 27555,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 63064,
            Name = "Chigozie Dilibe",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 16111,
            YearsOfService = 5,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 23451,
            Name = "Christabel Parnell",
            Age = 40,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 47967,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 21687,
            Name = "Christelle Charron",
            Age = 42,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 43169,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 54184,
            Name = "Cindra Murrells",
            Age = 42,
            JobTitle = "Technical Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 10,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 38174,
            Name = "Conan Sinclair",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 68615,
            YearsOfService = 3,
            PayBand = 1,
            OnLeave = 1
        },
        new()
        {
            Id = 26771,
            Name = "Conrad McGill",
            Age = 29,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 85571,
            YearsOfService = 5,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 89000,
            Name = "Corine Fay",
            Age = 36,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 72606,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 74567,
            Name = "Courtenay Potten",
            Age = 33,
            JobTitle = "Office Administrator",
            Department = "Office Management",
            ManagerId = 56808,
            YearsOfService = 4,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 22514,
            Name = "Dalton Cleft",
            Age = 27,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 61328,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 24194,
            Name = "Dan Chiu",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 57415,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 22143,
            Name = "Daphne Bishop",
            Age = 21,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 68615,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 87815,
            Name = "Daryle Bhatia",
            Age = 35,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 61328,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 51983,
            Name = "Davar Rahmanzai",
            Age = 30,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 31138,
            YearsOfService = 8,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 49333,
            Name = "David Taylor",
            Age = 47,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 87095,
            YearsOfService = 4,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 87597,
            Name = "Dean Blumson",
            Age = 34,
            JobTitle = "Business Development Manager",
            Department = "Sales",
            ManagerId = 85548,
            YearsOfService = 6,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 71441,
            Name = "Delshad Turabi",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 22570,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 94901,
            Name = "Devika Thaman",
            Age = 40,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 5,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 25088,
            Name = "Devin Shurey",
            Age = 43,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 90874,
            YearsOfService = 4,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 48434,
            Name = "Devina Linwood",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 41548,
            YearsOfService = 5,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 60100,
            Name = "Devlin Nicholls",
            Age = 34,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 57699,
            YearsOfService = 8,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 15711,
            Name = "Devonne Luckhurst",
            Age = 38,
            JobTitle = "Technical Lead",
            Department = "Support",
            ManagerId = 65178,
            YearsOfService = 10,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 85098,
            Name = "Dorry Filipic",
            Age = 37,
            JobTitle = "Delivery Lead",
            Department = "Consulting",
            ManagerId = 23975,
            YearsOfService = 4,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 67176,
            Name = "Duke Gudgen",
            Age = 49,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 4,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 21872,
            Name = "Eba Strand",
            Age = 39,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 93035,
            YearsOfService = 4,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 49856,
            Name = "Edeline Petrina",
            Age = 31,
            JobTitle = "Performance Analyst",
            Department = "Delivery",
            ManagerId = 69969,
            YearsOfService = 4,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 32225,
            Name = "Edric Ocalan",
            Age = 20,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 21687,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 1
        },
        new()
        {
            Id = 68418,
            Name = "Elena Adams",
            Age = 36,
            JobTitle = "Senior UX Designer",
            Department = "Design",
            ManagerId = 90767,
            YearsOfService = 6,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 91855,
            Name = "Elfreda Burt",
            Age = 41,
            JobTitle = "Director",
            Department = "Consulting",
            ManagerId = 51708,
            YearsOfService = 6,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 86208,
            Name = "Elizabeth Malone",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 62874,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 40035,
            Name = "Ella Cooper",
            Age = 23,
            JobTitle = "Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 2,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 13798,
            Name = "Eloise Beeson",
            Age = 28,
            JobTitle = "Accounts Assistant",
            Department = "Finance",
            ManagerId = 86362,
            YearsOfService = 4,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 85010,
            Name = "Elsie Hartley",
            Age = 40,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 41548,
            YearsOfService = 8,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 61948,
            Name = "Emera Harker",
            Age = 23,
            JobTitle = "Content Designer",
            Department = "Marketing",
            ManagerId = 84047,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 65176,
            Name = "Emmi Vanhalla",
            Age = 36,
            JobTitle = "Senior Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 6,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 41685,
            Name = "Eniola Micheal",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 31138,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 72686,
            Name = "Enrica Widdowfield",
            Age = 34,
            JobTitle = "Senior Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 6,
            PayBand = 7,
            OnLeave = 1
        },
        new()
        {
            Id = 65470,
            Name = "Esme Simon",
            Age = 48,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 82068,
            YearsOfService = 8,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 35605,
            Name = "Estefania Orozco",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 10405,
            YearsOfService = 0,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 15228,
            Name = "Eustace Wanell",
            Age = 29,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 87299,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 21447,
            Name = "Eveline Blanchar",
            Age = 46,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 53555,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 17018,
            Name = "Fabien Vials",
            Age = 43,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 33330,
            YearsOfService = 6,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 38634,
            Name = "Felix Varah",
            Age = 33,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 27555,
            YearsOfService = 8,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 69601,
            Name = "Fen Chao",
            Age = 35,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 43228,
            YearsOfService = 9,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 82068,
            Name = "Feng Mai",
            Age = 37,
            JobTitle = "Technical Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 9,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 56282,
            Name = "Florry Sandle",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 46072,
            YearsOfService = 5,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 15543,
            Name = "Gareth Newton",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 36752,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 12291,
            Name = "Garrett Mersh",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 43487,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 11024,
            Name = "Garwood Attridge",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 66133,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 77224,
            Name = "Georgina McKenzie",
            Age = 37,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 80470,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 60487,
            Name = "Gilberta Donohue",
            Age = 39,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 84782,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 62085,
            Name = "Gim Mishil",
            Age = 34,
            JobTitle = "IT Manager",
            Department = "IT",
            ManagerId = 35800,
            YearsOfService = 10,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 74047,
            Name = "Ginevra Burless",
            Age = 38,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 73444,
            YearsOfService = 3,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 45519,
            Name = "Glaw Davies",
            Age = 36,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 88600,
            YearsOfService = 1,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 38481,
            Name = "Glynnis McGahern",
            Age = 36,
            JobTitle = "Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 82329,
            Name = "Goldina Timpany",
            Age = 38,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 21687,
            YearsOfService = 2,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 69969,
            Name = "Grace Di Nisco",
            Age = 31,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 46827,
            YearsOfService = 7,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 57699,
            Name = "Greta Biasini",
            Age = 27,
            JobTitle = "Senior UX Designer",
            Department = "Design",
            ManagerId = 90767,
            YearsOfService = 3,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 49034,
            Name = "Guanyin Liang",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 16111,
            YearsOfService = 0,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 46850,
            Name = "Gustaw Zawadski",
            Age = 29,
            JobTitle = "Technical Lead",
            Department = "Support",
            ManagerId = 61328,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 99521,
            Name = "Gwan Min Ki",
            Age = 29,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 17018,
            YearsOfService = 8,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 26534,
            Name = "Habibah Amari",
            Age = 29,
            JobTitle = "HR Advisor",
            Department = "HR",
            ManagerId = 73580,
            YearsOfService = 9,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 33330,
            Name = "Hadrienne Labelle",
            Age = 36,
            JobTitle = "Technical Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 7,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 41824,
            Name = "Haiya Mohan",
            Age = 41,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 30934,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 38179,
            Name = "Hamisi Akunyili",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 17018,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 98817,
            Name = "Hamlin Camilletti",
            Age = 38,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 12445,
            YearsOfService = 5,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 36198,
            Name = "Hamood Machi",
            Age = 41,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 20630,
            YearsOfService = 5,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 27225,
            Name = "Hanna Wozniak",
            Age = 43,
            JobTitle = "Senior Technical Lead",
            Department = "Support",
            ManagerId = 65178,
            YearsOfService = 9,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 64989,
            Name = "Hassan Rosado",
            Age = 47,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 20630,
            YearsOfService = 5,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 90874,
            Name = "Haze Vanyukov",
            Age = 31,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 10,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 87031,
            Name = "Heida Dowthwaite",
            Age = 27,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 59009,
            YearsOfService = 5,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 27555,
            Name = "Heidi Jennings",
            Age = 37,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 37773,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 12095,
            Name = "Helia Rivera",
            Age = 44,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 65470,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 50053,
            Name = "Herrick Hazel",
            Age = 38,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 43169,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 1
        },
        new()
        {
            Id = 85571,
            Name = "Hideki Saito",
            Age = 44,
            JobTitle = "Senior Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 6,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 29648,
            Name = "Hildy Warricker",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 54178,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 38537,
            Name = "Hillary Walster",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 85098,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 49239,
            Name = "Hong Yao",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 89037,
            YearsOfService = 4,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 40293,
            Name = "Hortense Martel",
            Age = 21,
            JobTitle = "Business Analyst",
            Department = "Delivery",
            ManagerId = 22570,
            YearsOfService = 1,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 31138,
            Name = "Hsin Sun",
            Age = 36,
            JobTitle = "Technical Lead",
            Department = "Support",
            ManagerId = 65178,
            YearsOfService = 9,
            PayBand = 8,
            OnLeave = 1
        },
        new()
        {
            Id = 24406,
            Name = "Huan Hu",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 71609,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 66994,
            Name = "Huberto Arondel",
            Age = 54,
            JobTitle = "Delivery Principal",
            Department = "Support",
            ManagerId = 12610,
            YearsOfService = 8,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 71609,
            Name = "Hugh Runnett",
            Age = 40,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 46827,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 26543,
            Name = "Ida Pachmann",
            Age = 38,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 18114,
            YearsOfService = 6,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 68162,
            Name = "Idowu Adebayo",
            Age = 37,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 68615,
            YearsOfService = 1,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 48950,
            Name = "Iheoma Belonwu",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 25088,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 65603,
            Name = "Indira Toor",
            Age = 21,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 35920,
            YearsOfService = 3,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 24592,
            Name = "Inessa Williamson",
            Age = 33,
            JobTitle = "Senior Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 5,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 35920,
            Name = "Isaiah Little",
            Age = 32,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 60124,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 87095,
            Name = "Isaiah Madron",
            Age = 42,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 33330,
            YearsOfService = 10,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 54956,
            Name = "Isandro Danon",
            Age = 25,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 54178,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 49100,
            Name = "Iva Parkin",
            Age = 40,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 59009,
            YearsOfService = 8,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 18810,
            Name = "Jackson Wilkinson",
            Age = 40,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 59591,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 19348,
            Name = "Jade Harding",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 83752,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 86955,
            Name = "Jamba Adeoye",
            Age = 27,
            JobTitle = "Receptionist",
            Department = "Office Management",
            ManagerId = 56808,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 30004,
            Name = "James Hall",
            Age = 24,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 57415,
            YearsOfService = 5,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 51708,
            Name = "Jasmine Harding",
            Age = 51,
            JobTitle = "Managing Director",
            Department = null,
            ManagerId = null,
            YearsOfService = 1,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 83752,
            Name = "Jawed Dar",
            Age = 31,
            JobTitle = "Delivery Lead",
            Department = "Support",
            ManagerId = 66994,
            YearsOfService = 6,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 86362,
            Name = "Jemmie Edmonds",
            Age = 34,
            JobTitle = "Management Accountant",
            Department = "Finance",
            ManagerId = 43518,
            YearsOfService = 4,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 59591,
            Name = "Jenete Ibekwe",
            Age = 49,
            JobTitle = "Senior Technical Lead",
            Department = "Support",
            ManagerId = 65178,
            YearsOfService = 7,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 62660,
            Name = "Jie Tsao",
            Age = 28,
            JobTitle = "Senior Delivery Lead",
            Department = "Delivery",
            ManagerId = 46827,
            YearsOfService = 7,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 30918,
            Name = "Jobina Badrick",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 87299,
            YearsOfService = 3,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 51168,
            Name = "Joe Smith",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 53479,
            YearsOfService = 4,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 73126,
            Name = "Joelle Donaghy",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 23451,
            YearsOfService = 4,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 52006,
            Name = "Joshua Tuddall",
            Age = 21,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 71666,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 72223,
            Name = "Julie Lee",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 72606,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 53479,
            Name = "Julita Kucharska",
            Age = 41,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 67176,
            YearsOfService = 5,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 33676,
            Name = "Jun Hou",
            Age = 40,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 53555,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 15584,
            Name = "Junpei Takayama",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 23300,
            YearsOfService = 5,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 49009,
            Name = "Justin Fairbank",
            Age = 26,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 41824,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 50683,
            Name = "Kamala Sagar",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 98817,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 72146,
            Name = "Kamila Aslakhanov",
            Age = 37,
            JobTitle = "Delivery Lead",
            Department = "Support",
            ManagerId = 32376,
            YearsOfService = 5,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 30934,
            Name = "Karen Romero",
            Age = 53,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 54184,
            YearsOfService = 9,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 41342,
            Name = "Karim Brumfitt",
            Age = 42,
            JobTitle = "Senior Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 38567,
            Name = "Karimah Atiyeh",
            Age = 37,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 71666,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 84981,
            Name = "Karlie Bartelli",
            Age = 25,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 62874,
            YearsOfService = 7,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 69712,
            Name = "Karolina Dudek",
            Age = 27,
            JobTitle = "Content Designer",
            Department = "Marketing",
            ManagerId = 84047,
            YearsOfService = 5,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 42203,
            Name = "Kasia Lennon",
            Age = 43,
            JobTitle = "Senior Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 9,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 45521,
            Name = "Kayin Owayale",
            Age = 50,
            JobTitle = "Director",
            Department = "Delivery",
            ManagerId = 51708,
            YearsOfService = 8,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 89407,
            Name = "Kearney Weippert",
            Age = 27,
            JobTitle = "Finance Assistant",
            Department = "Finance",
            ManagerId = 39362,
            YearsOfService = 6,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 84599,
            Name = "Kendall Becker",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 96663,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 60124,
            Name = "Kerri Perryman",
            Age = 53,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 82068,
            YearsOfService = 6,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 58721,
            Name = "Kingsley Pateman",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 26637,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 67933,
            Name = "Kirstin Cliff",
            Age = 49,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 43169,
            YearsOfService = 9,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 35811,
            Name = "Klara Nowak",
            Age = 25,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 47967,
            YearsOfService = 5,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 45726,
            Name = "Kris Conachie",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 41548,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 23736,
            Name = "Kristi Pattillo",
            Age = 22,
            JobTitle = "HR Administrator",
            Department = "HR",
            ManagerId = 73580,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 93679,
            Name = "Kyler Luther",
            Age = 40,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 71666,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 1
        },
        new()
        {
            Id = 49418,
            Name = "Larissa Larson",
            Age = 39,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 87299,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 72606,
            Name = "Lawrence Kao",
            Age = 47,
            JobTitle = "Technical Lead",
            Department = "Support",
            ManagerId = 59591,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 87299,
            Name = "Layla Snowding",
            Age = 28,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 42203,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 15367,
            Name = "Lei Shirong",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 47174,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 56808,
            Name = "Leon Voronov",
            Age = 41,
            JobTitle = "Office Manager",
            Department = "Office Management",
            ManagerId = 51708,
            YearsOfService = 10,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 75083,
            Name = "Leonard Whitewood",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 48107,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 43518,
            Name = "Leroy Lamb",
            Age = 44,
            JobTitle = "Finance Director",
            Department = "Finance",
            ManagerId = null,
            YearsOfService = 10,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 57793,
            Name = "Li Meng",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 41701,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 44697,
            Name = "Lidya Nasih",
            Age = 35,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 54178,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 57659,
            Name = "Lok Tsai",
            Age = 24,
            JobTitle = "Technology Architect",
            Department = "Delivery",
            ManagerId = 69601,
            YearsOfService = 3,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 46072,
            Name = "Lonnie Sumnall",
            Age = 50,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 45663,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 92963,
            Name = "Loretta McDowell",
            Age = 28,
            JobTitle = "Technology Architect",
            Department = "Consulting",
            ManagerId = 10405,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 89317,
            Name = "Lottie Hargrave",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 33676,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 23776,
            Name = "Lucian Hamshar",
            Age = 48,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 45663,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 22570,
            Name = "Macey Christie",
            Age = 31,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 25852,
            YearsOfService = 6,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 12459,
            Name = "Maddie Simons",
            Age = 25,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 59591,
            YearsOfService = 6,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 93142,
            Name = "Magdalena Jakubovics",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 79919,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 71045,
            Name = "Maki Okada",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 86772,
            YearsOfService = 4,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 99069,
            Name = "Maksim Gusev",
            Age = 25,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 15711,
            YearsOfService = 3,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 61575,
            Name = "Mangjeol Haru",
            Age = 36,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 27225,
            YearsOfService = 10,
            PayBand = 6,
            OnLeave = 1
        },
        new()
        {
            Id = 44455,
            Name = "Manish Tara",
            Age = 21,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 68418,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 26670,
            Name = "Manolo Wheelan",
            Age = 37,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 62874,
            YearsOfService = 5,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 71168,
            Name = "Margaret Woolford",
            Age = 45,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 90874,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 63680,
            Name = "Margot Booth",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 10415,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 30713,
            Name = "Marian Augustin",
            Age = 29,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 55608,
            YearsOfService = 7,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 48545,
            Name = "Mariele Monnelly",
            Age = 35,
            JobTitle = "Director",
            Department = "Design",
            ManagerId = 51708,
            YearsOfService = 7,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 86772,
            Name = "Mariele Pegram",
            Age = 37,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 33330,
            YearsOfService = 9,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 75187,
            Name = "Marinna Wodeland",
            Age = 28,
            JobTitle = "Receptionist",
            Department = "Office Management",
            ManagerId = 56808,
            YearsOfService = 5,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 10405,
            Name = "Mark Jackson",
            Age = 45,
            JobTitle = "Delivery Lead",
            Department = "Consulting",
            ManagerId = 23975,
            YearsOfService = 9,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 35776,
            Name = "Marya Holcroft",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 64989,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 21639,
            Name = "Maryann Bresner",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 35920,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 65178,
            Name = "Masako Takahashi",
            Age = 42,
            JobTitle = "Technical Principal",
            Department = "Support",
            ManagerId = 12610,
            YearsOfService = 9,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 61242,
            Name = "Massawa Mustafa",
            Age = 37,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 93035,
            YearsOfService = 9,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 86665,
            Name = "Matthew Peterson",
            Age = 49,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 30934,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 55608,
            Name = "Mauricio Aslet",
            Age = 36,
            JobTitle = "Design Principal",
            Department = "Design",
            ManagerId = 48545,
            YearsOfService = 9,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 28515,
            Name = "Maysa Haq",
            Age = 28,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 66133,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 70188,
            Name = "Meike Krantz",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 23776,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 48107,
            Name = "Melanie Frankton",
            Age = 37,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 81316,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 27466,
            Name = "Michael Wilson",
            Age = 36,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 80470,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 42769,
            Name = "Miguel Lodwig",
            Age = 38,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 60124,
            YearsOfService = 3,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 46827,
            Name = "Miranda Mullins",
            Age = 30,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 7,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 96005,
            Name = "Mitra Ramachandran",
            Age = 37,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 36752,
            YearsOfService = 6,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 13989,
            Name = "Monah Scarisbrick",
            Age = 39,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 68418,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 12712,
            Name = "Monisola Ojo",
            Age = 32,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 87095,
            YearsOfService = 3,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 24314,
            Name = "Mosiya Okonjo",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 69969,
            YearsOfService = 0,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 39362,
            Name = "Nadia Gordon",
            Age = 41,
            JobTitle = "Finance Manager",
            Department = "Finance",
            ManagerId = 43518,
            YearsOfService = 7,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 37773,
            Name = "Nadya Thridgould",
            Age = 43,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 33330,
            YearsOfService = 9,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 56141,
            Name = "Namrata Kumer",
            Age = 27,
            JobTitle = "Legal Administrator",
            Department = "Legal",
            ManagerId = 61062,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 18682,
            Name = "Ned Farmer",
            Age = 27,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 84782,
            YearsOfService = 4,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 59009,
            Name = "Niko Acory",
            Age = 30,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 47967,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 90548,
            Name = "Nile Awate",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 87815,
            YearsOfService = 3,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 88152,
            Name = "Nile Giles",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 12095,
            YearsOfService = 0,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 47323,
            Name = "Nina Kenny",
            Age = 29,
            JobTitle = "Technology Architect",
            Department = "Delivery",
            ManagerId = 94389,
            YearsOfService = 4,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 54178,
            Name = "Nona O'Neill",
            Age = 49,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 10,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 33797,
            Name = "Olayinka Isiaka",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 84782,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 21656,
            Name = "Olufemi Ikande",
            Age = 24,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 20453,
            YearsOfService = 6,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 66478,
            Name = "Oluwasola Akintola",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 46973,
            YearsOfService = 5,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 47967,
            Name = "Oscar Holmes",
            Age = 49,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 33330,
            YearsOfService = 7,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 12442,
            Name = "Paige Bloomfield",
            Age = 37,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 47174,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 20453,
            Name = "Pan Mirae",
            Age = 50,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 54184,
            YearsOfService = 3,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 38678,
            Name = "Pashan Ghazali",
            Age = 30,
            JobTitle = "Legal Administrator",
            Department = "Legal",
            ManagerId = 61062,
            YearsOfService = 8,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 32376,
            Name = "Patricia Cooper",
            Age = 47,
            JobTitle = "Delivery Principal",
            Department = "Support",
            ManagerId = 12610,
            YearsOfService = 6,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 49508,
            Name = "Patrick French",
            Age = 24,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 26637,
            YearsOfService = 6,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 10370,
            Name = "Paul Davies",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 57415,
            YearsOfService = 5,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 73580,
            Name = "Penny Walker",
            Age = 35,
            JobTitle = "HR Partner",
            Department = "HR",
            ManagerId = 15519,
            YearsOfService = 11,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 35118,
            Name = "Peri Adanir",
            Age = 27,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 54184,
            YearsOfService = 5,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 79919,
            Name = "Peter Green",
            Age = 28,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 37773,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 85548,
            Name = "Priscilla Townsend",
            Age = 29,
            JobTitle = "Sales Manager",
            Department = "Sales",
            ManagerId = 44210,
            YearsOfService = 3,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 58784,
            Name = "Raafida Panhwar",
            Age = 34,
            JobTitle = "Office Administrator",
            Department = "Office Management",
            ManagerId = 56808,
            YearsOfService = 4,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 47808,
            Name = "Raghav Merchant",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 77224,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 46357,
            Name = "Rajesh Pai",
            Age = 30,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 35118,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 23975,
            Name = "Rani Prabhu",
            Age = 42,
            JobTitle = "Delivery Principal",
            Department = "Consulting",
            ManagerId = 91855,
            YearsOfService = 9,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 68291,
            Name = "Raoul Restorick",
            Age = 27,
            JobTitle = "HR Partner",
            Department = "HR",
            ManagerId = 15519,
            YearsOfService = 8,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 26241,
            Name = "Raquela Fryman",
            Age = 20,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 17018,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 91620,
            Name = "Ravi Parsa",
            Age = 48,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 60124,
            YearsOfService = 5,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 57415,
            Name = "Rayan Malik",
            Age = 48,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 73444,
            YearsOfService = 3,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 16111,
            Name = "Rebecca Joron",
            Age = 29,
            JobTitle = "Technical Lead",
            Department = "Support",
            ManagerId = 27225,
            YearsOfService = 6,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 61328,
            Name = "Ricca Dewdeny",
            Age = 54,
            JobTitle = "Senior Technical Lead",
            Department = "Support",
            ManagerId = 65178,
            YearsOfService = 9,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 41375,
            Name = "Ritu Thakur",
            Age = 32,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 86772,
            YearsOfService = 7,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 24519,
            Name = "Robert Clarke",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 72146,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 88600,
            Name = "Roksana Kaczmarek",
            Age = 42,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 65176,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 91810,
            Name = "Rosalina Lozada",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 66826,
            YearsOfService = 4,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 86424,
            Name = "Rose Hallahan",
            Age = 38,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 65470,
            YearsOfService = 6,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 90939,
            Name = "Rosita Ortiz",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 88600,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 17625,
            Name = "Rubin Petroff",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 86424,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 12610,
            Name = "Ruth Craig",
            Age = 53,
            JobTitle = "Director",
            Department = "Support",
            ManagerId = 51708,
            YearsOfService = 9,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 15421,
            Name = "Ryo Igarashi",
            Age = 54,
            JobTitle = "Senior Technical Lead",
            Department = "Support",
            ManagerId = 65178,
            YearsOfService = 8,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 27117,
            Name = "Sally Nash",
            Age = 46,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 85571,
            YearsOfService = 10,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 93027,
            Name = "Sam Owolabi",
            Age = 38,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 35118,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 68697,
            Name = "Samantha Liao",
            Age = 32,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 65176,
            YearsOfService = 6,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 26637,
            Name = "Sarah Evans",
            Age = 25,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 81316,
            YearsOfService = 3,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 81086,
            Name = "Sareema Salehi",
            Age = 33,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 86772,
            YearsOfService = 8,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 39741,
            Name = "Sawyer Thowes",
            Age = 32,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 65176,
            YearsOfService = 8,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 74745,
            Name = "Selim Uyanik",
            Age = 28,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 16111,
            YearsOfService = 6,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 57666,
            Name = "Shaun Braun",
            Age = 34,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 94901,
            YearsOfService = 4,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 62874,
            Name = "Shazia Rashid",
            Age = 31,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 45663,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 33337,
            Name = "Sheila Rubertis",
            Age = 30,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 89037,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 25852,
            Name = "Shireen Chachar",
            Age = 37,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 9,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 95287,
            Name = "Sibyl Durber",
            Age = 27,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 31138,
            YearsOfService = 7,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 89333,
            Name = "Sid Murtagh",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 57197,
            YearsOfService = 5,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 43169,
            Name = "Sidney Paoli",
            Age = 40,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 82068,
            YearsOfService = 10,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 81316,
            Name = "Similoluwa Esuola",
            Age = 30,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 54184,
            YearsOfService = 5,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 61062,
            Name = "Solomon Goldstein",
            Age = 33,
            JobTitle = "Legal Advisor",
            Department = "Legal",
            ManagerId = 62564,
            YearsOfService = 2,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 68615,
            Name = "Sona Sachdeva",
            Age = 45,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 93035,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 23326,
            Name = "Stefa Padrick",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 21687,
            YearsOfService = 4,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 16490,
            Name = "Sumit Ghosh",
            Age = 32,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 30934,
            YearsOfService = 4,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 15519,
            Name = "Sunita Patel",
            Age = 44,
            JobTitle = "HR Director",
            Department = "HR",
            ManagerId = null,
            YearsOfService = 5,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 57197,
            Name = "Surya Sandhu",
            Age = 28,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 73444,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 32185,
            Name = "Susan Harris",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 12459,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 61021,
            Name = "Sushila Sabharwal",
            Age = 31,
            JobTitle = "IT Administrator",
            Department = "IT",
            ManagerId = 62085,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 10415,
            Name = "Tabby Franklin",
            Age = 39,
            JobTitle = "Delivery Lead",
            Department = "Support",
            ManagerId = 32376,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 76576,
            Name = "Tadao Asai",
            Age = 31,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 72606,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 62442,
            Name = "Tae Kyung",
            Age = 25,
            JobTitle = "IT Administrator",
            Department = "IT",
            ManagerId = 62085,
            YearsOfService = 6,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 22544,
            Name = "Tan Jia",
            Age = 46,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 15421,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 28478,
            Name = "Tariq Qadiri",
            Age = 34,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 94901,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 80470,
            Name = "Teddy Ivankovic",
            Age = 49,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 8,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 96663,
            Name = "Temidayo Joseph",
            Age = 41,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 25852,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 95290,
            Name = "Teniola Adeyemi",
            Age = 24,
            JobTitle = "Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 26451,
            Name = "Teresita Evans",
            Age = 27,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 12712,
            YearsOfService = 4,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 20630,
            Name = "Thomas Edwards",
            Age = 37,
            JobTitle = "Senior Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 8,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 97382,
            Name = "Tito Hargrove",
            Age = 25,
            JobTitle = "UI Designer",
            Department = "Design",
            ManagerId = 57699,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 34534,
            Name = "Trista Redolfi",
            Age = 26,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 41824,
            YearsOfService = 8,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 37599,
            Name = "Ulric Josskovitz",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 46850,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 53555,
            Name = "Ursula Klemmt",
            Age = 38,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 54184,
            YearsOfService = 9,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 48747,
            Name = "Usman Shah",
            Age = 33,
            JobTitle = "Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 6,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 23300,
            Name = "Valini Srinivas",
            Age = 28,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 27225,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 12445,
            Name = "Vania Yates",
            Age = 49,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 6,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 40978,
            Name = "Varsha Tak",
            Age = 27,
            JobTitle = "Delivery Lead",
            Department = "Support",
            ManagerId = 66994,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 16215,
            Name = "Veda Cartledge",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 94901,
            YearsOfService = 0,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 56390,
            Name = "Victor Nicholson",
            Age = 31,
            JobTitle = "Senior UX Designer",
            Department = "Design",
            ManagerId = 90767,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 35432,
            Name = "Victoria Brown",
            Age = 29,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 42203,
            YearsOfService = 3,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 93424,
            Name = "Vimal Sundaram",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 27555,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 69790,
            Name = "Viola Shelton",
            Age = 25,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 18114,
            YearsOfService = 6,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 43487,
            Name = "Waseema Mirza",
            Age = 42,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 81316,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 93035,
            Name = "Wylie Jarrelt",
            Age = 55,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 54184,
            YearsOfService = 7,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 84047,
            Name = "Yewande Okoro",
            Age = 35,
            JobTitle = "Content Manager",
            Department = "Marketing",
            ManagerId = 10788,
            YearsOfService = 7,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 14007,
            Name = "Yilma Loharani",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 12712,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 81816,
            Name = "Yuan Wu",
            Age = 29,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 46850,
            YearsOfService = 5,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 54805,
            Name = "Yvonne O'Donovan",
            Age = 37,
            JobTitle = "Office Administrator",
            Department = "Office Management",
            ManagerId = 56808,
            YearsOfService = 9,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 34751,
            Name = "Zahidah Said",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 26771,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 44210,
            Name = "Zahra Ahmed",
            Age = 55,
            JobTitle = "Sales Director",
            Department = "Sales",
            ManagerId = null,
            YearsOfService = 5,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 46141,
            Name = "Zakiya Godina",
            Age = 38,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 35118,
            YearsOfService = 3,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 37585,
            Name = "Zhen Wei",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 42769,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 45663,
            Name = "Zou Ruolan",
            Age = 50,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 82068,
            YearsOfService = 10,
            PayBand = 10,
            OnLeave = 0
        }
    };

    public static readonly List<Employee> AllEmployeesInDescendingNameOrder = new()
    {
        new()
        {
            Id = 45663,
            Name = "Zou Ruolan",
            Age = 50,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 82068,
            YearsOfService = 10,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 37585,
            Name = "Zhen Wei",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 42769,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 46141,
            Name = "Zakiya Godina",
            Age = 38,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 35118,
            YearsOfService = 3,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 44210,
            Name = "Zahra Ahmed",
            Age = 55,
            JobTitle = "Sales Director",
            Department = "Sales",
            ManagerId = null,
            YearsOfService = 5,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 34751,
            Name = "Zahidah Said",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 26771,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 54805,
            Name = "Yvonne O'Donovan",
            Age = 37,
            JobTitle = "Office Administrator",
            Department = "Office Management",
            ManagerId = 56808,
            YearsOfService = 9,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 81816,
            Name = "Yuan Wu",
            Age = 29,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 46850,
            YearsOfService = 5,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 14007,
            Name = "Yilma Loharani",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 12712,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 84047,
            Name = "Yewande Okoro",
            Age = 35,
            JobTitle = "Content Manager",
            Department = "Marketing",
            ManagerId = 10788,
            YearsOfService = 7,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 93035,
            Name = "Wylie Jarrelt",
            Age = 55,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 54184,
            YearsOfService = 7,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 43487,
            Name = "Waseema Mirza",
            Age = 42,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 81316,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 69790,
            Name = "Viola Shelton",
            Age = 25,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 18114,
            YearsOfService = 6,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 93424,
            Name = "Vimal Sundaram",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 27555,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 35432,
            Name = "Victoria Brown",
            Age = 29,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 42203,
            YearsOfService = 3,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 56390,
            Name = "Victor Nicholson",
            Age = 31,
            JobTitle = "Senior UX Designer",
            Department = "Design",
            ManagerId = 90767,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 16215,
            Name = "Veda Cartledge",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 94901,
            YearsOfService = 0,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 40978,
            Name = "Varsha Tak",
            Age = 27,
            JobTitle = "Delivery Lead",
            Department = "Support",
            ManagerId = 66994,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 12445,
            Name = "Vania Yates",
            Age = 49,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 6,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 23300,
            Name = "Valini Srinivas",
            Age = 28,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 27225,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 48747,
            Name = "Usman Shah",
            Age = 33,
            JobTitle = "Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 6,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 53555,
            Name = "Ursula Klemmt",
            Age = 38,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 54184,
            YearsOfService = 9,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 37599,
            Name = "Ulric Josskovitz",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 46850,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 34534,
            Name = "Trista Redolfi",
            Age = 26,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 41824,
            YearsOfService = 8,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 97382,
            Name = "Tito Hargrove",
            Age = 25,
            JobTitle = "UI Designer",
            Department = "Design",
            ManagerId = 57699,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 20630,
            Name = "Thomas Edwards",
            Age = 37,
            JobTitle = "Senior Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 8,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 26451,
            Name = "Teresita Evans",
            Age = 27,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 12712,
            YearsOfService = 4,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 95290,
            Name = "Teniola Adeyemi",
            Age = 24,
            JobTitle = "Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 96663,
            Name = "Temidayo Joseph",
            Age = 41,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 25852,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 80470,
            Name = "Teddy Ivankovic",
            Age = 49,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 8,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 28478,
            Name = "Tariq Qadiri",
            Age = 34,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 94901,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 22544,
            Name = "Tan Jia",
            Age = 46,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 15421,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 62442,
            Name = "Tae Kyung",
            Age = 25,
            JobTitle = "IT Administrator",
            Department = "IT",
            ManagerId = 62085,
            YearsOfService = 6,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 76576,
            Name = "Tadao Asai",
            Age = 31,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 72606,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 10415,
            Name = "Tabby Franklin",
            Age = 39,
            JobTitle = "Delivery Lead",
            Department = "Support",
            ManagerId = 32376,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 61021,
            Name = "Sushila Sabharwal",
            Age = 31,
            JobTitle = "IT Administrator",
            Department = "IT",
            ManagerId = 62085,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 32185,
            Name = "Susan Harris",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 12459,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 57197,
            Name = "Surya Sandhu",
            Age = 28,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 73444,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 15519,
            Name = "Sunita Patel",
            Age = 44,
            JobTitle = "HR Director",
            Department = "HR",
            ManagerId = null,
            YearsOfService = 5,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 16490,
            Name = "Sumit Ghosh",
            Age = 32,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 30934,
            YearsOfService = 4,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 23326,
            Name = "Stefa Padrick",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 21687,
            YearsOfService = 4,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 68615,
            Name = "Sona Sachdeva",
            Age = 45,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 93035,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 61062,
            Name = "Solomon Goldstein",
            Age = 33,
            JobTitle = "Legal Advisor",
            Department = "Legal",
            ManagerId = 62564,
            YearsOfService = 2,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 81316,
            Name = "Similoluwa Esuola",
            Age = 30,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 54184,
            YearsOfService = 5,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 43169,
            Name = "Sidney Paoli",
            Age = 40,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 82068,
            YearsOfService = 10,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 89333,
            Name = "Sid Murtagh",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 57197,
            YearsOfService = 5,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 95287,
            Name = "Sibyl Durber",
            Age = 27,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 31138,
            YearsOfService = 7,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 25852,
            Name = "Shireen Chachar",
            Age = 37,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 9,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 33337,
            Name = "Sheila Rubertis",
            Age = 30,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 89037,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 62874,
            Name = "Shazia Rashid",
            Age = 31,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 45663,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 57666,
            Name = "Shaun Braun",
            Age = 34,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 94901,
            YearsOfService = 4,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 74745,
            Name = "Selim Uyanik",
            Age = 28,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 16111,
            YearsOfService = 6,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 39741,
            Name = "Sawyer Thowes",
            Age = 32,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 65176,
            YearsOfService = 8,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 81086,
            Name = "Sareema Salehi",
            Age = 33,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 86772,
            YearsOfService = 8,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 26637,
            Name = "Sarah Evans",
            Age = 25,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 81316,
            YearsOfService = 3,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 68697,
            Name = "Samantha Liao",
            Age = 32,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 65176,
            YearsOfService = 6,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 93027,
            Name = "Sam Owolabi",
            Age = 38,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 35118,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 27117,
            Name = "Sally Nash",
            Age = 46,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 85571,
            YearsOfService = 10,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 15421,
            Name = "Ryo Igarashi",
            Age = 54,
            JobTitle = "Senior Technical Lead",
            Department = "Support",
            ManagerId = 65178,
            YearsOfService = 8,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 12610,
            Name = "Ruth Craig",
            Age = 53,
            JobTitle = "Director",
            Department = "Support",
            ManagerId = 51708,
            YearsOfService = 9,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 17625,
            Name = "Rubin Petroff",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 86424,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 90939,
            Name = "Rosita Ortiz",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 88600,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 86424,
            Name = "Rose Hallahan",
            Age = 38,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 65470,
            YearsOfService = 6,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 91810,
            Name = "Rosalina Lozada",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 66826,
            YearsOfService = 4,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 88600,
            Name = "Roksana Kaczmarek",
            Age = 42,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 65176,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 24519,
            Name = "Robert Clarke",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 72146,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 41375,
            Name = "Ritu Thakur",
            Age = 32,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 86772,
            YearsOfService = 7,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 61328,
            Name = "Ricca Dewdeny",
            Age = 54,
            JobTitle = "Senior Technical Lead",
            Department = "Support",
            ManagerId = 65178,
            YearsOfService = 9,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 16111,
            Name = "Rebecca Joron",
            Age = 29,
            JobTitle = "Technical Lead",
            Department = "Support",
            ManagerId = 27225,
            YearsOfService = 6,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 57415,
            Name = "Rayan Malik",
            Age = 48,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 73444,
            YearsOfService = 3,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 91620,
            Name = "Ravi Parsa",
            Age = 48,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 60124,
            YearsOfService = 5,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 26241,
            Name = "Raquela Fryman",
            Age = 20,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 17018,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 68291,
            Name = "Raoul Restorick",
            Age = 27,
            JobTitle = "HR Partner",
            Department = "HR",
            ManagerId = 15519,
            YearsOfService = 8,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 23975,
            Name = "Rani Prabhu",
            Age = 42,
            JobTitle = "Delivery Principal",
            Department = "Consulting",
            ManagerId = 91855,
            YearsOfService = 9,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 46357,
            Name = "Rajesh Pai",
            Age = 30,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 35118,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 47808,
            Name = "Raghav Merchant",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 77224,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 58784,
            Name = "Raafida Panhwar",
            Age = 34,
            JobTitle = "Office Administrator",
            Department = "Office Management",
            ManagerId = 56808,
            YearsOfService = 4,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 85548,
            Name = "Priscilla Townsend",
            Age = 29,
            JobTitle = "Sales Manager",
            Department = "Sales",
            ManagerId = 44210,
            YearsOfService = 3,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 79919,
            Name = "Peter Green",
            Age = 28,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 37773,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 35118,
            Name = "Peri Adanir",
            Age = 27,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 54184,
            YearsOfService = 5,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 73580,
            Name = "Penny Walker",
            Age = 35,
            JobTitle = "HR Partner",
            Department = "HR",
            ManagerId = 15519,
            YearsOfService = 11,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 10370,
            Name = "Paul Davies",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 57415,
            YearsOfService = 5,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 49508,
            Name = "Patrick French",
            Age = 24,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 26637,
            YearsOfService = 6,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 32376,
            Name = "Patricia Cooper",
            Age = 47,
            JobTitle = "Delivery Principal",
            Department = "Support",
            ManagerId = 12610,
            YearsOfService = 6,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 38678,
            Name = "Pashan Ghazali",
            Age = 30,
            JobTitle = "Legal Administrator",
            Department = "Legal",
            ManagerId = 61062,
            YearsOfService = 8,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 20453,
            Name = "Pan Mirae",
            Age = 50,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 54184,
            YearsOfService = 3,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 12442,
            Name = "Paige Bloomfield",
            Age = 37,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 47174,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 47967,
            Name = "Oscar Holmes",
            Age = 49,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 33330,
            YearsOfService = 7,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 66478,
            Name = "Oluwasola Akintola",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 46973,
            YearsOfService = 5,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 21656,
            Name = "Olufemi Ikande",
            Age = 24,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 20453,
            YearsOfService = 6,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 33797,
            Name = "Olayinka Isiaka",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 84782,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 54178,
            Name = "Nona O'Neill",
            Age = 49,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 10,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 47323,
            Name = "Nina Kenny",
            Age = 29,
            JobTitle = "Technology Architect",
            Department = "Delivery",
            ManagerId = 94389,
            YearsOfService = 4,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 88152,
            Name = "Nile Giles",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 12095,
            YearsOfService = 0,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 90548,
            Name = "Nile Awate",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 87815,
            YearsOfService = 3,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 59009,
            Name = "Niko Acory",
            Age = 30,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 47967,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 18682,
            Name = "Ned Farmer",
            Age = 27,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 84782,
            YearsOfService = 4,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 56141,
            Name = "Namrata Kumer",
            Age = 27,
            JobTitle = "Legal Administrator",
            Department = "Legal",
            ManagerId = 61062,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 37773,
            Name = "Nadya Thridgould",
            Age = 43,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 33330,
            YearsOfService = 9,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 39362,
            Name = "Nadia Gordon",
            Age = 41,
            JobTitle = "Finance Manager",
            Department = "Finance",
            ManagerId = 43518,
            YearsOfService = 7,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 24314,
            Name = "Mosiya Okonjo",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 69969,
            YearsOfService = 0,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 12712,
            Name = "Monisola Ojo",
            Age = 32,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 87095,
            YearsOfService = 3,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 13989,
            Name = "Monah Scarisbrick",
            Age = 39,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 68418,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 96005,
            Name = "Mitra Ramachandran",
            Age = 37,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 36752,
            YearsOfService = 6,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 46827,
            Name = "Miranda Mullins",
            Age = 30,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 7,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 42769,
            Name = "Miguel Lodwig",
            Age = 38,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 60124,
            YearsOfService = 3,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 27466,
            Name = "Michael Wilson",
            Age = 36,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 80470,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 48107,
            Name = "Melanie Frankton",
            Age = 37,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 81316,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 70188,
            Name = "Meike Krantz",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 23776,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 28515,
            Name = "Maysa Haq",
            Age = 28,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 66133,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 55608,
            Name = "Mauricio Aslet",
            Age = 36,
            JobTitle = "Design Principal",
            Department = "Design",
            ManagerId = 48545,
            YearsOfService = 9,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 86665,
            Name = "Matthew Peterson",
            Age = 49,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 30934,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 61242,
            Name = "Massawa Mustafa",
            Age = 37,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 93035,
            YearsOfService = 9,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 65178,
            Name = "Masako Takahashi",
            Age = 42,
            JobTitle = "Technical Principal",
            Department = "Support",
            ManagerId = 12610,
            YearsOfService = 9,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 21639,
            Name = "Maryann Bresner",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 35920,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 35776,
            Name = "Marya Holcroft",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 64989,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 10405,
            Name = "Mark Jackson",
            Age = 45,
            JobTitle = "Delivery Lead",
            Department = "Consulting",
            ManagerId = 23975,
            YearsOfService = 9,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 75187,
            Name = "Marinna Wodeland",
            Age = 28,
            JobTitle = "Receptionist",
            Department = "Office Management",
            ManagerId = 56808,
            YearsOfService = 5,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 86772,
            Name = "Mariele Pegram",
            Age = 37,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 33330,
            YearsOfService = 9,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 48545,
            Name = "Mariele Monnelly",
            Age = 35,
            JobTitle = "Director",
            Department = "Design",
            ManagerId = 51708,
            YearsOfService = 7,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 30713,
            Name = "Marian Augustin",
            Age = 29,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 55608,
            YearsOfService = 7,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 63680,
            Name = "Margot Booth",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 10415,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 71168,
            Name = "Margaret Woolford",
            Age = 45,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 90874,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 26670,
            Name = "Manolo Wheelan",
            Age = 37,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 62874,
            YearsOfService = 5,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 44455,
            Name = "Manish Tara",
            Age = 21,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 68418,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 61575,
            Name = "Mangjeol Haru",
            Age = 36,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 27225,
            YearsOfService = 10,
            PayBand = 6,
            OnLeave = 1
        },
        new()
        {
            Id = 99069,
            Name = "Maksim Gusev",
            Age = 25,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 15711,
            YearsOfService = 3,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 71045,
            Name = "Maki Okada",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 86772,
            YearsOfService = 4,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 93142,
            Name = "Magdalena Jakubovics",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 79919,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 12459,
            Name = "Maddie Simons",
            Age = 25,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 59591,
            YearsOfService = 6,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 22570,
            Name = "Macey Christie",
            Age = 31,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 25852,
            YearsOfService = 6,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 23776,
            Name = "Lucian Hamshar",
            Age = 48,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 45663,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 89317,
            Name = "Lottie Hargrave",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 33676,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 92963,
            Name = "Loretta McDowell",
            Age = 28,
            JobTitle = "Technology Architect",
            Department = "Consulting",
            ManagerId = 10405,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 46072,
            Name = "Lonnie Sumnall",
            Age = 50,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 45663,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 57659,
            Name = "Lok Tsai",
            Age = 24,
            JobTitle = "Technology Architect",
            Department = "Delivery",
            ManagerId = 69601,
            YearsOfService = 3,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 44697,
            Name = "Lidya Nasih",
            Age = 35,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 54178,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 57793,
            Name = "Li Meng",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 41701,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 43518,
            Name = "Leroy Lamb",
            Age = 44,
            JobTitle = "Finance Director",
            Department = "Finance",
            ManagerId = null,
            YearsOfService = 10,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 75083,
            Name = "Leonard Whitewood",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 48107,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 56808,
            Name = "Leon Voronov",
            Age = 41,
            JobTitle = "Office Manager",
            Department = "Office Management",
            ManagerId = 51708,
            YearsOfService = 10,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 15367,
            Name = "Lei Shirong",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 47174,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 87299,
            Name = "Layla Snowding",
            Age = 28,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 42203,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 72606,
            Name = "Lawrence Kao",
            Age = 47,
            JobTitle = "Technical Lead",
            Department = "Support",
            ManagerId = 59591,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 49418,
            Name = "Larissa Larson",
            Age = 39,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 87299,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 93679,
            Name = "Kyler Luther",
            Age = 40,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 71666,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 1
        },
        new()
        {
            Id = 23736,
            Name = "Kristi Pattillo",
            Age = 22,
            JobTitle = "HR Administrator",
            Department = "HR",
            ManagerId = 73580,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 45726,
            Name = "Kris Conachie",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 41548,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 35811,
            Name = "Klara Nowak",
            Age = 25,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 47967,
            YearsOfService = 5,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 67933,
            Name = "Kirstin Cliff",
            Age = 49,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 43169,
            YearsOfService = 9,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 58721,
            Name = "Kingsley Pateman",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 26637,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 60124,
            Name = "Kerri Perryman",
            Age = 53,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 82068,
            YearsOfService = 6,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 84599,
            Name = "Kendall Becker",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 96663,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 89407,
            Name = "Kearney Weippert",
            Age = 27,
            JobTitle = "Finance Assistant",
            Department = "Finance",
            ManagerId = 39362,
            YearsOfService = 6,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 45521,
            Name = "Kayin Owayale",
            Age = 50,
            JobTitle = "Director",
            Department = "Delivery",
            ManagerId = 51708,
            YearsOfService = 8,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 42203,
            Name = "Kasia Lennon",
            Age = 43,
            JobTitle = "Senior Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 9,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 69712,
            Name = "Karolina Dudek",
            Age = 27,
            JobTitle = "Content Designer",
            Department = "Marketing",
            ManagerId = 84047,
            YearsOfService = 5,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 84981,
            Name = "Karlie Bartelli",
            Age = 25,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 62874,
            YearsOfService = 7,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 38567,
            Name = "Karimah Atiyeh",
            Age = 37,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 71666,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 41342,
            Name = "Karim Brumfitt",
            Age = 42,
            JobTitle = "Senior Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 30934,
            Name = "Karen Romero",
            Age = 53,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 54184,
            YearsOfService = 9,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 72146,
            Name = "Kamila Aslakhanov",
            Age = 37,
            JobTitle = "Delivery Lead",
            Department = "Support",
            ManagerId = 32376,
            YearsOfService = 5,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 50683,
            Name = "Kamala Sagar",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 98817,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 49009,
            Name = "Justin Fairbank",
            Age = 26,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 41824,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 15584,
            Name = "Junpei Takayama",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 23300,
            YearsOfService = 5,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 33676,
            Name = "Jun Hou",
            Age = 40,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 53555,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 53479,
            Name = "Julita Kucharska",
            Age = 41,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 67176,
            YearsOfService = 5,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 72223,
            Name = "Julie Lee",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 72606,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 52006,
            Name = "Joshua Tuddall",
            Age = 21,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 71666,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 73126,
            Name = "Joelle Donaghy",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 23451,
            YearsOfService = 4,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 51168,
            Name = "Joe Smith",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 53479,
            YearsOfService = 4,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 30918,
            Name = "Jobina Badrick",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 87299,
            YearsOfService = 3,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 62660,
            Name = "Jie Tsao",
            Age = 28,
            JobTitle = "Senior Delivery Lead",
            Department = "Delivery",
            ManagerId = 46827,
            YearsOfService = 7,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 59591,
            Name = "Jenete Ibekwe",
            Age = 49,
            JobTitle = "Senior Technical Lead",
            Department = "Support",
            ManagerId = 65178,
            YearsOfService = 7,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 86362,
            Name = "Jemmie Edmonds",
            Age = 34,
            JobTitle = "Management Accountant",
            Department = "Finance",
            ManagerId = 43518,
            YearsOfService = 4,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 83752,
            Name = "Jawed Dar",
            Age = 31,
            JobTitle = "Delivery Lead",
            Department = "Support",
            ManagerId = 66994,
            YearsOfService = 6,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 51708,
            Name = "Jasmine Harding",
            Age = 51,
            JobTitle = "Managing Director",
            Department = null,
            ManagerId = null,
            YearsOfService = 1,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 30004,
            Name = "James Hall",
            Age = 24,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 57415,
            YearsOfService = 5,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 86955,
            Name = "Jamba Adeoye",
            Age = 27,
            JobTitle = "Receptionist",
            Department = "Office Management",
            ManagerId = 56808,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 19348,
            Name = "Jade Harding",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 83752,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 18810,
            Name = "Jackson Wilkinson",
            Age = 40,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 59591,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 49100,
            Name = "Iva Parkin",
            Age = 40,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 59009,
            YearsOfService = 8,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 54956,
            Name = "Isandro Danon",
            Age = 25,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 54178,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 87095,
            Name = "Isaiah Madron",
            Age = 42,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 33330,
            YearsOfService = 10,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 35920,
            Name = "Isaiah Little",
            Age = 32,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 60124,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 24592,
            Name = "Inessa Williamson",
            Age = 33,
            JobTitle = "Senior Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 5,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 65603,
            Name = "Indira Toor",
            Age = 21,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 35920,
            YearsOfService = 3,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 48950,
            Name = "Iheoma Belonwu",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 25088,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 68162,
            Name = "Idowu Adebayo",
            Age = 37,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 68615,
            YearsOfService = 1,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 26543,
            Name = "Ida Pachmann",
            Age = 38,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 18114,
            YearsOfService = 6,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 71609,
            Name = "Hugh Runnett",
            Age = 40,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 46827,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 66994,
            Name = "Huberto Arondel",
            Age = 54,
            JobTitle = "Delivery Principal",
            Department = "Support",
            ManagerId = 12610,
            YearsOfService = 8,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 24406,
            Name = "Huan Hu",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 71609,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 31138,
            Name = "Hsin Sun",
            Age = 36,
            JobTitle = "Technical Lead",
            Department = "Support",
            ManagerId = 65178,
            YearsOfService = 9,
            PayBand = 8,
            OnLeave = 1
        },
        new()
        {
            Id = 40293,
            Name = "Hortense Martel",
            Age = 21,
            JobTitle = "Business Analyst",
            Department = "Delivery",
            ManagerId = 22570,
            YearsOfService = 1,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 49239,
            Name = "Hong Yao",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 89037,
            YearsOfService = 4,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 38537,
            Name = "Hillary Walster",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 85098,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 29648,
            Name = "Hildy Warricker",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 54178,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 85571,
            Name = "Hideki Saito",
            Age = 44,
            JobTitle = "Senior Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 6,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 50053,
            Name = "Herrick Hazel",
            Age = 38,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 43169,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 1
        },
        new()
        {
            Id = 12095,
            Name = "Helia Rivera",
            Age = 44,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 65470,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 27555,
            Name = "Heidi Jennings",
            Age = 37,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 37773,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 87031,
            Name = "Heida Dowthwaite",
            Age = 27,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 59009,
            YearsOfService = 5,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 90874,
            Name = "Haze Vanyukov",
            Age = 31,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 10,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 64989,
            Name = "Hassan Rosado",
            Age = 47,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 20630,
            YearsOfService = 5,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 27225,
            Name = "Hanna Wozniak",
            Age = 43,
            JobTitle = "Senior Technical Lead",
            Department = "Support",
            ManagerId = 65178,
            YearsOfService = 9,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 36198,
            Name = "Hamood Machi",
            Age = 41,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 20630,
            YearsOfService = 5,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 98817,
            Name = "Hamlin Camilletti",
            Age = 38,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 12445,
            YearsOfService = 5,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 38179,
            Name = "Hamisi Akunyili",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 17018,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 41824,
            Name = "Haiya Mohan",
            Age = 41,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 30934,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 33330,
            Name = "Hadrienne Labelle",
            Age = 36,
            JobTitle = "Technical Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 7,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 26534,
            Name = "Habibah Amari",
            Age = 29,
            JobTitle = "HR Advisor",
            Department = "HR",
            ManagerId = 73580,
            YearsOfService = 9,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 99521,
            Name = "Gwan Min Ki",
            Age = 29,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 17018,
            YearsOfService = 8,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 46850,
            Name = "Gustaw Zawadski",
            Age = 29,
            JobTitle = "Technical Lead",
            Department = "Support",
            ManagerId = 61328,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 49034,
            Name = "Guanyin Liang",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 16111,
            YearsOfService = 0,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 57699,
            Name = "Greta Biasini",
            Age = 27,
            JobTitle = "Senior UX Designer",
            Department = "Design",
            ManagerId = 90767,
            YearsOfService = 3,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 69969,
            Name = "Grace Di Nisco",
            Age = 31,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 46827,
            YearsOfService = 7,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 82329,
            Name = "Goldina Timpany",
            Age = 38,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 21687,
            YearsOfService = 2,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 38481,
            Name = "Glynnis McGahern",
            Age = 36,
            JobTitle = "Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 45519,
            Name = "Glaw Davies",
            Age = 36,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 88600,
            YearsOfService = 1,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 74047,
            Name = "Ginevra Burless",
            Age = 38,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 73444,
            YearsOfService = 3,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 62085,
            Name = "Gim Mishil",
            Age = 34,
            JobTitle = "IT Manager",
            Department = "IT",
            ManagerId = 35800,
            YearsOfService = 10,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 60487,
            Name = "Gilberta Donohue",
            Age = 39,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 84782,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 77224,
            Name = "Georgina McKenzie",
            Age = 37,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 80470,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 11024,
            Name = "Garwood Attridge",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 66133,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 12291,
            Name = "Garrett Mersh",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 43487,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 15543,
            Name = "Gareth Newton",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 36752,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 56282,
            Name = "Florry Sandle",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 46072,
            YearsOfService = 5,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 82068,
            Name = "Feng Mai",
            Age = 37,
            JobTitle = "Technical Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 9,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 69601,
            Name = "Fen Chao",
            Age = 35,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 43228,
            YearsOfService = 9,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 38634,
            Name = "Felix Varah",
            Age = 33,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 27555,
            YearsOfService = 8,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 17018,
            Name = "Fabien Vials",
            Age = 43,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 33330,
            YearsOfService = 6,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 21447,
            Name = "Eveline Blanchar",
            Age = 46,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 53555,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 15228,
            Name = "Eustace Wanell",
            Age = 29,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 87299,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 35605,
            Name = "Estefania Orozco",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 10405,
            YearsOfService = 0,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 65470,
            Name = "Esme Simon",
            Age = 48,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 82068,
            YearsOfService = 8,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 72686,
            Name = "Enrica Widdowfield",
            Age = 34,
            JobTitle = "Senior Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 6,
            PayBand = 7,
            OnLeave = 1
        },
        new()
        {
            Id = 41685,
            Name = "Eniola Micheal",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 31138,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 65176,
            Name = "Emmi Vanhalla",
            Age = 36,
            JobTitle = "Senior Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 6,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 61948,
            Name = "Emera Harker",
            Age = 23,
            JobTitle = "Content Designer",
            Department = "Marketing",
            ManagerId = 84047,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 85010,
            Name = "Elsie Hartley",
            Age = 40,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 41548,
            YearsOfService = 8,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 13798,
            Name = "Eloise Beeson",
            Age = 28,
            JobTitle = "Accounts Assistant",
            Department = "Finance",
            ManagerId = 86362,
            YearsOfService = 4,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 40035,
            Name = "Ella Cooper",
            Age = 23,
            JobTitle = "Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 2,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 86208,
            Name = "Elizabeth Malone",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 62874,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 91855,
            Name = "Elfreda Burt",
            Age = 41,
            JobTitle = "Director",
            Department = "Consulting",
            ManagerId = 51708,
            YearsOfService = 6,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 68418,
            Name = "Elena Adams",
            Age = 36,
            JobTitle = "Senior UX Designer",
            Department = "Design",
            ManagerId = 90767,
            YearsOfService = 6,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 32225,
            Name = "Edric Ocalan",
            Age = 20,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 21687,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 1
        },
        new()
        {
            Id = 49856,
            Name = "Edeline Petrina",
            Age = 31,
            JobTitle = "Performance Analyst",
            Department = "Delivery",
            ManagerId = 69969,
            YearsOfService = 4,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 21872,
            Name = "Eba Strand",
            Age = 39,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 93035,
            YearsOfService = 4,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 67176,
            Name = "Duke Gudgen",
            Age = 49,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 4,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 85098,
            Name = "Dorry Filipic",
            Age = 37,
            JobTitle = "Delivery Lead",
            Department = "Consulting",
            ManagerId = 23975,
            YearsOfService = 4,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 15711,
            Name = "Devonne Luckhurst",
            Age = 38,
            JobTitle = "Technical Lead",
            Department = "Support",
            ManagerId = 65178,
            YearsOfService = 10,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 60100,
            Name = "Devlin Nicholls",
            Age = 34,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 57699,
            YearsOfService = 8,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 48434,
            Name = "Devina Linwood",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 41548,
            YearsOfService = 5,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 25088,
            Name = "Devin Shurey",
            Age = 43,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 90874,
            YearsOfService = 4,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 94901,
            Name = "Devika Thaman",
            Age = 40,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 5,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 71441,
            Name = "Delshad Turabi",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 22570,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 87597,
            Name = "Dean Blumson",
            Age = 34,
            JobTitle = "Business Development Manager",
            Department = "Sales",
            ManagerId = 85548,
            YearsOfService = 6,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 49333,
            Name = "David Taylor",
            Age = 47,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 87095,
            YearsOfService = 4,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 51983,
            Name = "Davar Rahmanzai",
            Age = 30,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 31138,
            YearsOfService = 8,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 87815,
            Name = "Daryle Bhatia",
            Age = 35,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 61328,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 22143,
            Name = "Daphne Bishop",
            Age = 21,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 68615,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 24194,
            Name = "Dan Chiu",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 57415,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 22514,
            Name = "Dalton Cleft",
            Age = 27,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 61328,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 74567,
            Name = "Courtenay Potten",
            Age = 33,
            JobTitle = "Office Administrator",
            Department = "Office Management",
            ManagerId = 56808,
            YearsOfService = 4,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 89000,
            Name = "Corine Fay",
            Age = 36,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 72606,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 26771,
            Name = "Conrad McGill",
            Age = 29,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 85571,
            YearsOfService = 5,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 38174,
            Name = "Conan Sinclair",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 68615,
            YearsOfService = 3,
            PayBand = 1,
            OnLeave = 1
        },
        new()
        {
            Id = 54184,
            Name = "Cindra Murrells",
            Age = 42,
            JobTitle = "Technical Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 10,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 21687,
            Name = "Christelle Charron",
            Age = 42,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 43169,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 23451,
            Name = "Christabel Parnell",
            Age = 40,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 47967,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 63064,
            Name = "Chigozie Dilibe",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 16111,
            YearsOfService = 5,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 37360,
            Name = "Chiebuka Nebechi",
            Age = 21,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 27555,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 99018,
            Name = "Cherilynn Watkins",
            Age = 36,
            JobTitle = "Senior Software Developer",
            Department = "Support",
            ManagerId = 15421,
            YearsOfService = 5,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 44287,
            Name = "Charis Petracchi",
            Age = 35,
            JobTitle = "Technical Principal",
            Department = "Consulting",
            ManagerId = 91855,
            YearsOfService = 10,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 81496,
            Name = "Ceri Bellis",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 89037,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 62564,
            Name = "Celestine Pennetta",
            Age = 32,
            JobTitle = "Legal Director",
            Department = "Legal",
            ManagerId = null,
            YearsOfService = 9,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 42775,
            Name = "Celestina Schober",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 86665,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 39570,
            Name = "Carol Berrisford",
            Age = 20,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 36752,
            YearsOfService = 2,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 89954,
            Name = "Carly Lei",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 69601,
            YearsOfService = 3,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 86299,
            Name = "Carlo Doherty",
            Age = 24,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 26637,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 10838,
            Name = "Carla Weber",
            Age = 25,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 42203,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 73444,
            Name = "Carl Russell",
            Age = 41,
            JobTitle = "Senior Technical Lead",
            Department = "Delivery",
            ManagerId = 33330,
            YearsOfService = 10,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 15328,
            Name = "Camille Craighall",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 20453,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 79790,
            Name = "Caitrin Bartolomeu",
            Age = 20,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 55608,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 61098,
            Name = "Bryn Cecil",
            Age = 42,
            JobTitle = "Senior Designer",
            Department = "Design",
            ManagerId = 55608,
            YearsOfService = 8,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 17551,
            Name = "Brana Josefs",
            Age = 28,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 88600,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 43228,
            Name = "Braith Llewelyn",
            Age = 45,
            JobTitle = "Delivery Principal",
            Department = "Delivery",
            ManagerId = 45521,
            YearsOfService = 10,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 93402,
            Name = "Bobby Vize",
            Age = 30,
            JobTitle = "Finance Assistant",
            Department = "Finance",
            ManagerId = 39362,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 35800,
            Name = "Bernardita Pedrosa",
            Age = 36,
            JobTitle = "Director",
            Department = "IT",
            ManagerId = null,
            YearsOfService = 8,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 10788,
            Name = "Benoit Durant",
            Age = 29,
            JobTitle = "Marketing Director",
            Department = "Marketing",
            ManagerId = null,
            YearsOfService = 9,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 84782,
            Name = "Belinda Feldt",
            Age = 29,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 20630,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 82445,
            Name = "Basheera Kouri",
            Age = 23,
            JobTitle = "HR Advisor",
            Department = "HR",
            ManagerId = 68291,
            YearsOfService = 2,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 84023,
            Name = "Barton Varren",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 15711,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 39363,
            Name = "Barbette Cutridge",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 91620,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 73778,
            Name = "Barbara Cresswell",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 15711,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 84379,
            Name = "Awni Ashkani",
            Age = 22,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 35920,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 42464,
            Name = "Audrie Rosgen",
            Age = 27,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 56390,
            YearsOfService = 5,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 72137,
            Name = "Audrey Alessandrini",
            Age = 31,
            JobTitle = "Senior Delivery Lead",
            Department = "Delivery",
            ManagerId = 80470,
            YearsOfService = 8,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 32835,
            Name = "Audie Osborne",
            Age = 39,
            JobTitle = "Technical Consultant",
            Department = "Delivery",
            ManagerId = 88390,
            YearsOfService = 6,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 91237,
            Name = "Astor Blau",
            Age = 21,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 56390,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 33873,
            Name = "Arthur Olatunji",
            Age = 35,
            JobTitle = "Business Development Manager",
            Department = "Sales",
            ManagerId = 85548,
            YearsOfService = 8,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 18114,
            Name = "Artan Sayyid",
            Age = 44,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 65470,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 94015,
            Name = "April Scay",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 59009,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 40899,
            Name = "Aoife Allington",
            Age = 26,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 47174,
            YearsOfService = 4,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 46973,
            Name = "Anushka Dmitrieva",
            Age = 35,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 12445,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 71666,
            Name = "Antonia Rosgen",
            Age = 38,
            JobTitle = "Design Principal",
            Department = "Design",
            ManagerId = 48545,
            YearsOfService = 8,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 94389,
            Name = "Annie Jones",
            Age = 31,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 43228,
            YearsOfService = 10,
            PayBand = 8,
            OnLeave = 1
        },
        new()
        {
            Id = 88390,
            Name = "Angelle Joyce",
            Age = 42,
            JobTitle = "Lead Technical Consultant",
            Department = "Consulting",
            ManagerId = 91855,
            YearsOfService = 8,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 62470,
            Name = "Andrew Robinson",
            Age = 30,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 40978,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 10883,
            Name = "Andras Lewerenz",
            Age = 39,
            JobTitle = "Business Analyst",
            Department = "Consulting",
            ManagerId = 85098,
            YearsOfService = 8,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 41548,
            Name = "Anastasia Cocozza",
            Age = 39,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 82068,
            YearsOfService = 3,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 66133,
            Name = "Amit Seshadri",
            Age = 28,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 53555,
            YearsOfService = 6,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 13829,
            Name = "Amala Sachs",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 94389,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 91468,
            Name = "Alvinia Whannel",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 50053,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 36752,
            Name = "Alistair Thompson",
            Age = 37,
            JobTitle = "Technical Lead",
            Department = "Support",
            ManagerId = 15421,
            YearsOfService = 5,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 14158,
            Name = "Alisha Srivastava",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 18114,
            YearsOfService = 3,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 63854,
            Name = "Alexander Crowcombe",
            Age = 22,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 12712,
            YearsOfService = 4,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 60208,
            Name = "Alex Harris",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 27466,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 30834,
            Name = "Alex Fletcher",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 71168,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 41767,
            Name = "Alex Ambrogetti",
            Age = 45,
            JobTitle = "Lead Technical Consultant",
            Department = "Consulting",
            ManagerId = 91855,
            YearsOfService = 10,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 66826,
            Name = "Alberto Felix",
            Age = 30,
            JobTitle = "Delivery Lead",
            Department = "Delivery",
            ManagerId = 67176,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 40908,
            Name = "Alain Fanthome",
            Age = 32,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 66133,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 89037,
            Name = "Aishwarya Mukherjee",
            Age = 46,
            JobTitle = "Technical Lead",
            Department = "Delivery",
            ManagerId = 82068,
            YearsOfService = 10,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 73079,
            Name = "Advik Chadha",
            Age = 35,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 87095,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 28373,
            Name = "Adrienne Villeneuve",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 20453,
            YearsOfService = 5,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 65502,
            Name = "Adria Gascard",
            Age = 30,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 41824,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 90767,
            Name = "Adena Aitchinson",
            Age = 44,
            JobTitle = "Lead UX Designer",
            Department = "Design",
            ManagerId = 48545,
            YearsOfService = 10,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 41701,
            Name = "Adebola Oyinlola",
            Age = 39,
            JobTitle = "Senior Software Developer",
            Department = "Delivery",
            ManagerId = 37773,
            YearsOfService = 8,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 30040,
            Name = "Adala Stauss",
            Age = 39,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 46850,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 47174,
            Name = "Abioye Emmanuel",
            Age = 44,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 85571,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        }
    };

    public static readonly List<Employee> AllEmployeesInConsultingDeparment = new()
    {
        new()
        {
            Id = 10405,
            Name = "Mark Jackson",
            Age = 45,
            JobTitle = "Delivery Lead",
            Department = "Consulting",
            ManagerId = 23975,
            YearsOfService = 9,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 10838,
            Name = "Carla Weber",
            Age = 25,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 42203,
            YearsOfService = 7,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 10883,
            Name = "Andras Lewerenz",
            Age = 39,
            JobTitle = "Business Analyst",
            Department = "Consulting",
            ManagerId = 85098,
            YearsOfService = 8,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 12442,
            Name = "Paige Bloomfield",
            Age = 37,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 47174,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 15228,
            Name = "Eustace Wanell",
            Age = 29,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 87299,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 15367,
            Name = "Lei Shirong",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 47174,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 16215,
            Name = "Veda Cartledge",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 94901,
            YearsOfService = 0,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 17551,
            Name = "Brana Josefs",
            Age = 28,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 88600,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 18682,
            Name = "Ned Farmer",
            Age = 27,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 84782,
            YearsOfService = 4,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 20630,
            Name = "Thomas Edwards",
            Age = 37,
            JobTitle = "Senior Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 8,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 23975,
            Name = "Rani Prabhu",
            Age = 42,
            JobTitle = "Delivery Principal",
            Department = "Consulting",
            ManagerId = 91855,
            YearsOfService = 9,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 24592,
            Name = "Inessa Williamson",
            Age = 33,
            JobTitle = "Senior Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 5,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 26771,
            Name = "Conrad McGill",
            Age = 29,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 85571,
            YearsOfService = 5,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 27117,
            Name = "Sally Nash",
            Age = 46,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 85571,
            YearsOfService = 10,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 28478,
            Name = "Tariq Qadiri",
            Age = 34,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 94901,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 29648,
            Name = "Hildy Warricker",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 54178,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 30918,
            Name = "Jobina Badrick",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 87299,
            YearsOfService = 3,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 33797,
            Name = "Olayinka Isiaka",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 84782,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 35432,
            Name = "Victoria Brown",
            Age = 29,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 42203,
            YearsOfService = 3,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 35605,
            Name = "Estefania Orozco",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 10405,
            YearsOfService = 0,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 36198,
            Name = "Hamood Machi",
            Age = 41,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 20630,
            YearsOfService = 5,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 38481,
            Name = "Glynnis McGahern",
            Age = 36,
            JobTitle = "Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 38537,
            Name = "Hillary Walster",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 85098,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 39741,
            Name = "Sawyer Thowes",
            Age = 32,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 65176,
            YearsOfService = 8,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 40035,
            Name = "Ella Cooper",
            Age = 23,
            JobTitle = "Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 2,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 40899,
            Name = "Aoife Allington",
            Age = 26,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 47174,
            YearsOfService = 4,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 41342,
            Name = "Karim Brumfitt",
            Age = 42,
            JobTitle = "Senior Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 41767,
            Name = "Alex Ambrogetti",
            Age = 45,
            JobTitle = "Lead Technical Consultant",
            Department = "Consulting",
            ManagerId = 91855,
            YearsOfService = 10,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 42203,
            Name = "Kasia Lennon",
            Age = 43,
            JobTitle = "Senior Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 9,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 44287,
            Name = "Charis Petracchi",
            Age = 35,
            JobTitle = "Technical Principal",
            Department = "Consulting",
            ManagerId = 91855,
            YearsOfService = 10,
            PayBand = 11,
            OnLeave = 0
        },
        new()
        {
            Id = 44697,
            Name = "Lidya Nasih",
            Age = 35,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 54178,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 45519,
            Name = "Glaw Davies",
            Age = 36,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 88600,
            YearsOfService = 1,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 47174,
            Name = "Abioye Emmanuel",
            Age = 44,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 85571,
            YearsOfService = 4,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 48747,
            Name = "Usman Shah",
            Age = 33,
            JobTitle = "Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 6,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 49418,
            Name = "Larissa Larson",
            Age = 39,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 87299,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 54178,
            Name = "Nona O'Neill",
            Age = 49,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 10,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 54956,
            Name = "Isandro Danon",
            Age = 25,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 54178,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 57666,
            Name = "Shaun Braun",
            Age = 34,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 94901,
            YearsOfService = 4,
            PayBand = 5,
            OnLeave = 0
        },
        new()
        {
            Id = 60487,
            Name = "Gilberta Donohue",
            Age = 39,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 84782,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 64989,
            Name = "Hassan Rosado",
            Age = 47,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 20630,
            YearsOfService = 5,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 65176,
            Name = "Emmi Vanhalla",
            Age = 36,
            JobTitle = "Senior Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 6,
            PayBand = 10,
            OnLeave = 0
        },
        new()
        {
            Id = 68697,
            Name = "Samantha Liao",
            Age = 32,
            JobTitle = "Senior Software Developer",
            Department = "Consulting",
            ManagerId = 65176,
            YearsOfService = 6,
            PayBand = 6,
            OnLeave = 0
        },
        new()
        {
            Id = 72686,
            Name = "Enrica Widdowfield",
            Age = 34,
            JobTitle = "Senior Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 6,
            PayBand = 7,
            OnLeave = 1
        },
        new()
        {
            Id = 84782,
            Name = "Belinda Feldt",
            Age = 29,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 20630,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 85098,
            Name = "Dorry Filipic",
            Age = 37,
            JobTitle = "Delivery Lead",
            Department = "Consulting",
            ManagerId = 23975,
            YearsOfService = 4,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 85571,
            Name = "Hideki Saito",
            Age = 44,
            JobTitle = "Senior Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 6,
            PayBand = 9,
            OnLeave = 0
        },
        new()
        {
            Id = 87299,
            Name = "Layla Snowding",
            Age = 28,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 42203,
            YearsOfService = 9,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 88390,
            Name = "Angelle Joyce",
            Age = 42,
            JobTitle = "Lead Technical Consultant",
            Department = "Consulting",
            ManagerId = 91855,
            YearsOfService = 8,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 88600,
            Name = "Roksana Kaczmarek",
            Age = 42,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 65176,
            YearsOfService = 10,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 90939,
            Name = "Rosita Ortiz",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 88600,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 91855,
            Name = "Elfreda Burt",
            Age = 41,
            JobTitle = "Director",
            Department = "Consulting",
            ManagerId = 51708,
            YearsOfService = 6,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 92963,
            Name = "Loretta McDowell",
            Age = 28,
            JobTitle = "Technology Architect",
            Department = "Consulting",
            ManagerId = 10405,
            YearsOfService = 7,
            PayBand = 7,
            OnLeave = 0
        },
        new()
        {
            Id = 94901,
            Name = "Devika Thaman",
            Age = 40,
            JobTitle = "Technical Lead",
            Department = "Consulting",
            ManagerId = 44287,
            YearsOfService = 5,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 95290,
            Name = "Teniola Adeyemi",
            Age = 24,
            JobTitle = "Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        }
    };
    
    public static readonly List<Employee> AllEmployeesBelowPayBand5 = new()
    {
        new()
        {
            Id = 10370,
            Name = "Paul Davies",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 57415,
            YearsOfService = 5,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 11024,
            Name = "Garwood Attridge",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 66133,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 12291,
            Name = "Garrett Mersh",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 43487,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 12442,
            Name = "Paige Bloomfield",
            Age = 37,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 47174,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 13829,
            Name = "Amala Sachs",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 94389,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 13989,
            Name = "Monah Scarisbrick",
            Age = 39,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 68418,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 14007,
            Name = "Yilma Loharani",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 12712,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 14158,
            Name = "Alisha Srivastava",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 18114,
            YearsOfService = 3,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 15228,
            Name = "Eustace Wanell",
            Age = 29,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 87299,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 15328,
            Name = "Camille Craighall",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 20453,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 15367,
            Name = "Lei Shirong",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 47174,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 15543,
            Name = "Gareth Newton",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 36752,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 15584,
            Name = "Junpei Takayama",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 23300,
            YearsOfService = 5,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 16215,
            Name = "Veda Cartledge",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 94901,
            YearsOfService = 0,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 17551,
            Name = "Brana Josefs",
            Age = 28,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 88600,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 17625,
            Name = "Rubin Petroff",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 86424,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 18682,
            Name = "Ned Farmer",
            Age = 27,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 84782,
            YearsOfService = 4,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 19348,
            Name = "Jade Harding",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 83752,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 21639,
            Name = "Maryann Bresner",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 35920,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 22143,
            Name = "Daphne Bishop",
            Age = 21,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 68615,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 23326,
            Name = "Stefa Padrick",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 21687,
            YearsOfService = 4,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 23736,
            Name = "Kristi Pattillo",
            Age = 22,
            JobTitle = "HR Administrator",
            Department = "HR",
            ManagerId = 73580,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 24194,
            Name = "Dan Chiu",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 57415,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 24314,
            Name = "Mosiya Okonjo",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 69969,
            YearsOfService = 0,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 24406,
            Name = "Huan Hu",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 71609,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 24519,
            Name = "Robert Clarke",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 72146,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 26241,
            Name = "Raquela Fryman",
            Age = 20,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 17018,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 26451,
            Name = "Teresita Evans",
            Age = 27,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 12712,
            YearsOfService = 4,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 26543,
            Name = "Ida Pachmann",
            Age = 38,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 18114,
            YearsOfService = 6,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 26670,
            Name = "Manolo Wheelan",
            Age = 37,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 62874,
            YearsOfService = 5,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 28478,
            Name = "Tariq Qadiri",
            Age = 34,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 94901,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 28515,
            Name = "Maysa Haq",
            Age = 28,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 66133,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 29648,
            Name = "Hildy Warricker",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 54178,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 30004,
            Name = "James Hall",
            Age = 24,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 57415,
            YearsOfService = 5,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 30040,
            Name = "Adala Stauss",
            Age = 39,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 46850,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 30834,
            Name = "Alex Fletcher",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 71168,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 30918,
            Name = "Jobina Badrick",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 87299,
            YearsOfService = 3,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 32185,
            Name = "Susan Harris",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 12459,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 32225,
            Name = "Edric Ocalan",
            Age = 20,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 21687,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 1
        },
        new()
        {
            Id = 32835,
            Name = "Audie Osborne",
            Age = 39,
            JobTitle = "Technical Consultant",
            Department = "Delivery",
            ManagerId = 88390,
            YearsOfService = 6,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 33337,
            Name = "Sheila Rubertis",
            Age = 30,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 89037,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 33797,
            Name = "Olayinka Isiaka",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 84782,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 34751,
            Name = "Zahidah Said",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 26771,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 35605,
            Name = "Estefania Orozco",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 10405,
            YearsOfService = 0,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 35776,
            Name = "Marya Holcroft",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 64989,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 37360,
            Name = "Chiebuka Nebechi",
            Age = 21,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 27555,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 37585,
            Name = "Zhen Wei",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 42769,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 37599,
            Name = "Ulric Josskovitz",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 46850,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 38174,
            Name = "Conan Sinclair",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 68615,
            YearsOfService = 3,
            PayBand = 1,
            OnLeave = 1
        },
        new()
        {
            Id = 38179,
            Name = "Hamisi Akunyili",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 17018,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 38481,
            Name = "Glynnis McGahern",
            Age = 36,
            JobTitle = "Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 38537,
            Name = "Hillary Walster",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 85098,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 38567,
            Name = "Karimah Atiyeh",
            Age = 37,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 71666,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 38634,
            Name = "Felix Varah",
            Age = 33,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 27555,
            YearsOfService = 8,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 39363,
            Name = "Barbette Cutridge",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 91620,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 40908,
            Name = "Alain Fanthome",
            Age = 32,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 66133,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 41685,
            Name = "Eniola Micheal",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 31138,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 42464,
            Name = "Audrie Rosgen",
            Age = 27,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 56390,
            YearsOfService = 5,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 42775,
            Name = "Celestina Schober",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 86665,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 44455,
            Name = "Manish Tara",
            Age = 21,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 68418,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 44697,
            Name = "Lidya Nasih",
            Age = 35,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 54178,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 45726,
            Name = "Kris Conachie",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 41548,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 46357,
            Name = "Rajesh Pai",
            Age = 30,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 35118,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 47808,
            Name = "Raghav Merchant",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 77224,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 48950,
            Name = "Iheoma Belonwu",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 25088,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 49009,
            Name = "Justin Fairbank",
            Age = 26,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 41824,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 49034,
            Name = "Guanyin Liang",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 16111,
            YearsOfService = 0,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 49418,
            Name = "Larissa Larson",
            Age = 39,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 87299,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 49508,
            Name = "Patrick French",
            Age = 24,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 26637,
            YearsOfService = 6,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 50683,
            Name = "Kamala Sagar",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 98817,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 51168,
            Name = "Joe Smith",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 53479,
            YearsOfService = 4,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 52006,
            Name = "Joshua Tuddall",
            Age = 21,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 71666,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 54805,
            Name = "Yvonne O'Donovan",
            Age = 37,
            JobTitle = "Office Administrator",
            Department = "Office Management",
            ManagerId = 56808,
            YearsOfService = 9,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 54956,
            Name = "Isandro Danon",
            Age = 25,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 54178,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 56141,
            Name = "Namrata Kumer",
            Age = 27,
            JobTitle = "Legal Administrator",
            Department = "Legal",
            ManagerId = 61062,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 56282,
            Name = "Florry Sandle",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 46072,
            YearsOfService = 5,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 57793,
            Name = "Li Meng",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 41701,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 58721,
            Name = "Kingsley Pateman",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 26637,
            YearsOfService = 3,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 60208,
            Name = "Alex Harris",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 27466,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 60487,
            Name = "Gilberta Donohue",
            Age = 39,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 84782,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 61948,
            Name = "Emera Harker",
            Age = 23,
            JobTitle = "Content Designer",
            Department = "Marketing",
            ManagerId = 84047,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 62470,
            Name = "Andrew Robinson",
            Age = 30,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 40978,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 63680,
            Name = "Margot Booth",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 10415,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 63854,
            Name = "Alexander Crowcombe",
            Age = 22,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 12712,
            YearsOfService = 4,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 65502,
            Name = "Adria Gascard",
            Age = 30,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 41824,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 66478,
            Name = "Oluwasola Akintola",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 46973,
            YearsOfService = 5,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 69790,
            Name = "Viola Shelton",
            Age = 25,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 18114,
            YearsOfService = 6,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 70188,
            Name = "Meike Krantz",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 23776,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 71045,
            Name = "Maki Okada",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 86772,
            YearsOfService = 4,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 71441,
            Name = "Delshad Turabi",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 22570,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 72223,
            Name = "Julie Lee",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 72606,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 73126,
            Name = "Joelle Donaghy",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 23451,
            YearsOfService = 4,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 73778,
            Name = "Barbara Cresswell",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 15711,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 74567,
            Name = "Courtenay Potten",
            Age = 33,
            JobTitle = "Office Administrator",
            Department = "Office Management",
            ManagerId = 56808,
            YearsOfService = 4,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 74745,
            Name = "Selim Uyanik",
            Age = 28,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 16111,
            YearsOfService = 6,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 75083,
            Name = "Leonard Whitewood",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 48107,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 75187,
            Name = "Marinna Wodeland",
            Age = 28,
            JobTitle = "Receptionist",
            Department = "Office Management",
            ManagerId = 56808,
            YearsOfService = 5,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 76576,
            Name = "Tadao Asai",
            Age = 31,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 72606,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 79790,
            Name = "Caitrin Bartolomeu",
            Age = 20,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 55608,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 81496,
            Name = "Ceri Bellis",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 89037,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 84023,
            Name = "Barton Varren",
            Age = 23,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 15711,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 84379,
            Name = "Awni Ashkani",
            Age = 22,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 35920,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 84599,
            Name = "Kendall Becker",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 96663,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 85010,
            Name = "Elsie Hartley",
            Age = 40,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 41548,
            YearsOfService = 8,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 86208,
            Name = "Elizabeth Malone",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 62874,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 86299,
            Name = "Carlo Doherty",
            Age = 24,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 26637,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 86955,
            Name = "Jamba Adeoye",
            Age = 27,
            JobTitle = "Receptionist",
            Department = "Office Management",
            ManagerId = 56808,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 88152,
            Name = "Nile Giles",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 12095,
            YearsOfService = 0,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 89000,
            Name = "Corine Fay",
            Age = 36,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 72606,
            YearsOfService = 7,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 89317,
            Name = "Lottie Hargrave",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 33676,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 89333,
            Name = "Sid Murtagh",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 57197,
            YearsOfService = 5,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 89954,
            Name = "Carly Lei",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 69601,
            YearsOfService = 3,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 90548,
            Name = "Nile Awate",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 87815,
            YearsOfService = 3,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 90939,
            Name = "Rosita Ortiz",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 88600,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 91237,
            Name = "Astor Blau",
            Age = 21,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 56390,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 91468,
            Name = "Alvinia Whannel",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 50053,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 91810,
            Name = "Rosalina Lozada",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 66826,
            YearsOfService = 4,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 93027,
            Name = "Sam Owolabi",
            Age = 38,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 35118,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 93142,
            Name = "Magdalena Jakubovics",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 79919,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 93402,
            Name = "Bobby Vize",
            Age = 30,
            JobTitle = "Finance Assistant",
            Department = "Finance",
            ManagerId = 39362,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 93424,
            Name = "Vimal Sundaram",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 27555,
            YearsOfService = 5,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 93679,
            Name = "Kyler Luther",
            Age = 40,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 71666,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 1
        },
        new()
        {
            Id = 94015,
            Name = "April Scay",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 59009,
            YearsOfService = 4,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 95290,
            Name = "Teniola Adeyemi",
            Age = 24,
            JobTitle = "Technical Consultant",
            Department = "Consulting",
            ManagerId = 41767,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 97382,
            Name = "Tito Hargrove",
            Age = 25,
            JobTitle = "UI Designer",
            Department = "Design",
            ManagerId = 57699,
            YearsOfService = 3,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 99521,
            Name = "Gwan Min Ki",
            Age = 29,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 17018,
            YearsOfService = 8,
            PayBand = 4,
            OnLeave = 0
        }
    };

    public static readonly List<Employee> AllEmployeesBelowPayBand5AndWithLessThan3YearsOfService = new()
    {
        new()
        {
            Id = 11024,
            Name = "Garwood Attridge",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 66133,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 12291,
            Name = "Garrett Mersh",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 43487,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 13829,
            Name = "Amala Sachs",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 94389,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 13989,
            Name = "Monah Scarisbrick",
            Age = 39,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 68418,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 14007,
            Name = "Yilma Loharani",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 12712,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 15228,
            Name = "Eustace Wanell",
            Age = 29,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 87299,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 15367,
            Name = "Lei Shirong",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 47174,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 15543,
            Name = "Gareth Newton",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 36752,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 16215,
            Name = "Veda Cartledge",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 94901,
            YearsOfService = 0,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 21639,
            Name = "Maryann Bresner",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 35920,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 22143,
            Name = "Daphne Bishop",
            Age = 21,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 68615,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 23736,
            Name = "Kristi Pattillo",
            Age = 22,
            JobTitle = "HR Administrator",
            Department = "HR",
            ManagerId = 73580,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 24194,
            Name = "Dan Chiu",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 57415,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 24314,
            Name = "Mosiya Okonjo",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 69969,
            YearsOfService = 0,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 24406,
            Name = "Huan Hu",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 71609,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 26241,
            Name = "Raquela Fryman",
            Age = 20,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 17018,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 29648,
            Name = "Hildy Warricker",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 54178,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 30040,
            Name = "Adala Stauss",
            Age = 39,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 46850,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 30834,
            Name = "Alex Fletcher",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 71168,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 32185,
            Name = "Susan Harris",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 12459,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 32225,
            Name = "Edric Ocalan",
            Age = 20,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 21687,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 1
        },
        new()
        {
            Id = 35605,
            Name = "Estefania Orozco",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 10405,
            YearsOfService = 0,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 35776,
            Name = "Marya Holcroft",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 64989,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 37585,
            Name = "Zhen Wei",
            Age = 21,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 42769,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 38179,
            Name = "Hamisi Akunyili",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 17018,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 38537,
            Name = "Hillary Walster",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 85098,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 38567,
            Name = "Karimah Atiyeh",
            Age = 37,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 71666,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 39363,
            Name = "Barbette Cutridge",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 91620,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 41685,
            Name = "Eniola Micheal",
            Age = 26,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 31138,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 44697,
            Name = "Lidya Nasih",
            Age = 35,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 54178,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 45726,
            Name = "Kris Conachie",
            Age = 24,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 41548,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 46357,
            Name = "Rajesh Pai",
            Age = 30,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 35118,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 47808,
            Name = "Raghav Merchant",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 77224,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 48950,
            Name = "Iheoma Belonwu",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 25088,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 49009,
            Name = "Justin Fairbank",
            Age = 26,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 41824,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 49034,
            Name = "Guanyin Liang",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 16111,
            YearsOfService = 0,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 50683,
            Name = "Kamala Sagar",
            Age = 25,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 98817,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 52006,
            Name = "Joshua Tuddall",
            Age = 21,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 71666,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 54956,
            Name = "Isandro Danon",
            Age = 25,
            JobTitle = "Software Developer",
            Department = "Consulting",
            ManagerId = 54178,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 56141,
            Name = "Namrata Kumer",
            Age = 27,
            JobTitle = "Legal Administrator",
            Department = "Legal",
            ManagerId = 61062,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 57793,
            Name = "Li Meng",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 41701,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 61948,
            Name = "Emera Harker",
            Age = 23,
            JobTitle = "Content Designer",
            Department = "Marketing",
            ManagerId = 84047,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 62470,
            Name = "Andrew Robinson",
            Age = 30,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 40978,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 63680,
            Name = "Margot Booth",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 10415,
            YearsOfService = 2,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 70188,
            Name = "Meike Krantz",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 23776,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 71441,
            Name = "Delshad Turabi",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 22570,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 72223,
            Name = "Julie Lee",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Support",
            ManagerId = 72606,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 75083,
            Name = "Leonard Whitewood",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 48107,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 76576,
            Name = "Tadao Asai",
            Age = 31,
            JobTitle = "Software Developer",
            Department = "Support",
            ManagerId = 72606,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 79790,
            Name = "Caitrin Bartolomeu",
            Age = 20,
            JobTitle = "Designer",
            Department = "Design",
            ManagerId = 55608,
            YearsOfService = 2,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 81496,
            Name = "Ceri Bellis",
            Age = 20,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 89037,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 84379,
            Name = "Awni Ashkani",
            Age = 22,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 35920,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 86208,
            Name = "Elizabeth Malone",
            Age = 27,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 62874,
            YearsOfService = 1,
            PayBand = 1,
            OnLeave = 0
        },
        new()
        {
            Id = 86299,
            Name = "Carlo Doherty",
            Age = 24,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 26637,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 88152,
            Name = "Nile Giles",
            Age = 22,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 12095,
            YearsOfService = 0,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 89317,
            Name = "Lottie Hargrave",
            Age = 28,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 33676,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 90939,
            Name = "Rosita Ortiz",
            Age = 23,
            JobTitle = "Junior Software Developer",
            Department = "Consulting",
            ManagerId = 88600,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 91237,
            Name = "Astor Blau",
            Age = 21,
            JobTitle = "UX Designer",
            Department = "Design",
            ManagerId = 56390,
            YearsOfService = 1,
            PayBand = 2,
            OnLeave = 0
        },
        new()
        {
            Id = 91468,
            Name = "Alvinia Whannel",
            Age = 19,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 50053,
            YearsOfService = 1,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 93027,
            Name = "Sam Owolabi",
            Age = 38,
            JobTitle = "Software Developer",
            Department = "Delivery",
            ManagerId = 35118,
            YearsOfService = 2,
            PayBand = 4,
            OnLeave = 0
        },
        new()
        {
            Id = 93142,
            Name = "Magdalena Jakubovics",
            Age = 29,
            JobTitle = "Junior Software Developer",
            Department = "Delivery",
            ManagerId = 79919,
            YearsOfService = 2,
            PayBand = 3,
            OnLeave = 0
        },
        new()
        {
            Id = 93402,
            Name = "Bobby Vize",
            Age = 30,
            JobTitle = "Finance Assistant",
            Department = "Finance",
            ManagerId = 39362,
            YearsOfService = 1,
            PayBand = 4,
            OnLeave = 0
        }
    };
    
    public static readonly List<Employee> AllEmployeesWithIdOrManagerId51708 = new()
    {
        new()
        {
            Id = 12610,
            Name = "Ruth Craig",
            Age = 53,
            JobTitle = "Director",
            Department = "Support",
            ManagerId = 51708,
            YearsOfService = 9,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 45521,
            Name = "Kayin Owayale",
            Age = 50,
            JobTitle = "Director",
            Department = "Delivery",
            ManagerId = 51708,
            YearsOfService = 8,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 48545,
            Name = "Mariele Monnelly",
            Age = 35,
            JobTitle = "Director",
            Department = "Design",
            ManagerId = 51708,
            YearsOfService = 7,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 51708,
            Name = "Jasmine Harding",
            Age = 51,
            JobTitle = "Managing Director",
            Department = null,
            ManagerId = null,
            YearsOfService = 1,
            PayBand = 12,
            OnLeave = 0
        },
        new()
        {
            Id = 56808,
            Name = "Leon Voronov",
            Age = 41,
            JobTitle = "Office Manager",
            Department = "Office Management",
            ManagerId = 51708,
            YearsOfService = 10,
            PayBand = 8,
            OnLeave = 0
        },
        new()
        {
            Id = 91855,
            Name = "Elfreda Burt",
            Age = 41,
            JobTitle = "Director",
            Department = "Consulting",
            ManagerId = 51708,
            YearsOfService = 6,
            PayBand = 12,
            OnLeave = 0
        }
    };

    public static readonly List<string> AllDistinctNonNullDepartments = new()
    {
        "Delivery",
        "Consulting",
        "Support",
        "Marketing",
        "Finance",
        "Design",
        "HR",
        "Sales",
        "IT",
        "Legal",
        "Office Management"
    };

    public static List<Dictionary<string, object>> ConvertEmployeesToDictionaries(List<Employee> employees)
    {
        return new List<Dictionary<string, object>>(employees.Select(ConvertEmployeeToDictionary));
    }

    public static Dictionary<string, object> ConvertEmployeeToDictionary(Employee employee)
    {
        var employeeFields = typeof(Employee).GetProperties();

        return new Dictionary<string, object>(employeeFields.Select(field =>
            new KeyValuePair<string, object>(field.Name.ToSnakeCase(), field.GetValue(employee))));
    }
    
    private static string ToSnakeCase(this string text)
    {
        var builder = new StringBuilder();

        for (var i = 0; i < text.Length; i++)
        {
            var character = text[i];
            
            if (char.IsUpper(character) && i == 0)
            {
                builder.Append(char.ToLowerInvariant(character));
                continue;
            }
            
            if (char.IsUpper(character) && i != 0)
            {
                builder.Append("_" + char.ToLowerInvariant(character));
                continue;
            }

            builder.Append(character);
        }

        return builder.ToString();
    }
}