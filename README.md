# Diziler Listesi Uygulaması (Series List Application)

Bu proje, kullanıcıların dizi bilgilerini girmesine olanak tanır, ardından bu dizilerden yalnızca komedi türündeki dizileri seçer ve bu bilgileri sıralayarak görüntüler. Proje, C# programlama dili ve LINQ kullanılarak geliştirilmiştir.

---

## Özellikler (Features)

- **Dizi Ekleme (Add Series):**
  Kullanıcılar konsol üzerinden dizilerin adı, türü, yapım yılı, yayınlanma yılı, yönetmeni ve yayınlandığı ilk platformu gibi bilgileri ekleyebilir.
  
- **Komedi Dizileri Filtreleme (Filter Comedy Series):**
  Diziler arasından yalnızca komedi türünde olanları seçip, yeni bir liste oluşturur.

- **Sıralama (Sorting):**
  Komedi dizileri, önce dizi adı (`Dizi Adı` / `Series Name`), ardından yönetmen adı (`Yönetmen` / `Director`) baz alınarak sıralanır.

- **Listeleme (Listing):**
  Filtrelenmiş ve sıralanmış komedi dizileri, dizi adı, türü ve yönetmeniyle birlikte ekrana yazdırılır.

---

## Kullanım (Usage)

### Gereksinimler (Requirements)

- .NET 6 SDK veya daha üstü
- Visual Studio veya herhangi bir C# IDE'si

### Kurulum (Setup)

1. Bu projeyi indirin veya kopyalayın.
2. `Program.cs` dosyasını bir C# konsol uygulamasına ekleyin.

### Çalıştırma (Run)

1. Projeyi terminal veya IDE üzerinden çalıştırın.
2. Kullanıcıdan dizi bilgilerini girip, her dizi ekledikten sonra yeni bir dizi eklemek isteyip istemediği sorulacaktır.
3. Program sonunda komedi türündeki diziler sıralı bir şekilde görüntülenecektir.

```bash
dotnet run
