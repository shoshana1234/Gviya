using GviyaBackend.Controllers;
using GviyaBackend.Models;

namespace GviyaBackend.Components
{
    public static class Data
    {
        public static Resident[] Residents = new[]{
        new Resident{ResidentId=1,IdNumber="999999036",FirstName="David",LastName="Cohen",Age=70},
        new Resident{ResidentId=2,IdNumber="999999231",FirstName="Avraham",LastName="Levi",Age=60},
        new Resident{ResidentId=3,IdNumber="999999079",FirstName="Yisrael",LastName="Cohen",Age=50},
        new Resident{ResidentId=4,IdNumber="999999791",FirstName="Yosef",LastName="Levi",Age=40},
        new Resident{ResidentId=5,IdNumber="999999456",FirstName="Shalom",LastName="Cohen",Age=30},
        new Resident{ResidentId=6,IdNumber="999999876",FirstName="Chaim",LastName="Levi",Age=20},
        new Resident{ResidentId=7,IdNumber="999999064",FirstName="Elazar",LastName="Cohen",Age=35},
    };

        public static Payment[] Payments = new[] {
            new Payment{PaymentId=1, ResidentId=1,Amount=500,Date=new DateTime(2025,1,1)},
            new Payment{PaymentId=2, ResidentId=1,Amount=500,Date=new DateTime(2025,2,1)},
            new Payment{PaymentId=3, ResidentId=1,Amount=500,Date=new DateTime(2025,3,1)},
            new Payment{PaymentId=4, ResidentId=1,Amount=500,Date=new DateTime(2025,4,1)},

            new Payment{PaymentId=5, ResidentId=2,Amount=600,Date=new DateTime(2025,1,1)},
            new Payment{PaymentId=6, ResidentId=2,Amount=500,Date=new DateTime(2025,2,1)},
            new Payment{PaymentId=7, ResidentId=2,Amount=500,Date=new DateTime(2025,3,1)},
            new Payment{PaymentId=8, ResidentId=2,Amount=500,Date=new DateTime(2025,4,1)},

            new Payment{PaymentId=9, ResidentId=3,Amount=500,Date=new DateTime(2025,1,1)},
            new Payment{PaymentId=10, ResidentId=3,Amount=700,Date=new DateTime(2025,2,1)},
            new Payment{PaymentId=11, ResidentId=3,Amount=500,Date=new DateTime(2025,3,1)},
            new Payment{PaymentId=12, ResidentId=3,Amount=500,Date=new DateTime(2025,4,1)}
        };
    }
}
