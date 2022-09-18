# Programı Çalıştırabilmek İçin
- ### Veri Tabanı Bağlantısı
OperatorMonitor.Data>Context>OperatorDBContext.cs sınıfındaki OnConfiguring metodu altında bulunan 
> optionsBuilder.UseSqlServer(@"[Connection_String]”);

satırındaki **Connection_String** alanı düzenlenmeli. İşlem sonrasında veritabanı komutla migrate edilmeli.
- ### Mail Gönderimi
Proje ilk ayağa kalktığında, program dizinine “settings.ini” belgesi oluşacaktır. Belge içerisindeki alanlar gerekli şekilde doldurulduğunda program, mail gönderebilir duruma gelecektir. Belgedeki “**To**” key’ine “**|**”(Düz çizgi) karakteri ayraç olarak kullanılarak birden fazla mail adresi girilebilir.

## Senaryo
Şirketin belirli bölgelerinde kimlik doğrulama cihazları bulunmaktadır. Bu bölgelerden, doğrulama cihazının özelliğine göre(kart okutma, biyometrik tarama vb.) bir güvenlik taraması yapıldıktan sonra geçilebilmektedir. Her doğrulama işlemi kaydedilmektedir. Şirket içerisindeki bir operatörün bu doğrulama kayıtlarını izlemesi gerekmektedir.

Sistem içerisinde, her get isteğinde bir adet doğrulama logu getiren bir end-point bulunmaktadır. Uygulamanın, bu end-point'e düzenli aralıklarla istek atması ve gelen cevabı görüntülemesi ve veritabanına kaydetmesi gerekmektedir. Eğer dönen log, başarısız bir doğrulama işleminin kaydı ise operatöre bir popup çıkartılmalı ve başarısız geçiş için bir aksiyon belirtmesi istenmelidir. Operatör, ekrandaki geçişi onaylamazsa, tanımlanmış yetkili kişiye bir mail atılmalıdır. Operatör geçişi onayladığında ise end-point'e bir post atılmalıdır. Açılan popup'ın etkileşim süresi 30 saniyedir. 30 saniye içerisinde herhangi bir etkileşim olmadığında, doğrulama işlemi reddedilmiş sayılarak ret aksiyonu uygulanmalı ve popup kapatılmalıdır.

## Yapılması Gerekenler

 - Arayüz için Console, Web ya da Desktop seçilebilir.
 - Sql Server'da bir veri tabanına doğrulama kayıtlanının tutulduğu bir tablo oluşturulmalı.
 - Mail için SMTP kullanılmalı.
 - SMTP bilgileri bir **.ini** belgesinden ya da arayüzdenden alınmalı.
 - Unit test yazılmalı.
 
 ## Servis Bilgileri
Get isteği ile dönen logun **VerifyStatusCode** değeri bir enum'dır ve **0**'dan büyük ise, doğrulama başarısızdır.
