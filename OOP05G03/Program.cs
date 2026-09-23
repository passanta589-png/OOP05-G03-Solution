using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP05G03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01
            //a)هو بس اللي بيتنسخ، يعني المتغيرين بيبقوا باصين على نفس الحاجة ونفس المكان في الذاكرة
            //b)لأ.هو هو نفس الكائن الأصلي، مجرد بقى ليه اسمين
            //c)نسخ المرجع: بننسخ العنوان بس(لو غيّرنا في واحد، التاني بيتغير معاه فوراً).نسخ الكائن: بنعمل نسخة جديدة خالص في مكان تاني في الذاكرة(لو غيّرنا في* واحد، التاني مابيتأثرش)
            #endregion

            #region 02
            //1)بننسخ الكائن من بره بس؛ الحاجات العادية بتتنسخ صح، بس الحاجات المربوطة بكائنات تانية(زي العنوان) بتفضل متشاركة بين الأصل والنسخة
            //2)بننسخ الكائن وكل الحاجات اللي جواه من أصلها؛ فتطلع نسخة مستقلة 100 % ومافيش أي حاجة متشاركة بينهم
            //3)الأصل والنسخة بيفضلوا مربوطين بنفس العنوان. لو عدلت العنوان في النسخة، هيتعدل في الأصل كمان
            ////4)بيتكرر ويتعمل منه عنوان جديد تماماً للنسخة، فما يتأثروش ببعض
            //5)لما نكون عايزين نعمل نسخة من شحنة ونعدل في عنوانها، من غير ما نبوظ العنوان الأصلي للشحنة القديمة
            #endregion

            #region 03
            //1)لساكن(static): نسخة واحدة بس للبرنامج كله، كل الشحنات بتشوفها وبتتشارك فيها(زي عداد الشحنات).العادي(instance): كل شحنة ليها القيمة الخاصة بيها لوحدها(زي اسم العميل أو الوزن)
            //2)هي دالة بنناديها باسم الكلاس على طول من غير ما نعمل كائن(new) وما تقدرش تشوف المتغيرات العادية المباشرة لأنها مش مربوطة بشحنة معينة
            //3)كود بيشتغل مرة واحدة بس أول ما البرنامج يبدأ يتعامل مع الكلاس، عشان يجهز الحاجات الساكنة، وما ينفعش نناديه بإيدينا خالص
            //4)كلاس جواه حاجات static بس (زي أدوات طباعة الفواصل). وما ينفعش نعمل منها كائن بـ new 
            #endregion

            #region 04
            //1)طريقة بنزود بيها ميزة أو دالة جديدة لكلاس جاهز، من غير ما نفتح كود الكلاس الأصلي ونعدل فيه
            //2)this
            //3)جوة كلاس من نوع static
            //4)لأ. بتشوف الحاجات الـ public بس لأنها تعتبر جاية من بره الكلاس
            #endregion

            #region 05
            //1)كلاس واحد بس بنقسم الكود بتاعه على أكثر من ملف لسهولة التنظيم
            //2)عشان يسهل تنظيم الكود، أو عشان لو أكتر من مبرمج شغالين على نفس الكلاس في نفس الوقت ما يعطلوش بعض
            //3)دالة بنكتب اسمها(إعلانها) في ملف، وبنكتب الكود اللي بتنفذه في ملف تاني لنفس الكلاس
            //4)الفيجوال ستوديو بيمسحها خالص وهو بيترجم الكود وما بيديناش أي خطأ(Error) ولا بتأثر على البرنامج
            #endregion

            #region 11
            DeliveryUtilities.PrintSystemTitle("Smart Delivery Management System");

            DeliveryUtilities.PrintSystemTitle("Creating Shipments...");
            Shipment s1 = new Shipment("SH001", "Standard", 3, "Cairo");
            Shipment s2 = new Shipment("SH002", "Express", 2, "Cairo");
            Shipment s3 = new Shipment("SH003", "International", 8, "Cairo");

            Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");

            DeliveryUtilities.PrintSystemTitle("Object Copying");
            Shipment assignedShipment = s1;
            Console.WriteLine($"Original Shipment  : {s1.TrackingCode}");
            Console.WriteLine($"Assigned Shipment  : {assignedShipment.TrackingCode}");
            Console.WriteLine($"Same Object : {ReferenceEquals(s1, assignedShipment)}");

            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Shallow Copy");
            DeliveryUtilities.PrintSeparator();

            Shipment shallowCopy = s1.ShallowCopy();
            Console.WriteLine($"Original Shipment Address : {s1.Address.City}");
            Console.WriteLine($"Copied Shipment Address   : {shallowCopy.Address.City}");

            Console.WriteLine("Changing copied shipment address...");
            shallowCopy.Address.City = "Giza";

            Console.WriteLine($"Original Shipment Address : {s1.Address.City}");
            Console.WriteLine($"Copied Shipment Address   : {shallowCopy.Address.City}");
            Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(s1.Address, shallowCopy.Address)}");

            s1.Address.City = "Cairo";

            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Deep Copy");
            DeliveryUtilities.PrintSeparator();

            Shipment deepCopy = s1.DeepCopy();
            Console.WriteLine($"Original Shipment Address : {s1.Address.City}");
            Console.WriteLine($"Copied Shipment Address   : {deepCopy.Address.City}");

            Console.WriteLine("Changing copied shipment address...");
            deepCopy.Address.City = "Giza";

            Console.WriteLine($"Original Shipment Address : {s1.Address.City}");
            Console.WriteLine($"Copied Shipment Address   : {deepCopy.Address.City}");
            Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(s1.Address, deepCopy.Address)}");

            DeliveryUtilities.PrintSystemTitle("Extension Methods");
            s2.UpdateTrackingStatus("Out For Delivery");
            s3.UpdateTrackingStatus("Delivered");

            Console.WriteLine(s1.GetSummary());
            Console.WriteLine(s2.GetSummary());
            Console.WriteLine(s3.GetSummary());

            Console.WriteLine($"SH001 Is Delivered : {s1.IsDelivered()}");
            Console.WriteLine($"SH003 Is Delivered : {s3.IsDelivered()}");

            DeliveryUtilities.PrintSystemTitle("Assignment Completed");
        }
            #endregion
    }
    
}
