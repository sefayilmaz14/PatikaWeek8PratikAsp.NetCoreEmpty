using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //MVC servislerinin eklenmesi

var app = builder.Build();

app.UseStaticFiles();// Static dosyalarýn kullanýlmasý için konfügrasyon iþlemi

app.MapControllerRoute( // Routing yapýlandýrýlmasý
    name: "Default",
    pattern: "{controller=Home}/{action=Index}" // Varsayýlan routing konfigürasyonu

    );
app.Run();


/*
 Controller : Kullanýcýdan gelen isteklerin iþlenmesi ve ilgili model ile etkileþime geçip gerekli Viewlerin kullanýcýya gösterilmesini saðlar
Action : Controller'larýn içerisinde bulunan methodlara denir.
Model : Veri yapýlarýný belirten sýnýflardýr.
View : Kullanýcýya ilgili verinin görselleþtirilerek sunulmasýný saðlayan yapýlardýr.
Razor: HTML içerisinde C# komutlarýnýn yazýlmasýný saðlayan bir view engindir.
RazorView: Razor kullanýlan view dosyasýdýr.
wwwroot: Css , JS , görüntü dosyalarý ve diðer static dosyalarýn tutulduðu ve bu dosyalarýn doðrudan web tarayýcýsý ile eriþilebilir hale getirilen klasör
builder.Build(): Uygulamayý inþa eder ve app nesnesini döner. app ile uygulama yapýlandýrýlýr.
app.Run(): Uygulamayý baþlatýr ve gelen istekleri dinler, son olarak uygulamanýn çalýþmasýný saðlar.
*/