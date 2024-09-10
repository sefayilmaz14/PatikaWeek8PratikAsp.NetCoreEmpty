using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //MVC servislerinin eklenmesi

var app = builder.Build();

app.UseStaticFiles();// Static dosyalar�n kullan�lmas� i�in konf�grasyon i�lemi

app.MapControllerRoute( // Routing yap�land�r�lmas�
    name: "Default",
    pattern: "{controller=Home}/{action=Index}" // Varsay�lan routing konfig�rasyonu

    );
app.Run();


/*
 Controller : Kullan�c�dan gelen isteklerin i�lenmesi ve ilgili model ile etkile�ime ge�ip gerekli Viewlerin kullan�c�ya g�sterilmesini sa�lar
Action : Controller'lar�n i�erisinde bulunan methodlara denir.
Model : Veri yap�lar�n� belirten s�n�flard�r.
View : Kullan�c�ya ilgili verinin g�rselle�tirilerek sunulmas�n� sa�layan yap�lard�r.
Razor: HTML i�erisinde C# komutlar�n�n yaz�lmas�n� sa�layan bir view engindir.
RazorView: Razor kullan�lan view dosyas�d�r.
wwwroot: Css , JS , g�r�nt� dosyalar� ve di�er static dosyalar�n tutuldu�u ve bu dosyalar�n do�rudan web taray�c�s� ile eri�ilebilir hale getirilen klas�r
builder.Build(): Uygulamay� in�a eder ve app nesnesini d�ner. app ile uygulama yap�land�r�l�r.
app.Run(): Uygulamay� ba�lat�r ve gelen istekleri dinler, son olarak uygulaman�n �al��mas�n� sa�lar.
*/